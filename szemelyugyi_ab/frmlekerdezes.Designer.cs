namespace szemelyugyi_ab
{
    partial class frmlekerdezes
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
            this.dgadatok = new System.Windows.Forms.DataGridView();
            this.nev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.szulido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eletkor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fizetes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.belepdatum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.beosztas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kilepdatum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tnev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txsearch = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbab = new System.Windows.Forms.RadioButton();
            this.rbdis = new System.Windows.Forms.RadioButton();
            this.rball = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgadatok)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgadatok
            // 
            this.dgadatok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgadatok.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nev,
            this.szulido,
            this.eletkor,
            this.fizetes,
            this.belepdatum,
            this.beosztas,
            this.kilepdatum,
            this.tnev});
            this.dgadatok.Location = new System.Drawing.Point(14, 119);
            this.dgadatok.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgadatok.Name = "dgadatok";
            this.dgadatok.Size = new System.Drawing.Size(900, 320);
            this.dgadatok.TabIndex = 0;
            // 
            // nev
            // 
            this.nev.HeaderText = "Dolgozó neve";
            this.nev.Name = "nev";
            this.nev.ReadOnly = true;
            this.nev.Width = 200;
            // 
            // szulido
            // 
            this.szulido.HeaderText = "Születési idő";
            this.szulido.Name = "szulido";
            this.szulido.ReadOnly = true;
            // 
            // eletkor
            // 
            this.eletkor.HeaderText = "Életkor";
            this.eletkor.Name = "eletkor";
            this.eletkor.ReadOnly = true;
            this.eletkor.Width = 50;
            // 
            // fizetes
            // 
            this.fizetes.HeaderText = "Fizetés";
            this.fizetes.Name = "fizetes";
            this.fizetes.ReadOnly = true;
            // 
            // belepdatum
            // 
            this.belepdatum.HeaderText = "Belépés dátuma";
            this.belepdatum.Name = "belepdatum";
            this.belepdatum.ReadOnly = true;
            // 
            // beosztas
            // 
            this.beosztas.HeaderText = "Beosztása";
            this.beosztas.Name = "beosztas";
            this.beosztas.ReadOnly = true;
            // 
            // kilepdatum
            // 
            this.kilepdatum.HeaderText = "Kilépés dátuma";
            this.kilepdatum.Name = "kilepdatum";
            this.kilepdatum.ReadOnly = true;
            // 
            // tnev
            // 
            this.tnev.HeaderText = "Telephely neve";
            this.tnev.Name = "tnev";
            this.tnev.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 88);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Keresés";
            // 
            // txsearch
            // 
            this.txsearch.Location = new System.Drawing.Point(73, 85);
            this.txsearch.Name = "txsearch";
            this.txsearch.Size = new System.Drawing.Size(123, 20);
            this.txsearch.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rball);
            this.groupBox1.Controls.Add(this.rbdis);
            this.groupBox1.Controls.Add(this.rbab);
            this.groupBox1.Location = new System.Drawing.Point(579, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 93);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Státusz";
            // 
            // rbab
            // 
            this.rbab.AutoSize = true;
            this.rbab.Location = new System.Drawing.Point(7, 20);
            this.rbab.Name = "rbab";
            this.rbab.Size = new System.Drawing.Size(70, 17);
            this.rbab.TabIndex = 0;
            this.rbab.TabStop = true;
            this.rbab.Text = "Aktívak";
            this.rbab.UseVisualStyleBackColor = true;
            // 
            // rbdis
            // 
            this.rbdis.AutoSize = true;
            this.rbdis.Location = new System.Drawing.Point(6, 43);
            this.rbdis.Name = "rbdis";
            this.rbdis.Size = new System.Drawing.Size(82, 17);
            this.rbdis.TabIndex = 1;
            this.rbdis.TabStop = true;
            this.rbdis.Text = "Kilépettek";
            this.rbdis.UseVisualStyleBackColor = true;
            // 
            // rball
            // 
            this.rball.AutoSize = true;
            this.rball.Location = new System.Drawing.Point(7, 66);
            this.rball.Name = "rball";
            this.rball.Size = new System.Drawing.Size(76, 17);
            this.rball.TabIndex = 2;
            this.rball.TabStop = true;
            this.rball.Text = "Mindenki";
            this.rball.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(17, 446);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(897, 63);
            this.panel1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "label2";
            // 
            // frmlekerdezes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 521);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txsearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgadatok);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmlekerdezes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmlekerdezes";
            this.Load += new System.EventHandler(this.frmlekerdezes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgadatok)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgadatok;
        private System.Windows.Forms.DataGridViewTextBoxColumn nev;
        private System.Windows.Forms.DataGridViewTextBoxColumn szulido;
        private System.Windows.Forms.DataGridViewTextBoxColumn eletkor;
        private System.Windows.Forms.DataGridViewTextBoxColumn fizetes;
        private System.Windows.Forms.DataGridViewTextBoxColumn belepdatum;
        private System.Windows.Forms.DataGridViewTextBoxColumn beosztas;
        private System.Windows.Forms.DataGridViewTextBoxColumn kilepdatum;
        private System.Windows.Forms.DataGridViewTextBoxColumn tnev;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txsearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rball;
        private System.Windows.Forms.RadioButton rbdis;
        private System.Windows.Forms.RadioButton rbab;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
    }
}