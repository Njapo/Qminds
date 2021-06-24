using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Qminds.Model;
using Xamarin.Forms;
using SQLite;
using System.IO;
using Qminds.Droid;

[assembly: Dependency(typeof(SQLite_Droid))]
namespace Qminds.Droid
{
    public class SQLite_Droid : ISQLite
    {
        public SQLiteConnection LoginConnection()
        {
            var dbName = "usersdatabase.sqlite3";
            var dbPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.ApplicationData);
            var path = Path.Combine(dbPath, dbName);
            var conn = new SQLiteConnection(path);
            return conn;
        }
    }
}