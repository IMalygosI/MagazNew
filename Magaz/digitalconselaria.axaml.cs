using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using System.Linq;

namespace Magaz;

public partial class digitalconselaria : Window
{
    public digitalconselaria()
    {
        InitializeComponent();
        if (0 <= ShopTab.SaveMagaz.Product.Count - 1)
        {
            for (int i = 0; i < ShopTab.SaveMagaz.Product.Count; i++)
            {
                ShopTab.SaveMagaz.Product[i].Id = i;
            }
            AAA.ItemsSource = ShopTab.SaveMagaz.Product.ToList();
        }
        korz.Click += Click_korz;
        magaz.Click += Click_magaz;        
        ssil("Канцелярия"); 
    }
    private void ssil(string type)
    {
        AAA.ItemsSource = ShopTab.SaveMagaz.Product.Where(x => x.TypeProduct == type).Select(x => new { x.image, x.ProductName, x.PraiseProduct, x.Id });
    }
    public void Ubrat(object sender, RoutedEventArgs args)
    {
        if (0 <= ShopTab.SaveMagaz.Product.Count - 1)
        {
            ShopTab.SaveMagaz.Product.RemoveAt((int)(sender as Button)!.Tag!);

            for (int i = 0; i < ShopTab.SaveMagaz.Product.Count; i++)
            {
                ShopTab.SaveMagaz.Product[i].Id = i;
            }
            AAA.ItemsSource = ShopTab.SaveMagaz.Product.ToList();
        }
        ssil("Канцелярия");
    }
    public void redakt(object sender, RoutedEventArgs args)
    {
        int massiv = (int)(sender as Button)!.Tag!;
        ShopTab.massiv[0] = massiv;
        Redakt taskWindow = new Redakt();
        taskWindow.Show();
        this.Close();
    }
    private void inkorz(object? sender, RoutedEventArgs e)
    {
        ShopTab.SaveMagaz.korzinaa.Add(ShopTab.SaveMagaz.Product[(int)(sender as Button)!.Tag!]);
    }
    public void Click_korz(object sender, RoutedEventArgs args)
    {
        basketA taskWindow = new basketA();
        taskWindow.Show();
        this.Close();
    }
    public void Click_magaz(object sender, RoutedEventArgs args)
    {
        this.Close();
    }
}