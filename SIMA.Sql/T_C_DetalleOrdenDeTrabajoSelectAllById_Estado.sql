if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_DetalleOrdenDeTrabajoSelectAllById_Estado]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_DetalleOrdenDeTrabajoSelectAllById_Estado]
GO

CREATE PROCEDURE [dbo].[T_C_DetalleOrdenDeTrabajoSelectAllById_Estado]
(
	@Id_Estado int
)

AS

SET NOCOUNT ON

SELECT [Id_DetalleOrdendeTrabajo],
	[Id_OrdendeTrabajo],
	[Costo],
	[Porcentaje],
	[Motivo],
	[FechaRegistro],
	[Id_Estado],
	[Cantidad],
	[Id_OrdenTrabajo],
	[Id_Solicitud]
FROM [T_C_DetalleOrdenDeTrabajo]
WHERE [Id_Estado] = @Id_Estado
GO
