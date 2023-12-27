using EESSSYSTEM.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EESSSYSTEM.Domain.Repository
{
    public interface IMemberRepository
    {
        Task<List<MemberEntity>> GetAllMembers();
    }
}
