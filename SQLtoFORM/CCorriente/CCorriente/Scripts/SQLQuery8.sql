USE [CCorriente]
GO
/****** Object:  StoredProcedure [dbo].[EliminarCliente]    Script Date: 23/07/2021 16:52:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[EliminarCliente]
@IDCliente varchar(30)
as
Delete
from Cliente
where IDCliente=@IDCliente