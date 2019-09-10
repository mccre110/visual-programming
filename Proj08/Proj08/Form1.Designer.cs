namespace Proj08
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
            this.label1 = new System.Windows.Forms.Label();
            this.addTextBox = new System.Windows.Forms.TextBox();
            this.encodebutton = new System.Windows.Forms.Button();
            this.writebutton = new System.Windows.Forms.Button();
            this.findButton = new System.Windows.Forms.Button();
            this.decodeButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.foundTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.openButton = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Text to Add to Image";
            // 
            // addTextBox
            // 
            this.addTextBox.Location = new System.Drawing.Point(15, 56);
            this.addTextBox.Multiline = true;
            this.addTextBox.Name = "addTextBox";
            this.addTextBox.Size = new System.Drawing.Size(277, 72);
            this.addTextBox.TabIndex = 1;
            // 
            // encodebutton
            // 
            this.encodebutton.Location = new System.Drawing.Point(12, 136);
            this.encodebutton.Name = "encodebutton";
            this.encodebutton.Size = new System.Drawing.Size(138, 23);
            this.encodebutton.TabIndex = 2;
            this.encodebutton.Text = "Encode Text";
            this.encodebutton.UseVisualStyleBackColor = true;
            this.encodebutton.Click += new System.EventHandler(this.encodebutton_Click);
            // 
            // writebutton
            // 
            this.writebutton.Location = new System.Drawing.Point(13, 165);
            this.writebutton.Name = "writebutton";
            this.writebutton.Size = new System.Drawing.Size(137, 26);
            this.writebutton.TabIndex = 3;
            this.writebutton.Text = "Write to Image";
            this.writebutton.UseVisualStyleBackColor = true;
            this.writebutton.Click += new System.EventHandler(this.writebutton_Click);
            // 
            // findButton
            // 
            this.findButton.Location = new System.Drawing.Point(12, 255);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(138, 23);
            this.findButton.TabIndex = 4;
            this.findButton.Text = "Find Text";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // decodeButton
            // 
            this.decodeButton.Location = new System.Drawing.Point(12, 284);
            this.decodeButton.Name = "decodeButton";
            this.decodeButton.Size = new System.Drawing.Size(138, 23);
            this.decodeButton.TabIndex = 5;
            this.decodeButton.Text = "Decode Text";
            this.decodeButton.UseVisualStyleBackColor = true;
            this.decodeButton.Click += new System.EventHandler(this.decodeButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 314);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Text Found in Image";
            // 
            // foundTextBox
            // 
            this.foundTextBox.Location = new System.Drawing.Point(13, 334);
            this.foundTextBox.Multiline = true;
            this.foundTextBox.Name = "foundTextBox";
            this.foundTextBox.Size = new System.Drawing.Size(279, 73);
            this.foundTextBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "_________________";
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(484, 379);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(121, 28);
            this.openButton.TabIndex = 9;
            this.openButton.Text = "Open Image...";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(319, 78);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(434, 286);
            this.pictureBox.TabIndex = 10;
            this.pictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.foundTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.decodeButton);
            this.Controls.Add(this.findButton);
            this.Controls.Add(this.writebutton);
            this.Controls.Add(this.encodebutton);
            this.Controls.Add(this.addTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox addTextBox;
        private System.Windows.Forms.Button encodebutton;
        private System.Windows.Forms.Button writebutton;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.Button decodeButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox foundTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}

