namespace WorldTimeBuddy_WinformsEdition
{
    partial class mainform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainform));
            this.BackgroundPanel = new System.Windows.Forms.Panel();
            this.CountrySelector = new System.Windows.Forms.ComboBox();
            this.Header = new System.Windows.Forms.Label();
            this.LabelToReveal = new System.Windows.Forms.Label();
            this.BackgroundPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BackgroundPanel
            // 
            this.BackgroundPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BackgroundPanel.BackgroundImage")));
            this.BackgroundPanel.Controls.Add(this.LabelToReveal);
            this.BackgroundPanel.Controls.Add(this.CountrySelector);
            this.BackgroundPanel.Controls.Add(this.Header);
            this.BackgroundPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackgroundPanel.Location = new System.Drawing.Point(0, 0);
            this.BackgroundPanel.Name = "BackgroundPanel";
            this.BackgroundPanel.Size = new System.Drawing.Size(1040, 622);
            this.BackgroundPanel.TabIndex = 0;
            this.BackgroundPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.BackgroundPanel_Paint);
            this.BackgroundPanel.Resize += new System.EventHandler(this.BackgroundPanel_Resize);
            // 
            // CountrySelector
            // 
            this.CountrySelector.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountrySelector.FormattingEnabled = true;
            this.CountrySelector.Location = new System.Drawing.Point(342, 306);
            this.CountrySelector.Name = "CountrySelector";
            this.CountrySelector.Size = new System.Drawing.Size(285, 41);
            this.CountrySelector.TabIndex = 1;
            this.CountrySelector.SelectedIndexChanged += new System.EventHandler(this.CountrySelector_SelectedIndexChanged);
            // 
            // Header
            // 
            this.Header.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Header.AutoSize = true;
            this.Header.BackColor = System.Drawing.Color.Transparent;
            this.Header.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Header.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Header.ForeColor = System.Drawing.Color.Chocolate;
            this.Header.Location = new System.Drawing.Point(320, 223);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(351, 44);
            this.Header.TabIndex = 0;
            this.Header.Text = "Select Your Country";
            // 
            // LabelToReveal
            // 
            this.LabelToReveal.AutoSize = true;
            this.LabelToReveal.BackColor = System.Drawing.Color.Transparent;
            this.LabelToReveal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LabelToReveal.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelToReveal.ForeColor = System.Drawing.Color.Snow;
            this.LabelToReveal.Location = new System.Drawing.Point(367, 431);
            this.LabelToReveal.Name = "LabelToReveal";
            this.LabelToReveal.Size = new System.Drawing.Size(245, 44);
            this.LabelToReveal.TabIndex = 3;
            this.LabelToReveal.Text = "Wait And See";
            // 
            // mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 622);
            this.Controls.Add(this.BackgroundPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainform";
            this.Text = "World Time Buddy";
            this.Load += new System.EventHandler(this.mainform_Load);
            this.BackgroundPanel.ResumeLayout(false);
            this.BackgroundPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BackgroundPanel;
        private System.Windows.Forms.Label Header;
        private System.Windows.Forms.ComboBox CountrySelector;
        private System.Windows.Forms.Label LabelToReveal;
    }
}

