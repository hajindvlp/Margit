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
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Render()
        {
            string InputContent = InputTb.Text;
            string HtmlContent = MarkdownRender.Md2HTML(InputContent);

            if (RenderWb != null)
                RenderWb.NavigateToString(HtmlContent);
        }

        private void inputTextChangedEventHandler(object sender, TextChangedEventArgs args)
        {
            Render();
        }

        private void RenderWbNavigating(object sender, NavigatingCancelEventArgs e)
        {
            if (e.Uri != null)
                Render();
        }
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
                InputTb.Text = File.ReadAllText(openFileDialog.FileName);
        }

        private void SaveContent(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Markdown file (*.md)|*.md"
            };
            if (saveFileDialog.ShowDialog() == true)
                File.WriteAllText(saveFileDialog.FileName, InputTb.Text);
        }

        private void ExitClicked(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void SaveAsContent(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Markdown file (*.md)|*.md";
            if (saveFileDialog.ShowDialog() == true)
                File.WriteAllText(saveFileDialog.FileName, InputTb.Text);
        }
    }
}
