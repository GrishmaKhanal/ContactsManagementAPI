using ContactsManagementAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace ContactsManagementAPI.Services.ContactDetailService
{
    public class ContactDetailService : IContactDetailService
    {
        private static List<ContactDetails> contactList = new List<ContactDetails>
        {
            new ContactDetails
            {
                Id = 1,
                Name = "Acc",
                Email = "",
                Address = "",
                PhoneNumber = "*400#",
                Note = "Check CellPhone's Account Balance"
            },
            new ContactDetails
            {
                Id = 2,
                Name = "Police",
                Email = "",
                Address = "Nepal",
                PhoneNumber = "100",
                Note = "Emergency Police Station Number"
            }
        };
        public List<ContactDetails> AddContact(ContactDetails contact)
        {
            contactList.Add(contact);
            return contactList;
        }

        public List<ContactDetails>? DeleteContact(int id)
        {
            var contact = contactList.Find(x => x.Id == id);

            if (contact == null) return null;

            contactList.Remove(contact);
            return contactList;
        }

        public List<ContactDetails> GetAllContacts()
        {
            return contactList;
        }

        public ContactDetails? GetContactById(int id)
        {
            var contact = contactList.Find(x => x.Id == id);

            if (contact == null) return null;
            
            return contact;
        }

        public List<ContactDetails>? UpdateContact(int id, ContactDetails request)
        {
            var contact = contactList.Find(x => x.Id == id);

            if (contact == null) return null;

            contact.Name = request.Name;
            contact.Email = request.Email;
            contact.Address = request.Address;
            contact.PhoneNumber = request.PhoneNumber;
            contact.Note = request.Note;

            return contactList;
        }
    }
}
