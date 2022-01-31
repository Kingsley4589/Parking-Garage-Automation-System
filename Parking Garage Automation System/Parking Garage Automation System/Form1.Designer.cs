namespace zubeer
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
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.hometoolstr = new System.Windows.Forms.ToolStrip();
            this.tsbtnDriverTyoes = new System.Windows.Forms.ToolStripButton();
            this.tsbtnCarTypes = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnPersonRegistration = new System.Windows.Forms.ToolStripButton();
            this.tsbtnVehicles = new System.Windows.Forms.ToolStripButton();
            this.tsbtnCheckin = new System.Windows.Forms.ToolStripButton();
            this.tsbtnChekOut = new System.Windows.Forms.ToolStripButton();
            this.tsbtnHistory = new System.Windows.Forms.ToolStripButton();
            this.panelParent = new System.Windows.Forms.Panel();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hometoolstr.SuspendLayout();
            this.panelParent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 54);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.toolStripLabel2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 10);
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(69, 39);
            this.toolStripLabel2.Text = "Parking";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.toolStripLabel1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 10);
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(103, 39);
            this.toolStripLabel1.Text = "Registration";
            // 
            // hometoolstr
            // 
            this.hometoolstr.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.hometoolstr.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.hometoolstr.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnDriverTyoes,
            this.tsbtnCarTypes,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.tsbtnPersonRegistration,
            this.tsbtnVehicles,
            this.toolStripSeparator2,
            this.toolStripLabel2,
            this.tsbtnCheckin,
            this.tsbtnChekOut,
            this.tsbtnHistory});
            this.hometoolstr.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.hometoolstr.Location = new System.Drawing.Point(0, 0);
            this.hometoolstr.Name = "hometoolstr";
            this.hometoolstr.Size = new System.Drawing.Size(836, 54);
            this.hometoolstr.TabIndex = 2;
            this.hometoolstr.Text = "toolStrip1";
            // 
            // tsbtnDriverTyoes
            // 
            this.tsbtnDriverTyoes.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnDriverTyoes.Image")));
            this.tsbtnDriverTyoes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnDriverTyoes.Name = "tsbtnDriverTyoes";
            this.tsbtnDriverTyoes.Size = new System.Drawing.Size(67, 51);
            this.tsbtnDriverTyoes.Text = "Car Details";
            this.tsbtnDriverTyoes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnDriverTyoes.Click += new System.EventHandler(this.tsbtnDriverTyoes_Click);
            // 
            // tsbtnCarTypes
            // 
            this.tsbtnCarTypes.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnCarTypes.Image")));
            this.tsbtnCarTypes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnCarTypes.Name = "tsbtnCarTypes";
            this.tsbtnCarTypes.Size = new System.Drawing.Size(61, 51);
            this.tsbtnCarTypes.Text = "Car Types";
            this.tsbtnCarTypes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnCarTypes.Click += new System.EventHandler(this.tsbtnCarTypes_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 54);
            // 
            // tsbtnPersonRegistration
            // 
            this.tsbtnPersonRegistration.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnPersonRegistration.Image")));
            this.tsbtnPersonRegistration.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnPersonRegistration.Name = "tsbtnPersonRegistration";
            this.tsbtnPersonRegistration.Size = new System.Drawing.Size(74, 51);
            this.tsbtnPersonRegistration.Text = "Registration";
            this.tsbtnPersonRegistration.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnPersonRegistration.Click += new System.EventHandler(this.tsbtnPersonRegistration_Click);
            // 
            // tsbtnVehicles
            // 
            this.tsbtnVehicles.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnVehicles.Image")));
            this.tsbtnVehicles.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnVehicles.Name = "tsbtnVehicles";
            this.tsbtnVehicles.Size = new System.Drawing.Size(70, 51);
            this.tsbtnVehicles.Text = "All Vehicles";
            this.tsbtnVehicles.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnVehicles.Click += new System.EventHandler(this.tsbtnVehicles_Click);
            // 
            // tsbtnCheckin
            // 
            this.tsbtnCheckin.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnCheckin.Image")));
            this.tsbtnCheckin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnCheckin.Name = "tsbtnCheckin";
            this.tsbtnCheckin.Size = new System.Drawing.Size(57, 51);
            this.tsbtnCheckin.Text = "Check In";
            this.tsbtnCheckin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnCheckin.Click += new System.EventHandler(this.tsbtnCheckin_Click);
            // 
            // tsbtnChekOut
            // 
            this.tsbtnChekOut.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnChekOut.Image")));
            this.tsbtnChekOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnChekOut.Name = "tsbtnChekOut";
            this.tsbtnChekOut.Size = new System.Drawing.Size(56, 51);
            this.tsbtnChekOut.Text = "Retrieval";
            this.tsbtnChekOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnChekOut.Click += new System.EventHandler(this.tsbtnChekOut_Click);
            // 
            // tsbtnHistory
            // 
            this.tsbtnHistory.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnHistory.Image")));
            this.tsbtnHistory.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnHistory.Name = "tsbtnHistory";
            this.tsbtnHistory.Size = new System.Drawing.Size(92, 51);
            this.tsbtnHistory.Text = "Parking History";
            this.tsbtnHistory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnHistory.Click += new System.EventHandler(this.tsbtnHistory_Click);
            // 
            // panelParent
            // 
            this.panelParent.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelParent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelParent.BackgroundImage")));
            this.panelParent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelParent.Controls.Add(this.dataGridView3);
            this.panelParent.Controls.Add(this.dataGridView2);
            this.panelParent.Controls.Add(this.dataGridView1);
            this.panelParent.Controls.Add(this.hometoolstr);
            this.panelParent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelParent.Location = new System.Drawing.Point(0, 0);
            this.panelParent.Name = "panelParent";
            this.panelParent.Size = new System.Drawing.Size(836, 496);
            this.panelParent.TabIndex = 3;
            // 
            // dataGridView3
            // 
            this.dataGridView3.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(0, 54);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(40, 406);
            this.dataGridView3.TabIndex = 46;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(794, 54);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(40, 406);
            this.dataGridView2.TabIndex = 45;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 462);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(833, 34);
            this.dataGridView1.TabIndex = 44;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 496);
            this.Controls.Add(this.panelParent);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parking Garage Automation System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.hometoolstr.ResumeLayout(false);
            this.hometoolstr.PerformLayout();
            this.panelParent.ResumeLayout(false);
            this.panelParent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelParent;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton tsbtnCheckin;
        private System.Windows.Forms.ToolStripButton tsbtnChekOut;
        private System.Windows.Forms.ToolStripButton tsbtnPersonRegistration;
        private System.Windows.Forms.ToolStripButton tsbtnVehicles;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStrip hometoolstr;
        private System.Windows.Forms.ToolStripButton tsbtnDriverTyoes;
        private System.Windows.Forms.ToolStripButton tsbtnCarTypes;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbtnHistory;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

