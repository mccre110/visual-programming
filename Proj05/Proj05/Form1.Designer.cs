namespace Proj05
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
            this.addButton = new System.Windows.Forms.Button();
            this.lnameInput = new System.Windows.Forms.TextBox();
            this.fnameInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.recordListbox = new System.Windows.Forms.ListBox();
            this.standingInput = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.standingOutput = new System.Windows.Forms.Label();
            this.lnameOutput = new System.Windows.Forms.Label();
            this.fnameOutput = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(35, 192);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(99, 23);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Add Record";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // lnameInput
            // 
            this.lnameInput.Location = new System.Drawing.Point(36, 95);
            this.lnameInput.Name = "lnameInput";
            this.lnameInput.Size = new System.Drawing.Size(100, 22);
            this.lnameInput.TabIndex = 1;
            // 
            // fnameInput
            // 
            this.fnameInput.Location = new System.Drawing.Point(35, 39);
            this.fnameInput.Name = "fnameInput";
            this.fnameInput.Size = new System.Drawing.Size(100, 22);
            this.fnameInput.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Last Name";
            // 
            // recordListbox
            // 
            this.recordListbox.FormattingEnabled = true;
            this.recordListbox.ItemHeight = 16;
            this.recordListbox.Location = new System.Drawing.Point(198, 19);
            this.recordListbox.Name = "recordListbox";
            this.recordListbox.Size = new System.Drawing.Size(152, 196);
            this.recordListbox.TabIndex = 4;
            this.recordListbox.SelectedIndexChanged += new System.EventHandler(this.recordListbox_SelectedIndexChanged);
            // 
            // standingInput
            // 
            this.standingInput.FormattingEnabled = true;
            this.standingInput.Items.AddRange(new object[] {
            "Freshman",
            "Sophmore",
            "Junior",
            "Senior"});
            this.standingInput.Location = new System.Drawing.Point(35, 148);
            this.standingInput.Name = "standingInput";
            this.standingInput.Size = new System.Drawing.Size(121, 24);
            this.standingInput.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Class Standing";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.standingOutput);
            this.groupBox1.Controls.Add(this.lnameOutput);
            this.groupBox1.Controls.Add(this.fnameOutput);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(36, 239);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 110);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Current Student";
            // 
            // standingOutput
            // 
            this.standingOutput.AutoSize = true;
            this.standingOutput.Location = new System.Drawing.Point(94, 64);
            this.standingOutput.Name = "standingOutput";
            this.standingOutput.Size = new System.Drawing.Size(12, 17);
            this.standingOutput.TabIndex = 8;
            this.standingOutput.Text = " ";
            // 
            // lnameOutput
            // 
            this.lnameOutput.AutoSize = true;
            this.lnameOutput.Location = new System.Drawing.Point(94, 43);
            this.lnameOutput.Name = "lnameOutput";
            this.lnameOutput.Size = new System.Drawing.Size(12, 17);
            this.lnameOutput.TabIndex = 7;
            this.lnameOutput.Text = " ";
            // 
            // fnameOutput
            // 
            this.fnameOutput.AutoSize = true;
            this.fnameOutput.Location = new System.Drawing.Point(94, 22);
            this.fnameOutput.Name = "fnameOutput";
            this.fnameOutput.Size = new System.Drawing.Size(12, 17);
            this.fnameOutput.TabIndex = 6;
            this.fnameOutput.Text = " ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(85, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 17);
            this.label9.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(94, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 17);
            this.label8.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(94, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 17);
            this.label7.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Standing:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Last Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "First Name:";
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(322, 255);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 23);
            this.editButton.TabIndex = 9;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(322, 297);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 10;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(34, 192);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(102, 23);
            this.saveButton.TabIndex = 11;
            this.saveButton.Text = "Save Record";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Visible = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 408);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.standingInput);
            this.Controls.Add(this.recordListbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fnameInput);
            this.Controls.Add(this.lnameInput);
            this.Controls.Add(this.addButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox lnameInput;
        private System.Windows.Forms.TextBox fnameInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox recordListbox;
        private System.Windows.Forms.ComboBox standingInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label standingOutput;
        private System.Windows.Forms.Label lnameOutput;
        private System.Windows.Forms.Label fnameOutput;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button saveButton;
    }
}

