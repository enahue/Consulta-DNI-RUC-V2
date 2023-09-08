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
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(610, 378);
            Controls.Add(comboBox1);
            ForeColor = SystemColors.ActiveCaption;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Consulta DNI-RUC V2 - ERWIN NAHUE";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBox1;
    }
}