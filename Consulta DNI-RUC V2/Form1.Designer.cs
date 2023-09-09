namespace Consulta_DNI_RUC_V2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            comboBox1 = new ComboBox();
            lbl_numdoc = new Label();
            lbl_nameap = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            txb_ruc = new TextBox();
            txb_rdnirz = new TextBox();
            txb_nroruc = new TextBox();
            txb_estado = new TextBox();
            txb_condicion = new TextBox();
            txb_direccion = new TextBox();
            txb_distrito = new TextBox();
            txb_provincia = new TextBox();
            txb_departamento = new TextBox();
            txb_ubigeo = new TextBox();
            menuStrip1 = new MenuStrip();
            helpToolStripMenuItem = new ToolStripMenuItem();
            tokenToolStripMenuItem = new ToolStripMenuItem();
            txb_dni = new TextBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.ScrollBar;
            comboBox1.DisplayMember = "DNI";
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.DropDownWidth = 122;
            comboBox1.FlatStyle = FlatStyle.Popup;
            comboBox1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "DNI", "RUC" });
            comboBox1.Location = new Point(236, 12);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(122, 21);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // lbl_numdoc
            // 
            lbl_numdoc.AutoSize = true;
            lbl_numdoc.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_numdoc.ForeColor = Color.SlateGray;
            lbl_numdoc.Location = new Point(89, 72);
            lbl_numdoc.Name = "lbl_numdoc";
            lbl_numdoc.Size = new Size(29, 13);
            lbl_numdoc.TabIndex = 1;
            lbl_numdoc.Text = "DNI";
            // 
            // lbl_nameap
            // 
            lbl_nameap.AutoSize = true;
            lbl_nameap.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_nameap.ForeColor = Color.SlateGray;
            lbl_nameap.Location = new Point(12, 98);
            lbl_nameap.Name = "lbl_nameap";
            lbl_nameap.Size = new Size(106, 13);
            lbl_nameap.TabIndex = 2;
            lbl_nameap.Text = "NOMBRES O RZ.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.SlateGray;
            label2.Location = new Point(6, 124);
            label2.Name = "label2";
            label2.Size = new Size(112, 13);
            label2.TabIndex = 3;
            label2.Text = "NUMERO DE DOC";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.SlateGray;
            label3.Location = new Point(61, 150);
            label3.Name = "label3";
            label3.Size = new Size(57, 13);
            label3.TabIndex = 4;
            label3.Text = "ESTADO";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.SlateGray;
            label4.Location = new Point(42, 176);
            label4.Name = "label4";
            label4.Size = new Size(76, 13);
            label4.TabIndex = 5;
            label4.Text = "CONDICION";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.SlateGray;
            label5.Location = new Point(43, 202);
            label5.Name = "label5";
            label5.Size = new Size(75, 13);
            label5.TabIndex = 6;
            label5.Text = "DIRECCION";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.SlateGray;
            label6.Location = new Point(64, 228);
            label6.Name = "label6";
            label6.Size = new Size(54, 13);
            label6.TabIndex = 7;
            label6.Text = "UBIGEO";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.SlateGray;
            label7.Location = new Point(52, 254);
            label7.Name = "label7";
            label7.Size = new Size(66, 13);
            label7.TabIndex = 8;
            label7.Text = "DISTRITO";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.SlateGray;
            label8.Location = new Point(44, 280);
            label8.Name = "label8";
            label8.Size = new Size(74, 13);
            label8.TabIndex = 9;
            label8.Text = "PROVINCIA";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.SlateGray;
            label9.Location = new Point(9, 306);
            label9.Name = "label9";
            label9.Size = new Size(109, 13);
            label9.TabIndex = 10;
            label9.Text = "DEPARTAMENTO";
            // 
            // txb_ruc
            // 
            txb_ruc.Cursor = Cursors.IBeam;
            txb_ruc.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txb_ruc.Location = new Point(128, 65);
            txb_ruc.MaxLength = 11;
            txb_ruc.Name = "txb_ruc";
            txb_ruc.Size = new Size(153, 20);
            txb_ruc.TabIndex = 11;
            txb_ruc.TextChanged += txb_ruc_TextChanged;
            // 
            // txb_rdnirz
            // 
            txb_rdnirz.BackColor = SystemColors.Control;
            txb_rdnirz.Cursor = Cursors.IBeam;
            txb_rdnirz.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txb_rdnirz.Location = new Point(128, 91);
            txb_rdnirz.MaxLength = 11;
            txb_rdnirz.Name = "txb_rdnirz";
            txb_rdnirz.ReadOnly = true;
            txb_rdnirz.Size = new Size(462, 20);
            txb_rdnirz.TabIndex = 13;
            // 
            // txb_nroruc
            // 
            txb_nroruc.BackColor = SystemColors.Control;
            txb_nroruc.Cursor = Cursors.IBeam;
            txb_nroruc.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txb_nroruc.Location = new Point(128, 117);
            txb_nroruc.MaxLength = 11;
            txb_nroruc.Name = "txb_nroruc";
            txb_nroruc.ReadOnly = true;
            txb_nroruc.Size = new Size(134, 20);
            txb_nroruc.TabIndex = 14;
            // 
            // txb_estado
            // 
            txb_estado.BackColor = SystemColors.Control;
            txb_estado.Cursor = Cursors.IBeam;
            txb_estado.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txb_estado.Location = new Point(128, 143);
            txb_estado.MaxLength = 11;
            txb_estado.Name = "txb_estado";
            txb_estado.ReadOnly = true;
            txb_estado.Size = new Size(100, 20);
            txb_estado.TabIndex = 15;
            // 
            // txb_condicion
            // 
            txb_condicion.BackColor = SystemColors.Control;
            txb_condicion.Cursor = Cursors.IBeam;
            txb_condicion.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txb_condicion.Location = new Point(128, 169);
            txb_condicion.MaxLength = 11;
            txb_condicion.Name = "txb_condicion";
            txb_condicion.ReadOnly = true;
            txb_condicion.Size = new Size(100, 20);
            txb_condicion.TabIndex = 16;
            // 
            // txb_direccion
            // 
            txb_direccion.BackColor = SystemColors.Control;
            txb_direccion.Cursor = Cursors.IBeam;
            txb_direccion.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txb_direccion.Location = new Point(128, 195);
            txb_direccion.MaxLength = 11;
            txb_direccion.Name = "txb_direccion";
            txb_direccion.ReadOnly = true;
            txb_direccion.Size = new Size(462, 20);
            txb_direccion.TabIndex = 17;
            // 
            // txb_distrito
            // 
            txb_distrito.BackColor = SystemColors.Control;
            txb_distrito.Cursor = Cursors.IBeam;
            txb_distrito.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txb_distrito.Location = new Point(128, 247);
            txb_distrito.MaxLength = 11;
            txb_distrito.Name = "txb_distrito";
            txb_distrito.ReadOnly = true;
            txb_distrito.Size = new Size(206, 20);
            txb_distrito.TabIndex = 19;
            // 
            // txb_provincia
            // 
            txb_provincia.BackColor = SystemColors.Control;
            txb_provincia.Cursor = Cursors.IBeam;
            txb_provincia.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txb_provincia.Location = new Point(128, 273);
            txb_provincia.MaxLength = 11;
            txb_provincia.Name = "txb_provincia";
            txb_provincia.ReadOnly = true;
            txb_provincia.Size = new Size(206, 20);
            txb_provincia.TabIndex = 20;
            // 
            // txb_departamento
            // 
            txb_departamento.BackColor = SystemColors.Control;
            txb_departamento.Cursor = Cursors.IBeam;
            txb_departamento.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txb_departamento.Location = new Point(128, 299);
            txb_departamento.MaxLength = 11;
            txb_departamento.Name = "txb_departamento";
            txb_departamento.ReadOnly = true;
            txb_departamento.Size = new Size(206, 20);
            txb_departamento.TabIndex = 21;
            // 
            // txb_ubigeo
            // 
            txb_ubigeo.BackColor = SystemColors.Control;
            txb_ubigeo.Cursor = Cursors.IBeam;
            txb_ubigeo.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txb_ubigeo.Location = new Point(128, 221);
            txb_ubigeo.MaxLength = 11;
            txb_ubigeo.Name = "txb_ubigeo";
            txb_ubigeo.ReadOnly = true;
            txb_ubigeo.Size = new Size(100, 20);
            txb_ubigeo.TabIndex = 18;
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.Items.AddRange(new ToolStripItem[] { helpToolStripMenuItem });
            menuStrip1.Location = new Point(548, 9);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(52, 24);
            menuStrip1.TabIndex = 21;
            menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tokenToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // tokenToolStripMenuItem
            // 
            tokenToolStripMenuItem.Name = "tokenToolStripMenuItem";
            tokenToolStripMenuItem.Size = new Size(105, 22);
            tokenToolStripMenuItem.Text = "Token";
            tokenToolStripMenuItem.Click += tokenToolStripMenuItem_Click;
            // 
            // txb_dni
            // 
            txb_dni.Cursor = Cursors.IBeam;
            txb_dni.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txb_dni.Location = new Point(128, 65);
            txb_dni.MaxLength = 11;
            txb_dni.Name = "txb_dni";
            txb_dni.Size = new Size(100, 20);
            txb_dni.TabIndex = 1;
            txb_dni.TextChanged += txb_dni_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(610, 378);
            Controls.Add(txb_ruc);
            Controls.Add(txb_dni);
            Controls.Add(txb_ubigeo);
            Controls.Add(txb_departamento);
            Controls.Add(txb_provincia);
            Controls.Add(txb_distrito);
            Controls.Add(txb_direccion);
            Controls.Add(txb_condicion);
            Controls.Add(txb_estado);
            Controls.Add(txb_nroruc);
            Controls.Add(txb_rdnirz);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lbl_nameap);
            Controls.Add(lbl_numdoc);
            Controls.Add(comboBox1);
            Controls.Add(menuStrip1);
            ForeColor = SystemColors.ActiveCaption;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Consulta DNI-RUC V2 - ERWIN NAHUE";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label lbl_numdoc;
        private Label lbl_nameap;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox txb_ruc;
        private TextBox txb_rdnirz;
        private TextBox txb_nroruc;
        private TextBox txb_estado;
        private TextBox txb_condicion;
        private TextBox txb_direccion;
        private TextBox txb_distrito;
        private TextBox txb_provincia;
        private TextBox txb_departamento;
        private TextBox txb_ubigeo;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem tokenToolStripMenuItem;
        private TextBox txb_dni;
    }
}