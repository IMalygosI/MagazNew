using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using System.Collections.Generic;
using System.Xml.Linq;
using System;
using System.Linq;
using System.Collections;
using System.IO;
using System.Net.Mime;
using static System.Net.Mime.MediaTypeNames;
using Avalonia.Media.Imaging;

namespace Magaz;

public partial class Redakt : Window
{
    public Redakt()
    {
        InitializeComponent();
        Otmen.Click += Click_Otmen;
        redaktirovat.Click += Redaktirovat_Click;

        prise.Text = Convert.ToString(ShopTab.SaveMagaz.Product[ShopTab.massiv[0]].PraiseProduct);
        name.Text = ShopTab.SaveMagaz.Product[ShopTab.massiv[0]].ProductName;
        TypeVibor.Text = Convert.ToString(ShopTab.SaveMagaz.Product[ShopTab.massiv[0]].TypeProduct);
        SelectedImage = ShopTab.SaveMagaz.Product[ShopTab.massiv[0]].Sourse;
        if (SelectedImage != null)
        {
            img_preview.Source = new Bitmap($"Asset/{SelectedImage}");
        }
        else
        {
            img_preview.Source = new Bitmap("Asset/default_image.jpg");
        }
    }
    string SelectedImage;
    
    private void ssil(string type)
    {
        ShopTab.SaveMagaz.Product.Where(x => x.TypeProduct == type).Select(x => new {x.image, x.ProductName, x.PraiseProduct, x.Id});
    }
    private void Redaktirovat_Click(object? sender, RoutedEventArgs e)
    {
        string III = " ";
        switch (strok.SelectedIndex)
        {
            case 0:
                III = TypeVibor.Text;
                break;
            case 1:
                III = "Техника";
                break;
            case 2:
                III = "Продукты";
                break;
            case 3:
                III = "Канцелярия";
                break;
            case 4:
                III = "Одежда";
                break;
        }
        ShopTab.SaveMagaz.Product[ShopTab.massiv[0]].Sourse = SelectedImage;
        ShopTab.SaveMagaz.Product[ShopTab.massiv[0]].ProductName = name.Text;
        ShopTab.SaveMagaz.Product[ShopTab.massiv[0]].PraiseProduct = Convert.ToDouble(prise.Text);
        ShopTab.SaveMagaz.Product[ShopTab.massiv[0]].TypeProduct = III;
        this.Close();
    }
    private readonly FileDialogFilter fileFilter = new()
    {
        Extensions = new System.Collections.Generic.List<string>() {"png", "jpg", "jpeg"},
        Name = "Файлы изображений"
    };
    private async void ImageSelection(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        var button = (sender as Button)!;
        switch (button.Name)
        {
            case "btn_imgAdd":
                OpenFileDialog dialog = new();
                dialog.Filters.Add(fileFilter);

                string[] result = await dialog.ShowAsync(this);
                if (result == null)
                    return;
                string imageName = Path.GetFileName(result[0]);
                File.Copy(result[0], $"Asset/{imageName}", true);
                tblock_preview.IsVisible = img_preview.IsVisible = true; 
                tblock_preview.Text = SelectedImage = imageName;
                img_preview.Source = new Bitmap($"Asset/{imageName}");
                break;
            case "btn_imgDel":
                tblock_preview.IsVisible = img_preview.IsVisible = false;
                SelectedImage = null;
                break;
        }
    }
    public void Click_Otmen(object sender, RoutedEventArgs args)
    {
        this.Close();
    }
}
