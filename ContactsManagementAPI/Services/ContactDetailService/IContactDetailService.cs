namespace ContactsManagementAPI.Services.ContactDetailService
{
    public interface IContactDetailService
    {
        Task<List<ContactDetails>> GetAllContacts();
        Task<ContactDetails>? GetContactById(int id);
        Task<List<ContactDetails>> AddContact(ContactDetails contact);
        Task<List<ContactDetails?>> UpdateContact(int id, ContactDetails request);
        Task<List<ContactDetails?>> DeleteContact(int id);

    }
}
