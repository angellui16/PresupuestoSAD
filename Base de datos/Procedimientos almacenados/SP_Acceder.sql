USE [DB7]
GO
/****** Object:  StoredProcedure [dbo].[SP_Acceder]    Script Date: 25/07/2016 2:33:41 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Angel Tobar
-- Create date: 26/06/2016
-- Description:	SP para login
-- =============================================

CREATE procedure [dbo].[SP_Acceder]
@user varchar(15),
@contraseña varchar(15)

as
select * from tbl_frm_usuario
where usr_usuario = @user and usr_password = @contraseña 