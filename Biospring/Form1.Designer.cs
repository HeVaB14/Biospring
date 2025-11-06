namespace Biospring
{
    partial class Home
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.barratitulo = new System.Windows.Forms.Panel();
            this.panelcontenedor = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnExpandir = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnAbonos = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnCreditos = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnGastos = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnVentas = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnClientes = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MenuVertical.SuspendLayout();
            this.barratitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExpandir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(163)))), ((int)(((byte)(182)))));
            this.MenuVertical.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MenuVertical.Controls.Add(this.btnAbonos);
            this.MenuVertical.Controls.Add(this.btnCreditos);
            this.MenuVertical.Controls.Add(this.btnGastos);
            this.MenuVertical.Controls.Add(this.btnVentas);
            this.MenuVertical.Controls.Add(this.btnClientes);
            this.MenuVertical.Controls.Add(this.pictureBox1);
            this.MenuVertical.Cursor = System.Windows.Forms.Cursors.Cross;
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 0);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(246, 909);
            this.MenuVertical.TabIndex = 0;
            // 
            // barratitulo
            // 
            this.barratitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.barratitulo.Controls.Add(this.btnCerrar);
            this.barratitulo.Controls.Add(this.btnExpandir);
            this.barratitulo.Controls.Add(this.btnMinimizar);
            this.barratitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.barratitulo.Location = new System.Drawing.Point(246, 0);
            this.barratitulo.Name = "barratitulo";
            this.barratitulo.Size = new System.Drawing.Size(1310, 74);
            this.barratitulo.TabIndex = 1;
            this.barratitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.barratitulo_MouseDown);
            // 
            // panelcontenedor
            // 
            this.panelcontenedor.AutoSize = true;
            this.panelcontenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(204)))), ((int)(((byte)(230)))));
            this.panelcontenedor.BackgroundImage = global::Biospring.Properties.Resources._1762403840209;
            this.panelcontenedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelcontenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelcontenedor.Location = new System.Drawing.Point(246, 74);
            this.panelcontenedor.Name = "panelcontenedor";
            this.panelcontenedor.Size = new System.Drawing.Size(1310, 835);
            this.panelcontenedor.TabIndex = 2;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.Teal;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1199, 0);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(57, 49);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnExpandir
            // 
            this.btnExpandir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExpandir.Image = ((System.Drawing.Image)(resources.GetObject("btnExpandir.Image")));
            this.btnExpandir.Location = new System.Drawing.Point(1134, 3);
            this.btnExpandir.Margin = new System.Windows.Forms.Padding(4);
            this.btnExpandir.Name = "btnExpandir";
            this.btnExpandir.Size = new System.Drawing.Size(57, 49);
            this.btnExpandir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExpandir.TabIndex = 5;
            this.btnExpandir.TabStop = false;
            this.btnExpandir.Click += new System.EventHandler(this.btnExpandir_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.BackColor = System.Drawing.Color.Teal;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimizar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(1073, 4);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(53, 49);
            this.btnMinimizar.TabIndex = 3;
            this.btnMinimizar.UseVisualStyleBackColor = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnAbonos
            // 
            this.btnAbonos.ActiveBorderThickness = 1;
            this.btnAbonos.ActiveCornerRadius = 20;
            this.btnAbonos.ActiveFillColor = System.Drawing.Color.Honeydew;
            this.btnAbonos.ActiveForecolor = System.Drawing.Color.White;
            this.btnAbonos.ActiveLineColor = System.Drawing.SystemColors.GrayText;
            this.btnAbonos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(163)))), ((int)(((byte)(182)))));
            this.btnAbonos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAbonos.BackgroundImage")));
            this.btnAbonos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnAbonos.ButtonText = "Abonos";
            this.btnAbonos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbonos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbonos.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnAbonos.IdleBorderThickness = 1;
            this.btnAbonos.IdleCornerRadius = 20;
            this.btnAbonos.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(102)))), ((int)(((byte)(189)))));
            this.btnAbonos.IdleForecolor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAbonos.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnAbonos.Location = new System.Drawing.Point(3, 593);
            this.btnAbonos.Margin = new System.Windows.Forms.Padding(6);
            this.btnAbonos.Name = "btnAbonos";
            this.btnAbonos.Size = new System.Drawing.Size(240, 65);
            this.btnAbonos.TabIndex = 5;
            this.btnAbonos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCreditos
            // 
            this.btnCreditos.ActiveBorderThickness = 1;
            this.btnCreditos.ActiveCornerRadius = 20;
            this.btnCreditos.ActiveFillColor = System.Drawing.Color.Honeydew;
            this.btnCreditos.ActiveForecolor = System.Drawing.Color.White;
            this.btnCreditos.ActiveLineColor = System.Drawing.SystemColors.GrayText;
            this.btnCreditos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(163)))), ((int)(((byte)(182)))));
            this.btnCreditos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCreditos.BackgroundImage")));
            this.btnCreditos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnCreditos.ButtonText = "Creditos";
            this.btnCreditos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreditos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreditos.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnCreditos.IdleBorderThickness = 1;
            this.btnCreditos.IdleCornerRadius = 20;
            this.btnCreditos.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(102)))), ((int)(((byte)(189)))));
            this.btnCreditos.IdleForecolor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCreditos.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnCreditos.Location = new System.Drawing.Point(0, 503);
            this.btnCreditos.Margin = new System.Windows.Forms.Padding(6);
            this.btnCreditos.Name = "btnCreditos";
            this.btnCreditos.Size = new System.Drawing.Size(240, 65);
            this.btnCreditos.TabIndex = 4;
            this.btnCreditos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGastos
            // 
            this.btnGastos.ActiveBorderThickness = 1;
            this.btnGastos.ActiveCornerRadius = 20;
            this.btnGastos.ActiveFillColor = System.Drawing.Color.Honeydew;
            this.btnGastos.ActiveForecolor = System.Drawing.Color.White;
            this.btnGastos.ActiveLineColor = System.Drawing.Color.GreenYellow;
            this.btnGastos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(163)))), ((int)(((byte)(182)))));
            this.btnGastos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGastos.BackgroundImage")));
            this.btnGastos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnGastos.ButtonText = "Gastos";
            this.btnGastos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGastos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGastos.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnGastos.IdleBorderThickness = 1;
            this.btnGastos.IdleCornerRadius = 20;
            this.btnGastos.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(102)))), ((int)(((byte)(189)))));
            this.btnGastos.IdleForecolor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGastos.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnGastos.Location = new System.Drawing.Point(3, 405);
            this.btnGastos.Margin = new System.Windows.Forms.Padding(6);
            this.btnGastos.Name = "btnGastos";
            this.btnGastos.Size = new System.Drawing.Size(240, 65);
            this.btnGastos.TabIndex = 3;
            this.btnGastos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnVentas
            // 
            this.btnVentas.ActiveBorderThickness = 1;
            this.btnVentas.ActiveCornerRadius = 20;
            this.btnVentas.ActiveFillColor = System.Drawing.Color.Honeydew;
            this.btnVentas.ActiveForecolor = System.Drawing.Color.White;
            this.btnVentas.ActiveLineColor = System.Drawing.Color.GreenYellow;
            this.btnVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(163)))), ((int)(((byte)(182)))));
            this.btnVentas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVentas.BackgroundImage")));
            this.btnVentas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnVentas.ButtonText = "Ventas";
            this.btnVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVentas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentas.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnVentas.IdleBorderThickness = 1;
            this.btnVentas.IdleCornerRadius = 20;
            this.btnVentas.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(102)))), ((int)(((byte)(189)))));
            this.btnVentas.IdleForecolor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVentas.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnVentas.Location = new System.Drawing.Point(3, 305);
            this.btnVentas.Margin = new System.Windows.Forms.Padding(6);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(240, 65);
            this.btnVentas.TabIndex = 2;
            this.btnVentas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClientes
            // 
            this.btnClientes.ActiveBorderThickness = 1;
            this.btnClientes.ActiveCornerRadius = 20;
            this.btnClientes.ActiveFillColor = System.Drawing.Color.Transparent;
            this.btnClientes.ActiveForecolor = System.Drawing.Color.White;
            this.btnClientes.ActiveLineColor = System.Drawing.Color.GreenYellow;
            this.btnClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(163)))), ((int)(((byte)(182)))));
            this.btnClientes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClientes.BackgroundImage")));
            this.btnClientes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnClientes.ButtonText = "Clientes";
            this.btnClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClientes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnClientes.IdleBorderThickness = 1;
            this.btnClientes.IdleCornerRadius = 20;
            this.btnClientes.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(102)))), ((int)(((byte)(189)))));
            this.btnClientes.IdleForecolor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClientes.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnClientes.Location = new System.Drawing.Point(3, 229);
            this.btnClientes.Margin = new System.Windows.Forms.Padding(6);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(240, 64);
            this.btnClientes.TabIndex = 1;
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Biospring.Properties.Resources._1762403840209;
            this.pictureBox1.Location = new System.Drawing.Point(6, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1556, 909);
            this.Controls.Add(this.panelcontenedor);
            this.Controls.Add(this.barratitulo);
            this.Controls.Add(this.MenuVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.Text = "Form1";
            this.MenuVertical.ResumeLayout(false);
            this.barratitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnExpandir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.Panel barratitulo;
        private System.Windows.Forms.Panel panelcontenedor;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.PictureBox btnExpandir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnClientes;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAbonos;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCreditos;
        private Bunifu.Framework.UI.BunifuThinButton2 btnGastos;
        private Bunifu.Framework.UI.BunifuThinButton2 btnVentas;
    }
}

