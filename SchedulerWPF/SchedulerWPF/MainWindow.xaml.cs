using Syncfusion.UI.Xaml.Scheduler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Syncfusion.Windows.Tools.Controls;
using WpfScheduler.Behavior;
using WpfScheduler.Model;
using WpfScheduler.ViewModel;
using System.Collections.ObjectModel;

namespace WpfScheduler
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void dataGrid_AddNewRowInitiating(object sender, Syncfusion.UI.Xaml.Grid.AddNewRowInitiatingEventArgs e)
        {

        }

        private void ButtonAdv_Click()
        {

        }

        private void TabItem_ContextMenuOpening(object sender, ContextMenuEventArgs e)
        {
            var scheduleAppointment = new TaskAppointmentModel();
            scheduleAppointment.Subject = "";
        }
    }
}
