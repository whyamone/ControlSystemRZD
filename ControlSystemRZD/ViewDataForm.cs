using System;
using System.Linq;
using System.Windows.Forms;

namespace ControlSystemRZD
{
    public partial class ViewDataForm : Form
    {
        public ViewDataForm()
        {
            InitializeComponent();
            this.Text = "Просмотр данных";
            this.Load += new EventHandler(ViewDataForm_Load);
            cmbTables.SelectedIndexChanged += new EventHandler(cmbTables_SelectedIndexChanged);
        }

        private void ViewDataForm_Load(object sender, EventArgs e)
        {
            cmbTables.Items.Clear();
            cmbTables.Items.AddRange(new string[] { "Станции", "Поезда", "Маршруты", "Расписание" });
            cmbTables.SelectedIndex = 0;
        }

        private void cmbTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSelectedTableData();
        }


        private void LoadSelectedTableData()
        {
            string selectedTable = cmbTables.SelectedItem.ToString();
                
            switch (selectedTable)
            {
                case "Станции":
                    this.станцииTableAdapter.Fill(this.controlSystemRZDDataSet.Станции);
                    dataGridView1.DataSource = this.controlSystemRZDDataSet.Станции;
                    break;

                case "Поезда":
                    this.поездаTableAdapter.Fill(this.controlSystemRZDDataSet.Поезда);
                    dataGridView1.DataSource = this.controlSystemRZDDataSet.Поезда;
                    break;

                case "Маршруты":
                    this.маршрутыTableAdapter.Fill(this.controlSystemRZDDataSet.Маршруты);
                    dataGridView1.DataSource = this.controlSystemRZDDataSet.Маршруты;
                    break;

                case "Расписание":
                    this.расписаниеTableAdapter.Fill(this.controlSystemRZDDataSet.Расписание);
                    dataGridView1.DataSource = this.controlSystemRZDDataSet.Расписание;
                    break;
            }

            dataGridView1.Refresh();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Получаем текст, введенный в поле поиска
            string searchText = txtSearch.Text.Trim();

            // Проверяем, что поле поиска не пустое
            if (string.IsNullOrEmpty(searchText))
            {
                MessageBox.Show("Введите текст для поиска.", "Поиск", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Ищем в DataGridView
            bool found = false;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                // Проходим по всем ячейкам строки
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString().ToLower().Contains(searchText.ToLower()))
                    {
                        // Если нашли совпадение, выделяем строку
                        row.Selected = true;
                        dataGridView1.FirstDisplayedScrollingRowIndex = row.Index;
                        found = true;
                        break;
                    }
                    else
                    {
                        row.Selected = false; // Снимаем выделение, если нет совпадений
                    }
                }
                if (found)
                    break;
            }

            // Сообщение, если совпадений не найдено
            if (!found)
            {
                MessageBox.Show("Совпадений не найдено.", "Поиск", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}