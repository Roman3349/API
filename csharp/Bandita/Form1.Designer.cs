namespace Bandita
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbTretiCislo = new System.Windows.Forms.Label();
            this.btnHrej = new System.Windows.Forms.Button();
            this.lbVyhra = new System.Windows.Forms.Label();
            this.txtVklad = new System.Windows.Forms.TextBox();
            this.lbCastka = new System.Windows.Forms.Label();
            this.btnVloz = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.picObrazek1 = new System.Windows.Forms.PictureBox();
            this.picObrazek2 = new System.Windows.Forms.PictureBox();
            this.picObrazek3 = new System.Windows.Forms.PictureBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.picObrazek1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picObrazek2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picObrazek3)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTretiCislo
            // 
            this.lbTretiCislo.AutoSize = true;
            this.lbTretiCislo.Font = new System.Drawing.Font("Microsoft Sans Serif", 150F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbTretiCislo.Location = new System.Drawing.Point(726, 77);
            this.lbTretiCislo.Name = "lbTretiCislo";
            this.lbTretiCislo.Size = new System.Drawing.Size(0, 283);
            this.lbTretiCislo.TabIndex = 2;
            // 
            // btnHrej
            // 
            this.btnHrej.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnHrej.Location = new System.Drawing.Point(464, 542);
            this.btnHrej.Name = "btnHrej";
            this.btnHrej.Size = new System.Drawing.Size(125, 66);
            this.btnHrej.TabIndex = 3;
            this.btnHrej.Text = "Hrej";
            this.btnHrej.UseVisualStyleBackColor = true;
            this.btnHrej.Click += new System.EventHandler(this.btnHrej_Click);
            // 
            // lbVyhra
            // 
            this.lbVyhra.AutoSize = true;
            this.lbVyhra.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbVyhra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbVyhra.Location = new System.Drawing.Point(454, 467);
            this.lbVyhra.Name = "lbVyhra";
            this.lbVyhra.Size = new System.Drawing.Size(163, 55);
            this.lbVyhra.TabIndex = 4;
            this.lbVyhra.Text = "Výhra!";
            // 
            // txtVklad
            // 
            this.txtVklad.Location = new System.Drawing.Point(814, 599);
            this.txtVklad.Name = "txtVklad";
            this.txtVklad.Size = new System.Drawing.Size(100, 22);
            this.txtVklad.TabIndex = 5;
            // 
            // lbCastka
            // 
            this.lbCastka.AutoSize = true;
            this.lbCastka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbCastka.Location = new System.Drawing.Point(258, 566);
            this.lbCastka.Name = "lbCastka";
            this.lbCastka.Size = new System.Drawing.Size(23, 25);
            this.lbCastka.TabIndex = 6;
            this.lbCastka.Text = "0";
            // 
            // btnVloz
            // 
            this.btnVloz.Location = new System.Drawing.Point(920, 599);
            this.btnVloz.Name = "btnVloz";
            this.btnVloz.Size = new System.Drawing.Size(75, 23);
            this.btnVloz.TabIndex = 7;
            this.btnVloz.Text = "Vložit";
            this.btnVloz.UseVisualStyleBackColor = true;
            this.btnVloz.Click += new System.EventHandler(this.btnVloz_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(27, 566);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Aktuální částka:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(814, 566);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Vlož částku";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "MP900180394.JPG");
            this.imageList1.Images.SetKeyName(1, "MP900262823.JPG");
            this.imageList1.Images.SetKeyName(2, "MP900262893.JPG");
            this.imageList1.Images.SetKeyName(3, "MP900430836.JPG");
            this.imageList1.Images.SetKeyName(4, "MP900438661.JPG");
            this.imageList1.Images.SetKeyName(5, "MP900439270.JPG");
            this.imageList1.Images.SetKeyName(6, "MP900439280.JPG");
            // 
            // picObrazek1
            // 
            this.picObrazek1.Location = new System.Drawing.Point(60, 77);
            this.picObrazek1.Name = "picObrazek1";
            this.picObrazek1.Size = new System.Drawing.Size(250, 250);
            this.picObrazek1.TabIndex = 10;
            this.picObrazek1.TabStop = false;
            this.picObrazek1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // picObrazek2
            // 
            this.picObrazek2.Location = new System.Drawing.Point(394, 77);
            this.picObrazek2.Name = "picObrazek2";
            this.picObrazek2.Size = new System.Drawing.Size(250, 250);
            this.picObrazek2.TabIndex = 11;
            this.picObrazek2.TabStop = false;
            this.picObrazek2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // picObrazek3
            // 
            this.picObrazek3.Location = new System.Drawing.Point(718, 77);
            this.picObrazek3.Name = "picObrazek3";
            this.picObrazek3.Size = new System.Drawing.Size(250, 250);
            this.picObrazek3.TabIndex = 12;
            this.picObrazek3.TabStop = false;
            this.picObrazek3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(158, 339);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(98, 21);
            this.checkBox1.TabIndex = 13;
			this.checkBox1.Text = "Zastav válec";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(475, 339);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(98, 21);
            this.checkBox2.TabIndex = 14;
			this.checkBox2.Text = "Zastav válec";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(796, 339);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(98, 21);
            this.checkBox3.TabIndex = 15;
            this.checkBox3.Text = "Zastav válec";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 644);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.picObrazek3);
            this.Controls.Add(this.picObrazek2);
            this.Controls.Add(this.picObrazek1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVloz);
            this.Controls.Add(this.lbCastka);
            this.Controls.Add(this.txtVklad);
            this.Controls.Add(this.lbVyhra);
            this.Controls.Add(this.btnHrej);
            this.Controls.Add(this.lbTretiCislo);
            this.Name = "Form1";
            this.Text = "Bandita";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picObrazek1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picObrazek2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picObrazek3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTretiCislo;
        private System.Windows.Forms.Button btnHrej;
        private System.Windows.Forms.Label lbVyhra;
        private System.Windows.Forms.TextBox txtVklad;
        private System.Windows.Forms.Label lbCastka;
        private System.Windows.Forms.Button btnVloz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox picObrazek1;
        private System.Windows.Forms.PictureBox picObrazek2;
        private System.Windows.Forms.PictureBox picObrazek3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
    }
}

