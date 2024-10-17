# ST10038389_PROG6212 - Part 2
------------------------------
# Updated ReadMe File:
----------------------
Feedback changes from Part1 to Part2:
•	Updated the GUI Application.
•	Updated Error Handling to handle users’ data in case the user entered his details incorrectly, the program will output an error message or in the input fields.
•	Updated Content of the Application.
•	Updated the Styling of the Web Application.
•	Updated the Colour Scheme.
•	Added more detail to the Home Page.
•	Added a new Page called, Contact Us page. 
•	The Contact Us page views all the business inquiries and contact details.
•	Changed the Privacy Policy page to About Us page.
•	Added more functionality to interact with on the Application. 
•	Updated the Login Form page.
•	Updated the Dashboard page.
------------------------------------------------------------------------------
URL Link of Web Application Running Locally:
--------------------------------------------
https://localhost:7220/
--------------------------------------------------
GitHub Link of Web Application:
--------------------------------
https://github.com/KingLuqmaan123/ST10038389_PROG6212---Part-2
----------------------------------------------------------------

Screenshots of Updated GUI Web Application:
-------------------------------------------
1.Screenshot of Home Page:
--------------------------
![image](https://github.com/user-attachments/assets/a6164960-147b-4474-b647-8993a28331f8)

2.Screenshot of Privacy Policy Page converted to About Us Page:
---------------------------------------------------------------
![image](https://github.com/user-attachments/assets/83077209-eceb-483d-9a47-fbd474d32c74)

3.Screenshot of Login Form Page:
--------------------------------
![image](https://github.com/user-attachments/assets/d8c520b7-c39a-4e65-bde4-4bb80628080f)

4.Screenshot of Create a Claim Page:
------------------------------------
•	On this Page, The User will enter details in the input fields, after he clicked on Submit Claim Button, it will send this data through to the Database to store in a Table and when I go to the View Claims Page, the data will be viewed in a Table Form.
![image](https://github.com/user-attachments/assets/fc37a63e-d7ea-4510-b84e-f56ff621ee30)


5.Screenshot of View Claims Page:
---------------------------------
![image](https://github.com/user-attachments/assets/cf464d04-d223-42b5-ae68-3867d506188e)

6.Screenshot of Dashboard Page:
-------------------------------
![image](https://github.com/user-attachments/assets/495bcf2c-1c71-43ba-aab8-850d2650ef56)

7.Screenshot of Contact Us Page:
--------------------------------
![image](https://github.com/user-attachments/assets/3d3dec32-4d0c-4e47-918d-c2857e269b25)

Screenshots of Unit Testing:
----------------------------
1.ClaimService.cs – Unit Testing:
---------------------------------
![image](https://github.com/user-attachments/assets/1c8f699d-d66b-473b-afae-c2702fa32e39)

2.ClaimServiceTests.cs - Unit Testing:
--------------------------------------
![image](https://github.com/user-attachments/assets/e40b245a-42af-48dc-97b8-56e6bb758d9f)

Screenshots of Database:
------------------------
Screenshots of Local Database:
------------------------------
![image](https://github.com/user-attachments/assets/504336aa-da80-487b-8c1b-9e7325d15b01)

Screenshot of Database Table:
-----------------------------
![image](https://github.com/user-attachments/assets/e0143497-2969-41e6-a803-ceb2a9769e8f)
![image](https://github.com/user-attachments/assets/996bc495-d025-4bfe-99fb-61321ad17c45)
![image](https://github.com/user-attachments/assets/6c984297-b3e1-4633-8c7b-7cb93bb52fc3)

Screenshot of Source Code in GitHub:
-------------------------------------
![image](https://github.com/user-attachments/assets/ce60cb5b-27a4-4962-832b-eef155431f5e)

Screenshots of (5 Commits) created in GitHub:
Screenshot of Commit 1:
Updated the Comments in ClaimsService File:
----------------------------------------------
![image](https://github.com/user-attachments/assets/38f82656-97be-4c68-afaf-9f283794fdb9)

Screenshot of Commit 2:
Updated the Comments in ClaimsServiceTests File:
-------------------------------------------------
![image](https://github.com/user-attachments/assets/10dba7cf-dda9-4fa9-8958-d0b32385824d)

Screenshot of Commit 3:
Updated the Comments in ClaimsController File:
----------------------------------------------
![image](https://github.com/user-attachments/assets/86edaf50-45af-45b8-8734-91cb0f3daf38)

Screenshot of Commit 4:
Updated the Index Page/Home Page:
---------------------------------
![image](https://github.com/user-attachments/assets/49e19e6f-d765-4900-b48a-f6ba714f99b2)

Screenshot of Commit 5:
Updated the Code in ViewClaims Page:
-------------------------------------
![image](https://github.com/user-attachments/assets/bd9beedb-c8d0-4075-abc1-21515de47a79)

Screenshot of all Commits Created:
----------------------------------
![image](https://github.com/user-attachments/assets/4fc7d879-bc53-4eb9-abce-793b2873d427)

Explain How to the User OR Marker how to run your local Database:
--------------------------------------------------------------------
•	Open Visual Studio.
•	Open your MVC Project.
•	Click on “View”.
•	Scroll down till you see “SQL Server Object Explorer”.
•	Click it.
•	It will then open the SQL Server Object Explorer, and you can see your Local Database Server.
•	Right-click on the local Database and click on Properties to view the Connection string.
•	Go back to the explorer in the SQL Server, Open the Folder Database, open system databases, then open master file, then open Tables Folder. 
•	You will then see your dbo.Claims database where it stores all the user's data from the web application.
•	If you right click on “dbo.Claims” and click view designer, it will show you the design interface or SQL code of this Table.

How to Update the Database and its Migrations:
------------------------------------------------
•	To Update the Database, Go to Tools in the top panel of the project, scroll down to NuGet Package Manager and hover over it and another panel will open and click on Package manager console to run the commands to and update the database every time you update the claims model codes or your controller’s code.





