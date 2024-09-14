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

namespace Midterm
{
    /// <summary>
    /// Interaction logic for ParentWindow.xaml
    /// </summary>
    public partial class ParentWindow : Window
    {
        public ParentWindow()
        {
            InitializeComponent();
        }

        private void btnSpawnChild_Click(object sender, RoutedEventArgs e)
        {
            foreach (Window win in Application.Current.Windows)
            {
                if (win.Title.Equals("ChildWindow"))
                {
                    MessageBox.Show("Child window already exists!", "Parent Window Exists", MessageBoxButton.OK);
                    return;
                }
            }
            ChildWindow c = new ChildWindow();
            c.Show();
        }
    }
}
