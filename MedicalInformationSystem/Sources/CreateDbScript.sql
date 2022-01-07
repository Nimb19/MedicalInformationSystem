USE [master]

/****** Object:  Database [MedicalCorporation]    Script Date: 07.01.2022 21:48:14 ******/
CREATE DATABASE [MedicalCorporation]
 CONTAINMENT = NONE
 WITH CATALOG_COLLATION = DATABASE_DEFAULT

ALTER DATABASE [MedicalCorporation] SET COMPATIBILITY_LEVEL = 150

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MedicalCorporation].[dbo].[sp_fulltext_database] @action = 'enable'
end

ALTER DATABASE [MedicalCorporation] SET ANSI_NULL_DEFAULT OFF 

ALTER DATABASE [MedicalCorporation] SET ANSI_NULLS OFF 

ALTER DATABASE [MedicalCorporation] SET ANSI_PADDING OFF 

ALTER DATABASE [MedicalCorporation] SET ANSI_WARNINGS OFF 

ALTER DATABASE [MedicalCorporation] SET ARITHABORT OFF 

ALTER DATABASE [MedicalCorporation] SET AUTO_CLOSE OFF 

ALTER DATABASE [MedicalCorporation] SET AUTO_SHRINK OFF 

ALTER DATABASE [MedicalCorporation] SET AUTO_UPDATE_STATISTICS ON 

ALTER DATABASE [MedicalCorporation] SET CURSOR_CLOSE_ON_COMMIT OFF 

ALTER DATABASE [MedicalCorporation] SET CURSOR_DEFAULT  GLOBAL 

ALTER DATABASE [MedicalCorporation] SET CONCAT_NULL_YIELDS_NULL OFF 

ALTER DATABASE [MedicalCorporation] SET NUMERIC_ROUNDABORT OFF 

ALTER DATABASE [MedicalCorporation] SET QUOTED_IDENTIFIER OFF 

ALTER DATABASE [MedicalCorporation] SET RECURSIVE_TRIGGERS OFF 

ALTER DATABASE [MedicalCorporation] SET  DISABLE_BROKER 

ALTER DATABASE [MedicalCorporation] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 

ALTER DATABASE [MedicalCorporation] SET DATE_CORRELATION_OPTIMIZATION OFF 

ALTER DATABASE [MedicalCorporation] SET TRUSTWORTHY OFF 

ALTER DATABASE [MedicalCorporation] SET ALLOW_SNAPSHOT_ISOLATION OFF 

ALTER DATABASE [MedicalCorporation] SET PARAMETERIZATION SIMPLE 

ALTER DATABASE [MedicalCorporation] SET READ_COMMITTED_SNAPSHOT OFF 

ALTER DATABASE [MedicalCorporation] SET HONOR_BROKER_PRIORITY OFF 

ALTER DATABASE [MedicalCorporation] SET RECOVERY SIMPLE 

ALTER DATABASE [MedicalCorporation] SET  MULTI_USER 

ALTER DATABASE [MedicalCorporation] SET PAGE_VERIFY CHECKSUM  

ALTER DATABASE [MedicalCorporation] SET DB_CHAINING OFF 

ALTER DATABASE [MedicalCorporation] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 

ALTER DATABASE [MedicalCorporation] SET TARGET_RECOVERY_TIME = 60 SECONDS 

ALTER DATABASE [MedicalCorporation] SET DELAYED_DURABILITY = DISABLED 

ALTER DATABASE [MedicalCorporation] SET ACCELERATED_DATABASE_RECOVERY = OFF  

EXEC sys.sp_db_vardecimal_storage_format N'MedicalCorporation', N'ON'

ALTER DATABASE [MedicalCorporation] SET QUERY_STORE = OFF

GO
/****** Object:  Schema [assoc]    Script Date: 07.01.2022 21:48:14 ******/
CREATE SCHEMA [assoc]
GO
/****** Object:  Schema [geo]    Script Date: 07.01.2022 21:48:14 ******/
CREATE SCHEMA [geo]
GO
/****** Object:  Schema [m]    Script Date: 07.01.2022 21:48:14 ******/
CREATE SCHEMA [m]
GO
/****** Object:  Schema [med]    Script Date: 07.01.2022 21:48:14 ******/
CREATE SCHEMA [med]
GO
/****** Object:  Schema [usr]    Script Date: 07.01.2022 21:48:14 ******/
CREATE SCHEMA [usr]
GO

USE [MedicalCorporation]

