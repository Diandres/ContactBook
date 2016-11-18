namespace ContactBook
{
    partial class TelephoneTypeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelephoneTypeForm));
            this.dataSet1 = new ContactBook.DataSet1();
            this.telephoneTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.telephoneTypesTableAdapter = new ContactBook.DataSet1TableAdapters.TelephoneTypesTableAdapter();
            this.tableAdapterManager = new ContactBook.DataSet1TableAdapters.TableAdapterManager();
            this.telephoneTypesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.telephoneTypesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.telephoneTypesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmdGoBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telephoneTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telephoneTypesBindingNavigator)).BeginInit();
            this.telephoneTypesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.telephoneTypesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // telephoneTypesBindingSource
            // 
            this.telephoneTypesBindingSource.DataMember = "TelephoneTypes";
            this.telephoneTypesBindingSource.DataSource = this.dataSet1;
            // 
            // telephoneTypesTableAdapter
            // 
            this.telephoneTypesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.@__MigrationHistoryTableAdapter = null;
            this.tableAdapterManager.AdressTypesTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ContactAdressesTableAdapter = null;
            this.tableAdapterManager.ContactsTableAdapter = null;
            this.tableAdapterManager.ContactTelephoneNumbersTableAdapter = null;
            this.tableAdapterManager.TelephoneTypesTableAdapter = this.telephoneTypesTableAdapter;
            this.tableAdapterManager.UpdateOrder = ContactBook.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // telephoneTypesBindingNavigator
            // 
            this.telephoneTypesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.telephoneTypesBindingNavigator.BindingSource = this.telephoneTypesBindingSource;
            this.telephoneTypesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.telephoneTypesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.telephoneTypesBindingNavigator.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.telephoneTypesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.telephoneTypesBindingNavigatorSaveItem});
            this.telephoneTypesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.telephoneTypesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.telephoneTypesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.telephoneTypesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.telephoneTypesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.telephoneTypesBindingNavigator.Name = "telephoneTypesBindingNavigator";
            this.telephoneTypesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.telephoneTypesBindingNavigator.Size = new System.Drawing.Size(1264, 47);
            this.telephoneTypesBindingNavigator.TabIndex = 0;
            this.telephoneTypesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(44, 44);
            this.bindingNavigatorAddNewItem.Text = "Add new";
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
            // telephoneTypesBindingNavigatorSaveItem
            // 
            this.telephoneTypesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.telephoneTypesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("telephoneTypesBindingNavigatorSaveItem.Image")));
            this.telephoneTypesBindingNavigatorSaveItem.Name = "telephoneTypesBindingNavigatorSaveItem";
            this.telephoneTypesBindingNavigatorSaveItem.Size = new System.Drawing.Size(44, 44);
            this.telephoneTypesBindingNavigatorSaveItem.Text = "Save Data";
            this.telephoneTypesBindingNavigatorSaveItem.Click += new System.EventHandler(this.telephoneTypesBindingNavigatorSaveItem_Click);
            // 
            // telephoneTypesDataGridView
            // 
            this.telephoneTypesDataGridView.AutoGenerateColumns = false;
            this.telephoneTypesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.telephoneTypesDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.telephoneTypesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.telephoneTypesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.telephoneTypesDataGridView.DataSource = this.telephoneTypesBindingSource;
            this.telephoneTypesDataGridView.Location = new System.Drawing.Point(57, 156);
            this.telephoneTypesDataGridView.Name = "telephoneTypesDataGridView";
            this.telephoneTypesDataGridView.RowTemplate.Height = 40;
            this.telephoneTypesDataGridView.Size = new System.Drawing.Size(792, 282);
            this.telephoneTypesDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TelephoneTypeID";
            this.dataGridViewTextBoxColumn1.HeaderText = "TelephoneTypeID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TelephoneTypeName";
            this.dataGridViewTextBoxColumn2.HeaderText = "TelephoneTypeName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // cmdGoBack
            // 
            this.cmdGoBack.Location = new System.Drawing.Point(188, 487);
            this.cmdGoBack.Name = "cmdGoBack";
            this.cmdGoBack.Size = new System.Drawing.Size(294, 110);
            this.cmdGoBack.TabIndex = 2;
            this.cmdGoBack.Text = "Back";
            this.cmdGoBack.UseVisualStyleBackColor = true;
            this.cmdGoBack.Click += new System.EventHandler(this.cmdGoBack_Click);
            // 
            // TelephoneTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 763);
            this.Controls.Add(this.cmdGoBack);
            this.Controls.Add(this.telephoneTypesDataGridView);
            this.Controls.Add(this.telephoneTypesBindingNavigator);
            this.Name = "TelephoneTypeForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telephoneTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telephoneTypesBindingNavigator)).EndInit();
            this.telephoneTypesBindingNavigator.ResumeLayout(false);
            this.telephoneTypesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.telephoneTypesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource telephoneTypesBindingSource;
        private DataSet1TableAdapters.TelephoneTypesTableAdapter telephoneTypesTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator telephoneTypesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton telephoneTypesBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView telephoneTypesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button cmdGoBack;
    }
}