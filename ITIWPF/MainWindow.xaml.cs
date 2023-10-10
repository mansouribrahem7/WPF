using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
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

namespace ITIWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window,INotifyPropertyChanged
    {
        int _count;

        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnPropertyChanged(string prop)
        {
            PropertyChanged?.Invoke(this,new PropertyChangedEventArgs(prop));
        }

        public int Count
        {

            get
            {
                return _count;
            }

            set
            {
                if (_count!=value)
                {
                    _count = value;
                    OnPropertyChanged("Count");


                }
            }
        }
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        private void changeCount(object sender, RoutedEventArgs e)
        {
            Count++;
        }
    }
}
