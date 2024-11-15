using System;
using System.Data;
using System.Windows.Forms;

namespace ControlSystemRZD
{
    public partial class TabControl : Form
    {
        public TabControl()
        {
            InitializeComponent();
        }

        // Обработчики событий для DataGridView (оставлены пустыми, если не требуются)
        private void станцииDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void поездаDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void маршрутыDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void расписаниеDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        // Добавление новой записи в таблицу Станции
        private void Добавить_Click(object sender, EventArgs e)
        {
            try
            {
                // Код для добавления новой записи в таблицу Станции
                DataRow newRow = controlSystemRZDDataSet.Станции.NewRow();
                newRow["НазваниеСтанции"] = названиеСтанцииTextBox.Text;
                newRow["Местоположение"] = местоположениеTextBox.Text;
                controlSystemRZDDataSet.Станции.Rows.Add(newRow);
                this.станцииBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.controlSystemRZDDataSet);

                // После успешного добавления новой записи, обновляем ComboBox
                this.станцииTableAdapter.Fill(this.controlSystemRZDDataSet.Станции);

                // Обновляем ComboBox для Станция Начала ID
                станцияНачалаComboBox.DataSource = null;
                станцияНачалаComboBox.DataSource = controlSystemRZDDataSet.Станции;
                станцияНачалаComboBox.DisplayMember = "НазваниеСтанции";
                станцияНачалаComboBox.ValueMember = "СтанцияID";

                // Обновляем ComboBox для Станция Конца ID
                станцияКонцаComboBox.DataSource = null;
                станцияКонцаComboBox.DataSource = controlSystemRZDDataSet.Станции;
                станцияКонцаComboBox.DisplayMember = "НазваниеСтанции";
                станцияКонцаComboBox.ValueMember = "СтанцияID";

                MessageBox.Show("Запись добавлена и данные обновлены.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при добавлении станции: " + ex.Message);
            }
        }

