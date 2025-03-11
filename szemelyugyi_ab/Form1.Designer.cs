namespace szemelyugyi_ab
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
            this.label1 = new System.Windows.Forms.Label();
            this.txszemid = new System.Windows.Forms.TextBox();
            this.txnev = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txszulhely = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtszulido = new System.Windows.Forms.DateTimePicker();
            this.cbbeosztas = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbtlephely = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dtbelepdatum = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txfizetes = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Azonosító:";
            // 
            // txszemid
            // 
            this.txszemid.Location = new System.Drawing.Point(122, 41);
            this.txszemid.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txszemid.MaxLength = 4;
            this.txszemid.Name = "txszemid";
            this.txszemid.Size = new System.Drawing.Size(57, 20);
            this.txszemid.TabIndex = 1;
            // 
            // txnev
            // 
            this.txnev.Location = new System.Drawing.Point(94, 85);
            this.txnev.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txnev.MaxLength = 45;
            this.txnev.Name = "txnev";
            this.txnev.Size = new System.Drawing.Size(171, 20);
            this.txnev.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Név:";
            // 
            // txszulhely
            // 
            this.txszulhely.Location = new System.Drawing.Point(153, 134);
            this.txszulhely.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txszulhely.MaxLength = 20;
            this.txszulhely.Name = "txszulhely";
            this.txszulhely.Size = new System.Drawing.Size(116, 20);
            this.txszulhely.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 141);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Születési helye:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 181);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Születési dátum:";
            // 
            // dtszulido
            // 
            this.dtszulido.CustomFormat = "yyyy-MM-dd";
            this.dtszulido.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtszulido.Location = new System.Drawing.Point(157, 175);
            this.dtszulido.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtszulido.Name = "dtszulido";
            this.dtszulido.Size = new System.Drawing.Size(135, 20);
            this.dtszulido.TabIndex = 7;
            // 
            // cbbeosztas
            // 
            this.cbbeosztas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbeosztas.FormattingEnabled = true;
            this.cbbeosztas.Items.AddRange(new object[] {
            "szellemi",
            "fizikai",
            "vezető"});
            this.cbbeosztas.Location = new System.Drawing.Point(125, 310);
            this.cbbeosztas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbbeosztas.Name = "cbbeosztas";
            this.cbbeosztas.Size = new System.Drawing.Size(140, 21);
            this.cbbeosztas.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 318);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Beosztás:";
            // 
            // cbtlephely
            // 
            this.cbtlephely.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbtlephely.FormattingEnabled = true;
            this.cbtlephely.Location = new System.Drawing.Point(129, 357);
            this.cbtlephely.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbtlephely.Name = "cbtlephely";
            this.cbtlephely.Size = new System.Drawing.Size(140, 21);
            this.cbtlephely.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 365);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Telephely:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(339, 288);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 43);
            this.button1.TabIndex = 12;
            this.button1.Text = "Mentés";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Belépés dátuma:";
            // 
            // dtbelepdatum
            // 
            this.dtbelepdatum.CustomFormat = "yyyy-MM-dd";
            this.dtbelepdatum.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtbelepdatum.Location = new System.Drawing.Point(153, 217);
            this.dtbelepdatum.Name = "dtbelepdatum";
            this.dtbelepdatum.Size = new System.Drawing.Size(139, 20);
            this.dtbelepdatum.TabIndex = 14;
            this.dtbelepdatum.Value = new System.DateTime(2025, 3, 2, 11, 59, 0, 0);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(49, 271);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Fizetés:";
            // 
            // txfizetes
            // 
            this.txfizetes.Location = new System.Drawing.Point(106, 268);
            this.txfizetes.Name = "txfizetes";
            this.txfizetes.Size = new System.Drawing.Size(100, 20);
            this.txfizetes.TabIndex = 16;
            this.txfizetes.TextChanged += new System.EventHandler(this.txfizetes_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(347, 112);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 61);
            this.button2.TabIndex = 17;
            this.button2.Text = "Lekérdezés";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 393);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txfizetes);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtbelepdatum);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbtlephely);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbbeosztas);
            this.Controls.Add(this.dtszulido);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txszulhely);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txnev);
            this.Controls.Add(this.txszemid);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Új felvitel";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txszemid;
        private System.Windows.Forms.TextBox txnev;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txszulhely;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtszulido;
        private System.Windows.Forms.ComboBox cbbeosztas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbtlephely;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtbelepdatum;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txfizetes;
        private System.Windows.Forms.Button button2;
    }
}

