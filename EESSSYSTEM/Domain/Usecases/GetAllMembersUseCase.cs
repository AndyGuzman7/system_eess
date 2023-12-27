using EESSSYSTEM.Core;
using EESSSYSTEM.Domain.Entities;
using EESSSYSTEM.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EESSSYSTEM.Domain.Usecases
{
    public class GetAllMembersUseCase : IUseCase<List<MemberEntity>, NoParams>
    {
        private IMemberRepository memberRepository;

        public GetAllMembersUseCase(IMemberRepository memberRepository)
        {
            this.memberRepository = memberRepository;
        }

        public Task<List<MemberEntity>> Call(NoParams @params)
        {
            return memberRepository.GetAllMembers();
        }
    }
}
