﻿
namespace ControlDeCalidadCliente.Presentacion.Vistas
{
    partial class MenuPrincipalVista
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ordenesDeProduccinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearOrdernDeProducciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarOPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.semaforoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ordenesDeProduccinToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1034, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ordenesDeProduccinToolStripMenuItem
            // 
            this.ordenesDeProduccinToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearOrdernDeProducciónToolStripMenuItem,
            this.gestionarOPToolStripMenuItem,
            this.semaforoToolStripMenuItem});
            this.ordenesDeProduccinToolStripMenuItem.Name = "ordenesDeProduccinToolStripMenuItem";
            this.ordenesDeProduccinToolStripMenuItem.Size = new System.Drawing.Size(177, 24);
            this.ordenesDeProduccinToolStripMenuItem.Text = "Ordenes de Produccion";
            // 
            // crearOrdernDeProducciónToolStripMenuItem
            // 
            this.crearOrdernDeProducciónToolStripMenuItem.Name = "crearOrdernDeProducciónToolStripMenuItem";
            this.crearOrdernDeProducciónToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.crearOrdernDeProducciónToolStripMenuItem.Text = "Crear Nueva OP";
            this.crearOrdernDeProducciónToolStripMenuItem.Click += new System.EventHandler(this.crearOrdernDeProduccionToolStripMenuItem_Click);
            // 
            // gestionarOPToolStripMenuItem
            // 
            this.gestionarOPToolStripMenuItem.Name = "gestionarOPToolStripMenuItem";
            this.gestionarOPToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.gestionarOPToolStripMenuItem.Text = "Gestionar OP";
            this.gestionarOPToolStripMenuItem.Click += new System.EventHandler(this.gestionarOPToolStripMenuItem_Click_1);
            // 
            // semaforoToolStripMenuItem
            // 
            this.semaforoToolStripMenuItem.Name = "semaforoToolStripMenuItem";
            this.semaforoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.semaforoToolStripMenuItem.Text = "Semaforo";
            this.semaforoToolStripMenuItem.Click += new System.EventHandler(this.semaforoToolStripMenuItem_Click);
            // 
            // MenuPrincipalVista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 663);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuPrincipalVista";
            this.Text = "Menu Principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuPrincipalVista_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ordenesDeProduccinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearOrdernDeProducciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarOPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem semaforoToolStripMenuItem;
    }
}