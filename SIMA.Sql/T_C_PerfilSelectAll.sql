if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_PerfilSelectAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_PerfilSelectAll]
GO

CREATE PROCEDURE [dbo].[T_C_PerfilSelectAll]

AS

SET NOCOUNT ON

SELECT [Id_Perfil],
	[Nombre],
	[Descripcion],
	[Id_Estado]
FROM [T_C_Perfil]
GO
