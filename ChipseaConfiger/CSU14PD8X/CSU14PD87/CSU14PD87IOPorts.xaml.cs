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
    /// Interaction logic for SubWindowIOPortsSetting.xaml
    /// </summary>
    public partial class CSU14PD87IOPorts : Window
    {
        public CSU14PD87IOPorts()
        {
            InitializeComponent();
        }
        public delegate void SubWindowEventHander(object sender, ChipseaEventArgs e);
        public event SubWindowEventHander subWindChange;
        private void OnsubWindowChanging(ChipseaEventArgs csEvent) {
            subWindChange?.Invoke(this, csEvent);
        }

        //private void button_Click(object sender, RoutedEventArgs e)
        //{
        //    OnsubWindowChanging(new ChipseaEventArgs("jh", 0328));
        //}
    }
}
