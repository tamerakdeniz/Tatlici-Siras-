namespace tatlicisirasi
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnSirayaGir = new System.Windows.Forms.Button();
            this.txtSiraNo = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(56, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sıra Alınız";
            // 
            // btnSirayaGir
            // 
            this.btnSirayaGir.Location = new System.Drawing.Point(46, 50);
            this.btnSirayaGir.Name = "btnSirayaGir";
            this.btnSirayaGir.Size = new System.Drawing.Size(106, 23);
            this.btnSirayaGir.TabIndex = 1;
            this.btnSirayaGir.Text = "SIRAYA GİR";
            this.btnSirayaGir.UseVisualStyleBackColor = true;
            this.btnSirayaGir.Click += new System.EventHandler(this.btnSirayaGir_Click);
            // 
            // txtSiraNo
            // 
            this.txtSiraNo.Location = new System.Drawing.Point(167, 50);
            this.txtSiraNo.Name = "txtSiraNo";
            this.txtSiraNo.Size = new System.Drawing.Size(260, 23);
            this.txtSiraNo.TabIndex = 2;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(46, 118);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(231, 289);
            this.listBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(111, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "TATLI SIRASI";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 15;
            this.listBox2.Location = new System.Drawing.Point(515, 118);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(231, 289);
            this.listBox2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(540, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "SIRASI GELEN MÜŞTERİLER";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(315, 190);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 102);
            this.button2.TabIndex = 6;
            this.button2.Text = "SIRADAKİ MÜŞTERİYİ ÇAĞIR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.Location = new System.Drawing.Point(621, 24);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(125, 49);
            this.button6.TabIndex = 10;
            this.button6.Text = "PROGRAMI KAPAT";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtSiraNo);
            this.Controls.Add(this.btnSirayaGir);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btnSirayaGir;
        private TextBox txtSiraNo;
        private ListBox listBox1;
        private Label label2;
        private ListBox listBox2;
        private Label label3;
        private Button button2;
        private Button button6;
    }
}