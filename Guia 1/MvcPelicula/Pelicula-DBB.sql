create table peliculas(
	ID INT PRIMARY KEY IDENTITY(1,1),
	titulo VARCHAR(60),
	fechaLanzamiento DATETIME,
	genero VARCHAR(1),
	precio DECIMAL
);
go