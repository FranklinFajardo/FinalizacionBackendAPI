USE [prueba]
GO

/****** Object: Table [dbo].[Usuarios] Script Date: 19/11/2022 19:15:37 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Personas] (
    [Identificador]            INT          IDENTITY (1, 1) NOT NULL,
    [Nombres]                  VARCHAR (40) NOT NULL,
    [Apellido]                 VARCHAR (40) NOT NULL,
    [Numero_de_identificacion] TEXT         NULL,
    [Email]                    TEXT         NULL,
    [Tipo_de_identificacion]   TEXT         NULL,
    [Fecha_de_reacion]         DATETIME     NULL,
    [columna2]                 AS           (concat([Nombres],' ',[Apellido])),
    [columna1]                 AS           (concat([Numero_de_identificacion],' ',[Tipo_de_identificacion]))
);


