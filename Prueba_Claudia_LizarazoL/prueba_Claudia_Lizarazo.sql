use prueba_Claudia_Lizarazo

select * from sys.tables;

CREATE TABLE pacientes (
TipoDocumento VARCHAR(15)
               CHECK( TipoDocumento IN('CC','TI', 'PA') ),
	NumeroDocumento INT, 
	Nombres varchar(20),
	Apellidos varchar(20),
	CorroElectronico varchar(20),
	Telefono varchar(20),
	FechaNacimiento date,
	EstadoAfiliaci�n varchar(15)
               CHECK( EstadoAfiliaci�n IN('ACTIVO','INACTIVO') )
);

DROP TABLE pacientes

SELECT * FROM pacientes