USE [AnaSınıfı]
GO
/****** Object:  Table [dbo].[Birim]    Script Date: 18.04.2019 11:50:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Birim](
	[BirimID] [int] IDENTITY(1,1) NOT NULL,
	[BirimAdı] [varchar](50) NULL,
 CONSTRAINT [PK_Birim] PRIMARY KEY CLUSTERED 
(
	[BirimID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Çocuk]    Script Date: 18.04.2019 11:50:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Çocuk](
	[ÇocukID] [int] IDENTITY(1,1) NOT NULL,
	[TC] [int] NULL,
	[Adı] [varchar](50) NULL,
	[Soyadı] [varchar](50) NULL,
	[Yaş] [int] NULL,
	[Cinsiyet] [varchar](50) NULL,
 CONSTRAINT [PK_Çocuk] PRIMARY KEY CLUSTERED 
(
	[ÇocukID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Görevlendirme]    Script Date: 18.04.2019 11:50:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Görevlendirme](
	[GörevID] [int] IDENTITY(1,1) NOT NULL,
	[GörevAdı] [varchar](50) NULL,
	[GörevYeri] [varchar](50) NULL,
 CONSTRAINT [PK_Görevlendirme] PRIMARY KEY CLUSTERED 
(
	[GörevID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Hocalar]    Script Date: 18.04.2019 11:50:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Hocalar](
	[HocaID] [int] IDENTITY(1,1) NOT NULL,
	[HocaAdıSoyadı] [varchar](50) NULL,
	[ÇocukID] [int] NULL,
	[BirimID] [int] NULL,
	[GörevID] [int] NULL,
	[ŞubeID] [int] NULL,
	[ProjeID] [int] NULL,
 CONSTRAINT [PK_Hocalar] PRIMARY KEY CLUSTERED 
(
	[HocaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Ödeme]    Script Date: 18.04.2019 11:50:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Ödeme](
	[ÖdemeID] [int] IDENTITY(1,1) NOT NULL,
	[ÖdemeTipi] [varchar](50) NULL,
	[GeçerlilikDurumu] [varchar](50) NULL,
	[Tutar] [money] NULL,
	[ÇocukID] [int] NULL,
 CONSTRAINT [PK_Ödeme] PRIMARY KEY CLUSTERED 
(
	[ÖdemeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Proje]    Script Date: 18.04.2019 11:50:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Proje](
	[ProjeID] [int] IDENTITY(1,1) NOT NULL,
	[ProjeAdı] [varchar](50) NULL,
	[KatıldığıŞehir] [varchar](50) NULL,
	[ProjeKonusu] [varchar](50) NULL,
	[ÇocukID] [int] NULL,
 CONSTRAINT [PK_Proje] PRIMARY KEY CLUSTERED 
(
	[ProjeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Rehberlik]    Script Date: 18.04.2019 11:50:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Rehberlik](
	[RehberlikID] [int] IDENTITY(1,1) NOT NULL,
	[RehberlikDurumu] [varchar](50) NULL,
	[Tespit] [varchar](50) NULL,
	[Açıklama] [varchar](50) NULL,
	[ÇocukID] [int] NULL,
 CONSTRAINT [PK_Rehberlik] PRIMARY KEY CLUSTERED 
(
	[RehberlikID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Şube]    Script Date: 18.04.2019 11:50:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Şube](
	[ŞubeID] [int] IDENTITY(1,1) NOT NULL,
	[ŞubeAdı] [varchar](50) NULL,
	[BirimID] [int] NULL,
	[ÇocukID] [int] NULL,
 CONSTRAINT [PK_Şube] PRIMARY KEY CLUSTERED 
(
	[ŞubeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Veli]    Script Date: 18.04.2019 11:50:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Veli](
	[VeliID] [int] IDENTITY(1,1) NOT NULL,
	[ÇocukID] [int] NULL,
	[ÖdemeID] [int] NULL,
	[ProjeID] [int] NULL,
	[ŞubeID] [int] NULL,
	[RehberlikID] [int] NULL,
 CONSTRAINT [PK_Veli] PRIMARY KEY CLUSTERED 
(
	[VeliID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Hocalar]  WITH CHECK ADD  CONSTRAINT [FK_Hocalar_Birim] FOREIGN KEY([BirimID])
REFERENCES [dbo].[Birim] ([BirimID])
GO
ALTER TABLE [dbo].[Hocalar] CHECK CONSTRAINT [FK_Hocalar_Birim]
GO
ALTER TABLE [dbo].[Hocalar]  WITH CHECK ADD  CONSTRAINT [FK_Hocalar_Çocuk] FOREIGN KEY([ÇocukID])
REFERENCES [dbo].[Çocuk] ([ÇocukID])
GO
ALTER TABLE [dbo].[Hocalar] CHECK CONSTRAINT [FK_Hocalar_Çocuk]
GO
ALTER TABLE [dbo].[Hocalar]  WITH CHECK ADD  CONSTRAINT [FK_Hocalar_Görevlendirme] FOREIGN KEY([GörevID])
REFERENCES [dbo].[Görevlendirme] ([GörevID])
GO
ALTER TABLE [dbo].[Hocalar] CHECK CONSTRAINT [FK_Hocalar_Görevlendirme]
GO
ALTER TABLE [dbo].[Hocalar]  WITH CHECK ADD  CONSTRAINT [FK_Hocalar_Proje] FOREIGN KEY([ProjeID])
REFERENCES [dbo].[Proje] ([ProjeID])
GO
ALTER TABLE [dbo].[Hocalar] CHECK CONSTRAINT [FK_Hocalar_Proje]
GO
ALTER TABLE [dbo].[Hocalar]  WITH CHECK ADD  CONSTRAINT [FK_Hocalar_Şube] FOREIGN KEY([ŞubeID])
REFERENCES [dbo].[Şube] ([ŞubeID])
GO
ALTER TABLE [dbo].[Hocalar] CHECK CONSTRAINT [FK_Hocalar_Şube]
GO
ALTER TABLE [dbo].[Ödeme]  WITH CHECK ADD  CONSTRAINT [FK_Ödeme_Çocuk] FOREIGN KEY([ÇocukID])
REFERENCES [dbo].[Çocuk] ([ÇocukID])
GO
ALTER TABLE [dbo].[Ödeme] CHECK CONSTRAINT [FK_Ödeme_Çocuk]
GO
ALTER TABLE [dbo].[Proje]  WITH CHECK ADD  CONSTRAINT [FK_Proje_Çocuk] FOREIGN KEY([ÇocukID])
REFERENCES [dbo].[Çocuk] ([ÇocukID])
GO
ALTER TABLE [dbo].[Proje] CHECK CONSTRAINT [FK_Proje_Çocuk]
GO
ALTER TABLE [dbo].[Rehberlik]  WITH CHECK ADD  CONSTRAINT [FK_Rehberlik_Çocuk] FOREIGN KEY([ÇocukID])
REFERENCES [dbo].[Çocuk] ([ÇocukID])
GO
ALTER TABLE [dbo].[Rehberlik] CHECK CONSTRAINT [FK_Rehberlik_Çocuk]
GO
ALTER TABLE [dbo].[Şube]  WITH CHECK ADD  CONSTRAINT [FK_Şube_Birim] FOREIGN KEY([BirimID])
REFERENCES [dbo].[Birim] ([BirimID])
GO
ALTER TABLE [dbo].[Şube] CHECK CONSTRAINT [FK_Şube_Birim]
GO
ALTER TABLE [dbo].[Şube]  WITH CHECK ADD  CONSTRAINT [FK_Şube_Çocuk] FOREIGN KEY([ÇocukID])
REFERENCES [dbo].[Çocuk] ([ÇocukID])
GO
ALTER TABLE [dbo].[Şube] CHECK CONSTRAINT [FK_Şube_Çocuk]
GO
ALTER TABLE [dbo].[Veli]  WITH CHECK ADD  CONSTRAINT [FK_Veli_Çocuk] FOREIGN KEY([ÇocukID])
REFERENCES [dbo].[Çocuk] ([ÇocukID])
GO
ALTER TABLE [dbo].[Veli] CHECK CONSTRAINT [FK_Veli_Çocuk]
GO
ALTER TABLE [dbo].[Veli]  WITH CHECK ADD  CONSTRAINT [FK_Veli_Ödeme] FOREIGN KEY([ÖdemeID])
REFERENCES [dbo].[Ödeme] ([ÖdemeID])
GO
ALTER TABLE [dbo].[Veli] CHECK CONSTRAINT [FK_Veli_Ödeme]
GO
ALTER TABLE [dbo].[Veli]  WITH CHECK ADD  CONSTRAINT [FK_Veli_Proje] FOREIGN KEY([ProjeID])
REFERENCES [dbo].[Proje] ([ProjeID])
GO
ALTER TABLE [dbo].[Veli] CHECK CONSTRAINT [FK_Veli_Proje]
GO
ALTER TABLE [dbo].[Veli]  WITH CHECK ADD  CONSTRAINT [FK_Veli_Rehberlik] FOREIGN KEY([RehberlikID])
REFERENCES [dbo].[Rehberlik] ([RehberlikID])
GO
ALTER TABLE [dbo].[Veli] CHECK CONSTRAINT [FK_Veli_Rehberlik]
GO
ALTER TABLE [dbo].[Veli]  WITH CHECK ADD  CONSTRAINT [FK_Veli_Şube] FOREIGN KEY([ŞubeID])
REFERENCES [dbo].[Şube] ([ŞubeID])
GO
ALTER TABLE [dbo].[Veli] CHECK CONSTRAINT [FK_Veli_Şube]
GO
