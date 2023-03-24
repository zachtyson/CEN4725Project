using System.Windows.Controls;

namespace Microsoft.Samples.Kinect.BodyBasics
{
    public partial class LowerWorkoutListPage : Page
    {
        
        private StackPanel stackPanel;
        public LowerWorkoutListPage()
        {
            InitializeComponent();
            TextBlock[] textBlocks = new TextBlock[3];
            textBlocks[2] = new TextBlock();
            textBlocks[2].Text = "LOWER WORKOUTS";
            textBlocks[2].HorizontalAlignment = System.Windows.HorizontalAlignment.Center;
            textBlocks[2].Margin = new System.Windows.Thickness(000, -200, 0, 0);
            textBlocks[2].FontSize = 24;
            textBlocks[2].TextAlignment = System.Windows.TextAlignment.Left;
            textBlocks[0] = new TextBlock();
            textBlocks[0].Text = "SQUATS";
            textBlocks[0].HorizontalAlignment = System.Windows.HorizontalAlignment.Left;
            textBlocks[0].Margin = new System.Windows.Thickness(-300, 50, 0, 0);
            textBlocks[0].FontSize = 36;
            textBlocks[0].TextAlignment = System.Windows.TextAlignment.Left;
            textBlocks[1] = new TextBlock();
            textBlocks[1].Text = "EXIT";
            textBlocks[1].HorizontalAlignment = System.Windows.HorizontalAlignment.Left;
            textBlocks[1].Margin = new System.Windows.Thickness(-300, 100, 0, 0);
            textBlocks[1].FontSize = 24;
            textBlocks[1].TextAlignment = System.Windows.TextAlignment.Left;
            
            stackPanel = new StackPanel();
            stackPanel.Children.Add(textBlocks[2]);
            stackPanel.Children.Add(textBlocks[0]);
            stackPanel.Children.Add(textBlocks[1]);
            this.Content = stackPanel;
        }
        
        int hoveredWorkout = 1;
        
                
        public int GetCategoryIndex()
        {
            return hoveredWorkout;
        }

        public int WaveUp()
        {
            //Waving up means decrementing the hovered category, unless it's already 1, in which case it's 2
            TextBlock textBlock1 = (TextBlock)stackPanel.Children[hoveredWorkout ];
            textBlock1.FontSize = 24;
            if (hoveredWorkout == 1)
            {
                hoveredWorkout = 2;
            }
            else
            {
                hoveredWorkout--;
            }
            TextBlock textBlock2 = (TextBlock)stackPanel.Children[hoveredWorkout ];
            textBlock2.FontSize = 36;
            return hoveredWorkout;
        }

        public int WaveDown()
        {
            //Waving down means incrementing the hovered category, unless it's already 2, in which case it's 1
            TextBlock textBlock1 = (TextBlock)stackPanel.Children[hoveredWorkout ];
            textBlock1.FontSize = 24;
            if(hoveredWorkout == 2)
            {
                hoveredWorkout = 1;
            }
            else
            {
                hoveredWorkout++;
            }
            TextBlock textBlock2 = (TextBlock)stackPanel.Children[hoveredWorkout ];
            textBlock2.FontSize = 36;
            return hoveredWorkout;
        }
    }
}