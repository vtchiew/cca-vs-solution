using EO.Pdf;
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


namespace CCA.POC.PDFForm
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

        private void btnGenerate_Click(object sender, RoutedEventArgs e)
        {
            PdfDocument doc = new PdfDocument("sample.pdf");

            PdfField field = doc.Fields["PatientName"];
            field.Value = string.IsNullOrEmpty(txtUserFullName.Text.Trim())?"(No name)":txtUserFullName.Text.Trim();

            PdfField field2 = doc.Fields["Age"];
            field2.Value = string.IsNullOrEmpty(txtAge.Text.Trim()) ? "--" : txtAge.Text.Trim(); ;

            var fileName = DateTime.Now.Ticks.ToString() + ".pdf";
            doc.Save(fileName);

            System.Diagnostics.Process.Start(fileName);
        }
    }
}
