using _1226.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _1226.Models.Services.Interfaces
{
    public interface IMermberRepository
    {
        bool IsExists(string account);

        void Create(RegisterDto dto);

        MemberDto Load(int mermberId);
        void ActiveRegister(int mermberId);

        MemberDto GetByAccount(string account);
    }
}