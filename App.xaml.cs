using System;
using Costea_Maria_ClaudiaBakery.Data;
using System.IO;
using SQLite;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Costea_Maria_ClaudiaBakery;

public partial class App : Application
{

   // static WishListDatabase database;
    //public static WishListDatabase Database
   // {
      //  get
     //   {
       //     if (database == null)
         //   {
          //      database = new WishListDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "WishList.db3"));
        //    }
         //   return database;
    //    }
   // }


    public App()
	{
		InitializeComponent();

		MainPage = new LoginPage();
	}

    static LoginDatabase database;

    // Create the database connection as a singleton.
    public static LoginDatabase Database
    {
        get
        {
            if (database == null)
            {
                database = new LoginDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "SQLLiteSample.db"));
            }
            return database;
        }
    }
}
