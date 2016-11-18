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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }      

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet11.TelephoneTypes' table. You can move, or remove it, as needed.
            this.telephoneTypesTableAdapter.Fill(this.dataSet11.TelephoneTypes);
            // TODO: This line of code loads data into the 'dataSet11.AdressTypes' table. You can move, or remove it, as needed.
            this.adressTypesTableAdapter.Fill(this.dataSet11.AdressTypes);
            this.contactsTableAdapter.Fill(this.dataSet1.Contacts);

            contactsDataGridView.Columns[0].Visible = false;
        }

        private void contactsDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            using (var context = new ContactBoockContext())
            {
                //Getting Contacts PhoneNumbers And Adresses
                if (contactsDataGridView.SelectedRows.Count > 0)
                {
                    var selectedID = int.Parse(contactsDataGridView.SelectedRows[0].Cells[0].Value.ToString());
                    if (selectedID > 0)
                    {
                        //Find Contacts Adresses

                        BindingSource biAdress = new BindingSource();
                        BindingSource biPhones = new BindingSource();

                        var selectedAdress = context.ContactAdresses.Where(data => data.ContactID == selectedID).Select(data => data.Adress).ToList();

                        biAdress.DataSource = (from a in context.ContactAdresses
                                               join t in context.AdressTypes on a.AdressTypeID equals t.AdressTypeID
                                               where a.ContactID == selectedID
                                               select new { AddressType = t.AdressTypeName, Address = a.Adress, TypeID=a.AdressTypeID, a.ContactAdressID }).ToList();
                        
                        DgvAdresses.DataSource = biAdress;
                        DgvAdresses.Columns[2].Visible = false;
                        DgvAdresses.Columns[3].Visible = false;
                        if (biAdress.Count > 0)
                        {
                            DgvAdresses.CurrentCell = DgvAdresses.Rows[0].Cells[0];
                        }

                        //Find Contacts TelephoneNumbers

                        biPhones.DataSource = (from a in context.ContactTelephoneNumbers
                                               join t in context.TelephoneTypes on a.TelephoneTypeID equals t.TelephoneTypeID
                                               where a.ContactID == selectedID
                                               select new { Type = t.TelephoneTypeName, Number = a.TelefonNumber, TypeID=a.TelephoneTypeID, a.ContactTelephoneNumberID}).ToList();

                        DgvPhones.DataSource = biPhones;
                        DgvPhones.Columns[2].Visible = false;
                        DgvPhones.Columns[3].Visible = false;

                    }
                    else
                    {
                        DgvAdresses.DataSource = null;
                        DgvPhones.DataSource = null;
                    }

                }
            }
        }

        private void cmdSaveAdress_Click(object sender, EventArgs e)
        {
            using (var context = new ContactBoockContext())
            {
                var selectedID = int.Parse(contactsDataGridView.SelectedRows[0].Cells[0].Value.ToString());
                if (selectedID > 0)
                {
                    var selectedAdress = context.ContactAdresses.Where(data => data.ContactID == selectedID).Select(data => data.Adress).ToList();

                    ContactAdress ContactToAdd = new ContactAdress();
                    ContactToAdd.ContactID = selectedID;
                    ContactToAdd.Adress = txtAdress.Text;
                    ContactToAdd.AdressTypeID = (int)cbTypeOfAdress.SelectedValue;
                    context.ContactAdresses.Add(ContactToAdd);
                    context.SaveChanges();
                    contactsDataGridView_SelectionChanged(null, null);
                    isEnableAdress(false);
                }
            }
        }

        private void DgvAdresses_SelectionChanged(object sender, EventArgs e)
        {
            if (DgvAdresses.SelectedCells.Count > 0)
            {
                if (DgvAdresses.SelectedCells.Count <= 0)
                {
                    DgvAdresses.CurrentCell = DgvAdresses.Rows[0].Cells[0];
                }
                else
                {
                    try
                    {
                        var SelectedAdress = DgvAdresses.SelectedRows[0].Cells[1].Value.ToString();
                        txtAdress.Text = SelectedAdress;
                        var SelectedType = int.Parse(DgvAdresses.SelectedRows[0].Cells[2].Value.ToString());
                        cbTypeOfAdress.SelectedValue = SelectedType;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Unable to get the record. There might be a blank cell. ", "Error Addresses", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtAdress.Clear();
                        cbTypeOfAdress.SelectedIndex = -1;
                        cbTypeOfAdress.Text = "Select a Type";
                    }                    
                }
            }
            else
            {
                txtAdress.Clear();
                cbTypeOfAdress.SelectedIndex = -1;
                cbTypeOfAdress.Text = "Select a Type";
            }
        }

        private void cmdNewAdress_Click(object sender, EventArgs e)
        {
            cbTypeOfAdress.SelectedIndex = -1;
            cbTypeOfAdress.Text = "Select a Type";
            txtAdress.Clear();
            isEnableAdress(true);
        }

        private void cmdEditAdress_Click(object sender, EventArgs e)
        {
            var SelectedAdress = DgvAdresses.SelectedRows[0].Cells[1].Value.ToString();
            txtAdress.Text = SelectedAdress;
            var SelectedType = int.Parse(DgvAdresses.SelectedRows[0].Cells[2].Value.ToString());
            cbTypeOfAdress.SelectedValue = SelectedType;
            isEnableAdress(true);
        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            var selectedID = int.Parse(DgvAdresses.SelectedRows[0].Cells[3].Value.ToString());
            using (var context = new ContactBoockContext())
            {
                ContactAdress AddressToDelete = (ContactAdress)(from data in context.ContactAdresses
                                      where data.ContactAdressID == selectedID
                                      select data).First();                
                context.ContactAdresses.Remove(AddressToDelete);
                context.SaveChanges();
                contactsDataGridView_SelectionChanged(null,null);
                isEnableAdress(false);


            }
        }
        public void isEnableAdress(bool enable)
        {
            
            cmdSaveAdress.Enabled = enable;
            cmdCancelAdress.Enabled = enable;
            txtAdress.Enabled = enable;
            cbTypeOfAdress.Enabled = enable;

            cmdDeleteAdress.Enabled = !enable;
            cmdEditAdress.Enabled = !enable;
            cmdNewAdress.Enabled = !enable;
            DgvAdresses.Enabled = !enable;
            DgvPhones.Enabled = !enable;
            contactsDataGridView.Enabled = !enable;
            groupBox2.Enabled = !enable;
            contactsBindingNavigator.Enabled = !enable;
        }
        public void isEnableNumber(bool enable)
        {
            cmdSaveNumber.Enabled = enable;
            cmdCancelNumber.Enabled = enable;
            txtPhoneNumber.Enabled = enable;
            cbTypeOfPhones.Enabled = enable;

            cmdDeleteNumber.Enabled = !enable;
            cmdEditNumber.Enabled = !enable;
            cmdNewNumber.Enabled = !enable;
            DgvAdresses.Enabled = !enable;
            DgvPhones.Enabled = !enable;
            contactsDataGridView.Enabled = !enable;
            groupBox1.Enabled = !enable;
            contactsBindingNavigator.Enabled = !enable;

        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            isEnableAdress(false);
        }

        private void DgvPhones_SelectionChanged(object sender, EventArgs e)
        {
            if (DgvPhones.SelectedCells.Count > 0)
            {
                if (DgvPhones.SelectedCells.Count <= 0)
                {
                    DgvPhones.CurrentCell = DgvPhones.Rows[0].Cells[0];
                }
                else
                {
                    try
                    {
                        var SelectedPhone = DgvPhones.SelectedRows[0].Cells[1].Value.ToString();
                        txtPhoneNumber.Text = SelectedPhone;
                        var SelectedType = int.Parse(DgvPhones.SelectedRows[0].Cells[2].Value.ToString());
                        cbTypeOfPhones.SelectedValue = SelectedType;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Unable to get the record. There might be a blank cell. ", "Error Phone Numbers", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtAdress.Clear();
                        cbTypeOfPhones.SelectedIndex = -1;
                        cbTypeOfPhones.Text = "Select a Type";
                    }
                }
            }
            else
            {
                txtPhoneNumber.Clear();
                cbTypeOfPhones.SelectedIndex = -1;
                cbTypeOfPhones.Text = "Select a Type";
            }
        }

        private void cmdNewNumber_Click(object sender, EventArgs e)
        {
            cbTypeOfPhones.SelectedIndex = -1;
            cbTypeOfPhones.Text = "Select a Type";
            txtPhoneNumber.Clear();
            isEnableNumber(true);
        }

        private void cmdEditNumber_Click(object sender, EventArgs e)
        {
            var SelectNumber = DgvPhones.SelectedRows[0].Cells[1].Value.ToString();
            txtPhoneNumber.Text = SelectNumber;
            var SelectedType = int.Parse(DgvPhones.SelectedRows[0].Cells[2].Value.ToString());
            cbTypeOfPhones.SelectedValue = SelectedType;
            isEnableNumber(true);
        }

        private void cmdSaveNumber_Click(object sender, EventArgs e)
        {
            using (var context = new ContactBoockContext())
            {
                var selectedID = int.Parse(contactsDataGridView.SelectedRows[0].Cells[0].Value.ToString());
                if (selectedID > 0)
                {
                    var SelectNumber = context.ContactAdresses.Where(data => data.ContactID == selectedID).Select(data => data.Adress).ToList();

                    ContactTelephoneNumber PhoneNumberToAdd = new ContactTelephoneNumber();
                    PhoneNumberToAdd.ContactID = selectedID;
                    PhoneNumberToAdd.TelefonNumber = txtAdress.Text;
                    PhoneNumberToAdd.TelephoneTypeID = (int)cbTypeOfAdress.SelectedValue;
                    context.ContactTelephoneNumbers.Add(PhoneNumberToAdd);
                    context.SaveChanges();
                    contactsDataGridView_SelectionChanged(null, null);
                    isEnableNumber(false);
                }
            }
        }

        private void cmdCancelNumber_Click(object sender, EventArgs e)
        {
            isEnableNumber(false);
        }

        private void cmdDeleteNumber_Click(object sender, EventArgs e)
        {
            var selectedID = int.Parse(DgvPhones.SelectedRows[0].Cells[3].Value.ToString());
            using (var context = new ContactBoockContext())
            {
                ContactTelephoneNumber NumberToDelete = (ContactTelephoneNumber)(from data in context.ContactTelephoneNumbers
                                                                where data.ContactTelephoneNumberID == selectedID
                                                                select data).First();
                context.ContactTelephoneNumbers.Remove(NumberToDelete);
                context.SaveChanges();
                contactsDataGridView_SelectionChanged(null, null);
                isEnableAdress(false);


            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
            bindingNavigatorAddNewItem.Enabled = false;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dont FORGET to save, to cmplete deletion of Contact");
        }
        private void contactsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.contactsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);
            groupBox1.Enabled = true;
            groupBox2.Enabled = true;
            bindingNavigatorAddNewItem.Enabled = true;
            Form1_Load(null, null);
        }

        private void cmdAddNewTypeAddress_Click(object sender, EventArgs e)
        {
            Form frm = new TelephoneTypeForm();
            frm.Show();
            this.Hide();
            
        }

        private void cmdAddNewTypeNumber_Click(object sender, EventArgs e)
        {
            Form frm = new AdressTypeForm();
            frm.Show();
            this.Hide();
           
        }
    }
}
