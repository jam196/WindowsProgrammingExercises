using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Windows_Programming_Exercises.Views
{
    /// <summary>
    /// Interaction logic for Page2.xaml
    /// </summary>
    public partial class Page2 : UserControl
    {
        public OleDbConnection connection;

        public Page2()
        {
            InitializeComponent();

            // Load danh sách lớp
            this.connection = new OleDbConnection();
            this.connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:/Users/profi/Desktop/DataKTHT.mdb";
            this.connection.Open();

            OleDbDataAdapter ad = new OleDbDataAdapter("SELECT `MaLop` FROM LOP", this.connection);

            DataTable dataTable = new DataTable();
            ad.Fill(dataTable);

            MaLopTxt.ItemsSource = dataTable.DefaultView;
            MaLopTxt1.ItemsSource = dataTable.DefaultView;

            OleDbDataAdapter ad2 = new OleDbDataAdapter("SELECT `MaSinhVien` FROM SINH_VIEN", this.connection);
            DataTable dataTable2 = new DataTable();
            ad2.Fill(dataTable2);

            MaSVTxt1.ItemsSource = dataTable2.DefaultView;
            MaSVTxt2.ItemsSource = dataTable2.DefaultView;
        }

        private void Button_Form1_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            try
            {
                Boolean GioiTinhVal = GioiTinhTxt.Text == "Nam";
                OleDbCommand command = new OleDbCommand("INSERT INTO SINH_VIEN(MaSinhVien, HoDem, Ten, NgaySinh, GioiTinh, MaLop) VALUES('" + MaSVTxt.Text + "', '" + HoDemTxt.Text + "', '" + TenSVTxt.Text + "', '" + NgaySinhTxt.Text + "', " + GioiTinhVal + ", '" + MaLopTxt.Text + "');", this.connection);
                command.ExecuteNonQuery();

                MessageBox.Show("Thêm sinh viên thành công");
            }
            catch (Exception err)
            {
                MessageBox.Show("Dữ liệu không hợp lệ. " + err.Message);
            }
        }

        private void Button_Form2_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            try
            {
                Boolean GioiTinhVal = GioiTinhTxt1.Text == "Nam";
                OleDbCommand command = new OleDbCommand("UPDATE SINH_VIEN SET HoDem='" + HoDemTxt1.Text + "', Ten='" + TenSVTxt1.Text + "', NgaySinh='" + NgaySinhTxt1.Text + "', GioiTinh=" + GioiTinhVal + ", MaLop='" + MaLopTxt1.Text + "' WHERE MaSinhVien = '" + MaSVTxt1.Text + "'", this.connection);
                command.ExecuteNonQuery();

                MessageBox.Show("Sửa sinh viên thành công");
            }
            catch (Exception err)
            {
                MessageBox.Show("Dữ liệu không hợp lệ. " + err.Message);
            }
        }

        private void Button_Form3_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            try
            {
                OleDbCommand command = new OleDbCommand("DELETE FROM SINH_VIEN WHERE MaSinhVien = '" + MaSVTxt2.Text + "'", this.connection);
                command.ExecuteNonQuery();

                MessageBox.Show("Xóa sinh viên thành công");
            }
            catch (Exception err)
            {
                MessageBox.Show("Dữ liệu không hợp lệ. " + err.Message);
            }
        }

        private void MaSVTxt1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Object[] ChangedData = ((DataRowView)e.AddedItems[0]).Row.ItemArray;
            OleDbCommand command = new OleDbCommand("SELECT * FROM SINH_VIEN WHERE `MaSinhVien` = '" + ChangedData[0].ToString() + "'", this.connection);
            OleDbDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                MessageBox.Show(reader["GioiTinh"].ToString());

                HoDemTxt1.Text = reader["HoDem"].ToString();
                TenSVTxt1.Text = reader["Ten"].ToString();
                GioiTinhTxt1.Text = reader["GioiTinh"].ToString() == "True" ? "Nam" : "Nữ";
                MaLopTxt1.Text = reader["MaLop"].ToString();
                NgaySinhTxt1.Text = reader["NgaySinh"].ToString();
            }
            reader.Close();
        }
    }
}
