using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace TravelRecordApp2.Model 
{
    public class Post                           // Lesson 53
    {
        [PrimaryKey, AutoIncrement]             // Lesson 54
        public int Id { get; set; }

        [MaxLength(250)]                        // Lesson 54
        public string Experience { get; set; }
    }
}
