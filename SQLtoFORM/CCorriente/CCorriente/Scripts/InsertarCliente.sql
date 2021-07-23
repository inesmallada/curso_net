USE [CCorriente]
GO
/****** Object:  StoredProcedure [dbo].[insertarCliente]    Script Date: 23/07/2021 16:13:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[insertarCliente]
@IDCliente varchar (5),
@Apellidos varchar (30),
@Nombres varchar (30)
AS
insert into Cliente(IDCliente, Apellidos,Nombres)
values (@IDCliente, @Apellidos,@Nombres)