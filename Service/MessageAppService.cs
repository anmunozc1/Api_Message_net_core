using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapi_sofka.Contexts;
using webapi_sofka.Entities;
using webapi_sofka.Interface;

namespace webapi_sofka.Service
{
    public class MessageAppService : IMessageApp
    {
        private readonly AppDbContext _context;

        public MessageAppService(AppDbContext context)
        {
            _context = context;
        }
        public MessageApp GetMessage(int Id_Language)
        {
            try
            {
                var messageapp =  _context.MessageApp.FirstOrDefault(p => p.Id_Language == Id_Language);
                return messageapp;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
