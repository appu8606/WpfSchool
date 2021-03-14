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
using WpfSchool.Model;

namespace WpfSchool.Views
{
    /// <summary>
    /// Interaction logic for StudentView.xaml
    /// </summary>
    public partial class StudentView : UserControl
    {
        public StudentView()
        {
            InitializeComponent();
        }

        private void Expander_Expanded(object sender, RoutedEventArgs e)
        {
            DataGridRow row = FindVisualParent<DataGridRow>(sender as Expander);
            row.DetailsVisibility = Visibility.Visible;
        }

        private void Expander_Collapsed(object sender, RoutedEventArgs e)
        {
            DataGridRow row = FindVisualParent<DataGridRow>(sender as Expander);
            row.DetailsVisibility = Visibility.Collapsed;
        }

        public T FindVisualParent<T>(DependencyObject child) where T : DependencyObject
        {
            DependencyObject parentObject = VisualTreeHelper.GetParent(child);
            if (parentObject == null) return null;
            T parent = parentObject as T;
            if (parent != null)
                return parent;
            else
                return FindVisualParent<T>(parentObject);
        }


        private void DG_myStudents_RowDetailsVisibilityChanged(object sender, DataGridRowDetailsEventArgs e)
        {

            DataGrid MainDataGrid = sender as DataGrid;
            var cell = MainDataGrid.CurrentCell;

            Student student = (MainDataGrid.CurrentItem as Student);
            if (student == null)
            {
                return;
            }
            List<Details> DetailList = new List<Details>();
            DataGrid DetailsDataGrid = e.DetailsElement as DataGrid;

            DetailList.Add(new Details() { Subcode = student.details.Subcode, MySubject = student.details.MySubject, TotMarks = student.details.TotMarks });
            DetailsDataGrid.ItemsSource = DetailList;
        }


    }
}
