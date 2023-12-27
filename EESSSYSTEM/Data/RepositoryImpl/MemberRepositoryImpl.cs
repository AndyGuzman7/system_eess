using EESSSYSTEM.Data.DataSource.Remote;
using EESSSYSTEM.Domain.Entities;
using EESSSYSTEM.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EESSSYSTEM.Data.RepositoryImpl
{
    public class MemberRepositoryImpl : IMemberRepository
    {
        private MemberDataSourcerRemote memberDataSourcerRemote;

        public MemberRepositoryImpl(MemberDataSourcerRemote memberDataSourcerRemote)
        {
            this.memberDataSourcerRemote = memberDataSourcerRemote;
        }

        public async Task<List<MemberEntity>> GetAllMembers()
        {
            var list = await memberDataSourcerRemote.Get();
            return list.Select((model) => new MemberEntity(model)).ToList();
        }
    }
}
