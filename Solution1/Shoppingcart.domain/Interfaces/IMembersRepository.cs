using Shoppingcart.domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shoppingcart.domain.Interfaces
{
    public interface IMembersRepository
    {
        void AddMember(Member m);
    }
}
