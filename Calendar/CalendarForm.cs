using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendar
{
    public partial class CalendarForm : Form
    {
        int month, year;
        public CalendarForm()
        {
            InitializeComponent();
        }

        private void CalendarForm_Load(object sender, EventArgs e)
        {
            displaydays();
        }

        private void displaydays()
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;

            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            labeldate.Text = monthname + " " + year;

            DateTime startofthemonth = new DateTime(year, month, 1);

            int days = DateTime.DaysInMonth(year, month);

            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;

            for(int i = 1; i < dayoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                flowLayoutPanel1.Controls.Add(ucblank);
            }

            for(int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                flowLayoutPanel1.Controls.Add(ucdays);
            }
        }

        private void nextbtn_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            month++;
            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            labeldate.Text = monthname + " " + year;

            DateTime startofthemonth = new DateTime(year, month, 1);

            int days = DateTime.DaysInMonth(year, month);

            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                flowLayoutPanel1.Controls.Add(ucblank);
            }

            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                flowLayoutPanel1.Controls.Add(ucdays);
            }
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void prevbtn_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            month--;
            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            labeldate.Text = monthname + " " + year;

            DateTime startofthemonth = new DateTime(year, month, 1);

            int days = DateTime.DaysInMonth(year, month);

            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                flowLayoutPanel1.Controls.Add(ucblank);
            }

            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                flowLayoutPanel1.Controls.Add(ucdays);
            }
        }
    }
}
