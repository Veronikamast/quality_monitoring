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
    public partial class Berries : Form
    {
        public Berries()
        {
            InitializeComponent();
        }

        private void buttonstrawberry_Click(object sender, EventArgs e)
        {
            ShowRecommendedFertilizers("Клубника");
        }

        private void buttongooseberry_Click(object sender, EventArgs e)
        {
            ShowRecommendedFertilizers("Крыжовник");
        }

        private void buttonraspberry_Click(object sender, EventArgs e)
        {
            ShowRecommendedFertilizers("Малина");
        }

        private void buttonblackberry_Click(object sender, EventArgs e)
        {
            ShowRecommendedFertilizers("Ежевика");
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
                case "Клубника":
                    fertilizers = "Для выращивания клубники подходят такие удобрения как:\r\nКалийная селитра: содержит калий и азот, который способствует росту и развитию растений, улучшает устойчивость к стрессу и болезням.\r\nФосфокалий: содержит фосфор и калий, улучшает общее развитие растений, устойчивость к болезням и стрессовым условиям.\r\nАммофос: содержит азот и фосфор, необходим для роста и развития растений, особенно на начальных этапах и в период цветения.\r\nАзофоска: содержит азот, фосфор и серу, используется для улучшения плодоношения, увеличения урожайности и качества продукции.";
                    break;
                case "Крыжовник":
                    fertilizers = "Для выращивания крыжовника подходят такие удобрения как:\r\nКалийная селитра: содержит калий и азот, который способствует росту и развитию растений, улучшает устойчивость к стрессу и болезням.\r\nФосфокалий: содержит фосфор и калий, улучшает общее развитие растений, устойчивость к болезням и стрессовым условиям.\r\nАммофос: содержит азот и фосфор, необходим для роста и развития растений, особенно на начальных этапах и в период цветения.\r\nАзофоска: содержит азот, фосфор и серу, используется для улучшения плодоношения, увеличения урожайности и качества продукции.";
                    break;
                case "Малина":
                    fertilizers = "Для выращивания малины подходят такие удобрения как:\r\nКалийная селитра: содержит калий и азот, который способствует росту и развитию растений, улучшает устойчивость к стрессу и болезням.\r\nФосфокалий: содержит фосфор и калий, улучшает общее развитие растений, устойчивость к болезням и стрессовым условиям.\r\nАммофос: содержит азот и фосфор, необходим для роста и развития растений, особенно на начальных этапах и в период цветения.\r\nАзофоска: содержит азот, фосфор и серу, используется для улучшения плодоношения, увеличения урожайности и качества продукции.";
                    break;
                case "Ежевика":
                    fertilizers = "Для выращивания ежевики подходят такие удобрения как:\r\nКалийная селитра: содержит калий и азот, который способствует росту и развитию растений, улучшает устойчивость к стрессу и болезням.\r\nФосфокалий: содержит фосфор и калий, улучшает общее развитие растений, устойчивость к болезням и стрессовым условиям.\r\nАммофос: содержит азот и фосфор, необходим для роста и развития растений, особенно на начальных этапах и в период цветения.\r\nАзофоска: содержит азот, фосфор и серу, используется для улучшения плодоношения, увеличения урожайности и качества продукции.";
                    break;
            }
            return fertilizers;
        }
    }
}
