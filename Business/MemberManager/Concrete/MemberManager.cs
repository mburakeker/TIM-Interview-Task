using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.MemberManager.Abstract;
using DataAccess.EntityFramework;
using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Business.MemberManager.Concrete
{
    public class MemberManager : IMemberManager
    {
        private readonly ILogger<MemberManager> _logger;
        private readonly LibraryContext _context;
        public MemberManager(ILogger<MemberManager> logger,LibraryContext context)
        {
            _logger = logger;
            _context = context;
        }
        public async Task<List<Member>> GetMembers() => await _context.Members.ToListAsync();
        public async Task SaveMember(Member member)
        {
            var memberEntity = await _context.Members.SingleOrDefaultAsync(m => m.EmailAddress == member.EmailAddress);
            if (memberEntity != null)
            {
                _logger.LogInformation($"A Member with Email Address: {member.EmailAddress} is already registered!");
                throw new Exception("A Member with this email address is already registered!");
            }
            member.RegistrationDate = DateTime.Now;
            _context.Members.Add(member);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateMember(Member member)
        {
            var memberEntity = await _context.Members.AsNoTracking().SingleOrDefaultAsync(m => m.MemberId == member.MemberId);
            if (memberEntity == null)
            {
                _logger.LogInformation($"Member with Id {member.MemberId} not found!");
                throw new Exception("Member not found!");
            }
            _context.Members.Update(member);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteMember(int memberId)
        {
            var memberEntity = await _context.Members.SingleOrDefaultAsync(m => m.MemberId == memberId);
            if (memberEntity == null)
            {
                _logger.LogInformation($"Member with Id {memberId} not found!");
                throw new Exception("Member not found!");
            }
            _context.Members.Remove(memberEntity);
            await _context.SaveChangesAsync();
        }
    }
}
