using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecommendedFertilizers
{
    public partial class Vegetables : Form
    {
        public Vegetables()
        {
            InitializeComponent();
        }

        private void buttonTomato_Click(object sender, EventArgs e)
        {
            ShowRecommendedFertilizers("Помидор");
        }

        private void buttonCucumber_Click(object sender, EventArgs e)
        {
            ShowRecommendedFertilizers("Огурец");
        }

        private void buttonZucchini_Click(object sender, EventArgs e)
        {
            ShowRecommendedFertilizers("Кабачок");
        }

        private void buttonCarrot_Click(object sender, EventArgs e)
        {
            ShowRecommendedFertilizers("Морковь");
        }

        private void buttonCabbage_Click(object sender, EventArgs e)
        {
            ShowRecommendedFertilizers("Капуста");
        }

        private void buttonBeet_Click(object sender, EventArgs e)
        {
            ShowRecommendedFertilizers("Свёкла");
        }

        private void buttonEggplant_Click(object sender, EventArgs e)
        {
            ShowRecommendedFertilizers("Баклажан");
        }

        private void buttonPumpkin_Click(object sender, EventArgs e)
        {
            ShowRecommendedFertilizers("Тыква");
        }

        private void buttonPotato_Click(object sender, EventArgs e)
        {
            ShowRecommendedFertilizers("Картофель");
        }

        public void ShowRecommendedFertilizers(string culture)
        {
            string fertilizers = GetRecommendedFertilizersCulture(culture);
            MessageBox.Show(fertilizers);
        }

        private string GetRecommendedFertilizersCulture(string culture)
        {
            string fertilizers = Properties.Fertilizer.ResourceManager.GetString(culture);
            return fertilizers;
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            this.Hide();
        }
    }
}