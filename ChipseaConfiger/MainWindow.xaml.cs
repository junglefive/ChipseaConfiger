using ICSharpCode.AvalonEdit.Highlighting;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
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
using System.Xml;

namespace ChipseaConfiger
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {

        IHighlightingDefinition chipseaAssemblyHighlighting;
        public MainWindow()
        {
           
            InitializeComponent();
            IHighlightingDefinition highlighting = UserHighlightInitiate();
            TextEditorLeft.FontFamily = new FontFamily("consolas");
            TextEditorLeft.FontSize = 15;
            TextEditorLeft.SyntaxHighlighting = highlighting;
            TextEditorRight.SyntaxHighlighting = highlighting;
            TextEditorRight = TextEditorLeft;
            //layout
            TextEditorLeft.Padding = new Thickness(4);
            TextEditorRight.Padding = new Thickness(4);


        }
        private IHighlightingDefinition UserHighlightInitiate() {

            // Load our custom highlighting definition
           
            using (Stream s = Assembly.GetExecutingAssembly().GetManifestResourceStream("ChipseaConfiger.Highlighting.ChipseaAssemblyHighlighting.xshd"))
            {
                if (s == null)
                    throw new InvalidOperationException("Could not find embedded resource");
                using (XmlReader reader = new XmlTextReader(s))
                {
                    chipseaAssemblyHighlighting = ICSharpCode.AvalonEdit.Highlighting.Xshd.HighlightingLoader.Load(reader, HighlightingManager.Instance);
                }
            }
            // and register it in the HighlightingManager
            HighlightingManager.Instance.RegisterHighlighting("ChipseaAssembly Highlighting", new string[] { ".asm","inc" }, chipseaAssemblyHighlighting);
            return chipseaAssemblyHighlighting;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        private void NewViewIntoFileOnClick(object sender, RoutedEventArgs e)
        {
            TextEditorRight = TextEditorLeft;

        }
        private void ItemSchemeOnClick(object sender, RoutedEventArgs e) {
            if (ItemScheme.IsChecked)
            {
                ItemScheme.IsChecked = false;
                BrushConverter brushConverter = new BrushConverter();
                TextEditorLeft.Background =(Brush)brushConverter.ConvertFromString("#FFFFFF");
                TextEditorRight.Background = (Brush)brushConverter.ConvertFromString("#FFFFFF");
                TextEditorLeft.Foreground = (Brush)brushConverter.ConvertFromString("#000000");
                TextEditorRight.Foreground = (Brush)brushConverter.ConvertFromString("#000000");
            }
            else {

                ItemScheme.IsChecked = true;
                BrushConverter brushConverter = new BrushConverter();
                TextEditorLeft.Background = (Brush)brushConverter.ConvertFromString("#272822");
                TextEditorRight.Background = (Brush)brushConverter.ConvertFromString("#272822");
                TextEditorLeft.Foreground = (Brush)brushConverter.ConvertFromString("#FFFACD");
                TextEditorRight.Foreground = (Brush)brushConverter.ConvertFromString("#FFFACD");


            }

            
        }

        private void NewFileClick(object sender, RoutedEventArgs e)
        {
            try
            {
                Uri uri = new Uri("sys_init.asm", UriKind.Relative);
                FileStream fs = File.Open(uri.ToString(), FileMode.OpenOrCreate);
                TextEditorLeft.Load(fs);
                //TextEditorLeft.
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine(uri.ToString());
                TextEditorLeft.Load(fs);
                TextEditorRight.Load(fs);
            }
            catch (Exception ex){
                Console.WriteLine("New file fail."+ex.ToString());
            }
           
           
        }
        private void ChooseOptionTextEditor(object sender, RoutedEventArgs e) {
            

        }
        private void SaveFileClick(object sender, RoutedEventArgs e)
        {
            if (currentFileName == null)
            {
                SaveFileDialog dlg = new SaveFileDialog();
                dlg.DefaultExt = ".asm";
                if (dlg.ShowDialog() ?? false)
                {
                    currentFileName = dlg.FileName;
                }
                else
                {
                    return;
                }
            }
            TextEditorLeft.Save(currentFileName);

        }
        string currentFileName;
        private void OpenFileClick(object sender, RoutedEventArgs e) {

            OpenFileDialog dlg = new OpenFileDialog();
            dlg.CheckFileExists = true;
            if (dlg.ShowDialog() ?? false)
            {
                currentFileName = dlg.FileName;
                TextEditorLeft.Load(currentFileName);
                TextEditorRight.Load(currentFileName);
                TextEditorLeft.SyntaxHighlighting = HighlightingManager.Instance.GetDefinitionByExtension(System.IO.Path.GetExtension(currentFileName));
                TextEditorRight.SyntaxHighlighting = HighlightingManager.Instance.GetDefinitionByExtension(System.IO.Path.GetExtension(currentFileName));
            }

        }
        private void ToggleLayout(object sender, RoutedEventArgs e) {

            if (LayoutSingleItem.IsChecked==false)
            {
                this.GridPanel.ColumnDefinitions.Remove(ColumnRight);
                LayoutSingleItem.IsChecked = true;
            }
            else {
                this.GridPanel.ColumnDefinitions.Add(ColumnRight);
                LayoutSingleItem.IsChecked = false;
                ColumnRight.Width = ColumnLeft.Width;
            }
        }
        private void ToggleStatusBar(object sender, RoutedEventArgs e) {
            if (StatusBarItem.IsChecked) {
                RowStatusBar.Height = new GridLength(0);
                StatusBarItem.IsChecked = false;
            }
            else{
                StatusBarItem.IsChecked = true;
                RowStatusBar.Height = new GridLength(20);
            }
            
        }
        private void ToggleShowWordWrap(object sender, RoutedEventArgs e) {
            if (TextEditorLeft.WordWrap)
            {
                TextEditorLeft.WordWrap = false;
                TextEditorRight.WordWrap = false;
                WordWrapItem.IsChecked = false;
            }
            else
            {
                TextEditorLeft.WordWrap = true;
                TextEditorRight.WordWrap = true;
                WordWrapItem.IsChecked = true;
            }


        }
        private void ToggleShowLineNumber(object sender, RoutedEventArgs e) {

            if (TextEditorLeft.ShowLineNumbers)
            {
                TextEditorLeft.ShowLineNumbers = false;
                TextEditorRight.ShowLineNumbers = false;
                LineNumberItem.IsChecked = false;
            }
            else {
                TextEditorLeft.ShowLineNumbers = true;
                TextEditorRight.ShowLineNumbers = true;
                LineNumberItem.IsChecked = true;
            }

        }
    }
}
