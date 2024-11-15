namespace ControlSystemRZD
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.controlSystemRZDDataSet = new ControlSystemRZD.ControlSystemRZDDataSet();
            this.trainBoardViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trainBoardViewTableAdapter = new ControlSystemRZD.ControlSystemRZDDataSetTableAdapters.TrainBoardViewTableAdapter();
            this.tableAdapterManager = new ControlSystemRZD.ControlSystemRZDDataSetTableAdapters.TableAdapterManager();
            this.trainBoardViewDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Обновить = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddData = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnViewData = new System.Windows.Forms.Button();
            this.trainBoardViewTableAdapter1 = new ControlSystemRZD.ControlSystemRZDDataSetTableAdapters.TrainBoardViewTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.controlSystemRZDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainBoardViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainBoardViewDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 8;
            // 
            // controlSystemRZDDataSet
            // 
            this.controlSystemRZDDataSet.DataSetName = "ControlSystemRZDDataSet";
            this.controlSystemRZDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // trainBoardViewBindingSource
            // 
            this.trainBoardViewBindingSource.DataMember = "TrainBoardView";
            this.trainBoardViewBindingSource.DataSource = this.controlSystemRZDDataSet;
            // 
            // trainBoardViewTableAdapter
            // 
            this.trainBoardViewTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = ControlSystemRZD.ControlSystemRZDDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.МаршрутыTableAdapter = null;
            this.tableAdapterManager.ПоездаTableAdapter = null;
            this.tableAdapterManager.РасписаниеTableAdapter = null;
            this.tableAdapterManager.СтанцииTableAdapter = null;
            // 
            // trainBoardViewDataGridView
            // 
            this.trainBoardViewDataGridView.AutoGenerateColumns = false;
            this.trainBoardViewDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.trainBoardViewDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.trainBoardViewDataGridView.DataSource = this.trainBoardViewBindingSource;
            this.trainBoardViewDataGridView.Location = new System.Drawing.Point(80, 146);
            this.trainBoardViewDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trainBoardViewDataGridView.Name = "trainBoardViewDataGridView";
            this.trainBoardViewDataGridView.RowHeadersWidth = 51;
            this.trainBoardViewDataGridView.RowTemplate.Height = 24;
            this.trainBoardViewDataGridView.Size = new System.Drawing.Size(928, 244);
            this.trainBoardViewDataGridView.TabIndex = 2;
            this.trainBoardViewDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.trainBoardViewDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Номер поезда";
            this.dataGridViewTextBoxColumn1.HeaderText = "Номер поезда";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Категория";
            this.dataGridViewTextBoxColumn2.HeaderText = "Категория";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Назначение";
            this.dataGridViewTextBoxColumn3.HeaderText = "Назначение";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Прибытие";
            this.dataGridViewTextBoxColumn4.HeaderText = "Прибытие";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Отправление";
            this.dataGridViewTextBoxColumn5.HeaderText = "Отправление";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Путь";
            this.dataGridViewTextBoxColumn6.HeaderText = "Путь";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Опоздание";
            this.dataGridViewTextBoxColumn7.HeaderText = "Опоздание";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // Обновить
            // 
            this.Обновить.Location = new System.Drawing.Point(80, 415);
            this.Обновить.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Обновить.Name = "Обновить";
            this.Обновить.Size = new System.Drawing.Size(101, 26);
            this.Обновить.TabIndex = 7;
            this.Обновить.Text = "Обновить";
            this.Обновить.UseVisualStyleBackColor = true;
            this.Обновить.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(365, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(424, 42);
            this.label2.TabIndex = 9;
            this.label2.Text = "Система Управления";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnAddData
            // 
            this.btnAddData.Location = new System.Drawing.Point(80, 470);
            this.btnAddData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddData.Name = "btnAddData";
            this.btnAddData.Size = new System.Drawing.Size(215, 101);
            this.btnAddData.TabIndex = 10;
            this.btnAddData.Text = "Добавить данные";
            this.toolTip1.SetToolTip(this.btnAddData, "Добавьте данные в таблицы в порядке: Станции → Поезда → Маршруты → Расписание");
            this.btnAddData.UseVisualStyleBackColor = true;
            this.btnAddData.Click += new System.EventHandler(this.btnAddData_Click);
            // 
            // btnViewData
            // 
            this.btnViewData.Location = new System.Drawing.Point(767, 470);
            this.btnViewData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnViewData.Name = "btnViewData";
            this.btnViewData.Size = new System.Drawing.Size(241, 101);
            this.btnViewData.TabIndex = 11;
            this.btnViewData.Text = "Просмотр данных";
            this.toolTip1.SetToolTip(this.btnViewData, "Добавьте данные в таблицы в порядке: Станции → Поезда → Маршруты → Расписание");
            this.btnViewData.UseVisualStyleBackColor = true;
            this.btnViewData.Click += new System.EventHandler(this.btnViewData_Click);
            // 
            // trainBoardViewTableAdapter1
            // 
            this.trainBoardViewTableAdapter1.ClearBeforeFill = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 644);
            this.Controls.Add(this.btnViewData);
            this.Controls.Add(this.btnAddData);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Обновить);
            this.Controls.Add(this.trainBoardViewDataGridView);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Main";
            this.Text = "Form1";
            this.toolTip1.SetToolTip(this, "Добавьте данные в таблицы в порядке: Станции → Поезда → Маршруты → Расписание");
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.controlSystemRZDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainBoardViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainBoardViewDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private ControlSystemRZDDataSet controlSystemRZDDataSet;
        private System.Windows.Forms.BindingSource trainBoardViewBindingSource;
        private ControlSystemRZDDataSetTableAdapters.TrainBoardViewTableAdapter trainBoardViewTableAdapter;
        private ControlSystemRZDDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView trainBoardViewDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Button Обновить;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddData;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnViewData;
        private ControlSystemRZDDataSetTableAdapters.TrainBoardViewTableAdapter trainBoardViewTableAdapter1;
    }
}

