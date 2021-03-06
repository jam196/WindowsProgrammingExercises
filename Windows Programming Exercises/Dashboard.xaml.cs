using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace Windows_Programming_Exercises
{
    public partial class Dashboard : UserControl
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Button_Form1_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            try
            {
                KetquaForm1.Text =
                    ((float.Parse(Form1SoA.Text) + double.Parse(Form1SoB.Text) + double.Parse(Form1SoC.Text)) / 3)
                    .ToString("0.00");
            }
            catch (Exception)
            {
                MessageBox.Show("Dữ liệu không hợp lệ");
            }
        }

        private void Button_Form2_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            try
            {
                KetquaForm2.Text =
                    ((double.Parse(Form2SoA.Text) + double.Parse(Form2SoB.Text) + double.Parse(Form2SoC.Text)))
                    .ToString("0.00");
            }
            catch (Exception)
            {
                MessageBox.Show("Dữ liệu không hợp lệ");
            }
        }

        private void Button_Form3_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            try
            {
                KetquaForm3.Text =
                    ((float.Parse(Form3SoA.Text) + float.Parse(Form3SoB.Text)) * 2).ToString("0.00");
            }
            catch (Exception)
            {
                MessageBox.Show("Dữ liệu không hợp lệ");
            }
        }

        private void Button_Form4_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            try
            {
                KetquaForm4.Text =
                    (double.Parse(Form4SoA.Text) * 4).ToString("0.00");
            }
            catch (Exception)
            {
                MessageBox.Show("Dữ liệu không hợp lệ");
            }
        }

        private void Button_Form5_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            try
            {
                KetquaForm5.Text =
                    (double.Parse(Form5SoA.Text) * double.Parse(Form5SoA.Text)).ToString("0.00");
            }
            catch (Exception)
            {
                MessageBox.Show("Dữ liệu không hợp lệ");
            }
        }

        private void Button_Form6_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            try
            {
                KetquaForm6.Text =
                    (double.Parse(Form6SoA.Text) * double.Parse(Form6SoB.Text)).ToString("0.00");
            }
            catch (Exception)
            {
                MessageBox.Show("Dữ liệu không hợp lệ");
            }
        }

        private void Button_Form7_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            try
            {
                KetquaForm7.Text =
                    (double.Parse(Form7SoA.Text) * double.Parse(Form7SoA.Text) * 3.14).ToString("0.00");
            }
            catch (Exception)
            {
                MessageBox.Show("Dữ liệu không hợp lệ");
            }
        }

        private void Button_Form8_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            try
            {
                double a = double.Parse(Form8SoA.Text);
                double b = double.Parse(Form8SoB.Text);
                String ketqua = "";

                if (a == 0)
                {
                    ketqua = "a phải khác 0";
                }
                else
                {
                    double x = -b / a;
                    ketqua = x.ToString("0.00");
                }

                KetquaForm8.Text = ketqua;
            }
            catch (Exception)
            {
                MessageBox.Show("Dữ liệu không hợp lệ");
            }
        }

        private void Button_Form9_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            try
            {
                double a = double.Parse(Form9SoA.Text);
                double b = double.Parse(Form9SoB.Text);
                double c = double.Parse(Form9SoC.Text);
                String ketqua = "";

                double delta = b * b - 4 * a * c;
                if (delta > 0)
                {
                    ketqua = "a = " + ((-b - Math.Sqrt(delta)) / 2 * a).ToString("0.00") + " \nb = " +
                             ((-b + Math.Sqrt(delta)) / 2 * a).ToString("0.00");
                }
                else if (delta == 0)
                {
                    ketqua = "Nghiệm kép = " + (-b / 2 * a).ToString("0.00");
                }
                else if (delta < 0)
                {
                    ketqua = "Vô nghiệm";
                }

                KetquaForm9.Text = ketqua;
            }
            catch (Exception)
            {
                MessageBox.Show("Dữ liệu không hợp lệ");
            }
        }

        private void Button_Form10_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            try
            {
                int n = Int32.Parse(Form10SoA.Text);
                int ketqua = 0;

                for (int i = 0; i <= n; i++)
                {
                    ketqua += i;
                }

                KetquaForm10.Text = ketqua.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Dữ liệu không hợp lệ");
            }
        }

        private void Button_Form11_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            try
            {
                int n = Int32.Parse(Form11SoA.Text);
                int ketqua = 1;

                if (n < 1)
                {
                    ketqua = 0;
                }

                for (int i = 1; i <= n; i++)
                {
                    if (i % 2 == 0)
                    {
                        ketqua *= i;
                    }
                }

                KetquaForm11.Text = ketqua.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Dữ liệu không hợp lệ");
            }
        }

        private void Button_Form12_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            try
            {
                int n = Int32.Parse(Form12SoA.Text);
                String ketqua;

                Boolean checkIsPrimeNumber = IsPrimeNumber(n);

                if (checkIsPrimeNumber)
                {
                    ketqua = "Là số \nnguyên tố";
                }
                else
                {
                    ketqua = "Không phải \nsố nguyên số";
                }

                KetquaForm12.Text = ketqua;
            }
            catch (Exception)
            {
                MessageBox.Show("Dữ liệu không hợp lệ");
            }
        }

        private Boolean IsPrimeNumber(int n)
        {
            Boolean isPrimeNumber;
            int m = 0;

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    m++;
                }
            }

            if (m == 2)
            {
                isPrimeNumber = true;
            }
            else
            {
                isPrimeNumber = false;
            }

            return isPrimeNumber;
        }

        private void Button_Form13_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            try
            {
                int n = Int32.Parse(Form13SoA.Text);
                List<String> ketqua = new List<String>();

                for (int i = 2; i <= n; i++)
                {
                    Boolean checkIsPrimeNumber = IsPrimeNumber(i);
                    if (checkIsPrimeNumber)
                    {
                        ketqua.Add(i.ToString());
                    }
                }

                KetquaForm13.Text = String.Join(",", ketqua);
            }
            catch (Exception)
            {
                MessageBox.Show("Dữ liệu không hợp lệ");
            }
        }

        private void Button_Form14_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            try
            {
                int a = Int32.Parse(Form14SoA.Text);
                int b = Int32.Parse(Form14SoB.Text);
                int ketqua = 0;
                int c = (a < b) ? a : b;
                for (int i = 1; i <= c; i++)
                {
                    if (a % i == 0 && b % i == 0)
                    {
                        ketqua = i;
                    }
                }

                KetquaForm14.Text = ketqua.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Dữ liệu không hợp lệ");
            }
        }
    }
}