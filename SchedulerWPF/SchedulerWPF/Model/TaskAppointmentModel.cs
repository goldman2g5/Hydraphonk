using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using Syncfusion.UI.Xaml.Scheduler;

namespace WpfScheduler.Model
{
    public class TaskAppointmentModel : ScheduleAppointment
    {

        public string Field { get; set; }
        public string TaskType { get; set; }
        public string Task { get; set; }

        public string EmployeeTitle { get; set; }

        public string Employee { get; set; }

        public string MachineryType { get; set; }
        public string Machinery { get; set; }

        public ScheduleAppointment ToScheduleAppointment()
        {
            ScheduleAppointment appointment = new ScheduleAppointment();
            appointment.Subject = this.Subject;
            appointment.StartTime = this.StartTime;
            appointment.EndTime = this.EndTime;
            appointment.IsAllDay = this.IsAllDay;
            appointment.Notes = this.Notes;
            return appointment;
        }



    }
}
