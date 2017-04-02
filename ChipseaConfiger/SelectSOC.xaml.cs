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
using System.Windows.Shapes;

namespace ChipseaConfiger
{
    /// <summary>
    /// Interaction logic for SelectSOC.xaml
    /// </summary>
    public partial class SelectSOC : Window
    {
        public SelectSOC()
        {
            InitializeComponent();
        }
        //本文件用于实例化 ChipseaSOC.currentSoc
        private void CSU14PD87ItemSelected(object sender, RoutedEventArgs e) {

            ChipseaSOC.currentSoc = new CSU14PD87();
            this.Close();
            MessageBox.Show("Choosed CSU14PD87" ,"Tips");
        }

    }
}
