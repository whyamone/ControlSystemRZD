namespace ControlSystemRZD
{
    partial class ViewDataForm
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
            this.cmbTables = new System.Windows.Forms.ComboBox();
            this.маршрутыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.controlSystemRZDDataSet = new ControlSystemRZD.ControlSystemRZDDataSet();
            this.controlSystemRZDDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnRefresh = new System.Windows.Forms.Button();
            this.маршрутыTableAdapter = new ControlSystemRZD.ControlSystemRZDDataSetTableAdapters.МаршрутыTableAdapter();
            this.tableAdapterManager = new ControlSystemRZD.ControlSystemRZDDataSetTableAdapters.TableAdapterManager();
            this.поездаTableAdapter = new ControlSystemRZD.ControlSystemRZDDataSetTableAdapters.ПоездаTableAdapter();
            this.расписаниеTableAdapter = new ControlSystemRZD.ControlSystemRZDDataSetTableAdapters.РасписаниеTableAdapter();
            this.станцииTableAdapter = new ControlSystemRZD.ControlSystemRZDDataSetTableAdapters.СтанцииTableAdapter();
            this.поездаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.расписаниеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.станцииBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.маршрутыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlSystemRZDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlSystemRZDDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.поездаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.расписаниеBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.станцииBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbTables
            // 
            this.cmbTables.FormattingEnabled = true;
            this.cmbTables.Location = new System.Drawing.Point(9, 10);
            this.cmbTables.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbTables.Name = "cmbTables";
            this.cmbTables.Size = new System.Drawing.Size(134, 21);
            this.cmbTables.TabIndex = 0;
            // 
            // маршрутыBindingSource
            // 
            this.маршрутыBindingSource.DataMember = "Маршруты";
            this.маршрутыBindingSource.DataSource = this.controlSystemRZDDataSet;
            // 
            // controlSystemRZDDataSet
            // 
            this.controlSystemRZDDataSet.DataSetName = "ControlSystemRZDDataSet";
            this.controlSystemRZDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // controlSystemRZDDataSetBindingSource
            // 
            this.controlSystemRZDDataSetBindingSource.DataSource = this.controlSystemRZDDataSet;
            this.controlSystemRZDDataSetBindingSource.Position = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(147, 9);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(88, 23);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Обновить";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // маршрутыTableAdapter
            // 
            this.маршрутыTableAdapter.ClearBeforeFill = true;
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
            // поездаTableAdapter
            // 
            this.поездаTableAdapter.ClearBeforeFill = true;
            // 
            // расписаниеTableAdapter
            // 
            this.расписаниеTableAdapter.ClearBeforeFill = true;
            // 
            // станцииTableAdapter
            // 
            this.станцииTableAdapter.ClearBeforeFill = true;
            // 
            // поездаBindingSource
            // 
            this.поездаBindingSource.DataMember = "Поезда";
            this.поездаBindingSource.DataSource = this.controlSystemRZDDataSet;
            // 
            // расписаниеBindingSource
            // 
            this.расписаниеBindingSource.DataMember = "Расписание";
            this.расписаниеBindingSource.DataSource = this.controlSystemRZDDataSet;
            // 
            // станцииBindingSource
            // 
            this.станцииBindingSource.DataMember = "Станции";
            this.станцииBindingSource.DataSource = this.controlSystemRZDDataSet;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 46);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(680, 392);
            this.dataGridView1.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(445, 9);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(67, 30);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Поиск";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(516, 12);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(76, 20);
            this.txtSearch.TabIndex = 5;
            // 
            // ViewDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 468);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.cmbTables);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ViewDataForm";
            this.Text = "ViewDataForm";
            this.Load += new System.EventHandler(this.ViewDataForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.маршрутыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlSystemRZDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlSystemRZDDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.поездаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.расписаниеBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.станцииBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTables;
        private System.Windows.Forms.BindingSource controlSystemRZDDataSetBindingSource;
        private ControlSystemRZDDataSet controlSystemRZDDataSet;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.BindingSource маршрутыBindingSource;
        private ControlSystemRZDDataSetTableAdapters.МаршрутыTableAdapter маршрутыTableAdapter;
        private ControlSystemRZDDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private ControlSystemRZDDataSetTableAdapters.ПоездаTableAdapter поездаTableAdapter;
        private System.Windows.Forms.BindingSource поездаBindingSource;
        private ControlSystemRZDDataSetTableAdapters.РасписаниеTableAdapter расписаниеTableAdapter;
        private System.Windows.Forms.BindingSource расписаниеBindingSource;
        private ControlSystemRZDDataSetTableAdapters.СтанцииTableAdapter станцииTableAdapter;
        private System.Windows.Forms.BindingSource станцииBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
    }
}