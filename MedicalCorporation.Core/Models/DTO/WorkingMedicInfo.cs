using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalCorporation.Core.Models.DTO
{
    public class WorkingMedicInfo
    {
        [DisplayedName("ID")]
        public int Id { get; set; }
        [DisplayedName("Имя")]
        public string Name { get; set; }
        [DisplayedName("Фамилия")]
        public string Surname { get; set; }
        [DisplayedName("Отчество")]
        public string Patronymic { get; set; }
        [DisplayedName("Профиль")]
        public string ProfileName { get; set; }
        [DisplayedName("Звание")]
        public string RankName { get; set; }
        [DisplayedName("Опыт работы (кол-во лет)")]
        public int WorkExperienceInYears { get; set; }
    }
}
