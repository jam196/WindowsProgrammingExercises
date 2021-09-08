using System.Windows;
using System.Windows.Input;

namespace Windows_Programming_Exercises
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            MouseDown += Window_MouseDown;
        }

        private void MainWindow_OnLoaded(object sender, RoutedEventArgs e)
        {
            RenderPages.Children.Add(new Dashboard());
        }

        private void CloseButton_OnClick(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                DragMove();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            RenderPages.Children.Clear();
            RenderPages.Children.Add(new Views.Page1());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            RenderPages.Children.Clear();
            RenderPages.Children.Add(new Views.Page2());
        }
    }
}