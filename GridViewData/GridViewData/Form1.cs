using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GridViewData
{
    public partial class FrmGridView : Form
    {
        /*This is a simple and basic datagridview project*/
        /*Use public DataTable*/
        public DataTable studentInfo;
        public FrmGridView()
        {
            InitializeComponent();
        }

        private void FrmGridView_Load(object sender, EventArgs e)
        {
            /*Create a variable for DataTable*/
            studentInfo = new DataTable("studentInfo");

            /*Add Data Columns for each title*/
            DataColumn stu_name = new DataColumn("Name", typeof(string));
            studentInfo.Columns.Add(stu_name);

            DataColumn stu_age = new DataColumn("Age", typeof(Int32));
            studentInfo.Columns.Add(stu_age);

            DataColumn stu_city = new DataColumn("City", typeof(string));
            studentInfo.Columns.Add(stu_city);

            /*Path to DataSource*/
            dtgridview1.DataSource = studentInfo;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            /*Get inputs*/
            string name = txtName.Text;
            string age = txtAge.Text;
            string city = txtCity.Text;
            /*Add data to DataTable*/
            studentInfo.Rows.Add(name, age, city);
            /*Clear all textboxes data*/
            txtName.Clear();
            txtAge.Clear();
            txtCity.Clear();

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            /*Delete selected row data*/
            int index = dtgridview1.SelectedRows[0].Index;
            if (index >= 0) {
                studentInfo.Rows[index].Delete();
            }
        }
    }
}
