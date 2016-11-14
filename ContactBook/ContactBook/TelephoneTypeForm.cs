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
    public partial class TelephoneTypeForm : Form
    {
        public TelephoneTypeForm()
        {
            InitializeComponent();
        }

        private void telephoneTypesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.telephoneTypesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.TelephoneTypes' table. You can move, or remove it, as needed.
            this.telephoneTypesTableAdapter.Fill(this.dataSet1.TelephoneTypes);

        }
    }
}
