using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace AddNewRaschetBenzina
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }
        private ObservableCollection<Toplivo> top1;
        private void btnAddNewToplivoClick(object sender, RoutedEventArgs e)
        {
            double Vtopliva = Convert.ToDouble(V.Text);
            double Ptopliva = Convert.ToDouble(P.Text);

            top1 = new ObservableCollection<Toplivo>()
            {
                new Toplivo() {V =  Vtopliva, P =  Ptopliva},
            };
            DG.Items.Add(top1);


        }
    }
}
