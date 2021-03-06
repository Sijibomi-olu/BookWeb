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
    public class CharacteristicsService : ICharacteristics
    {
        private BookWebDataContext _context;
        public CharacteristicsService(BookWebDataContext context)
        {
            _context = context;
        }

        public void Add(Characteristics characteristics)
        {
            _context.Add(characteristics);
            _context.SaveChanges();
        }
        public async Task<bool> AddAsync(Characteristics characteristics)
        {
            try
            {
                await _context.AddAsync(characteristics);
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
            var characteristics = await _context.Characteristics.FindAsync(Id);

            if (characteristics != null)
            {
                _context.Characteristics.Remove(characteristics);
                _context.SaveChanges();
                return true;
            }

            return false;
        }

        public async Task<IEnumerable<Characteristics>> GetAll()
        {

            return await _context.Characteristics.ToListAsync();
        }

        public async Task<Characteristics> GetById(int Id)
        {
            var characteristics = await _context.Characteristics.FindAsync(Id);

            return characteristics;
        }

        public async Task<bool> Update(Characteristics characteristics)
        {
            var cha = await _context.Characteristics.FindAsync(characteristics.Id);
            if (cha != null)
            {                
                cha.Title = characteristics.Title;

                await _context.SaveChangesAsync();
                return true;
            }

            return false;

        }
    }
}
