﻿using ProyectoFinal.Models;
using static ProyectoFinal.DTOs.TeacherDTO;

namespace ProyectoFinal.Interfaces
{
    public interface ITeacherService
    {
        Task TeachMatterSubject(TeachMatterRequestDto teachMatter);

        Task<List<object>> AllSubjectsTaught(AllSubjectsTaughtRequestDto teacher);

        Task CreateTask(TaskPublishRequestDto newTask);

        Task UpdateTask(TaskUpdatehRequestDto updateTask);

        Task DeleteTask(TaskDeleteRequestDto deleteTask);

        Task QualificationsAssignments(QualificationsAssignmentsRequestDTO qualificationsAssignments);

        Task PublishAssistance(AssistancePublishRequestDto assistance);

        Task QualificationsStudents(QualificationsStudentRequestDto qualificationsStudent);

    }
}
