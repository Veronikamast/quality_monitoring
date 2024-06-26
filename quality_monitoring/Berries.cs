﻿using System;
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
        private void buttonblueberry_Click(object sender, EventArgs e)
        {
            ShowRecommendedFertilizers("Голубика");
        }

        private void buttoncherries_Click(object sender, EventArgs e)
        {
            ShowRecommendedFertilizers("Черешня");
        }

        private void buttoncurrant_Click(object sender, EventArgs e)
        {
            ShowRecommendedFertilizers("Смородина");
        }

        private void buttonrowan_Click(object sender, EventArgs e)
        {
            ShowRecommendedFertilizers("Рябина");
        }

        private void buttonsea_buckthorn_Click(object sender, EventArgs e)
        {
            ShowRecommendedFertilizers("Облепиха");
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
                case "Голубика":
                    fertilizers = "Для выращивания голубики подходят такие удобрения как:\r\nКалийная селитра: содержит калий и азот, который способствует росту и развитию растений, улучшает устойчивость к стрессу и болезням.\r\nСуперфосфат: содержит фосфор и кальций, способствует хорошему развитию корневой системы, цветению и плодоношению растений.\r\n Карбамид: удобрение, содержащее азот в легкодоступной форме, необходимо для роста зеленой массы растений.";
                    break;
                case "Черешня":
                    fertilizers = "Для выращивания черешни подходят такие удобрения как:\r\nКалий хлористый:  содержит калий и хлор, обеспечивает растения калием, необходимым для роста и развития, а также улучшает устойчивость к стрессовым условиям.\r\nФосфокалий: содержит фосфор и калий, улучшает общее развитие растений, устойчивость к болезням и стрессовым условиям.";
                    break;
                case "Смородина":
                    fertilizers = "Для выращивания смородины подходят такие удобрения как:\r\nАммофос: содержит азот и фосфор, необходим для роста и развития растений, особенно на начальных этапах и в период цветения.\r\nАзофоска: содержит азот, фосфор и серу, используется для улучшения плодоношения, увеличения урожайности и качества продукции.";
                    break;
                case "Рябина":
                    fertilizers = "Для выращивания рябины подходят такие удобрения как:\r\nКалийная селитра: содержит калий и азот, который способствует росту и развитию растений, улучшает устойчивость к стрессу и болезням.\r\nСульфат калия: содержит калий и серу, используется для увеличения урожайности и качества плодов.";
                    break;
                case "Облепиха":
                    fertilizers = "Для выращивания облепихи подходят такие удобрения как:\r\nСульфат калия: содержит калий и серу, используется для увеличения урожайности и качества плодов.\r\nДвухосновной фосфат:удобрение богатое фосфором, необходимое для роста растений.";
                    break;
            }
            return fertilizers;
        }
    }
}
