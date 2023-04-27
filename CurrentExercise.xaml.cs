﻿using System;
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
            pb.Orientation = Orientation.Vertical;
            pb.Margin = new Thickness(0, 0, -1000, -50);
            pb.Height = 800;
            pb.Width = 50;
            pb.Value = 50;
            //allow overflow
            pb.ClipToBounds = false;
            pb.Foreground = Brushes.Yellow;
            stackPanel.Children.Add(pb);
            TextBlock tb2 = new TextBlock();
            tb2.Inlines.Add("FORM A CIRCLE WITH YOUR ARMS TO EXIT");
            tb2.HorizontalAlignment = HorizontalAlignment.Center;
            tb2.VerticalAlignment = VerticalAlignment.Bottom;
            tb2.FontSize = 24;
            tb2.Margin = new Thickness(0, 0, 0, -100);
            stackPanel.Children.Add(tb2);
            TextBlock tb3 = new TextBlock();
            tb3.Inlines.Add("EVALUATION BAR");
            tb3.HorizontalAlignment = HorizontalAlignment.Right;
            tb3.VerticalAlignment = VerticalAlignment.Top;
            tb3.FontSize = 24;
            tb3.Margin = new Thickness(0, -800, -470, 0);
            stackPanel.Children.Add(tb3);
            TextBlock tb4 = new TextBlock();
            tb4.Inlines.Add("100");
            tb4.HorizontalAlignment = HorizontalAlignment.Right;
            tb4.VerticalAlignment = VerticalAlignment.Top;
            tb4.FontSize = 24;
            tb4.Margin = new Thickness(0, -740, -350, 0);
            stackPanel.Children.Add(tb4);
            TextBlock tb5 = new TextBlock();
            tb5.Inlines.Add("50");
            tb5.HorizontalAlignment = HorizontalAlignment.Right;
            tb5.VerticalAlignment = VerticalAlignment.Top;
            tb5.FontSize = 24;
            tb5.Margin = new Thickness(0, -370, -350, 0);
            stackPanel.Children.Add(tb5);
            TextBlock tb6 = new TextBlock();
            tb6.Inlines.Add("0");
            tb6.HorizontalAlignment = HorizontalAlignment.Right;
            tb6.VerticalAlignment = VerticalAlignment.Bottom;
            tb6.FontSize = 24;
            tb6.Margin = new Thickness(0, 0, -350, 0);
            stackPanel.Children.Add(tb6);

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
            if (num > 100)
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