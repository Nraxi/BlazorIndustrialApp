using System.Timers;

namespace BlazorIndustrialApp.Models
{
    public class Car
    {

        public string ?Title { get; set; }
        public string ?Model { get; set; }
        public bool IsToggled { get; set; }
        public bool IsStarted { get; set; }
        public TimeSpan ElapsedTime { get; set; } = TimeSpan.Zero;
        public System.Timers.Timer ?Timer { get; set; }

      
    }
}
