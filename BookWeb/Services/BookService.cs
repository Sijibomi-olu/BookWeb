﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookWeb.Data;
using BookWeb.Entities;
using BookWeb.Interface;
using Microsoft.EntityFrameworkCore;

namespace BookWeb.Services
{
    public class BookService : IBook
    {
        private BookWebDataContext _context;
        public BookService(BookWebDataContext context)
        {
            _context = context;
        }

        public void Add(Book book)
        {
            _context.Add(book);
            _context.SaveChanges();
        }
        public async Task<bool> AddAsync(Book book)
        {
            try
            {
                await _context.AddAsync(book);
                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public async Task<bool> Delete(int Id)
        {
            // find the entity/object
            var book = await _context.Books.FindAsync(Id);

            if (book != null)
            {
                _context.Books.Remove(book);
                _context.SaveChanges();
                return true;
            }

            return false;
        }

        public async Task<IEnumerable<Book>> GetAll()
        {

            return await _context.Books.ToListAsync();
        }

        public async Task<Book> GetById(int Id)
        {
            var book = await _context.Books.FindAsync(Id);

            return book;
        }

        public async Task<bool> Update(Book book)
        {
            var books = await _context.Books.FindAsync(book.Id);
            if (books != null)
            {                
                books.Title = book.Title;

                await _context.SaveChangesAsync();
                return true;
            }

            return false;

        }
    }
}
