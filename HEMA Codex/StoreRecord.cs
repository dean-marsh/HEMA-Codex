using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HEMA_Codex
{
    public partial class StoreRecord : Form

    {

        HEMAdatabase hemaDatabase;

        enum FormState { browse, add, edit };
        FormState formState = FormState.browse;

        private void setState(FormState state)
        {
            switch (state)
            {
                case FormState.browse:
                    formState = FormState.browse;
                    break;
                case FormState.add:
                    formState = FormState.add;
                    break;
                case FormState.edit:
                    formState = FormState.edit;
                    break;
            }
        }


        public StoreRecord()
        {
            InitializeComponent();
            lviewRecord.Columns.Add(new ColumnHeader());
            lviewRecord.Columns[0].Text = "Id";
            lviewRecord.Columns.Add(new ColumnHeader());
            lviewRecord.Columns[1].Text = "Name";
            hemaDatabase = new HEMAdatabase();
            this.refreshList();

        }

        /* Data dictionary set up for record id as key and name as value */
        private void refreshList()
        {
            lviewRecord.Items.Clear();
            Dictionary<string, string> recordList = new Dictionary<string, string>();
            recordList = hemaDatabase.getRecordList();

            foreach (KeyValuePair<string, string> recordItem in recordList)
            {
                ListViewItem lvItem = new ListViewItem(new string[] { recordItem.Key, recordItem.Value });
                lviewRecord.Items.Add(lvItem);
            }
        }

        /* Add New function set up to clear the textbxoes for a new record to be added */
        private void btnAdd_Click(object sender, EventArgs e)
        {
            /* Clears all textboxes for next record to be added */ 
            setState(FormState.add);
            txtName.Text = "";
            txtCountry.Text = "";
            txtSchool.Text = "";
            txtDate.Text = "";
            txtDiscipline.Text = "";
            txtSource.Text = "";
        }

        private string getSelectedId()
        {
            ListView.SelectedListViewItemCollection selectedItem = this.lviewRecord.SelectedItems;
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

        /* Index for selecting and updating the records within the program  */
        private void lviewRecord_SelectedIndexChanged(object sender, EventArgs e)
        {
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
            }
        }

        /* Save & Update Function for list and database */
        private void btnSave_Click(object sender, EventArgs e)
        {
            DatabaseRecord entry = new DatabaseRecord();
            entry.name = txtName.Text;
            entry.country = txtCountry.Text;
            entry.school = txtSchool.Text;
            entry.date = txtDate.Text;
            entry.discipline = txtDiscipline.Text;
            entry.source = txtSource.Text;

            if (formState == FormState.add)
            {

                hemaDatabase.insertRecord(entry);
            }
            else if( formState == FormState.edit)
            {
                string id = getSelectedId();
                if (id != null)
                {
                    hemaDatabase.updateRecord(id, entry);
                }
            }

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
                hemaDatabase.deleteRecord(id);
                this.refreshList();
            }
        }
    }
}
