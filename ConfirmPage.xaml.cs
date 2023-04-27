using System.Windows.Controls;

namespace Microsoft.Samples.Kinect.BodyBasics
{
    public partial class ConfirmPage : Page
    {
        int hoveredWorkout = 1;

        private StackPanel stackPanel;

        //There's currently 3 categories, Curls, Pushups, and Exit, respectively
        public ConfirmPage()
        {
            InitializeComponent();
            //<TextBlock Text = "CURLS" HorizontalAlignment="LEFT" Margin="0 100 0 0 " FontSize="24"></TextBlock>
            //<TextBlock Text = "PUSHUPS" HorizontalAlignment="LEFT" Margin="0 200 0 0 " FontSize="24"></TextBlock>
            //<TextBlock Text = "EXIT" HorizontalAlignment="LEFT" Margin="0 300 0 0 " FontSize="24"></TextBlock>
            TextBlock[] textBlocks = new TextBlock[4];
            hoveredWorkout = 0;
            textBlocks[2] = new TextBlock();
            textBlocks[2].Text = "EXIT?";
            textBlocks[2].HorizontalAlignment = System.Windows.HorizontalAlignment.Center;
            textBlocks[2].Margin = new System.Windows.Thickness(000, -250, 0, 0);
            textBlocks[2].FontSize = 24;
            textBlocks[2].TextAlignment = System.Windows.TextAlignment.Left;

            textBlocks[0] = new TextBlock();
            textBlocks[0].Text = "RETURN";
            textBlocks[0].HorizontalAlignment = System.Windows.HorizontalAlignment.Left;
            textBlocks[0].Margin = new System.Windows.Thickness(-300, 50, 0, 0);
            textBlocks[0].TextAlignment = System.Windows.TextAlignment.Left;
            textBlocks[0].FontSize = 36;
            textBlocks[1] = new TextBlock();
            textBlocks[1].Text = "EXIT";
            textBlocks[1].HorizontalAlignment = System.Windows.HorizontalAlignment.Left;
            textBlocks[1].Margin = new System.Windows.Thickness(-300, 100, 0, 0);
            textBlocks[1].FontSize = 24;
            textBlocks[1].TextAlignment = System.Windows.TextAlignment.Left;
            textBlocks[2] = new TextBlock();

            stackPanel = new StackPanel();
            stackPanel.Children.Add(textBlocks[0]);
            stackPanel.Children.Add(textBlocks[1]);
            stackPanel.Children.Add(textBlocks[2]);

            TextBlock exitMessage = new TextBlock();
            exitMessage.Text = "Wave to select, Close your fist to confirm";
            exitMessage.HorizontalAlignment = System.Windows.HorizontalAlignment.Center;
            exitMessage.FontSize = 16;
            exitMessage.Margin = new System.Windows.Thickness(0, -600, 0, 0000);
            stackPanel.Children.Add(exitMessage);

            this.Content = stackPanel;


        }

        public int GetCategoryIndex()
        {
            return hoveredWorkout;
        }

        public int WaveUp()
        {
            //Waving up means decrementing the hovered category, unless it's already 1, in which case it's 2
            TextBlock textBlock1 = (TextBlock)stackPanel.Children[hoveredWorkout];
            textBlock1.FontSize = 24;
            if (hoveredWorkout == 1)
            {
                hoveredWorkout = 0;
            }
            else if (hoveredWorkout == 0)
            {
                hoveredWorkout = 1;
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
            //Waving down means incrementing the hovered category, unless it's already 2, in which case it's 1
            TextBlock textBlock1 = (TextBlock)stackPanel.Children[hoveredWorkout];
            textBlock1.FontSize = 24;
            if (hoveredWorkout == 1)
            {
                hoveredWorkout = 0;
            }
            else if (hoveredWorkout == 0)
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