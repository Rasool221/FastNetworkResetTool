namespace Fast_Network_Reset_Tool
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Adapter = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.macAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.refreshList = new System.Windows.Forms.Button();
            this.resetAllButton = new System.Windows.Forms.Button();
            this.adapterOnButton = new System.Windows.Forms.Button();
            this.adapterOffButton = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.statusLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(241, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(500, 312);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Network Adapter(s)";
            // 
            // listView1
            // 
            this.listView1.AutoArrange = false;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Adapter,
            this.Status,
            this.macAddress});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(7, 19);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(487, 277);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Adapter
            // 
            this.Adapter.Text = "Adapter";
            this.Adapter.Width = 195;
            // 
            // Status
            // 
            this.Status.Text = "Status";
            this.Status.Width = 82;
            // 
            // macAddress
            // 
            this.macAddress.Text = "MAC Address";
            this.macAddress.Width = 206;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.refreshList);
            this.groupBox2.Controls.Add(this.resetAllButton);
            this.groupBox2.Controls.Add(this.adapterOnButton);
            this.groupBox2.Controls.Add(this.adapterOffButton);
            this.groupBox2.Location = new System.Drawing.Point(13, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(222, 312);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Controls";
            // 
            // refreshList
            // 
            this.refreshList.Location = new System.Drawing.Point(6, 254);
            this.refreshList.Name = "refreshList";
            this.refreshList.Size = new System.Drawing.Size(210, 23);
            this.refreshList.TabIndex = 3;
            this.refreshList.Text = "Refresh Adapter List";
            this.refreshList.UseVisualStyleBackColor = true;
            this.refreshList.Click += new System.EventHandler(this.refreshList_Click);
            // 
            // resetAllButton
            // 
            this.resetAllButton.Location = new System.Drawing.Point(7, 283);
            this.resetAllButton.Name = "resetAllButton";
            this.resetAllButton.Size = new System.Drawing.Size(208, 23);
            this.resetAllButton.TabIndex = 2;
            this.resetAllButton.Text = "Reset All Adapters";
            this.resetAllButton.UseVisualStyleBackColor = true;
            this.resetAllButton.Click += new System.EventHandler(this.resetAllButton_Click);
            // 
            // adapterOnButton
            // 
            this.adapterOnButton.Enabled = false;
            this.adapterOnButton.Location = new System.Drawing.Point(7, 19);
            this.adapterOnButton.Name = "adapterOnButton";
            this.adapterOnButton.Size = new System.Drawing.Size(209, 23);
            this.adapterOnButton.TabIndex = 1;
            this.adapterOnButton.Text = "Turn Adapter On";
            this.adapterOnButton.UseVisualStyleBackColor = true;
            this.adapterOnButton.Click += new System.EventHandler(this.adapterOnButton_Click);
            // 
            // adapterOffButton
            // 
            this.adapterOffButton.Enabled = false;
            this.adapterOffButton.Location = new System.Drawing.Point(6, 48);
            this.adapterOffButton.Name = "adapterOffButton";
            this.adapterOffButton.Size = new System.Drawing.Size(209, 23);
            this.adapterOffButton.TabIndex = 0;
            this.adapterOffButton.Text = "Turn Adapter Off";
            this.adapterOffButton.UseVisualStyleBackColor = true;
            this.adapterOffButton.Click += new System.EventHandler(this.adapterOffButton_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(687, 389);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(48, 13);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "LinkedIn";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(641, 389);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(40, 13);
            this.linkLabel2.TabIndex = 3;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "GitHub";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(10, 389);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(81, 13);
            this.statusLabel.TabIndex = 4;
            this.statusLabel.Text = "Status: dormant";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 411);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Fast Network Adapter Reset Tool";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void linkLabel1_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/rasool-abbas-123393185/");
        }

        private void linkLabel2_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://github.com/Rasool221");
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Adapter;
        private System.Windows.Forms.ColumnHeader Status;
        private System.Windows.Forms.ColumnHeader macAddress;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Button resetAllButton;
        private System.Windows.Forms.Button adapterOnButton;
        private System.Windows.Forms.Button adapterOffButton;
        private System.Windows.Forms.Button refreshList;
        private System.Windows.Forms.Label statusLabel;
    }
}

