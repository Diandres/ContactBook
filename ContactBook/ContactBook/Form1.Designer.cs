namespace ContactBook
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataSet1 = new ContactBook.DataSet1();
            this.contactsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contactsTableAdapter = new ContactBook.DataSet1TableAdapters.ContactsTableAdapter();
            this.tableAdapterManager = new ContactBook.DataSet1TableAdapters.TableAdapterManager();
            this.contactTelephoneNumbersTableAdapter = new ContactBook.DataSet1TableAdapters.ContactTelephoneNumbersTableAdapter();
            this.telephoneTypesTableAdapter = new ContactBook.DataSet1TableAdapters.TelephoneTypesTableAdapter();
            this.contactsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.contactsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.contactsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactTelephoneNumbersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.telephoneTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DgvAdresses = new System.Windows.Forms.DataGridView();
            this.DgvPhones = new System.Windows.Forms.DataGridView();
            this.cmdSaveAdress = new System.Windows.Forms.Button();
            this.cmdNewAdress = new System.Windows.Forms.Button();
            this.cbTypeOfAdress = new System.Windows.Forms.ComboBox();
            this.adressTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet11 = new ContactBook.DataSet1();
            this.adressTypesTableAdapter = new ContactBook.DataSet1TableAdapters.AdressTypesTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbTypeOfPhones = new System.Windows.Forms.ComboBox();
            this.telephoneTypesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.cmdNewNumber = new System.Windows.Forms.Button();
            this.cmdSaveNumber = new System.Windows.Forms.Button();
            this.cmdEditAdress = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdCancelAdress = new System.Windows.Forms.Button();
            this.cmdDeleteAdress = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmdCancelNumber = new System.Windows.Forms.Button();
            this.cmdDeleteNumber = new System.Windows.Forms.Button();
            this.cmdEditNumber = new System.Windows.Forms.Button();
            this.cmdAddNewTypeAddress = new System.Windows.Forms.Label();
            this.cmdAddNewTypeNumber = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactsBindingNavigator)).BeginInit();
            this.contactsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contactsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactTelephoneNumbersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telephoneTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAdresses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPhones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adressTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telephoneTypesBindingSource1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contactsBindingSource
            // 
            this.contactsBindingSource.DataMember = "Contacts";
            this.contactsBindingSource.DataSource = this.dataSet1;
            // 
            // contactsTableAdapter
            // 
            this.contactsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.@__MigrationHistoryTableAdapter = null;
            this.tableAdapterManager.AdressTypesTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ContactAdressesTableAdapter = null;
            this.tableAdapterManager.ContactsTableAdapter = this.contactsTableAdapter;
            this.tableAdapterManager.ContactTelephoneNumbersTableAdapter = this.contactTelephoneNumbersTableAdapter;
            this.tableAdapterManager.TelephoneTypesTableAdapter = this.telephoneTypesTableAdapter;
            this.tableAdapterManager.UpdateOrder = ContactBook.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // contactTelephoneNumbersTableAdapter
            // 
            this.contactTelephoneNumbersTableAdapter.ClearBeforeFill = true;
            // 
            // telephoneTypesTableAdapter
            // 
            this.telephoneTypesTableAdapter.ClearBeforeFill = true;
            // 
            // contactsBindingNavigator
            // 
            this.contactsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.contactsBindingNavigator.BindingSource = this.contactsBindingSource;
            this.contactsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.contactsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.contactsBindingNavigator.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.contactsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.contactsBindingNavigatorSaveItem});
            this.contactsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.contactsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.contactsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.contactsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.contactsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.contactsBindingNavigator.Name = "contactsBindingNavigator";
            this.contactsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.contactsBindingNavigator.Size = new System.Drawing.Size(2264, 47);
            this.contactsBindingNavigator.TabIndex = 0;
            this.contactsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(44, 44);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(87, 44);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(44, 44);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(44, 44);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(44, 44);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 47);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 47);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 47);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(44, 44);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(44, 44);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 47);
            // 
            // contactsBindingNavigatorSaveItem
            // 
            this.contactsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.contactsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("contactsBindingNavigatorSaveItem.Image")));
            this.contactsBindingNavigatorSaveItem.Name = "contactsBindingNavigatorSaveItem";
            this.contactsBindingNavigatorSaveItem.Size = new System.Drawing.Size(44, 44);
            this.contactsBindingNavigatorSaveItem.Text = "Save Data";
            this.contactsBindingNavigatorSaveItem.Click += new System.EventHandler(this.contactsBindingNavigatorSaveItem_Click);
            // 
            // contactsDataGridView
            // 
            this.contactsDataGridView.AutoGenerateColumns = false;
            this.contactsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.contactsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.contactsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contactsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.contactsDataGridView.DataSource = this.contactsBindingSource;
            this.contactsDataGridView.Location = new System.Drawing.Point(66, 203);
            this.contactsDataGridView.Name = "contactsDataGridView";
            this.contactsDataGridView.RowTemplate.Height = 40;
            this.contactsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.contactsDataGridView.Size = new System.Drawing.Size(659, 1254);
            this.contactsDataGridView.TabIndex = 1;
            this.contactsDataGridView.SelectionChanged += new System.EventHandler(this.contactsDataGridView_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ContactID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ContactName";
            this.dataGridViewTextBoxColumn2.HeaderText = "ContactName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // contactTelephoneNumbersBindingSource
            // 
            this.contactTelephoneNumbersBindingSource.DataMember = "ContactTelephoneNumbers";
            this.contactTelephoneNumbersBindingSource.DataSource = this.dataSet1;
            // 
            // telephoneTypesBindingSource
            // 
            this.telephoneTypesBindingSource.DataMember = "TelephoneTypes";
            this.telephoneTypesBindingSource.DataSource = this.dataSet1;
            // 
            // DgvAdresses
            // 
            this.DgvAdresses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvAdresses.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DgvAdresses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAdresses.Location = new System.Drawing.Point(44, 95);
            this.DgvAdresses.Name = "DgvAdresses";
            this.DgvAdresses.RowTemplate.Height = 40;
            this.DgvAdresses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvAdresses.Size = new System.Drawing.Size(707, 485);
            this.DgvAdresses.TabIndex = 2;
            this.DgvAdresses.SelectionChanged += new System.EventHandler(this.DgvAdresses_SelectionChanged);
            // 
            // DgvPhones
            // 
            this.DgvPhones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvPhones.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DgvPhones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPhones.Location = new System.Drawing.Point(44, 92);
            this.DgvPhones.Name = "DgvPhones";
            this.DgvPhones.RowTemplate.Height = 40;
            this.DgvPhones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvPhones.Size = new System.Drawing.Size(707, 485);
            this.DgvPhones.TabIndex = 3;
            this.DgvPhones.SelectionChanged += new System.EventHandler(this.DgvPhones_SelectionChanged);
            // 
            // cmdSaveAdress
            // 
            this.cmdSaveAdress.Enabled = false;
            this.cmdSaveAdress.Location = new System.Drawing.Point(1096, 420);
            this.cmdSaveAdress.Name = "cmdSaveAdress";
            this.cmdSaveAdress.Size = new System.Drawing.Size(115, 56);
            this.cmdSaveAdress.TabIndex = 4;
            this.cmdSaveAdress.Text = "Save";
            this.cmdSaveAdress.UseVisualStyleBackColor = true;
            this.cmdSaveAdress.Click += new System.EventHandler(this.cmdSaveAdress_Click);
            // 
            // cmdNewAdress
            // 
            this.cmdNewAdress.Location = new System.Drawing.Point(826, 420);
            this.cmdNewAdress.Name = "cmdNewAdress";
            this.cmdNewAdress.Size = new System.Drawing.Size(115, 56);
            this.cmdNewAdress.TabIndex = 5;
            this.cmdNewAdress.Text = "New";
            this.cmdNewAdress.UseVisualStyleBackColor = true;
            this.cmdNewAdress.Click += new System.EventHandler(this.cmdNewAdress_Click);
            // 
            // cbTypeOfAdress
            // 
            this.cbTypeOfAdress.DataSource = this.adressTypesBindingSource;
            this.cbTypeOfAdress.DisplayMember = "AdressTypeName";
            this.cbTypeOfAdress.Enabled = false;
            this.cbTypeOfAdress.FormattingEnabled = true;
            this.cbTypeOfAdress.Location = new System.Drawing.Point(826, 155);
            this.cbTypeOfAdress.Name = "cbTypeOfAdress";
            this.cbTypeOfAdress.Size = new System.Drawing.Size(336, 39);
            this.cbTypeOfAdress.TabIndex = 6;
            this.cbTypeOfAdress.ValueMember = "AdressTypeID";
            // 
            // adressTypesBindingSource
            // 
            this.adressTypesBindingSource.DataMember = "AdressTypes";
            this.adressTypesBindingSource.DataSource = this.dataSet11;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adressTypesTableAdapter
            // 
            this.adressTypesTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(812, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "Type Of Adress";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(821, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = "Adress";
            // 
            // txtAdress
            // 
            this.txtAdress.Enabled = false;
            this.txtAdress.Location = new System.Drawing.Point(826, 286);
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(335, 38);
            this.txtAdress.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(831, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 32);
            this.label3.TabIndex = 11;
            this.label3.Text = "Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(821, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(312, 32);
            this.label4.TabIndex = 10;
            this.label4.Text = "Type Of PhoneNummer";
            // 
            // cbTypeOfPhones
            // 
            this.cbTypeOfPhones.DataSource = this.telephoneTypesBindingSource1;
            this.cbTypeOfPhones.DisplayMember = "TelephoneTypeName";
            this.cbTypeOfPhones.Enabled = false;
            this.cbTypeOfPhones.FormattingEnabled = true;
            this.cbTypeOfPhones.Location = new System.Drawing.Point(827, 176);
            this.cbTypeOfPhones.Name = "cbTypeOfPhones";
            this.cbTypeOfPhones.Size = new System.Drawing.Size(344, 39);
            this.cbTypeOfPhones.TabIndex = 12;
            this.cbTypeOfPhones.ValueMember = "TelephoneTypeID";
            // 
            // telephoneTypesBindingSource1
            // 
            this.telephoneTypesBindingSource1.DataMember = "TelephoneTypes";
            this.telephoneTypesBindingSource1.DataSource = this.dataSet11;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Enabled = false;
            this.txtPhoneNumber.Location = new System.Drawing.Point(826, 298);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(345, 38);
            this.txtPhoneNumber.TabIndex = 13;
            // 
            // cmdNewNumber
            // 
            this.cmdNewNumber.Location = new System.Drawing.Point(835, 411);
            this.cmdNewNumber.Name = "cmdNewNumber";
            this.cmdNewNumber.Size = new System.Drawing.Size(115, 56);
            this.cmdNewNumber.TabIndex = 15;
            this.cmdNewNumber.Text = "New";
            this.cmdNewNumber.UseVisualStyleBackColor = true;
            this.cmdNewNumber.Click += new System.EventHandler(this.cmdNewNumber_Click);
            // 
            // cmdSaveNumber
            // 
            this.cmdSaveNumber.Enabled = false;
            this.cmdSaveNumber.Location = new System.Drawing.Point(1105, 411);
            this.cmdSaveNumber.Name = "cmdSaveNumber";
            this.cmdSaveNumber.Size = new System.Drawing.Size(115, 56);
            this.cmdSaveNumber.TabIndex = 14;
            this.cmdSaveNumber.Text = "Save";
            this.cmdSaveNumber.UseVisualStyleBackColor = true;
            this.cmdSaveNumber.Click += new System.EventHandler(this.cmdSaveNumber_Click);
            // 
            // cmdEditAdress
            // 
            this.cmdEditAdress.Location = new System.Drawing.Point(959, 420);
            this.cmdEditAdress.Name = "cmdEditAdress";
            this.cmdEditAdress.Size = new System.Drawing.Size(115, 56);
            this.cmdEditAdress.TabIndex = 16;
            this.cmdEditAdress.Text = "Edit";
            this.cmdEditAdress.UseVisualStyleBackColor = true;
            this.cmdEditAdress.Click += new System.EventHandler(this.cmdEditAdress_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdAddNewTypeAddress);
            this.groupBox1.Controls.Add(this.cmdCancelAdress);
            this.groupBox1.Controls.Add(this.cmdDeleteAdress);
            this.groupBox1.Controls.Add(this.cmdEditAdress);
            this.groupBox1.Controls.Add(this.txtAdress);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbTypeOfAdress);
            this.groupBox1.Controls.Add(this.cmdNewAdress);
            this.groupBox1.Controls.Add(this.cmdSaveAdress);
            this.groupBox1.Controls.Add(this.DgvAdresses);
            this.groupBox1.Location = new System.Drawing.Point(750, 154);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1442, 662);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contact Addresses";
            // 
            // cmdCancelAdress
            // 
            this.cmdCancelAdress.Enabled = false;
            this.cmdCancelAdress.Location = new System.Drawing.Point(1227, 420);
            this.cmdCancelAdress.Name = "cmdCancelAdress";
            this.cmdCancelAdress.Size = new System.Drawing.Size(115, 56);
            this.cmdCancelAdress.TabIndex = 18;
            this.cmdCancelAdress.Text = "Cancel";
            this.cmdCancelAdress.UseVisualStyleBackColor = true;
            this.cmdCancelAdress.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // cmdDeleteAdress
            // 
            this.cmdDeleteAdress.Location = new System.Drawing.Point(1022, 524);
            this.cmdDeleteAdress.Name = "cmdDeleteAdress";
            this.cmdDeleteAdress.Size = new System.Drawing.Size(115, 56);
            this.cmdDeleteAdress.TabIndex = 17;
            this.cmdDeleteAdress.Text = "Delete";
            this.cmdDeleteAdress.UseVisualStyleBackColor = true;
            this.cmdDeleteAdress.Click += new System.EventHandler(this.cmdDelete_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmdAddNewTypeNumber);
            this.groupBox2.Controls.Add(this.cmdCancelNumber);
            this.groupBox2.Controls.Add(this.cmdNewNumber);
            this.groupBox2.Controls.Add(this.cmdDeleteNumber);
            this.groupBox2.Controls.Add(this.cmdEditNumber);
            this.groupBox2.Controls.Add(this.cmdSaveNumber);
            this.groupBox2.Controls.Add(this.txtPhoneNumber);
            this.groupBox2.Controls.Add(this.cbTypeOfPhones);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.DgvPhones);
            this.groupBox2.Location = new System.Drawing.Point(750, 845);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1442, 679);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Contact Phone Numbers";
            // 
            // cmdCancelNumber
            // 
            this.cmdCancelNumber.Enabled = false;
            this.cmdCancelNumber.Location = new System.Drawing.Point(1236, 411);
            this.cmdCancelNumber.Name = "cmdCancelNumber";
            this.cmdCancelNumber.Size = new System.Drawing.Size(115, 56);
            this.cmdCancelNumber.TabIndex = 21;
            this.cmdCancelNumber.Text = "Cancel";
            this.cmdCancelNumber.UseVisualStyleBackColor = true;
            this.cmdCancelNumber.Click += new System.EventHandler(this.cmdCancelNumber_Click);
            // 
            // cmdDeleteNumber
            // 
            this.cmdDeleteNumber.Location = new System.Drawing.Point(1031, 508);
            this.cmdDeleteNumber.Name = "cmdDeleteNumber";
            this.cmdDeleteNumber.Size = new System.Drawing.Size(115, 56);
            this.cmdDeleteNumber.TabIndex = 20;
            this.cmdDeleteNumber.Text = "Delete";
            this.cmdDeleteNumber.UseVisualStyleBackColor = true;
            this.cmdDeleteNumber.Click += new System.EventHandler(this.cmdDeleteNumber_Click);
            // 
            // cmdEditNumber
            // 
            this.cmdEditNumber.Location = new System.Drawing.Point(968, 411);
            this.cmdEditNumber.Name = "cmdEditNumber";
            this.cmdEditNumber.Size = new System.Drawing.Size(115, 56);
            this.cmdEditNumber.TabIndex = 19;
            this.cmdEditNumber.Text = "Edit";
            this.cmdEditNumber.UseVisualStyleBackColor = true;
            this.cmdEditNumber.Click += new System.EventHandler(this.cmdEditNumber_Click);
            // 
            // cmdAddNewTypeAddress
            // 
            this.cmdAddNewTypeAddress.AutoSize = true;
            this.cmdAddNewTypeAddress.Location = new System.Drawing.Point(1168, 155);
            this.cmdAddNewTypeAddress.Name = "cmdAddNewTypeAddress";
            this.cmdAddNewTypeAddress.Size = new System.Drawing.Size(199, 32);
            this.cmdAddNewTypeAddress.TabIndex = 19;
            this.cmdAddNewTypeAddress.Text = "Add New Type";
            this.cmdAddNewTypeAddress.Click += new System.EventHandler(this.cmdAddNewTypeAddress_Click);
            // 
            // cmdAddNewTypeNumber
            // 
            this.cmdAddNewTypeNumber.AutoSize = true;
            this.cmdAddNewTypeNumber.Location = new System.Drawing.Point(1177, 176);
            this.cmdAddNewTypeNumber.Name = "cmdAddNewTypeNumber";
            this.cmdAddNewTypeNumber.Size = new System.Drawing.Size(199, 32);
            this.cmdAddNewTypeNumber.TabIndex = 20;
            this.cmdAddNewTypeNumber.Text = "Add New Type";
            this.cmdAddNewTypeNumber.Click += new System.EventHandler(this.cmdAddNewTypeNumber_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 32);
            this.label5.TabIndex = 20;
            this.label5.Text = "Contacts";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(2264, 1680);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.contactsDataGridView);
            this.Controls.Add(this.contactsBindingNavigator);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contact Book";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactsBindingNavigator)).EndInit();
            this.contactsBindingNavigator.ResumeLayout(false);
            this.contactsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contactsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactTelephoneNumbersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telephoneTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAdresses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPhones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adressTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telephoneTypesBindingSource1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource contactsBindingSource;
        private DataSet1TableAdapters.ContactsTableAdapter contactsTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator contactsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton contactsBindingNavigatorSaveItem;
        private DataSet1TableAdapters.ContactTelephoneNumbersTableAdapter contactTelephoneNumbersTableAdapter;
        private System.Windows.Forms.DataGridView contactsDataGridView;
        private System.Windows.Forms.BindingSource contactTelephoneNumbersBindingSource;
        private DataSet1TableAdapters.TelephoneTypesTableAdapter telephoneTypesTableAdapter;
        private System.Windows.Forms.BindingSource telephoneTypesBindingSource;
        private System.Windows.Forms.DataGridView DgvAdresses;
        private System.Windows.Forms.DataGridView DgvPhones;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button cmdSaveAdress;
        private System.Windows.Forms.Button cmdNewAdress;
        private System.Windows.Forms.ComboBox cbTypeOfAdress;
        private DataSet1 dataSet11;
        private System.Windows.Forms.BindingSource adressTypesBindingSource;
        private DataSet1TableAdapters.AdressTypesTableAdapter adressTypesTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbTypeOfPhones;
        private System.Windows.Forms.BindingSource telephoneTypesBindingSource1;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Button cmdNewNumber;
        private System.Windows.Forms.Button cmdSaveNumber;
        private System.Windows.Forms.Button cmdEditAdress;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cmdDeleteAdress;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button cmdCancelAdress;
        private System.Windows.Forms.Button cmdCancelNumber;
        private System.Windows.Forms.Button cmdDeleteNumber;
        private System.Windows.Forms.Button cmdEditNumber;
        private System.Windows.Forms.Label cmdAddNewTypeAddress;
        private System.Windows.Forms.Label cmdAddNewTypeNumber;
        private System.Windows.Forms.Label label5;
    }
}