using System;
using System.Collections;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Microsoft.Samples.Kinect.BodyBasics
{
    public partial class CurrentExercise : Page
    {
        public CurrentExercise()
        {
                
            InitializeComponent();
            Grid g = (Grid)FindName("Ugh");
            TextBlock tb = new TextBlock();
            tb.Inlines.Add("Sup");
            this.Content = tb;
        }
        private StackPanel stackPanel;
        public string exercise; 
        public CurrentExercise(String exercise)
        {
            //<TextBlock Text = "LOWER BODY WORKOUTS" HorizontalAlignment="Center" VerticalAlignment="TOP" FontSize="24"> </TextBlock>
            InitializeComponent();
            Grid g = (Grid)FindName("Ugh");
            TextBlock tb = new TextBlock();
            tb.Inlines.Add(exercise);
            tb.HorizontalAlignment = HorizontalAlignment.Center;
            tb.VerticalAlignment = VerticalAlignment.Top;
            tb.FontSize = 24;
            stackPanel = new StackPanel();
            stackPanel.Children.Add(tb);
            ProgressBar pb = new ProgressBar();
            pb.Value = 50;
            pb.Foreground = Brushes.Yellow;
            stackPanel.Children.Add(pb);
            this.Content = stackPanel;
            this.exercise = exercise;
        }

        public void ChangeBar(float num)
        {
            ProgressBar pb = (ProgressBar)stackPanel.Children[1];
                if (num < 50)
                {
                    double scaledNum = (num * 1.0 / 50) * 255;
                    byte floored = (byte)scaledNum;
                    pb.Foreground = new SolidColorBrush(Color.FromRgb(255, floored, 0));

                }
                else if (num > 50)
                {
                    double scaledNum = 255 - ((num * 1.0 / 50) * 255);
                    byte floored = (byte)scaledNum;

                    pb.Foreground = new SolidColorBrush(Color.FromRgb(floored, 255, 0));
                }
                else
                {
                    pb.Foreground = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                }

                pb.Value = num;
        }
        
        public void IncrementBar()
        {
            ProgressBar pb = (ProgressBar)stackPanel.Children[1];
            double num = pb.Value;
            num = num + 1;
            if(num > 100)
            {
                num = 100;
            }
            if (num < 50)
            {
                double scaledNum = (num * 1.0 / 50) * 255;
                byte floored = (byte)scaledNum;
                pb.Foreground = new SolidColorBrush(Color.FromRgb(255, floored, 0));

            }
            else if (num > 50)
            {
                double scaledNum = 255 - ((num * 1.0 / 50) * 255);
                byte floored = (byte)scaledNum;

                pb.Foreground = new SolidColorBrush(Color.FromRgb(floored, 255, 0));
            }
            else
            {
                pb.Foreground = new SolidColorBrush(Color.FromRgb(255, 255, 0));
            }
            pb.Value = num;
        }
        
        public void DecrementBar()
        {
            ProgressBar pb = (ProgressBar)stackPanel.Children[1];
            double num = pb.Value;
            num = num - 1;
            if (num < 0)
            {
                num = 0;
            }
            if (num < 50)
            {
                double scaledNum = (num * 1.0 / 50) * 255;
                byte floored = (byte)scaledNum;
                pb.Foreground = new SolidColorBrush(Color.FromRgb(255, floored, 0));

            }
            else if (num > 50)
            {
                double scaledNum = 255 - ((num * 1.0 / 50) * 255);
                byte floored = (byte)scaledNum;

                pb.Foreground = new SolidColorBrush(Color.FromRgb(floored, 255, 0));
            }
            else
            {
                pb.Foreground = new SolidColorBrush(Color.FromRgb(255, 255, 0));
            }
            pb.Value = num;
        }
        
    }
}