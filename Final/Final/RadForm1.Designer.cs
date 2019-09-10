namespace Final
{
    partial class RadForm1
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
            this.genButton = new Telerik.WinControls.UI.RadButton();
            this.restList = new Telerik.WinControls.UI.RadListControl();
            this.nameLabel = new Telerik.WinControls.UI.RadLabel();
            this.nameTextBox = new Telerik.WinControls.UI.RadTextBox();
            this.locationBox = new Telerik.WinControls.UI.RadCheckedDropDownList();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.locationLabel = new Telerik.WinControls.UI.RadLabel();
            this.priceLabel = new Telerik.WinControls.UI.RadLabel();
            this.priceDropList = new Telerik.WinControls.UI.RadCheckedDropDownList();
            this.addRestButton = new Telerik.WinControls.UI.RadButton();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.greaterTextBox = new Telerik.WinControls.UI.RadTextBox();
            this.editButton = new Telerik.WinControls.UI.RadButton();
            this.deleteButton = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.genButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceDropList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addRestButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greaterTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deleteButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // genButton
            // 
            this.genButton.Location = new System.Drawing.Point(106, 217);
            this.genButton.Name = "genButton";
            this.genButton.Size = new System.Drawing.Size(178, 30);
            this.genButton.TabIndex = 4;
            this.genButton.Text = "Generate Random Restaurant";
            this.genButton.Click += new System.EventHandler(this.genButton_Click);
            // 
            // restList
            // 
            this.restList.Location = new System.Drawing.Point(190, 32);
            this.restList.Name = "restList";
            this.restList.Size = new System.Drawing.Size(126, 151);
            this.restList.TabIndex = 8;
            this.restList.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.restList_SelectedIndexChanged);
            // 
            // nameLabel
            // 
            this.nameLabel.Location = new System.Drawing.Point(13, 8);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(39, 18);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(13, 32);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(125, 24);
            this.nameTextBox.TabIndex = 0;
            // 
            // locationBox
            // 
            this.locationBox.Location = new System.Drawing.Point(13, 78);
            this.locationBox.Name = "locationBox";
            this.locationBox.Size = new System.Drawing.Size(156, 20);
            this.locationBox.TabIndex = 1;
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(190, 8);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(79, 18);
            this.radLabel1.TabIndex = 7;
            this.radLabel1.Text = "Restaurant List";
            // 
            // locationLabel
            // 
            this.locationLabel.Location = new System.Drawing.Point(13, 62);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(51, 18);
            this.locationLabel.TabIndex = 8;
            this.locationLabel.Text = "Location:";
            // 
            // priceLabel
            // 
            this.priceLabel.Location = new System.Drawing.Point(13, 106);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(33, 18);
            this.priceLabel.TabIndex = 9;
            this.priceLabel.Text = "Price:";
            // 
            // priceDropList
            // 
            this.priceDropList.Location = new System.Drawing.Point(13, 122);
            this.priceDropList.Name = "priceDropList";
            this.priceDropList.Size = new System.Drawing.Size(156, 20);
            this.priceDropList.TabIndex = 2;
            // 
            // addRestButton
            // 
            this.addRestButton.Location = new System.Drawing.Point(106, 253);
            this.addRestButton.Name = "addRestButton";
            this.addRestButton.Size = new System.Drawing.Size(178, 30);
            this.addRestButton.TabIndex = 5;
            this.addRestButton.Text = "Add a Restaurant";
            this.addRestButton.Click += new System.EventHandler(this.addRestButton_Click);
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(13, 149);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(102, 18);
            this.radLabel2.TabIndex = 15;
            this.radLabel2.Text = "Rating Better Than:";
            // 
            // greaterTextBox
            // 
            this.greaterTextBox.Location = new System.Drawing.Point(13, 173);
            this.greaterTextBox.Name = "greaterTextBox";
            this.greaterTextBox.Size = new System.Drawing.Size(51, 24);
            this.greaterTextBox.TabIndex = 3;
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(106, 290);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(178, 30);
            this.editButton.TabIndex = 6;
            this.editButton.Text = "Edit Selected Entry";
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(106, 327);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(178, 30);
            this.deleteButton.TabIndex = 7;
            this.deleteButton.Text = "Delete Selected Entry";
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // RadForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 366);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.greaterTextBox);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.addRestButton);
            this.Controls.Add(this.priceDropList);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.locationLabel);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.locationBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.restList);
            this.Controls.Add(this.genButton);
            this.Name = "RadForm1";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "RadForm1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.writeFile);
            this.Load += new System.EventHandler(this.load);
            ((System.ComponentModel.ISupportInitialize)(this.genButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceDropList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addRestButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greaterTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deleteButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadButton genButton;
        public Telerik.WinControls.UI.RadListControl restList;
        private Telerik.WinControls.UI.RadLabel nameLabel;
        private Telerik.WinControls.UI.RadTextBox nameTextBox;
        private Telerik.WinControls.UI.RadCheckedDropDownList locationBox;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel locationLabel;
        private Telerik.WinControls.UI.RadLabel priceLabel;
        private Telerik.WinControls.UI.RadCheckedDropDownList priceDropList;
        private Telerik.WinControls.UI.RadButton addRestButton;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadTextBox greaterTextBox;
        private Telerik.WinControls.UI.RadButton editButton;
        private Telerik.WinControls.UI.RadButton deleteButton;
    }
}