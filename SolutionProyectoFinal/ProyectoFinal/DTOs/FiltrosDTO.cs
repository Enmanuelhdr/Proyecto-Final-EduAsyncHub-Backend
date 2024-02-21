﻿namespace ProyectoFinal.DTOs
{
    public class FiltrosDTO
    {
        public class UserFilterRequestDto
        {
            public int UserId { get; set; }
        }

        public class StudentFilterRequestDto
        {
            public int StudentId { get; set; }
        }

        public class TeacherFilterRequestDto
        {
            public int TeacherId { get; set; }
        }


    }
}