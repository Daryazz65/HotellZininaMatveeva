using HotellZininaMatveeva.Model;
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

namespace HotellZininaMatveeva.View.Page
{
    /// <summary>
    /// Логика взаимодействия для ComnatPage.xaml
    /// </summary>
    public partial class ComnatPage : System.Windows.Controls.Page
    {
        List<Status> statuses = App.context.Status.ToList();
        public ComnatPage()
        {
            InitializeComponent();
            // выгрузка из бд---.
            RoomcLb.ItemsSource = App.context.Room.ToList();
            //---.

            statuses.Insert(0, new Status() { Name = "Все статусы" });
            FilterByCategoryCmb.ItemsSource = statuses;
            FilterByCategoryCmb.DisplayMemberPath = "Name";
            FilterByCategoryCmb.SelectedValuePath = "Id";
            FilterByCategoryCmb.SelectedIndex = 0;
        }

        private void SearchTb_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (SearchTb.Text != string.Empty)
            {
                int roomNumber = Convert.ToInt32(SearchTb.Text);
                RoomcLb.ItemsSource = App.context.Room.Where(r => r.Number == roomNumber).ToList();
            }
            else
            {
                RoomcLb.ItemsSource = App.context.Room.ToList();
            }
        }

        private void FilterByCategoryCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (FilterByCategoryCmb.SelectedIndex != 0)
            {
                RoomcLb.ItemsSource = App.context.Room.Where(r => r.StatusId == FilterByCategoryCmb.SelectedIndex).ToList();
            }
            else
            {
                RoomcLb.ItemsSource = App.context.Room.ToList();
            }
        }

        private void RoomcLb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
