using System;
using System.Collections.Generic;
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
using System.IO;
using Microsoft.Win32;

namespace p_20260108_ÁB
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
        public List<string> Tasklist = new List<string>();
        private void rogzit_Click(object sender, RoutedEventArgs e)
        {
            string fnv = "";
            Tasklist.Add(feladat.Text);
            //feladatok.Items.Add(rogzit.Content);
            //feladatok.ItemsSource = feladatok.Items;
            feladatok.ItemsSource = Tasklist;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.ShowDialog();
            FileStream f = new FileStream(saveFileDialog.FileName, FileMode.Create);
            StreamWriter ir = new StreamWriter(f);
            foreach (string item in Tasklist)
            {
                ir.WriteLine(item);
            }
            ir.Close();
            f.Close();
        }

        private void feladat_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
