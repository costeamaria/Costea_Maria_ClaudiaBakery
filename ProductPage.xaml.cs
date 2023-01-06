using Costea_Maria_ClaudiaBakery.ViewModel;

namespace Costea_Maria_ClaudiaBakery;

public partial class ProductPage : ContentPage
{
    ProductPageViewModel productPageViewModel;
    public ProductPage()
	{
		InitializeComponent();
        productPageViewModel = new ProductPageViewModel(this.Navigation);
        BindingContext = productPageViewModel;
    }
}