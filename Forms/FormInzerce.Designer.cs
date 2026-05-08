namespace BCSH1_SemestralniPrace_Suttner.Forms
{
    partial class FormInzerce
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInzerce));
            panelTop = new Panel();
            btnZpet = new Button();
            btnVyhledat = new Button();
            cmbZnacka = new ComboBox();
            txtNazev = new TextBox();
            flpObsah = new FlowLayoutPanel();
            panelTop.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.WhiteSmoke;
            panelTop.Controls.Add(btnZpet);
            panelTop.Controls.Add(btnVyhledat);
            panelTop.Controls.Add(cmbZnacka);
            panelTop.Controls.Add(txtNazev);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(728, 50);
            panelTop.TabIndex = 5;
            // 
            // btnZpet
            // 
            btnZpet.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnZpet.DialogResult = DialogResult.Cancel;
            btnZpet.Image = (Image)resources.GetObject("btnZpet.Image");
            btnZpet.Location = new Point(672, 3);
            btnZpet.Name = "btnZpet";
            btnZpet.Size = new Size(53, 44);
            btnZpet.TabIndex = 5;
            btnZpet.UseVisualStyleBackColor = true;
            btnZpet.Click += btnZpet_Click;
            // 
            // btnVyhledat
            // 
            btnVyhledat.Font = new Font("Segoe UI Semilight", 10F, FontStyle.Regular, GraphicsUnit.Point, 238);
            btnVyhledat.Location = new Point(440, 8);
            btnVyhledat.Name = "btnVyhledat";
            btnVyhledat.Size = new Size(112, 36);
            btnVyhledat.TabIndex = 4;
            btnVyhledat.Text = "Vyhledat";
            btnVyhledat.UseVisualStyleBackColor = true;
            btnVyhledat.Click += btnVyhledat_Click;
            // 
            // cmbZnacka
            // 
            cmbZnacka.Font = new Font("Segoe UI Semilight", 10F, FontStyle.Regular, GraphicsUnit.Point, 238);
            cmbZnacka.FormattingEnabled = true;
            cmbZnacka.Location = new Point(3, 8);
            cmbZnacka.Name = "cmbZnacka";
            cmbZnacka.Size = new Size(182, 36);
            cmbZnacka.TabIndex = 3;
            cmbZnacka.Text = "Značka";
            // 
            // txtNazev
            // 
            txtNazev.BackColor = Color.White;
            txtNazev.Font = new Font("Segoe UI Semilight", 10F, FontStyle.Regular, GraphicsUnit.Point, 238);
            txtNazev.Location = new Point(191, 10);
            txtNazev.Name = "txtNazev";
            txtNazev.Size = new Size(243, 34);
            txtNazev.TabIndex = 2;
            txtNazev.Text = "Vyhledávání Název";
            // 
            // flpObsah
            // 
            flpObsah.AutoScroll = true;
            flpObsah.BackColor = Color.DarkGray;
            flpObsah.Dock = DockStyle.Fill;
            flpObsah.Location = new Point(0, 50);
            flpObsah.Name = "flpObsah";
            flpObsah.Size = new Size(728, 394);
            flpObsah.TabIndex = 6;
            // 
            // FormInzerce
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(728, 444);
            Controls.Add(flpObsah);
            Controls.Add(panelTop);
            Name = "FormInzerce";
            Text = "FormInzerce";
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private Button btnVyhledat;
        private ComboBox cmbZnacka;
        private TextBox txtNazev;
        private FlowLayoutPanel flpObsah;
        private Button btnZpet;
    }
}