USE [_190716041]
GO
/****** Object:  Table [dbo].[bedenBilgileri]    Script Date: 13.06.2020 18:31:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[bedenBilgileri](
	[BedenId] [int] IDENTITY(1,1) NOT NULL,
	[PersonalId] [int] NULL,
	[Kilo] [int] NOT NULL,
	[Boy] [int] NOT NULL,
	[Kol] [int] NOT NULL,
	[Bel] [int] NOT NULL,
	[Gogus] [int] NOT NULL,
	[Kalca] [int] NOT NULL,
	[Omuz] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[BedenId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Odemeler]    Script Date: 13.06.2020 18:31:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Odemeler](
	[OdemeId] [int] IDENTITY(1,1) NOT NULL,
	[PersonalId] [int] NULL,
	[Ogrenci] [varchar](30) NOT NULL,
	[Odeme] [varchar](30) NOT NULL,
	[Tutar] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[OdemeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[personalInformation]    Script Date: 13.06.2020 18:31:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[personalInformation](
	[PersonalId] [int] NOT NULL,
	[Ad] [varchar](30) NOT NULL,
	[Soyad] [varchar](30) NOT NULL,
	[Tel] [bigint] NOT NULL,
	[Cinsiyet] [varchar](50) NOT NULL,
	[kayitTarihi] [date] NOT NULL,
	[bitisTarihi] [date] NOT NULL,
	[Adres] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[PersonalId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Yonetici]    Script Date: 13.06.2020 18:31:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Yonetici](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[kullaniciAdi] [varchar](30) NOT NULL,
	[Sifre] [varchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[bedenBilgileri] ON 

INSERT [dbo].[bedenBilgileri] ([BedenId], [PersonalId], [Kilo], [Boy], [Kol], [Bel], [Gogus], [Kalca], [Omuz]) VALUES (1, 1, 64, 170, 32, 23, 24, 23, 32)
INSERT [dbo].[bedenBilgileri] ([BedenId], [PersonalId], [Kilo], [Boy], [Kol], [Bel], [Gogus], [Kalca], [Omuz]) VALUES (2, 2, 100, 190, 32, 60, 52, 30, 24)
INSERT [dbo].[bedenBilgileri] ([BedenId], [PersonalId], [Kilo], [Boy], [Kol], [Bel], [Gogus], [Kalca], [Omuz]) VALUES (3, 3, 60, 180, 20, 30, 25, 30, 32)
INSERT [dbo].[bedenBilgileri] ([BedenId], [PersonalId], [Kilo], [Boy], [Kol], [Bel], [Gogus], [Kalca], [Omuz]) VALUES (4, 4, 70, 170, 56, 63, 52, 20, 30)
INSERT [dbo].[bedenBilgileri] ([BedenId], [PersonalId], [Kilo], [Boy], [Kol], [Bel], [Gogus], [Kalca], [Omuz]) VALUES (5, 5, 130, 180, 60, 30, 50, 30, 60)
INSERT [dbo].[bedenBilgileri] ([BedenId], [PersonalId], [Kilo], [Boy], [Kol], [Bel], [Gogus], [Kalca], [Omuz]) VALUES (6, 6, 70, 80, 20, 30, 50, 30, 60)
SET IDENTITY_INSERT [dbo].[bedenBilgileri] OFF
SET IDENTITY_INSERT [dbo].[Odemeler] ON 

INSERT [dbo].[Odemeler] ([OdemeId], [PersonalId], [Ogrenci], [Odeme], [Tutar]) VALUES (1, 1, N'Evet', N'Peşin', 452)
INSERT [dbo].[Odemeler] ([OdemeId], [PersonalId], [Ogrenci], [Odeme], [Tutar]) VALUES (2, 2, N'Hayır', N'Peşin', 10545)
INSERT [dbo].[Odemeler] ([OdemeId], [PersonalId], [Ogrenci], [Odeme], [Tutar]) VALUES (3, 3, N'Hayır', N'Peşin', 915)
INSERT [dbo].[Odemeler] ([OdemeId], [PersonalId], [Ogrenci], [Odeme], [Tutar]) VALUES (4, 4, N'Evet', N'Peşin', 2920)
INSERT [dbo].[Odemeler] ([OdemeId], [PersonalId], [Ogrenci], [Odeme], [Tutar]) VALUES (5, 5, N'Hayır', N'Peşin', 43005)
INSERT [dbo].[Odemeler] ([OdemeId], [PersonalId], [Ogrenci], [Odeme], [Tutar]) VALUES (6, 6, N'Hayır', N'Peşin', 2590)
SET IDENTITY_INSERT [dbo].[Odemeler] OFF
INSERT [dbo].[personalInformation] ([PersonalId], [Ad], [Soyad], [Tel], [Cinsiyet], [kayitTarihi], [bitisTarihi], [Adres]) VALUES (1, N'kemal', N'bekcan', 5372725023, N'erkek', CAST(N'2020-01-01' AS Date), CAST(N'2020-06-30' AS Date), N'bursa')
INSERT [dbo].[personalInformation] ([PersonalId], [Ad], [Soyad], [Tel], [Cinsiyet], [kayitTarihi], [bitisTarihi], [Adres]) VALUES (2, N'zeynep', N'dere', 5345635654, N'kadın', CAST(N'2015-01-22' AS Date), CAST(N'2020-10-31' AS Date), N'bursa')
INSERT [dbo].[personalInformation] ([PersonalId], [Ad], [Soyad], [Tel], [Cinsiyet], [kayitTarihi], [bitisTarihi], [Adres]) VALUES (3, N'osman', N'duran', 5345623212, N'erkek', CAST(N'2019-12-01' AS Date), CAST(N'2020-06-01' AS Date), N'bursa')
INSERT [dbo].[personalInformation] ([PersonalId], [Ad], [Soyad], [Tel], [Cinsiyet], [kayitTarihi], [bitisTarihi], [Adres]) VALUES (4, N'merve', N'çelik', 5345635878, N'kadın', CAST(N'2017-01-19' AS Date), CAST(N'2020-04-01' AS Date), N'bursa')
INSERT [dbo].[personalInformation] ([PersonalId], [Ad], [Soyad], [Tel], [Cinsiyet], [kayitTarihi], [bitisTarihi], [Adres]) VALUES (5, N'mehmet', N'çetin', 5345621228, N'erkek', CAST(N'1990-11-23' AS Date), CAST(N'2014-06-11' AS Date), N'bursa')
INSERT [dbo].[personalInformation] ([PersonalId], [Ad], [Soyad], [Tel], [Cinsiyet], [kayitTarihi], [bitisTarihi], [Adres]) VALUES (6, N'berke', N'kaya', 5345875623, N'erkek', CAST(N'2009-06-01' AS Date), CAST(N'2010-11-01' AS Date), N'bursa')
SET IDENTITY_INSERT [dbo].[Yonetici] ON 

INSERT [dbo].[Yonetici] ([Id], [kullaniciAdi], [Sifre]) VALUES (1, N'kemal', N'bekcan')
INSERT [dbo].[Yonetici] ([Id], [kullaniciAdi], [Sifre]) VALUES (2, N'admin', N'123')
SET IDENTITY_INSERT [dbo].[Yonetici] OFF
ALTER TABLE [dbo].[bedenBilgileri]  WITH CHECK ADD  CONSTRAINT [FK__bedenBilg__Perso__4F7CD00D] FOREIGN KEY([PersonalId])
REFERENCES [dbo].[personalInformation] ([PersonalId])
ON UPDATE SET DEFAULT
ON DELETE SET DEFAULT
GO
ALTER TABLE [dbo].[bedenBilgileri] CHECK CONSTRAINT [FK__bedenBilg__Perso__4F7CD00D]
GO
ALTER TABLE [dbo].[Odemeler]  WITH CHECK ADD  CONSTRAINT [FK__Odemeler__Person__5070F446] FOREIGN KEY([PersonalId])
REFERENCES [dbo].[personalInformation] ([PersonalId])
ON UPDATE SET DEFAULT
ON DELETE SET DEFAULT
GO
ALTER TABLE [dbo].[Odemeler] CHECK CONSTRAINT [FK__Odemeler__Person__5070F446]
GO
