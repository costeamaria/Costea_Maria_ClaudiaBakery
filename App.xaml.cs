using System;
using Costea_Maria_ClaudiaBakery.Data;
using System.IO;
namespace Costea_Maria_ClaudiaBakery;

public partial class App : Application
{

    static WishListDatabase database;
    public static WishListDatabase Database
    {
        get
        {
            if (database == null)
            {
                database = new WishListDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "WishList.db3"));
            }
            return database;
        }
    }

    public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}
}
