namespace ContactBook
{
    partial class Main
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
            this.cmdPhoneTypes = new System.Windows.Forms.Button();
            this.cmdAdresTypes = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdPhoneTypes
            // 
            this.cmdPhoneTypes.Location = new System.Drawing.Point(137, 135);
            this.cmdPhoneTypes.Name = "cmdPhoneTypes";
            this.cmdPhoneTypes.Size = new System.Drawing.Size(268, 149);
            this.cmdPhoneTypes.TabIndex = 0;
            this.cmdPhoneTypes.Text = "Phone Types";
            this.cmdPhoneTypes.UseVisualStyleBackColor = true;
            this.cmdPhoneTypes.Click += new System.EventHandler(this.cmdPhoneTypes_Click);
            // 
            // cmdAdresTypes
            // 
            this.cmdAdresTypes.Location = new System.Drawing.Point(137, 373);
            this.cmdAdresTypes.Name = "cmdAdresTypes";
            this.cmdAdresTypes.Size = new System.Drawing.Size(268, 149);
            this.cmdAdresTypes.TabIndex = 1;
            this.cmdAdresTypes.Text = "Adres Types";
            this.cmdAdresTypes.UseVisualStyleBackColor = true;
            this.cmdAdresTypes.Click += new System.EventHandler(this.cmdAdresTypes_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(137, 570);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(270, 168);
            this.button1.TabIndex = 2;
            this.button1.Text = "Contacts";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 928);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmdAdresTypes);
            this.Controls.Add(this.cmdPhoneTypes);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdPhoneTypes;
        private System.Windows.Forms.Button cmdAdresTypes;
        private System.Windows.Forms.Button button1;
    }
}