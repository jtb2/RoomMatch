using System;
using System.ComponentModel.DataAnnotations;

namespace RoomMatch.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }
        public bool A1 { get; set; }
        public bool A2 { get; set; }
        public bool A3 { get; set; }
        public bool A4 { get; set; }
        public bool A5 { get; set; }
        public bool A6 { get; set; }
        public bool A7 { get; set; }
        public bool A8 { get; set; }
        public bool A9 { get; set; }
    }
}