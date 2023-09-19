namespace Consulta_DNI_RUC_V2
{
    partial class TokenControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TokenControl));
            txb_newtoken = new TextBox();
            label1 = new Label();
            label2 = new Label();
            linkLabel1 = new LinkLabel();
            txb_token = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // txb_newtoken
            // 
            txb_newtoken.Location = new Point(63, 99);
            txb_newtoken.Name = "txb_newtoken";
            txb_newtoken.Size = new Size(287, 23);
            txb_newtoken.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(114, 18);
            label1.Name = "label1";
            label1.Size = new Size(110, 15);
            label1.TabIndex = 2;
            label1.Text = "Genera un token en";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 40);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 3;
            label2.Text = "Token";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(219, 18);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(64, 15);
            linkLabel1.TabIndex = 4;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "apis.net.pe";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // txb_token
            // 
            txb_token.BackColor = SystemColors.Control;
            txb_token.Cursor = Cursors.IBeam;
            txb_token.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txb_token.Location = new Point(102, 38);
            txb_token.MaxLength = 11;
            txb_token.Name = "txb_token";
            txb_token.PasswordChar = '+';
            txb_token.ReadOnly = true;
            txb_token.Size = new Size(248, 20);
            txb_token.TabIndex = 14;
            // 
            // button1
            // 
            button1.Location = new Point(159, 125);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 15;
            button1.Text = "Actualizar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // TokenControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(410, 242);
            Controls.Add(button1);
            Controls.Add(txb_token);
            Controls.Add(linkLabel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txb_newtoken);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TokenControl";
            Text = "Configure Token";
            Load += TokenControl_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txb_newtoken;
        private Label label1;
        private Label label2;
        private LinkLabel linkLabel1;
        private TextBox txb_token;
        private Button button1;
    }
}