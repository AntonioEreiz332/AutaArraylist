namespace Automobili
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
            this.btnNovi = new System.Windows.Forms.Button();
            this.txtboxNovi = new System.Windows.Forms.TextBox();
            this.btnUnesi = new System.Windows.Forms.Button();
            this.rtxtboxAuta = new System.Windows.Forms.RichTextBox();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNovi
            // 
            this.btnNovi.Location = new System.Drawing.Point(13, 13);
            this.btnNovi.Name = "btnNovi";
            this.btnNovi.Size = new System.Drawing.Size(125, 23);
            this.btnNovi.TabIndex = 0;
            this.btnNovi.Text = "Novi automobil";
            this.btnNovi.UseVisualStyleBackColor = true;
            this.btnNovi.Click += new System.EventHandler(this.btnNovi_Click);
            // 
            // txtboxNovi
            // 
            this.txtboxNovi.Location = new System.Drawing.Point(13, 58);
            this.txtboxNovi.Name = "txtboxNovi";
            this.txtboxNovi.Size = new System.Drawing.Size(143, 20);
            this.txtboxNovi.TabIndex = 1;
            this.txtboxNovi.TextChanged += new System.EventHandler(this.txtboxNovi_TextChanged);
            // 
            // btnUnesi
            // 
            this.btnUnesi.Location = new System.Drawing.Point(186, 58);
            this.btnUnesi.Name = "btnUnesi";
            this.btnUnesi.Size = new System.Drawing.Size(79, 20);
            this.btnUnesi.TabIndex = 2;
            this.btnUnesi.Text = "Unesi";
            this.btnUnesi.UseVisualStyleBackColor = true;
            this.btnUnesi.Click += new System.EventHandler(this.btnUnesi_Click);
            // 
            // rtxtboxAuta
            // 
            this.rtxtboxAuta.Location = new System.Drawing.Point(12, 110);
            this.rtxtboxAuta.Name = "rtxtboxAuta";
            this.rtxtboxAuta.Size = new System.Drawing.Size(253, 216);
            this.rtxtboxAuta.TabIndex = 3;
            this.rtxtboxAuta.Text = "";
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(12, 346);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(101, 23);
            this.btnObrisi.TabIndex = 4;
            this.btnObrisi.Text = "Obrisi listu";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 381);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.rtxtboxAuta);
            this.Controls.Add(this.btnUnesi);
            this.Controls.Add(this.txtboxNovi);
            this.Controls.Add(this.btnNovi);
            this.Name = "Form1";
            this.Text = "Automobili";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNovi;
        private System.Windows.Forms.TextBox txtboxNovi;
        private System.Windows.Forms.Button btnUnesi;
        private System.Windows.Forms.RichTextBox rtxtboxAuta;
        private System.Windows.Forms.Button btnObrisi;
    }
}