        // Удаление выбранной записи из таблицы Станции
        private void Удалить_Click(object sender, EventArgs e)
        {
            if (станцииDataGridView.CurrentRow != null)
            {
                станцииDataGridView.Rows.Remove(станцииDataGridView.CurrentRow);
                this.станцииBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.controlSystemRZDDataSet);
            }
        }

        // Добавление новой записи в таблицу Поезда
        private void Добавить1_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow newRow = controlSystemRZDDataSet.Поезда.NewRow();
                newRow["НомерПоезда"] = номерПоездаTextBox.Text;
                newRow["ТипПоезда"] = типПоездаTextBox.Text;
                controlSystemRZDDataSet.Поезда.Rows.Add(newRow);
                this.поездаBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.controlSystemRZDDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при добавлении поезда: " + ex.Message);
            }
        }

        // Удаление выбранной записи из таблицы Поезда
        private void Удалить1_Click(object sender, EventArgs e)
        {
            if (поездаDataGridView.CurrentRow != null)
            {
                поездаDataGridView.Rows.Remove(поездаDataGridView.CurrentRow);
                this.поездаBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.controlSystemRZDDataSet);
            }
        }

        // Добавление новой записи в таблицу Маршруты
        private void Добавить2_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow newRow = controlSystemRZDDataSet.Маршруты.NewRow();
                newRow["СтанцияНачалаID"] = станцияНачалаComboBox.SelectedValue;
                newRow["СтанцияКонцаID"] = станцияКонцаComboBox.SelectedValue;
                newRow["Длительность"] = длительностьTextBox.Text;
                controlSystemRZDDataSet.Маршруты.Rows.Add(newRow);
                this.маршрутыBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.controlSystemRZDDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при добавлении маршрута: " + ex.Message);
            }
        }

        // Удаление выбранной записи из таблицы Маршруты
        private void Удалить2_Click(object sender, EventArgs e)
        {
            if (маршрутыDataGridView.CurrentRow != null)
            {
                маршрутыDataGridView.Rows.Remove(маршрутыDataGridView.CurrentRow);
                this.маршрутыBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.controlSystemRZDDataSet);
            }
        }

        // Добавление новой записи в таблицу Расписание
        private void Добавить3_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow newRow = controlSystemRZDDataSet.Расписание.NewRow();
                newRow["ПоездID"] = поездIDComboBox.SelectedValue;
                newRow["МаршрутID"] = маршрутIDComboBox.SelectedValue;
                newRow["ВремяОтправления"] = времяОтправленияDateTimePicker.Value.TimeOfDay;
                newRow["ВремяПрибытия"] = времяПрибытияDateTimePicker.Value.TimeOfDay;
                newRow["Путь"] = путьTextBox.Text;
                newRow["Опоздание"] = опозданиеTextBox.Text; // если требуется
                controlSystemRZDDataSet.Расписание.Rows.Add(newRow);
                this.расписаниеBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.controlSystemRZDDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при добавлении расписания: " + ex.Message);
            }
        }

        // Удаление выбранной записи из таблицы Расписание
        private void Удалить3_Click(object sender, EventArgs e)
        {
            if (расписаниеDataGridView.CurrentRow != null)
            {
                расписаниеDataGridView.Rows.Remove(расписаниеDataGridView.CurrentRow);
                this.расписаниеBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.controlSystemRZDDataSet);
            }
        }

        // Отмена и закрытие формы без сохранения
        private void Отмена_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Вы действительно хотите прервать процесс и выйти без сохранения?",
                                 "Подтверждение",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        // Сохранение всех данных и закрытие формы
        private void Завершить_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.станцииBindingSource.EndEdit();
            this.поездаBindingSource.EndEdit();
            this.маршрутыBindingSource.EndEdit();
            this.расписаниеBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.controlSystemRZDDataSet);
            this.Close();
        }

        private void TabControl_Load(object sender, EventArgs e)
        {
            // Загрузка данных в таблицу
            this.поездаTableAdapter.Fill(this.controlSystemRZDDataSet.Поезда);
            this.маршрутыTableAdapter.Fill(this.controlSystemRZDDataSet.Маршруты);
            this.станцииTableAdapter.Fill(this.controlSystemRZDDataSet.Станции);
            this.расписаниеTableAdapter.Fill(this.controlSystemRZDDataSet.Расписание);

            // Создаем отдельные копии данных для каждого ComboBox, чтобы они могли работать независимо
            var станцииDataНачало = controlSystemRZDDataSet.Станции.Copy();
            var станцииDataКонец = controlSystemRZDDataSet.Станции.Copy();

            // Заполнение ComboBox для ПоездID
            поездIDComboBox.DataSource = controlSystemRZDDataSet.Поезда;
            поездIDComboBox.DisplayMember = "НомерПоезда";
            поездIDComboBox.ValueMember = "ПоездID";

            // Заполнение ComboBox для МаршрутID
            маршрутIDComboBox.DataSource = controlSystemRZDDataSet.Маршруты;
            маршрутIDComboBox.DisplayMember = "МаршрутID";
            маршрутIDComboBox.ValueMember = "МаршрутID";

            // Заполнение ComboBox для Станция Начала ID
            станцияНачалаComboBox.DataSource = станцииDataНачало;
            станцияНачалаComboBox.DisplayMember = "НазваниеСтанции"; // Поле для отображения (имя станции)
            станцияНачалаComboBox.ValueMember = "СтанцияID"; // Поле, значение которого будет использоваться

            // Заполнение ComboBox для Станция Конца ID
            станцияКонцаComboBox.DataSource = станцииDataКонец;
            станцияКонцаComboBox.DisplayMember = "НазваниеСтанции"; // Поле для отображения (имя станции)
            станцияКонцаComboBox.ValueMember = "СтанцияID"; // Поле, значение которого будет использоваться


        }
    }
}
