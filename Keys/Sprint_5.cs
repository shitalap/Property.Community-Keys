
using Keys.Pages;
using NUnit.Framework;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Design;

namespace Keys.Global
{
    class Sprint_1
    {
        [TestFixture]
        [Category("Sprint_1")]

        class Sprint_1_Administration : Base
        {

            [Test]
            public void ListaRental()
            {
                // creates a toggle for the given test, adds all log events under it 

                test = extent.StartTest("List a Rental");
                Owner_ListARental LRentalobj = new Owner_ListARental();
                LRentalobj.ListRentalPage();     
                LRentalobj.LARSave();
                LRentalobj.LARverify();
                //  test.Log(LogStatus.Pass, "Owner-List A Rental test case passed");
            }

            [Test]
            public void ListAsaRental()
            {
                // creates a toggle for the given test, adds all log events under it 

                test = extent.StartTest("List As a Rental");
                Owner_Properties LasRentalobj = new Owner_Properties();
                LasRentalobj.ListaRentalPage();
                Owner_ListARental LRentalobj = new Owner_ListARental();
                LRentalobj.LARSave();
                LRentalobj.LARverify();
                // test.Log(LogStatus.Pass, "Owner-List As Rental test case passed");
            }

            [Test]
            public void PODBNListing()
            {
                // creates a toggle for the given test, adds all log events under it
                test = extent.StartTest(" ");
                OwnerDashboard LstPODBobj = new OwnerDashboard();
                LstPODBobj.NListingPage();
                Owner_ListARental LRentalobj = new Owner_ListARental();
                LRentalobj.LARSave();
                LRentalobj.LARverify();

            }


            [Test]
            public void ListaRental_invalid()
            {
             // creates a toggle for the given test, adds all log events under it 
                test = extent.StartTest("ListARental_Invalid ");
                Owner_ListARental LRentalobj = new Owner_ListARental();
                LRentalobj.LARInvalid();

                // Screenshot
                String img = SaveScreenShotClass.SaveScreenshot(Driver.driver, "Report");//AddScreenCapture(@"E:\Dropbox\VisualStudio\Projects\Beehive\TestReports\ScreenShots\");
                String screenshot = SaveScreenShotClass.SaveScreenshot(Driver.driver, "ScreenShotPath"); //Add screenshot to report

                 test.Log(LogStatus.Pass, "Image File Name:" + img);
                //test.Log(LogStatus.Info, "ScreenShot: " + test.AddScreenCapture(@"C:\Users\Anyone\Desktop\Keys-2018\Keys\TestReports\*.jpeg"));
                 test.Log(LogStatus.Pass, "ScreenShot:" + test.AddScreenCapture(screenshot));
                 test.Log(LogStatus.Pass, Details: "User cannot save invalid or blank mandatory field on List A Rental Page");
            }

          

            
            //    //Preethi/Reshma Maintenance CRUD
            //    #region Maintenance
            //    //[Test]
            //    //public void Maintenance_AddJob()
            //    //{
            //    //    test = extent.StartTest("Add Job for Property Manager ");
            //    //    Maintenance addjobobj = new Maintenance();
            //    //    addjobobj.AddJob();
            //    //}

            //    //[Test]
            //    //public void Maintenance_EditJob()
            //    //{
            //    //    test = extent.StartTest("Edit Job for Property Manager ");
            //    //    Maintenance jobobj = new Maintenance();
            //    //    jobobj.editjob();
            //    //}
            //    //[Test]
            //    //public void Maintenance_PickJob()
            //    //{
            //    //    test = extent.StartTest("Pick Job for Property Manager ");
            //    //    Maintenance jobobj = new Maintenance();
            //    //    jobobj.pickjob();
            //    //}

            //    //[Test]
            //    //public void Maintenance_JobStatus()
            //    //{
            //    //    test = extent.StartTest("Job Status for Property Manager ");
            //    //    Maintenance jobobj = new Maintenance();
            //    //    jobobj.jobstatus();
            //    //}
            //    ////Janani test
            //    //[Test]
            //    //public void Maintenance_pickJobJanani()
            //    //{
            //    //    test = extent.StartTest("Job Status for Property Manager ");
            //    //    Maintenance jobobj = new Maintenance();
            //    //    jobobj.pickJobJanani();
            //    //}


