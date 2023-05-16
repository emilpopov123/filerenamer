using Microsoft.Win32;
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
using Ookii.Dialogs.Wpf;



namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainBtn_Click(object sender, RoutedEventArgs e)
        {

            if (directoryText.Text != "" && searchVal.Text != "" && replaceVal.Text != "")
            {
                DirectoryInfo directory = new DirectoryInfo(directoryText.Text);
                MessageBox.Show(directory.ToString());
                foreach (var file in directory.GetFiles("*.jpg"))
                {
                    //Console.WriteLine(file);
                    if (file.Name.Contains(searchVal.Text))
                    {
                        File.Move(file.FullName, directory + "\\" + file.Name.Replace(searchVal.Text, replaceVal.Text));
                    }
                }
                MessageBox.Show("Dateien umbenannt");
            }
            else {
                MessageBox.Show("Textfelder nicht gefüllt");
            }
        }

        private void DirectoryBtn_Click(object sender, RoutedEventArgs e) {

            VistaFolderBrowserDialog dlg = new VistaFolderBrowserDialog();

            if (dlg.ShowDialog() ?? false)
            {
                directoryText.Text = dlg.SelectedPath;
            }
        }
    }
}
