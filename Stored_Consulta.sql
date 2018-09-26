USE [BelExam]
GO
/****** Object:  StoredProcedure [dbo].[usp_s_ListarProductos]    Script Date: 26/09/2018 3:29:35 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[usp_s_ListarProductos]
	-- Add the parameters for the stored procedure here
	(
	@vDescripcion as varchar(500)
	)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
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