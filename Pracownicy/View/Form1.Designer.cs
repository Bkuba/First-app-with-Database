﻿namespace Pracownicy
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbImie = new System.Windows.Forms.TextBox();
            this.tbNazwisko = new System.Windows.Forms.TextBox();
            this.tbWiek = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cbEtaty = new System.Windows.Forms.ComboBox();
            this.btdodajEtat = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Imie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nazwisko";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Wiek";
            // 
            // tbImie
            // 
            this.tbImie.Location = new System.Drawing.Point(101, 27);
            this.tbImie.Name = "tbImie";
            this.tbImie.Size = new System.Drawing.Size(100, 22);
            this.tbImie.TabIndex = 1;
            this.tbImie.TextChanged += new System.EventHandler(this.tbImie_TextChanged);
            // 
            // tbNazwisko
            // 
            this.tbNazwisko.Location = new System.Drawing.Point(101, 74);
            this.tbNazwisko.Name = "tbNazwisko";
            this.tbNazwisko.Size = new System.Drawing.Size(100, 22);
            this.tbNazwisko.TabIndex = 2;
            // 
            // tbWiek
            // 
            this.tbWiek.Location = new System.Drawing.Point(101, 128);
            this.tbWiek.Name = "tbWiek";
            this.tbWiek.Size = new System.Drawing.Size(100, 22);
            this.tbWiek.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(101, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 64);
            this.button1.TabIndex = 4;
            this.button1.Text = "Dodaj do bazy";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbEtaty
            // 
            this.cbEtaty.FormattingEnabled = true;
            this.cbEtaty.Items.AddRange(new object[] {
            "Dyrektor",
            "Menadzer",
            "Starszy programista"});
            this.cbEtaty.Location = new System.Drawing.Point(266, 24);
            this.cbEtaty.Name = "cbEtaty";
            this.cbEtaty.Size = new System.Drawing.Size(144, 24);
            this.cbEtaty.TabIndex = 5;
            // 
            // btdodajEtat
            // 
            this.btdodajEtat.Location = new System.Drawing.Point(335, 68);
            this.btdodajEtat.Name = "btdodajEtat";
            this.btdodajEtat.Size = new System.Drawing.Size(75, 23);
            this.btdodajEtat.TabIndex = 6;
            this.btdodajEtat.Text = "Dodaj";
            this.btdodajEtat.UseVisualStyleBackColor = true;
            this.btdodajEtat.Click += new System.EventHandler(this.btdodajEtat_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(278, 171);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(132, 21);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "tekst z texboxow";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(300, 211);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 72);
            this.button2.TabIndex = 8;
            this.button2.Text = "Dodaj z texboxow";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "zmywak"});
            this.comboBox1.Location = new System.Drawing.Point(509, 24);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 9;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(550, 65);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 28);
            this.button3.TabIndex = 10;
            this.button3.Text = "Aktualizuj";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(101, 303);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 11;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btdodajEtat);
            this.Controls.Add(this.cbEtaty);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbWiek);
            this.Controls.Add(this.tbNazwisko);
            this.Controls.Add(this.tbImie);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox tbImie;
        private System.Windows.Forms.TextBox tbNazwisko;
        private System.Windows.Forms.TextBox tbWiek;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbEtaty;
        private System.Windows.Forms.Button btdodajEtat;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

