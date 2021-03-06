USE [DB7]
GO
/****** Object:  StoredProcedure [dbo].[SP_Presupuesto_gva]    Script Date: 25/07/2016 2:34:45 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Angel Tobar
-- Create date: 16/07/2016
-- Description:	SP para reporte gva
-- =============================================

CREATE procedure [dbo].[SP_Presupuesto_gva]

@nombre as varchar(25)

as 

select gva_nombre, gva_periodo, gav_nombre, gav_valor, gva_subventa, gaa_nombre, gaa_valor, gva_subadmin, gva_grantotal, emp_nombre_empresa2, usr_usuario, mnd_moneda2
from tbl_frm_presupuesto_gva A, tbl_frm_gastosventa B, tbl_frm_gastosadmin C, tbl_frm_empresa2 D, tbl_frm_usuario E, tbl_frm_moneda2 F
where gva_nombre = @nombre and  B.id_presupuesto_gva = A.id_presupuesto_gva and C.id_presupuesto_gva = A.id_presupuesto_gva and D.id_empresa2 = A.id_empresa2 and E.id_usuario = A.id_usuario and F.id_moneda2 = A.id_moneda2