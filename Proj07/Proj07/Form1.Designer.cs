namespace Proj07
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.addressBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.pingAllOnce = new System.Windows.Forms.Button();
            this.PingAllUser = new System.Windows.Forms.Button();
            this.pingNumberLabel = new System.Windows.Forms.Label();
            this.pingNumberBox = new System.Windows.Forms.TextBox();
            this.settingsButton = new System.Windows.Forms.Button();
            this.pingChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pingSelOnceButton = new System.Windows.Forms.Button();
            this.pingSelUserButton = new System.Windows.Forms.Button();
            this.pingSecondsBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pingChart)).BeginInit();
            this.SuspendLayout();
            // 
            // addressBox
            // 
            this.addressBox.FormattingEnabled = true;
            this.addressBox.ItemHeight = 16;
            this.addressBox.Location = new System.Drawing.Point(12, 29);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(192, 164);
            this.addressBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Addresses";
            // 
            // addBox
            // 
            this.addBox.Location = new System.Drawing.Point(12, 200);
            this.addBox.Name = "addBox";
            this.addBox.Size = new System.Drawing.Size(150, 22);
            this.addBox.TabIndex = 2;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(12, 228);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(97, 23);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Add URL";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(12, 258);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(150, 23);
            this.removeButton.TabIndex = 4;
            this.removeButton.Text = "Remove Selected";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // pingAllOnce
            // 
            this.pingAllOnce.Location = new System.Drawing.Point(12, 289);
            this.pingAllOnce.Name = "pingAllOnce";
            this.pingAllOnce.Size = new System.Drawing.Size(149, 27);
            this.pingAllOnce.TabIndex = 5;
            this.pingAllOnce.Text = "Ping All (1)";
            this.pingAllOnce.UseVisualStyleBackColor = true;
            this.pingAllOnce.Click += new System.EventHandler(this.pingAllOnce_Click);
            // 
            // PingAllUser
            // 
            this.PingAllUser.Location = new System.Drawing.Point(12, 322);
            this.PingAllUser.Name = "PingAllUser";
            this.PingAllUser.Size = new System.Drawing.Size(147, 27);
            this.PingAllUser.TabIndex = 6;
            this.PingAllUser.Text = "Ping All (x)";
            this.PingAllUser.UseVisualStyleBackColor = true;
            this.PingAllUser.Click += new System.EventHandler(this.PingAllUser_Click);
            // 
            // pingNumberLabel
            // 
            this.pingNumberLabel.AutoSize = true;
            this.pingNumberLabel.Location = new System.Drawing.Point(9, 434);
            this.pingNumberLabel.Name = "pingNumberLabel";
            this.pingNumberLabel.Size = new System.Drawing.Size(117, 17);
            this.pingNumberLabel.TabIndex = 7;
            this.pingNumberLabel.Text = "Number of Pings:";
            // 
            // pingNumberBox
            // 
            this.pingNumberBox.Location = new System.Drawing.Point(12, 454);
            this.pingNumberBox.Name = "pingNumberBox";
            this.pingNumberBox.Size = new System.Drawing.Size(32, 22);
            this.pingNumberBox.TabIndex = 8;
            // 
            // settingsButton
            // 
            this.settingsButton.Location = new System.Drawing.Point(12, 482);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(97, 32);
            this.settingsButton.TabIndex = 9;
            this.settingsButton.Text = "Settings";
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // pingChart
            // 
            chartArea1.Name = "ChartArea1";
            this.pingChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.pingChart.Legends.Add(legend1);
            this.pingChart.Location = new System.Drawing.Point(210, 29);
            this.pingChart.Name = "pingChart";
            this.pingChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "PingResults";
            this.pingChart.Series.Add(series1);
            this.pingChart.Size = new System.Drawing.Size(494, 485);
            this.pingChart.TabIndex = 10;
            this.pingChart.Text = "chart1";
            // 
            // pingSelOnceButton
            // 
            this.pingSelOnceButton.Location = new System.Drawing.Point(12, 356);
            this.pingSelOnceButton.Name = "pingSelOnceButton";
            this.pingSelOnceButton.Size = new System.Drawing.Size(147, 28);
            this.pingSelOnceButton.TabIndex = 11;
            this.pingSelOnceButton.Text = "Ping Selected (1)";
            this.pingSelOnceButton.UseVisualStyleBackColor = true;
            this.pingSelOnceButton.Click += new System.EventHandler(this.pingSelOnceButton_Click);
            // 
            // pingSelUserButton
            // 
            this.pingSelUserButton.Location = new System.Drawing.Point(12, 391);
            this.pingSelUserButton.Name = "pingSelUserButton";
            this.pingSelUserButton.Size = new System.Drawing.Size(147, 31);
            this.pingSelUserButton.TabIndex = 12;
            this.pingSelUserButton.Text = "Ping Selected (x)";
            this.pingSelUserButton.UseVisualStyleBackColor = true;
            this.pingSelUserButton.Click += new System.EventHandler(this.pingSelUserButton_Click);
            // 
            // pingSecondsBox
            // 
            this.pingSecondsBox.Location = new System.Drawing.Point(81, 454);
            this.pingSecondsBox.Name = "pingSecondsBox";
            this.pingSecondsBox.Size = new System.Drawing.Size(100, 22);
            this.pingSecondsBox.TabIndex = 13;
            this.pingSecondsBox.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 527);
            this.Controls.Add(this.pingSecondsBox);
            this.Controls.Add(this.pingSelUserButton);
            this.Controls.Add(this.pingSelOnceButton);
            this.Controls.Add(this.pingChart);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.pingNumberBox);
            this.Controls.Add(this.pingNumberLabel);
            this.Controls.Add(this.PingAllUser);
            this.Controls.Add(this.pingAllOnce);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.addBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addressBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pingChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox addressBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox addBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button pingAllOnce;
        private System.Windows.Forms.Button PingAllUser;
        private System.Windows.Forms.Label pingNumberLabel;
        private System.Windows.Forms.TextBox pingNumberBox;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart pingChart;
        private System.Windows.Forms.Button pingSelOnceButton;
        private System.Windows.Forms.Button pingSelUserButton;
        public System.Windows.Forms.TextBox pingSecondsBox;
    }
}

