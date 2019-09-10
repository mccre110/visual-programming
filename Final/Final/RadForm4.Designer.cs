namespace Final
{
    partial class RadForm4
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
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.nameEditTextBox = new Telerik.WinControls.UI.RadTextBox();
            this.locEditTextBox = new Telerik.WinControls.UI.RadTextBox();
            this.priceEditList = new Telerik.WinControls.UI.RadDropDownList();
            this.ratingEditTextBox = new Telerik.WinControls.UI.RadTextBox();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameEditTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locEditTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceEditList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ratingEditTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(13, 67);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(49, 18);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "Location";
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(13, 176);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(38, 18);
            this.radLabel2.TabIndex = 1;
            this.radLabel2.Text = "Rating";
            // 
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(12, 12);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(36, 18);
            this.radLabel3.TabIndex = 0;
            this.radLabel3.Text = "Name";
            // 
            // radLabel4
            // 
            this.radLabel4.Location = new System.Drawing.Point(12, 122);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(30, 18);
            this.radLabel4.TabIndex = 3;
            this.radLabel4.Text = "Price";
            // 
            // nameEditTextBox
            // 
            this.nameEditTextBox.Location = new System.Drawing.Point(13, 37);
            this.nameEditTextBox.Name = "nameEditTextBox";
            this.nameEditTextBox.Size = new System.Drawing.Size(125, 24);
            this.nameEditTextBox.TabIndex = 0;
            this.nameEditTextBox.Enter += new System.EventHandler(this.load);
            // 
            // locEditTextBox
            // 
            this.locEditTextBox.Location = new System.Drawing.Point(13, 92);
            this.locEditTextBox.Name = "locEditTextBox";
            this.locEditTextBox.Size = new System.Drawing.Size(125, 24);
            this.locEditTextBox.TabIndex = 1;
            // 
            // priceEditList
            // 
            this.priceEditList.Location = new System.Drawing.Point(13, 146);
            this.priceEditList.Name = "priceEditList";
            this.priceEditList.Size = new System.Drawing.Size(156, 24);
            this.priceEditList.TabIndex = 2;
            this.priceEditList.Text = "radDropDownList1";
            // 
            // ratingEditTextBox
            // 
            this.ratingEditTextBox.Location = new System.Drawing.Point(12, 201);
            this.ratingEditTextBox.Name = "ratingEditTextBox";
            this.ratingEditTextBox.Size = new System.Drawing.Size(50, 24);
            this.ratingEditTextBox.TabIndex = 3;
            // 
            // radButton1
            // 
            this.radButton1.Location = new System.Drawing.Point(22, 231);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(137, 30);
            this.radButton1.TabIndex = 4;
            this.radButton1.Text = "Save Changes";
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click_1);
            // 
            // RadForm4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(187, 275);
            this.Controls.Add(this.radButton1);
            this.Controls.Add(this.ratingEditTextBox);
            this.Controls.Add(this.priceEditList);
            this.Controls.Add(this.locEditTextBox);
            this.Controls.Add(this.nameEditTextBox);
            this.Controls.Add(this.radLabel4);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radLabel1);
            this.Name = "RadForm4";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "RadForm4";
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameEditTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locEditTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceEditList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ratingEditTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadTextBox nameEditTextBox;
        private Telerik.WinControls.UI.RadTextBox locEditTextBox;
        private Telerik.WinControls.UI.RadDropDownList priceEditList;
        private Telerik.WinControls.UI.RadTextBox ratingEditTextBox;
        private Telerik.WinControls.UI.RadButton radButton1;
    }
}
