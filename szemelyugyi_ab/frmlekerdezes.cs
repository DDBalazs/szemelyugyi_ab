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
            string lekerdezes = "select szemelytorzs.nev as n,szemelytorzs.szulido as sz,year(curdate())-year(szemelytorzs.szulido) as kor, szemelytorzs.fizetes as f, szemelytorzs.belepdatum as be, szemelytorzs.beosztas as beo,szemelytorzs.kilepdatum as kile,telephelytorzs.nev as net from szemely_telep,szemelytorzs,telephelytorzs where szemelytorzs.szemid = szemely_telep.szemid and telephelytorzs.tid = szemely_telep.tid group by szemelytorzs.nev order by szemelytorzs.nev";
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
        }
        public frmlekerdezes()
        {
            InitializeComponent();
        }

        private void frmlekerdezes_Load(object sender, EventArgs e)
        {
            betoltes();
        }
    }
}
