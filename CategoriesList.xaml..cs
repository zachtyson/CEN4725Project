﻿using System.Windows.Controls;

namespace Microsoft.Samples.Kinect.BodyBasics
{
    public partial class CategoriesListPage : Page
    {
        private int hoveredCategory = 1;
        //There's currently 3 categories, Upper Body, Lower Body, and Exit, respectively
        private StackPanel stackPanel;
        public CategoriesListPage()
        {
            InitializeComponent();
            /*
             * <Border x:Name="upper_border" Width="153" HorizontalAlignment="Left" Height="72" VerticalAlignment="Top" Margin="10,123,0,0" BorderThickness="3,3,3,3">
            <TextBlock x:Name="upper_body_text" Text = "UPPER BODY" HorizontalAlignment="Left" Margin="10,10,0,10" FontSize="24" Width="135"></TextBlock>
        </Border>
        <Border x:Name="lower_border" Margin="0,200,526,318">
            <TextBlock x:Name="lower_body_text" Text = "LOWER BODY" HorizontalAlignment="Left" Margin="10,10,0,-13" FontSize="24" Width="246"></TextBlock>
        </Border>
        <TextBlock x:Name="exit_text" Text = "EXIT" HorizontalAlignment="Left" Margin="0,300,0,213" FontSize="24" Width="69"></TextBlock>
             */
            TextBlock[] textBlocks = new TextBlock[3];
            textBlocks[0] = new TextBlock();
            textBlocks[0].Text = "UPPER";
            textBlocks[0].HorizontalAlignment = System.Windows.HorizontalAlignment.Left;
            textBlocks[0].Margin = new System.Windows.Thickness(-300, 50, 0, 0);
            textBlocks[0].FontSize = 36;
            textBlocks[0].TextAlignment = System.Windows.TextAlignment.Left;
            textBlocks[1] = new TextBlock();
            textBlocks[1].Text = "LOWER";
            textBlocks[1].HorizontalAlignment = System.Windows.HorizontalAlignment.Left;
            textBlocks[1].Margin = new System.Windows.Thickness(-300, 100, 0, 0);
            textBlocks[1].FontSize = 24;
            textBlocks[1].TextAlignment = System.Windows.TextAlignment.Left;
            textBlocks[2] = new TextBlock();
            textBlocks[2].Text = "EXIT";
            textBlocks[2].HorizontalAlignment = System.Windows.HorizontalAlignment.Left;
            textBlocks[2].Margin = new System.Windows.Thickness(-300, 150, 0, 0);
            textBlocks[2].FontSize = 24;
            textBlocks[2].TextAlignment = System.Windows.TextAlignment.Left;
            stackPanel = new StackPanel();
            stackPanel.Children.Add(textBlocks[0]);
            stackPanel.Children.Add(textBlocks[1]);
            stackPanel.Children.Add(textBlocks[2]);
            this.Content = stackPanel;
        }
        
        public int GetCategoryIndex()
        {
            return hoveredCategory;
        }

        public int WaveUp()
        {
            //Waving up means decrementing the hovered category, unless it's already 1, in which case it's 3
            TextBlock textBlock1 = (TextBlock)stackPanel.Children[hoveredCategory - 1];
            textBlock1.FontSize = 24;
            if (hoveredCategory == 1)
            {
                hoveredCategory = 3;
            }
            else
            {
                hoveredCategory--;
            }
            TextBlock textBlock2 = (TextBlock)stackPanel.Children[hoveredCategory - 1];
            textBlock2.FontSize = 36;
            return hoveredCategory;
        }

        public int WaveDown()
        {
            //Waving down means incrementing the hovered category, unless it's already 3, in which case it's 1
            TextBlock textBlock1 = (TextBlock)stackPanel.Children[hoveredCategory - 1];
            textBlock1.FontSize = 24;
            if(hoveredCategory == 3)
            {
                hoveredCategory = 1;
            }
            else
            {
                hoveredCategory++;
            }
            TextBlock textBlock2 = (TextBlock)stackPanel.Children[hoveredCategory - 1];
            textBlock2.FontSize = 36;
            return hoveredCategory;
        }
    }
}