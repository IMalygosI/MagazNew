using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace Magaz;

public partial class admin : Window
{
    public admin()
    {
        InitializeComponent();
        basket.Click += Click_basketA;
        exit.Click += Click_exit;
        digitalEat.Click += Click_digitalEat;
        digitalTechnology.Click += Click_digitalTechnology;
        digitaldezda.Click += Click_digitaldezda;
        digitalconselaria.Click += Click_digitalconselaria;
        redact.Click += redact_Click;
    }
    private void redact_Click(object sender, RoutedEventArgs e)
    {
        Delete taskWindow = new Delete();
        taskWindow.Show();
    }
    private void redact1_Click(object sender, RoutedEventArgs e)
    {
        Delete taskWindow = new Delete();
        taskWindow.Show();
    }
    public void Click_digitalconselaria(object sender, RoutedEventArgs args)
    {
        digitalconselaria taskWindow = new digitalconselaria();
        taskWindow.Show();
    }
    public void Click_digitaldezda(object sender, RoutedEventArgs args)
    {
        digitaldezda taskWindow = new digitaldezda();
        taskWindow.Show();
    }
    public void Click_digitalEat(object sender, RoutedEventArgs args)
    {
        digitalEat taskWindow = new digitalEat();
        taskWindow.Show();
    }
    public void Click_digitalTechnology(object sender, RoutedEventArgs args)
    {
        digitalTechnology taskWindow = new digitalTechnology();
        taskWindow.Show();
    }
    public void Click_basketA(object sender, RoutedEventArgs args)
    {
        basketA taskWindow = new basketA();
        taskWindow.Show();
        //this.Close();
    }
    public void Click_exit(object sender, RoutedEventArgs args)
    {
        MainWindow taskWindow = new MainWindow();
        taskWindow.Show();
        this.Close();
    }
}
