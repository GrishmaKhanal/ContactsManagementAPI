using System.ComponentModel.DataAnnotations;

namespace ContactsManagementAPI.Models
{
    public class ContactDetails
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Email { get; set; }
        public string? Address {  get; set; } 

        public string PhoneNumber { get; set; } = string.Empty;
        public string? Note {  get; set; }

    }
}
