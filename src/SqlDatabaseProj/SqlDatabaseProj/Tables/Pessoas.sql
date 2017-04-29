CREATE TABLE [dbo].[Pessoas]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Nome] VARCHAR(50) NOT NULL, 
    [DataNascimento] DATE NOT NULL, 
    [Estatura] DECIMAL NOT NULL, 
    [Peso] DECIMAL NOT NULL, 
    [Genero] INT NOT NULL, 
    [Idade] INT NOT NULL, 
    [Fumante] INT NOT NULL, 
    [ExFumante] INT NOT NULL, 
    [QndParouFumar] DATE NULL, 
    [Convenio] VARCHAR(50) NOT NULL, 
    [Imc] DECIMAL NOT NULL
)