            //    ////  pickJobJanani
            //    ////Janani Code changes start here
            //    //[Test]
            //    //public void Maintenance_Job_Add()
            //    //{
            //    //    test = extent.StartTest("Add new Job");
            //    //    Maintenance jobAdd = new Maintenance();
            //    //    jobAdd.addNewJob();

            //    //}

            //    //[Test]
            //    //public void Maintenance_View_My_Quote()
            //    //{
            //    //    test = extent.StartTest("Add new Job");
            //    //    Maintenance viewMyQuote = new Maintenance();
            //    //    viewMyQuote.view_my_quote();
            //    //}
            //    ////Delete a new job
            //    ////[Test]
            //    ////public void Job_Delete()
            //    ////{
            //    ////    test = extent.StartTest("Delete added Job");
            //    ////    Maintenance jobAdd = new Maintenance();
            //    ////    jobAdd.delete_job_Open();

            //    ////}

            //    //////Delete a started job
            //    //////Delete a new job
            //    ////[Test]
            //    ////public void Job_Delete_Pending()
            //    ////{
            //    ////    test = extent.StartTest("Delete added Job");
            //    ////    Maintenance jobAdd = new Maintenance();
            //    ////    jobAdd.delete_job_Started();

            //    ////}

            //    ////Janani Code changes end here

            //    //[Test]
            //    //public void Maintenance_AddNewJob()
            //    //{
            //    //    test = extent.StartTest("Check Minimum/Maximum Lenght validation of Job Description field");
            //    //    Maintenance AddNewJob = new Maintenance();
            //    //    AddNewJob.ValidationsOfJobPropertyManager();

            //    //}
            //    //[Test]
            //    //public void Maintenance_DeleteJobFromPropertyManagerTest()
            //    //{
            //    //    test = extent.StartTest("Check delete record from the Maintenance job for Property Manager");
            //    //    Maintenance DeleteRecord = new Maintenance();
            //    //    DeleteRecord.DeleteJobFromMaintenance();
            //    //}
            //    ////Lewis Manage Job Property Manager View Quote
            //    //[Test]
            //    //public void Maintenance_ViewQuote1()
            //    //{
            //    //    test = extent.StartTest("Manage Job for Property Manager View Quote ");
            //    //    Maintenance jobobj = new Maintenance();
            //    //    jobobj.viewquote();
            //    //}
            //    //[Test]
            //    //public void Maintenance_DeletePending()
            //    //{
            //    //    test = extent.StartTest("Manage Job for Property Manager Delete Pending ");
            //    //    Maintenance jobobj = new Maintenance();
            //    //    jobobj.deletePending();
            //    //}
            //    #endregion
            //    //Preethi Admin
            //    #region
            //    [Test]
            //    public void Adminpage()
            //    {
            //        test = extent.StartTest("Admin page navigation");
            //        Admin adminpageobj = new Admin();
            //        adminpageobj.Adminpage();
            //    }
            //    [Test]
            //    public void Admin_Edit()
            //    {

            //        test = extent.StartTest("Editing user details");
            //        Admin editpageobj = new Admin();
            //        editpageobj.Adminpage();
            //        editpageobj.adminedit2();
            //    }
            //    [Test]
            //    public void Admin_Delete()
            //    {
            //        test = extent.StartTest("Deleting user details");
            //        Admin deletepageobj = new Admin();
            //        deletepageobj.Adminpage();
            //        deletepageobj.admindelete();
            //    }
            //    [Test]
            //    public void Adminfieldvalidation()
            //    {
            //        test = extent.StartTest("Field validations");
            //        Admin validationobj = new Admin();
            //        validationobj.Adminpage();

            //        validationobj.adminfieldval();
            //    }
            //    #endregion
            //    //Saranga Add New Property
            //    [Test]
            //    public void AddPropertyTest()
            //    {
            //        test = extent.StartTest("Check with the valid data to all input fields by clicking Submit button Add New Property");
            //        Property AddNew = new Property();
            //        AddNew.AddProperty();
            //    }
            //    #region max character
            //    //[Test]
            //    //public void Property_ValidateMaxlengthOfFields()
            //    //{
            //    //    test = extent.StartTest("Check Maximum length validation of Property Page text fields");
            //    //    Property TextBoxValidation = new Property();
            //    //    TextBoxValidation.CheckMaxCharaterLength();


            //    //}
            //#endregion



