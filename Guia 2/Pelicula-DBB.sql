create database pelicula;
create table peliculas(
	id INT PRIMARY KEY IDENTITY(1,1),
	titulo VARCHAR(60),
	fechaLanzamiento DATETIME,
	genero VARCHAR(1),
	precio DECIMAL
);