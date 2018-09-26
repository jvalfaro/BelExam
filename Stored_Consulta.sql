USE [BelExam]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[usp_s_ListarProductos]
	(
	@vDescripcion as varchar(500)
	)
AS
BEGIN

	SET NOCOUNT ON;

	SELECT TOP 100
		AnioCampania,
		Cuv,
		P.MarcaID,
		Precio,
		P.Descripcion,
		CodigoTipoOferta,
		CodigoSAP,
		M.Descripcion as DescMarca,
		EstadoActivo
	FROM Producto P JOIN Marca M ON P.MarcaID = M.MarcaID
	WHERE P.Descripcion like '%'+ @vDescripcion + '%' AND AnioCampania = 201806
END