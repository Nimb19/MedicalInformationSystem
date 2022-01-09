using MedicalCorporation.Core.Models;
using MedicalCorporation.Core.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MedicalCorporation.Core.SqlShellParts
{
    public partial class MedicalSqlShell
    {
        // -- Вывести всех работающих медиков
        // SELECT
        //     usr.Users.Id as Id,
        //     usr.Users.Name as Name,
        //     usr.Users.Surname as Surname,
        //     usr.Users.Patronymic as Patronymic,
        //     usr.Profiles.Name as ProfileName,
        //     med.Ranks.Name as RankName,
        //     assoc.UsersProfiles.WorkExperienceInYears as WorkExperienceInYears
        // 
        // FROM [MedicalCorporation].assoc.UsersProfiles
        // 
        // INNER JOIN usr.Profiles ON usr.Profiles.Id = assoc.UsersProfiles.ProfileId
        // INNER JOIN med.Medics ON med.Medics.UserId = assoc.UsersProfiles.UserId
        // INNER JOIN med.Ranks ON med.Ranks.Id = med.Medics.RankId
        // INNER JOIN usr.Workers ON usr.Workers.UserId = med.Medics.UserId
        // INNER JOIN usr.Users ON usr.Users.Id = med.Medics.UserId
        // 
        // 
        // WHERE usr.Workers.IsEnabled = 1 AND usr.Profiles.RoleId = 2 AND EXISTS (
        //     SELECT 1 FROM[MedicalCorporation].assoc.UsersRoles WHERE assoc.UsersRoles.UserId = usr.Users.Id AND assoc.UsersRoles.RoleId = 2
        // )
        public WorkingMedicInfo[] GetAllWorkingMedics()
        {
            var cmdTxt = $@" -- Вывести всех работающих медиков
    SELECT
    
        {User.TableName}.{nameof(User.Id)} as Id, 
    	{User.TableName}.{nameof(User.Name)} as Name, 
    	{User.TableName}.{nameof(User.Surname)} as Surname, 
    	{User.TableName}.{nameof(User.Patronymic)} as Patronymic, 
    	{Profile.TableName}.{nameof(Profile.Name)} as ProfileName, 
    	{Rank.TableName}.{nameof(Rank.Name)} as RankName,
	    {UserProfile.TableName}.{nameof(UserProfile.WorkExperienceInYears)} as WorkExperienceInYears
    
    FROM [{_dbName}].{UserProfile.TableName}
    
    INNER JOIN {Profile.TableName} ON {Profile.TableName}.{nameof(Profile.Id)} = {UserProfile.TableName}.{nameof(UserProfile.ProfileId)}
    INNER JOIN {Medic.TableName} ON {Medic.TableName}.{nameof(Medic.UserId)} = {UserProfile.TableName}.{nameof(UserProfile.UserId)}
    INNER JOIN {Rank.TableName} ON {Rank.TableName}.{nameof(Rank.Id)} = {Medic.TableName}.{nameof(Medic.RankId)}
    INNER JOIN {Worker.TableName} ON {Worker.TableName}.{nameof(Worker.UserId)} = {Medic.TableName}.{nameof(Medic.UserId)}
    INNER JOIN {User.TableName} ON {User.TableName}.{nameof(User.Id)} = {Medic.TableName}.{nameof(Medic.UserId)}
    
    WHERE {Worker.TableName}.{nameof(Worker.IsEnabled)} = 1 AND {Profile.TableName}.{nameof(Profile.RoleId)} = {(int)EtalonRolesEnum.Medic} 
    AND EXISTS(
        SELECT 1 FROM [{_dbName}].{UserRole.TableName} 
        WHERE {UserRole.TableName}.{nameof(UserRole.UserId)} = {User.TableName}.{nameof(User.Id)} 
        AND {UserRole.TableName}.{nameof(UserRole.RoleId)} = {(int)EtalonRolesEnum.Medic}
    )";

            return GetArrayOf<WorkingMedicInfo>(cmdTxt);
        }

        public MedicalInstitutionPlace[] GetMedicalInstitionsPlaces() 
        {
            string tableName = MedicalInstitutionPlace.TableName;
            var cmdTxt = $"SELECT * FROM [{_dbName}].{tableName}";
            return GetArrayOf<MedicalInstitutionPlace>(cmdTxt);
        }

        public MedicalInstitute[] GetMedicalInstitions(int? placeId = null)
        {
            string tableName = MedicalInstitute.TableName;
            var cmdTxt = $"SELECT * FROM [{_dbName}].{tableName} " +
                $"WHERE {nameof(MedicalInstitute.MedicalInstitutePlaceId)} = {placeId}";
            return GetArrayOf<MedicalInstitute>(cmdTxt);
        }

        public Profile[] GetProfiles(int? roleId = null)
        {
            string tableName = Profile.TableName;
            var cmdTxt = $"SELECT * FROM [{_dbName}].{tableName}" +
                $"{(roleId.HasValue ? $" WHERE {nameof(Profile.RoleId)} = {roleId}" : string.Empty)}";
            return GetArrayOf<Profile>(cmdTxt);
        }

        public Rank[] GetRanks()
        {
            string tableName = Rank.TableName;
            var cmdTxt = $"SELECT * FROM [{_dbName}].{tableName}";
            return GetArrayOf<Rank>(cmdTxt);
        }

        public AcademicDegree[] GetAcademicDegrees()
        {
            string tableName = AcademicDegree.TableName;
            var cmdTxt = $"SELECT * FROM [{_dbName}].{tableName}";
            return GetArrayOf<AcademicDegree>(cmdTxt);
        }
    }
}
