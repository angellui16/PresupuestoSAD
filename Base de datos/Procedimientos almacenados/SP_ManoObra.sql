USE [DB7]
GO

-- ==========================================================
-- Author:		Rodrigo Miranda
-- Create date: 20/07/2016
-- Description:	SP para reporte de costo de mano de obra
-- ==========================================================

CREATE procedure SP_Reporte_MObra

@nombre as varchar(25)

as

select mod_nombre,mod_periodo,mod_grantotal_manoobradirecta,emp_nombre_empresa2,usr_usuario,mnd_moneda2
from tbl_frm_presupuesto_mod A, tbl_frm_empresa2 E, tbl_frm_usuario F, tbl_frm_moneda2 G
where mod_nombre = @nombre and  E.id_empresa2 = A.id_empresa2 and F.id_usuario = A.id_usuario and G.id_moneda2 = A.id_moneda2