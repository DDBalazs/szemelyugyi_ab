using Org.BouncyCastle.Math.Field;
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
    public partial class frmlekerdezes : Form
    {
        void betoltes()
        {
            dgadatok.Rows.Clear();
            string szukites = "";
            if (rbab.Checked)
            {
                szukites = " and szemelytorzs.kilepdatum is null ";
            }
            if (rbdis.Checked)
            {
                szukites = " and szemelytorzs.kilepdatum is not null ";
            }
            string searchleker = "";
            if (txsearch.Text.Length > 0)
            {
                searchleker = " and szemelytorzs.nev like '" + txsearch.Text + "%' ";
            }
            string lekerdezes = "select szemelytorzs.nev as n,szemelytorzs.szulido as sz,year(curdate())-year(szemelytorzs.szulido) as kor, szemelytorzs.fizetes as f, szemelytorzs.belepdatum as be, szemelytorzs.beosztas as beo,szemelytorzs.kilepdatum as kile,telephelytorzs.nev as net from szemely_telep,szemelytorzs,telephelytorzs where szemelytorzs.szemid = szemely_telep.szemid and telephelytorzs.tid = szemely_telep.tid "+szukites+searchleker+" group by szemelytorzs.nev order by szemelytorzs.nev";
            Adatbazis ab = new Adatbazis(lekerdezes);
            while (ab.Dr.Read())
            {
                DateTime szuletes = Convert.ToDateTime(ab.Dr["sz"]);
                DateTime belepes = Convert.ToDateTime(ab.Dr["be"]);
                string kilepes = "";
                if (!Convert.IsDBNull(ab.Dr["kile"]))
                {
                    DateTime kilep = Convert.ToDateTime(ab.Dr["kile"]);
                    kilepes=kilep.ToString("yyyy--MM--dd");
                }
                string beoszt = ab.Dr["beo"].ToString();
                string hosszunev = "";
                if(beoszt == "v")
                {
                    hosszunev = "vezetői";
                }
                else if(beoszt == "s")
                {
                    hosszunev = "szellemi";
                }
                else
                {
                    hosszunev = "fizikai";
                }
                dgadatok.Rows.Add(ab.Dr["n"], szuletes.ToString("yyyy-MM--dd"), ab.Dr["kor"], ab.Dr["f"], belepes.ToString("yyyy-MM--dd"), hosszunev, kilepes,ab.Dr["net"]);
            }
            ab.lezaras();
            lekerdezes = "select round(avg(fizetes),0) as atlag from szemelytorzs where kilepdatum is null";
            ab = new Adatbazis(lekerdezes);
            ab.Dr.Read();
            lbatlag.Text = "A dolgozók átlag fizetése: "+ ab.Dr["atlag"].ToString()+" Ft";
        }
        public frmlekerdezes()
        {
            InitializeComponent();
        }

        private void frmlekerdezes_Load(object sender, EventArgs e)
        {
            betoltes();
            rball.Checked = true;
        }

        private void rbab_CheckedChanged(object sender, EventArgs e)
        {
            betoltes();
        }

        private void rbdis_CheckedChanged(object sender, EventArgs e)
        {
            betoltes();
        }

        private void rball_CheckedChanged(object sender, EventArgs e)
        {
            betoltes();
        }

        private void txsearch_TextChanged(object sender, EventArgs e)
        {
            betoltes();
        }
    }
}
