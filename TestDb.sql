USE [Test_db]
GO
/****** Object:  Table [dbo].[Person]    Script Date: 11/24/2020 4:03:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Person](
	[FirstName] [nchar](50) NOT NULL,
	[LastName] [nchar](50) NOT NULL,
	[Country] [nchar](100) NOT NULL,
	[Id] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_Person] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Person] ON 

INSERT [dbo].[Person] ([FirstName], [LastName], [Country], [Id]) VALUES (N'Poonam', N'Dwivedi', N'India', 1078)
INSERT [dbo].[Person] ([FirstName], [LastName], [Country], [Id]) VALUES (N'Nick', N'Jonas', N'USA', 1079)
INSERT [dbo].[Person] ([FirstName], [LastName], [Country], [Id]) VALUES (N'Jofra', N'Archer', N'England', 1080)
INSERT [dbo].[Person] ([FirstName], [LastName], [Country], [Id]) VALUES (N'Mosh', N'Hamedani', N'UK', 1081)
INSERT [dbo].[Person] ([FirstName], [LastName], [Country], [Id]) VALUES (N'Richa', N'Chadda', N'Pakistan', 1082)
SET IDENTITY_INSERT [dbo].[Person] OFF
