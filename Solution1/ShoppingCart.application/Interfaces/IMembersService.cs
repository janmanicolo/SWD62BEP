﻿using ShoppingCart.application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.application.Interfaces
{
    public interface IMembersService
    {
        void AddMember(MemberViewModel m);
    }
}
