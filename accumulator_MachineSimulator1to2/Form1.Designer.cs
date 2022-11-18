
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.plCpu = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.plInfo = new System.Windows.Forms.Panel();
            this.dgvToken = new System.Windows.Forms.DataGridView();
            this.Token = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lexema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Linea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Indice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.plTopMenu = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.masToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoArchivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirArchivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarCambiosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diagramaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.console = new System.Windows.Forms.RichTextBox();
            this.plLeft = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodif = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.plPlayer = new System.Windows.Forms.Panel();
            this.btnStop = new System.Windows.Forms.PictureBox();
            this.btnPause = new System.Windows.Forms.PictureBox();
            this.btnPlay = new System.Windows.Forms.PictureBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.dgVars = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbPC = new System.Windows.Forms.Label();
            this.lbZ = new System.Windows.Forms.Label();
            this.lbInst = new System.Windows.Forms.Label();
            this.lbMAR = new System.Windows.Forms.Label();
            this.lbMDR = new System.Windows.Forms.Label();
            this.lbY = new System.Windows.Forms.Label();
            this.lbX = new System.Windows.Forms.Label();
            this.lbOperator = new System.Windows.Forms.Label();
            this.ejemplosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.plCpu.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.plInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvToken)).BeginInit();
            this.plTopMenu.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.plLeft.SuspendLayout();
            this.plPlayer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnStop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgVars)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.plCpu);
            this.panel1.Controls.Add(this.plInfo);
            this.panel1.Controls.Add(this.plTopMenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(479, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(805, 727);
            this.panel1.TabIndex = 3;
            // 
            // plCpu
            // 
            this.plCpu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.plCpu.Controls.Add(this.tabControl1);
            this.plCpu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plCpu.Location = new System.Drawing.Point(0, 59);
            this.plCpu.Margin = new System.Windows.Forms.Padding(2);
            this.plCpu.Name = "plCpu";
            this.plCpu.Size = new System.Drawing.Size(805, 477);
            this.plCpu.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(805, 477);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabPage1.Controls.Add(this.lbOperator);
            this.tabPage1.Controls.Add(this.lbX);
            this.tabPage1.Controls.Add(this.lbY);
            this.tabPage1.Controls.Add(this.lbMDR);
            this.tabPage1.Controls.Add(this.lbMAR);
            this.tabPage1.Controls.Add(this.lbInst);
            this.tabPage1.Controls.Add(this.lbZ);
            this.tabPage1.Controls.Add(this.lbPC);
            this.tabPage1.Controls.Add(this.dgVars);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(797, 451);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "CPU";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::accumulator_MachineSimulator1to2.Properties.Resources.CPU;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(791, 445);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(697, 285);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "E / S";
            // 
            // plInfo
            // 
            this.plInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.plInfo.Controls.Add(this.dgvToken);
            this.plInfo.Controls.Add(this.label1);
            this.plInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.plInfo.Location = new System.Drawing.Point(0, 536);
            this.plInfo.Margin = new System.Windows.Forms.Padding(2);
            this.plInfo.Name = "plInfo";
            this.plInfo.Size = new System.Drawing.Size(805, 191);
            this.plInfo.TabIndex = 1;
            // 
            // dgvToken
            // 
            this.dgvToken.AllowUserToAddRows = false;
            this.dgvToken.AllowUserToDeleteRows = false;
            this.dgvToken.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvToken.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvToken.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dgvToken.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvToken.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvToken.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvToken.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Token,
            this.Lexema,
            this.Linea,
            this.Columna,
            this.Indice});
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvToken.DefaultCellStyle = dataGridViewCellStyle19;
            this.dgvToken.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.dgvToken.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgvToken.Location = new System.Drawing.Point(9, 28);
            this.dgvToken.Margin = new System.Windows.Forms.Padding(2);
            this.dgvToken.Name = "dgvToken";
            this.dgvToken.ReadOnly = true;
            this.dgvToken.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvToken.RowHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.dgvToken.RowHeadersWidth = 51;
            this.dgvToken.RowTemplate.Height = 24;
            this.dgvToken.Size = new System.Drawing.Size(785, 152);
            this.dgvToken.TabIndex = 3;
            // 
            // Token
            // 
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.ControlLight;
            this.Token.DefaultCellStyle = dataGridViewCellStyle18;
            this.Token.HeaderText = "Token";
            this.Token.MinimumWidth = 6;
            this.Token.Name = "Token";
            this.Token.ReadOnly = true;
            // 
            // Lexema
            // 
            this.Lexema.HeaderText = "Lexema";
            this.Lexema.MinimumWidth = 6;
            this.Lexema.Name = "Lexema";
            this.Lexema.ReadOnly = true;
            // 
            // Linea
            // 
            this.Linea.HeaderText = "Linea";
            this.Linea.MinimumWidth = 6;
            this.Linea.Name = "Linea";
            this.Linea.ReadOnly = true;
            // 
            // Columna
            // 
            this.Columna.HeaderText = "Columna";
            this.Columna.MinimumWidth = 6;
            this.Columna.Name = "Columna";
            this.Columna.ReadOnly = true;
            // 
            // Indice
            // 
            this.Indice.HeaderText = "Indice";
            this.Indice.MinimumWidth = 6;
            this.Indice.Name = "Indice";
            this.Indice.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(5, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lexemas";
            // 
            // plTopMenu
            // 
            this.plTopMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.plTopMenu.Controls.Add(this.menuStrip1);
            this.plTopMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.plTopMenu.Location = new System.Drawing.Point(0, 0);
            this.plTopMenu.Margin = new System.Windows.Forms.Padding(2);
            this.plTopMenu.Name = "plTopMenu";
            this.plTopMenu.Size = new System.Drawing.Size(805, 59);
            this.plTopMenu.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masToolStripMenuItem,
            this.verToolStripMenuItem,
            this.ejemplosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuStrip1.Size = new System.Drawing.Size(805, 59);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // masToolStripMenuItem
            // 
            this.masToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.masToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoArchivoToolStripMenuItem,
            this.abrirArchivoToolStripMenuItem,
            this.guardarCambiosToolStripMenuItem});
            this.masToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.masToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.masToolStripMenuItem.Name = "masToolStripMenuItem";
            this.masToolStripMenuItem.Size = new System.Drawing.Size(83, 55);
            this.masToolStripMenuItem.Text = "Proyecto";
            // 
            // nuevoArchivoToolStripMenuItem
            // 
            this.nuevoArchivoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.nuevoArchivoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.nuevoArchivoToolStripMenuItem.Name = "nuevoArchivoToolStripMenuItem";
            this.nuevoArchivoToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.nuevoArchivoToolStripMenuItem.Text = "Nuevo archivo";
            this.nuevoArchivoToolStripMenuItem.Click += new System.EventHandler(this.nuevoArchivoToolStripMenuItem_Click);
            // 
            // abrirArchivoToolStripMenuItem
            // 
            this.abrirArchivoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.abrirArchivoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.abrirArchivoToolStripMenuItem.Name = "abrirArchivoToolStripMenuItem";
            this.abrirArchivoToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.abrirArchivoToolStripMenuItem.Text = "Abrir archivo";
            this.abrirArchivoToolStripMenuItem.Click += new System.EventHandler(this.abrirArchivoToolStripMenuItem_Click);
            // 
            // guardarCambiosToolStripMenuItem
            // 
            this.guardarCambiosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.guardarCambiosToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.guardarCambiosToolStripMenuItem.Name = "guardarCambiosToolStripMenuItem";
            this.guardarCambiosToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.guardarCambiosToolStripMenuItem.Text = "Guardar cambios";
            this.guardarCambiosToolStripMenuItem.Click += new System.EventHandler(this.guardarCambiosToolStripMenuItem_Click);
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.diagramaToolStripMenuItem});
            this.verToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(45, 55);
            this.verToolStripMenuItem.Text = "Ver";
            // 
            // diagramaToolStripMenuItem
            // 
            this.diagramaToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.diagramaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.diagramaToolStripMenuItem.Name = "diagramaToolStripMenuItem";
            this.diagramaToolStripMenuItem.Size = new System.Drawing.Size(148, 26);
            this.diagramaToolStripMenuItem.Text = "Diagrama";
            this.diagramaToolStripMenuItem.Click += new System.EventHandler(this.diagramaToolStripMenuItem_Click);
            // 
            // console
            // 
            this.console.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.console.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.console.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.console.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.console.ForeColor = System.Drawing.Color.White;
            this.console.Location = new System.Drawing.Point(11, 563);
            this.console.Margin = new System.Windows.Forms.Padding(2);
            this.console.Name = "console";
            this.console.ReadOnly = true;
            this.console.Size = new System.Drawing.Size(464, 153);
            this.console.TabIndex = 1;
            this.console.Text = "";
            // 
            // plLeft
            // 
            this.plLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.plLeft.Controls.Add(this.label3);
            this.plLeft.Controls.Add(this.txtCodif);
            this.plLeft.Controls.Add(this.console);
            this.plLeft.Controls.Add(this.label2);
            this.plLeft.Controls.Add(this.plPlayer);
            this.plLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.plLeft.Location = new System.Drawing.Point(0, 0);
            this.plLeft.Margin = new System.Windows.Forms.Padding(2);
            this.plLeft.Name = "plLeft";
            this.plLeft.Size = new System.Drawing.Size(479, 727);
            this.plLeft.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(11, 538);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Consola";
            // 
            // txtCodif
            // 
            this.txtCodif.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtCodif.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtCodif.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodif.DetectUrls = false;
            this.txtCodif.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodif.ForeColor = System.Drawing.Color.White;
            this.txtCodif.Location = new System.Drawing.Point(11, 83);
            this.txtCodif.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodif.Name = "txtCodif";
            this.txtCodif.Size = new System.Drawing.Size(464, 453);
            this.txtCodif.TabIndex = 2;
            this.txtCodif.Text = ";Code Will be here";
            this.txtCodif.TextChanged += new System.EventHandler(this.CodeChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(7, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Codificación";
            // 
            // plPlayer
            // 
            this.plPlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.plPlayer.Controls.Add(this.btnStop);
            this.plPlayer.Controls.Add(this.btnPause);
            this.plPlayer.Controls.Add(this.btnPlay);
            this.plPlayer.Dock = System.Windows.Forms.DockStyle.Top;
            this.plPlayer.Location = new System.Drawing.Point(0, 0);
            this.plPlayer.Margin = new System.Windows.Forms.Padding(2);
            this.plPlayer.Name = "plPlayer";
            this.plPlayer.Size = new System.Drawing.Size(479, 59);
            this.plPlayer.TabIndex = 0;
            // 
            // btnStop
            // 
            this.btnStop.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnStop.Location = new System.Drawing.Point(96, 0);
            this.btnStop.Margin = new System.Windows.Forms.Padding(8, 2, 2, 2);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(48, 59);
            this.btnStop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnStop.TabIndex = 2;
            this.btnStop.TabStop = false;
            // 
            // btnPause
            // 
            this.btnPause.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPause.Location = new System.Drawing.Point(48, 0);
            this.btnPause.Margin = new System.Windows.Forms.Padding(8, 2, 2, 2);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(48, 59);
            this.btnPause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnPause.TabIndex = 1;
            this.btnPause.TabStop = false;
            // 
            // btnPlay
            // 
            this.btnPlay.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPlay.Image = ((System.Drawing.Image)(resources.GetObject("btnPlay.Image")));
            this.btnPlay.Location = new System.Drawing.Point(0, 0);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(15, 2, 2, 2);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(48, 59);
            this.btnPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnPlay.TabIndex = 0;
            this.btnPlay.TabStop = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // dgVars
            // 
            this.dgVars.AllowUserToAddRows = false;
            this.dgVars.AllowUserToDeleteRows = false;
            this.dgVars.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgVars.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgVars.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.dgVars.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgVars.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgVars.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.dgVars.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgVars.DefaultCellStyle = dataGridViewCellStyle23;
            this.dgVars.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.dgVars.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgVars.Location = new System.Drawing.Point(458, 75);
            this.dgVars.Margin = new System.Windows.Forms.Padding(2);
            this.dgVars.Name = "dgVars";
            this.dgVars.ReadOnly = true;
            this.dgVars.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgVars.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.dgVars.RowHeadersWidth = 51;
            this.dgVars.RowTemplate.Height = 24;
            this.dgVars.Size = new System.Drawing.Size(312, 267);
            this.dgVars.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle22;
            this.dataGridViewTextBoxColumn1.HeaderText = "Id Reg";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Valor";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // lbPC
            // 
            this.lbPC.AutoSize = true;
            this.lbPC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.lbPC.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPC.ForeColor = System.Drawing.Color.White;
            this.lbPC.Location = new System.Drawing.Point(645, 386);
            this.lbPC.Name = "lbPC";
            this.lbPC.Size = new System.Drawing.Size(36, 17);
            this.lbPC.TabIndex = 5;
            this.lbPC.Text = "0000";
            // 
            // lbZ
            // 
            this.lbZ.AutoSize = true;
            this.lbZ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.lbZ.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbZ.ForeColor = System.Drawing.Color.White;
            this.lbZ.Location = new System.Drawing.Point(258, 386);
            this.lbZ.Name = "lbZ";
            this.lbZ.Size = new System.Drawing.Size(36, 17);
            this.lbZ.TabIndex = 6;
            this.lbZ.Text = "0000";
            // 
            // lbInst
            // 
            this.lbInst.AutoSize = true;
            this.lbInst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.lbInst.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInst.ForeColor = System.Drawing.Color.White;
            this.lbInst.Location = new System.Drawing.Point(191, 144);
            this.lbInst.Name = "lbInst";
            this.lbInst.Size = new System.Drawing.Size(55, 17);
            this.lbInst.TabIndex = 7;
            this.lbInst.Text = "Nothing";
            // 
            // lbMAR
            // 
            this.lbMAR.AutoSize = true;
            this.lbMAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.lbMAR.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMAR.ForeColor = System.Drawing.Color.White;
            this.lbMAR.Location = new System.Drawing.Point(34, 79);
            this.lbMAR.Name = "lbMAR";
            this.lbMAR.Size = new System.Drawing.Size(36, 17);
            this.lbMAR.TabIndex = 8;
            this.lbMAR.Text = "0000";
            // 
            // lbMDR
            // 
            this.lbMDR.AutoSize = true;
            this.lbMDR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.lbMDR.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMDR.ForeColor = System.Drawing.Color.White;
            this.lbMDR.Location = new System.Drawing.Point(34, 139);
            this.lbMDR.Name = "lbMDR";
            this.lbMDR.Size = new System.Drawing.Size(36, 17);
            this.lbMDR.TabIndex = 9;
            this.lbMDR.Text = "0000";
            // 
            // lbY
            // 
            this.lbY.AutoSize = true;
            this.lbY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.lbY.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbY.ForeColor = System.Drawing.Color.White;
            this.lbY.Location = new System.Drawing.Point(258, 289);
            this.lbY.Name = "lbY";
            this.lbY.Size = new System.Drawing.Size(36, 17);
            this.lbY.TabIndex = 10;
            this.lbY.Text = "0000";
            // 
            // lbX
            // 
            this.lbX.AutoSize = true;
            this.lbX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.lbX.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbX.ForeColor = System.Drawing.Color.White;
            this.lbX.Location = new System.Drawing.Point(343, 289);
            this.lbX.Name = "lbX";
            this.lbX.Size = new System.Drawing.Size(36, 17);
            this.lbX.TabIndex = 11;
            this.lbX.Text = "0000";
            // 
            // lbOperator
            // 
            this.lbOperator.AutoSize = true;
            this.lbOperator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.lbOperator.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOperator.ForeColor = System.Drawing.Color.White;
            this.lbOperator.Location = new System.Drawing.Point(300, 325);
            this.lbOperator.Name = "lbOperator";
            this.lbOperator.Size = new System.Drawing.Size(36, 17);
            this.lbOperator.TabIndex = 12;
            this.lbOperator.Text = "0000";
            // 
            // ejemplosToolStripMenuItem
            // 
            this.ejemplosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.operacionesToolStripMenuItem});
            this.ejemplosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ejemplosToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.ejemplosToolStripMenuItem.Name = "ejemplosToolStripMenuItem";
            this.ejemplosToolStripMenuItem.Size = new System.Drawing.Size(85, 55);
            this.ejemplosToolStripMenuItem.Text = "Ejemplos";
            // 
            // operacionesToolStripMenuItem
            // 
            this.operacionesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.operacionesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.operacionesToolStripMenuItem.Name = "operacionesToolStripMenuItem";
            this.operacionesToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.operacionesToolStripMenuItem.Text = "Operaciones";
            this.operacionesToolStripMenuItem.Click += new System.EventHandler(this.operacionesToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 727);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.plLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1300, 700);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.plCpu.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.plInfo.ResumeLayout(false);
            this.plInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvToken)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgVars)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel plCpu;
        private System.Windows.Forms.Panel plInfo;
        private System.Windows.Forms.RichTextBox console;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel plTopMenu;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem masToolStripMenuItem;
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Token;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lexema;
        private System.Windows.Forms.DataGridViewTextBoxColumn Linea;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columna;
        private System.Windows.Forms.DataGridViewTextBoxColumn Indice;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diagramaToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgVars;
        private System.Windows.Forms.Label lbOperator;
        private System.Windows.Forms.Label lbX;
        private System.Windows.Forms.Label lbY;
        private System.Windows.Forms.Label lbMDR;
        private System.Windows.Forms.Label lbMAR;
        private System.Windows.Forms.Label lbInst;
        private System.Windows.Forms.Label lbZ;
        private System.Windows.Forms.Label lbPC;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.ToolStripMenuItem ejemplosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operacionesToolStripMenuItem;
    }
}

