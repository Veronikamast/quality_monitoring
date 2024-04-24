using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace quality_monitoring
{
    public partial class home_page : Form
    {
        private MySqlConnection sqlConnection;
        private MySqlDataAdapter adapterFertilizer;
        private MySqlDataAdapter adapterCulture;
        private MySqlDataAdapter adapterRecommendation;

        public home_page()
        {
            InitializeComponent();

            // Подключение к базе данных
            string connectionString = "server=localhost;user=root;database=Fertilizer_system;port=3306;password= ";
            sqlConnection = new MySqlConnection(connectionString);
            sqlConnection.Open();

            // Заполнение выпадающего списка с видами растений
            MySqlDataAdapter adapterType = new MySqlDataAdapter("SELECT Name_of_type FROM Plant_type", sqlConnection);
            DataTable tableType = new DataTable();
            adapterType.Fill(tableType);
            comboBoxType.DataSource = tableType;
            comboBoxType.DisplayMember = "Name_of_type";

            // Инициализация адаптеров для каждой таблицы
            adapterFertilizer = new MySqlDataAdapter("SELECT Fertilizer_name FROM Fertilizer", sqlConnection);
            adapterCulture = new MySqlDataAdapter("SELECT Name_of_culture FROM Plant_culture WHERE id_type = @id_type", sqlConnection);
            adapterRecommendation = new MySqlDataAdapter("SELECT Fertilizer_name FROM Fertilizer f INNER JOIN Recommendation r ON f.id_fertilizer = r.id_fertilizer WHERE r.id_culture = @id_culture", sqlConnection);
        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView selectedTypeRow = (DataRowView)comboBoxType.SelectedItem;
            int typeId = (int)selectedTypeRow.Row["id_type"];

            // Заполнение выпадающего списка с культурами, основанными на выбранном виде
            adapterCulture.SelectCommand.Parameters.Clear();
            adapterCulture.SelectCommand.Parameters.AddWithValue("@id_type", typeId);

            DataTable tableCulture = new DataTable();
            adapterCulture.Fill(tableCulture);

            comboBoxCulture.DataSource = tableCulture;
            comboBoxCulture.DisplayMember = "Name_of_culture";
        }

        private void button_fertilizer_selection_Click(object sender, EventArgs e)
        {
            DataRowView selectedCultureRow = (DataRowView)comboBoxCulture.SelectedItem;
            int cultureId = (int)selectedCultureRow.Row["id_culture"];

            // Получение рекомендованных удобрений для выбранной культуры
            adapterRecommendation.SelectCommand.Parameters.Clear();
            adapterRecommendation.SelectCommand.Parameters.AddWithValue("@id_culture", cultureId);

            DataTable tableRecommendation = new DataTable();
            adapterRecommendation.Fill(tableRecommendation);

            string recommendedFertilizers = "";
            foreach (DataRow row in tableRecommendation.Rows)
            {
                recommendedFertilizers += row["Fertilizer_name"].ToString() + Environment.NewLine;
            }

            MessageBox.Show($"Рекомендуемые удобрения для выбранной культуры:\n{recommendedFertilizers}");
        }
    }
}