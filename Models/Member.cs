using System.ComponentModel.DataAnnotations;

namespace NetCore.Models
{
    public class Member
    {
        [Key]
        public int Id { get; set; }
        public string Cname { get; set; }
        public string Ename { get; set; }
        public string Email { get; set; }
        public string Tel { get; set; }
        public string Identification { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
