using System.Diagnostics.Eventing.Reader;
using System.Windows.Controls;

namespace Microsoft.Samples.Kinect.BodyBasics
{
    public partial class UpperWorkoutListPage : Page
    {
        int hoveredWorkout = 1;
        
        private StackPanel stackPanel;
        
        //There's currently 3 categories, Curls, Pushups, and Exit, respectively
        public UpperWorkoutListPage()
        {
            InitializeComponent();
            //<TextBlock Text = "CURLS" HorizontalAlignment="LEFT" Margin="0 100 0 0 " FontSize="24"></TextBlock>
            //<TextBlock Text = "PUSHUPS" HorizontalAlignment="LEFT" Margin="0 200 0 0 " FontSize="24"></TextBlock>
            //<TextBlock Text = "EXIT" HorizontalAlignment="LEFT" Margin="0 300 0 0 " FontSize="24"></TextBlock>
            TextBlock[] textBlocks = new TextBlock[4];
            textBlocks[3] = new TextBlock();
            textBlocks[3].Text = "UPPER WORKOUTS";
            textBlocks[3].HorizontalAlignment = System.Windows.HorizontalAlignment.Center;
            textBlocks[3].Margin = new System.Windows.Thickness(000, -200, 0, 0);
            textBlocks[3].FontSize = 24;
            textBlocks[3].TextAlignment = System.Windows.TextAlignment.Left;

            textBlocks[0] = new TextBlock();
            textBlocks[0].Text = "CURLS";
            textBlocks[0].HorizontalAlignment = System.Windows.HorizontalAlignment.Left;
            textBlocks[0].Margin = new System.Windows.Thickness(-300, 50, 0, 0);
            textBlocks[0].TextAlignment = System.Windows.TextAlignment.Left;
            textBlocks[0].FontSize = 36;
            textBlocks[1] = new TextBlock();
            textBlocks[1].Text = "PUSHUPS";
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
            stackPanel.Children.Add((textBlocks[3]));
            stackPanel.Children.Add(textBlocks[0]);
            stackPanel.Children.Add(textBlocks[1]);
            stackPanel.Children.Add(textBlocks[2]);
            this.Content = stackPanel;
            
            
        }
        
        public int GetCategoryIndex()
        {
            return hoveredWorkout;
        }

        public int WaveUp()
        {
            //Waving up means decrementing the hovered category, unless it's already 1, in which case it's 3
            TextBlock textBlock1 = (TextBlock)stackPanel.Children[hoveredWorkout];
            textBlock1.FontSize = 24;
            if (hoveredWorkout == 1)
            {
                hoveredWorkout = 3;
            }
            else
            {
                hoveredWorkout--;
            }
            TextBlock textBlock2 = (TextBlock)stackPanel.Children[hoveredWorkout];
            textBlock2.FontSize = 36;
            return hoveredWorkout;
        }

        public int WaveDown()
        {
            //Waving down means incrementing the hovered category, unless it's already 3, in which case it's 1
            TextBlock textBlock1 = (TextBlock)stackPanel.Children[hoveredWorkout];
            textBlock1.FontSize = 24;
            if(hoveredWorkout == 3)
            {
                hoveredWorkout = 1;
            }
            else
            {
                hoveredWorkout++;
            }
            TextBlock textBlock2 = (TextBlock)stackPanel.Children[hoveredWorkout];
            textBlock2.FontSize = 36;
            return hoveredWorkout;
        }
    }
}