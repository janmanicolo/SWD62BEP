using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.application.AutoMapper
{
    public class AutomapperConfiguration
    {
        //AutoMapper >> Configuration >> Profiles >> Maps
        public static MapperConfiguration RegisterMappings()
        {
            return new MapperConfiguration(
                cfg =>
                {
                    cfg.AddProfile(new DomainToViewModelProfile());
                    cfg.AddProfile(new ViewModelToDomainProfile());
                }
                );
        }
    }
}
