using System;
using System.Collections.Generic;
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
        




    }
}
