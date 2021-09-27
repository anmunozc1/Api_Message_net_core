using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapi_sofka.Entities;

namespace webapi_sofka.Interface
{
    public interface IMessageApp
    {
        MessageApp GetMessage(int Id_Language);
    }
}
