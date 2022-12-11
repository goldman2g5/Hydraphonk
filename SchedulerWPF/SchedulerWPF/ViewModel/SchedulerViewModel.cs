using Syncfusion.UI.Xaml.Scheduler;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using WpfScheduler.Misc;
using WpfScheduler.Model;

namespace WpfScheduler
{
    public class SchedulerViewModel : INotifyPropertyChanged
    {
        private ScheduleAppointmentCollection scheduleAppointmentCollection;
        public ObservableCollection<ScheduleAppointment> Events
        {
            get;
            set;
        }



        public SchedulerViewModel()
        {
            this.Events = new ObservableCollection<ScheduleAppointment>();


            WeatherModel weather = WeatherProvider.GetRandomToday();

            ScheduleAppointmentCollection = new ScheduleAppointmentCollection();

            var scheduleAppointment = new ScheduleAppointment();


            scheduleAppointment.Subject = "";
            scheduleAppointment.StartTime = weather.from;
            scheduleAppointment.EndTime = weather.to;


            ScheduleAppointmentCollection.Add(new ScheduleAppointment()
            {
                StartTime = DateTime.Now,
                EndTime = DateTime.Now.AddHours(1),
                Subject = "Meeting",
                Location = "Hutchison road",
            });
            this.Events.Add(scheduleAppointment);
            MessageBox.Show("bebra");
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
   