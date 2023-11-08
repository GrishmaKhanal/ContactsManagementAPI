namespace ContactsManagementAPI.Services.ContactDetailService
{
    public interface IContactDetailService
    {
        List<ContactDetails> GetAllContacts();
        ContactDetails? GetContactById(int id);
        List<ContactDetails> AddContact(ContactDetails contact);
        List<ContactDetails>? UpdateContact(int id, ContactDetails request);
        List<ContactDetails>? DeleteContact(int id);

    }
}
