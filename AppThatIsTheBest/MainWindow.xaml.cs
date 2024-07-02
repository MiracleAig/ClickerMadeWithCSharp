using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AppThatIsTheBest;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{

    private int _timesClicked = 0;
    
    public MainWindow()
    {
        InitializeComponent();
    }

    private void Button_OnClick(object sender, RoutedEventArgs e)
    {
        _timesClicked++;
        if (_timesClicked == 1)
        {
            timesClicked.Content = $"You have clicked 1 time";
        }
        else
        {
          timesClicked.Content = $"You have clicked {_timesClicked} times";
        }
    }
}