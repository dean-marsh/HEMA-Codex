/* Dean Marsh HND Software Development */
/* HEMA Codex Project - Graded Unit 2 */
/* Main code for Windows Form Storerecord in Application */
/* Coding of the UI Domain for application */ 


/* Libaries used in program */
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HEMA_Codex
{
    public partial class StoreRecord : Form

    {

        HEMAdatabase hemaDatabase;

        /* Setting form states for UI interaction */
        enum FormState { browse, add, edit };
        FormState formState = FormState.browse;

        /* Function set up for the Application form state */
        private void setState(FormState state)
        {
            switch (state)
            {
                /* Browse is the default form state which the application will run on*/
                case FormState.browse:
                    formState = FormState.browse;
                    btnCancel.Enabled = false;
                    btnSave.Enabled = false;
                    btnDelete.Enabled = true;
                    btnAdd.Enabled = true;
                    getSelectedRecord();
                    break;

                /* Form state changes to add when the user clicks the New button */
                case FormState.add:
                    formState = FormState.add;
                    btnCancel.Enabled = true;
                    btnSave.Enabled = true;
                    btnDelete.Enabled = false;
                    btnAdd.Enabled = false;
                    txtName.Text = "";
                    txtCountry.Text = "";
                    txtSchool.Text = "";
                    txtDate.Text = "";
                    txtDiscipline.Text = "";
                    txtSource.Text = "";
                    txtAdditionalInfo.Text = "";
                    lblidvalue.Text = "** New Record **";
                    txtName.Focus();
                    break;

                /* Form state edit enables the save button to be clicked
                * if existing record is selected */
                case FormState.edit:
                    formState = FormState.edit;
                    btnCancel.Enabled = true;
                    btnSave.Enabled = true;
                    btnDelete.Enabled = false;
                    btnAdd.Enabled = false;
                    break;
            }
        }


        public StoreRecord()
        {
            InitializeComponent();

            /* Columns defined for the list view box */
            listViewRecord.Columns.Add(new ColumnHeader());
            listViewRecord.Columns[0].Text = "Id";
            listViewRecord.Columns.Add(new ColumnHeader());
            listViewRecord.Columns[1].Text = "Name";

            /* Event Handler if the text is changed from an existing record */ 
            txtName.KeyDown += new KeyEventHandler(recordEdited);
            txtCountry.KeyDown += new KeyEventHandler(recordEdited);
            txtSchool.KeyDown += new KeyEventHandler(recordEdited);
            txtDate.KeyDown += new KeyEventHandler(recordEdited);
            txtDiscipline.KeyDown += new KeyEventHandler(recordEdited);
            txtSource.KeyDown += new KeyEventHandler(recordEdited);
            txtAdditionalInfo.KeyDown += new KeyEventHandler(recordEdited);

            /* Error Handler */
            try {
                hemaDatabase = new HEMAdatabase();
                this.refreshList();
            } catch (Exception ex) {
                /* Failed to connect to database, user message displayed */
                MessageBox.Show(ex.ToString());
            }
        }


        /* Changes the default state of the Form from Browse to Edit */ 
        private void recordEdited(object sender, System.EventArgs e)
        {
            if ((formState == FormState.browse) && (getSelectedId()!=null))
            {
                setState(FormState.edit);
            }
        }

        /* Data dictionary set up for record id as key and name as value */
        private void refreshList()
        {
            /* Refreshes the list to display the current IDs and Names in the database */
            listViewRecord.Items.Clear();
            Dictionary<string, string> recordList = new Dictionary<string, string>();
            recordList = hemaDatabase.getRecordList();

            foreach (KeyValuePair<string, string> recordItem in recordList)
            {
                ListViewItem lvItem = new ListViewItem(new string[] { recordItem.Key, recordItem.Value });
                listViewRecord.Items.Add(lvItem);
            }
        }

        /* Add New function set up to clear the textbxoes for a new record to be added */
        private void btnAdd_Click(object sender, EventArgs e)
        {
            /* Clears all textboxes for next record to be added */ 
            setState(FormState.add);
        }

        /* Returns the information of the selected ID */
        private string getSelectedId()
        {
            ListView.SelectedListViewItemCollection selectedItem = this.listViewRecord.SelectedItems;
            string selectedId = null;

            /* If statement to check that ID exists and that ID can be printed*/
            if (selectedItem.Count > 0)
            {
                foreach (ListViewItem item in selectedItem)
                {
                    selectedId = item.SubItems[0].Text;
                }
            }
            return selectedId;
        }

        /* Function for returning information back from a selected record to the textboxes */ 
        private void getSelectedRecord()
        {
            /* Checks that the ID exists to retreive the record */
            string id = getSelectedId();
            if (id != null)
            {
                /* Returns information from table codex in DatabaseRecord entry to text boxes */
                DatabaseRecord entry = new DatabaseRecord();
                entry = hemaDatabase.getRecord(id);
                txtName.Text = entry.name;
                txtCountry.Text = entry.country;
                txtSchool.Text = entry.school;
                txtDate.Text = entry.date;
                txtDiscipline.Text = entry.discipline;
                txtSource.Text = entry.source;
                txtAdditionalInfo.Text = entry.additionalinfo;
                lblidvalue.Text = id;
            } 
        }

        /* Index for selecting and updating the records within the program  */
        private void lviewRecord_SelectedIndexChanged(object sender, EventArgs e)
        {
            getSelectedRecord();
        }

        /* Save Function for list and database, to include new entries and updating existing ones */
        private void btnSave_Click(object sender, EventArgs e)
        {
            /* Takes the information from the texts boxs and adds them to the entry*/
            DatabaseRecord entry = new DatabaseRecord();
            entry.name = txtName.Text;
            entry.country = txtCountry.Text;
            entry.school = txtSchool.Text;
            entry.date = txtDate.Text;
            entry.discipline = txtDiscipline.Text;
            entry.source = txtSource.Text;
            entry.additionalinfo = txtAdditionalInfo.Text;
       

            /* If the form state is set to add then they information to entry is added as a new record */
            if (formState == FormState.add)
            {
                hemaDatabase.insertRecord(entry);
            }

            /* Else if it the form state is in edit then exists the existing record that has been selected */
            else if( formState == FormState.edit)
            {
                string id = getSelectedId();
                if (id != null)
                {
                    hemaDatabase.updateRecord(id, entry);
                    this.refreshList();
                }
            }

            /* Refreshes the list view box  and returns form state back to browse*/
            this.refreshList();
            setState(FormState.browse);
        }


        /* Delete function from List View and Database */
        private void btnDelete_Click(object sender, EventArgs e)
        {

            /* defines the ID as string and equal to the selected ID */
            /* If statement to make sure */
            string id = getSelectedId();
            if (id != null)
            {

                /* Dialog Box and buttons to display to confirm if the user does wish to confirm the deletion */
                DialogResult result = MessageBox.Show("Are you sure you wish to delete this entry?", "Confirmation", MessageBoxButtons.YesNo);

                /* If the result is yes then record is deleted */
                if (result == DialogResult.Yes)
                {
                    hemaDatabase.deleteRecord(id);
                    this.refreshList();
                    MessageBox.Show("Entry has been succesfully deleted.");
                }

                /* Does nothing if no is clicked */
                else if (result == DialogResult.No)
                {
                    /* Do Nothing */
                }
            }
            
            /* Clears all textboxes of the deleted record fields */
            txtName.Text = "";
            txtCountry.Text = "";
            txtSchool.Text = "";
            txtDate.Text = "";
            txtDiscipline.Text = "";
            txtSource.Text = "";
            txtAdditionalInfo.Text = "";
            lblidvalue.Text = "...";
        }


        /* Cancel function for if the user wishes to cancel adding their new entry.  */
        private void btnCancel_Click(object sender, EventArgs e)
        {
            /* Sets the form state back to browse */
            setState(FormState.browse);
        }
    }
}
