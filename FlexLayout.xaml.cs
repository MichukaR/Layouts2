using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppLayouts;

public partial class FlexLayout : ContentPage
{
    public FlexLayout()
    {
        InitializeComponent();
    }
    private void BotonAAbsolute(object? sender, EventArgs e)
    {
        Navigation.PushAsync(new AbsolutLayout());
    }
}