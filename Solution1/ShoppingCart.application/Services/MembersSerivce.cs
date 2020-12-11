using Shoppingcart.domain.Interfaces;
using Shoppingcart.domain.Models;
using ShoppingCart.application.Interfaces;
using ShoppingCart.application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.application.Services
{
    public class MembersSerivce : IMembersService
    {
        private IMembersRepository _membersRep;
        public MembersSerivce(IMembersRepository membersRepository)
        {
            _membersRep = membersRepository;
        }

        public void AddMember(MemberViewModel m)
        {
            Member member = new Member();
            member.Email = m.Email;
            member.FirstName = m.FirstName;
            member.LastName = m.LastName;

            _membersRep.AddMember(member);
        }
    }
}
