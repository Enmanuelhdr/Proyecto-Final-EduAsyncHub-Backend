﻿namespace ProyectoFinal.DTOs
{
    public class StudentDTO
    {
        public class EnrollCareerStudentRequestDto
        {
            public int EstudianteId { get; set; }
            public int CarreraId { get; set; }

        }

        public class EnrollSubjectStudentRequestDto
        {
            public int EstudianteId { get; set; }
            public int MateriaId { get; set; }

        }

         public class AllSubjectsStudentRequestDto
         {
           public int EstudianteId { get; set; }

         }

        public class SubmitAssignmentRequestDto
        {
            public int EstudianteId { get; set; }
            public int AsignacionId { get; set; }
            public IFormFile Archivo { get; set; }


        }

        public class EditAssignmentRequestDto
        {
            public int EstudianteId { get; set; }
            public int AsignacionId { get; set; }
            public string Respuesta { get; set; }

        }

        public class DeleteAssignmentRequestDto
        {
            public int EstudianteId { get; set; }
            public int AsignacionId { get; set; }

        }

        public class ViewQualificationsRequestDto
        {
            public int EstudianteId { get; set; }

        }

        public class ViewAssitanceRequestDto
        {
            public int EstudianteId { get; set; }

        }

    }
}
