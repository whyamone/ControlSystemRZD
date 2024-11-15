using System;
using System.Windows.Forms;

namespace ControlSystemRZD
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            this.Text = "Меню";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Загрузка данных из представления "TrainBoardView" с использованием FillBy
            LoadTrainBoardData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Обновление данных в DataGridView из представления с использованием FillBy
            LoadTrainBoardData();
        }

        private void LoadTrainBoardData()
        {
            // Временно отключаем проверку ограничений
            this.controlSystemRZDDataSet.EnforceConstraints = false;

            try
            {
                // Загрузка данных с использованием метода FillBy
                this.trainBoardViewTableAdapter.FillBy(this.controlSystemRZDDataSet.TrainBoardView);
            }
            catch (Exception ex)
            {
                // Обработка исключений, если что-то пойдет не так
                MessageBox.Show("Ошибка при загрузке данных: " + ex.Message);
            }
            
            // Обновляем DataGridView, чтобы отобразить данные
            trainBoardViewDataGridView.Refresh();
        }


        private void trainBoardViewDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Обработчик клика по ячейкам DataGridView, если потребуется
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAddData_Click(object sender, EventArgs e)
        {
            // Создаем экземпляр окна TabControl
            TabControl tabControlForm = new TabControl();

            // Открываем окно TabControl как диалоговое
            tabControlForm.ShowDialog();
        }

        private void btnViewData_Click(object sender, EventArgs e)
        {
            ViewDataForm viewDataForm = new ViewDataForm();
            viewDataForm.ShowDialog();
        }
    }
}
