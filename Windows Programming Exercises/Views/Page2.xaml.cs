using System;
using System.Data;
using System.Data.OleDb;
using System.Windows;
using System.Windows.Controls;

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
            DataTable dataTable = DBClass.queryAsDatatable("SELECT `MaLop` FROM LOP");

            // Load danh sách sinh viên
            DataTable dataTable2 = DBClass.queryAsDatatable("SELECT `MaSinhVien` FROM SINH_VIEN");

            MaLopTxt.ItemsSource = dataTable.DefaultView;
            MaLopTxt1.ItemsSource = dataTable.DefaultView;

            MaSVTxt1.ItemsSource = dataTable2.DefaultView;
            MaSVTxt2.ItemsSource = dataTable2.DefaultView;
        }

        private void Button_Form1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Boolean GioiTinhVal = GioiTinhTxt.Text == "Nam";
                DBClass.excuteCommand("INSERT INTO SINH_VIEN(MaSinhVien, HoDem, Ten, NgaySinh, GioiTinh, MaLop) VALUES('" + MaSVTxt.Text + "', '" + HoDemTxt.Text + "', '" + TenSVTxt.Text + "', '" + NgaySinhTxt.Text + "', " + GioiTinhVal + ", '" + MaLopTxt.Text + "');");

                MessageBox.Show("Thêm sinh viên thành công");
            }
            catch (Exception err)
            {
                MessageBox.Show("Dữ liệu không hợp lệ. " + err.Message);
            }
        }

        private void Button_Form2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Boolean GioiTinhVal = GioiTinhTxt1.Text == "Nam";
                DBClass.excuteCommand("UPDATE SINH_VIEN SET HoDem='" + HoDemTxt1.Text + "', Ten='" + TenSVTxt1.Text + "', NgaySinh='" + NgaySinhTxt1.Text + "', GioiTinh=" + GioiTinhVal + ", MaLop='" + MaLopTxt1.Text + "' WHERE MaSinhVien = '" + MaSVTxt1.Text + "'");

                MessageBox.Show("Sửa sinh viên thành công");
            }
            catch (Exception err)
            {
                MessageBox.Show("Dữ liệu không hợp lệ. " + err.Message);
            }
        }

        private void Button_Form3_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DBClass.excuteCommand("DELETE FROM SINH_VIEN WHERE MaSinhVien = '" + MaSVTxt2.Text + "'");
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
            OleDbDataReader reader = DBClass.queryAsDatareader("SELECT * FROM SINH_VIEN WHERE `MaSinhVien` = '" + ChangedData[0].ToString() + "'");

            while (reader.Read())
            {
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
