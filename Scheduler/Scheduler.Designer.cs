namespace Scheduler
{
    partial class Scheduler
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel_data = new System.Windows.Forms.Panel();
            this.button_del = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scheduleDBBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.database_scheduleDataSet11 = new Database_scheduleDataSet1();
            this.scheduleDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.scheduleDBBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.databasescheduleDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database_scheduleDataSet1 = new Database_scheduleDataSet();
            this.databasescheduleDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel_add = new System.Windows.Forms.Panel();
            this.label_manage = new System.Windows.Forms.Label();
            this.label_endday = new System.Windows.Forms.Label();
            this.label_startday = new System.Windows.Forms.Label();
            this.dateTimePicker_end = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_start = new System.Windows.Forms.DateTimePicker();
            this.TextBox_memo = new System.Windows.Forms.RichTextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox_location = new System.Windows.Forms.TextBox();
            this.textBox_title = new System.Windows.Forms.TextBox();
            this.label_memo = new System.Windows.Forms.Label();
            this.label_type = new System.Windows.Forms.Label();
            this.label_location = new System.Windows.Forms.Label();
            this.label_day = new System.Windows.Forms.Label();
            this.label_title = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_end = new System.Windows.Forms.Button();
            this.panel_calendar = new System.Windows.Forms.Panel();
            this.btn_today = new System.Windows.Forms.Button();
            this.button_front = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button();
            this.Calendar = new Calendar.Calendar();
            this.scheduleDBTableAdapter = new Database_scheduleDataSet1TableAdapters.scheduleDBTableAdapter();
            this.tableAdapterManager1 = new Database_scheduleDataSetTableAdapters.TableAdapterManager();
            this.panel_data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleDBBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database_scheduleDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleDBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleDBBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databasescheduleDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database_scheduleDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databasescheduleDataSetBindingSource)).BeginInit();
            this.panel_add.SuspendLayout();
            this.panel_calendar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_data
            // 
            this.panel_data.Controls.Add(this.button_del);
            this.panel_data.Controls.Add(this.comboBox1);
            this.panel_data.Controls.Add(this.dataGridView1);
            this.panel_data.Location = new System.Drawing.Point(2, 365);
            this.panel_data.Name = "panel_data";
            this.panel_data.Size = new System.Drawing.Size(687, 194);
            this.panel_data.TabIndex = 0;
            // 
            // button_del
            // 
            this.button_del.Location = new System.Drawing.Point(607, 7);
            this.button_del.Name = "button_del";
            this.button_del.Size = new System.Drawing.Size(75, 23);
            this.button_del.TabIndex = 2;
            this.button_del.Text = "삭제";
            this.button_del.UseVisualStyleBackColor = true;
            this.button_del.Click += new System.EventHandler(this.button_del_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(10, 8);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.locationDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn5});
            this.dataGridView1.DataSource = this.scheduleDBBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(0, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(687, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Type";
            this.dataGridViewTextBoxColumn4.HeaderText = "Type";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 60;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Title";
            this.dataGridViewTextBoxColumn1.HeaderText = "Title";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Date_s";
            this.dataGridViewTextBoxColumn2.HeaderText = "Date_s";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Date_e";
            this.dataGridViewTextBoxColumn3.HeaderText = "Date_e";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "Location";
            this.locationDataGridViewTextBoxColumn.HeaderText = "Location";
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            this.locationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Memo";
            this.dataGridViewTextBoxColumn5.HeaderText = "Memo";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 130;
            // 
            // scheduleDBBindingSource2
            // 
            this.scheduleDBBindingSource2.DataMember = "scheduleDB";
            this.scheduleDBBindingSource2.DataSource = this.database_scheduleDataSet11;
            // 
            // database_scheduleDataSet11
            // 
            this.database_scheduleDataSet11.DataSetName = "Database_scheduleDataSet1";
            this.database_scheduleDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // databasescheduleDataSet1BindingSource
            // 
            this.databasescheduleDataSet1BindingSource.DataSource = this.database_scheduleDataSet1;
            this.databasescheduleDataSet1BindingSource.Position = 0;
            // 
            // database_scheduleDataSet1
            // 
            this.database_scheduleDataSet1.DataSetName = "Database_scheduleDataSet";
            this.database_scheduleDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel_add
            // 
            this.panel_add.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel_add.Controls.Add(this.label_manage);
            this.panel_add.Controls.Add(this.label_endday);
            this.panel_add.Controls.Add(this.label_startday);
            this.panel_add.Controls.Add(this.dateTimePicker_end);
            this.panel_add.Controls.Add(this.dateTimePicker_start);
            this.panel_add.Controls.Add(this.TextBox_memo);
            this.panel_add.Controls.Add(this.comboBox2);
            this.panel_add.Controls.Add(this.textBox_location);
            this.panel_add.Controls.Add(this.textBox_title);
            this.panel_add.Controls.Add(this.label_memo);
            this.panel_add.Controls.Add(this.label_type);
            this.panel_add.Controls.Add(this.label_location);
            this.panel_add.Controls.Add(this.label_day);
            this.panel_add.Controls.Add(this.label_title);
            this.panel_add.Controls.Add(this.btn_cancel);
            this.panel_add.Controls.Add(this.btn_save);
            this.panel_add.Location = new System.Drawing.Point(691, 2);
            this.panel_add.Name = "panel_add";
            this.panel_add.Size = new System.Drawing.Size(291, 399);
            this.panel_add.TabIndex = 1;
            // 
            // label_manage
            // 
            this.label_manage.AutoSize = true;
            this.label_manage.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold);
            this.label_manage.Location = new System.Drawing.Point(16, 20);
            this.label_manage.Name = "label_manage";
            this.label_manage.Size = new System.Drawing.Size(101, 20);
            this.label_manage.TabIndex = 18;
            this.label_manage.Text = "일정 관리";
            // 
            // label_endday
            // 
            this.label_endday.AutoSize = true;
            this.label_endday.Location = new System.Drawing.Point(233, 117);
            this.label_endday.Name = "label_endday";
            this.label_endday.Size = new System.Drawing.Size(29, 12);
            this.label_endday.TabIndex = 17;
            this.label_endday.Text = "까지";
            // 
            // label_startday
            // 
            this.label_startday.AutoSize = true;
            this.label_startday.Location = new System.Drawing.Point(233, 90);
            this.label_startday.Name = "label_startday";
            this.label_startday.Size = new System.Drawing.Size(29, 12);
            this.label_startday.TabIndex = 16;
            this.label_startday.Text = "부터";
            // 
            // dateTimePicker_end
            // 
            this.dateTimePicker_end.Location = new System.Drawing.Point(53, 111);
            this.dateTimePicker_end.Name = "dateTimePicker_end";
            this.dateTimePicker_end.Size = new System.Drawing.Size(173, 21);
            this.dateTimePicker_end.TabIndex = 15;
            // 
            // dateTimePicker_start
            // 
            this.dateTimePicker_start.Location = new System.Drawing.Point(54, 84);
            this.dateTimePicker_start.Name = "dateTimePicker_start";
            this.dateTimePicker_start.Size = new System.Drawing.Size(173, 21);
            this.dateTimePicker_start.TabIndex = 14;
            // 
            // TextBox_memo
            // 
            this.TextBox_memo.Location = new System.Drawing.Point(54, 207);
            this.TextBox_memo.Name = "TextBox_memo";
            this.TextBox_memo.Size = new System.Drawing.Size(225, 146);
            this.TextBox_memo.TabIndex = 13;
            this.TextBox_memo.Text = "";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(54, 175);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(227, 20);
            this.comboBox2.TabIndex = 9;
            // 
            // textBox_location
            // 
            this.textBox_location.Location = new System.Drawing.Point(53, 144);
            this.textBox_location.Name = "textBox_location";
            this.textBox_location.Size = new System.Drawing.Size(227, 21);
            this.textBox_location.TabIndex = 8;
            // 
            // textBox_title
            // 
            this.textBox_title.Location = new System.Drawing.Point(54, 53);
            this.textBox_title.Name = "textBox_title";
            this.textBox_title.Size = new System.Drawing.Size(227, 21);
            this.textBox_title.TabIndex = 7;
            // 
            // label_memo
            // 
            this.label_memo.AutoSize = true;
            this.label_memo.Location = new System.Drawing.Point(18, 210);
            this.label_memo.Name = "label_memo";
            this.label_memo.Size = new System.Drawing.Size(29, 12);
            this.label_memo.TabIndex = 6;
            this.label_memo.Text = "메모";
            // 
            // label_type
            // 
            this.label_type.AutoSize = true;
            this.label_type.Location = new System.Drawing.Point(18, 180);
            this.label_type.Name = "label_type";
            this.label_type.Size = new System.Drawing.Size(29, 12);
            this.label_type.TabIndex = 5;
            this.label_type.Text = "분류";
            // 
            // label_location
            // 
            this.label_location.AutoSize = true;
            this.label_location.Location = new System.Drawing.Point(18, 150);
            this.label_location.Name = "label_location";
            this.label_location.Size = new System.Drawing.Size(29, 12);
            this.label_location.TabIndex = 4;
            this.label_location.Text = "장소";
            // 
            // label_day
            // 
            this.label_day.AutoSize = true;
            this.label_day.Location = new System.Drawing.Point(18, 90);
            this.label_day.Name = "label_day";
            this.label_day.Size = new System.Drawing.Size(29, 12);
            this.label_day.TabIndex = 3;
            this.label_day.Text = "날짜";
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Location = new System.Drawing.Point(18, 60);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(29, 12);
            this.label_title.TabIndex = 2;
            this.label_title.Text = "제목";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(126, 363);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 1;
            this.btn_cancel.Text = "취소";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(206, 363);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 0;
            this.btn_save.Text = "저장";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_end
            // 
            this.btn_end.Location = new System.Drawing.Point(850, 511);
            this.btn_end.Name = "btn_end";
            this.btn_end.Size = new System.Drawing.Size(122, 38);
            this.btn_end.TabIndex = 2;
            this.btn_end.Text = "종료";
            this.btn_end.UseVisualStyleBackColor = true;
            this.btn_end.Click += new System.EventHandler(this.btn_end_Click);
            // 
            // panel_calendar
            // 
            this.panel_calendar.Controls.Add(this.btn_today);
            this.panel_calendar.Controls.Add(this.button_front);
            this.panel_calendar.Controls.Add(this.button_back);
            this.panel_calendar.Controls.Add(this.Calendar);
            this.panel_calendar.Location = new System.Drawing.Point(2, 2);
            this.panel_calendar.Name = "panel_calendar";
            this.panel_calendar.Size = new System.Drawing.Size(687, 357);
            this.panel_calendar.TabIndex = 3;
            // 
            // btn_today
            // 
            this.btn_today.Location = new System.Drawing.Point(608, 33);
            this.btn_today.Name = "btn_today";
            this.btn_today.Size = new System.Drawing.Size(75, 23);
            this.btn_today.TabIndex = 3;
            this.btn_today.Text = "오늘";
            this.btn_today.UseVisualStyleBackColor = true;
            this.btn_today.Click += new System.EventHandler(this.btn_today_Click);
            // 
            // button_front
            // 
            this.button_front.Location = new System.Drawing.Point(443, 17);
            this.button_front.Name = "button_front";
            this.button_front.Size = new System.Drawing.Size(75, 23);
            this.button_front.TabIndex = 1;
            this.button_front.Text = ">";
            this.button_front.UseVisualStyleBackColor = true;
            this.button_front.Click += new System.EventHandler(this.button_front_Click);
            // 
            // button_back
            // 
            this.button_back.Location = new System.Drawing.Point(159, 17);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(75, 23);
            this.button_back.TabIndex = 0;
            this.button_back.Text = "<";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // Calendar
            // 
            this.Calendar.Location = new System.Drawing.Point(0, 4);
            this.Calendar.Name = "Calendar";
            this.Calendar.Size = new System.Drawing.Size(684, 350);
            this.Calendar.TabIndex = 2;
            // 
            // scheduleDBTableAdapter
            // 
            this.scheduleDBTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.scheduleDBTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = Database_scheduleDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Scheduler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.panel_calendar);
            this.Controls.Add(this.btn_end);
            this.Controls.Add(this.panel_add);
            this.Controls.Add(this.panel_data);
            this.Name = "Scheduler";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_data.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleDBBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database_scheduleDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleDBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleDBBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databasescheduleDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database_scheduleDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databasescheduleDataSetBindingSource)).EndInit();
            this.panel_add.ResumeLayout(false);
            this.panel_add.PerformLayout();
            this.panel_calendar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_data;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel_add;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_end;
        private System.Windows.Forms.Panel panel_calendar;
        private System.Windows.Forms.Label label_endday;
        private System.Windows.Forms.Label label_startday;
        private System.Windows.Forms.DateTimePicker dateTimePicker_end;
        private System.Windows.Forms.DateTimePicker dateTimePicker_start;
        private System.Windows.Forms.RichTextBox TextBox_memo;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox_location;
        private System.Windows.Forms.TextBox textBox_title;
        private System.Windows.Forms.Label label_memo;
        private System.Windows.Forms.Label label_type;
        private System.Windows.Forms.Label label_location;
        private System.Windows.Forms.Label label_day;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Label label_manage;
        private System.Windows.Forms.Button button_front;
        private System.Windows.Forms.Button button_back;
        private Calendar.Calendar Calendar;
        private System.Windows.Forms.Button btn_today;
        private System.Windows.Forms.BindingSource databasescheduleDataSetBindingSource;
        private Database_scheduleDataSet database_scheduleDataSet1;
        private System.Windows.Forms.BindingSource databasescheduleDataSet1BindingSource;
        private System.Windows.Forms.BindingSource scheduleDBBindingSource;
        private System.Windows.Forms.BindingSource scheduleDBBindingSource1;
        private Database_scheduleDataSet1 database_scheduleDataSet11;
        private System.Windows.Forms.BindingSource scheduleDBBindingSource2;
        private Database_scheduleDataSet1TableAdapters.scheduleDBTableAdapter scheduleDBTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private Database_scheduleDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.Button button_del;
    }
}

