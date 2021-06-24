using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace Qminds.Model
{
    public class User
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Passowrd { get; set; }
        public long Phone { get; set; }
        public string Email { get; set; }
    }
}
