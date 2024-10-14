using System;
using WebApiSample.Models;

namespace WebApiSample.Data;

public static class Data
{
    public static List<Project> ProjectDataList =>
    [
        new() {
            ProjectId = 1,
            Name = "Capcitación C#",
            Decription = "Capacitación para principiantes en C#",
            CreateDate = new DateTime(2024,09,1),
            Status = ProjectStatus.Canceled,
            StartDate = new DateTime(2024,09,2),
            EndDate = new DateTime(2024,09,12) 
        },
        new() {
            ProjectId = 2,
            Name = "Creación de sitio WEB de compras",
            Decription = "Creación de un sitip web de compras en linea",
            CreateDate = new DateTime(2024,09,12),
            Status = ProjectStatus.Created
        },
        new() {
            ProjectId = 3,
            Name = "Implemetación de Servidor GIT",
            Decription = "Implmentar servidor GIT",
            CreateDate = new DateTime(2024,09,18),
            Status = ProjectStatus.InProgress,
            StartDate = new DateTime(2024,09,22)
        },
        new() {
            ProjectId = 4,
            Name = "Refactorización de Aplicación de RRHH",
            Decription = "Refactorizar la aplicaipn de Recueross Humanos",
            CreateDate = new DateTime(2024,09,19),
            Status = ProjectStatus.Paused,
            StartDate = new DateTime(2024,09, 25)
        },
        new() {
            ProjectId = 5,
            Name = "Capcitación Java",
            Decription = "Capacitación para principiantes en Java",
            CreateDate = new DateTime(2024,09,23),
            Status = ProjectStatus.Done,
            StartDate = new DateTime(2024,09,23),
            EndDate = new DateTime(2024,09,23)
        },
        new() {
            ProjectId = 6,
            Name = "Creación de Infraestrutura AWS",
            Decription = "Crear infraestructura para sitio web en AWS",
            CreateDate = new DateTime(2024,10,1),
            Status = ProjectStatus.Created
        },
        new() {
            ProjectId = 7,
            Name = "Asesoría Clean Code",
            Decription = "Coaching en Clean Code",
            CreateDate = new DateTime(2024,10,7),
            Status = ProjectStatus.Created
        },
        new() {
            ProjectId = 8,
            Name = "Aplicación movil para registrar Asistencia",
            Decription = "Desarrollar una aplicació movil que registre la asistencia.",
            CreateDate = new DateTime(2024,10,8),
            Status = ProjectStatus.Created
        },
        new() {
            ProjectId = 9,
            Name = "Generar procesos de onboarding de colaboradores",
            Decription = "Generar el proceso de onboarding de nuevos colaboradores",
            CreateDate = new DateTime(2024,10,9),
            Status = ProjectStatus.Created
        },
        new() {
            ProjectId = 10,
            Name = "Capcitación C#",
            Decription = "Capacitación para principiantes en C#",
            CreateDate = new DateTime(2024,10,10),
            Status = ProjectStatus.Created
        }
    ];
}
