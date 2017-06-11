using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calendar
{
    public partial class Calendar : UserControl
    {
        public delegate void DateTimeEventHandler(DateTime dt);
        public event DateTimeEventHandler _changedDate;
        likeCal LikeCal = new likeCal();

        public Calendar()
        {
            InitializeComponent();
            LikeCal._changeDate += new likeCal.dtDelegate(LikeCal_changeDate);
            LikeCal.Dock = DockStyle.Fill;
            LikeCal.selectDate(DateTime.Now);
            panel_day.Controls.Add(LikeCal);
        }

        public DateTime selectedDate
        {
            get
            {
                return LikeCal.dtValue;
            }
        }

        private void LikeCal_changeDate(DateTime dt)
        {
            label_caption.Text = dt.Month + "월";
            label_year.Text = dt.Year+"년";
            if (_changedDate != null) _changedDate(LikeCal.dtValue);
        }

        public void goToDateWithNoEvent(DateTime dt)
        {
            LikeCal.selectDate(dt);
            label_caption.Text = dt.Month + "월";
            label_year.Text = dt.Year + "년";
        }
    }

    class dLabel : Label
    {
        public dLabel()
        {
            this.SetStyle(ControlStyles.DoubleBuffer | ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.ResizeRedraw, true);
            this.UpdateStyles();
        }
    }

    class likeCal : TableLayoutPanel
    {
        public delegate void dtDelegate(DateTime dt);
        public event dtDelegate _changeDate;

        int Month = DateTime.Now.Month;
        public DateTime dtValue = DateTime.Now;
        public dLabel[] TB = new dLabel[42];
        int[] holidayList = null;
        string[] holidayName = null;

        public likeCal()
        {
            DoubleBuffered = true;
            setRowColumns(7, 7);
        }

        public void setholiday(int[] holidayList, string[] holidayName)
        {
            this.holidayList = holidayList;
            this.holidayName = holidayName;
        }

        //달력 마우스 클릭 이벤트
        private void likeCal_MouseClick(object sender, MouseEventArgs e)
        {
            if (((Control)sender).Text != null && ((Control)sender).Text != "")
            {
                DateTime dt;
                try
                {
                    dt = new DateTime(dtValue.Year, dtValue.Month, int.Parse(((Control)sender).Text), 0, 0, 0);
                }
                catch
                {
                    return;
                }
                selectDate(dt);
                if (_changeDate != null) _changeDate(dt);
            }
        }

        //달력 디자인
        public void setRowColumns(int rows, int columns)
        {
            ColumnCount = columns;
            RowCount = rows;
            for (int i = 0; i < RowCount; i++) RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            for (int i = 0; i < ColumnCount; i++) ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));

            dLabel tb = null;
            for (int i = 0; i < RowCount; i++)
            {
                for (int j = 0; j < ColumnCount; j++)
                {
                    tb = new dLabel();
                    tb.AutoSize = false;
                    if (i == 0) //첫줄: 요일
                    {
                        tb.Text = System.Threading.Thread.CurrentThread.CurrentCulture.DateTimeFormat.AbbreviatedDayNames[j][0].ToString();
                        tb.ForeColor = System.Drawing.Color.White;
                        tb.BackColor = System.Drawing.Color.Gray;
                        tb.Font = new System.Drawing.Font("Arial", 18, FontStyle.Bold);
                        tb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    }
                    else
                    {
                        tb.ForeColor = System.Drawing.Color.Black;
                        tb.BackColor = System.Drawing.Color.White;
                        tb.MouseClick += new MouseEventHandler(likeCal_MouseClick);
                        tb.Font = new System.Drawing.Font("Arial", 13);
                        tb.TextAlign = System.Drawing.ContentAlignment.TopLeft;
                        TB[j + ((i - 1) * 7)] = tb;
                    }

                    tb.BorderStyle = BorderStyle.None;
                    tb.Margin = new Padding(1);
                    tb.Padding = new Padding(0);
                    tb.Dock = DockStyle.Fill;
                    Controls.Add(tb, j, i);
                }
            }
        }

        //날짜 선택
        public void selectDate(DateTime DT)
        {
            dtValue = DT;

            //이전 선택된 날짜 리셋
            for (int i = 0; i < 42; i++)
            {
                TB[i].BorderStyle = System.Windows.Forms.BorderStyle.None;
                TB[i].BackColor = Color.White;
                TB[i].Cursor = Cursors.Default;
                TB[i].Text = string.Empty;
            }

            DateTime Start = new DateTime(DT.Year, DT.Month, 1);
            int End = DateTime.DaysInMonth(DT.Year, DT.Month);
            int week = (int)Start.DayOfWeek;

            for (int var = 1; var <= End; var++)
            {
                int index = var + week - 1;

                TB[index].Cursor = Cursors.Hand;
                TB[index].Text = string.Format("{0:0}", var);

                if (var == dtValue.Day) 
                {
                    if (index % 7 == 0)
                    {
                        TB[index].ForeColor = System.Drawing.Color.Red;
                    }
                    else TB[index].ForeColor = System.Drawing.Color.Black;

                    TB[index].BackColor = System.Drawing.Color.Gainsboro;
                }
                else
                {
                    if (index % 7 == 0)
                    {
                        TB[index].ForeColor = System.Drawing.Color.Red;
                    }
                    else TB[index].ForeColor = System.Drawing.Color.Black;
                }
            }
        }
    }
}

