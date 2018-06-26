namespace TEST1
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.IPAdress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Availability = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Virtual = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SystemName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RobotWareVersionAndControllerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bScanner = new System.Windows.Forms.Button();
            this.bStartRAPID = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IPAdress,
            this.Availability,
            this.Virtual,
            this.SystemName,
            this.RobotWareVersionAndControllerName});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(12, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(808, 278);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // IPAdress
            // 
            this.IPAdress.Text = "IPAdress";
            this.IPAdress.Width = 132;
            // 
            // Availability
            // 
            this.Availability.Text = "Availability";
            this.Availability.Width = 86;
            // 
            // Virtual
            // 
            this.Virtual.Text = "Virtual";
            this.Virtual.Width = 64;
            // 
            // SystemName
            // 
            this.SystemName.Text = "System Name";
            this.SystemName.Width = 106;
            // 
            // RobotWareVersionAndControllerName
            // 
            this.RobotWareVersionAndControllerName.Text = "RobotWareVersion and Controller name";
            this.RobotWareVersionAndControllerName.Width = 390;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bScanner);
            this.panel1.Controls.Add(this.bStartRAPID);
            this.panel1.Location = new System.Drawing.Point(12, 302);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(808, 119);
            this.panel1.TabIndex = 1;
            // 
            // bScanner
            // 
            this.bScanner.Location = new System.Drawing.Point(194, 24);
            this.bScanner.Name = "bScanner";
            this.bScanner.Size = new System.Drawing.Size(143, 71);
            this.bScanner.TabIndex = 1;
            this.bScanner.Text = "Scan sieci";
            this.bScanner.UseVisualStyleBackColor = true;
            this.bScanner.Click += new System.EventHandler(this.button1_Click);
            // 
            // bStartRAPID
            // 
            this.bStartRAPID.Location = new System.Drawing.Point(28, 24);
            this.bStartRAPID.Name = "bStartRAPID";
            this.bStartRAPID.Size = new System.Drawing.Size(135, 71);
            this.bStartRAPID.TabIndex = 0;
            this.bStartRAPID.Text = "Start RAPID Program";
            this.bStartRAPID.UseVisualStyleBackColor = true;
            this.bStartRAPID.Click += new System.EventHandler(this.bStartRAPID_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 433);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Network Scanning for Robot ABB";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader IPAdress;
        private System.Windows.Forms.ColumnHeader Availability;
        private System.Windows.Forms.ColumnHeader Virtual;
        private System.Windows.Forms.ColumnHeader SystemName;
        private System.Windows.Forms.ColumnHeader RobotWareVersionAndControllerName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bStartRAPID;
        private System.Windows.Forms.Button bScanner;
    }
}

