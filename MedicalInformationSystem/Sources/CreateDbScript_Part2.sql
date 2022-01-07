USE [MedicalCorporation]

/****** Object:  Table [dbo].[Administrators]    Script Date: 23.12.2021 19:35:12 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[Administrators](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](128) NOT NULL,
	[Surname] [nvarchar](128) NOT NULL,
	[Middlename] [nvarchar](128) NOT NULL,
	[Sex] [int] NOT NULL,
	[TownId] [int] NOT NULL,
	[Wage] [float] NOT NULL,
	[Login] [nvarchar](128) NOT NULL,
	[Password] [nvarchar](128) NOT NULL,
 CONSTRAINT [PK_Administrators] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [dbo].[Appointments]    Script Date: 23.12.2021 19:35:12 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[Appointments](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DoctorId] [int] NOT NULL,
	[UserId] [int] NOT NULL,
	[Description] [nvarchar](128) NOT NULL,
	[Price] [float] NOT NULL,
	[CreateDate] [datetime] NOT NULL,
	[AppointmentDate] [datetime] NOT NULL,
 CONSTRAINT [PK_Appointments] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [dbo].[Doctors]    Script Date: 23.12.2021 19:35:12 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[Doctors](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](128) NOT NULL,
	[Surname] [nvarchar](128) NOT NULL,
	[Middlename] [nvarchar](128) NOT NULL,
	[Sex] [int] NOT NULL,
	[HospitalId] [int] NOT NULL,
	[Speciality] [nvarchar](128) NOT NULL,
	[AppointmentPrice] [float] NOT NULL,
	[Office] [int] NOT NULL,
	[Wage] [float] NOT NULL,
	[Login] [nvarchar](128) NOT NULL,
	[Password] [nvarchar](128) NOT NULL,
 CONSTRAINT [PK_Doctors] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [dbo].[Hospitals]    Script Date: 23.12.2021 19:35:12 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[Hospitals](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](128) NOT NULL,
	[Address] [nvarchar](128) NOT NULL,
	[Description] [nvarchar](128) NOT NULL,
	[Rating] [float] NOT NULL,
 CONSTRAINT [PK_Hospitals] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [dbo].[HospitalsInTowns]    Script Date: 23.12.2021 19:35:12 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[HospitalsInTowns](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TownId] [int] NOT NULL,
	[HospitalId] [int] NOT NULL,
 CONSTRAINT [PK_HospitalsInTowns] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [dbo].[Towns]    Script Date: 23.12.2021 19:35:12 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[Towns](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](128) NOT NULL,
	[Region] [nvarchar](128) NOT NULL,
	[Rating] [float] NOT NULL,
 CONSTRAINT [PK_Towns] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [dbo].[Users]    Script Date: 23.12.2021 19:35:12 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[Users](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](128) NOT NULL,
	[Surname] [nvarchar](128) NOT NULL,
	[Middlename] [nvarchar](128) NOT NULL,
	[Sex] [int] NOT NULL,
	[Age] [int] NOT NULL,
	[TownId] [int] NOT NULL,
	[Login] [nvarchar](128) NOT NULL,
	[Password] [nvarchar](128) NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

SET IDENTITY_INSERT [dbo].[Administrators] ON 

INSERT [dbo].[Administrators] ([Id], [Name], [Surname], [Middlename], [Sex], [TownId], [Wage], [Login], [Password]) VALUES (1, N'Сергей', N'Медведев', N'Романович', 1, 1, 60000, N'medvedev', N'1812')

INSERT [dbo].[Administrators] ([Id], [Name], [Surname], [Middlename], [Sex], [TownId], [Wage], [Login], [Password]) VALUES (2, N'София', N'Фадеева', N'Матвеевна', 2, 2, 60000, N'fadeeva', N'144')

INSERT [dbo].[Administrators] ([Id], [Name], [Surname], [Middlename], [Sex], [TownId], [Wage], [Login], [Password]) VALUES (3, N'Оливия', N'Киреева', N'Кирилловна', 2, 1, 90000, N'kireeva', N'4912')

SET IDENTITY_INSERT [dbo].[Administrators] OFF

SET IDENTITY_INSERT [dbo].[Appointments] ON 

INSERT [dbo].[Appointments] ([Id], [DoctorId], [UserId], [Description], [Price], [CreateDate], [AppointmentDate]) VALUES (1, 3, 1, N'Болезнь', 1000, CAST(N'2021-11-20T15:34:05.000' AS DateTime), CAST(N'2021-11-21T15:00:00.000' AS DateTime))

INSERT [dbo].[Appointments] ([Id], [DoctorId], [UserId], [Description], [Price], [CreateDate], [AppointmentDate]) VALUES (2, 2, 2, N'Болезнь', 900, CAST(N'2021-11-20T16:02:30.000' AS DateTime), CAST(N'2021-11-23T08:00:00.000' AS DateTime))

INSERT [dbo].[Appointments] ([Id], [DoctorId], [UserId], [Description], [Price], [CreateDate], [AppointmentDate]) VALUES (3, 1, 3, N'Прфоилактика', 900, CAST(N'2021-11-21T11:37:05.000' AS DateTime), CAST(N'2021-11-22T11:30:00.000' AS DateTime))

INSERT [dbo].[Appointments] ([Id], [DoctorId], [UserId], [Description], [Price], [CreateDate], [AppointmentDate]) VALUES (4, 2, 2, N'Консультация', 900, CAST(N'2021-11-22T12:36:05.000' AS DateTime), CAST(N'2021-11-23T12:30:00.000' AS DateTime))

INSERT [dbo].[Appointments] ([Id], [DoctorId], [UserId], [Description], [Price], [CreateDate], [AppointmentDate]) VALUES (5, 2, 3, N'Болезнь', 1500, CAST(N'2021-11-22T13:30:02.000' AS DateTime), CAST(N'2021-11-23T13:30:00.000' AS DateTime))

INSERT [dbo].[Appointments] ([Id], [DoctorId], [UserId], [Description], [Price], [CreateDate], [AppointmentDate]) VALUES (6, 4, 7, N'Болезнь', 1200, CAST(N'2021-11-23T08:30:25.000' AS DateTime), CAST(N'2021-11-24T08:00:00.000' AS DateTime))

INSERT [dbo].[Appointments] ([Id], [DoctorId], [UserId], [Description], [Price], [CreateDate], [AppointmentDate]) VALUES (7, 1, 5, N'Простуда', 900, CAST(N'2021-11-24T08:30:35.000' AS DateTime), CAST(N'2021-11-25T11:30:00.000' AS DateTime))

SET IDENTITY_INSERT [dbo].[Appointments] OFF

SET IDENTITY_INSERT [dbo].[Doctors] ON 

INSERT [dbo].[Doctors] ([Id], [Name], [Surname], [Middlename], [Sex], [HospitalId], [Speciality], [AppointmentPrice], [Office], [Wage], [Login], [Password]) VALUES (1, N'Вероника', N'Васильева', N'Егоровна', 2, 1, N'Кардиолог', 900, 15, 75000, N'vasilyeva', N'1234')

INSERT [dbo].[Doctors] ([Id], [Name], [Surname], [Middlename], [Sex], [HospitalId], [Speciality], [AppointmentPrice], [Office], [Wage], [Login], [Password]) VALUES (2, N'Константин', N'Дубов', N'Фёдорович', 1, 2, N'Хирург', 1200, 16, 75000, N'dubov', N'12')

INSERT [dbo].[Doctors] ([Id], [Name], [Surname], [Middlename], [Sex], [HospitalId], [Speciality], [AppointmentPrice], [Office], [Wage], [Login], [Password]) VALUES (3, N'Алиса', N'Филиппова', N'Егоровна', 2, 1, N'Дерматовенеролог', 1500, 7, 90000, N'filippova', N'123')

INSERT [dbo].[Doctors] ([Id], [Name], [Surname], [Middlename], [Sex], [HospitalId], [Speciality], [AppointmentPrice], [Office], [Wage], [Login], [Password]) VALUES (4, N'Глеб', N'Матвеев', N'Денисович', 1, 3, N'Иммунолог', 900, 23, 75000, N'matveev', N'4321')

INSERT [dbo].[Doctors] ([Id], [Name], [Surname], [Middlename], [Sex], [HospitalId], [Speciality], [AppointmentPrice], [Office], [Wage], [Login], [Password]) VALUES (5, N'Виктория', N'Булатова', N'Владимировна', 2, 5, N'Акушер', 900, 33, 75000, N'bulatova', N'55555')

INSERT [dbo].[Doctors] ([Id], [Name], [Surname], [Middlename], [Sex], [HospitalId], [Speciality], [AppointmentPrice], [Office], [Wage], [Login], [Password]) VALUES (6, N'Эмилия', N'Ларина', N'Данииловна', 2, 4, N'Акушер', 1200, 30, 90000, N'larina', N'666666')

INSERT [dbo].[Doctors] ([Id], [Name], [Surname], [Middlename], [Sex], [HospitalId], [Speciality], [AppointmentPrice], [Office], [Wage], [Login], [Password]) VALUES (7, N'Мия', N'Смирнова', N'Андреевна', 2, 4, N'Дерматовенеролог', 1500, 41, 90000, N'smirnova', N'777')

INSERT [dbo].[Doctors] ([Id], [Name], [Surname], [Middlename], [Sex], [HospitalId], [Speciality], [AppointmentPrice], [Office], [Wage], [Login], [Password]) VALUES (8, N'Давид', N'Кузнецов', N'Арсентьевич', 1, 5, N'Хирург', 1000, 12, 75000, N'kuznetsov', N'678')

SET IDENTITY_INSERT [dbo].[Doctors] OFF

SET IDENTITY_INSERT [dbo].[Hospitals] ON 

INSERT [dbo].[Hospitals] ([Id], [Name], [Address], [Description], [Rating]) VALUES (1, N'Поликлиника № 2', N'2-я Бульварная ул., 38', N'Городская больница', 8.8)

INSERT [dbo].[Hospitals] ([Id], [Name], [Address], [Description], [Rating]) VALUES (2, N'Хирургическое отделение #1', N'ул. Пирогова, 23', N'Хирургическое отделение Городской клинической больницы', 9.2)

INSERT [dbo].[Hospitals] ([Id], [Name], [Address], [Description], [Rating]) VALUES (3, N'Центральная городская больница', N'пр. Калинина, 32к4', N'Городская клиническая больница', 9.5)

INSERT [dbo].[Hospitals] ([Id], [Name], [Address], [Description], [Rating]) VALUES (4, N'Городская поликлиника № 1', N'Первомайский пр., 15', N'ГБУЗ СК Городская поликлиника № 1 г. Кисловодска', 9.3)

INSERT [dbo].[Hospitals] ([Id], [Name], [Address], [Description], [Rating]) VALUES (5, N'1-е кардиологическое отделение', N'ул. Кутузова, 128', N'1-е кардиологическое отделение Кисловодской центральной городской больницы', 9.2)

SET IDENTITY_INSERT [dbo].[Hospitals] OFF

SET IDENTITY_INSERT [dbo].[HospitalsInTowns] ON 

INSERT [dbo].[HospitalsInTowns] ([Id], [TownId], [HospitalId]) VALUES (1, 1, 1)

INSERT [dbo].[HospitalsInTowns] ([Id], [TownId], [HospitalId]) VALUES (2, 1, 2)

INSERT [dbo].[HospitalsInTowns] ([Id], [TownId], [HospitalId]) VALUES (3, 1, 3)

INSERT [dbo].[HospitalsInTowns] ([Id], [TownId], [HospitalId]) VALUES (4, 2, 4)

INSERT [dbo].[HospitalsInTowns] ([Id], [TownId], [HospitalId]) VALUES (5, 2, 5)

SET IDENTITY_INSERT [dbo].[HospitalsInTowns] OFF

SET IDENTITY_INSERT [dbo].[Towns] ON 

INSERT [dbo].[Towns] ([Id], [Name], [Region], [Rating]) VALUES (1, N'Пятигорск', N'Ставропольский край', 9.3)

INSERT [dbo].[Towns] ([Id], [Name], [Region], [Rating]) VALUES (2, N'Кисловодск', N'Ставропольский край', 8.9)

SET IDENTITY_INSERT [dbo].[Towns] OFF

SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([Id], [Name], [Surname], [Middlename], [Sex], [Age], [TownId], [Login], [Password]) VALUES (1, N'Антонина', N'Григорьева', N'Константиновна', 2, 22, 1, N'gririeva', N'1234')

INSERT [dbo].[Users] ([Id], [Name], [Surname], [Middlename], [Sex], [Age], [TownId], [Login], [Password]) VALUES (2, N'Елизавета', N'Смирнова', N'Максимовна', 2, 23, 1, N'smirnova', N'22')

INSERT [dbo].[Users] ([Id], [Name], [Surname], [Middlename], [Sex], [Age], [TownId], [Login], [Password]) VALUES (3, N'Злата', N'Суворова', N'Андреевна', 2, 19, 2, N'suvorov', N'333')

INSERT [dbo].[Users] ([Id], [Name], [Surname], [Middlename], [Sex], [Age], [TownId], [Login], [Password]) VALUES (4, N'Алиса', N'Степанова', N'Арсентьевна', 2, 32, 1, N'stepanova', N'4444')

INSERT [dbo].[Users] ([Id], [Name], [Surname], [Middlename], [Sex], [Age], [TownId], [Login], [Password]) VALUES (5, N'Никита', N'Кочетов', N'Семёнович', 1, 18, 1, N'kochetov', N'55555')

INSERT [dbo].[Users] ([Id], [Name], [Surname], [Middlename], [Sex], [Age], [TownId], [Login], [Password]) VALUES (6, N'Матвей', N'Щербаков', N'Георгиевич', 1, 45, 2, N'shcherbakov', N'666666')

INSERT [dbo].[Users] ([Id], [Name], [Surname], [Middlename], [Sex], [Age], [TownId], [Login], [Password]) VALUES (7, N'Вероника', N'Васильева', N'Егоровна', 2, 33, 1, N'vasilyeva', N'777')

SET IDENTITY_INSERT [dbo].[Users] OFF

ALTER TABLE [dbo].[Appointments] ADD  CONSTRAINT [DF_Appointments_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]

ALTER TABLE [dbo].[Administrators]  WITH CHECK ADD  CONSTRAINT [FK_Towns_Administrators] FOREIGN KEY([TownId])
REFERENCES [dbo].[Towns] ([Id])

ALTER TABLE [dbo].[Administrators] CHECK CONSTRAINT [FK_Towns_Administrators]

ALTER TABLE [dbo].[Appointments]  WITH CHECK ADD  CONSTRAINT [FK_Appointments_Doctors] FOREIGN KEY([DoctorId])
REFERENCES [dbo].[Doctors] ([Id])

ALTER TABLE [dbo].[Appointments] CHECK CONSTRAINT [FK_Appointments_Doctors]

ALTER TABLE [dbo].[Appointments]  WITH CHECK ADD  CONSTRAINT [FK_Appointments_Users] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])

ALTER TABLE [dbo].[Appointments] CHECK CONSTRAINT [FK_Appointments_Users]

ALTER TABLE [dbo].[Doctors]  WITH CHECK ADD  CONSTRAINT [FK_Doctors_Hospitals] FOREIGN KEY([HospitalId])
REFERENCES [dbo].[Hospitals] ([Id])

ALTER TABLE [dbo].[Doctors] CHECK CONSTRAINT [FK_Doctors_Hospitals]

ALTER TABLE [dbo].[HospitalsInTowns]  WITH CHECK ADD  CONSTRAINT [FK_HospitalsInTowns_Hospitals] FOREIGN KEY([HospitalId])
REFERENCES [dbo].[Hospitals] ([Id])

ALTER TABLE [dbo].[HospitalsInTowns] CHECK CONSTRAINT [FK_HospitalsInTowns_Hospitals]

ALTER TABLE [dbo].[HospitalsInTowns]  WITH CHECK ADD  CONSTRAINT [FK_HospitalsInTowns_Towns] FOREIGN KEY([TownId])
REFERENCES [dbo].[Towns] ([Id])

ALTER TABLE [dbo].[HospitalsInTowns] CHECK CONSTRAINT [FK_HospitalsInTowns_Towns]

ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_Towns] FOREIGN KEY([TownId])
REFERENCES [dbo].[Towns] ([Id])

ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_Towns]

USE [master]

ALTER DATABASE [MedicalCorporation] SET  READ_WRITE 
