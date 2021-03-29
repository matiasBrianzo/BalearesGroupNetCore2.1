# BalearesGroupNetCore2.1
scripts 
CREATE TABLE NegocioControl (
		[id] int not null identity,
		[Negocio] nvarchar(255),
		[DiaDeLaSemana] nvarchar(255),
		[HorarioApertura] nvarchar(255),
		[HorarioCierre] nvarchar(255),
		PRIMARY KEY( [id] )
	);
