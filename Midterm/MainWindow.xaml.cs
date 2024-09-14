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

namespace Midterm
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

        private void btnPage1_Click(object sender, RoutedEventArgs e)
        {
            tc.SelectedItem = ti2;
        }

        private void chkPage1_Click(object sender, RoutedEventArgs e)
        {
            if (chkPage1.IsChecked == true)
            {
                lblCheckbox.Content = "CheckBox Checked";
            } else
            {
                lblCheckbox.Content = "CheckBox Not Checked";
            }
        }

        private void txtPage1_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            switch (e.Key.ToString())
            {
                case "Q":
                case "Y":
                case "Z":
                case "q":
                case "y":
                case "z":
                    e.Handled = true;
                    break;
            }
            
        }

        private void txtPage1_KeyUp(object sender, KeyEventArgs e)
        {
            lblTextbox.Content = txtPage1.Text;
        }

        private void expSlider_Expanded(object sender, RoutedEventArgs e)
        {
            expImage.IsExpanded = false;
        }

        private void expImage_Expanded(object sender, RoutedEventArgs e)
        {
            expSlider.IsExpanded = false;
        }

        private void slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lblSlider.Content = "Value: " + Math.Round(slider.Value, 1).ToString();
        }

        private void btnParent_Click(object sender, RoutedEventArgs e)
        {
            
            foreach (Window win in Application.Current.Windows)
            {
                if (win.Title.Equals("ParentWindow"))
                {
                    MessageBox.Show("Parent window already exists!", "Parent Window Exists", MessageBoxButton.OK);
                    return;
                }
                
            }

            ParentWindow p = new ParentWindow();
            p.Show();

        }

        private void btnChild_Click(object sender, RoutedEventArgs e)
        {
            bool isParent = false;
            foreach (Window win in Application.Current.Windows)
            {
                if (win.Title.Equals("ChildWindow"))
                {
                    MessageBox.Show("Child window already exists!", "Parent Window Exists", MessageBoxButton.OK);
                    return;
                } else if(win.Title.Equals("ParentWindow"))
                {
                    isParent = true;
                }

            }

            if(!isParent) 
            {
                MessageBox.Show("Child window already exists!", "Parent Window Exists", MessageBoxButton.OK);
                return;
            }
            ChildWindow c = new ChildWindow();
            c.Show();
        }

        private void img_MouseEnter(object sender, MouseEventArgs e)
        {
            if (Width >= img.ActualWidth)
            {
                img.Stretch = Stretch.UniformToFill;
                img.StretchDirection = StretchDirection.UpOnly;
            }
            else
            {
                img.Stretch = Stretch.Uniform;
            }
        }

        private void img_MouseLeave(object sender, MouseEventArgs e)
        {
            if(Height >= img.ActualHeight)
            {
                img.Stretch = Stretch.UniformToFill;
                img.StretchDirection = StretchDirection.UpOnly;
            } else
            {
                img.Stretch = Stretch.Uniform;
            }
        }
    }
}
