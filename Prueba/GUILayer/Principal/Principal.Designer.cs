
namespace Prueba.GUILayer
{
    partial class FrmPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.Exit = new System.Windows.Forms.PictureBox();
            this.BtnClient = new System.Windows.Forms.Button();
            this.BtnStock = new System.Windows.Forms.Button();
            this.BtnSales = new System.Windows.Forms.Button();
            this.BtnPurchases = new System.Windows.Forms.Button();
            this.BtnEmployee = new System.Windows.Forms.Button();
            this.BtnReport = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.PnlPrueba = new System.Windows.Forms.Panel();
            this.SlidePic = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Prb = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.asdsaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SlidePic)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Transparent;
            this.Exit.Image = ((System.Drawing.Image)(resources.GetObject("Exit.Image")));
            this.Exit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Exit.Location = new System.Drawing.Point(1035, 0);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(25, 25);
            this.Exit.TabIndex = 4;
            this.Exit.TabStop = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // BtnClient
            // 
            this.BtnClient.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BtnClient.BackColor = System.Drawing.Color.Transparent;
            this.BtnClient.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnClient.BackgroundImage")));
            this.BtnClient.FlatAppearance.BorderSize = 0;
            this.BtnClient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BtnClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClient.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClient.Location = new System.Drawing.Point(12, 158);
            this.BtnClient.Name = "BtnClient";
            this.BtnClient.Size = new System.Drawing.Size(162, 46);
            this.BtnClient.TabIndex = 5;
            this.BtnClient.Text = "Clientes";
            this.BtnClient.UseVisualStyleBackColor = false;
            this.BtnClient.Click += new System.EventHandler(this.BtnClient_Click);
            // 
            // BtnStock
            // 
            this.BtnStock.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BtnStock.BackColor = System.Drawing.Color.Transparent;
            this.BtnStock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnStock.BackgroundImage")));
            this.BtnStock.FlatAppearance.BorderSize = 0;
            this.BtnStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnStock.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStock.Location = new System.Drawing.Point(12, 270);
            this.BtnStock.Name = "BtnStock";
            this.BtnStock.Size = new System.Drawing.Size(162, 46);
            this.BtnStock.TabIndex = 7;
            this.BtnStock.Text = "Stock";
            this.BtnStock.UseVisualStyleBackColor = false;
            this.BtnStock.Click += new System.EventHandler(this.BtnStock_Click);
            // 
            // BtnSales
            // 
            this.BtnSales.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BtnSales.BackColor = System.Drawing.Color.Transparent;
            this.BtnSales.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSales.BackgroundImage")));
            this.BtnSales.FlatAppearance.BorderSize = 0;
            this.BtnSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSales.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSales.Location = new System.Drawing.Point(12, 214);
            this.BtnSales.Name = "BtnSales";
            this.BtnSales.Size = new System.Drawing.Size(162, 46);
            this.BtnSales.TabIndex = 6;
            this.BtnSales.Text = "Ventas";
            this.BtnSales.UseVisualStyleBackColor = false;
            this.BtnSales.Click += new System.EventHandler(this.BtnSales_Click);
            // 
            // BtnPurchases
            // 
            this.BtnPurchases.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BtnPurchases.BackColor = System.Drawing.Color.Transparent;
            this.BtnPurchases.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnPurchases.BackgroundImage")));
            this.BtnPurchases.FlatAppearance.BorderSize = 0;
            this.BtnPurchases.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPurchases.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPurchases.Location = new System.Drawing.Point(12, 326);
            this.BtnPurchases.Name = "BtnPurchases";
            this.BtnPurchases.Size = new System.Drawing.Size(162, 46);
            this.BtnPurchases.TabIndex = 8;
            this.BtnPurchases.Text = "Compras";
            this.BtnPurchases.UseVisualStyleBackColor = false;
            this.BtnPurchases.Click += new System.EventHandler(this.BtnPurchases_Click);
            // 
            // BtnEmployee
            // 
            this.BtnEmployee.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BtnEmployee.BackColor = System.Drawing.Color.Transparent;
            this.BtnEmployee.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnEmployee.BackgroundImage")));
            this.BtnEmployee.FlatAppearance.BorderSize = 0;
            this.BtnEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEmployee.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEmployee.Location = new System.Drawing.Point(12, 382);
            this.BtnEmployee.Name = "BtnEmployee";
            this.BtnEmployee.Size = new System.Drawing.Size(162, 46);
            this.BtnEmployee.TabIndex = 9;
            this.BtnEmployee.Text = "Empleados";
            this.BtnEmployee.UseVisualStyleBackColor = false;
            this.BtnEmployee.Click += new System.EventHandler(this.BtnEmployee_Click);
            // 
            // BtnReport
            // 
            this.BtnReport.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BtnReport.BackColor = System.Drawing.Color.Transparent;
            this.BtnReport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnReport.BackgroundImage")));
            this.BtnReport.FlatAppearance.BorderSize = 0;
            this.BtnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReport.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReport.Location = new System.Drawing.Point(12, 438);
            this.BtnReport.Name = "BtnReport";
            this.BtnReport.Size = new System.Drawing.Size(162, 46);
            this.BtnReport.TabIndex = 10;
            this.BtnReport.Text = "Reportes";
            this.BtnReport.UseVisualStyleBackColor = false;
            this.BtnReport.Click += new System.EventHandler(this.BtnReport_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // PnlPrueba
            // 
            this.PnlPrueba.BackColor = System.Drawing.Color.Transparent;
            this.PnlPrueba.Location = new System.Drawing.Point(245, 73);
            this.PnlPrueba.Name = "PnlPrueba";
            this.PnlPrueba.Size = new System.Drawing.Size(729, 604);
            this.PnlPrueba.TabIndex = 16;
            // 
            // SlidePic
            // 
            this.SlidePic.ErrorImage = null;
            this.SlidePic.Image = ((System.Drawing.Image)(resources.GetObject("SlidePic.Image")));
            this.SlidePic.ImageLocation = "";
            this.SlidePic.Location = new System.Drawing.Point(183, 186);
            this.SlidePic.Name = "SlidePic";
            this.SlidePic.Size = new System.Drawing.Size(697, 329);
            this.SlidePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SlidePic.TabIndex = 18;
            this.SlidePic.TabStop = false;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(15, 490);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 46);
            this.button1.TabIndex = 19;
            this.button1.Text = "Usuarios";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Prb
            // 
            this.Prb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Prb.BackColor = System.Drawing.Color.Transparent;
            this.Prb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Prb.BackgroundImage")));
            this.Prb.FlatAppearance.BorderSize = 0;
            this.Prb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Prb.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Prb.Location = new System.Drawing.Point(15, 542);
            this.Prb.Name = "Prb";
            this.Prb.Size = new System.Drawing.Size(162, 46);
            this.Prb.TabIndex = 20;
            this.Prb.Text = "Proveedores";
            this.Prb.UseVisualStyleBackColor = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asdsaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(1062, 44);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // asdsaToolStripMenuItem
            // 
            this.asdsaToolStripMenuItem.Name = "asdsaToolStripMenuItem";
            this.asdsaToolStripMenuItem.Size = new System.Drawing.Size(27, 40);
            this.asdsaToolStripMenuItem.Text = "asdsa";
            this.asdsaToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1062, 701);
            this.Controls.Add(this.Prb);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnReport);
            this.Controls.Add(this.BtnEmployee);
            this.Controls.Add(this.BtnPurchases);
            this.Controls.Add(this.BtnSales);
            this.Controls.Add(this.BtnStock);
            this.Controls.Add(this.BtnClient);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.PnlPrueba);
            this.Controls.Add(this.SlidePic);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrincipal";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmPrincipal_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SlidePic)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Exit;
        private System.Windows.Forms.Button BtnClient;
        private System.Windows.Forms.Button BtnStock;
        private System.Windows.Forms.Button BtnSales;
        private System.Windows.Forms.Button BtnPurchases;
        private System.Windows.Forms.Button BtnEmployee;
        private System.Windows.Forms.Button BtnReport;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel PnlPrueba;
        private System.Windows.Forms.PictureBox SlidePic;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Prb;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem asdsaToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}