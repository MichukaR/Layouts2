using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppLayouts;

public partial class AbsolutLayout : ContentPage
{
    public AbsolutLayout()
    {
        InitializeComponent();
    }

    private void BotonAlInicio(object sender, EventArgs e)
    {
        Navigation.PushAsync(new GridLayout());
    }
}