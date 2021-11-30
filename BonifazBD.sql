Create DataBase CitasMedicas2
Use CitasMedicas2

Create table Administrador(
IDAdministrador int primary key not null,
CorreoElectronico varchar(30),
Contraseña varchar(30)
)

Create Table Especialidad(
IDEspecialidad_Nombre varchar(40) primary key not null,
Descripcion varchar(100)  not null
)

Create Table Medico(
IdMedico int primary key not null,
ApellidoPaterno varchar(30)not null,
ApellidoMaterno varchar(30)not null,
Nombre varchar(30)not null,
Genero varchar (15)not null,
FechaNacimiento datetime not null,
CorreoElectronico varchar(30) not null,
Contraseña varchar(30) not null,
IDEspecialidad_Nombre VARCHAR(40) not null FOREIGN KEY REFERENCES Especialidad(IDEspecialidad_Nombre)
)

Create Table Horarios(
IDHorario int primary key not null,
Hora_Entrada Time not null,
Hora_Salida Time not null,
IdMedico Int not null FOREIGN KEY REFERENCES Medico(IdMedico)
)


Create Table Paciente(
IdPaciente int primary key not null,
ApellidoPaterno varchar(30)not null,
ApellidoMaterno varchar(30)not null,
Nombre varchar(30)not null,
Genero varchar (15)not null,
FechaNacimiento datetime not null,
CorreoElectronico varchar(30) not null,
Contraseña varchar(30) not null,
)

Create Table Cita(
IdPaciente int not null FOREIGN KEY REFERENCES Paciente(Idpaciente),
IdMedico Int not null FOREIGN KEY REFERENCES Medico(IdMedico),
Fecha datetime not null,
Hora TIME not null,
Folio int primary key not null,
StatusS varchar(20)
)



