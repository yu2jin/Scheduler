using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Scheduler
{
    public partial class Scheduler : Form
    {
        //Con_Database db
        public Scheduler()
        {
            InitializeComponent();

            this.MinimumSize = new Size(1000, 600);
            this.MaximumSize = new Size(1000, 600);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'database_scheduleDataSet11.scheduleDB' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.scheduleDBTableAdapter.Fill(this.database_scheduleDataSet11.scheduleDB);
            comboBox1.Items.Add("ALL");
            comboBox1.Items.Add("schedule");
            comboBox1.Items.Add("test");
            comboBox1.Items.Add("travel");
            comboBox1.SelectedIndex = 0;

            comboBox2.Items.Add("schedule");
            comboBox2.Items.Add("test");
            comboBox2.Items.Add("travel");
            comboBox2.SelectedIndex = 0;
        }

        //이전 달로 이동
        private void button_back_Click(object sender, EventArgs e)
        {
            Calendar.goToDateWithNoEvent(Calendar.selectedDate.AddMonths(-1));
        }

        //다음 달로 이동
        private void button_front_Click(object sender, EventArgs e)
        {
            Calendar.goToDateWithNoEvent(Calendar.selectedDate.AddMonths(1));
        }

        //오늘 날짜로 이동
        private void btn_today_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            Calendar.goToDateWithNoEvent(dt);
        }


        //일정 취소
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.textBox_title.ResetText();
            this.dateTimePicker_start.ResetText();
            this.dateTimePicker_end.ResetText();
            this.textBox_location.ResetText();
            this.comboBox2.ResetText();
            this.TextBox_memo.ResetText();
        }

        //일정 저장
        private void btn_save_Click(object sender, EventArgs e)
        {
            TimeSpan ts = this.dateTimePicker_end.Value - this.dateTimePicker_start.Value;
            int diffDay = ts.Days;

            if (this.textBox_title.Text != "" && diffDay > 0)
            {
                MessageBox.Show("일정을 추가 하시겠습니까?", "확인창");

                //데이터베이스에 삽입할 값
                string sTitle = this.textBox_title.Text;
                string sDate_s = this.dateTimePicker_start.ToString();
                string sDate_e = this.dateTimePicker_end.ToString();
                string sLocation = this.textBox_location.Text;
                string sType = this.comboBox2.Text;
                string sMemo = this.TextBox_memo.Text;

                //새로운 열 생성 및 대입
                DataRow row = this.database_scheduleDataSet11.scheduleDB.NewRow();
                row["Title"] = sTitle;
                row["Date_s"] = sDate_s;
                row["Date_e"] = sDate_e;
                row["Locaiton"] = sLocation;
                row["Type"] = sType;
                row["Memo"] = sMemo;

                this.database_scheduleDataSet11.scheduleDB.Rows.Add(row);
                scheduleDBTableAdapter.Update(this.database_scheduleDataSet11.scheduleDB);

                this.textBox_title.ResetText();
                this.dateTimePicker_start.ResetText();
                this.dateTimePicker_end.ResetText();
                this.textBox_location.ResetText();
                this.comboBox2.ResetText();
                this.TextBox_memo.ResetText();
            }
            else if (this.textBox_title.Text == "")
            {
                MessageBox.Show("제목은 필수 입력 사항입니다.");
            }
            else if (diffDay < 0)
            {
                MessageBox.Show("시작 날짜가 끝 날짜보다 앞설 수 없습니다.");
            }
        }

        //일정 삭제
        private void button_del_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection selRow = dataGridView1.SelectedRows;
            for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {
                dataGridView1.Rows.Remove(selRow[i]);
            }
        }

        //프로그램 종료
        private void btn_end_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
            Environment.Exit(0);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Item = comboBox1.SelectedItem.ToString();
            if (Item == "ALL")
            {
                this.scheduleDBTableAdapter.Fill(this.database_scheduleDataSet11.scheduleDB);
            }
            else
            {
                string sql = "SELECT * FORM scheduleDB Where Type ='" + Item + "'";
            }
        }
    }
}
