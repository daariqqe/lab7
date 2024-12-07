using System;
using System.Windows.Forms;

namespace ЛР7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                
                double x1 = double.Parse(tbX1.Text);
                double x2 = double.Parse(tbX2.Text);

                if (x1 < 0)
                {
                    MessageBox.Show("x1 має бути >= 0 для коректного обчислення.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                double y = Math.Sin(x1 - Math.Pow(x2, 3) + Math.Sqrt(x1)) - 1.3 * Math.Pow(x1, 3);

                tbResult.Text = y.ToString("F4");

                double minValue = Math.Min(x1, x2);
                tbMinResult.Text = minValue.ToString("F4"); 
            }
            catch (FormatException)
            {
                MessageBox.Show("Перевірте, чи правильно введені дані (числа).", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Сталася помилка: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbX1.Clear();
            tbX2.Clear();
            tbResult.Clear();
            tbMinResult.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            btnCalculate_Click(sender, e);
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            btnClear_Click(sender, e); 
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            btnExit_Click(sender, e); 
        }

    }
}
