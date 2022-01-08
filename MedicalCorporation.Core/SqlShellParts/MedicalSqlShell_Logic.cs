using MedicalCorporation.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MedicalCorporation.Core.SqlShellParts
{
    public partial class MedicalSqlShell
    {
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
