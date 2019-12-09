using System;
using System.ComponentModel.DataAnnotations;

namespace RoomMatch.Models
{
    public enum LevelThree { Low, Medium, High }
    public enum LevelFour { Low, MedLow, MedHigh, High }
    public enum LevelFive { Low, MedLow, Medium, MedHigh, High }

    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }
        public bool IsOrganized { get; set; }
        public bool LikesLight { get; set; }
        public bool LikesWorkingAlone { get; set; }
        public LevelFive Sleep { get; set; }
        public LevelFour Social { get; set; }
        public LevelThree Cleanliness { get; set; }
        public LevelThree Sharing { get; set; }
        public LevelThree Sound { get; set; }
        public LevelThree Temperature { get; set; }
    }
}