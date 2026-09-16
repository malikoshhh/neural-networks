using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Media;
using Avalonia.LogicalTree;

namespace M031_malikoshhh
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            foreach (var logical in this.GetLogicalDescendants())
            {
                if (logical is Button btn && btn.Content?.ToString() != "Распознать")
                {
                    btn.Click += Button_Click;
                }
            }
        }

        private void Button_Click(object? sender, RoutedEventArgs e)
        {
            if (sender is not Button clickedButton) return;

            bool isBlack = false;

            if (clickedButton.Background is SolidColorBrush brush)
            {
                isBlack = brush.Color == Colors.Black;
            }

            if (isBlack)
            {
                clickedButton.Background = new SolidColorBrush(Colors.White);
                clickedButton.Foreground = new SolidColorBrush(Colors.Black);
            }
            else
            {
                clickedButton.Background = new SolidColorBrush(Colors.Black);
                clickedButton.Foreground = new SolidColorBrush(Colors.White);
            }
        }
    }
}