            //    [Test]
            //    public void Register_CreateNewUser()
            //    {
            //        // creates a toggle for the given test, adds all log events under it    
            //        test = extent.StartTest("Register New Customer");
            //        Register obj = new Register();
            //        obj.register();

            //    }


            //    //Add Property_DetailValidation()

            //    [Test]
            //    public void AddProperty_DetailValidation()
            //    {
            //        // creates a toggle for the given test, adds all log events under it    
            //        test = extent.StartTest("Check data validation in Add New Property");
            //        //Create Proprty Obj and deletes
            //        Property PObj = new Property();
            //        PObj.PropertyDetailValidation();


            //    }
            //    //Delete a Property

            //    [Test]
            //    public void Property_Delete()
            //    {
            //        // creates a toggle for the given test, adds all log events under it    
            //        test = extent.StartTest("Check whether user able to Delete Property");
            //        //Create Proprty Obj and deletes
            //        Property delobj = new Property();
            //        delobj.DeleteProperty();


            //    }
            //    //Verify Cancel button in Delete Property Func

            //    [Test]
            //    public void Property_Cancel()
            //    {
            //        // creates a toggle for the given test, adds all log events under it    
            //        test = extent.StartTest("Check whether user able to Click Cancel operation in Delete Confirm");
            //        //Create Proprty Obj and deletes
            //        Property PObj = new Property();
            //        PObj.DeleteCancel();


            //    }

            //    //Apply for job with quote in marketplace
            //    [Test]
            //    public void Job_Apply()
            //    {
            //        // creates a toggle for the given test, adds all log events under it    
            //        test = extent.StartTest("Check whether user is able to apply for a job in marketplace");
            //        MarketPlace obj = new MarketPlace();
            //        obj.Apply_Quote_Job();
            //    }

            //    //Property Owner Onboarding
            //    [Test]
            //    public void owner_onboarding()
            //    {
            //        // creates a toggle for the given test, adds all log events under it
            //        test = extent.StartTest("Check whether property owner is able to complete Onboarding process");
            //        PropertyOwner_Onboarding obj = new PropertyOwner_Onboarding();
            //        obj.Property_OwnerOnboard_addtenant();
            //    }
            //    //service supplier onboarding
            //    [Test]

            //    public void servicesupplier_onboarding()
            //    {
            //        // creates a toggle for the given test, adds all log events under it
            //        test = extent.StartTest("Check whether service supplier is able to complete Onboarding process");
            //        ServiceSupplierOnboarding obj = new ServiceSupplierOnboarding();
            //        obj.ServiceProviderEnterAllDetails();
            //    }

            //    //tenant onboarding
            //    [Test]

            //    public void tenant_onboarding()
            //    {
            //        // creates a toggle for the given test, adds all log events under it
            //        test = extent.StartTest("Check whether tenant is able to complete Onboarding process");
            //        TenantOnboarding obj = new TenantOnboarding();
            //        obj.tenantonboard();
            //    }

            //    //add new job
            //    [Test]
            //    public void Addnewjob()
            //    {
            //        // creates a toggle for the given test, adds all log events under it
            //        test = extent.StartTest("Check whether owner is able to add new job to marketplace");
            //        Owners_Job_quotes obj = new Owners_Job_quotes();
            //        obj.Addnewjob();
            //    }

            //    // Service supplier My job 
            //    [Test]
            //    public void Job_Edit()
            //    {
            //        test = extent.StartTest("Check whether service provider able to edit job");
            //        ServiceSupplier ss = new ServiceSupplier();
            //        ss.Edit();
            //    }
            //    // Service supplier My job 
            //    [Test]
            //    public void Job_Detail()
            //    {
            //        test = extent.StartTest("Check whether service provider able to see details");
            //        ServiceSupplier ss = new ServiceSupplier();
            //        ss.MyJobs_detail();

            //    }
            //    // Service supplier My job 
            //    [Test]
            //    public void MyJobEdit_Back()
            //    {
            //        test = extent.StartTest("Check whether service provider able to navigate to previous page");
            //        ServiceSupplier ss = new ServiceSupplier();
            //        ss.EditBack_Button();

