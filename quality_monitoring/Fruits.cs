using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecommendedFertilizers
{
    public partial class Fruits : Form
    {
        public Fruits()
        {
            InitializeComponent();
        }

        private void buttonpear_Click(object sender, EventArgs e)
        {
            ShowRecommendedFertilizers("Груша");
        }

        private void buttonapple_Click(object sender, EventArgs e)
        {
            ShowRecommendedFertilizers("Яблоко");
        }

        private void buttonplum_Click(object sender, EventArgs e)
        {
            ShowRecommendedFertilizers("Слива");
        }

        private void buttonapricot_Click(object sender, EventArgs e)
        {
            ShowRecommendedFertilizers("Абрикос");
        }
        public void ShowRecommendedFertilizers(string culture)
        {
            string fertilizers = GetRecommendedFertilizersCulture(culture);
            MessageBox.Show(fertilizers);
        }
        private string GetRecommendedFertilizersCulture(string culture)
        {
            string fertilizers = "";
            switch (culture)
            {
                case "Груша":
                    fertilizers = "Для выращивания груш подходят такие удобрения как:\r\nКалийная селитра: содержит калий и азот, который способствует росту и развитию растений, улучшает устойчивость к стрессу и болезням.\r\nКалий хлористый:  содержит калий и хлор, обеспечивает растения калием, необходимым для роста и развития, а также улучшает устойчивость к стрессовым условиям.\r\nСульфат калия: содержит калий и серу, используется для увеличения урожайности и качества плодов.";
                    break;
                case "Яблоко":
                    fertilizers = "Для выращивания яблок подходят такие удобрения как:\r\nКалийная селитра: содержит калий и азот, который способствует росту и развитию растений, улучшает устойчивость к стрессу и болезням.\r\nКалий хлористый:  содержит калий и хлор, обеспечивает растения калием, необходимым для роста и развития, а также улучшает устойчивость к стрессовым условиям.\r\nСульфат калия: содержит калий и серу, используется для увеличения урожайности и качества плодов.";
                    break;
                case "Слива":
                    fertilizers = "Для выращивания слив подходят такие удобрения как:\r\nКалийная селитра: содержит калий и азот, который способствует росту и развитию растений, улучшает устойчивость к стрессу и болезням.\r\nКалий хлористый:  содержит калий и хлор, обеспечивает растения калием, необходимым для роста и развития, а также улучшает устойчивость к стрессовым условиям.\r\nСульфат калия: содержит калий и серу, используется для увеличения урожайности и качества плодов.";
                    break;
                case "Абрикос":
                    fertilizers = "Для выращивания абрикосов подходят такие удобрения как:\r\nКалийная селитра: содержит калий и азот, который способствует росту и развитию растений, улучшает устойчивость к стрессу и болезням.\r\nКалий хлористый:  содержит калий и хлор, обеспечивает растения калием, необходимым для роста и развития, а также улучшает устойчивость к стрессовым условиям.\r\nСульфат калия: содержит калий и серу, используется для увеличения урожайности и качества плодов.";
                    break;
            }
            return fertilizers;
        }
    }
}
