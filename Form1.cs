using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PR_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void SortBtn_Click(object sender, EventArgs e)
        {
            // Тестирование с целыми числами
            int[] intArray = { 5, 2, 8, 1, 9, 3};
            OneDimensionalArray<int> intArrayObj = new OneDimensionalArray<int>(intArray);
            intArrayObj.ShellSort();
            IntTxt.Text = intArrayObj.PrintArray();

            // Тестирование с строками
            string[] stringArray = { "яблоко", "арбуз", "дыня", "горох", "помидор" };
            OneDimensionalArray<string> stringArrayObj = new OneDimensionalArray<string>(stringArray);
            stringArrayObj.ShellSort();
            StringTxt.Text = stringArrayObj.PrintArray();

            // Тестирование с объектами типа DateTime
            DateTime[] dateTimeArray = { new DateTime(2023, 11, 15), new DateTime(2024, 11, 10),
             new DateTime(2023, 9, 20), new DateTime(2013, 09, 21) };
            OneDimensionalArray<DateTime> dateTimeArrayObj = new OneDimensionalArray<DateTime>(dateTimeArray);
            dateTimeArrayObj.ShellSort();
            DateTxt.Text = dateTimeArrayObj.PrintArray();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            IntTxt.Text = "";
           StringTxt.Text = "";
            DateTxt.Text = "";
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
