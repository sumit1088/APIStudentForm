namespace StudentForm.Models
{
    public class School
    {
        public int Id { get; set; }
        public int SchoolId { get; set; }
        public int CenterId { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public int DistrictId { get; set; }
        public int Password { get; set; }
        public int TehsilId { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? Created { get; set; }
        public ICollection<Student>? Students { get; set; }
    }
}
