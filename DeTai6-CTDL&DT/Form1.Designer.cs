using System;
using System.Windows.Forms;
namespace DeTai6_CTDL_DT
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
            this.textbox = new System.Windows.Forms.TextBox();
            this.C = new System.Windows.Forms.Button();
            this.Xóa = new System.Windows.Forms.Button();
            this.open = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.tru = new System.Windows.Forms.Button();
            this.nhan = new System.Windows.Forms.Button();
            this.so1 = new System.Windows.Forms.Button();
            this.so2 = new System.Windows.Forms.Button();
            this.so3 = new System.Windows.Forms.Button();
            this.cong = new System.Windows.Forms.Button();
            this.so4 = new System.Windows.Forms.Button();
            this.so5 = new System.Windows.Forms.Button();
            this.so6 = new System.Windows.Forms.Button();
            this.so7 = new System.Windows.Forms.Button();
            this.so8 = new System.Windows.Forms.Button();
            this.so9 = new System.Windows.Forms.Button();
            this.chia = new System.Windows.Forms.Button();
            this.bang = new System.Windows.Forms.Button();
            this.textbox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textbox
            // 
            this.textbox.Location = new System.Drawing.Point(67, 94);
            this.textbox.Margin = new System.Windows.Forms.Padding(2);
            this.textbox.Name = "textbox";
            this.textbox.Size = new System.Drawing.Size(178, 20);
            this.textbox.TabIndex = 0;
            this.textbox.TextChanged += new System.EventHandler(this.textbox_TextChanged);
            // 
            // C
            // 
            this.C.Location = new System.Drawing.Point(67, 129);
            this.C.Margin = new System.Windows.Forms.Padding(2);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(56, 26);
            this.C.TabIndex = 2;
            this.C.Text = "C";
            this.C.UseVisualStyleBackColor = true;
            this.C.Click += new System.EventHandler(this.C_Click);
            // 
            // Xóa
            // 
            this.Xóa.Location = new System.Drawing.Point(128, 129);
            this.Xóa.Margin = new System.Windows.Forms.Padding(2);
            this.Xóa.Name = "Xóa";
            this.Xóa.Size = new System.Drawing.Size(56, 26);
            this.Xóa.TabIndex = 3;
            this.Xóa.Text = "Xóa";
            this.Xóa.UseVisualStyleBackColor = true;
            this.Xóa.Click += new System.EventHandler(this.Xóa_Click);
            // 
            // open
            // 
            this.open.Location = new System.Drawing.Point(188, 129);
            this.open.Margin = new System.Windows.Forms.Padding(2);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(26, 26);
            this.open.TabIndex = 4;
            this.open.Text = "(";
            this.open.UseVisualStyleBackColor = true;
            this.open.Click += new System.EventHandler(this.open_Click);
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(219, 129);
            this.close.Margin = new System.Windows.Forms.Padding(2);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(26, 26);
            this.close.TabIndex = 5;
            this.close.Text = ")";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // tru
            // 
            this.tru.Location = new System.Drawing.Point(249, 222);
            this.tru.Margin = new System.Windows.Forms.Padding(2);
            this.tru.Name = "tru";
            this.tru.Size = new System.Drawing.Size(56, 26);
            this.tru.TabIndex = 6;
            this.tru.Text = "-";
            this.tru.UseVisualStyleBackColor = true;
            this.tru.Click += new System.EventHandler(this.tru_Click);
            // 
            // nhan
            // 
            this.nhan.Location = new System.Drawing.Point(250, 160);
            this.nhan.Margin = new System.Windows.Forms.Padding(2);
            this.nhan.Name = "nhan";
            this.nhan.Size = new System.Drawing.Size(56, 26);
            this.nhan.TabIndex = 7;
            this.nhan.Text = "*";
            this.nhan.UseVisualStyleBackColor = true;
            this.nhan.Click += new System.EventHandler(this.nhan_Click);
            // 
            // so1
            // 
            this.so1.Location = new System.Drawing.Point(67, 165);
            this.so1.Margin = new System.Windows.Forms.Padding(2);
            this.so1.Name = "so1";
            this.so1.Size = new System.Drawing.Size(56, 35);
            this.so1.TabIndex = 8;
            this.so1.Text = "1";
            this.so1.UseVisualStyleBackColor = true;
            this.so1.Click += new System.EventHandler(this.so1_Click);
            // 
            // so2
            // 
            this.so2.Location = new System.Drawing.Point(128, 165);
            this.so2.Margin = new System.Windows.Forms.Padding(2);
            this.so2.Name = "so2";
            this.so2.Size = new System.Drawing.Size(56, 35);
            this.so2.TabIndex = 9;
            this.so2.Text = "2";
            this.so2.UseVisualStyleBackColor = true;
            this.so2.Click += new System.EventHandler(this.so2_Click);
            // 
            // so3
            // 
            this.so3.Location = new System.Drawing.Point(188, 165);
            this.so3.Margin = new System.Windows.Forms.Padding(2);
            this.so3.Name = "so3";
            this.so3.Size = new System.Drawing.Size(56, 35);
            this.so3.TabIndex = 10;
            this.so3.Text = "3";
            this.so3.UseVisualStyleBackColor = true;
            this.so3.Click += new System.EventHandler(this.so3_Click);
            // 
            // cong
            // 
            this.cong.Location = new System.Drawing.Point(250, 191);
            this.cong.Margin = new System.Windows.Forms.Padding(2);
            this.cong.Name = "cong";
            this.cong.Size = new System.Drawing.Size(56, 26);
            this.cong.TabIndex = 11;
            this.cong.Text = "+";
            this.cong.UseVisualStyleBackColor = true;
            this.cong.Click += new System.EventHandler(this.cong_Click);
            // 
            // so4
            // 
            this.so4.Location = new System.Drawing.Point(67, 205);
            this.so4.Margin = new System.Windows.Forms.Padding(2);
            this.so4.Name = "so4";
            this.so4.Size = new System.Drawing.Size(56, 35);
            this.so4.TabIndex = 12;
            this.so4.Text = "4";
            this.so4.UseVisualStyleBackColor = true;
            this.so4.Click += new System.EventHandler(this.so4_Click);
            // 
            // so5
            // 
            this.so5.Location = new System.Drawing.Point(128, 205);
            this.so5.Margin = new System.Windows.Forms.Padding(2);
            this.so5.Name = "so5";
            this.so5.Size = new System.Drawing.Size(56, 35);
            this.so5.TabIndex = 13;
            this.so5.Text = "5";
            this.so5.UseVisualStyleBackColor = true;
            this.so5.Click += new System.EventHandler(this.so5_Click);
            // 
            // so6
            // 
            this.so6.Location = new System.Drawing.Point(188, 205);
            this.so6.Margin = new System.Windows.Forms.Padding(2);
            this.so6.Name = "so6";
            this.so6.Size = new System.Drawing.Size(56, 35);
            this.so6.TabIndex = 14;
            this.so6.Text = "6";
            this.so6.UseVisualStyleBackColor = true;
            this.so6.Click += new System.EventHandler(this.so6_Click_1);
            // 
            // so7
            // 
            this.so7.Location = new System.Drawing.Point(67, 245);
            this.so7.Margin = new System.Windows.Forms.Padding(2);
            this.so7.Name = "so7";
            this.so7.Size = new System.Drawing.Size(56, 34);
            this.so7.TabIndex = 15;
            this.so7.Text = "7";
            this.so7.UseVisualStyleBackColor = true;
            this.so7.Click += new System.EventHandler(this.so7_Click);
            // 
            // so8
            // 
            this.so8.Location = new System.Drawing.Point(128, 245);
            this.so8.Margin = new System.Windows.Forms.Padding(2);
            this.so8.Name = "so8";
            this.so8.Size = new System.Drawing.Size(56, 34);
            this.so8.TabIndex = 16;
            this.so8.Text = "8";
            this.so8.UseVisualStyleBackColor = true;
            this.so8.Click += new System.EventHandler(this.so8_Click);
            // 
            // so9
            // 
            this.so9.Location = new System.Drawing.Point(188, 245);
            this.so9.Margin = new System.Windows.Forms.Padding(2);
            this.so9.Name = "so9";
            this.so9.Size = new System.Drawing.Size(56, 34);
            this.so9.TabIndex = 17;
            this.so9.Text = "9";
            this.so9.UseVisualStyleBackColor = true;
            this.so9.Click += new System.EventHandler(this.so9_Click);
            // 
            // chia
            // 
            this.chia.Location = new System.Drawing.Point(250, 128);
            this.chia.Margin = new System.Windows.Forms.Padding(2);
            this.chia.Name = "chia";
            this.chia.Size = new System.Drawing.Size(56, 27);
            this.chia.TabIndex = 18;
            this.chia.Text = "/";
            this.chia.UseVisualStyleBackColor = true;
            this.chia.Click += new System.EventHandler(this.chia_Click);
            // 
            // bang
            // 
            this.bang.Location = new System.Drawing.Point(250, 253);
            this.bang.Margin = new System.Windows.Forms.Padding(2);
            this.bang.Name = "bang";
            this.bang.Size = new System.Drawing.Size(56, 26);
            this.bang.TabIndex = 19;
            this.bang.Text = "=";
            this.bang.UseVisualStyleBackColor = true;
            this.bang.Click += new System.EventHandler(this.bang_Click);
            // 
            // textbox1
            // 
            this.textbox1.Location = new System.Drawing.Point(250, 94);
            this.textbox1.Name = "textbox1";
            this.textbox1.Size = new System.Drawing.Size(56, 20);
            this.textbox1.TabIndex = 20;
            this.textbox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 366);
            this.Controls.Add(this.textbox1);
            this.Controls.Add(this.bang);
            this.Controls.Add(this.chia);
            this.Controls.Add(this.so9);
            this.Controls.Add(this.so8);
            this.Controls.Add(this.so7);
            this.Controls.Add(this.so6);
            this.Controls.Add(this.so5);
            this.Controls.Add(this.so4);
            this.Controls.Add(this.cong);
            this.Controls.Add(this.so3);
            this.Controls.Add(this.so2);
            this.Controls.Add(this.so1);
            this.Controls.Add(this.nhan);
            this.Controls.Add(this.tru);
            this.Controls.Add(this.close);
            this.Controls.Add(this.open);
            this.Controls.Add(this.Xóa);
            this.Controls.Add(this.C);
            this.Controls.Add(this.textbox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void so1_Click(object sender, EventArgs e)
        {
            textbox.Text += "1";
        }
        
        private void C_Click(object sender, EventArgs e)
        {
            textbox.Text = "";
        }
        

        private void textbox_TextChanged(object sender, EventArgs e)
        {

        }

        #endregion

        private System.Windows.Forms.TextBox textbox;
        private System.Windows.Forms.Button C;
        private System.Windows.Forms.Button Xóa;
        private System.Windows.Forms.Button open;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button tru;
        private System.Windows.Forms.Button nhan;
        private System.Windows.Forms.Button so1;
        private System.Windows.Forms.Button so2;
        private System.Windows.Forms.Button so3;
        private System.Windows.Forms.Button cong;
        private System.Windows.Forms.Button so4;
        private System.Windows.Forms.Button so5;
        private System.Windows.Forms.Button so6;
        private System.Windows.Forms.Button so7;
        private System.Windows.Forms.Button so8;
        private System.Windows.Forms.Button so9;
        private System.Windows.Forms.Button chia;
        private System.Windows.Forms.Button bang;
        private TextBox textbox1;
    }
}

