namespace InterfaceExamenProJuni
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
            txtDBww = new TextBox();
            btnLogin = new Button();
            label1 = new Label();
            lstLocaties = new ListBox();
            label2 = new Label();
            lblLocatieDetails = new Label();
            label3 = new Label();
            lstDieren = new ListBox();
            lblDier = new Label();
            cboLocaties = new ComboBox();
            btnVerplaats = new Button();
            lblVerplaats = new Label();
            SuspendLayout();
            // 
            // txtDBww
            // 
            txtDBww.Location = new Point(119, 23);
            txtDBww.Name = "txtDBww";
            txtDBww.PasswordChar = '*';
            txtDBww.Size = new Size(100, 23);
            txtDBww.TabIndex = 0;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(16, 55);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(203, 23);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "login";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 26);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 2;
            label1.Text = "DB wachtwoord: ";
            // 
            // lstLocaties
            // 
            lstLocaties.FormattingEnabled = true;
            lstLocaties.ItemHeight = 15;
            lstLocaties.Location = new Point(16, 141);
            lstLocaties.Name = "lstLocaties";
            lstLocaties.Size = new Size(154, 229);
            lstLocaties.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 111);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 4;
            label2.Text = "Locaties";
            // 
            // lblLocatieDetails
            // 
            lblLocatieDetails.AutoSize = true;
            lblLocatieDetails.Location = new Point(16, 394);
            lblLocatieDetails.Name = "lblLocatieDetails";
            lblLocatieDetails.Size = new Size(0, 15);
            lblLocatieDetails.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(271, 111);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 7;
            label3.Text = "Dieren";
            // 
            // lstDieren
            // 
            lstDieren.FormattingEnabled = true;
            lstDieren.ItemHeight = 15;
            lstDieren.Location = new Point(271, 141);
            lstDieren.Name = "lstDieren";
            lstDieren.Size = new Size(154, 229);
            lstDieren.TabIndex = 6;
            // 
            // lblDier
            // 
            lblDier.Location = new Point(271, 394);
            lblDier.Name = "lblDier";
            lblDier.Size = new Size(433, 223);
            lblDier.TabIndex = 8;
            // 
            // cboLocaties
            // 
            cboLocaties.FormattingEnabled = true;
            cboLocaties.Location = new Point(494, 165);
            cboLocaties.Name = "cboLocaties";
            cboLocaties.Size = new Size(121, 23);
            cboLocaties.TabIndex = 9;
            // 
            // btnVerplaats
            // 
            btnVerplaats.Location = new Point(494, 194);
            btnVerplaats.Name = "btnVerplaats";
            btnVerplaats.Size = new Size(121, 23);
            btnVerplaats.TabIndex = 10;
            btnVerplaats.Text = "verplaats";
            btnVerplaats.UseVisualStyleBackColor = true;
            // 
            // lblVerplaats
            // 
            lblVerplaats.AutoSize = true;
            lblVerplaats.Location = new Point(494, 141);
            lblVerplaats.Name = "lblVerplaats";
            lblVerplaats.Size = new Size(86, 15);
            lblVerplaats.TabIndex = 11;
            lblVerplaats.Text = "Verplaats naar: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 636);
            Controls.Add(lblVerplaats);
            Controls.Add(btnVerplaats);
            Controls.Add(cboLocaties);
            Controls.Add(lblDier);
            Controls.Add(label3);
            Controls.Add(lstDieren);
            Controls.Add(lblLocatieDetails);
            Controls.Add(label2);
            Controls.Add(lstLocaties);
            Controls.Add(label1);
            Controls.Add(btnLogin);
            Controls.Add(txtDBww);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDBww;
        private Button btnLogin;
        private Label label1;
        private ListBox lstLocaties;
        private Label label2;
        private Label lblLocatieDetails;
        private Label label3;
        private ListBox lstDieren;
        private Label lblDier;
        private ComboBox cboLocaties;
        private Button btnVerplaats;
        private Label lblVerplaats;
    }
}