namespace HastaTakipSistemi
{
    partial class frmKayit
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtkuladi = new System.Windows.Forms.Label();
            this.kuladi = new System.Windows.Forms.TextBox();
            this.sifree = new System.Windows.Forms.Label();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnKayit = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.txtsifre, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.sifree, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.kuladi, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtkuladi, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txtkuladi
            // 
            this.txtkuladi.AutoSize = true;
            this.txtkuladi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtkuladi.Location = new System.Drawing.Point(3, 0);
            this.txtkuladi.Name = "txtkuladi";
            this.txtkuladi.Size = new System.Drawing.Size(394, 50);
            this.txtkuladi.TabIndex = 3;
            this.txtkuladi.Text = "Kullanıcı Adı:";
            this.txtkuladi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kuladi
            // 
            this.kuladi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kuladi.Location = new System.Drawing.Point(403, 3);
            this.kuladi.Multiline = true;
            this.kuladi.Name = "kuladi";
            this.kuladi.Size = new System.Drawing.Size(394, 44);
            this.kuladi.TabIndex = 4;
            this.kuladi.TextChanged += new System.EventHandler(this.kuladi_TextChanged);
            // 
            // sifree
            // 
            this.sifree.AutoSize = true;
            this.sifree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sifree.Location = new System.Drawing.Point(3, 50);
            this.sifree.Name = "sifree";
            this.sifree.Size = new System.Drawing.Size(394, 50);
            this.sifree.TabIndex = 5;
            this.sifree.Text = "Şifre:";
            this.sifree.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtsifre
            // 
            this.txtsifre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtsifre.Location = new System.Drawing.Point(403, 53);
            this.txtsifre.Multiline = true;
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Size = new System.Drawing.Size(394, 44);
            this.txtsifre.TabIndex = 6;
            this.txtsifre.UseSystemPasswordChar = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnKayit, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 100);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(800, 350);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // btnKayit
            // 
            this.btnKayit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnKayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKayit.Location = new System.Drawing.Point(3, 3);
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.Size = new System.Drawing.Size(794, 344);
            this.btnKayit.TabIndex = 4;
            this.btnKayit.Text = "KAYIT OL";
            this.btnKayit.UseVisualStyleBackColor = true;
            this.btnKayit.Click += new System.EventHandler(this.btnKayit_Click);
            // 
            // frmKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmKayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hasta Takip Sistemi-Kayıt Ol";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label txtkuladi;
        private System.Windows.Forms.TextBox kuladi;
        private System.Windows.Forms.Label sifree;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnKayit;
    }
}