namespace UcakSavarOyunu.Desktop
{
    partial class AnaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaForm));
            this.panelYonerge = new System.Windows.Forms.Panel();
            this.labelSure = new System.Windows.Forms.Label();
            this.labelBilgi = new System.Windows.Forms.Label();
            this.panelBitis = new System.Windows.Forms.Panel();
            this.panelUcakSavar = new System.Windows.Forms.Panel();
            this.panelSavasAlani = new System.Windows.Forms.Panel();
            this.panelYonerge.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelYonerge
            // 
            this.panelYonerge.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panelYonerge.Controls.Add(this.labelSure);
            this.panelYonerge.Controls.Add(this.labelBilgi);
            this.panelYonerge.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelYonerge.Location = new System.Drawing.Point(0, 0);
            this.panelYonerge.Name = "panelYonerge";
            this.panelYonerge.Size = new System.Drawing.Size(799, 77);
            this.panelYonerge.TabIndex = 0;
            // 
            // labelSure
            // 
            this.labelSure.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSure.Font = new System.Drawing.Font("Century", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSure.Location = new System.Drawing.Point(620, 9);
            this.labelSure.Name = "labelSure";
            this.labelSure.Size = new System.Drawing.Size(167, 54);
            this.labelSure.TabIndex = 1;
            this.labelSure.Text = "0:00";
            this.labelSure.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelBilgi
            // 
            this.labelBilgi.AutoSize = true;
            this.labelBilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelBilgi.ForeColor = System.Drawing.Color.Black;
            this.labelBilgi.Location = new System.Drawing.Point(21, 9);
            this.labelBilgi.Name = "labelBilgi";
            this.labelBilgi.Size = new System.Drawing.Size(424, 54);
            this.labelBilgi.TabIndex = 0;
            this.labelBilgi.Text = "Oyunu Başlatmak İçin Enter Tuşuna Basınız.\r\nUçak Savarı Hareket Ettirmek İçin Sağ" +
    "/Sol Yön Tuşlarına Basın.\r\nAteş Etmek İçin Space(Boşluk) Tuşuna Basın.";
            // 
            // panelBitis
            // 
            this.panelBitis.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelBitis.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelBitis.Location = new System.Drawing.Point(794, 77);
            this.panelBitis.Name = "panelBitis";
            this.panelBitis.Size = new System.Drawing.Size(5, 457);
            this.panelBitis.TabIndex = 1;
            // 
            // panelUcakSavar
            // 
            this.panelUcakSavar.BackColor = System.Drawing.Color.Orange;
            this.panelUcakSavar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelUcakSavar.Location = new System.Drawing.Point(0, 434);
            this.panelUcakSavar.Name = "panelUcakSavar";
            this.panelUcakSavar.Size = new System.Drawing.Size(794, 100);
            this.panelUcakSavar.TabIndex = 2;
            // 
            // panelSavasAlani
            // 
            this.panelSavasAlani.BackColor = System.Drawing.Color.Orange;
            this.panelSavasAlani.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSavasAlani.Location = new System.Drawing.Point(0, 77);
            this.panelSavasAlani.Name = "panelSavasAlani";
            this.panelSavasAlani.Size = new System.Drawing.Size(794, 357);
            this.panelSavasAlani.TabIndex = 3;
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 534);
            this.Controls.Add(this.panelSavasAlani);
            this.Controls.Add(this.panelUcakSavar);
            this.Controls.Add(this.panelBitis);
            this.Controls.Add(this.panelYonerge);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AnaForm";
            this.Text = "Uçak Savar Oyunu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AnaForm_KeyDown);
            this.panelYonerge.ResumeLayout(false);
            this.panelYonerge.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelYonerge;
        private System.Windows.Forms.Label labelSure;
        private System.Windows.Forms.Label labelBilgi;
        private System.Windows.Forms.Panel panelBitis;
        private System.Windows.Forms.Panel panelUcakSavar;
        private System.Windows.Forms.Panel panelSavasAlani;
    }
}

