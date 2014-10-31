CREATE TABLE [dbo].[Usuario]
(
	[IdUsuario] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Login] VARCHAR(20) NOT NULL, 
    [Nome] VARCHAR(100) NOT NULL, 
    [Data_Nascimento] DATE NOT NULL, 
    [Sexo] CHAR NOT NULL, 
    [Senha] VARCHAR(10) NOT NULL
)
