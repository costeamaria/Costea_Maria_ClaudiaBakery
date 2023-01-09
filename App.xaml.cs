using System;
using Costea_Maria_ClaudiaBakery.Data;
using System.IO;
using SQLite;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Costea_Maria_ClaudiaBakery;

public partial class App : Application
{

    public App()
	{
		InitializeComponent();

		MainPage = new LoginPage();
	}

    static LoginDatabase database;

    
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
