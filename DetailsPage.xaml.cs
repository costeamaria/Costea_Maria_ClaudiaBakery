using Costea_Maria_ClaudiaBakery.ViewModel;

namespace Costea_Maria_ClaudiaBakery;

public partial class DetailsPage : ContentPage
{
    public DetailsPage(ProductPageViewModel item)
    {
        InitializeComponent();
        BindingContext = item;
    }
}