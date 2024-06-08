using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Avalonia.Media.Imaging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Magaz;

public partial class Delete : Window
{
    public Delete(){
        InitializeComponent();
        Otmen.Click += Click_Otmen;
        PostavkaK.Click += Click_PostavkaK;
    }
    string SelectedImage;
    private List<Type> tuype = new List<Type>()
    {
        new Type(0, "..."),
        new Type(0, "Техника"),
        new Type(1, "Продукты"),
        new Type(2, "Канцелярия"),
        new Type(3, "Одежда")
    };
    public void Click_PostavkaK(object sender, RoutedEventArgs args){
        string III = " ";
        switch (strok.SelectedIndex)
        {
            case 0:
                return;
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
        ShopTab.SaveMagaz.Product.Add(new Product(name.Text, Convert.ToDouble(prise.Text), III, id:1, SelectedImage));
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
    public void Click_Otmen(object sender, RoutedEventArgs args){
        this.Close();
    }
}