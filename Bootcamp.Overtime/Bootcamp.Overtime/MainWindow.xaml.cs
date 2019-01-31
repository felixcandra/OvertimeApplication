using Overtime.BusinessLogic.Services.Master;
using Overtime.DataAccess.Model;
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

namespace Bootcamp.Overtime
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MyContex _context = new MyContex();
        iPositionService _positionService = new PositionService();
        public MainWindow()
        {
            // 
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            dataGrid1.ItemsSource = _context.Position.Where(x => x.isDelete == false).ToList();
        }

        private void buttonInsertPosition_Click(object sender, RoutedEventArgs e)
        {
            new PopUpInsertPosition().Show();
            this.Hide();
        }

        private void buttonUpdatePosition_Click(object sender, RoutedEventArgs e)
        {
            PopUpUpdatePosition popUpUpdatepos = new PopUpUpdatePosition();
            object items = dataGrid1.SelectedItem;
            if (items == null)
            {
                MessageBox.Show("No Data selected for updating");
            }
            else
            {
                popUpUpdatepos.idtextBox.Text = (dataGrid1.SelectedCells[0].Column.GetCellContent(items) as TextBlock).Text;
                popUpUpdatepos.textBoxPosition.Text = (dataGrid1.SelectedCells[1].Column.GetCellContent(items) as TextBlock).Text;
                popUpUpdatepos.Show();
                this.Hide();
            }
           
            //new PopUpUpdatePosition().Show();
        }

        private void buttonDeletePosition_Click(object sender, RoutedEventArgs e)
        {
            object items = dataGrid1.SelectedItem;

            if (items == null)
            {
                MessageBox.Show("No Data Selected to Delete");
            }
            else
            {

                MessageBoxResult result = MessageBox.Show("Are You Sure to Delete this Position ?", "WARNING", MessageBoxButton.YesNo);
                if (result == MessageBoxResult.Yes)
                {

                    int id = Convert.ToInt16((dataGrid1.SelectedCells[0].Column.GetCellContent(items) as TextBlock).Text);
                    _positionService.delete(id);
                    dataGrid1.ItemsSource = _positionService.Get();

                }
            }
         
            //new PopUpDeletePosition().Show();
        }

        private void buttonRefresh_Click(object sender, RoutedEventArgs e)
        {

            dataGrid1.ItemsSource = _context.Position.Where(x => x.isDelete == false).ToList();
        }

        private void buttonSearch_Click(object sender, RoutedEventArgs e)
        {
            dataGrid1.ItemsSource = _positionService.Search(textBoxSearch.Text, SearchComboBox.Text);
        }

        private void tabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        public void LoadGrid()
        {
            dataGrid1.ItemsSource = _positionService.Get();
        }
    }
}
