using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace Qminds
{
    public interface ISQLite
    {
        SQLiteConnection LoginConnection();
    }
}
