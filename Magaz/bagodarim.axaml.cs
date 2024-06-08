using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace Magaz;

public partial class bagodarim : Window
{
    public bagodarim()
    {
        InitializeComponent();
        magazin.Click += Click_magazin;
    }
    public void Click_magazin(object sender, RoutedEventArgs args){
        this.Close();
    }
}