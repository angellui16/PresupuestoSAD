USE [DB7]
GO
/****** Object:  StoredProcedure [dbo].[SP_Transacciones]    Script Date: 25/07/2016 2:36:32 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- ==========================================================
-- Author:		Angel Tobar
-- Create date: 16/07/2016
-- Description:	SP para reporte transacciones presupuestarias
-- ==========================================================

CREATE procedure [dbo].[SP_Transacciones]

@fecha as date,
@fecha2 as date

as

select tsc_id_presupuesto_uno, tsc_presupuesto_uno, tsc_id_presupuesto_dos, tsc_presupuesto_dos, tsc_cantidad, tsc_fecha_transaccion, emp_nombre_empresa2, usr_usuario 
from tbl_frm_transacciones A, tbl_frm_empresa2 B, tbl_frm_usuario C 
where tsc_fecha_transaccion >= @fecha and tsc_fecha_transaccion <=@fecha2 and B.id_empresa2 = A.id_empresa2 and B.id_empresa2 = A.id_empresa2 and C.id_usuario = A.tsc_usuario_transaccion 

