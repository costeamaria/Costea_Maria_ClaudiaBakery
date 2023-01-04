using Costea_Maria_ClaudiaBakery.Models;
namespace Costea_Maria_ClaudiaBakery;

public partial class ListPage : ContentPage
{
	public ListPage()
	{
		InitializeComponent();
	}
    async void OnSaveButtonClicked(object sender, EventArgs e)
    {
        var slist = (WishList)BindingContext;
        slist.Date = DateTime.UtcNow;
        await App.Database.SaveWishListAsync(slist);
        await Navigation.PopAsync();
    }
    async void OnDeleteButtonClicked(object sender, EventArgs e)
    {
        var slist = (WishList)BindingContext;
        await App.Database.DeleteWishListAsync(slist);
        await Navigation.PopAsync();
    }

}