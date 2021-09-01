using System;
using System.Collections.Generic;
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
using System.Data;

namespace Windows_Programming_Exercises.Views
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : UserControl
    {
        public Page1()
        {
            InitializeComponent();

            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:/Users/profi/Desktop/DataKTHT.mdb";
            conn.Open();

            OleDbDataAdapter ad = new OleDbDataAdapter("SELECT `MaLop` FROM LOP", conn);

            DataTable dataTable = new DataTable();
            ad.Fill(dataTable);

            Combobox1.ItemsSource = dataTable.DefaultView;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:/Users/profi/Desktop/DataKTHT.mdb";
            conn.Open();

            OleDbDataAdapter ad = new OleDbDataAdapter("SELECT * FROM SINH_VIEN", conn);

            DataTable dataTable = new DataTable();
            ad.Fill(dataTable);

            Table1.ItemsSource = dataTable.DefaultView;
            Table1.Columns[0].Header = "Mã Sinh Viên";
            Table1.Columns[1].Header = "Họ đệm";
            Table1.Columns[2].Header = "Tên";
            Table1.Columns[3].Header = "Ngày sinh";
            Table1.Columns[4].Header = "Giới tính";
            Table1.Columns[5].Header = "Mã lớp";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:/Users/profi/Desktop/DataKTHT.mdb";
            conn.Open();

            OleDbDataAdapter ad = new OleDbDataAdapter("SELECT * FROM LOP", conn);

            DataTable dataTable = new DataTable();
            ad.Fill(dataTable);

            Table1.ItemsSource = dataTable.DefaultView;
            Table1.Columns[0].Header = "Mã Lớp";
            Table1.Columns[1].Header = "Tên lớp";
            Table1.Columns[2].Header = "Năm vào";
            Table1.Columns[3].Header = "Khoa";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            String dvht = SoDVHT.Text;

            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:/Users/profi/Desktop/DataKTHT.mdb";
            conn.Open();

            OleDbDataAdapter ad = new OleDbDataAdapter("SELECT * FROM MON_HOC WHERE SoDVHT >= " + dvht, conn);

            DataTable dataTable = new DataTable();
            ad.Fill(dataTable);

            Table1.ItemsSource = dataTable.DefaultView;
            Table1.Columns[0].Header = "Mã Môn";
            Table1.Columns[1].Header = "Tên môn";
            Table1.Columns[2].Header = "Số DVHT";
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            String maLop = Combobox1.Text;

            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:/Users/profi/Desktop/DataKTHT.mdb";
            conn.Open();

            OleDbDataAdapter ad = new OleDbDataAdapter("SELECT * FROM SINH_VIEN WHERE MaLop = '" + maLop + "'", conn);

            DataTable dataTable = new DataTable();
            ad.Fill(dataTable);

            Table1.ItemsSource = dataTable.DefaultView;
            Table1.Columns[0].Header = "Mã Sinh Viên";
            Table1.Columns[1].Header = "Họ đệm";
            Table1.Columns[2].Header = "Tên";
            Table1.Columns[3].Header = "Ngày sinh";
            Table1.Columns[4].Header = "Giới tính";
            Table1.Columns[5].Header = "Mã lớp";
        }
    }
}
