using ShoppincCart.data.Context;
using Shoppingcart.domain.Interfaces;
using Shoppingcart.domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppincCart.data.Repositories
{
    public class MembersRepostory : IMembersRepository
    {
        ShoppingCartDbContext _context;
        public MembersRepostory(ShoppingCartDbContext context)
        {
            _context = context;
        }
        public void AddMember(Member m)
        {
            _context.Members.Add(m);
            _context.SaveChanges();
        }
    }
}
