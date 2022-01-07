
namespace _948948849
{
    partial class Giris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giris));
            this.btnutelikislem = new System.Windows.Forms.Button();
            this.btnsiparisislem = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.MaaliGiris = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnutelikislem
            // 
            this.btnutelikislem.Location = new System.Drawing.Point(38, 236);
            this.btnutelikislem.Name = "btnutelikislem";
            this.btnutelikislem.Size = new System.Drawing.Size(175, 133);
            this.btnutelikislem.TabIndex = 0;
            this.btnutelikislem.Text = "Üyelik İşlemleri";
            this.btnutelikislem.UseVisualStyleBackColor = true;
            this.btnutelikislem.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnsiparisislem
            // 
            this.btnsiparisislem.Location = new System.Drawing.Point(263, 236);
            this.btnsiparisislem.Name = "btnsiparisislem";
            this.btnsiparisislem.Size = new System.Drawing.Size(175, 133);
            this.btnsiparisislem.TabIndex = 1;
            this.btnsiparisislem.Text = "Sipariş İşlemleri";
            this.btnsiparisislem.UseVisualStyleBackColor = true;
            this.btnsiparisislem.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(282, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(402, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(717, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 133);
            this.button1.TabIndex = 2;
            this.button1.Text = "Çıkış";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btncıkıs_Click);
            // 
            // MaaliGiris
            // 
            this.MaaliGiris.Location = new System.Drawing.Point(489, 236);
            this.MaaliGiris.Name = "MaaliGiris";
            this.MaaliGiris.Size = new System.Drawing.Size(175, 133);
            this.MaaliGiris.TabIndex = 4;
            this.MaaliGiris.Text = "Mali İşlemler";
            this.MaaliGiris.UseVisualStyleBackColor = true;
            this.MaaliGiris.Click += new System.EventHandler(this.MaaliGiris_Click);
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(945, 444);
            this.Controls.Add(this.MaaliGiris);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnsiparisislem);
            this.Controls.Add(this.btnutelikislem);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giris";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnutelikislem;
        private System.Windows.Forms.Button btnsiparisislem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button MaaliGiris;
    }
}