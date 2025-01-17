using System;
using CommunityToolkit.Mvvm.ComponentModel;

namespace DeepFocus.Models
{
    public partial class PomodoroSession : ObservableObject
    {
        [ObservableProperty]
        private int duration;

        [ObservableProperty]
        private DateTime startTime;

        [ObservableProperty]
        private DateTime? endTime;

        [ObservableProperty]
        private bool isCompleted;

        [ObservableProperty]
        private SessionType sessionType;

        public PomodoroSession(int duration, SessionType sessionType)
        {
            this.duration = duration;
            this.sessionType = sessionType;
            startTime = DateTime.Now;
            isCompleted = false;
        }
    }

    public enum SessionType
    {
        Focus,
        ShortBreak,
        LongBreak
    }
}