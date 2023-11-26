using System;
using System.Windows.Forms;

namespace RecipeManager
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

            MinutesLabel.Text = Time.Minutes.ToString() + " " + MinutesLabel.Tag.ToString();
            HoursLabel.Text = Time.Hours.ToString() + " " + HoursLabel.Tag.ToString();
            DaysLabel.Text = Time.Days.ToString() + " " + DaysLabel.Tag.ToString();

            return Time;
        }
        public void Update_Times()
        {
            TimeSpan PrepTimeSpan = Update_TimeSpan(MF.PrepTimeGroup);
            TimeSpan CookTimeSpan = Update_TimeSpan(MF.CookTimeGroup);
            TimeSpan TotalTimeSpan = PrepTimeSpan + CookTimeSpan;
            MF.TotalTime.Text = Format_Total_Time(TotalTimeSpan);
        }
        public string Format_Total_Time(TimeSpan TotalTimeSpan)
        {
            string FormattedTimeSpan = "";

            FormattedTimeSpan += $"{TotalTimeSpan.Days} Days ";
            FormattedTimeSpan += $"{TotalTimeSpan.Hours} Hours ";
            FormattedTimeSpan += $"{TotalTimeSpan.Minutes} Minutes";

            return FormattedTimeSpan;
        }
    }
}