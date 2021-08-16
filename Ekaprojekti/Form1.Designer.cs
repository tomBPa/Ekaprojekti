namespace Ekaprojekti
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
            this.EtunimiLB = new System.Windows.Forms.Label();
            this.MuutaBT = new System.Windows.Forms.Button();
            this.PeruutaBT = new System.Windows.Forms.Button();
            this.TekstiTB = new System.Windows.Forms.TextBox();
            this.ViestiLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EtunimiLB
            // 
            this.EtunimiLB.AutoSize = true;
            this.EtunimiLB.Location = new System.Drawing.Point(229, 128);
            this.EtunimiLB.Name = "EtunimiLB";
            this.EtunimiLB.Size = new System.Drawing.Size(183, 29);
            this.EtunimiLB.TabIndex = 0;
            this.EtunimiLB.Text = "Anna etunimesi:";
            // 
            // MuutaBT
            // 
            this.MuutaBT.BackColor = System.Drawing.Color.LawnGreen;
            this.MuutaBT.Location = new System.Drawing.Point(418, 169);
            this.MuutaBT.Name = "MuutaBT";
            this.MuutaBT.Size = new System.Drawing.Size(167, 56);
            this.MuutaBT.TabIndex = 1;
            this.MuutaBT.Text = "Muuta teksti";
            this.MuutaBT.UseVisualStyleBackColor = false;
            this.MuutaBT.Click += new System.EventHandler(this.MuutaBT_Click);
            // 
            // PeruutaBT
            // 
            this.PeruutaBT.BackColor = System.Drawing.Color.Red;
            this.PeruutaBT.ForeColor = System.Drawing.Color.White;
            this.PeruutaBT.Location = new System.Drawing.Point(645, 169);
            this.PeruutaBT.Name = "PeruutaBT";
            this.PeruutaBT.Size = new System.Drawing.Size(155, 56);
            this.PeruutaBT.TabIndex = 2;
            this.PeruutaBT.Text = "Peruuta";
            this.PeruutaBT.UseVisualStyleBackColor = false;
            this.PeruutaBT.Click += new System.EventHandler(this.PeruutaBT_Click);
            // 
            // TekstiTB
            // 
            this.TekstiTB.Location = new System.Drawing.Point(418, 128);
            this.TekstiTB.Name = "TekstiTB";
            this.TekstiTB.Size = new System.Drawing.Size(382, 35);
            this.TekstiTB.TabIndex = 3;
            // 
            // ViestiLB
            // 
            this.ViestiLB.AutoSize = true;
            this.ViestiLB.Location = new System.Drawing.Point(229, 388);
            this.ViestiLB.Name = "ViestiLB";
            this.ViestiLB.Size = new System.Drawing.Size(72, 29);
            this.ViestiLB.TabIndex = 4;
            this.ViestiLB.Text = "Viesti";
            this.ViestiLB.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 765);
            this.Controls.Add(this.ViestiLB);
            this.Controls.Add(this.TekstiTB);
            this.Controls.Add(this.PeruutaBT);
            this.Controls.Add(this.MuutaBT);
            this.Controls.Add(this.EtunimiLB);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EtunimiLB;
        private System.Windows.Forms.Button MuutaBT;
        private System.Windows.Forms.Button PeruutaBT;
        private System.Windows.Forms.TextBox TekstiTB;
        private System.Windows.Forms.Label ViestiLB;
    }
}

