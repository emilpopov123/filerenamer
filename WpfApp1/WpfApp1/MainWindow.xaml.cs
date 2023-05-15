using System;
using System.Collections.Generic;
using System.IO;
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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static string directory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
        public static DirectoryInfo dInfo = new DirectoryInfo(directory);
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainBtn_Click(object sender, RoutedEventArgs e)
        {
            foreach (var file in dInfo.GetFiles("*.jpg"))
            {
                //Console.WriteLine(file);
                if (file.Name.Contains("Capture"))
                {
                    File.Move(file.FullName, directory + "\\" + file.Name.Replace("Capture", "img"));
                }
            }
            MessageBox.Show("Dateien umbenannt");
        }
    }
}
