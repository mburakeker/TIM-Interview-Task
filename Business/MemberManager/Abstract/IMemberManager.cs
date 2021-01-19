using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Business.MemberManager.Abstract
{
    public interface IMemberManager
    {
        Task SaveMember(Member member);
        Task<List<Member>> GetMembers();
        Task UpdateMember(Member member);
        Task DeleteMember(int memberId);
    }
}
