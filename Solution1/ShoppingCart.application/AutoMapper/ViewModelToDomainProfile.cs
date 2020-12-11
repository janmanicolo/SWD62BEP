using AutoMapper;
using Shoppingcart.domain.Models;
using ShoppingCart.application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.application.AutoMapper
{
    public class ViewModelToDomainProfile: Profile
    {
        public ViewModelToDomainProfile()
        {
            CreateMap<ProductViewModels, Product>();//.ForMember(x=>x.Name, opt=> opt.MapFrom(src=>src.Name));
            CreateMap<MemberViewModel, Member>();
            CreateMap<CategoryViewModels, Category>();
        }
    }
}
