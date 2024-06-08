using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using System.Linq;

namespace Magaz;

public partial class digitalEatU : Window
{
    public digitalEatU()
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
        ssil("Продукты");
    }
    private void ssil(string type)
    {
        AAA.ItemsSource = ShopTab.SaveMagaz.Product.Where(x => x.TypeProduct == type).Select(x => new { x.image, x.ProductName, x.PraiseProduct, x.Id });
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