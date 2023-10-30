2023-10-23 12:38
 A 5.0.NET Application was created for the assignment 2
 i enabled the individual account under the authentication while creating this new project

 12:40
 i went to my launchSettings.json under my properties and comment out //"sslPort": 44321 to enable me have access to my web page

 12:42
 I created a README.txt file to add details about my project

 12:45
 i went to my startup.cs AND TOOK THIS OUT //options => options.SignIn.RequireConfirmedAccount = true

 2023-10-24 2:36
 i updated the database using the Update-Database in the management console

 2:37
 I went through the vires and data folder to get familiar with the files and the contents in it 

 3:10 
 I downloaded the bootstap file and added it to my css folder i already have a bootstap.cs file in my css so instead of deleting it i renamed 
 incase the one i downloaded didnt work i will have that as my backup

 3:13
 i went to my layout.cshtml and i linked the bookstap i downloaded while commenting out the one i have there previously

 3:32
 i also changed the nav class from the navbar-light to navbar-dark and bg-white to bg-primary

 3:36
 i made some changes in my footer in te renderbody function and added some properties which is the text-white-50 bg-primary

 3:39
 in my loginPartial.cshtml i removed the references to text-dark

 2023-10-30 11:35
 I started my project by cleaning and building the project again and everything is working perfectly

 11:42
 in my layout.cshtml page i added the additionL stylesheet and scriptfrom the CSS_LS file provided for us

 11:55
 in my layout.cshtml page i added the additionL stylesheet and scriptfrom the CSS_LS file provided for us

 1:19
 IN MY SHARED LAYOUT.CSHTML FILE I ADDED A DROP DOWN NAVIGATION MENU IMMEDIATELY AFTER MY PRIVACY LINK

 1:28
 i changed this display text from dropdown to content management

 1:29
 I created a new project in my class library i created three new projects in my solution folder
 RobiatsBooksStore.DataAccess,
 RobiatsBooksStore.Models,
 RobiatsBooksStore.Utility
 I copied my data folder in my project and pasted it in my  RobiatsBooksStore.DataAccess and deleted the original data folder from my project

 2:16
 I installed the Microsoft.EntityFrameWork Core.Relational and thhe Core.sqlServer packages 
 successfully installed

 2:18
 I DELETED THE MIGRATION FOLDER IN THE DATA.ACCESS FOLDER

 2:20
 I tried to install the Nuget Package but it was unsuccessful, issue with my namespace

 2:56
 mY ERRORS KEEPS INCRESING BUT I REALISED I DIDNT DOWNLOAD THE MICROSOFT.ASP.NERCORE
 
 5:36
 All errors gone

 5:37
 i changed my namespace in my ApplicationDB.Context to  RobiatsBookStore.DataAccess.Data
5:38 
Moved the models folder into my books.Models and deleted the original one
I added the project reference in my dataAccess folder ,also renamed the models folder to ViewModels

5:40
i changed the ErrorViewModels.cs namespace to the Models.ViewModels and built the project it is working 
in my startup.cs file i have the ApplicationDbContext highlighted in red i clicked on it and it brought out suggestions adding the  .DataAccess.Data as my namespace

5:50
i had errors so i had to remove the RobiatsBookStore .Data i reviewed the browser presentation and everything was working perfectly

5:52
In the Utility project,i crweated a static detailed calss called SD.cs and modified the properties adding the public static i also added project reference in the 
main project sellecting all the three projects  RobiatsBooksStore.DataAccess,
 RobiatsBooksStore.Models,
 RobiatsBooksStore.Utility

 5:55
 in the dataAccess project i added the references to reflect Models and the utility
 i proceeded to add the customer area to the areas but received errors
i meen to make changes where i previously have my  ErrorViewModels to Models.ViewModels i got errors from my startup.cs and the ErrorViewModels i was supposed to 
do that earlier

6:36
it took me some moments to figure out where to change all the defaults but it is done now all errors gone and my customer area is added to my areas
