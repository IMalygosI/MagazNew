using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace Magaz;

public partial class user : Window
{
    public user()
    {
        InitializeComponent();
        basket.Click += Click_basketA;
        exit.Click += Click_exit;
        digitalEat.Click += Click_digitalEat;
        digitalTechnology.Click += Click_digitalTechnology;
        digitaldezda.Click += Click_digitaldezda;
        digitalconselaria.Click += Click_digitalconselaria;
    }

    public void Click_digitalconselaria(object sender, RoutedEventArgs args)
    {
        digitalconselariaU taskWindow = new digitalconselariaU();
        taskWindow.Show();
    }
    public void Click_digitaldezda(object sender, RoutedEventArgs args)
    {
        digitaldezdaU taskWindow = new digitaldezdaU();
        taskWindow.Show();
    }
    public void Click_digitalEat(object sender, RoutedEventArgs args)
    {
        digitalEatU taskWindow = new digitalEatU();
        taskWindow.Show();
    }
    public void Click_digitalTechnology(object sender, RoutedEventArgs args)
    {
        digitalTechnologyU taskWindow = new digitalTechnologyU();
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