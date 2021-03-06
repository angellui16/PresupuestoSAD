USE [DB7]
GO
/****** Object:  StoredProcedure [dbo].[SP_Reporte_Resultados]    Script Date: 25/07/2016 2:35:49 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Angel Tobar
-- Create date: 16/07/2016
-- Description:	SP para reporte estado de resultados
-- =============================================

CREATE procedure [dbo].[SP_Reporte_Resultados]

@nombre as varchar(25)

as

select erp_nombre, erp_periodo, prv_nombre_presupuesto2, prv_total_producto2, pcv_nombre, pcv_grantotal, gva_nombre, gva_grantotal, erp_utilidad_bruta, erp_utilidad_operacion, erp_ingresos_gastos, erp_utilidad_aisr, erp_isr, erp_utilidad_neta, emp_nombre_empresa2, usr_usuario, mnd_moneda2
from tbl_frm_estadoresultados A, tbl_frm_presupuesto_ventas2 B, tbl_frm_presupuesto_cv C, tbl_frm_presupuesto_gva E, tbl_frm_empresa2 G, tbl_frm_usuario H, tbl_frm_moneda2 I
where erp_nombre = @nombre and B.id_presupuesto_ventas2 = A.id_presupuesto_ventas and C.id_presupuesto_cv = A.id_presupuesto_cv and E.id_presupuesto_gva = A.id_presupuesto_gva and G.id_empresa2 = A.id_empresa2 and H.id_usuario = A.id_usuario and I.id_moneda2 = A.id_moneda2

