using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppLayouts;

public partial class StackLayout : ContentPage
{
    public StackLayout()
    {
        InitializeComponent();
    }
    private void BotonAFlex(object? sender, EventArgs e)
    {
        Navigation.PushAsync(new FlexLayout());
    }
}