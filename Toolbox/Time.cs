using System;
using System.Windows.Forms;

namespace Recipsio
{
    public partial class Toolbox
    {
        public TimeSpan Update_TimeSpan(GroupBox TimeGroupBox)
        {
            Label DaysLabel = (Label)TimeGroupBox.Controls[0];
            Label HoursLabel = (Label)TimeGroupBox.Controls[1];
            Label MinutesLabel = (Label)TimeGroupBox.Controls[2];

            int Days = Convert.ToInt32(DaysLabel.Text.Split(" ")[0]);
            int Hours = Convert.ToInt32(HoursLabel.Text.Split(" ")[0]);
            int Minutes = Convert.ToInt32(MinutesLabel.Text.Split(" ")[0]);

            TimeSpan Time = new(Days, Hours, Minutes, 0);

            if (Time.Days == 1)
            {
                DaysLabel.Text = Time.Days.ToString() + " Day ";
            }
            else
            {
                DaysLabel.Text = Time.Days.ToString() + " Days ";
            }

            if (Time.Hours == 1)
            {
                HoursLabel.Text = Time.Hours.ToString() + " Hour ";
            }
            else
            {
                HoursLabel.Text = Time.Hours.ToString() + " Hours ";
            }

            if (Time.Minutes == 1)
            {
                MinutesLabel.Text = Time.Minutes.ToString() + " Minute";
            }
            else
            {
                MinutesLabel.Text = Time.Minutes.ToString() + " Minutes";
            }

            return Time;
        }
        public void Update_Times()
        {
            TimeSpan PrepTimeSpan = Update_TimeSpan(MF.PrepTime);
            TimeSpan CookTimeSpan = Update_TimeSpan(MF.CookTime);
            TimeSpan TotalTimeSpan = PrepTimeSpan + CookTimeSpan;
            MF.TotalTimeValue.Text = Format_Total_Time(TotalTimeSpan);
        }
        public string Format_Total_Time(TimeSpan TotalTimeSpan)
        {
            string FormattedTimeSpan = "";

            if (TotalTimeSpan.Days == 1)
            {
                FormattedTimeSpan += $"{TotalTimeSpan.Days} Day ";
            }
            else
            {
                FormattedTimeSpan += $"{TotalTimeSpan.Days} Days ";
            }

            if (TotalTimeSpan.Hours == 1)
            {
                FormattedTimeSpan += $"{TotalTimeSpan.Hours} Hour ";
            }
            else
            {
                FormattedTimeSpan += $"{TotalTimeSpan.Hours} Hours ";
            }

            if (TotalTimeSpan.Minutes == 1)
            {
                FormattedTimeSpan += $"{TotalTimeSpan.Minutes} Minute";
            }
            else
            {
                FormattedTimeSpan += $"{TotalTimeSpan.Minutes} Minutes";
            }

            return FormattedTimeSpan;
        }
    }
}