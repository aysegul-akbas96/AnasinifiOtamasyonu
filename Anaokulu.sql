USE [Anaokulu]
GO
/****** Object:  Table [dbo].[Birim]    Script Date: 17.04.2019 10:01:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Birim](
	[BirimID] [int] IDENTITY(1,1) NOT NULL,
	[BirimAdi] [varchar](50) NULL,
 CONSTRAINT [PK_Birim] PRIMARY KEY CLUSTERED 
(
	[BirimID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Cocuk]    Script Date: 17.04.2019 10:01:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Cocuk](
	[CocukTC] [char](11) NOT NULL,
	[AdSoyad] [varchar](50) NULL,
	[Yas] [int] NULL,
	[Cinsiyet] [char](10) NULL,
 CONSTRAINT [PK_Cocuk] PRIMARY KEY CLUSTERED 
(
	[CocukTC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Gorevlendirme]    Script Date: 17.04.2019 10:01:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Gorevlendirme](
	[GorevID] [int] IDENTITY(1,1) NOT NULL,
	[GorevAdi] [varchar](50) NULL,
	[GorevYeri] [varchar](50) NULL,
 CONSTRAINT [PK_Gorevlendirme] PRIMARY KEY CLUSTERED 
(
	[GorevID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Hoca]    Script Date: 17.04.2019 10:01:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Hoca](
	[HocaID] [int] IDENTITY(1,1) NOT NULL,
	[CocukTC] [char](11) NULL,
	[BirimID] [int] NULL,
	[GorevID] [int] NULL,
	[SubeID] [int] NULL,
	[ProjeID] [int] NULL,
	[HocaAdSoyad] [varchar](50) NULL,
 CONSTRAINT [PK_Hoca] PRIMARY KEY CLUSTERED 
(
	[HocaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Odeme]    Script Date: 17.04.2019 10:01:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Odeme](
	[OdemeID] [int] IDENTITY(1,1) NOT NULL,
	[CocukTC] [char](11) NULL,
	[Tutar] [money] NULL,
	[OdemeTipi] [varchar](50) NULL,
	[GecerlilikDurumu] [varchar](50) NULL,
 CONSTRAINT [PK_Odeme] PRIMARY KEY CLUSTERED 
(
	[OdemeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Proje]    Script Date: 17.04.2019 10:01:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Proje](
	[ProjeID] [int] IDENTITY(1,1) NOT NULL,
	[CocukTC] [char](11) NULL,
	[ProjeAdi] [varchar](50) NULL,
	[KatildigiSehir] [varchar](50) NULL,
	[ProjeKonusu] [varchar](50) NULL,
 CONSTRAINT [PK_Proje] PRIMARY KEY CLUSTERED 
(
	[ProjeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Rehberlik]    Script Date: 17.04.2019 10:01:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Rehberlik](
	[RehberlikID] [int] IDENTITY(1,1) NOT NULL,
	[CocukTC] [char](11) NULL,
	[Durum] [varchar](50) NULL,
	[Aciklama] [varchar](150) NULL,
	[Tespit] [varchar](50) NULL,
 CONSTRAINT [PK_Rehberlik] PRIMARY KEY CLUSTERED 
(
	[RehberlikID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Sube]    Script Date: 17.04.2019 10:01:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Sube](
	[SubeID] [int] IDENTITY(1,1) NOT NULL,
	[CocukTC] [char](11) NULL,
	[SubeAdi] [varchar](50) NULL,
	[BirimID] [int] NULL,
 CONSTRAINT [PK_Sube] PRIMARY KEY CLUSTERED 
(
	[SubeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Birim] ON 

INSERT [dbo].[Birim] ([BirimID], [BirimAdi]) VALUES (1, N'3+')
INSERT [dbo].[Birim] ([BirimID], [BirimAdi]) VALUES (2, N'4+')
INSERT [dbo].[Birim] ([BirimID], [BirimAdi]) VALUES (3, N'5+')
INSERT [dbo].[Birim] ([BirimID], [BirimAdi]) VALUES (4, N'2+')
SET IDENTITY_INSERT [dbo].[Birim] OFF
INSERT [dbo].[Cocuk] ([CocukTC], [AdSoyad], [Yas], [Cinsiyet]) VALUES (N'12345678910', N'Ayşe Nur', 5, N'KIZ       ')
INSERT [dbo].[Cocuk] ([CocukTC], [AdSoyad], [Yas], [Cinsiyet]) VALUES (N'14304062640', N'Selim Uysal', 4, N'Erkek     ')
SET IDENTITY_INSERT [dbo].[Gorevlendirme] ON 

INSERT [dbo].[Gorevlendirme] ([GorevID], [GorevAdi], [GorevYeri]) VALUES (1, N'Oyun Saati', N'Oyun Odası')
INSERT [dbo].[Gorevlendirme] ([GorevID], [GorevAdi], [GorevYeri]) VALUES (2, N'Yemek Saati', N'aaaa')
SET IDENTITY_INSERT [dbo].[Gorevlendirme] OFF
SET IDENTITY_INSERT [dbo].[Hoca] ON 

INSERT [dbo].[Hoca] ([HocaID], [CocukTC], [BirimID], [GorevID], [SubeID], [ProjeID], [HocaAdSoyad]) VALUES (1, N'14304062640', 1, 1, 1, 1, N'Nagihan Uysal')
INSERT [dbo].[Hoca] ([HocaID], [CocukTC], [BirimID], [GorevID], [SubeID], [ProjeID], [HocaAdSoyad]) VALUES (3, N'12345678910', 2, 1, 1, 1, N'Büşra')
SET IDENTITY_INSERT [dbo].[Hoca] OFF
SET IDENTITY_INSERT [dbo].[Odeme] ON 

INSERT [dbo].[Odeme] ([OdemeID], [CocukTC], [Tutar], [OdemeTipi], [GecerlilikDurumu]) VALUES (1, N'14304062640', 2000.0000, N'Nakit', N'Ödendi')
INSERT [dbo].[Odeme] ([OdemeID], [CocukTC], [Tutar], [OdemeTipi], [GecerlilikDurumu]) VALUES (3, N'12345678910', 1200.0000, N'8 Taksit', N'5 taksit ödendi')
SET IDENTITY_INSERT [dbo].[Odeme] OFF
SET IDENTITY_INSERT [dbo].[Proje] ON 

INSERT [dbo].[Proje] ([ProjeID], [CocukTC], [ProjeAdi], [KatildigiSehir], [ProjeKonusu]) VALUES (1, N'14304062640', N'Temiz Çevre', N'İstanbul', N'Geri dönüşüm')
INSERT [dbo].[Proje] ([ProjeID], [CocukTC], [ProjeAdi], [KatildigiSehir], [ProjeKonusu]) VALUES (2, N'14304062640', N'aaaaaaa', N'ankara', N'cccccc')
SET IDENTITY_INSERT [dbo].[Proje] OFF
SET IDENTITY_INSERT [dbo].[Rehberlik] ON 

INSERT [dbo].[Rehberlik] ([RehberlikID], [CocukTC], [Durum], [Aciklama], [Tespit]) VALUES (1, N'14304062640', N'Kaygı', N'Yanlış yapma kaygısı', N'Parmak kaldırmama')
INSERT [dbo].[Rehberlik] ([RehberlikID], [CocukTC], [Durum], [Aciklama], [Tespit]) VALUES (2, N'14304062640', N'Korku', N'aaaaaaaaaaaa', N'Ağlama krizleri')
SET IDENTITY_INSERT [dbo].[Rehberlik] OFF
SET IDENTITY_INSERT [dbo].[Sube] ON 

INSERT [dbo].[Sube] ([SubeID], [CocukTC], [SubeAdi], [BirimID]) VALUES (1, N'12345678910', N'A Şubesi', 1)
INSERT [dbo].[Sube] ([SubeID], [CocukTC], [SubeAdi], [BirimID]) VALUES (3, N'14304062640', N'B Şubesi', 4)
SET IDENTITY_INSERT [dbo].[Sube] OFF
ALTER TABLE [dbo].[Hoca]  WITH CHECK ADD  CONSTRAINT [FK_Hoca_Birim] FOREIGN KEY([BirimID])
REFERENCES [dbo].[Birim] ([BirimID])
GO
ALTER TABLE [dbo].[Hoca] CHECK CONSTRAINT [FK_Hoca_Birim]
GO
ALTER TABLE [dbo].[Hoca]  WITH CHECK ADD  CONSTRAINT [FK_Hoca_Cocuk] FOREIGN KEY([CocukTC])
REFERENCES [dbo].[Cocuk] ([CocukTC])
GO
ALTER TABLE [dbo].[Hoca] CHECK CONSTRAINT [FK_Hoca_Cocuk]
GO
ALTER TABLE [dbo].[Hoca]  WITH CHECK ADD  CONSTRAINT [FK_Hoca_Gorevlendirme] FOREIGN KEY([GorevID])
REFERENCES [dbo].[Gorevlendirme] ([GorevID])
GO
ALTER TABLE [dbo].[Hoca] CHECK CONSTRAINT [FK_Hoca_Gorevlendirme]
GO
ALTER TABLE [dbo].[Hoca]  WITH CHECK ADD  CONSTRAINT [FK_Hoca_Proje] FOREIGN KEY([ProjeID])
REFERENCES [dbo].[Proje] ([ProjeID])
GO
ALTER TABLE [dbo].[Hoca] CHECK CONSTRAINT [FK_Hoca_Proje]
GO
ALTER TABLE [dbo].[Hoca]  WITH CHECK ADD  CONSTRAINT [FK_Hoca_Sube] FOREIGN KEY([SubeID])
REFERENCES [dbo].[Sube] ([SubeID])
GO
ALTER TABLE [dbo].[Hoca] CHECK CONSTRAINT [FK_Hoca_Sube]
GO
ALTER TABLE [dbo].[Odeme]  WITH CHECK ADD  CONSTRAINT [FK_Odeme_Cocuk] FOREIGN KEY([CocukTC])
REFERENCES [dbo].[Cocuk] ([CocukTC])
GO
ALTER TABLE [dbo].[Odeme] CHECK CONSTRAINT [FK_Odeme_Cocuk]
GO
ALTER TABLE [dbo].[Proje]  WITH CHECK ADD  CONSTRAINT [FK_Proje_Cocuk] FOREIGN KEY([CocukTC])
REFERENCES [dbo].[Cocuk] ([CocukTC])
GO
ALTER TABLE [dbo].[Proje] CHECK CONSTRAINT [FK_Proje_Cocuk]
GO
ALTER TABLE [dbo].[Rehberlik]  WITH CHECK ADD  CONSTRAINT [FK_Rehberlik_Cocuk] FOREIGN KEY([CocukTC])
REFERENCES [dbo].[Cocuk] ([CocukTC])
GO
ALTER TABLE [dbo].[Rehberlik] CHECK CONSTRAINT [FK_Rehberlik_Cocuk]
GO
ALTER TABLE [dbo].[Sube]  WITH CHECK ADD  CONSTRAINT [FK_Sube_Birim] FOREIGN KEY([BirimID])
REFERENCES [dbo].[Birim] ([BirimID])
GO
ALTER TABLE [dbo].[Sube] CHECK CONSTRAINT [FK_Sube_Birim]
GO
ALTER TABLE [dbo].[Sube]  WITH CHECK ADD  CONSTRAINT [FK_Sube_Cocuk] FOREIGN KEY([CocukTC])
REFERENCES [dbo].[Cocuk] ([CocukTC])
GO
ALTER TABLE [dbo].[Sube] CHECK CONSTRAINT [FK_Sube_Cocuk]
GO
