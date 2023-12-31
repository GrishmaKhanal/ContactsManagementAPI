﻿using ContactsManagementAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace ContactsManagementAPI.Services.ContactDetailService
{
    public class ContactDetailService : IContactDetailService
    {
        //private static List<ContactDetails> contactList = new List<ContactDetails>
        //{
        //    new ContactDetails
        //    {
        //        Id = 1,
        //        Name = "Acc",
        //        Email = "",
        //        Address = "",
        //        PhoneNumber = "*400#",
        //        Note = "Check CellPhone's Account Balance"
        //    },
        //    new ContactDetails
        //    {
        //        Id = 2,
        //        Name = "Police",
        //        Email = "",
        //        Address = "Nepal",
        //        PhoneNumber = "100",
        //        Note = "Emergency Police Station Number"
        //    }
        //};

        private readonly DataContext _context;
        public ContactDetailService(DataContext context)
        {
            _context = context;
        }
        public async Task<List<ContactDetails>> AddContact(ContactDetails contact)
        {
            _context.ContactDetailss.Add(contact);
            await _context.SaveChangesAsync();

            var contacts = await _context.ContactDetailss.ToListAsync();
            return contacts;
        }

        public async Task<List<ContactDetails?>> DeleteContact(int id)
        {
            var contact = await _context.ContactDetailss.FindAsync(id);

            if (contact == null) return null;

            _context.ContactDetailss.Remove(contact);
            await _context.SaveChangesAsync();

            var contacts = await _context.ContactDetailss.ToListAsync();
            return contacts;
        }

        public async Task<List<ContactDetails>> GetAllContacts()
        {
            var contacts = await _context.ContactDetailss.ToListAsync();
            return contacts;
        }

        public async Task<ContactDetails>? GetContactById(int id)
        {
            var contact = await _context.ContactDetailss.FindAsync(id);

            if (contact == null) return null;
            
            return contact;
        }

        public async Task<List<ContactDetails>>? UpdateContact(int id, ContactDetails request)
        {
            //Find Contact with the given ID
            var contact = await _context.ContactDetailss.FindAsync(id);
            if (contact == null) return null;

            contact.Name = request.Name;
            contact.Email = request.Email;
            contact.Address = request.Address;
            contact.PhoneNumber = request.PhoneNumber;
            contact.Note = request.Note;
            await _context.SaveChangesAsync();

            //contacts get all the contacts of db and returns it
            var contacts = await _context.ContactDetailss.ToListAsync();
            return contacts;
        }
    }
}
