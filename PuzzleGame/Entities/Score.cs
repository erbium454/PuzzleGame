﻿using System.ComponentModel.DataAnnotations;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace PuzzleGame.Entities
{
    public class Score
    {
        [Key]
        public int Id { get; set; }
        public int TimeSeconds { get; set; }
        public int MovesAmount { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}