            //    }
            //    // Service supplier My job 
            //    [Test]
            //    public void MyJobDetail_Back()
            //    {
            //        test = extent.StartTest("Check whether service provider able to navigate to previous page");
            //        ServiceSupplier ss = new ServiceSupplier();
            //        ss.DetaileditBack_button();
            //    }
            //    // Service supplier My job 
            //    [Test]
            //    public void Job_Edit_InvalidData()
            //    {
            //        test = extent.StartTest("Check whether service provider see validation messages with Invalid Data");
            //        ServiceSupplier ss = new ServiceSupplier();
            //        ss.Edit_InvalidData();
            //    }
            //    // Service supplier My job 
            //    [Test]
            //    public void DetailEditInvalidData()
            //    {
            //        test = extent.StartTest("Check whether service provider see validation messages with Invalid Data");
            //        ServiceSupplier ss = new ServiceSupplier();
            //        ss.DetaileditInvalidData();
            //    }
            //    //Owner Rental Application
            //    //Owner Rental Application-Applications
            //    [Test]
            //    public void RentalApplication_Accept()
            //    {
            //        test = extent.StartTest("check whether owner is able to accept rental application");
            //        Owners_Rental_Applications oo = new Owners_Rental_Applications();
            //        oo.Application_Accept();
            //    }
            //    [Test]
            //    public void RentalApplication_Decline()
            //    {
            //        test = extent.StartTest("check whether owner is able to decline rental application");
            //        Owners_Rental_Applications oo = new Owners_Rental_Applications();
            //        oo.Application_Decline();

            //    }
            //    [Test]
            //    public void RentalApplication_Detail()
            //    {
            //        test = extent.StartTest("check whether owner is able to see detail rental application");
            //        Owners_Rental_Applications oo = new Owners_Rental_Applications();
            //        oo.Application_Detail();
            //    }
            //    [Test]
            //    public void RentalApplication_Edit()
            //    {
            //        test = extent.StartTest("check whether owner is able to edit rental property");
            //        Owners_Rental_Applications oo = new Owners_Rental_Applications();
            //        oo.RentalApplication_Edit(); 

            //    }
            //    // property owner Rental application Search
            //    [Test]
            //    public void RentalApplication_Search()
            //    {
            //        test = extent.StartTest("check if owner is able to search rental application");
            //        Owners_Rental_Applications oo = new Owners_Rental_Applications();
            //        oo.Search();
            //    }
            //    //property owner renatal application sort
            //    [Test]
            //    public void RentalApplication_Sort()
            //    {
            //        test = extent.StartTest("check if owner is able to sort rental application");
            //        Owners_Rental_Applications oo = new Owners_Rental_Applications();
            //        oo.Sort();

            //    }
            //    // owner Add new request 
            //    [Test]
            //    public void Owner_AddNewRequest()
            //    {
            //        test = extent.StartTest("check if owner is able to send new requst");
            //        Owner_AddNewRequest addnewrequest = new Owner_AddNewRequest();
            //        addnewrequest.AddNewRequest();
            //    }

            //    //tenant - Rental application cancel
            //    [Test]
            //    public void Tenant_Rentalapplication_Cancel()
            //    {

            //        test = extent.StartTest("check if owner is able to cancel rental application");
            //        Tenants_My_Rentals tenantrentalapplication = new Tenants_My_Rentals();
            //        tenantrentalapplication.RentalApplication_Cancel();

            //    }
            //    //changing password
            //    [Test]
            //    public void ChangePassword()
            //    {
            //        test = extent.StartTest("check if user is able to change passwrd");
            //        UserProfile user = new UserProfile();
            //        user.ChangePassword();
            //    }
            //    //changing password with Invalid data
            //    [Test]
            //    public void Changepassword_InvalidData()
            //    {
            //        test = extent.StartTest("check if user is able to change passwrd with invalid data");
            //        UserProfile user = new UserProfile();
            //        user.InvalidData_ChangePassword();

            //    }
            //    //edit Owner-My request
            //    [Test]
            //    public void OwnerMyRequest_Edit()
            //    {
            //        test = extent.StartTest("check if user is able to edit request");
            //        Owners_My_Requests request = new Owners_My_Requests();
            //        request.myrequest_Edit();

            //    }
            //    //send new request-Tenant
            //    [Test]
            //    public void Tenant_SendRequest()
            //    {
            //        test = extent.StartTest("check if tenant is able to send new request");
            //        Tenant_Sendnewrequest tenant = new Tenant_Sendnewrequest();
            //        tenant.SendNewRequest();
            //    }
            //    }



        }
    }
}
