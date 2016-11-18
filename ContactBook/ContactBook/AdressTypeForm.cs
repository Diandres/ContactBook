using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactBook
{
    public partial class AdressTypeForm : Form
    {
        public AdressTypeForm()
        {
            InitializeComponent();
        }

        private void adressTypesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.adressTypesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void AdressTypeForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.AdressTypes' table. You can move, or remove it, as needed.
            this.adressTypesTableAdapter.Fill(this.dataSet1.AdressTypes);

        }

        private void cmdGoBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Form frm = new Form1();
            frm.Show();
        }
    }
}
