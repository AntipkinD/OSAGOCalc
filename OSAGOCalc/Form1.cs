using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OSAGOCalc
{
    
    public partial class OSAGOCalc : Form
    {
        public OSAGOCalc()
        {
            InitializeComponent();
        }
        double rslt;
        double bt;
        double kt;
        double kbm;
        double ko;
        double kvs;
        double km;
        double ks;
        private void Figureout_button_Click(object sender, EventArgs e)
        {
            if (double.TryParse(BT.Text, out this.bt) == true & double.TryParse(KT.Text, out this.kt) == true & double.TryParse(KBM.Text, out this.kbm) == true & double.TryParse(KO.Text, out this.ko) == true
                & double.TryParse(KVS.Text, out this.kvs) == true & double.TryParse(KM.Text, out this.km) == true & double.TryParse(KS.Text, out this.ks) == true)
            {
                this.rslt = this.bt + this.kt + this.kbm + this.ko + this.kvs + this.km + this.ks;
                result.Text = Convert.ToString(this.rslt);
            }
        }

        private void Clear_button_Click(object sender, EventArgs e)
        {
            BT.Text = "Базовый тариф(БТ)";
            KT.Text = "Территориальный коэффициент (КТ)";
            KBM.Text = "Коэффициент \"бонус-малус\" (КБМ)";
            KO.Text = "Коэффициент ограничения (КО)";
            KVS.Text = "Коэффициент возраста и стажа (КВС)";
            KM.Text = "Коэффициент мощности двигателя (КМ)";
            KS.Text = "Коэффициент сезонности (КС)";
            result.Text = "Результат";
        }

        private void Export_button_Click(object sender, EventArgs e)
        {

        }
    }
}