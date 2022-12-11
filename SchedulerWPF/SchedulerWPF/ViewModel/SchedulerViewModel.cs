using Syncfusion.UI.Xaml.Scheduler;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace WpfScheduler
{
    public class SchedulerViewModel : INotifyPropertyChanged
    {
        private ScheduleAppointmentCollection scheduleAppointmentCollection; 
        public SchedulerViewModel()
        {
            ScheduleAppointmentCollection = new ScheduleAppointmentCollection();
            ScheduleAppointmentCollection.Add(new ScheduleAppointment()
            {
                
            });
        }
        public ScheduleAppointmentCollection ScheduleAppointmentCollection
        {
            get
            {
                return this.scheduleAppointmentCollection;
            }

            set
            {
                this.scheduleAppointmentCollection = value;
                this.RaiseOnPropertyChanged("ScheduleAppointmentCollection");
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        private void RaiseOnPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
   