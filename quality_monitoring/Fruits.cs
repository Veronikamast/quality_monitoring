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
        private void buttonpeach_Click(object sender, EventArgs e)
        {
            ShowRecommendedFertilizers("Персик");
        }

        private void buttonlemon_Click(object sender, EventArgs e)
        {
            ShowRecommendedFertilizers("Лимон");
        }

        private void buttonlime_Click(object sender, EventArgs e)
        {
            ShowRecommendedFertilizers("Лайм");
        }

        private void buttonmandarin_Click(object sender, EventArgs e)
        {
            ShowRecommendedFertilizers("Мандарин");
        }

        private void buttonpomegranate_Click(object sender, EventArgs e)
        {
            ShowRecommendedFertilizers("Гранат");
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
                case "Персик":
                    fertilizers = "Для выращивания персиков подходят такие удобрения как:\r\n Карбамид: удобрение, содержащее азот в легкодоступной форме, необходимо для роста зеленой массы растений.\r\nСульфат калия: содержит калий и серу, используется для увеличения урожайности и качества плодов.";
                    break;
                case "Лимон":
                    fertilizers = "Для выращивания лимонов подходят такие удобрения как:\r\nДвухосновной фосфат:удобрение богатое фосфором, необходимое для роста растений.\r\nАммиачная селитра: содержит азот, используется для ускорения роста растений, увеличения урожайности и улучшения зеленого цвета листьев.";
                    break;
                case "Лайм":
                    fertilizers = "Для выращивания лаймов подходят такие удобрения как:\r\nКалий хлористый:  содержит калий и хлор, обеспечивает растения калием, необходимым для роста и развития, а также улучшает устойчивость к стрессовым условиям.\r\nСульфат калия: содержит калий и серу, используется для увеличения урожайности и качества плодов.";
                    break;
                case "Мандарин":
                    fertilizers = "Для выращивания мандаринов подходят такие удобрения как:\r\n Карбамид: удобрение, содержащее азот в легкодоступной форме, необходимо для роста зеленой массы растений.\r\nАммофос: содержит азот и фосфор, необходим для роста и развития растений, особенно на начальных этапах и в период цветения.";
                    break;
                case "Гранат":
                    fertilizers = "Для выращивания гранатов подходят такие удобрения как:\r\nКалий хлористый:  содержит калий и хлор, обеспечивает растения калием, необходимым для роста и развития, а также улучшает устойчивость к стрессовым условиям.\r\nФосфокалий: содержит фосфор и калий, улучшает общее развитие растений, устойчивость к болезням и стрессовым условиям.";
                    break;
            }
            return fertilizers;
        }
    }
}
