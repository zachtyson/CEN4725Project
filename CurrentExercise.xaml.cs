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
            // counter label textBlock
            TextBlock tb3 = new TextBlock();
            tb3.Inlines.Add("COUNT");
            tb3.HorizontalAlignment = HorizontalAlignment.Left;
            tb3.VerticalAlignment = VerticalAlignment.Center;
            tb3.FontSize = 24;
            tb3.Margin = new Thickness(-1000, 75, 0, 0);

            // count textBlock

            TextBlock tb4 = new TextBlock();
            tb4.Text += 0;
            tb4.Inlines.Add(tb4.Text);
            tb4.HorizontalAlignment = HorizontalAlignment.Left;
            tb4.VerticalAlignment = VerticalAlignment.Center;
            tb4.FontSize = 24;
            tb4.Margin = new Thickness(-100, 100, 0, 0);

            Grid g = (Grid)FindName("Ugh");
            TextBlock tb = new TextBlock();
            tb.Inlines.Add(exercise);
            tb.HorizontalAlignment = HorizontalAlignment.Center;
            tb.VerticalAlignment = VerticalAlignment.Top;
            tb.FontSize = 24;
            stackPanel = new StackPanel();
          
            stackPanel.Children.Add(tb);
            ProgressBar pb = new ProgressBar();
            pb.Orientation = Orientation.Vertical;
            pb.Margin = new Thickness(0,0,-1000,-50);
            pb.Height = 800;
            pb.Width = 50;
            pb.Value = 50;
            //allow overflow
            pb.ClipToBounds = false;
            pb.Foreground = Brushes.Yellow;
            stackPanel.Children.Add(pb);
            TextBlock tb2 = new TextBlock();
            tb2.Inlines.Add("WAVE TO EXIT");
            tb2.HorizontalAlignment = HorizontalAlignment.Center;
            tb2.VerticalAlignment = VerticalAlignment.Bottom;
            tb2.FontSize = 24;
            tb2.Margin = new Thickness(0, 0, 0, -100);
            stackPanel.Children.Add(tb2);
            //stackPanel.Children.Add(tb3);
            //stackPanel.Children.Add(tb4);

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