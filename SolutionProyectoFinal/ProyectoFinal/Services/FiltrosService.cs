﻿using Microsoft.EntityFrameworkCore;
using ProyectoFinal.Context;
using ProyectoFinal.Interfaces;
using ProyectoFinal.Models;
using static ProyectoFinal.DTOs.FiltrosDTO;

namespace ProyectoFinal.Services
{
    public class FiltrosService : IFiltrosService
    {
        private readonly EduAsyncHubContext _context;

        public FiltrosService(EduAsyncHubContext dbContext)
        {
            _context = dbContext;
        }

        public async Task<Usuario> GetUserForId(UserFilterRequestDto userFilter)
        {
            var user = await _context.Usuarios.FirstOrDefaultAsync(u => u.UsuarioId == userFilter.UserId);

            return user;
        }

        public async Task<Estudiante> GetStudentForId(StudentFilterRequestDto studentFilter)
        {
            var student = await _context.Estudiantes.FirstOrDefaultAsync(u => u.EstudianteId == studentFilter.StudentId);

            return student;
        }

        public async Task<Profesore> GetTeacherForId(TeacherFilterRequestDto teacherFilter)
        {
            var teacher = await _context.Profesores.FirstOrDefaultAsync(u => u.ProfesorId == teacherFilter.TeacherId);

            return teacher;
        }

        public async Task<Carrera> GetCareerForId(CareerFilterRequestDto careerFilter)
        {
            var career = await _context.Carreras.FirstOrDefaultAsync(u => u.CarreraId == careerFilter.CareerId);

            return career;
        }

        public async Task<Materia> GetSubjectForId(SubjectFilterRequestDto subjectFilter)
        {
            var subject = await _context.Materias.FirstOrDefaultAsync(u => u.MateriaId == subjectFilter.SubjectId);

            return subject;
        }

        public async Task<Asignacione> GetAssignmentForId(AssignmentsFilterRequestDto assignmentFilter)
        {
            var assignment = await _context.Asignaciones.FirstOrDefaultAsync(u => u.AsignacionId == assignmentFilter.AssignmentsId);

            return assignment;
        }

    }
}
