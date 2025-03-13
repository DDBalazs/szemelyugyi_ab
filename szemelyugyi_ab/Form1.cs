using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace szemelyugyi_ab
{
    public partial class Form1 : Form
    {
        void telephelyfeltoltes()
        {
            cbtlephely.Items.Clear();
            string lekerdezes = "select nev from telephelytorzs";
            Adatbazis ab = new Adatbazis(lekerdezes);
            while(ab.Dr.Read())
            {
                cbtlephely.Items.Add(ab.Dr["nev"]);
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            telephelyfeltoltes();
            dtbelepdatum.Value=DateTime.Now;
        }

        private void txfizetes_TextChanged(object sender, EventArgs e)
        {
            if(txfizetes.TextLength>0)
            {
                try
                {
                    int szam = Convert.ToInt32(txfizetes.Text);
                }
                catch
                {
                    MessageBox.Show("A fizetés egész szám lehet!","HIBA",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    txfizetes.Clear();
                    txfizetes.Focus();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txnev.TextLength==0)
            {
                MessageBox.Show("Adja meg a dolgozó nevét!","HIBA",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txnev.Focus();
            }
            else if(txszulhely.TextLength == 0)
            {
                MessageBox.Show("Adja meg a dolgozó születési helyét!", "HIBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txszulhely.Focus();
            }
            else if (txfizetes.TextLength == 0)
            {
                MessageBox.Show("Adja meg a dolgozó fizetését!", "HIBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txfizetes.Focus();
            }
            else if(cbbeosztas.SelectedItem is null)
            {
                MessageBox.Show("Adja meg a dolgozó beosztását!", "HIBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbbeosztas.Focus();
            }
            else if(cbtlephely.SelectedItem is null)
            {
                MessageBox.Show("Adja meg a dolgozó telephelyét!", "HIBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbtlephely.Focus();
            }
            else if(txszemid.TextLength<4)
            {
                MessageBox.Show("Adja meg a dolgozó azonosítóját!", "HIBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txszemid.Focus();
            }
            else
            {
                string lekerdezes = "select count(szemid) as szam from szemelytorzs where szemid='"+txszemid.Text+"'";
                Adatbazis ab = new Adatbazis(lekerdezes);
                ab.Dr.Read();
                int eredmeny = Convert.ToInt32(ab.Dr["szam"]);
                ab.lezaras();
                if(eredmeny>0)
                {
                    MessageBox.Show("Ilyen azonosító már létezik! Adjon meg másikat!", "HIBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txszemid.Clear();
                    txszemid.Focus();
                }
                else
                {
                    lekerdezes = "select tid from telephelytorzs where nev='" + cbtlephely.Text + "'";
                    ab = new Adatbazis(lekerdezes);
                    ab.Dr.Read();
                    string tid = ab.Dr["tid"].ToString();
                    ab.lezaras();
                    lekerdezes = "insert into szemelytorzs(szemid,nev,szulhely,szulido,fizetes,belepdatum,kilepdatum,beosztas) values ('" + txszemid.Text + "','" + txnev.Text + "','" + txszulhely.Text + "','" + dtszulido.Text + "','" + txfizetes.Text + "','" + dtbelepdatum.Text + "',null,'" + cbbeosztas.Text[0]+"')";
                    ab = new Adatbazis(lekerdezes);
                    ab.Dr.Read();
                    ab.lezaras();
                    lekerdezes = "insert into szemely_telep(szemid,tid) values ('"+txszemid.Text+"','"+tid+"')";
                    ab = new Adatbazis(lekerdezes);
                    ab.Dr.Read();
                    MessageBox.Show("Sikeres adatbetöltés","SIKER", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmlekerdezes ujleker=new frmlekerdezes();
            ujleker.ShowDialog();
        }
    }
}
