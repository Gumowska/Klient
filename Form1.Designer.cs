﻿namespace Klient
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
            this.button1 = new System.Windows.Forms.Button();
            this.Adres = new System.Windows.Forms.TextBox();
            this.port_p = new System.Windows.Forms.NumericUpDown();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.polaczenie = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.port_p)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(429, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "Zamknij";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Adres
            // 
            this.Adres.Location = new System.Drawing.Point(43, 30);
            this.Adres.Name = "Adres";
            this.Adres.Size = new System.Drawing.Size(211, 20);
            this.Adres.TabIndex = 1;
            this.Adres.Text = "Adres";
            // 
            // port_p
            // 
            this.port_p.Location = new System.Drawing.Point(361, 29);
            this.port_p.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.port_p.Name = "port_p";
            this.port_p.Size = new System.Drawing.Size(264, 20);
            this.port_p.TabIndex = 2;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(25, 65);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(649, 264);
            this.listBox1.TabIndex = 3;
            // 
            // polaczenie
            // 
            this.polaczenie.Location = new System.Drawing.Point(131, 366);
            this.polaczenie.Name = "polaczenie";
            this.polaczenie.Size = new System.Drawing.Size(123, 45);
            this.polaczenie.TabIndex = 4;
            this.polaczenie.Text = "Polacz";
            this.polaczenie.UseVisualStyleBackColor = true;
            this.polaczenie.Click += new System.EventHandler(this.polaczenie_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 438);
            this.Controls.Add(this.polaczenie);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.port_p);
            this.Controls.Add(this.Adres);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";

            ((System.ComponentModel.ISupportInitialize)(this.port_p)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Adres;
        private System.Windows.Forms.NumericUpDown port_p;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button polaczenie;
    }
}

