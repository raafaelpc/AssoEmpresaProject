
----------------------TABLES-------------------------
-----------------------------------------------------

USE [db_teste]
GO

/****** Object:  Table [dbo].[tb_empresas]    Script Date: 09/06/2023 14:05:10 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tb_empresas](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](200) NOT NULL,
	[CNPJ] [varchar](14) NOT NULL,
	[Status] [int] NULL,
 CONSTRAINT [PK_tb_empresas] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO





USE [db_teste]
GO

/****** Object:  Table [dbo].[tb_associados]    Script Date: 09/06/2023 14:06:22 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tb_associados](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](200) NOT NULL,
	[Cpf] [varchar](11) NOT NULL,
	[DatadeNascimento] [datetime] NOT NULL,
	[Idempresa] [int] NULL,
	[Status] [int] NULL,
 CONSTRAINT [PK_tb_associados] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO





USE [db_teste]
GO

/****** Object:  Table [dbo].[tb_associadoempresas]    Script Date: 09/06/2023 14:06:56 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tb_associadoempresas](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idassociado] [int] NOT NULL,
	[idempresa] [int] NOT NULL,
	[status] [int] NULL
) ON [PRIMARY]
GO


-------------------PROCEDURES------------------------
-----------------------------------------------------


USE [db_teste]
GO

/****** Object:  StoredProcedure [dbo].[GetAllAssociados]    Script Date: 09/06/2023 14:07:37 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[GetAllAssociados]
as
begin
select * from tb_associados where Status = 1
end
GO


USE [db_teste]
GO

/****** Object:  StoredProcedure [dbo].[GetAllAssociadosEmpresas]    Script Date: 09/06/2023 14:08:33 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[GetAllAssociadosEmpresas]
as
begin
SELECT        dbo.tb_associados.Id AS Id_Associado, dbo.tb_associados.Nome AS Nome_Associado, dbo.tb_associados.Cpf AS Cpf_Associado, dbo.tb_associados.DatadeNascimento AS DataNascimento_Associado, dbo.tb_associadoempresas.status AS Status_Vinculação, dbo.tb_empresas.CNPJ AS CNPJ_Empresa, dbo.tb_empresas.Nome AS Nome_Empresa, 
                         dbo.tb_empresas.Id AS Id_Empresa
FROM            dbo.tb_associadoempresas INNER JOIN
                         dbo.tb_associados ON dbo.tb_associadoempresas.idassociado = dbo.tb_associados.Id INNER JOIN
                         dbo.tb_empresas ON dbo.tb_associadoempresas.idempresa = dbo.tb_empresas.Id
						 where tb_associadoempresas.status = 1
end
GO


USE [db_teste]
GO

/****** Object:  StoredProcedure [dbo].[GetAllAssociadosEmpresasByIdAssociado]    Script Date: 09/06/2023 14:08:49 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[GetAllAssociadosEmpresasByIdAssociado]  
@Id int  
as  
begin  
select * from tb_associadoempresas where @Id = idassociado
end
GO

USE [db_teste]
GO

/****** Object:  StoredProcedure [dbo].[GetAllAssociadosEmpresasByIdEmpresa]    Script Date: 09/06/2023 14:09:05 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[GetAllAssociadosEmpresasByIdEmpresa]  
@Id int  
as  
begin  
select * from tb_associadoempresas where @Id = idempresa
end
GO


USE [db_teste]
GO

/****** Object:  StoredProcedure [dbo].[GetAllEmpresas]    Script Date: 09/06/2023 14:09:14 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[GetAllEmpresas]
as
begin
select * from tb_empresas
end
GO


USE [db_teste]
GO

/****** Object:  StoredProcedure [dbo].[GetAssociadoByIdEmpresa]    Script Date: 09/06/2023 14:09:35 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[GetAssociadoByIdEmpresa]  
@Id int  
as  
begin  
select * from tb_associadoempresas where @Id = idassociado
end
GO


USE [db_teste]
GO

/****** Object:  StoredProcedure [dbo].[GetEmpresasByFilter]    Script Date: 09/06/2023 14:09:49 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[GetEmpresasByFilter]
@Id int,
@Nome varchar(200),
@Cnpj varchar(14)
as
begin
select * from tb_empresas where Status = 1 AND (Id = @Id Or Nome = @Nome Or Cnpj = @Cnpj)
end
GO


USE [db_teste]
GO

/****** Object:  StoredProcedure [dbo].[GetEmpresasById]    Script Date: 09/06/2023 14:09:57 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE procedure [dbo].[GetEmpresasById]  
@Id int  
as  
begin  
select * from tb_empresas where Id = @Id
end  
GO


USE [db_teste]
GO

/****** Object:  StoredProcedure [dbo].[InsertAssociadoEmpresa]    Script Date: 09/06/2023 14:10:08 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[InsertAssociadoEmpresa]  
@idassociado int,
@idempresa int,
@status int
as  
begin  
Insert into tb_associadoempresas(idassociado,idempresa,status) 
VALUES(@idassociado,@idempresa,@status)
end 
GO


USE [db_teste]
GO

/****** Object:  StoredProcedure [dbo].[InsertAssociados]    Script Date: 09/06/2023 14:10:15 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[InsertAssociados]
@Nome varchar(200),
@Cpf varchar(11),
@DatadeNascimento datetime,
@Status int
as
begin
Insert into tb_associados (Nome,Cpf,DatadeNascimento,Status) 
VALUES(@Nome,@Cpf,@DatadeNascimento,@Status)
end
GO


USE [db_teste]
GO

/****** Object:  StoredProcedure [dbo].[InsertEmpresas]    Script Date: 09/06/2023 14:10:22 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[InsertEmpresas]
@Nome varchar(200),
@CNPJ varchar(14),
@Status int
as
begin
Insert into tb_empresas(Nome,CNPJ,Status) 
VALUES(@Nome,@CNPJ,@Status)
end
GO


USE [db_teste]
GO

/****** Object:  StoredProcedure [dbo].[UpdateAssociados]    Script Date: 09/06/2023 14:10:29 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[UpdateAssociados]
@Id int,
@Nome varchar(200),
@Cpf varchar(11),
@DatadeNascimento datetime,
@Status int 
as
begin
Update tb_associados Set Nome = @Nome,Cpf = @Cpf,DatadeNascimento = @DatadeNascimento,[Status] = @Status where @Id = Id
end
GO


USE [db_teste]
GO

/****** Object:  StoredProcedure [dbo].[UpdateAssociadosIdempresa]    Script Date: 09/06/2023 14:10:36 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[UpdateAssociadosIdempresa]
@Id int,
@status int
as
begin
Update tb_associadoempresas Set Status= @status where @Id = Idempresa
end
GO


USE [db_teste]
GO

/****** Object:  StoredProcedure [dbo].[UpdateAssociadosIdempresaByIdAssociado]    Script Date: 09/06/2023 14:10:43 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[UpdateAssociadosIdempresaByIdAssociado]
@Id int,
@status int
as
begin
Update tb_associadoempresas Set Status= @status where @Id = idassociado
end
GO


USE [db_teste]
GO

/****** Object:  StoredProcedure [dbo].[UpdateAssociadosIdempresaByIdEmpresa]    Script Date: 09/06/2023 14:10:49 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[UpdateAssociadosIdempresaByIdEmpresa]
@Id int,
@status int
as
begin
Update tb_associadoempresas Set Status= @status where @Id = Idempresa
end
GO


USE [db_teste]
GO

/****** Object:  StoredProcedure [dbo].[UpdateEmpresas]    Script Date: 09/06/2023 14:10:56 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[UpdateEmpresas]
@Id int,
@Nome varchar(200),
@Cnpj varchar(14),
@Status int 
as
begin
Update tb_empresas Set Nome = @Nome,Cnpj = @Cnpj,[Status] = @Status where @Id = Id
end
GO





