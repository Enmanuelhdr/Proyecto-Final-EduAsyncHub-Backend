

USE EduAsyncHub;

-- Tabla de Roles
CREATE TABLE Roles (
    RolID INT PRIMARY KEY,
    NombreRol VARCHAR(50) NOT NULL
);

-- Inserci�n de roles
INSERT INTO Roles (RolID, NombreRol) VALUES
    (1, 'Estudiante'),
    (2, 'Profesor'),
    (3, 'Administrador');

-- Verificar roles
SELECT * FROM Roles;

-- Tabla de Grados Escolares
CREATE TABLE GradosEscolares (
    GradoID INT PRIMARY KEY,
    NombreGrado VARCHAR(100) NOT NULL
);

-- Inserci�n de grados escolares
INSERT INTO GradosEscolares (GradoID, NombreGrado) VALUES
    (1, 'Primero'),
    (2, 'Segundo'),
    (3, 'Tercero'),
    (4, 'Cuarto'),
    (5, 'Quinto'),
    (6, 'Sexto'),
    (7, 'Septimo'),
    (8, 'Octavo'),
    (9, 'Primero de bachiller'),
    (10, 'Segundo de bachiller'),
    (11, 'Tercero de bachiller'),
    (12, 'Cuarto de bachiller');


-- Verificar grados escolares
SELECT * FROM GradosEscolares;


-- Tabla de Usuarios
CREATE TABLE Usuarios (
    UsuarioID VARCHAR(10) PRIMARY KEY,
    Nombre VARCHAR(100) NOT NULL,
    CorreoElectronico VARCHAR(100) UNIQUE NOT NULL,
    Contrase�a VARCHAR(255) NOT NULL,
    RolID INT,
    FOREIGN KEY (RolID) REFERENCES Roles(RolID)
);

-- Verificar Usuarios
SELECT * FROM Usuarios;

-- Tabla de Estudiantes
CREATE TABLE Estudiantes (
    EstudianteID INT PRIMARY KEY IDENTITY(1,1),
    UsuarioID VARCHAR(10) UNIQUE,
    GradoID INT,
    FOREIGN KEY (UsuarioID) REFERENCES Usuarios(UsuarioID),
    FOREIGN KEY (GradoID) REFERENCES GradosEscolares(GradoID)
);

-- Verificar Estudiantes
SELECT * FROM Estudiantes;

-- Tabla de Profesores
CREATE TABLE Profesores (
    ProfesorID INT PRIMARY KEY IDENTITY(1,1),
    UsuarioID VARCHAR(10) UNIQUE,
    FOREIGN KEY (UsuarioID) REFERENCES Usuarios(UsuarioID)
);


-- Verificar Profesores
SELECT * FROM Profesores;

-- Tabla de Materias
CREATE TABLE Materias (
    MateriaID INT PRIMARY KEY IDENTITY(1,1),
    NombreMateria VARCHAR(100) NOT NULL
);

-- Inserci�n de materias
INSERT INTO Materias (NombreMateria) VALUES
    ('Lengua Espa�ola'),
    ('Ciencias Matematicas'),
    ('Ciencias Naturales'),
    ('Ciencias Sociales'),
    ('Civica'),
    ('Informatica'),
    ('Formacion Humana, Integral y Religiosa'),
    ('Educacion Fisica'),
    ('Educacion Sexual'),
    ('Ingles'),
    ('Frances'),
    ('Educacion Artistica');

-- Verificar Materias
SELECT * FROM Materias;

-- Tabla de Asistencias
CREATE TABLE Asistencias (
    AsistenciaID INT PRIMARY KEY IDENTITY(1,1),
    EstudianteID INT,
    MateriaID INT,
    ProfesorID INT,
    FechaAsistencia DATE NOT NULL,
    Asistio BIT,
    FOREIGN KEY (EstudianteID) REFERENCES Estudiantes(EstudianteID),
    FOREIGN KEY (MateriaID) REFERENCES Materias(MateriaID),
    FOREIGN KEY (ProfesorID) REFERENCES Profesores(ProfesorID)
);

-- Verificar Asistencias
SELECT * FROM Asistencias;

-- Tabla de Calificaciones
CREATE TABLE Calificaciones (
    CalificacionID INT PRIMARY KEY IDENTITY(1,1),
    EstudianteID INT,
    MateriaID INT,
    ProfesorID INT,
    Periodo INT, -- Nuevo campo para identificar el periodo
    Calificacion FLOAT NOT NULL,
    FechaPublicacion DATE NOT NULL,
    FOREIGN KEY (EstudianteID) REFERENCES Estudiantes(EstudianteID),
    FOREIGN KEY (MateriaID) REFERENCES Materias(MateriaID),
    FOREIGN KEY (ProfesorID) REFERENCES Profesores(ProfesorID)
);

-- Verificar Calificaciones
SELECT * FROM Calificaciones;

-- Tabla de NotaTotal
CREATE TABLE NotaTotal (
    NotaTotalID INT PRIMARY KEY IDENTITY(1,1),
    EstudianteID INT UNIQUE,
    MateriaID INT,
    NotaTotal FLOAT,
    FOREIGN KEY (EstudianteID) REFERENCES Estudiantes(EstudianteID),
    FOREIGN KEY (MateriaID) REFERENCES Materias(MateriaID)
);

-- Verificar NotasTotales
SELECT * FROM NotaTotal;


-- Modificar la tabla EstudianteMateria
CREATE TABLE EstudianteMateria (
    InscripcionMateriaID INT PRIMARY KEY IDENTITY(1,1),
    EstudianteID INT,
    MateriaID INT,
    GradoID INT,
    FOREIGN KEY (EstudianteID) REFERENCES Estudiantes(EstudianteID),
    FOREIGN KEY (MateriaID) REFERENCES Materias(MateriaID),
    FOREIGN KEY (GradoID) REFERENCES GradosEscolares(GradoID)
);

-- Verificar EstudianteMateria
SELECT * FROM EstudianteMateria;

-- Modificar la tabla ProfesorMateria
CREATE TABLE ProfesorMateria (
    AsignacionProfesorID INT PRIMARY KEY IDENTITY(1,1),
    ProfesorID INT,
    MateriaID INT,
    GradoID INT,
    FOREIGN KEY (ProfesorID) REFERENCES Profesores(ProfesorID),
    FOREIGN KEY (MateriaID) REFERENCES Materias(MateriaID),
    FOREIGN KEY (GradoID) REFERENCES GradosEscolares(GradoID)
);


-- Verificar EstudianteMateria
SELECT * FROM ProfesorMateria;


