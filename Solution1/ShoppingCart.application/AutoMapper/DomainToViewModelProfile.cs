using AutoMapper;
using Shoppingcart.domain.Models;
using ShoppingCart.application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.application.AutoMapper
{
    public class DomainToViewModelProfile: Profile
    {
        public DomainToViewModelProfile()
        {
            CreateMap<Product, ProductViewModels>();//.ForMember(x=>x.Name, opt=> opt.MapFrom(src=>src.Name));
            CreateMap<Member, MemberViewModel>();
            CreateMap<Category, CategoryViewModels>();
        }
    }
}