/****** Object:  Table [assoc].[MedicalInstitutionsTypes]    Script Date: 07.01.2022 21:48:14 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [assoc].[MedicalInstitutionsTypes](
	[MedicalInstituteId] [int] NOT NULL,
	[MedicalInstituteTypeId] [int] NOT NULL
) ON [PRIMARY]

/****** Object:  Table [assoc].[OperatingMedics]    Script Date: 07.01.2022 21:48:14 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [assoc].[OperatingMedics](
	[OperationId] [int] NOT NULL,
	[MedicId] [int] NOT NULL
) ON [PRIMARY]

/****** Object:  Table [assoc].[ProfilesPrivileges]    Script Date: 07.01.2022 21:48:14 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [assoc].[ProfilesPrivileges](
	[ProfileId] [int] NOT NULL,
	[PrivilegeId] [int] NOT NULL
) ON [PRIMARY]

/****** Object:  Table [assoc].[UsersMedicalInstitutions]    Script Date: 07.01.2022 21:48:14 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [assoc].[UsersMedicalInstitutions](
	[UserId] [int] NOT NULL,
	[MedicalInstituteId] [int] NOT NULL
) ON [PRIMARY]

/****** Object:  Table [assoc].[UsersProfiles]    Script Date: 07.01.2022 21:48:14 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [assoc].[UsersProfiles](
	[UserId] [int] NOT NULL,
	[ProfileId] [int] NOT NULL,
	[HoursInMonth] [float] NULL,
	[WorkExperienceInYears] [int] NULL,
	[CreateAssocDate] [date] NOT NULL
) ON [PRIMARY]

/****** Object:  Table [assoc].[UsersRoles]    Script Date: 07.01.2022 21:48:14 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [assoc].[UsersRoles](
	[UserId] [int] NOT NULL,
	[RoleId] [int] NOT NULL
) ON [PRIMARY]

/****** Object:  Table [geo].[Departments]    Script Date: 07.01.2022 21:48:14 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [geo].[Departments](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[MedicalInstituteId] [int] NOT NULL,
	[Name] [nvarchar](128) NOT NULL,
	[Description] [nvarchar](256) NULL,
 CONSTRAINT [PK_Departments] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [geo].[MedicalInstituteTypes]    Script Date: 07.01.2022 21:48:14 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [geo].[MedicalInstituteTypes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](128) NOT NULL,
 CONSTRAINT [PK_MedicalInstituteTypes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [geo].[MedicalInstitutions]    Script Date: 07.01.2022 21:48:14 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [geo].[MedicalInstitutions](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](128) NOT NULL,
	[Address] [nvarchar](256) NOT NULL,
	[Description] [nvarchar](256) NULL,
	[Rating] [float] NULL,
	[MedicalInstitutePlaceId] [int] NOT NULL,
	[NumberOfRooms] [int] NOT NULL,
	[StartTime] [time](7) NULL,
	[CloseTime] [time](7) NULL,
 CONSTRAINT [PK_MedicalInstitutions] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [geo].[MedicalInstitutionsPlaces]    Script Date: 07.01.2022 21:48:14 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [geo].[MedicalInstitutionsPlaces](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](128) NOT NULL,
	[RegionId] [int] NOT NULL,
 CONSTRAINT [PK_MedicalInstitutionsPlaces] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [geo].[Regions]    Script Date: 07.01.2022 21:48:14 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [geo].[Regions](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](128) NOT NULL,
 CONSTRAINT [PK_Regions] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [geo].[Rooms]    Script Date: 07.01.2022 21:48:14 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [geo].[Rooms](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DepartmentId] [int] NOT NULL,
	[RoomNumber] [int] NOT NULL,
	[Description] [nvarchar](256) NULL,
	[NumberOfBeds] [int] NULL,
 CONSTRAINT [PK_Room] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [m].[Param]    Script Date: 07.01.2022 21:48:14 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [m].[Param](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Value] [nvarchar](128) NULL,
	[Description] [nvarchar](128) NULL,
 CONSTRAINT [PK_Param] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [med].[AcademicDegrees]    Script Date: 07.01.2022 21:48:14 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [med].[AcademicDegrees](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[AcademicDegree] [nvarchar](256) NOT NULL,
 CONSTRAINT [PK_AcademicDegrees] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [med].[Medics]    Script Date: 07.01.2022 21:48:14 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [med].[Medics](
	[UserId] [int] NOT NULL,
	[AcademicDegreeId] [int] NULL,
	[RankId] [int] NULL,
 CONSTRAINT [PK_Medics] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [med].[Operations]    Script Date: 07.01.2022 21:48:14 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [med].[Operations](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[MedicalInstituteId] [int] NOT NULL,
	[IsSuccess] [bit] NOT NULL,
	[IsFatal] [bit] NOT NULL,
	[Description] [nvarchar](512) NULL,
	[OperationStartDateTime] [datetime] NOT NULL,
	[OperationMinutesSpan] [int] NOT NULL,
 CONSTRAINT [PK_Operations] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [med].[OutpatientAccounting]    Script Date: 07.01.2022 21:48:14 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [med].[OutpatientAccounting](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[TreatingMedicId] [int] NOT NULL,
	[IssuingPersonId] [int] NOT NULL,
	[ReferralId] [int] NULL,
	[MedicalInstituteId] [int] NOT NULL,
	[DepartmentId] [int] NULL,
	[RoomId] [int] NULL,
	[Description] [nvarchar](512) NULL,
	[Date] [date] NOT NULL,
 CONSTRAINT [PK_OutpatientAccounting] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [med].[Ranks]    Script Date: 07.01.2022 21:48:14 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [med].[Ranks](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Rank] [nvarchar](256) NOT NULL,
 CONSTRAINT [PK_Ranks] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [med].[Referrals]    Script Date: 07.01.2022 21:48:14 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [med].[Referrals](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[ReferralMedicId] [int] NULL,
	[DestinationMedicalInstituteId] [int] NOT NULL,
	[Description] [nvarchar](512) NULL,
	[CreateDate] [date] NOT NULL,
 CONSTRAINT [PK_Referrals] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [med].[StationaryAccounting]    Script Date: 07.01.2022 21:48:14 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [med].[StationaryAccounting](
	[Id] [int] NOT NULL,
	[UserId] [int] NOT NULL,
	[TreatingMedicId] [int] NOT NULL,
	[ReferralId] [int] NULL,
	[MedicalInstituteId] [int] NOT NULL,
	[DepartmentId] [int] NULL,
	[RoomId] [int] NULL,
	[Description] [nvarchar](512) NULL,
	[StartDate] [date] NOT NULL,
	[EndDate] [date] NOT NULL,
 CONSTRAINT [PK_StationaryAccounting] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [usr].[Privileges]    Script Date: 07.01.2022 21:48:14 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [usr].[Privileges](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Uid] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
	[Name] [nvarchar](128) NOT NULL,
	[Description] [nvarchar](256) NULL,
 CONSTRAINT [PK_Privileges] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [usr].[Profiles]    Script Date: 07.01.2022 21:48:14 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [usr].[Profiles](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](128) NOT NULL,
	[Description] [nvarchar](256) NULL,
	[SalaryIncreasePerHour] [float] NULL,
	[RoleId] [int] NULL,
 CONSTRAINT [PK_Profiles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [usr].[Roles]    Script Date: 07.01.2022 21:48:14 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [usr].[Roles](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](128) NOT NULL,
 CONSTRAINT [PK_Roles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [usr].[Users]    Script Date: 07.01.2022 21:48:14 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [usr].[Users](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](128) NOT NULL,
	[Surname] [nvarchar](128) NOT NULL,
	[Patronymic] [nvarchar](128) NULL,
	[Sex] [int] NOT NULL,
	[DateOfBirtf] [date] NULL,
	[Phone] [nvarchar](50) NULL,
	[Address] [nvarchar](128) NULL,
	[Login] [nvarchar](128) NOT NULL,
	[Password] [nvarchar](128) NOT NULL,
	[RegistrationDate] [date] NOT NULL,
	[DefaultTownId] [int] NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [usr].[Workers]    Script Date: 07.01.2022 21:48:14 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [usr].[Workers](
	[UserId] [int] NOT NULL,
	[Position] [nvarchar](128) NOT NULL,
	[PassportSeries] [nvarchar](128) NOT NULL,
	[PasportNumber] [nvarchar](128) NOT NULL,
	[SpecifiedSalary] [float] NULL,
	[Characteristic] [nvarchar](512) NULL,
	[IsEnabled] [bit] NOT NULL,
	[EmploymentDate] [date] NOT NULL,
 CONSTRAINT [PK_Workers] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

INSERT [assoc].[MedicalInstitutionsTypes] ([MedicalInstituteId], [MedicalInstituteTypeId]) VALUES (1, 1)

INSERT [assoc].[MedicalInstitutionsTypes] ([MedicalInstituteId], [MedicalInstituteTypeId]) VALUES (2, 1)

INSERT [assoc].[MedicalInstitutionsTypes] ([MedicalInstituteId], [MedicalInstituteTypeId]) VALUES (3, 2)

INSERT [assoc].[MedicalInstitutionsTypes] ([MedicalInstituteId], [MedicalInstituteTypeId]) VALUES (4, 2)

INSERT [assoc].[MedicalInstitutionsTypes] ([MedicalInstituteId], [MedicalInstituteTypeId]) VALUES (5, 2)

INSERT [assoc].[MedicalInstitutionsTypes] ([MedicalInstituteId], [MedicalInstituteTypeId]) VALUES (1, 2)

INSERT [assoc].[UsersProfiles] ([UserId], [ProfileId], [HoursInMonth], [WorkExperienceInYears], [CreateAssocDate]) VALUES (7, 14, 80, 10, CAST(N'2021-12-29' AS Date))

INSERT [assoc].[UsersProfiles] ([UserId], [ProfileId], [HoursInMonth], [WorkExperienceInYears], [CreateAssocDate]) VALUES (8, 8, 160, 15, CAST(N'2020-05-12' AS Date))

INSERT [assoc].[UsersProfiles] ([UserId], [ProfileId], [HoursInMonth], [WorkExperienceInYears], [CreateAssocDate]) VALUES (9, 7, 160, 14, CAST(N'2021-09-08' AS Date))

INSERT [assoc].[UsersProfiles] ([UserId], [ProfileId], [HoursInMonth], [WorkExperienceInYears], [CreateAssocDate]) VALUES (10, 9, 160, 3, CAST(N'2020-09-22' AS Date))

INSERT [assoc].[UsersProfiles] ([UserId], [ProfileId], [HoursInMonth], [WorkExperienceInYears], [CreateAssocDate]) VALUES (11, 15, 160, 3, CAST(N'2020-11-04' AS Date))

INSERT [assoc].[UsersProfiles] ([UserId], [ProfileId], [HoursInMonth], [WorkExperienceInYears], [CreateAssocDate]) VALUES (7, 1, 80, 6, CAST(N'2021-12-29' AS Date))

INSERT [assoc].[UsersProfiles] ([UserId], [ProfileId], [HoursInMonth], [WorkExperienceInYears], [CreateAssocDate]) VALUES (1, 16, NULL, NULL, CAST(N'2021-12-29' AS Date))

INSERT [assoc].[UsersProfiles] ([UserId], [ProfileId], [HoursInMonth], [WorkExperienceInYears], [CreateAssocDate]) VALUES (1, 17, NULL, NULL, CAST(N'2021-12-29' AS Date))

INSERT [assoc].[UsersProfiles] ([UserId], [ProfileId], [HoursInMonth], [WorkExperienceInYears], [CreateAssocDate]) VALUES (2, 16, NULL, NULL, CAST(N'2021-12-29' AS Date))

INSERT [assoc].[UsersProfiles] ([UserId], [ProfileId], [HoursInMonth], [WorkExperienceInYears], [CreateAssocDate]) VALUES (2, 17, NULL, NULL, CAST(N'2021-12-29' AS Date))

INSERT [assoc].[UsersProfiles] ([UserId], [ProfileId], [HoursInMonth], [WorkExperienceInYears], [CreateAssocDate]) VALUES (3, 16, NULL, NULL, CAST(N'2021-12-29' AS Date))

INSERT [assoc].[UsersProfiles] ([UserId], [ProfileId], [HoursInMonth], [WorkExperienceInYears], [CreateAssocDate]) VALUES (3, 17, NULL, NULL, CAST(N'2021-12-29' AS Date))

INSERT [assoc].[UsersProfiles] ([UserId], [ProfileId], [HoursInMonth], [WorkExperienceInYears], [CreateAssocDate]) VALUES (4, 16, NULL, NULL, CAST(N'2021-12-29' AS Date))

INSERT [assoc].[UsersProfiles] ([UserId], [ProfileId], [HoursInMonth], [WorkExperienceInYears], [CreateAssocDate]) VALUES (4, 17, NULL, NULL, CAST(N'2021-12-29' AS Date))

INSERT [assoc].[UsersProfiles] ([UserId], [ProfileId], [HoursInMonth], [WorkExperienceInYears], [CreateAssocDate]) VALUES (5, 16, NULL, NULL, CAST(N'2021-12-29' AS Date))

INSERT [assoc].[UsersProfiles] ([UserId], [ProfileId], [HoursInMonth], [WorkExperienceInYears], [CreateAssocDate]) VALUES (5, 17, NULL, NULL, CAST(N'2021-12-29' AS Date))

INSERT [assoc].[UsersProfiles] ([UserId], [ProfileId], [HoursInMonth], [WorkExperienceInYears], [CreateAssocDate]) VALUES (6, 16, NULL, NULL, CAST(N'2021-12-29' AS Date))

INSERT [assoc].[UsersProfiles] ([UserId], [ProfileId], [HoursInMonth], [WorkExperienceInYears], [CreateAssocDate]) VALUES (6, 17, NULL, NULL, CAST(N'2021-12-29' AS Date))

INSERT [assoc].[UsersProfiles] ([UserId], [ProfileId], [HoursInMonth], [WorkExperienceInYears], [CreateAssocDate]) VALUES (7, 16, NULL, NULL, CAST(N'2021-12-29' AS Date))

INSERT [assoc].[UsersProfiles] ([UserId], [ProfileId], [HoursInMonth], [WorkExperienceInYears], [CreateAssocDate]) VALUES (7, 17, NULL, NULL, CAST(N'2021-12-29' AS Date))

INSERT [assoc].[UsersProfiles] ([UserId], [ProfileId], [HoursInMonth], [WorkExperienceInYears], [CreateAssocDate]) VALUES (8, 16, NULL, NULL, CAST(N'2021-12-29' AS Date))

INSERT [assoc].[UsersProfiles] ([UserId], [ProfileId], [HoursInMonth], [WorkExperienceInYears], [CreateAssocDate]) VALUES (8, 17, NULL, NULL, CAST(N'2021-12-29' AS Date))

INSERT [assoc].[UsersProfiles] ([UserId], [ProfileId], [HoursInMonth], [WorkExperienceInYears], [CreateAssocDate]) VALUES (9, 16, NULL, NULL, CAST(N'2021-12-29' AS Date))

INSERT [assoc].[UsersProfiles] ([UserId], [ProfileId], [HoursInMonth], [WorkExperienceInYears], [CreateAssocDate]) VALUES (9, 17, NULL, NULL, CAST(N'2021-12-29' AS Date))

INSERT [assoc].[UsersProfiles] ([UserId], [ProfileId], [HoursInMonth], [WorkExperienceInYears], [CreateAssocDate]) VALUES (10, 16, NULL, NULL, CAST(N'2021-12-29' AS Date))

INSERT [assoc].[UsersProfiles] ([UserId], [ProfileId], [HoursInMonth], [WorkExperienceInYears], [CreateAssocDate]) VALUES (10, 17, NULL, NULL, CAST(N'2021-12-29' AS Date))

INSERT [assoc].[UsersProfiles] ([UserId], [ProfileId], [HoursInMonth], [WorkExperienceInYears], [CreateAssocDate]) VALUES (11, 16, NULL, NULL, CAST(N'2021-12-29' AS Date))

INSERT [assoc].[UsersProfiles] ([UserId], [ProfileId], [HoursInMonth], [WorkExperienceInYears], [CreateAssocDate]) VALUES (11, 17, NULL, NULL, CAST(N'2021-12-29' AS Date))

INSERT [assoc].[UsersRoles] ([UserId], [RoleId]) VALUES (7, 1)

INSERT [assoc].[UsersRoles] ([UserId], [RoleId]) VALUES (8, 2)

INSERT [assoc].[UsersRoles] ([UserId], [RoleId]) VALUES (9, 2)

INSERT [assoc].[UsersRoles] ([UserId], [RoleId]) VALUES (7, 2)

INSERT [assoc].[UsersRoles] ([UserId], [RoleId]) VALUES (10, 1)

INSERT [assoc].[UsersRoles] ([UserId], [RoleId]) VALUES (11, 1)

SET IDENTITY_INSERT [geo].[Departments] ON 

INSERT [geo].[Departments] ([Id], [MedicalInstituteId], [Name], [Description]) VALUES (1, 1, N'Терапевтическое отделение', NULL)

INSERT [geo].[Departments] ([Id], [MedicalInstituteId], [Name], [Description]) VALUES (2, 2, N'Терапевтическое отделение', NULL)

INSERT [geo].[Departments] ([Id], [MedicalInstituteId], [Name], [Description]) VALUES (3, 3, N'Хирургическое отделение', NULL)

INSERT [geo].[Departments] ([Id], [MedicalInstituteId], [Name], [Description]) VALUES (4, 4, N'Хирургическое отделение', NULL)

INSERT [geo].[Departments] ([Id], [MedicalInstituteId], [Name], [Description]) VALUES (5, 5, N'Терапевтическое отделение', NULL)

INSERT [geo].[Departments] ([Id], [MedicalInstituteId], [Name], [Description]) VALUES (6, 5, N'Хирургическое отделение', NULL)

SET IDENTITY_INSERT [geo].[Departments] OFF

SET IDENTITY_INSERT [geo].[MedicalInstituteTypes] ON 

INSERT [geo].[MedicalInstituteTypes] ([Id], [Name]) VALUES (1, N'Больница')

INSERT [geo].[MedicalInstituteTypes] ([Id], [Name]) VALUES (2, N'Поликлиника')

INSERT [geo].[MedicalInstituteTypes] ([Id], [Name]) VALUES (3, N'Лаборатория')

SET IDENTITY_INSERT [geo].[MedicalInstituteTypes] OFF

SET IDENTITY_INSERT [geo].[MedicalInstitutions] ON 

INSERT [geo].[MedicalInstitutions] ([Id], [Name], [Address], [Description], [Rating], [MedicalInstitutePlaceId], [NumberOfRooms], [StartTime], [CloseTime]) VALUES (1, N'ГБУЗ СК "Городская клиническая больница" города Пятигорска', N'ул. Пирогова, 22, Пятигорск, Ставропольский край, 357500', NULL, 7.7, 1, 80, CAST(N'06:00:00' AS Time), CAST(N'22:00:00' AS Time))

INSERT [geo].[MedicalInstitutions] ([Id], [Name], [Address], [Description], [Rating], [MedicalInstitutePlaceId], [NumberOfRooms], [StartTime], [CloseTime]) VALUES (2, N'Городская клиническая больница', N'ул. Пирогова, 22, Пятигорск, Ставропольский край, 357500', NULL, 6.7, 1, 55, CAST(N'06:00:00' AS Time), CAST(N'22:00:00' AS Time))

INSERT [geo].[MedicalInstitutions] ([Id], [Name], [Address], [Description], [Rating], [MedicalInstitutePlaceId], [NumberOfRooms], [StartTime], [CloseTime]) VALUES (3, N'ГБУЗ СК Городская поликлиника № 1 г. Кисловодска
', N'Первомайский пр., 10, Кисловодск, Ставропольский край, 357700', NULL, 8.1, 2, 68, CAST(N'06:00:00' AS Time), CAST(N'22:00:00' AS Time))

INSERT [geo].[MedicalInstitutions] ([Id], [Name], [Address], [Description], [Rating], [MedicalInstitutePlaceId], [NumberOfRooms], [StartTime], [CloseTime]) VALUES (4, N'ГБУЗ ГОРОДСКАЯ ПОЛИКЛИНИКА №3 МЗ КК Г.КРАСНОДАРА', N'ул. Ставропольская, 142, Краснодар, Краснодарский край, 350001', NULL, 8, 3, 40, CAST(N'06:00:00' AS Time), CAST(N'22:00:00' AS Time))

INSERT [geo].[MedicalInstitutions] ([Id], [Name], [Address], [Description], [Rating], [MedicalInstitutePlaceId], [NumberOfRooms], [StartTime], [CloseTime]) VALUES (5, N'Поликлиника № 1', N'1-я Бульварная ул., 37, Пятигорск, Ставропольский край, 357500', NULL, 8, 1, 70, CAST(N'06:00:00' AS Time), CAST(N'22:00:00' AS Time))

SET IDENTITY_INSERT [geo].[MedicalInstitutions] OFF

SET IDENTITY_INSERT [geo].[MedicalInstitutionsPlaces] ON 

INSERT [geo].[MedicalInstitutionsPlaces] ([Id], [Name], [RegionId]) VALUES (1, N'Пятигорск', 1)

INSERT [geo].[MedicalInstitutionsPlaces] ([Id], [Name], [RegionId]) VALUES (2, N'Кисловодск', 1)

INSERT [geo].[MedicalInstitutionsPlaces] ([Id], [Name], [RegionId]) VALUES (3, N'Краснодар', 2)

SET IDENTITY_INSERT [geo].[MedicalInstitutionsPlaces] OFF

SET IDENTITY_INSERT [geo].[Regions] ON 

INSERT [geo].[Regions] ([Id], [Name]) VALUES (1, N'Ставропольский край')

INSERT [geo].[Regions] ([Id], [Name]) VALUES (2, N'Краснодарский край')

SET IDENTITY_INSERT [geo].[Regions] OFF

SET IDENTITY_INSERT [geo].[Rooms] ON 

INSERT [geo].[Rooms] ([Id], [DepartmentId], [RoomNumber], [Description], [NumberOfBeds]) VALUES (1, 1, 30, NULL, 0)

INSERT [geo].[Rooms] ([Id], [DepartmentId], [RoomNumber], [Description], [NumberOfBeds]) VALUES (2, 2, 24, NULL, 0)

INSERT [geo].[Rooms] ([Id], [DepartmentId], [RoomNumber], [Description], [NumberOfBeds]) VALUES (3, 3, 32, NULL, 4)

INSERT [geo].[Rooms] ([Id], [DepartmentId], [RoomNumber], [Description], [NumberOfBeds]) VALUES (4, 4, 34, NULL, 4)

INSERT [geo].[Rooms] ([Id], [DepartmentId], [RoomNumber], [Description], [NumberOfBeds]) VALUES (5, 5, 4, NULL, 2)

INSERT [geo].[Rooms] ([Id], [DepartmentId], [RoomNumber], [Description], [NumberOfBeds]) VALUES (6, 3, 33, NULL, 4)

INSERT [geo].[Rooms] ([Id], [DepartmentId], [RoomNumber], [Description], [NumberOfBeds]) VALUES (7, 3, 34, NULL, 4)

INSERT [geo].[Rooms] ([Id], [DepartmentId], [RoomNumber], [Description], [NumberOfBeds]) VALUES (8, 3, 35, NULL, 4)

INSERT [geo].[Rooms] ([Id], [DepartmentId], [RoomNumber], [Description], [NumberOfBeds]) VALUES (9, 4, 35, NULL, 4)

INSERT [geo].[Rooms] ([Id], [DepartmentId], [RoomNumber], [Description], [NumberOfBeds]) VALUES (10, 4, 36, NULL, 5)

INSERT [geo].[Rooms] ([Id], [DepartmentId], [RoomNumber], [Description], [NumberOfBeds]) VALUES (11, 4, 37, NULL, 3)

INSERT [geo].[Rooms] ([Id], [DepartmentId], [RoomNumber], [Description], [NumberOfBeds]) VALUES (12, 5, 5, NULL, 4)

INSERT [geo].[Rooms] ([Id], [DepartmentId], [RoomNumber], [Description], [NumberOfBeds]) VALUES (13, 5, 6, NULL, 4)

INSERT [geo].[Rooms] ([Id], [DepartmentId], [RoomNumber], [Description], [NumberOfBeds]) VALUES (14, 5, 7, NULL, 4)

SET IDENTITY_INSERT [geo].[Rooms] OFF

SET IDENTITY_INSERT [m].[Param] ON 

INSERT [m].[Param] ([Id], [Value], [Description]) VALUES (1, N'001001006', N'Struct version')

INSERT [m].[Param] ([Id], [Value], [Description]) VALUES (2, N'1.0.0.0', N'Product version')

INSERT [m].[Param] ([Id], [Value], [Description]) VALUES (3, N'15000', N'Minimum wage')

SET IDENTITY_INSERT [m].[Param] OFF

SET IDENTITY_INSERT [med].[AcademicDegrees] ON 

INSERT [med].[AcademicDegrees] ([Id], [AcademicDegree]) VALUES (1, N'Доктор медицинских наук')

INSERT [med].[AcademicDegrees] ([Id], [AcademicDegree]) VALUES (2, N'Кандидат  медицинских наук ')

SET IDENTITY_INSERT [med].[AcademicDegrees] OFF

INSERT [med].[Medics] ([UserId], [AcademicDegreeId], [RankId]) VALUES (7, 1, 1)

INSERT [med].[Medics] ([UserId], [AcademicDegreeId], [RankId]) VALUES (8, 2, 2)

INSERT [med].[Medics] ([UserId], [AcademicDegreeId], [RankId]) VALUES (9, 2, 2)

SET IDENTITY_INSERT [med].[Ranks] ON 

INSERT [med].[Ranks] ([Id], [Rank]) VALUES (1, N'Профессор')

INSERT [med].[Ranks] ([Id], [Rank]) VALUES (2, N'Доцент')

SET IDENTITY_INSERT [med].[Ranks] OFF

SET IDENTITY_INSERT [usr].[Privileges] ON 

INSERT [usr].[Privileges] ([Id], [Uid], [Name], [Description]) VALUES (1, N'2000001d-0000-0000-c000-000000000000', N'Изменение структуры комплекса', N'Добавление ролей пользователей с добавлением таблиц хранений')

INSERT [usr].[Privileges] ([Id], [Uid], [Name], [Description]) VALUES (2, N'2000002d-0000-0000-c000-000000000000', N'Назначение ролей и профилей', N'Возможность назначения ролей и прфоилей пользователей')

INSERT [usr].[Privileges] ([Id], [Uid], [Name], [Description]) VALUES (3, N'2000003d-0000-0000-c000-000000000000', N'Добавление работников', N'Возможность принимать на работу работников')

INSERT [usr].[Privileges] ([Id], [Uid], [Name], [Description]) VALUES (4, N'2000004d-0000-0000-c000-000000000000', N'Изменение данных', N'Возможность редактирования данных пользователей')

INSERT [usr].[Privileges] ([Id], [Uid], [Name], [Description]) VALUES (5, N'2000005d-0000-0000-c000-000000000000', N'Направление пациентов', NULL)

INSERT [usr].[Privileges] ([Id], [Uid], [Name], [Description]) VALUES (6, N'2000006d-0000-0000-c000-000000000000', N'Лечение пациентов', NULL)

INSERT [usr].[Privileges] ([Id], [Uid], [Name], [Description]) VALUES (7, N'2000007d-0000-0000-c000-000000000000', N'Назначение приёма', NULL)

INSERT [usr].[Privileges] ([Id], [Uid], [Name], [Description]) VALUES (8, N'2000008d-0000-0000-c000-000000000000', N'Просмотр медиков', NULL)

INSERT [usr].[Privileges] ([Id], [Uid], [Name], [Description]) VALUES (9, N'2000009d-0000-0000-c000-000000000000', N'Просмотра персонала', NULL)

INSERT [usr].[Privileges] ([Id], [Uid], [Name], [Description]) VALUES (10, N'2000010d-0000-0000-c000-000000000000', N'Добавление географических объектов', NULL)

INSERT [usr].[Privileges] ([Id], [Uid], [Name], [Description]) VALUES (11, N'2000011d-0000-0000-c000-000000000000', N'Оперирование', NULL)

SET IDENTITY_INSERT [usr].[Privileges] OFF

SET IDENTITY_INSERT [usr].[Profiles] ON 

INSERT [usr].[Profiles] ([Id], [Name], [Description], [SalaryIncreasePerHour], [RoleId]) VALUES (1, N'Абдоминальный хирург', NULL, 600, 2)

INSERT [usr].[Profiles] ([Id], [Name], [Description], [SalaryIncreasePerHour], [RoleId]) VALUES (2, N'Акушер', NULL, 500, 2)

INSERT [usr].[Profiles] ([Id], [Name], [Description], [SalaryIncreasePerHour], [RoleId]) VALUES (3, N'Акушер-гинеколог', NULL, 550, 2)

INSERT [usr].[Profiles] ([Id], [Name], [Description], [SalaryIncreasePerHour], [RoleId]) VALUES (4, N'Вирусолог', NULL, 400, 2)

INSERT [usr].[Profiles] ([Id], [Name], [Description], [SalaryIncreasePerHour], [RoleId]) VALUES (5, N'Аллерголог', NULL, 500, 2)

INSERT [usr].[Profiles] ([Id], [Name], [Description], [SalaryIncreasePerHour], [RoleId]) VALUES (6, N'Кардиохирург', NULL, 500, 2)

INSERT [usr].[Profiles] ([Id], [Name], [Description], [SalaryIncreasePerHour], [RoleId]) VALUES (7, N'Терапевт', NULL, 450, 2)

INSERT [usr].[Profiles] ([Id], [Name], [Description], [SalaryIncreasePerHour], [RoleId]) VALUES (8, N'Хирург', NULL, 600, 2)

INSERT [usr].[Profiles] ([Id], [Name], [Description], [SalaryIncreasePerHour], [RoleId]) VALUES (9, N'Администратор систем безопасности', NULL, 500, 1)

INSERT [usr].[Profiles] ([Id], [Name], [Description], [SalaryIncreasePerHour], [RoleId]) VALUES (10, N'Администратор комплекса', NULL, 300, 1)

INSERT [usr].[Profiles] ([Id], [Name], [Description], [SalaryIncreasePerHour], [RoleId]) VALUES (11, N'Охранник', NULL, 230, 3)

INSERT [usr].[Profiles] ([Id], [Name], [Description], [SalaryIncreasePerHour], [RoleId]) VALUES (12, N'Уборщик', NULL, 250, 3)

INSERT [usr].[Profiles] ([Id], [Name], [Description], [SalaryIncreasePerHour], [RoleId]) VALUES (14, N'Главный архитектор', NULL, 900, 1)

INSERT [usr].[Profiles] ([Id], [Name], [Description], [SalaryIncreasePerHour], [RoleId]) VALUES (15, N'Служебный пользователь', NULL, 200, 1)

INSERT [usr].[Profiles] ([Id], [Name], [Description], [SalaryIncreasePerHour], [RoleId]) VALUES (16, N'Пациент', N'Выдаётся каждому', NULL, NULL)

INSERT [usr].[Profiles] ([Id], [Name], [Description], [SalaryIncreasePerHour], [RoleId]) VALUES (17, N'Пользователь', N'Выдаётся каждому', NULL, NULL)

SET IDENTITY_INSERT [usr].[Profiles] OFF

SET IDENTITY_INSERT [usr].[Roles] ON 

INSERT [usr].[Roles] ([Id], [Name]) VALUES (1, N'Administrator')

INSERT [usr].[Roles] ([Id], [Name]) VALUES (2, N'Medic')

INSERT [usr].[Roles] ([Id], [Name]) VALUES (3, N'ServiceStaff')

SET IDENTITY_INSERT [usr].[Roles] OFF

SET IDENTITY_INSERT [usr].[Users] ON 

INSERT [usr].[Users] ([Id], [Name], [Surname], [Patronymic], [Sex], [DateOfBirtf], [Phone], [Address], [Login], [Password], [RegistrationDate], [DefaultTownId]) VALUES (1, N'Антонина', N'Григорьева', N'Константиновна', 2, NULL, N'5341      ', NULL, N'1', N'1234', CAST(N'2020-07-05' AS Date), NULL)

INSERT [usr].[Users] ([Id], [Name], [Surname], [Patronymic], [Sex], [DateOfBirtf], [Phone], [Address], [Login], [Password], [RegistrationDate], [DefaultTownId]) VALUES (2, N'Елизавета', N'Смирнова', N'Максимовна', 2, NULL, N'1241      ', NULL, N'2', N'1234', CAST(N'2021-05-28' AS Date), NULL)

INSERT [usr].[Users] ([Id], [Name], [Surname], [Patronymic], [Sex], [DateOfBirtf], [Phone], [Address], [Login], [Password], [RegistrationDate], [DefaultTownId]) VALUES (3, N'Злата', N'Суворова', N'Андреевна', 2, NULL, N'5352      ', NULL, N'3', N'1234', CAST(N'2020-12-30' AS Date), NULL)

INSERT [usr].[Users] ([Id], [Name], [Surname], [Patronymic], [Sex], [DateOfBirtf], [Phone], [Address], [Login], [Password], [RegistrationDate], [DefaultTownId]) VALUES (4, N'Алиса', N'Степанова', N'Арсентьевна', 2, NULL, N'5235      ', NULL, N'4', N'1234', CAST(N'2021-01-27' AS Date), NULL)

INSERT [usr].[Users] ([Id], [Name], [Surname], [Patronymic], [Sex], [DateOfBirtf], [Phone], [Address], [Login], [Password], [RegistrationDate], [DefaultTownId]) VALUES (5, N'Никита', N'Кочетов', N'Семёнович', 1, NULL, N'1223      ', NULL, N'5', N'1234', CAST(N'2020-10-16' AS Date), NULL)

INSERT [usr].[Users] ([Id], [Name], [Surname], [Patronymic], [Sex], [DateOfBirtf], [Phone], [Address], [Login], [Password], [RegistrationDate], [DefaultTownId]) VALUES (6, N'Матвей', N'Щербаков', N'Георгиевич', 1, NULL, N'2343      ', NULL, N'6', N'1234', CAST(N'2021-09-11' AS Date), NULL)

INSERT [usr].[Users] ([Id], [Name], [Surname], [Patronymic], [Sex], [DateOfBirtf], [Phone], [Address], [Login], [Password], [RegistrationDate], [DefaultTownId]) VALUES (7, N'Вероника', N'Васильева', N'Егоровна', 2, NULL, N'1125      ', NULL, N'7', N'1234', CAST(N'2021-05-16' AS Date), NULL)

INSERT [usr].[Users] ([Id], [Name], [Surname], [Patronymic], [Sex], [DateOfBirtf], [Phone], [Address], [Login], [Password], [RegistrationDate], [DefaultTownId]) VALUES (8, N'Сергей', N'Медведев', N'Романович', 1, NULL, N'3511      ', NULL, N'8', N'1234', CAST(N'2020-09-20' AS Date), NULL)

INSERT [usr].[Users] ([Id], [Name], [Surname], [Patronymic], [Sex], [DateOfBirtf], [Phone], [Address], [Login], [Password], [RegistrationDate], [DefaultTownId]) VALUES (9, N'София', N'Фадеева', N'Матвеевна', 2, NULL, N'2572      ', NULL, N'9', N'1234', CAST(N'2021-07-01' AS Date), NULL)

INSERT [usr].[Users] ([Id], [Name], [Surname], [Patronymic], [Sex], [DateOfBirtf], [Phone], [Address], [Login], [Password], [RegistrationDate], [DefaultTownId]) VALUES (10, N'Оливия', N'Киреева', N'Кирилловна', 2, NULL, N'3242      ', NULL, N'10', N'1234', CAST(N'2021-01-26' AS Date), NULL)

INSERT [usr].[Users] ([Id], [Name], [Surname], [Patronymic], [Sex], [DateOfBirtf], [Phone], [Address], [Login], [Password], [RegistrationDate], [DefaultTownId]) VALUES (11, N'Ганзин', N'Юрий', N'Михайлович', 1, NULL, N'8(988)734-58-38', NULL, N'11', N'1234', CAST(N'2021-12-29' AS Date), NULL)

SET IDENTITY_INSERT [usr].[Users] OFF

INSERT [usr].[Workers] ([UserId], [Position], [PassportSeries], [PasportNumber], [SpecifiedSalary], [Characteristic], [IsEnabled], [EmploymentDate]) VALUES (7, N'Начальник отдела', N'3412', N'463745', 200000, NULL, 1, CAST(N'2019-03-30' AS Date))

INSERT [usr].[Workers] ([UserId], [Position], [PassportSeries], [PasportNumber], [SpecifiedSalary], [Characteristic], [IsEnabled], [EmploymentDate]) VALUES (8, N'Хирург', N'8534', N'538445', NULL, NULL, 1, CAST(N'2019-01-14' AS Date))

INSERT [usr].[Workers] ([UserId], [Position], [PassportSeries], [PasportNumber], [SpecifiedSalary], [Characteristic], [IsEnabled], [EmploymentDate]) VALUES (9, N'Терапевт', N'1347', N'342734', NULL, NULL, 1, CAST(N'2020-04-10' AS Date))

INSERT [usr].[Workers] ([UserId], [Position], [PassportSeries], [PasportNumber], [SpecifiedSalary], [Characteristic], [IsEnabled], [EmploymentDate]) VALUES (10, N'Начальник отдела информационной безопасности', N'3463', N'645375', NULL, NULL, 1, CAST(N'2020-02-28' AS Date))

INSERT [usr].[Workers] ([UserId], [Position], [PassportSeries], [PasportNumber], [SpecifiedSalary], [Characteristic], [IsEnabled], [EmploymentDate]) VALUES (11, N'Главный архитектор', N'1234', N'123456', NULL, NULL, 1, CAST(N'2021-12-29' AS Date))

ALTER TABLE [assoc].[UsersProfiles] ADD  CONSTRAINT [DF_UsersProfiles_CreateAssocDate]  DEFAULT (getdate()) FOR [CreateAssocDate]

ALTER TABLE [geo].[Rooms] ADD  CONSTRAINT [DF_Room_NumberOfBeds]  DEFAULT ((4)) FOR [NumberOfBeds]

ALTER TABLE [med].[Operations] ADD  CONSTRAINT [DF_Operations_OperationDate]  DEFAULT (getdate()) FOR [OperationStartDateTime]

ALTER TABLE [med].[OutpatientAccounting] ADD  CONSTRAINT [DF_OutpatientAccounting_Date]  DEFAULT (getdate()) FOR [Date]

ALTER TABLE [med].[Referrals] ADD  CONSTRAINT [DF_Referrals_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]

ALTER TABLE [med].[StationaryAccounting] ADD  CONSTRAINT [DF_StationaryAccounting_StartDate]  DEFAULT (getdate()) FOR [StartDate]

ALTER TABLE [usr].[Privileges] ADD  CONSTRAINT [DF_Privileges_Uid]  DEFAULT (newid()) FOR [Uid]

ALTER TABLE [usr].[Users] ADD  CONSTRAINT [DF_Users_RegistrationDate]  DEFAULT (getdate()) FOR [RegistrationDate]

ALTER TABLE [assoc].[MedicalInstitutionsTypes]  WITH CHECK ADD  CONSTRAINT [FK_MedicalInstitutionsTypes_MedicalInstituteTypes] FOREIGN KEY([MedicalInstituteTypeId])
REFERENCES [geo].[MedicalInstituteTypes] ([Id])

ALTER TABLE [assoc].[MedicalInstitutionsTypes] CHECK CONSTRAINT [FK_MedicalInstitutionsTypes_MedicalInstituteTypes]

ALTER TABLE [assoc].[MedicalInstitutionsTypes]  WITH CHECK ADD  CONSTRAINT [FK_MedicalInstitutionsTypes_MedicalInstitutions] FOREIGN KEY([MedicalInstituteId])
REFERENCES [geo].[MedicalInstitutions] ([Id])

ALTER TABLE [assoc].[MedicalInstitutionsTypes] CHECK CONSTRAINT [FK_MedicalInstitutionsTypes_MedicalInstitutions]

ALTER TABLE [assoc].[OperatingMedics]  WITH CHECK ADD  CONSTRAINT [FK_OperatingMedics_Medics] FOREIGN KEY([MedicId])
REFERENCES [med].[Medics] ([UserId])

ALTER TABLE [assoc].[OperatingMedics] CHECK CONSTRAINT [FK_OperatingMedics_Medics]

ALTER TABLE [assoc].[OperatingMedics]  WITH CHECK ADD  CONSTRAINT [FK_OperatingMedics_Operations] FOREIGN KEY([OperationId])
REFERENCES [med].[Operations] ([Id])

ALTER TABLE [assoc].[OperatingMedics] CHECK CONSTRAINT [FK_OperatingMedics_Operations]

ALTER TABLE [assoc].[ProfilesPrivileges]  WITH CHECK ADD  CONSTRAINT [FK_ProfilesPrivileges_Privileges] FOREIGN KEY([PrivilegeId])
REFERENCES [usr].[Privileges] ([Id])

ALTER TABLE [assoc].[ProfilesPrivileges] CHECK CONSTRAINT [FK_ProfilesPrivileges_Privileges]

ALTER TABLE [assoc].[ProfilesPrivileges]  WITH CHECK ADD  CONSTRAINT [FK_ProfilesPrivileges_Profiles] FOREIGN KEY([ProfileId])
REFERENCES [usr].[Profiles] ([Id])

ALTER TABLE [assoc].[ProfilesPrivileges] CHECK CONSTRAINT [FK_ProfilesPrivileges_Profiles]

ALTER TABLE [assoc].[UsersMedicalInstitutions]  WITH CHECK ADD  CONSTRAINT [FK_UsersMedicalInstitutions_MedicalInstitutions] FOREIGN KEY([MedicalInstituteId])
REFERENCES [geo].[MedicalInstitutions] ([Id])

ALTER TABLE [assoc].[UsersMedicalInstitutions] CHECK CONSTRAINT [FK_UsersMedicalInstitutions_MedicalInstitutions]

ALTER TABLE [assoc].[UsersMedicalInstitutions]  WITH CHECK ADD  CONSTRAINT [FK_UsersMedicalInstitutions_Users] FOREIGN KEY([UserId])
REFERENCES [usr].[Users] ([Id])

ALTER TABLE [assoc].[UsersMedicalInstitutions] CHECK CONSTRAINT [FK_UsersMedicalInstitutions_Users]

ALTER TABLE [assoc].[UsersProfiles]  WITH CHECK ADD  CONSTRAINT [FK_UsersProfiles_Profiles] FOREIGN KEY([ProfileId])
REFERENCES [usr].[Profiles] ([Id])

ALTER TABLE [assoc].[UsersProfiles] CHECK CONSTRAINT [FK_UsersProfiles_Profiles]

ALTER TABLE [assoc].[UsersProfiles]  WITH CHECK ADD  CONSTRAINT [FK_UsersProfiles_Users] FOREIGN KEY([UserId])
REFERENCES [usr].[Users] ([Id])

ALTER TABLE [assoc].[UsersProfiles] CHECK CONSTRAINT [FK_UsersProfiles_Users]

ALTER TABLE [assoc].[UsersRoles]  WITH CHECK ADD  CONSTRAINT [FK_UsersRoles_Roles] FOREIGN KEY([RoleId])
REFERENCES [usr].[Roles] ([Id])

ALTER TABLE [assoc].[UsersRoles] CHECK CONSTRAINT [FK_UsersRoles_Roles]

ALTER TABLE [assoc].[UsersRoles]  WITH CHECK ADD  CONSTRAINT [FK_UsersRoles_Users] FOREIGN KEY([UserId])
REFERENCES [usr].[Users] ([Id])

ALTER TABLE [assoc].[UsersRoles] CHECK CONSTRAINT [FK_UsersRoles_Users]

ALTER TABLE [geo].[Departments]  WITH CHECK ADD  CONSTRAINT [FK_Departments_MedicalInstitutions] FOREIGN KEY([MedicalInstituteId])
REFERENCES [geo].[MedicalInstitutions] ([Id])

ALTER TABLE [geo].[Departments] CHECK CONSTRAINT [FK_Departments_MedicalInstitutions]

ALTER TABLE [geo].[MedicalInstitutions]  WITH CHECK ADD  CONSTRAINT [FK_MedicalInstitutions_MedicalInstitutions] FOREIGN KEY([MedicalInstitutePlaceId])
REFERENCES [geo].[MedicalInstitutionsPlaces] ([Id])

ALTER TABLE [geo].[MedicalInstitutions] CHECK CONSTRAINT [FK_MedicalInstitutions_MedicalInstitutions]

ALTER TABLE [geo].[MedicalInstitutionsPlaces]  WITH CHECK ADD  CONSTRAINT [FK_MedicalInstitutionsPlaces_Regions] FOREIGN KEY([RegionId])
REFERENCES [geo].[Regions] ([Id])

ALTER TABLE [geo].[MedicalInstitutionsPlaces] CHECK CONSTRAINT [FK_MedicalInstitutionsPlaces_Regions]

ALTER TABLE [geo].[Rooms]  WITH CHECK ADD  CONSTRAINT [FK_Room_Departments] FOREIGN KEY([DepartmentId])
REFERENCES [geo].[Departments] ([Id])

ALTER TABLE [geo].[Rooms] CHECK CONSTRAINT [FK_Room_Departments]

ALTER TABLE [med].[Medics]  WITH CHECK ADD  CONSTRAINT [FK_Medics_AcademicDegrees] FOREIGN KEY([AcademicDegreeId])
REFERENCES [med].[AcademicDegrees] ([Id])

ALTER TABLE [med].[Medics] CHECK CONSTRAINT [FK_Medics_AcademicDegrees]

ALTER TABLE [med].[Medics]  WITH CHECK ADD  CONSTRAINT [FK_Medics_Ranks] FOREIGN KEY([RankId])
REFERENCES [med].[Ranks] ([Id])

ALTER TABLE [med].[Medics] CHECK CONSTRAINT [FK_Medics_Ranks]

ALTER TABLE [med].[Medics]  WITH CHECK ADD  CONSTRAINT [FK_Medics_Users] FOREIGN KEY([UserId])
REFERENCES [usr].[Users] ([Id])

ALTER TABLE [med].[Medics] CHECK CONSTRAINT [FK_Medics_Users]

ALTER TABLE [med].[Operations]  WITH CHECK ADD  CONSTRAINT [FK_Operations_MedicalInstitutions] FOREIGN KEY([MedicalInstituteId])
REFERENCES [geo].[MedicalInstitutions] ([Id])

ALTER TABLE [med].[Operations] CHECK CONSTRAINT [FK_Operations_MedicalInstitutions]

ALTER TABLE [med].[Operations]  WITH CHECK ADD  CONSTRAINT [FK_Operations_Users] FOREIGN KEY([UserId])
REFERENCES [usr].[Users] ([Id])

ALTER TABLE [med].[Operations] CHECK CONSTRAINT [FK_Operations_Users]

ALTER TABLE [med].[OutpatientAccounting]  WITH CHECK ADD  CONSTRAINT [FK_OutpatientAccounting_Departments] FOREIGN KEY([DepartmentId])
REFERENCES [geo].[Departments] ([Id])

ALTER TABLE [med].[OutpatientAccounting] CHECK CONSTRAINT [FK_OutpatientAccounting_Departments]

ALTER TABLE [med].[OutpatientAccounting]  WITH CHECK ADD  CONSTRAINT [FK_OutpatientAccounting_IssuingMedics] FOREIGN KEY([IssuingPersonId])
REFERENCES [med].[Medics] ([UserId])

ALTER TABLE [med].[OutpatientAccounting] CHECK CONSTRAINT [FK_OutpatientAccounting_IssuingMedics]

ALTER TABLE [med].[OutpatientAccounting]  WITH CHECK ADD  CONSTRAINT [FK_OutpatientAccounting_MedicalInstitutions] FOREIGN KEY([MedicalInstituteId])
REFERENCES [geo].[MedicalInstitutions] ([Id])

ALTER TABLE [med].[OutpatientAccounting] CHECK CONSTRAINT [FK_OutpatientAccounting_MedicalInstitutions]

ALTER TABLE [med].[OutpatientAccounting]  WITH CHECK ADD  CONSTRAINT [FK_OutpatientAccounting_Medics] FOREIGN KEY([TreatingMedicId])
REFERENCES [med].[Medics] ([UserId])

ALTER TABLE [med].[OutpatientAccounting] CHECK CONSTRAINT [FK_OutpatientAccounting_Medics]

ALTER TABLE [med].[OutpatientAccounting]  WITH CHECK ADD  CONSTRAINT [FK_OutpatientAccounting_Referrals] FOREIGN KEY([ReferralId])
REFERENCES [med].[Referrals] ([Id])

ALTER TABLE [med].[OutpatientAccounting] CHECK CONSTRAINT [FK_OutpatientAccounting_Referrals]

ALTER TABLE [med].[OutpatientAccounting]  WITH CHECK ADD  CONSTRAINT [FK_OutpatientAccounting_Room] FOREIGN KEY([RoomId])
REFERENCES [geo].[Rooms] ([Id])

ALTER TABLE [med].[OutpatientAccounting] CHECK CONSTRAINT [FK_OutpatientAccounting_Room]

ALTER TABLE [med].[OutpatientAccounting]  WITH CHECK ADD  CONSTRAINT [FK_OutpatientAccounting_Users] FOREIGN KEY([UserId])
REFERENCES [usr].[Users] ([Id])

ALTER TABLE [med].[OutpatientAccounting] CHECK CONSTRAINT [FK_OutpatientAccounting_Users]

ALTER TABLE [med].[Referrals]  WITH CHECK ADD  CONSTRAINT [FK_Referrals_MedicalInstitutions] FOREIGN KEY([DestinationMedicalInstituteId])
REFERENCES [geo].[MedicalInstitutions] ([Id])

ALTER TABLE [med].[Referrals] CHECK CONSTRAINT [FK_Referrals_MedicalInstitutions]

ALTER TABLE [med].[Referrals]  WITH CHECK ADD  CONSTRAINT [FK_Referrals_Medics] FOREIGN KEY([ReferralMedicId])
REFERENCES [med].[Medics] ([UserId])

ALTER TABLE [med].[Referrals] CHECK CONSTRAINT [FK_Referrals_Medics]

ALTER TABLE [med].[Referrals]  WITH CHECK ADD  CONSTRAINT [FK_Referrals_Users] FOREIGN KEY([UserId])
REFERENCES [usr].[Users] ([Id])

ALTER TABLE [med].[Referrals] CHECK CONSTRAINT [FK_Referrals_Users]

ALTER TABLE [med].[StationaryAccounting]  WITH CHECK ADD  CONSTRAINT [FK_StationaryAccounting_Departments] FOREIGN KEY([DepartmentId])
REFERENCES [geo].[Departments] ([Id])

ALTER TABLE [med].[StationaryAccounting] CHECK CONSTRAINT [FK_StationaryAccounting_Departments]

ALTER TABLE [med].[StationaryAccounting]  WITH CHECK ADD  CONSTRAINT [FK_StationaryAccounting_MedicalInstitutions] FOREIGN KEY([MedicalInstituteId])
REFERENCES [geo].[MedicalInstitutions] ([Id])

ALTER TABLE [med].[StationaryAccounting] CHECK CONSTRAINT [FK_StationaryAccounting_MedicalInstitutions]

ALTER TABLE [med].[StationaryAccounting]  WITH CHECK ADD  CONSTRAINT [FK_StationaryAccounting_Medics] FOREIGN KEY([TreatingMedicId])
REFERENCES [med].[Medics] ([UserId])

ALTER TABLE [med].[StationaryAccounting] CHECK CONSTRAINT [FK_StationaryAccounting_Medics]

ALTER TABLE [med].[StationaryAccounting]  WITH CHECK ADD  CONSTRAINT [FK_StationaryAccounting_Referrals] FOREIGN KEY([ReferralId])
REFERENCES [med].[Referrals] ([Id])

ALTER TABLE [med].[StationaryAccounting] CHECK CONSTRAINT [FK_StationaryAccounting_Referrals]

ALTER TABLE [med].[StationaryAccounting]  WITH CHECK ADD  CONSTRAINT [FK_StationaryAccounting_Room] FOREIGN KEY([RoomId])
REFERENCES [geo].[Rooms] ([Id])

ALTER TABLE [med].[StationaryAccounting] CHECK CONSTRAINT [FK_StationaryAccounting_Room]

ALTER TABLE [med].[StationaryAccounting]  WITH CHECK ADD  CONSTRAINT [FK_StationaryAccounting_Users] FOREIGN KEY([UserId])
REFERENCES [usr].[Users] ([Id])

ALTER TABLE [med].[StationaryAccounting] CHECK CONSTRAINT [FK_StationaryAccounting_Users]

ALTER TABLE [usr].[Profiles]  WITH CHECK ADD  CONSTRAINT [FK_Profiles_Roles] FOREIGN KEY([RoleId])
REFERENCES [usr].[Roles] ([Id])

ALTER TABLE [usr].[Profiles] CHECK CONSTRAINT [FK_Profiles_Roles]

ALTER TABLE [usr].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_MedicalInstitutionsPlaces] FOREIGN KEY([DefaultTownId])
REFERENCES [geo].[MedicalInstitutionsPlaces] ([Id])

ALTER TABLE [usr].[Users] CHECK CONSTRAINT [FK_Users_MedicalInstitutionsPlaces]

ALTER TABLE [usr].[Workers]  WITH CHECK ADD  CONSTRAINT [FK_Workers_Users] FOREIGN KEY([UserId])
REFERENCES [usr].[Users] ([Id])

ALTER TABLE [usr].[Workers] CHECK CONSTRAINT [FK_Workers_Users]

USE [master]

ALTER DATABASE [MedicalCorporation] SET  READ_WRITE 
