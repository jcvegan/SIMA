if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_PerfilDelete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_PerfilDelete]
GO

CREATE PROCEDURE [dbo].[T_C_PerfilDelete]
(
	@Id_Perfil int
)

AS

SET NOCOUNT ON

DELETE FROM [T_C_Perfil]
WHERE [Id_Perfil] = @Id_Perfil
GO
