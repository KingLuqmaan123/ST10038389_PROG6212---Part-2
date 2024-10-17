using Microsoft.AspNetCore.Mvc;
using ST10038389_PROG6212___Part_2.Data;
using ST10038389_PROG6212___Part_2.Models;
using Microsoft.EntityFrameworkCore;
using System.IO; 
using System.Threading.Tasks;

namespace ST10038389_PROG6212___Part_2.Controllers
{
    public class ClaimsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _hostingEnvironment;

        public ClaimsController(ApplicationDbContext context, IWebHostEnvironment hostingEnvironment)
        {
            _context = context;
            _hostingEnvironment = hostingEnvironment;
        }

        // GET: Claims
        public IActionResult Index()
        {
            var claims = _context.Claims.ToList(); // Get all claims
            return View(claims); // Pass claims to the view
        }

        // GET: Claims/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Claims/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Claim claim)
        {
            if (ModelState.IsValid)
            {
                // Handle file upload if a document is provided
                if (claim.SupportingDocument != null && claim.SupportingDocument.Length > 0)
                {
                    var uploadsDirectory = Path.Combine(_hostingEnvironment.WebRootPath, "uploads");
                    var filePath = Path.Combine(uploadsDirectory, claim.SupportingDocument.FileName);

                    // Ensure the uploads directory exists
                    if (!Directory.Exists(uploadsDirectory))
                    {
                        Directory.CreateDirectory(uploadsDirectory);
                    }

                    // Save the file to the uploads directory
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await claim.SupportingDocument.CopyToAsync(stream);
                    }

                    // Save the filename to the claim model
                    claim.SupportingDocumentPath = claim.SupportingDocument.FileName;
                }

                _context.Claims.Add(claim); // Add the new claim to the context
                await _context.SaveChangesAsync(); // Save changes asynchronously
                return RedirectToAction("Index"); // Redirect to the Index after successful creation
            }

            return View(claim); // Re-display the form if there are validation errors
        }

        // GET: Claims/Details/{id}
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound(); // Return 404 if no ID is provided
            }

            var claim = await _context.Claims.FirstOrDefaultAsync(m => m.Id == id); // Find claim by ID
            if (claim == null)
            {
                return NotFound(); // Return 404 if the claim is not found
            }

            return View(claim); // Pass the claim to the Details view
        }

        // GET: Claims/Edit/{id}
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound(); // Return 404 if no ID is provided
            }

            var claim = await _context.Claims.FindAsync(id);
            if (claim == null)
            {
                return NotFound(); // Return 404 if the claim is not found
            }

            return View(claim); // Return the Edit view with the claim
        }

        // POST: Claims/Edit/{id}
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Claim claim)
        {
            if (id != claim.Id)
            {
                return NotFound(); 
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(claim); 
                    await _context.SaveChangesAsync(); 
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClaimExists(claim.Id))
                    {
                        return NotFound(); // Handle concurrency issues
                    }
                    else
                    {
                        throw; // Rethrow the exception for further handling
                    }
                }
                return RedirectToAction(nameof(Index)); // Redirect to Index after successful update
            }
            return View(claim); // Re-display the form if there are validation errors
        }

        // GET: Claims/Delete/{id}
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound(); // Return 404 if no ID is provided
            }

            var claim = await _context.Claims.FirstOrDefaultAsync(m => m.Id == id);
            if (claim == null)
            {
                return NotFound(); // Return 404 if the claim is not found
            }

            return View(claim); // Show the delete confirmation page
        }

        // POST: Claims/Delete/{id}
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var claim = await _context.Claims.FindAsync(id);
            if (claim == null)
            {
                return NotFound(); // Return 404 if the claim is not found
            }

            _context.Claims.Remove(claim); // Remove the claim from the context
            await _context.SaveChangesAsync(); // Save changes asynchronously
            return RedirectToAction(nameof(Index)); // Return to Index after deletion
        }

        // GET: Claims/ViewClaims
        public IActionResult ViewClaims()
        {
            var claims = _context.Claims.ToList(); // Get all claims for viewing
            return View(claims); // Pass claims to the view
        }

        // POST: Claims/Approve
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Approve(int id)
        {
            var claim = await _context.Claims.FindAsync(id);
            if (claim == null)
            {
                return NotFound(); // Return 404 if the claim is not found
            }

            claim.Status = "Approved"; // Update the claim status
            _context.Update(claim); // Ensure the entity is being tracked
            await _context.SaveChangesAsync(); // Save changes to the database

            return RedirectToAction(nameof(ViewClaims)); // Redirect to ViewClaims page
        }

        // POST: Claims/Reject
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Reject(int id)
        {
            var claim = await _context.Claims.FindAsync(id);
            if (claim == null)
            {
                return NotFound(); // Return 404 if the claim is not found
            }

            claim.Status = "Rejected"; // Update the claim status
            _context.Update(claim); // Ensure the entity is being tracked
            await _context.SaveChangesAsync(); // Save changes to the database

            return RedirectToAction(nameof(ViewClaims)); // Redirect to ViewClaims page
        }

        // Check if a claim exists
        private bool ClaimExists(int id)
        {
            return _context.Claims.Any(e => e.Id == id); // Check if a claim exists with the given ID
        }
    }
}
//ClaimsController File Handles all the Claims from the Users.
//ClaimsController allows users to input data and store them in the local database.
