using System;
using System.Windows.Forms;

namespace GenerateTicketDoc
{
    public partial class TicketForm : Form
    {
        Ticket t = new Ticket();
        public TicketForm()
        {
            try
            {
                InitializeComponent();
                //Bind Textboxes to Object properties
                Binding ticketBind = new Binding("Text", t, "ticketNumber", true, DataSourceUpdateMode.OnValidation);
                Binding firstNameBind = new Binding("Text", t, "firstName", true, DataSourceUpdateMode.OnValidation);
                Binding lastNameBind = new Binding("Text", t, "lastName", true, DataSourceUpdateMode.OnValidation);
                Binding phoneNumberBind = new Binding("Text", t, "phoneNumber", true, DataSourceUpdateMode.OnValidation);
                Binding departmentBind = new Binding("Text", t, "department", true, DataSourceUpdateMode.OnValidation);
                Binding emailBind = new Binding("Text", t, "eMail", true, DataSourceUpdateMode.OnValidation);
                Binding descriptionBind = new Binding("Text", t, "description", true, DataSourceUpdateMode.OnValidation);
                Binding analystNameBind = new Binding("Text", t, "analystName", true, DataSourceUpdateMode.OnValidation);
                Binding applicationNameBind = new Binding("Text", t, "applicationName", true, DataSourceUpdateMode.OnValidation);
                Binding rollback1Bind = new Binding("Text", t, "rollback1", true, DataSourceUpdateMode.OnValidation);
                Binding rollback2Bind = new Binding("Text", t, "rollback2", true, DataSourceUpdateMode.OnValidation);
                Binding systemAffected1Bind = new Binding("Text", t, "systemAffected1", true, DataSourceUpdateMode.OnValidation);
                Binding systemAffected2Bind = new Binding("Text", t, "systemAffected2", true, DataSourceUpdateMode.OnValidation);
                Binding testingDescBind = new Binding("Text", t, "testingDescription", true, DataSourceUpdateMode.OnValidation);

                //Add Bindings
                txtTicketNumber.DataBindings.Add(ticketBind);
                txtFirstName.DataBindings.Add(firstNameBind);
                txtLastName.DataBindings.Add(lastNameBind);
                txtDepartment.DataBindings.Add(departmentBind);
                txtAnalystName.DataBindings.Add(analystNameBind);
                txtApplicationName.DataBindings.Add(applicationNameBind);
                txtDescription.DataBindings.Add(descriptionBind);
                txtEMail.DataBindings.Add(emailBind);
                txtPhoneNumber.DataBindings.Add(phoneNumberBind);
                txtRollBack1.DataBindings.Add(rollback1Bind);
                txtRollBack2.DataBindings.Add(rollback2Bind);
                txtSystemAffected1.DataBindings.Add(systemAffected1Bind);
                txtSystemAffected2.DataBindings.Add(systemAffected2Bind);
                txtTestingDescription.DataBindings.Add(testingDescBind);
            }
            catch (Exception ex)
            { 
                MessageBox.Show(ex.Message);
            }
            
        }

      
        private void getDocs_Click(object sender, EventArgs e)
        {

            #region    Test Data
            /*
            t.ticketNumber = "78945";
            t.firstName = "Scott";
            t.lastName = "Newton";
            t.phoneNumber = "423-463-3449";
            t.department = "Safety";
            t.eMail = "newsco@covenanttransport.com";
            t.description = "Create Safety Systems Report matching existing excel report.";
            t.analystName = "Bryan Eaton";
            t.applicationName = "SQL";
            t.rollBack1 = "SSRS SVN# 7575";
            t.rollBack2 = "SQL SVN# 7858";
            t.systemAffected1 = "SSRS";
            t.systemAffected2 = "SQL";
            t.testingDescription = "Make Sure Report is running well";
            */
            #endregion 

            try
            {

                var d = new Doc();
                d.createRollBackDoc(t.ticketNumber, t.date, t.systemAffected1, t.systemAffected2, t.rollBack1, t.rollBack2);
                d.createTestingDoc(t.ticketNumber, t.date, t.analystName, t.applicationName, t.description, t.name, t.firstName);
                d.createChangeDoc(t.date, t.ticketNumber, t.department, t.name, t.phoneNumber, t.eMail, t.systemAffected1, t.systemAffected2, t.description);
                MessageBox.Show("Files Created");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
