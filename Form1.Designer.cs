namespace Hesap_Makinesi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtsonuc = new System.Windows.Forms.TextBox();
            this.btnce = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btncikart = new System.Windows.Forms.Button();
            this.btntopla = new System.Windows.Forms.Button();
            this.btncarp = new System.Windows.Forms.Button();
            this.btnbol = new System.Windows.Forms.Button();
            this.btnsonuc = new System.Windows.Forms.Button();
            this.btnmod = new System.Windows.Forms.Button();
            this.btnkarekok = new System.Windows.Forms.Button();
            this.btnus = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnyuzde = new System.Windows.Forms.Button();
            this.lblsonuc = new System.Windows.Forms.Label();
            this.btnc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtsonuc
            // 
            this.txtsonuc.BackColor = System.Drawing.Color.Silver;
            this.txtsonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsonuc.Location = new System.Drawing.Point(12, 61);
            this.txtsonuc.Multiline = true;
            this.txtsonuc.Name = "txtsonuc";
            this.txtsonuc.Size = new System.Drawing.Size(321, 33);
            this.txtsonuc.TabIndex = 0;
            this.txtsonuc.Text = "0";
            // 
            // btnce
            // 
            this.btnce.BackColor = System.Drawing.Color.Silver;
            this.btnce.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnce.Location = new System.Drawing.Point(12, 103);
            this.btnce.Name = "btnce";
            this.btnce.Size = new System.Drawing.Size(212, 37);
            this.btnce.TabIndex = 1;
            this.btnce.Text = "CE";
            this.btnce.UseVisualStyleBackColor = false;
            this.btnce.Click += new System.EventHandler(this.btnce_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn1.Location = new System.Drawing.Point(12, 160);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(103, 64);
            this.btn1.TabIndex = 2;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.rakam);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn2.Location = new System.Drawing.Point(121, 160);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(103, 64);
            this.btn2.TabIndex = 3;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.rakam);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn3.Location = new System.Drawing.Point(230, 160);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(103, 64);
            this.btn3.TabIndex = 4;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.rakam);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn6.Location = new System.Drawing.Point(230, 230);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(103, 64);
            this.btn6.TabIndex = 7;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.rakam);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn5.Location = new System.Drawing.Point(121, 230);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(103, 64);
            this.btn5.TabIndex = 6;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.rakam);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn4.Location = new System.Drawing.Point(12, 230);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(103, 64);
            this.btn4.TabIndex = 5;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.rakam);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn9.Location = new System.Drawing.Point(230, 300);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(103, 64);
            this.btn9.TabIndex = 10;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.rakam);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn8.Location = new System.Drawing.Point(121, 300);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(103, 64);
            this.btn8.TabIndex = 9;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.rakam);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn7.Location = new System.Drawing.Point(12, 300);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(103, 64);
            this.btn7.TabIndex = 8;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.rakam);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn0.Location = new System.Drawing.Point(121, 370);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(103, 64);
            this.btn0.TabIndex = 11;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.rakam);
            // 
            // btncikart
            // 
            this.btncikart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btncikart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btncikart.Location = new System.Drawing.Point(339, 370);
            this.btncikart.Name = "btncikart";
            this.btncikart.Size = new System.Drawing.Size(129, 64);
            this.btncikart.TabIndex = 15;
            this.btncikart.Text = "-";
            this.btncikart.UseVisualStyleBackColor = false;
            this.btncikart.Click += new System.EventHandler(this.OptHesap);
            // 
            // btntopla
            // 
            this.btntopla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btntopla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btntopla.Location = new System.Drawing.Point(339, 300);
            this.btntopla.Name = "btntopla";
            this.btntopla.Size = new System.Drawing.Size(129, 64);
            this.btntopla.TabIndex = 14;
            this.btntopla.Text = "+";
            this.btntopla.UseVisualStyleBackColor = false;
            this.btntopla.Click += new System.EventHandler(this.OptHesap);
            // 
            // btncarp
            // 
            this.btncarp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btncarp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btncarp.Location = new System.Drawing.Point(339, 230);
            this.btncarp.Name = "btncarp";
            this.btncarp.Size = new System.Drawing.Size(129, 64);
            this.btncarp.TabIndex = 13;
            this.btncarp.Text = "*";
            this.btncarp.UseVisualStyleBackColor = false;
            this.btncarp.Click += new System.EventHandler(this.OptHesap);
            // 
            // btnbol
            // 
            this.btnbol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnbol.Location = new System.Drawing.Point(339, 160);
            this.btnbol.Name = "btnbol";
            this.btnbol.Size = new System.Drawing.Size(129, 64);
            this.btnbol.TabIndex = 12;
            this.btnbol.Text = "/";
            this.btnbol.UseVisualStyleBackColor = false;
            this.btnbol.Click += new System.EventHandler(this.OptHesap);
            // 
            // btnsonuc
            // 
            this.btnsonuc.BackColor = System.Drawing.Color.Silver;
            this.btnsonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsonuc.Location = new System.Drawing.Point(339, 12);
            this.btnsonuc.Name = "btnsonuc";
            this.btnsonuc.Size = new System.Drawing.Size(129, 128);
            this.btnsonuc.TabIndex = 16;
            this.btnsonuc.Text = "=";
            this.btnsonuc.UseVisualStyleBackColor = false;
            this.btnsonuc.Click += new System.EventHandler(this.btnsonuc_Click);
            // 
            // btnmod
            // 
            this.btnmod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnmod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnmod.Location = new System.Drawing.Point(121, 437);
            this.btnmod.Name = "btnmod";
            this.btnmod.Size = new System.Drawing.Size(103, 64);
            this.btnmod.TabIndex = 19;
            this.btnmod.Text = "MOD";
            this.btnmod.UseVisualStyleBackColor = false;
            this.btnmod.Click += new System.EventHandler(this.btnmod_Click);
            // 
            // btnkarekok
            // 
            this.btnkarekok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnkarekok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkarekok.Location = new System.Drawing.Point(230, 437);
            this.btnkarekok.Name = "btnkarekok";
            this.btnkarekok.Size = new System.Drawing.Size(238, 64);
            this.btnkarekok.TabIndex = 18;
            this.btnkarekok.Text = "KAREKÖK";
            this.btnkarekok.UseVisualStyleBackColor = false;
            this.btnkarekok.Click += new System.EventHandler(this.btnkarekok_Click);
            // 
            // btnus
            // 
            this.btnus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnus.Location = new System.Drawing.Point(12, 437);
            this.btnus.Name = "btnus";
            this.btnus.Size = new System.Drawing.Size(103, 64);
            this.btnus.TabIndex = 17;
            this.btnus.Text = "ÜS";
            this.btnus.UseVisualStyleBackColor = false;
            this.btnus.Click += new System.EventHandler(this.btnus_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(230, 370);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 64);
            this.button1.TabIndex = 20;
            this.button1.Text = ",";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnyuzde
            // 
            this.btnyuzde.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnyuzde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnyuzde.Location = new System.Drawing.Point(12, 370);
            this.btnyuzde.Name = "btnyuzde";
            this.btnyuzde.Size = new System.Drawing.Size(103, 64);
            this.btnyuzde.TabIndex = 21;
            this.btnyuzde.Text = "%";
            this.btnyuzde.UseVisualStyleBackColor = false;
            this.btnyuzde.Click += new System.EventHandler(this.btnyuzde_Click);
            // 
            // lblsonuc
            // 
            this.lblsonuc.AutoSize = true;
            this.lblsonuc.BackColor = System.Drawing.Color.Silver;
            this.lblsonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsonuc.Location = new System.Drawing.Point(27, 29);
            this.lblsonuc.Name = "lblsonuc";
            this.lblsonuc.Size = new System.Drawing.Size(0, 29);
            this.lblsonuc.TabIndex = 22;
            // 
            // btnc
            // 
            this.btnc.BackColor = System.Drawing.Color.Silver;
            this.btnc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnc.Location = new System.Drawing.Point(230, 103);
            this.btnc.Name = "btnc";
            this.btnc.Size = new System.Drawing.Size(103, 37);
            this.btnc.TabIndex = 23;
            this.btnc.Text = "C";
            this.btnc.UseVisualStyleBackColor = false;
            this.btnc.Click += new System.EventHandler(this.btnc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(480, 513);
            this.Controls.Add(this.btnc);
            this.Controls.Add(this.lblsonuc);
            this.Controls.Add(this.btnyuzde);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnmod);
            this.Controls.Add(this.btnkarekok);
            this.Controls.Add(this.btnus);
            this.Controls.Add(this.btnsonuc);
            this.Controls.Add(this.btncikart);
            this.Controls.Add(this.btntopla);
            this.Controls.Add(this.btncarp);
            this.Controls.Add(this.btnbol);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnce);
            this.Controls.Add(this.txtsonuc);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Hesap Makinesi";
            this.Click += new System.EventHandler(this.OptHesap);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtsonuc;
        private System.Windows.Forms.Button btnce;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btncikart;
        private System.Windows.Forms.Button btntopla;
        private System.Windows.Forms.Button btncarp;
        private System.Windows.Forms.Button btnbol;
        private System.Windows.Forms.Button btnsonuc;
        private System.Windows.Forms.Button btnmod;
        private System.Windows.Forms.Button btnkarekok;
        private System.Windows.Forms.Button btnus;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnyuzde;
        private System.Windows.Forms.Label lblsonuc;
        private System.Windows.Forms.Button btnc;
    }
}

