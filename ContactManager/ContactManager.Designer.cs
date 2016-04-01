namespace ContactManager
{
    partial class ContactManager
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.combobox = new System.Windows.Forms.ComboBox();
            this.nametext = new System.Windows.Forms.TextBox();
            this.addresstext = new System.Windows.Forms.TextBox();
            this.agetext = new System.Windows.Forms.TextBox();
            this.mobiletext = new System.Windows.Forms.TextBox();
            this.savebtn = new System.Windows.Forms.Button();
            this.listbtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Age";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mobile";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Type";
            // 
            // combobox
            // 
            this.combobox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.combobox.FormattingEnabled = true;
            this.combobox.Items.AddRange(new object[] {
            "Home",
            "WorkPlace",
            "Mobile"});
            this.combobox.Location = new System.Drawing.Point(91, 194);
            this.combobox.Name = "combobox";
            this.combobox.Size = new System.Drawing.Size(118, 21);
            this.combobox.TabIndex = 5;
            this.combobox.Tag = "";
            this.combobox.Text = "-Select One-";
            // 
            // nametext
            // 
            this.nametext.Location = new System.Drawing.Point(91, 38);
            this.nametext.Name = "nametext";
            this.nametext.Size = new System.Drawing.Size(118, 20);
            this.nametext.TabIndex = 6;
            // 
            // addresstext
            // 
            this.addresstext.Location = new System.Drawing.Point(91, 73);
            this.addresstext.Name = "addresstext";
            this.addresstext.Size = new System.Drawing.Size(118, 20);
            this.addresstext.TabIndex = 6;
            // 
            // agetext
            // 
            this.agetext.Location = new System.Drawing.Point(91, 117);
            this.agetext.Name = "agetext";
            this.agetext.Size = new System.Drawing.Size(118, 20);
            this.agetext.TabIndex = 6;
            // 
            // mobiletext
            // 
            this.mobiletext.Location = new System.Drawing.Point(91, 157);
            this.mobiletext.Name = "mobiletext";
            this.mobiletext.Size = new System.Drawing.Size(118, 20);
            this.mobiletext.TabIndex = 6;
            // 
            // savebtn
            // 
            this.savebtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.savebtn.Location = new System.Drawing.Point(12, 243);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(91, 23);
            this.savebtn.TabIndex = 7;
            this.savebtn.Text = "Save";
            this.savebtn.UseVisualStyleBackColor = true;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // listbtn
            // 
            this.listbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.listbtn.Location = new System.Drawing.Point(166, 243);
            this.listbtn.Name = "listbtn";
            this.listbtn.Size = new System.Drawing.Size(91, 23);
            this.listbtn.TabIndex = 7;
            this.listbtn.Text = "List";
            this.listbtn.UseVisualStyleBackColor = true;
            this.listbtn.Click += new System.EventHandler(this.listbtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(736, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 32);
            this.button1.TabIndex = 8;
            this.button1.Text = "<<";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnName,
            this.ColumnAddress,
            this.ColumnAge,
            this.ColumnMobile,
            this.ColumnType});
            this.dataGridView1.Location = new System.Drawing.Point(290, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(440, 252);
            this.dataGridView1.TabIndex = 9;
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "Name";
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.ReadOnly = true;
            // 
            // ColumnAddress
            // 
            this.ColumnAddress.HeaderText = "Address";
            this.ColumnAddress.Name = "ColumnAddress";
            this.ColumnAddress.ReadOnly = true;
            // 
            // ColumnAge
            // 
            this.ColumnAge.HeaderText = "Age";
            this.ColumnAge.Name = "ColumnAge";
            this.ColumnAge.ReadOnly = true;
            // 
            // ColumnMobile
            // 
            this.ColumnMobile.HeaderText = "Mobile";
            this.ColumnMobile.Name = "ColumnMobile";
            this.ColumnMobile.ReadOnly = true;
            // 
            // ColumnType
            // 
            this.ColumnType.HeaderText = "Type";
            this.ColumnType.Name = "ColumnType";
            this.ColumnType.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 276);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listbtn);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.mobiletext);
            this.Controls.Add(this.agetext);
            this.Controls.Add(this.addresstext);
            this.Controls.Add(this.nametext);
            this.Controls.Add(this.combobox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Contacts";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox combobox;
        private System.Windows.Forms.TextBox nametext;
        private System.Windows.Forms.TextBox addresstext;
        private System.Windows.Forms.TextBox agetext;
        private System.Windows.Forms.TextBox mobiletext;
        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.Button listbtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnType;
    }
}

