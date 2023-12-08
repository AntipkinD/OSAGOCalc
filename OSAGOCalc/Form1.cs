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
        public double rslt;
        public double bt;
        public double kt;
        public double kbm;
        public double ko;
        public double kvs;
        public double km;
        public double ks;
        public string tosave;
        //Метод для расчета ОСАГО
        void GetResult(double bt, double kt, double kbm, double ko, double kvs, double km, double ks, TextBox xtx)
        {
            double rslt = bt * kt * kbm * ko * kvs * km * ks;
            xtx.Text = Convert.ToString(rslt);
        }
        //Кнопка для расчета ОСАГО
        public void Figureout_button_Click(object sender, EventArgs e)
        {
            if (double.TryParse(BT.Text, out this.bt) == true & double.TryParse(KT.Text, out this.kt) == true & double.TryParse(KBM.Text, out this.kbm) == true & double.TryParse(KO.Text, out this.ko) == true
                & double.TryParse(KVS.Text, out this.kvs) == true & double.TryParse(KM.Text, out this.km) == true & double.TryParse(KS.Text, out this.ks) == true)
            {
                GetResult(this.bt, this.kt, this.kbm, this.ko, this.kvs, this.km, this.ks, result);
            }
            else MessageBox.Show("Пожалуйста, введите или выберите числовые значения коэффициентов!", "Неверный ввод", MessageBoxButtons.OK);
        }
        //Метод для очистки полей
        public void Clear_button_Click(object sender, EventArgs e)
        {
            BT.Text = "Базовый тариф (БТ)";
            KT.Text = "Территориальный коэффициент (КТ)";
            KBM.Text = "Коэффициент \"бонус-малус\" (КБМ)";
            KO.Text = "Коэффициент ограничения (КО)";
            KVS.Text = "Коэффициент возраста и стажа (КВС)";
            KM.Text = "Коэффициент мощности двигателя (КМ)";
            KS.Text = "Коэффициент сезонности (КС)";
            result.Text = "Результат";
        }
        //Метод для расчета ОСАГО и сохранения результата в файл
        public void Export_button_Click(object sender, EventArgs e)
        {
            if (double.TryParse(BT.Text, out this.bt) == true & double.TryParse(KT.Text, out this.kt) == true & double.TryParse(KBM.Text, out this.kbm) == true & double.TryParse(KO.Text, out this.ko) == true
                & double.TryParse(KVS.Text, out this.kvs) == true & double.TryParse(KM.Text, out this.km) == true & double.TryParse(KS.Text, out this.ks) == true & result.Text != "Результат")
            {
                GetResult(this.bt, this.kt, this.kbm, this.ko, this.kvs, this.km, this.ks, result);
                this.tosave = $"Базовый тариф (БТ): {this.bt}" +
                $"\nТерриториальный коэффициент (КТ): {this.kt}" +
                $"\nКоэффициент \"бонус-малус\" (КБМ): {this.kbm}" +
                $"\nКоэффициент ограничения (КО): {this.ko}" +
                $"\nКоэффициент возраста и стажа (КВС): {this.kvs}" +
                $"\nКоэффициент мощности двигателя (КМ): {this.km}" +
                $"\nКоэффициент сезонности (КС): {this.ks}" +
                $"\nРезультат: {this.rslt}";
                Saver saver = new Saver(this.tosave);
            }
            else MessageBox.Show("Пожалуйста, сперва введите или выберите числовые значения коэффициентов и нажмите кнопку \"Расчет\"!", "Неверный ввод", MessageBoxButtons.OK);
        }
    }
}