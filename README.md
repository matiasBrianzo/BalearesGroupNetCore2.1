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

Insert


GO

INSERT INTO [dbo].[NegocioControl]
           ([Negocio]
           ,[DiaDeLaSemana]
           ,[HorarioApertura]
           ,[HorarioCierre])
     VALUES
           ('Demo'
           ,'Lunes'
           ,'08:30'
           ,'18:30')
GO

INSERT INTO [dbo].[NegocioControl]
           ([Negocio]
           ,[DiaDeLaSemana]
           ,[HorarioApertura]
           ,[HorarioCierre])
     VALUES
           ('Demo'
           ,'Martes'
           ,'08:30'
           ,'18:30')
GO

INSERT INTO [dbo].[NegocioControl]
           ([Negocio]
           ,[DiaDeLaSemana]
           ,[HorarioApertura]
           ,[HorarioCierre])
     VALUES
           ('Demo'
           ,'Miercoles'
           ,'08:30'
           ,'18:30')
GO

INSERT INTO [dbo].[NegocioControl]
           ([Negocio]
           ,[DiaDeLaSemana]
           ,[HorarioApertura]
           ,[HorarioCierre])
     VALUES
           ('Demo'
           ,'Jueves'
           ,'08:30'
           ,'18:30')
GO
INSERT INTO [dbo].[NegocioControl]
           ([Negocio]
           ,[DiaDeLaSemana]
           ,[HorarioApertura]
           ,[HorarioCierre])
     VALUES
           ('Demo'
           ,'Viernes'
           ,'08:30'
           ,'18:30')
GO
