namespace MedicalCorporation.Core.Models.DTO
{
    public class WorkingMedicInfo
    {
        [DTOPropertyInfo("ID")]
        public int Id { get; set; }
        [DTOPropertyInfo("Имя")]
        public string Name { get; set; }
        [DTOPropertyInfo("Фамилия")]
        public string Surname { get; set; }
        [DTOPropertyInfo("Отчество")]
        public string Patronymic { get; set; }
        [DTOPropertyInfo("Профиль")]
        public string ProfileName { get; set; }
        [DTOPropertyInfo("Звание")]
        public string RankName { get; set; }
        [DTOPropertyInfo("Опыт работы (кол-во лет)")]
        public int WorkExperienceInYears { get; set; }
    }
}
