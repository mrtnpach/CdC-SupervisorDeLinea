namespace ControlDeCalidadCliente.Presentacion.Vistas
{
    partial class GestionarOpVista
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
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.layoutPanelDatos = new System.Windows.Forms.TableLayoutPanel();
            this.numeroLabel = new System.Windows.Forms.Label();
            this.supervisorLabel = new System.Windows.Forms.Label();
            this.lineaLabel = new System.Windows.Forms.Label();
            this.modeloLabel = new System.Windows.Forms.Label();
            this.colorLabel = new System.Windows.Forms.Label();
            this.estadoLabel = new System.Windows.Forms.Label();
            this.tituloLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.reanudarButton = new System.Windows.Forms.Button();
            this.pausarButton = new System.Windows.Forms.Button();
            this.finalizarButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel.SuspendLayout();
            this.layoutPanelDatos.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.layoutPanelDatos, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.tituloLabel, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.tableLayoutPanel1, 0, 2);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 3;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.06724F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.86552F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.06724F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(889, 661);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // layoutPanelDatos
            // 
            this.layoutPanelDatos.BackColor = System.Drawing.SystemColors.ControlLight;
            this.layoutPanelDatos.ColumnCount = 1;
            this.layoutPanelDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutPanelDatos.Controls.Add(this.numeroLabel, 0, 0);
            this.layoutPanelDatos.Controls.Add(this.supervisorLabel, 0, 1);
            this.layoutPanelDatos.Controls.Add(this.lineaLabel, 0, 2);
            this.layoutPanelDatos.Controls.Add(this.modeloLabel, 0, 3);
            this.layoutPanelDatos.Controls.Add(this.colorLabel, 0, 4);
            this.layoutPanelDatos.Controls.Add(this.estadoLabel, 0, 5);
            this.layoutPanelDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutPanelDatos.Location = new System.Drawing.Point(3, 89);
            this.layoutPanelDatos.Name = "layoutPanelDatos";
            this.layoutPanelDatos.RowCount = 6;
            this.layoutPanelDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layoutPanelDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.layoutPanelDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.layoutPanelDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.layoutPanelDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.layoutPanelDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.layoutPanelDatos.Size = new System.Drawing.Size(883, 482);
            this.layoutPanelDatos.TabIndex = 0;
            // 
            // numeroLabel
            // 
            this.numeroLabel.AutoSize = true;
            this.numeroLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numeroLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numeroLabel.Location = new System.Drawing.Point(3, 0);
            this.numeroLabel.Name = "numeroLabel";
            this.numeroLabel.Size = new System.Drawing.Size(877, 120);
            this.numeroLabel.TabIndex = 0;
            this.numeroLabel.Text = "Numero de Orden:";
            this.numeroLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // supervisorLabel
            // 
            this.supervisorLabel.AutoSize = true;
            this.supervisorLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.supervisorLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.supervisorLabel.Location = new System.Drawing.Point(3, 120);
            this.supervisorLabel.Name = "supervisorLabel";
            this.supervisorLabel.Size = new System.Drawing.Size(877, 72);
            this.supervisorLabel.TabIndex = 1;
            this.supervisorLabel.Text = "Supervisor de Linea:";
            this.supervisorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lineaLabel
            // 
            this.lineaLabel.AutoSize = true;
            this.lineaLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lineaLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lineaLabel.Location = new System.Drawing.Point(3, 192);
            this.lineaLabel.Name = "lineaLabel";
            this.lineaLabel.Size = new System.Drawing.Size(877, 72);
            this.lineaLabel.TabIndex = 2;
            this.lineaLabel.Text = "Linea de Trabajo:";
            this.lineaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // modeloLabel
            // 
            this.modeloLabel.AutoSize = true;
            this.modeloLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.modeloLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.modeloLabel.Location = new System.Drawing.Point(3, 264);
            this.modeloLabel.Name = "modeloLabel";
            this.modeloLabel.Size = new System.Drawing.Size(877, 72);
            this.modeloLabel.TabIndex = 3;
            this.modeloLabel.Text = "Modelo:";
            this.modeloLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // colorLabel
            // 
            this.colorLabel.AutoSize = true;
            this.colorLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.colorLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.colorLabel.Location = new System.Drawing.Point(3, 336);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(877, 72);
            this.colorLabel.TabIndex = 4;
            this.colorLabel.Text = "Color:";
            this.colorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // estadoLabel
            // 
            this.estadoLabel.AutoSize = true;
            this.estadoLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.estadoLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.estadoLabel.Location = new System.Drawing.Point(3, 408);
            this.estadoLabel.Name = "estadoLabel";
            this.estadoLabel.Size = new System.Drawing.Size(877, 74);
            this.estadoLabel.TabIndex = 5;
            this.estadoLabel.Text = "Estado:";
            this.estadoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tituloLabel
            // 
            this.tituloLabel.AutoSize = true;
            this.tituloLabel.BackColor = System.Drawing.Color.SeaGreen;
            this.tituloLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tituloLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tituloLabel.ForeColor = System.Drawing.Color.White;
            this.tituloLabel.Location = new System.Drawing.Point(3, 0);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(883, 86);
            this.tituloLabel.TabIndex = 2;
            this.tituloLabel.Text = "Gestionar Orden de Producción";
            this.tituloLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel1.Controls.Add(this.reanudarButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pausarButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.finalizarButton, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 577);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(883, 81);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // reanudarButton
            // 
            this.reanudarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.reanudarButton.BackColor = System.Drawing.Color.SeaGreen;
            this.reanudarButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.reanudarButton.ForeColor = System.Drawing.Color.White;
            this.reanudarButton.Location = new System.Drawing.Point(10, 21);
            this.reanudarButton.Margin = new System.Windows.Forms.Padding(10);
            this.reanudarButton.Name = "reanudarButton";
            this.reanudarButton.Size = new System.Drawing.Size(271, 39);
            this.reanudarButton.TabIndex = 0;
            this.reanudarButton.Text = "Reanudar";
            this.reanudarButton.UseVisualStyleBackColor = false;
            this.reanudarButton.Click += new System.EventHandler(this.reanudarButton_Click);
            // 
            // pausarButton
            // 
            this.pausarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pausarButton.BackColor = System.Drawing.Color.Orange;
            this.pausarButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pausarButton.ForeColor = System.Drawing.Color.White;
            this.pausarButton.Location = new System.Drawing.Point(301, 21);
            this.pausarButton.Margin = new System.Windows.Forms.Padding(10);
            this.pausarButton.Name = "pausarButton";
            this.pausarButton.Size = new System.Drawing.Size(271, 39);
            this.pausarButton.TabIndex = 1;
            this.pausarButton.Text = "Pausar";
            this.pausarButton.UseVisualStyleBackColor = false;
            this.pausarButton.Click += new System.EventHandler(this.pausarButton_Click);
            // 
            // finalizarButton
            // 
            this.finalizarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.finalizarButton.BackColor = System.Drawing.Color.Red;
            this.finalizarButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.finalizarButton.ForeColor = System.Drawing.Color.White;
            this.finalizarButton.Location = new System.Drawing.Point(592, 21);
            this.finalizarButton.Margin = new System.Windows.Forms.Padding(10);
            this.finalizarButton.Name = "finalizarButton";
            this.finalizarButton.Size = new System.Drawing.Size(281, 39);
            this.finalizarButton.TabIndex = 2;
            this.finalizarButton.Text = "Finalizar";
            this.finalizarButton.UseVisualStyleBackColor = false;
            this.finalizarButton.Click += new System.EventHandler(this.finalizarButton_Click);
            // 
            // GestionarOpVista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 661);
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "GestionarOpVista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gestionar Orden de Producción";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.layoutPanelDatos.ResumeLayout(false);
            this.layoutPanelDatos.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel layoutPanelDatos;
        private System.Windows.Forms.Label tituloLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label numeroLabel;
        private System.Windows.Forms.Label supervisorLabel;
        private System.Windows.Forms.Label lineaLabel;
        private System.Windows.Forms.Label modeloLabel;
        private System.Windows.Forms.Label colorLabel;
        private System.Windows.Forms.Label estadoLabel;
        private System.Windows.Forms.Button reanudarButton;
        private System.Windows.Forms.Button pausarButton;
        private System.Windows.Forms.Button finalizarButton;
    }
}