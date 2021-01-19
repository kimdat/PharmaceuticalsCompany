using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PharmaceuticalsCompany.Models.Candidate;
namespace PharmaceuticalsCompany.Services.Candidate
{
    public interface ICandidateService
    {
         Task<CandidateModel> Login(CandidateModel candidate);
        Task<CandidateModel> Register(CandidateModel model);
        Task<CandidateModel> Logout();
    }
}
