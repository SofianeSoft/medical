using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void patientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.patientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.medicalDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'medicalDataSet.patient' table. You can move, or remove it, as needed.
            this.patientTableAdapter.Fill(this.medicalDataSet.patient);

        }

        private void nomLabel_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {

        }

        private void patientDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
            switch (e.ColumnIndex)
            {
                case 5:
                    MessageBox.Show("edit row");
                    break;
                case 6:
                    MessageBox.Show("delete row");
                    break;
            }
        }

        private void patientDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
