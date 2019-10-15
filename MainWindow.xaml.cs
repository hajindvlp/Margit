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
using System.Diagnostics;
using Microsoft.Win32;
using System.IO;

namespace Margit
{
    public partial class MainWindow : Window
    {
        public bool isDark = false;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Render()
        {
            string InputContent = InputTb.Text;
            string HtmlContent = MarkdownRender.Md2HTML(InputContent, isDark);

            if (RenderWb != null)
            {
                RenderWb.NavigateToString(HtmlContent);
            }
        }

        private void inputTextChangedEventHandler(object sender, TextChangedEventArgs args) => Render();

        private void RenderWbNavigating(object sender, NavigatingCancelEventArgs e)
        {
            if (e.Uri != null)
                Render();
        }

        private bool ContentOpened = false;
        private string ContentDir;
        private void NewContent(object sender, RoutedEventArgs e)
        {
            var newWindow = new MainWindow();
            newWindow.Show();
        }

        private void OpenContent(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Markdown file (*.md)|*.md"
            };
            if (openFileDialog.ShowDialog() == true)
            {
                InputTb.Text = File.ReadAllText(openFileDialog.FileName);
                ContentOpened = true;
                ContentDir = openFileDialog.FileName;
            }
        }

        private void SaveContent(object sender, RoutedEventArgs e)
        {
            if(ContentOpened)
            {
                File.WriteAllText(ContentDir, InputTb.Text);
            }
            else
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "Markdown file (*.md)|*.md"
                };
                if (saveFileDialog.ShowDialog() == true)
                    File.WriteAllText(saveFileDialog.FileName, InputTb.Text);
            }
        }

        private void ExitClicked(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void SaveAsContent(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Markdown file (*.md)|*.md"
            };
            if (saveFileDialog.ShowDialog() == true)
                File.WriteAllText(saveFileDialog.FileName, InputTb.Text);
        }

        private void CheckDarkTheme(object sender, RoutedEventArgs e)
        {
            MainGrid.Background = InputTb.Background = new SolidColorBrush(Color.FromRgb(18, 18, 18));
            InputTb.Foreground = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            isDark = true;
            Render();
        }

        private void UnCheckDarkTheme(object sender, RoutedEventArgs e)
        {
            MainGrid.Background = InputTb.Background = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            InputTb.Foreground = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            isDark = false;
            Render();
        }
    }
}
