namespace ControlSystemRZD
{
    partial class TabControl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label названиеСтанцииLabel;
            System.Windows.Forms.Label местоположениеLabel;
            System.Windows.Forms.Label номерПоездаLabel;
            System.Windows.Forms.Label типПоездаLabel;
            System.Windows.Forms.Label станцияНачалаIDLabel;
            System.Windows.Forms.Label станцияКонцаIDLabel;
            System.Windows.Forms.Label длительностьLabel;
            System.Windows.Forms.Label времяОтправленияLabel;
            System.Windows.Forms.Label времяПрибытияLabel;
            System.Windows.Forms.Label путьLabel;
            System.Windows.Forms.Label опозданиеLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Станции = new System.Windows.Forms.TabPage();
            this.Удалить = new System.Windows.Forms.Button();
            this.Добавить = new System.Windows.Forms.Button();
            this.названиеСтанцииTextBox = new System.Windows.Forms.TextBox();
            this.станцииBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.controlSystemRZDDataSet = new ControlSystemRZD.ControlSystemRZDDataSet();
            this.местоположениеTextBox = new System.Windows.Forms.TextBox();
            this.станцииDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Поезда = new System.Windows.Forms.TabPage();
            this.Удалить1 = new System.Windows.Forms.Button();
            this.Добавить1 = new System.Windows.Forms.Button();
            this.номерПоездаTextBox = new System.Windows.Forms.TextBox();
            this.поездаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.типПоездаTextBox = new System.Windows.Forms.TextBox();
            this.поездаDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Маршруты = new System.Windows.Forms.TabPage();
            this.станцияКонцаComboBox = new System.Windows.Forms.ComboBox();
            this.станцияНачалаComboBox = new System.Windows.Forms.ComboBox();
            this.Добавить2 = new System.Windows.Forms.Button();
            this.Удалить2 = new System.Windows.Forms.Button();
            this.длительностьTextBox = new System.Windows.Forms.TextBox();
            this.маршрутыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.маршрутыDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Расписание = new System.Windows.Forms.TabPage();
            this.маршрутIDComboBox = new System.Windows.Forms.ComboBox();
            this.поездIDComboBox = new System.Windows.Forms.ComboBox();
            this.времяПрибытияDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.времяОтправленияDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Добавить3 = new System.Windows.Forms.Button();
            this.Удалить3 = new System.Windows.Forms.Button();
            this.путьTextBox = new System.Windows.Forms.TextBox();
            this.расписаниеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.опозданиеTextBox = new System.Windows.Forms.TextBox();
            this.расписаниеDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.станцииTableAdapter = new ControlSystemRZD.ControlSystemRZDDataSetTableAdapters.СтанцииTableAdapter();
            this.tableAdapterManager = new ControlSystemRZD.ControlSystemRZDDataSetTableAdapters.TableAdapterManager();
            this.маршрутыTableAdapter = new ControlSystemRZD.ControlSystemRZDDataSetTableAdapters.МаршрутыTableAdapter();
            this.поездаTableAdapter = new ControlSystemRZD.ControlSystemRZDDataSetTableAdapters.ПоездаTableAdapter();
            this.расписаниеTableAdapter = new ControlSystemRZD.ControlSystemRZDDataSetTableAdapters.РасписаниеTableAdapter();
            this.Завершить = new System.Windows.Forms.Button();
            this.Отмена = new System.Windows.Forms.Button();
            названиеСтанцииLabel = new System.Windows.Forms.Label();
            местоположениеLabel = new System.Windows.Forms.Label();
            номерПоездаLabel = new System.Windows.Forms.Label();
            типПоездаLabel = new System.Windows.Forms.Label();
            станцияНачалаIDLabel = new System.Windows.Forms.Label();
            станцияКонцаIDLabel = new System.Windows.Forms.Label();
            длительностьLabel = new System.Windows.Forms.Label();
            времяОтправленияLabel = new System.Windows.Forms.Label();
            времяПрибытияLabel = new System.Windows.Forms.Label();
            путьLabel = new System.Windows.Forms.Label();
            опозданиеLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.Станции.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.станцииBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlSystemRZDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.станцииDataGridView)).BeginInit();
            this.Поезда.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.поездаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.поездаDataGridView)).BeginInit();
            this.Маршруты.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.маршрутыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.маршрутыDataGridView)).BeginInit();
            this.Расписание.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.расписаниеBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.расписаниеDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // названиеСтанцииLabel
            // 
            названиеСтанцииLabel.AutoSize = true;
            названиеСтанцииLabel.Location = new System.Drawing.Point(1013, 74);
            названиеСтанцииLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            названиеСтанцииLabel.Name = "названиеСтанцииLabel";
            названиеСтанцииLabel.Size = new System.Drawing.Size(135, 16);
            названиеСтанцииLabel.TabIndex = 3;
            названиеСтанцииLabel.Text = "Название Станции:";
            // 
            // местоположениеLabel
            // 
            местоположениеLabel.AutoSize = true;
            местоположениеLabel.Location = new System.Drawing.Point(1013, 106);
            местоположениеLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            местоположениеLabel.Name = "местоположениеLabel";
            местоположениеLabel.Size = new System.Drawing.Size(124, 16);
            местоположениеLabel.TabIndex = 5;
            местоположениеLabel.Text = "Местоположение:";
            // 
            // номерПоездаLabel
            // 
            номерПоездаLabel.AutoSize = true;
            номерПоездаLabel.Location = new System.Drawing.Point(1039, 103);
            номерПоездаLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            номерПоездаLabel.Name = "номерПоездаLabel";
            номерПоездаLabel.Size = new System.Drawing.Size(106, 16);
            номерПоездаLabel.TabIndex = 3;
            номерПоездаLabel.Text = "Номер Поезда:";
            // 
            // типПоездаLabel
            // 
            типПоездаLabel.AutoSize = true;
            типПоездаLabel.Location = new System.Drawing.Point(1039, 135);
            типПоездаLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            типПоездаLabel.Name = "типПоездаLabel";
            типПоездаLabel.Size = new System.Drawing.Size(88, 16);
            типПоездаLabel.TabIndex = 5;
            типПоездаLabel.Text = "Тип Поезда:";
            // 
            // станцияНачалаIDLabel
            // 
            станцияНачалаIDLabel.AutoSize = true;
            станцияНачалаIDLabel.Location = new System.Drawing.Point(1020, 74);
            станцияНачалаIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            станцияНачалаIDLabel.Name = "станцияНачалаIDLabel";
            станцияНачалаIDLabel.Size = new System.Drawing.Size(134, 16);
            станцияНачалаIDLabel.TabIndex = 3;
            станцияНачалаIDLabel.Text = "Станция Начала ID:";
            // 
            // станцияКонцаIDLabel
            // 
            станцияКонцаIDLabel.AutoSize = true;
            станцияКонцаIDLabel.Location = new System.Drawing.Point(1020, 106);
            станцияКонцаIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            станцияКонцаIDLabel.Name = "станцияКонцаIDLabel";
            станцияКонцаIDLabel.Size = new System.Drawing.Size(124, 16);
            станцияКонцаIDLabel.TabIndex = 5;
            станцияКонцаIDLabel.Text = "Станция Конца ID:";
            // 
            // длительностьLabel
            // 
            длительностьLabel.AutoSize = true;
            длительностьLabel.Location = new System.Drawing.Point(1020, 138);
            длительностьLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            длительностьLabel.Name = "длительностьLabel";
            длительностьLabel.Size = new System.Drawing.Size(102, 16);
            длительностьLabel.TabIndex = 7;
            длительностьLabel.Text = "Длительность:";
            // 
            // времяОтправленияLabel
            // 
            времяОтправленияLabel.AutoSize = true;
            времяОтправленияLabel.Location = new System.Drawing.Point(1040, 140);
            времяОтправленияLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            времяОтправленияLabel.Name = "времяОтправленияLabel";
            времяОтправленияLabel.Size = new System.Drawing.Size(142, 16);
            времяОтправленияLabel.TabIndex = 7;
            времяОтправленияLabel.Text = "Время Отправления:";
            // 
            // времяПрибытияLabel
            // 
            времяПрибытияLabel.AutoSize = true;
            времяПрибытияLabel.Location = new System.Drawing.Point(1040, 172);
            времяПрибытияLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            времяПрибытияLabel.Name = "времяПрибытияLabel";
            времяПрибытияLabel.Size = new System.Drawing.Size(119, 16);
            времяПрибытияLabel.TabIndex = 9;
            времяПрибытияLabel.Text = "Время Прибытия:";
            // 
            // путьLabel
            // 
            путьLabel.AutoSize = true;
            путьLabel.Location = new System.Drawing.Point(1040, 204);
            путьLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            путьLabel.Name = "путьLabel";
            путьLabel.Size = new System.Drawing.Size(42, 16);
            путьLabel.TabIndex = 11;
            путьLabel.Text = "Путь:";
            // 
            // опозданиеLabel
            // 
            опозданиеLabel.AutoSize = true;
            опозданиеLabel.Location = new System.Drawing.Point(1040, 236);
            опозданиеLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            опозданиеLabel.Name = "опозданиеLabel";
            опозданиеLabel.Size = new System.Drawing.Size(84, 16);
            опозданиеLabel.TabIndex = 13;
            опозданиеLabel.Text = "Опоздание:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(1040, 108);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(82, 16);
            label1.TabIndex = 19;
            label1.Text = "МаршрутID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(1040, 79);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(65, 16);
            label2.TabIndex = 20;
            label2.Text = "ПоездID:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Станции);
            this.tabControl1.Controls.Add(this.Поезда);
            this.tabControl1.Controls.Add(this.Маршруты);
            this.tabControl1.Controls.Add(this.Расписание);
            this.tabControl1.ItemSize = new System.Drawing.Size(100, 30);
            this.tabControl1.Location = new System.Drawing.Point(17, 5);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1431, 544);
            this.tabControl1.TabIndex = 0;
            // 
            // Станции
            // 
            this.Станции.AutoScroll = true;
            this.Станции.Controls.Add(this.Удалить);
            this.Станции.Controls.Add(this.Добавить);
            this.Станции.Controls.Add(названиеСтанцииLabel);
            this.Станции.Controls.Add(this.названиеСтанцииTextBox);
            this.Станции.Controls.Add(местоположениеLabel);
            this.Станции.Controls.Add(this.местоположениеTextBox);
            this.Станции.Controls.Add(this.станцииDataGridView);
            this.Станции.Location = new System.Drawing.Point(4, 34);
            this.Станции.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Станции.Name = "Станции";
            this.Станции.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Станции.Size = new System.Drawing.Size(1423, 506);
            this.Станции.TabIndex = 0;
            this.Станции.Text = "Станции";
            this.Станции.UseVisualStyleBackColor = true;
            // 
            // Удалить
            // 
            this.Удалить.Location = new System.Drawing.Point(1017, 418);
            this.Удалить.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Удалить.Name = "Удалить";
            this.Удалить.Size = new System.Drawing.Size(100, 49);
            this.Удалить.TabIndex = 7;
            this.Удалить.Text = "Удалить";
            this.Удалить.UseVisualStyleBackColor = true;
            this.Удалить.Click += new System.EventHandler(this.Удалить_Click);
            // 
            // Добавить
            // 
            this.Добавить.Location = new System.Drawing.Point(1240, 418);
            this.Добавить.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Добавить.Name = "Добавить";
            this.Добавить.Size = new System.Drawing.Size(100, 49);
            this.Добавить.TabIndex = 1;
            this.Добавить.Text = "Добавить";
            this.Добавить.UseVisualStyleBackColor = true;
            this.Добавить.Click += new System.EventHandler(this.Добавить_Click);
            // 
            // названиеСтанцииTextBox
            // 
            this.названиеСтанцииTextBox.Location = new System.Drawing.Point(1181, 70);
            this.названиеСтанцииTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.названиеСтанцииTextBox.Name = "названиеСтанцииTextBox";
            this.названиеСтанцииTextBox.Size = new System.Drawing.Size(132, 22);
            this.названиеСтанцииTextBox.TabIndex = 4;
            // 
            // станцииBindingSource
            // 
            this.станцииBindingSource.DataMember = "Станции";
            this.станцииBindingSource.DataSource = this.controlSystemRZDDataSet;
            // 
            // controlSystemRZDDataSet
            // 
            this.controlSystemRZDDataSet.DataSetName = "ControlSystemRZDDataSet";
            this.controlSystemRZDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // местоположениеTextBox
            // 
            this.местоположениеTextBox.Location = new System.Drawing.Point(1181, 102);
            this.местоположениеTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.местоположениеTextBox.Name = "местоположениеTextBox";
            this.местоположениеTextBox.Size = new System.Drawing.Size(132, 22);
            this.местоположениеTextBox.TabIndex = 6;
            // 
            // станцииDataGridView
            // 
            this.станцииDataGridView.AutoGenerateColumns = false;
            this.станцииDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.станцииDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.станцииDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.станцииDataGridView.DataSource = this.станцииBindingSource;
            this.станцииDataGridView.Location = new System.Drawing.Point(0, 0);
            this.станцииDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.станцииDataGridView.Name = "станцииDataGridView";
            this.станцииDataGridView.RowHeadersWidth = 51;
            this.станцииDataGridView.Size = new System.Drawing.Size(965, 497);
            this.станцииDataGridView.TabIndex = 0;
            this.станцииDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.станцииDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "СтанцияID";
            this.dataGridViewTextBoxColumn1.HeaderText = "СтанцияID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "НазваниеСтанции";
            this.dataGridViewTextBoxColumn2.HeaderText = "НазваниеСтанции";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Местоположение";
            this.dataGridViewTextBoxColumn3.HeaderText = "Местоположение";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // Поезда
            // 
            this.Поезда.AutoScroll = true;
            this.Поезда.Controls.Add(this.Удалить1);
            this.Поезда.Controls.Add(this.Добавить1);
            this.Поезда.Controls.Add(номерПоездаLabel);
            this.Поезда.Controls.Add(this.номерПоездаTextBox);
            this.Поезда.Controls.Add(типПоездаLabel);
            this.Поезда.Controls.Add(this.типПоездаTextBox);
            this.Поезда.Controls.Add(this.поездаDataGridView);
            this.Поезда.Location = new System.Drawing.Point(4, 34);
            this.Поезда.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Поезда.Name = "Поезда";
            this.Поезда.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Поезда.Size = new System.Drawing.Size(1423, 506);
            this.Поезда.TabIndex = 1;
            this.Поезда.Text = "Поезда";
            this.Поезда.UseVisualStyleBackColor = true;
            // 
            // Удалить1
            // 
            this.Удалить1.Location = new System.Drawing.Point(1043, 418);
            this.Удалить1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Удалить1.Name = "Удалить1";
            this.Удалить1.Size = new System.Drawing.Size(100, 49);
            this.Удалить1.TabIndex = 8;
            this.Удалить1.Text = "Удалить";
            this.Удалить1.UseVisualStyleBackColor = true;
            this.Удалить1.Click += new System.EventHandler(this.Удалить1_Click);
            // 
            // Добавить1
            // 
            this.Добавить1.Location = new System.Drawing.Point(1231, 418);
            this.Добавить1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Добавить1.Name = "Добавить1";
            this.Добавить1.Size = new System.Drawing.Size(100, 49);
            this.Добавить1.TabIndex = 7;
            this.Добавить1.Text = "Добавить";
            this.Добавить1.UseVisualStyleBackColor = true;
            this.Добавить1.Click += new System.EventHandler(this.Добавить1_Click);
            // 
            // номерПоездаTextBox
            // 
            this.номерПоездаTextBox.Location = new System.Drawing.Point(1173, 100);
            this.номерПоездаTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.номерПоездаTextBox.Name = "номерПоездаTextBox";
            this.номерПоездаTextBox.Size = new System.Drawing.Size(132, 22);
            this.номерПоездаTextBox.TabIndex = 4;
            // 
            // поездаBindingSource
            // 
            this.поездаBindingSource.DataMember = "Поезда";
            this.поездаBindingSource.DataSource = this.controlSystemRZDDataSet;
            // 
            // типПоездаTextBox
            // 
            this.типПоездаTextBox.Location = new System.Drawing.Point(1173, 132);
            this.типПоездаTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.типПоездаTextBox.Name = "типПоездаTextBox";
            this.типПоездаTextBox.Size = new System.Drawing.Size(132, 22);
            this.типПоездаTextBox.TabIndex = 6;
            // 
            // поездаDataGridView
            // 
            this.поездаDataGridView.AutoGenerateColumns = false;
            this.поездаDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.поездаDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.поездаDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.поездаDataGridView.DataSource = this.поездаBindingSource;
            this.поездаDataGridView.Location = new System.Drawing.Point(0, 0);
            this.поездаDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.поездаDataGridView.Name = "поездаDataGridView";
            this.поездаDataGridView.RowHeadersWidth = 51;
            this.поездаDataGridView.Size = new System.Drawing.Size(965, 497);
            this.поездаDataGridView.TabIndex = 0;
            this.поездаDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.поездаDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ПоездID";
            this.dataGridViewTextBoxColumn4.HeaderText = "ПоездID";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "НомерПоезда";
            this.dataGridViewTextBoxColumn5.HeaderText = "НомерПоезда";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ТипПоезда";
            this.dataGridViewTextBoxColumn6.HeaderText = "ТипПоезда";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // Маршруты
            // 
            this.Маршруты.AutoScroll = true;
            this.Маршруты.Controls.Add(this.станцияКонцаComboBox);
            this.Маршруты.Controls.Add(this.станцияНачалаComboBox);
            this.Маршруты.Controls.Add(this.Добавить2);
            this.Маршруты.Controls.Add(this.Удалить2);
            this.Маршруты.Controls.Add(станцияНачалаIDLabel);
            this.Маршруты.Controls.Add(станцияКонцаIDLabel);
            this.Маршруты.Controls.Add(длительностьLabel);
            this.Маршруты.Controls.Add(this.длительностьTextBox);
            this.Маршруты.Controls.Add(this.маршрутыDataGridView);
            this.Маршруты.Location = new System.Drawing.Point(4, 34);
            this.Маршруты.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Маршруты.Name = "Маршруты";
            this.Маршруты.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Маршруты.Size = new System.Drawing.Size(1423, 506);
            this.Маршруты.TabIndex = 2;
            this.Маршруты.Text = "Маршруты";
            this.Маршруты.UseVisualStyleBackColor = true;
            // 
            // станцияКонцаComboBox
            // 
            this.станцияКонцаComboBox.FormattingEnabled = true;
            this.станцияКонцаComboBox.Location = new System.Drawing.Point(1191, 106);
            this.станцияКонцаComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.станцияКонцаComboBox.Name = "станцияКонцаComboBox";
            this.станцияКонцаComboBox.Size = new System.Drawing.Size(160, 24);
            this.станцияКонцаComboBox.TabIndex = 12;
            // 
            // станцияНачалаComboBox
            // 
            this.станцияНачалаComboBox.FormattingEnabled = true;
            this.станцияНачалаComboBox.Location = new System.Drawing.Point(1191, 74);
            this.станцияНачалаComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.станцияНачалаComboBox.Name = "станцияНачалаComboBox";
            this.станцияНачалаComboBox.Size = new System.Drawing.Size(160, 24);
            this.станцияНачалаComboBox.TabIndex = 11;
            // 
            // Добавить2
            // 
            this.Добавить2.Location = new System.Drawing.Point(1255, 409);
            this.Добавить2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Добавить2.Name = "Добавить2";
            this.Добавить2.Size = new System.Drawing.Size(100, 49);
            this.Добавить2.TabIndex = 10;
            this.Добавить2.Text = "Добавить";
            this.Добавить2.UseVisualStyleBackColor = true;
            this.Добавить2.Click += new System.EventHandler(this.Добавить2_Click);
            // 
            // Удалить2
            // 
            this.Удалить2.Location = new System.Drawing.Point(1024, 409);
            this.Удалить2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Удалить2.Name = "Удалить2";
            this.Удалить2.Size = new System.Drawing.Size(100, 49);
            this.Удалить2.TabIndex = 9;
            this.Удалить2.Text = "Удалить";
            this.Удалить2.UseVisualStyleBackColor = true;
            this.Удалить2.Click += new System.EventHandler(this.Удалить2_Click);
            // 
            // длительностьTextBox
            // 
            this.длительностьTextBox.Location = new System.Drawing.Point(1189, 134);
            this.длительностьTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.длительностьTextBox.Name = "длительностьTextBox";
            this.длительностьTextBox.Size = new System.Drawing.Size(164, 22);
            this.длительностьTextBox.TabIndex = 8;
            // 
            // маршрутыBindingSource
            // 
            this.маршрутыBindingSource.DataMember = "Маршруты";
            this.маршрутыBindingSource.DataSource = this.controlSystemRZDDataSet;
            // 
            // маршрутыDataGridView
            // 
            this.маршрутыDataGridView.AutoGenerateColumns = false;
            this.маршрутыDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.маршрутыDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.маршрутыDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.маршрутыDataGridView.DataSource = this.маршрутыBindingSource;
            this.маршрутыDataGridView.Location = new System.Drawing.Point(0, 0);
            this.маршрутыDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.маршрутыDataGridView.Name = "маршрутыDataGridView";
            this.маршрутыDataGridView.RowHeadersWidth = 51;
            this.маршрутыDataGridView.Size = new System.Drawing.Size(965, 497);
            this.маршрутыDataGridView.TabIndex = 0;
            this.маршрутыDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.маршрутыDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "МаршрутID";
            this.dataGridViewTextBoxColumn7.HeaderText = "МаршрутID";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "СтанцияНачалаID";
            this.dataGridViewTextBoxColumn8.HeaderText = "СтанцияНачалаID";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "СтанцияКонцаID";
            this.dataGridViewTextBoxColumn9.HeaderText = "СтанцияКонцаID";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Длительность";
            this.dataGridViewTextBoxColumn10.HeaderText = "Длительность";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // Расписание
            // 
            this.Расписание.AutoScroll = true;
            this.Расписание.Controls.Add(this.маршрутIDComboBox);
            this.Расписание.Controls.Add(this.поездIDComboBox);
            this.Расписание.Controls.Add(label2);
            this.Расписание.Controls.Add(label1);
            this.Расписание.Controls.Add(this.времяПрибытияDateTimePicker);
            this.Расписание.Controls.Add(this.времяОтправленияDateTimePicker);
            this.Расписание.Controls.Add(this.Добавить3);
            this.Расписание.Controls.Add(this.Удалить3);
            this.Расписание.Controls.Add(времяОтправленияLabel);
            this.Расписание.Controls.Add(времяПрибытияLabel);
            this.Расписание.Controls.Add(путьLabel);
            this.Расписание.Controls.Add(this.путьTextBox);
            this.Расписание.Controls.Add(опозданиеLabel);
            this.Расписание.Controls.Add(this.опозданиеTextBox);
            this.Расписание.Controls.Add(this.расписаниеDataGridView);
            this.Расписание.Location = new System.Drawing.Point(4, 34);
            this.Расписание.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Расписание.Name = "Расписание";
            this.Расписание.Size = new System.Drawing.Size(1423, 506);
            this.Расписание.TabIndex = 3;
            this.Расписание.Text = "Расписание";
            this.Расписание.UseVisualStyleBackColor = true;
            // 
            // маршрутIDComboBox
            // 
            this.маршрутIDComboBox.FormattingEnabled = true;
            this.маршрутIDComboBox.Location = new System.Drawing.Point(1221, 108);
            this.маршрутIDComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.маршрутIDComboBox.Name = "маршрутIDComboBox";
            this.маршрутIDComboBox.Size = new System.Drawing.Size(165, 24);
            this.маршрутIDComboBox.TabIndex = 24;
            // 
            // поездIDComboBox
            // 
            this.поездIDComboBox.FormattingEnabled = true;
            this.поездIDComboBox.Location = new System.Drawing.Point(1221, 79);
            this.поездIDComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.поездIDComboBox.Name = "поездIDComboBox";
            this.поездIDComboBox.Size = new System.Drawing.Size(165, 24);
            this.поездIDComboBox.TabIndex = 23;
            // 
            // времяПрибытияDateTimePicker
            // 
            this.времяПрибытияDateTimePicker.Location = new System.Drawing.Point(1221, 172);
            this.времяПрибытияDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.времяПрибытияDateTimePicker.Name = "времяПрибытияDateTimePicker";
            this.времяПрибытияDateTimePicker.Size = new System.Drawing.Size(165, 22);
            this.времяПрибытияDateTimePicker.TabIndex = 18;
            // 
            // времяОтправленияDateTimePicker
            // 
            this.времяОтправленияDateTimePicker.Location = new System.Drawing.Point(1221, 140);
            this.времяОтправленияDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.времяОтправленияDateTimePicker.Name = "времяОтправленияDateTimePicker";
            this.времяОтправленияDateTimePicker.Size = new System.Drawing.Size(165, 22);
            this.времяОтправленияDateTimePicker.TabIndex = 17;
            // 
            // Добавить3
            // 
            this.Добавить3.Location = new System.Drawing.Point(1273, 402);
            this.Добавить3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Добавить3.Name = "Добавить3";
            this.Добавить3.Size = new System.Drawing.Size(100, 49);
            this.Добавить3.TabIndex = 16;
            this.Добавить3.Text = "Добавить";
            this.Добавить3.UseVisualStyleBackColor = true;
            this.Добавить3.Click += new System.EventHandler(this.Добавить3_Click);
            // 
            // Удалить3
            // 
            this.Удалить3.Location = new System.Drawing.Point(1040, 402);
            this.Удалить3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Удалить3.Name = "Удалить3";
            this.Удалить3.Size = new System.Drawing.Size(100, 49);
            this.Удалить3.TabIndex = 15;
            this.Удалить3.Text = "Удалить";
            this.Удалить3.UseVisualStyleBackColor = true;
            this.Удалить3.Click += new System.EventHandler(this.Удалить3_Click);
            // 
            // путьTextBox
            // 
            this.путьTextBox.Location = new System.Drawing.Point(1221, 201);
            this.путьTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.путьTextBox.Name = "путьTextBox";
            this.путьTextBox.Size = new System.Drawing.Size(165, 22);
            this.путьTextBox.TabIndex = 12;
            // 
            // расписаниеBindingSource
            // 
            this.расписаниеBindingSource.DataMember = "Расписание";
            this.расписаниеBindingSource.DataSource = this.controlSystemRZDDataSet;
            // 
            // опозданиеTextBox
            // 
            this.опозданиеTextBox.Location = new System.Drawing.Point(1221, 233);
            this.опозданиеTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.опозданиеTextBox.Name = "опозданиеTextBox";
            this.опозданиеTextBox.Size = new System.Drawing.Size(165, 22);
            this.опозданиеTextBox.TabIndex = 14;
            // 
            // расписаниеDataGridView
            // 
            this.расписаниеDataGridView.AutoGenerateColumns = false;
            this.расписаниеDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.расписаниеDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.расписаниеDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17});
            this.расписаниеDataGridView.DataSource = this.расписаниеBindingSource;
            this.расписаниеDataGridView.Location = new System.Drawing.Point(0, 0);
            this.расписаниеDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.расписаниеDataGridView.Name = "расписаниеDataGridView";
            this.расписаниеDataGridView.RowHeadersWidth = 51;
            this.расписаниеDataGridView.Size = new System.Drawing.Size(965, 497);
            this.расписаниеDataGridView.TabIndex = 0;
            this.расписаниеDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.расписаниеDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "РасписаниеID";
            this.dataGridViewTextBoxColumn11.HeaderText = "РасписаниеID";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "ПоездID";
            this.dataGridViewTextBoxColumn12.HeaderText = "ПоездID";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "МаршрутID";
            this.dataGridViewTextBoxColumn13.HeaderText = "МаршрутID";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "ВремяОтправления";
            this.dataGridViewTextBoxColumn14.HeaderText = "ВремяОтправления";
            this.dataGridViewTextBoxColumn14.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "ВремяПрибытия";
            this.dataGridViewTextBoxColumn15.HeaderText = "ВремяПрибытия";
            this.dataGridViewTextBoxColumn15.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "Путь";
            this.dataGridViewTextBoxColumn16.HeaderText = "Путь";
            this.dataGridViewTextBoxColumn16.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "Опоздание";
            this.dataGridViewTextBoxColumn17.HeaderText = "Опоздание";
            this.dataGridViewTextBoxColumn17.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            // 
            // станцииTableAdapter
            // 
            this.станцииTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = ControlSystemRZD.ControlSystemRZDDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.МаршрутыTableAdapter = this.маршрутыTableAdapter;
            this.tableAdapterManager.ПоездаTableAdapter = this.поездаTableAdapter;
            this.tableAdapterManager.РасписаниеTableAdapter = this.расписаниеTableAdapter;
            this.tableAdapterManager.СтанцииTableAdapter = this.станцииTableAdapter;
            // 
            // маршрутыTableAdapter
            // 
            this.маршрутыTableAdapter.ClearBeforeFill = true;
            // 
            // поездаTableAdapter
            // 
            this.поездаTableAdapter.ClearBeforeFill = true;
            // 
            // расписаниеTableAdapter
            // 
            this.расписаниеTableAdapter.ClearBeforeFill = true;
            // 
            // Завершить
            // 
            this.Завершить.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Завершить.Location = new System.Drawing.Point(1204, 608);
            this.Завершить.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Завершить.Name = "Завершить";
            this.Завершить.Size = new System.Drawing.Size(292, 89);
            this.Завершить.TabIndex = 1;
            this.Завершить.Text = "Завершить";
            this.Завершить.UseVisualStyleBackColor = true;
            this.Завершить.Click += new System.EventHandler(this.Завершить_Click);
            // 
            // Отмена
            // 
            this.Отмена.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Отмена.Location = new System.Drawing.Point(23, 608);
            this.Отмена.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Отмена.Name = "Отмена";
            this.Отмена.Size = new System.Drawing.Size(292, 89);
            this.Отмена.TabIndex = 2;
            this.Отмена.Text = "Отмена";
            this.Отмена.UseVisualStyleBackColor = true;
            this.Отмена.Click += new System.EventHandler(this.Отмена_Click);
            // 
            // TabControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1624, 711);
            this.Controls.Add(this.Отмена);
            this.Controls.Add(this.Завершить);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TabControl";
            this.Text = "TabControl";
            this.Load += new System.EventHandler(this.TabControl_Load);
            this.tabControl1.ResumeLayout(false);
            this.Станции.ResumeLayout(false);
            this.Станции.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.станцииBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlSystemRZDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.станцииDataGridView)).EndInit();
            this.Поезда.ResumeLayout(false);
            this.Поезда.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.поездаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.поездаDataGridView)).EndInit();
            this.Маршруты.ResumeLayout(false);
            this.Маршруты.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.маршрутыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.маршрутыDataGridView)).EndInit();
            this.Расписание.ResumeLayout(false);
            this.Расписание.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.расписаниеBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.расписаниеDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Станции;
        private System.Windows.Forms.TabPage Поезда;
        private System.Windows.Forms.TabPage Маршруты;
        private System.Windows.Forms.TabPage Расписание;
        private ControlSystemRZDDataSet controlSystemRZDDataSet;
        private System.Windows.Forms.BindingSource станцииBindingSource;
        private ControlSystemRZDDataSetTableAdapters.СтанцииTableAdapter станцииTableAdapter;
        private ControlSystemRZDDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox названиеСтанцииTextBox;
        private System.Windows.Forms.TextBox местоположениеTextBox;
        private System.Windows.Forms.DataGridView станцииDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private ControlSystemRZDDataSetTableAdapters.ПоездаTableAdapter поездаTableAdapter;
        private System.Windows.Forms.BindingSource поездаBindingSource;
        private System.Windows.Forms.DataGridView поездаDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private ControlSystemRZDDataSetTableAdapters.МаршрутыTableAdapter маршрутыTableAdapter;
        private System.Windows.Forms.BindingSource маршрутыBindingSource;
        private System.Windows.Forms.DataGridView маршрутыDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private ControlSystemRZDDataSetTableAdapters.РасписаниеTableAdapter расписаниеTableAdapter;
        private System.Windows.Forms.BindingSource расписаниеBindingSource;
        private System.Windows.Forms.DataGridView расписаниеDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.TextBox номерПоездаTextBox;
        private System.Windows.Forms.TextBox типПоездаTextBox;
        private System.Windows.Forms.TextBox длительностьTextBox;
        private System.Windows.Forms.TextBox путьTextBox;
        private System.Windows.Forms.TextBox опозданиеTextBox;
        private System.Windows.Forms.Button Удалить;
        private System.Windows.Forms.Button Добавить;
        private System.Windows.Forms.Button Завершить;
        private System.Windows.Forms.Button Отмена;
        private System.Windows.Forms.Button Добавить1;
        private System.Windows.Forms.Button Удалить1;
        private System.Windows.Forms.Button Добавить2;
        private System.Windows.Forms.Button Удалить2;
        private System.Windows.Forms.Button Добавить3;
        private System.Windows.Forms.Button Удалить3;
        private System.Windows.Forms.DateTimePicker времяПрибытияDateTimePicker;
        private System.Windows.Forms.DateTimePicker времяОтправленияDateTimePicker;
        private System.Windows.Forms.ComboBox маршрутIDComboBox;
        private System.Windows.Forms.ComboBox поездIDComboBox;
        private System.Windows.Forms.ComboBox станцияКонцаComboBox;
        private System.Windows.Forms.ComboBox станцияНачалаComboBox;
    }
}