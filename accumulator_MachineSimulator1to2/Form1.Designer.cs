
namespace accumulator_MachineSimulator1to2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.plCpu = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.plInfo = new System.Windows.Forms.Panel();
            this.console = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.plTopMenu = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.masToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoArchivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirArchivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarCambiosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.plLeft = new System.Windows.Forms.Panel();
            this.txtCodif = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.plPlayer = new System.Windows.Forms.Panel();
            this.btnStop = new System.Windows.Forms.PictureBox();
            this.btnPause = new System.Windows.Forms.PictureBox();
            this.btnPlay = new System.Windows.Forms.PictureBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.dgvToken = new System.Windows.Forms.DataGridView();
            this.Token = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lexema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Linea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Indice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.plCpu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.plInfo.SuspendLayout();
            this.plTopMenu.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.plLeft.SuspendLayout();
            this.plPlayer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnStop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvToken)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.plCpu);
            this.panel1.Controls.Add(this.plInfo);
            this.panel1.Controls.Add(this.plTopMenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(639, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(673, 641);
            this.panel1.TabIndex = 3;
            // 
            // plCpu
            // 
            this.plCpu.Controls.Add(this.pictureBox1);
            this.plCpu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plCpu.Location = new System.Drawing.Point(0, 73);
            this.plCpu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.plCpu.Name = "plCpu";
            this.plCpu.Size = new System.Drawing.Size(673, 333);
            this.plCpu.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(673, 333);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.WaitOnLoad = true;
            // 
            // plInfo
            // 
            this.plInfo.BackColor = System.Drawing.Color.White;
            this.plInfo.Controls.Add(this.console);
            this.plInfo.Controls.Add(this.label1);
            this.plInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.plInfo.Location = new System.Drawing.Point(0, 406);
            this.plInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.plInfo.Name = "plInfo";
            this.plInfo.Size = new System.Drawing.Size(673, 235);
            this.plInfo.TabIndex = 1;
            // 
            // console
            // 
            this.console.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.console.Location = new System.Drawing.Point(12, 36);
            this.console.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.console.Name = "console";
            this.console.Size = new System.Drawing.Size(652, 187);
            this.console.TabIndex = 1;
            this.console.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consola";
            // 
            // plTopMenu
            // 
            this.plTopMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.plTopMenu.Controls.Add(this.menuStrip1);
            this.plTopMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.plTopMenu.Location = new System.Drawing.Point(0, 0);
            this.plTopMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.plTopMenu.Name = "plTopMenu";
            this.plTopMenu.Size = new System.Drawing.Size(673, 73);
            this.plTopMenu.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masToolStripMenuItem,
            this.masToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(673, 73);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // masToolStripMenuItem
            // 
            this.masToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoArchivoToolStripMenuItem,
            this.abrirArchivoToolStripMenuItem,
            this.guardarCambiosToolStripMenuItem});
            this.masToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.masToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.masToolStripMenuItem.Name = "masToolStripMenuItem";
            this.masToolStripMenuItem.Size = new System.Drawing.Size(104, 69);
            this.masToolStripMenuItem.Text = "Proyecto";
            // 
            // nuevoArchivoToolStripMenuItem
            // 
            this.nuevoArchivoToolStripMenuItem.Name = "nuevoArchivoToolStripMenuItem";
            this.nuevoArchivoToolStripMenuItem.Size = new System.Drawing.Size(247, 32);
            this.nuevoArchivoToolStripMenuItem.Text = "Nuevo archivo";
            this.nuevoArchivoToolStripMenuItem.Click += new System.EventHandler(this.nuevoArchivoToolStripMenuItem_Click);
            // 
            // abrirArchivoToolStripMenuItem
            // 
            this.abrirArchivoToolStripMenuItem.Name = "abrirArchivoToolStripMenuItem";
            this.abrirArchivoToolStripMenuItem.Size = new System.Drawing.Size(247, 32);
            this.abrirArchivoToolStripMenuItem.Text = "Abrir archivo";
            this.abrirArchivoToolStripMenuItem.Click += new System.EventHandler(this.abrirArchivoToolStripMenuItem_Click);
            // 
            // guardarCambiosToolStripMenuItem
            // 
            this.guardarCambiosToolStripMenuItem.Name = "guardarCambiosToolStripMenuItem";
            this.guardarCambiosToolStripMenuItem.Size = new System.Drawing.Size(247, 32);
            this.guardarCambiosToolStripMenuItem.Text = "Guardar cambios";
            this.guardarCambiosToolStripMenuItem.Click += new System.EventHandler(this.guardarCambiosToolStripMenuItem_Click);
            // 
            // masToolStripMenuItem1
            // 
            this.masToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.masToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.masToolStripMenuItem1.Name = "masToolStripMenuItem1";
            this.masToolStripMenuItem1.Size = new System.Drawing.Size(74, 69);
            this.masToolStripMenuItem1.Text = "Mas...";
            // 
            // plLeft
            // 
            this.plLeft.BackColor = System.Drawing.SystemColors.Control;
            this.plLeft.Controls.Add(this.dgvToken);
            this.plLeft.Controls.Add(this.txtCodif);
            this.plLeft.Controls.Add(this.label2);
            this.plLeft.Controls.Add(this.plPlayer);
            this.plLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.plLeft.Location = new System.Drawing.Point(0, 0);
            this.plLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.plLeft.Name = "plLeft";
            this.plLeft.Size = new System.Drawing.Size(639, 641);
            this.plLeft.TabIndex = 2;
            // 
            // txtCodif
            // 
            this.txtCodif.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtCodif.Location = new System.Drawing.Point(15, 102);
            this.txtCodif.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCodif.Name = "txtCodif";
            this.txtCodif.Size = new System.Drawing.Size(617, 303);
            this.txtCodif.TabIndex = 2;
            this.txtCodif.Text = "";
            this.txtCodif.TextChanged += new System.EventHandler(this.CodeChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Codificación";
            // 
            // plPlayer
            // 
            this.plPlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.plPlayer.Controls.Add(this.btnStop);
            this.plPlayer.Controls.Add(this.btnPause);
            this.plPlayer.Controls.Add(this.btnPlay);
            this.plPlayer.Dock = System.Windows.Forms.DockStyle.Top;
            this.plPlayer.Location = new System.Drawing.Point(0, 0);
            this.plPlayer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.plPlayer.Name = "plPlayer";
            this.plPlayer.Size = new System.Drawing.Size(639, 73);
            this.plPlayer.TabIndex = 0;
            // 
            // btnStop
            // 
            this.btnStop.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnStop.Location = new System.Drawing.Point(128, 0);
            this.btnStop.Margin = new System.Windows.Forms.Padding(11, 2, 3, 2);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(64, 73);
            this.btnStop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnStop.TabIndex = 2;
            this.btnStop.TabStop = false;
            // 
            // btnPause
            // 
            this.btnPause.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPause.Location = new System.Drawing.Point(64, 0);
            this.btnPause.Margin = new System.Windows.Forms.Padding(11, 2, 3, 2);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(64, 73);
            this.btnPause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnPause.TabIndex = 1;
            this.btnPause.TabStop = false;
            // 
            // btnPlay
            // 
            this.btnPlay.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPlay.Image = ((System.Drawing.Image)(resources.GetObject("btnPlay.Image")));
            this.btnPlay.Location = new System.Drawing.Point(0, 0);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(20, 2, 3, 2);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(64, 73);
            this.btnPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnPlay.TabIndex = 0;
            this.btnPlay.TabStop = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // dgvToken
            // 
            this.dgvToken.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvToken.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Token,
            this.Lexema,
            this.Linea,
            this.Columna,
            this.Indice});
            this.dgvToken.Location = new System.Drawing.Point(15, 410);
            this.dgvToken.Name = "dgvToken";
            this.dgvToken.RowHeadersWidth = 51;
            this.dgvToken.RowTemplate.Height = 24;
            this.dgvToken.Size = new System.Drawing.Size(617, 210);
            this.dgvToken.TabIndex = 3;
            // 
            // Token
            // 
            this.Token.HeaderText = "Token";
            this.Token.MinimumWidth = 6;
            this.Token.Name = "Token";
            this.Token.Width = 125;
            // 
            // Lexema
            // 
            this.Lexema.HeaderText = "Lexema";
            this.Lexema.MinimumWidth = 6;
            this.Lexema.Name = "Lexema";
            this.Lexema.Width = 125;
            // 
            // Linea
            // 
            this.Linea.HeaderText = "Linea";
            this.Linea.MinimumWidth = 6;
            this.Linea.Name = "Linea";
            this.Linea.Width = 125;
            // 
            // Columna
            // 
            this.Columna.HeaderText = "Columna";
            this.Columna.MinimumWidth = 6;
            this.Columna.Name = "Columna";
            this.Columna.Width = 125;
            // 
            // Indice
            // 
            this.Indice.HeaderText = "Indice";
            this.Indice.MinimumWidth = 6;
            this.Indice.Name = "Indice";
            this.Indice.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 641);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.plLeft);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1327, 678);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.plCpu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.plInfo.ResumeLayout(false);
            this.plInfo.PerformLayout();
            this.plTopMenu.ResumeLayout(false);
            this.plTopMenu.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.plLeft.ResumeLayout(false);
            this.plLeft.PerformLayout();
            this.plPlayer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnStop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvToken)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel plCpu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel plInfo;
        private System.Windows.Forms.RichTextBox console;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel plTopMenu;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem masToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masToolStripMenuItem1;
        private System.Windows.Forms.Panel plLeft;
        private System.Windows.Forms.RichTextBox txtCodif;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel plPlayer;
        private System.Windows.Forms.PictureBox btnStop;
        private System.Windows.Forms.PictureBox btnPause;
        private System.Windows.Forms.PictureBox btnPlay;
        private System.Windows.Forms.ToolStripMenuItem nuevoArchivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirArchivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarCambiosToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.DataGridView dgvToken;
        private System.Windows.Forms.DataGridViewTextBoxColumn Token;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lexema;
        private System.Windows.Forms.DataGridViewTextBoxColumn Linea;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columna;
        private System.Windows.Forms.DataGridViewTextBoxColumn Indice;
    }
}

