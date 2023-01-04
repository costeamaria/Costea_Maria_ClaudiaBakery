using Costea_Maria_ClaudiaBakery.Models;

namespace Costea_Maria_ClaudiaBakery;

public partial class WishEntryPage : ContentPage
{
	public WishEntryPage()
	{
		InitializeComponent();
	}
    protected override async void OnAppearing()
    {
        base.OnAppearing();
        listView.ItemsSource = await App.Database.GetWishListsAsync();
    }
    async void OnWishListAddedClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ListPage
        {
            BindingContext = new WishList()
        });
    }
    async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (e.SelectedItem != null)
        {
            await Navigation.PushAsync(new ListPage
            {
                BindingContext = e.SelectedItem as WishList
            });
        }
    }

}