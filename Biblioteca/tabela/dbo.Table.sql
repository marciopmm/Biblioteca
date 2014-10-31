CREATE TABLE [dbo].[Livro]
(
	[IDLivro] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Nome] VARCHAR(100) NOT NULL, 
    [Autor] VARCHAR(100) NOT NULL, 
    [Editora] VARCHAR(50) NOT NULL, 
    [Emprestado] BIT NOT NULL
)
