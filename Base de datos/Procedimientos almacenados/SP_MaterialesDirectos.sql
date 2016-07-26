USE [DB7]
GO

-- ==========================================================
-- Author:		Rodrigo Miranda
-- Create date: 20/07/2016
-- Description:	SP para reporte de compra de materiales directos
-- ==========================================================
CREATE procedure SP_Reporte_MatD

@nombre as varchar(25)

as

select cmd_nombre,cmd_periodo,cmd_grantotal_matdirectos_compra, emp_nombre_empresa2, usr_usuario, mnd_moneda2
from tbl_frm_compras_matdirectos A, tbl_frm_empresa2 E, tbl_frm_usuario F, tbl_frm_moneda2 G
where cmd_nombre = @nombre and  E.id_empresa2 = A.id_empresa2 and F.id_usuario = A.id_usuario and G.id_moneda2 = A.id_moneda2