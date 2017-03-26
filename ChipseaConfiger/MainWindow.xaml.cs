using System;
using System.Collections.Generic;
using System.Data;
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

namespace ChipseaConfiger
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            TextEditorLeft.ShowLineNumbers = true;
            TextEditorRight.ShowLineNumbers = true;
            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
        }
        private void ToggleLayout(object sender, RoutedEventArgs e) {

            if (this.GridPanel.ColumnDefinitions.Count > 1)
            {
                this.GridPanel.ColumnDefinitions.Remove(ColumnRight);
            }
            else {
                this.GridPanel.ColumnDefinitions.Add(ColumnRight);
            }
        }
        private void ToggleStatusBar(object sender, RoutedEventArgs e) {
            if (this.GridWindow.RowDefinitions.Contains(RowStatusBar))
            {
                this.GridWindow.RowDefinitions.Remove(RowStatusBar);
            }
            else {
                this.GridWindow.RowDefinitions.Add(RowStatusBar);
            }
        }
        private void ToggleShowWordWrap(object sender, RoutedEventArgs e) {
            if (TextEditorLeft.WordWrap)
            {
                TextEditorLeft.WordWrap = false;
                TextEditorRight.WordWrap = false;
            }
            else
            {
                TextEditorLeft.WordWrap = true;
                TextEditorRight.WordWrap = true;
            }


        }
        private void ToggleShowLineNumber(object sender, RoutedEventArgs e) {

            if (TextEditorLeft.ShowLineNumbers)
            {
                TextEditorLeft.ShowLineNumbers = false;
                TextEditorRight.ShowLineNumbers = false;
            }
            else {
                TextEditorLeft.ShowLineNumbers = true;
                TextEditorRight.ShowLineNumbers = true;
            }

        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
