using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppLayouts;

public partial class GridLayout : ContentPage
{
    public GridLayout()
    {
        InitializeComponent();
    }
    private void MainClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MainPage());
    }

    private void Button_OnClicked(object? sender, EventArgs e)
    {
        Navigation.PushAsync(new StackLayout());
    }
}