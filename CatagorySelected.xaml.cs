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

namespace Register
{
    /// <summary>
    /// Interaction logic for CatagorySelected.xaml
    /// </summary>
    public partial class CatagorySelected : Window
    {
        public CatagorySelected()
        {
            InitializeComponent();
            string SQL = "SELECT * FROM MOCK_DATA;";
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
