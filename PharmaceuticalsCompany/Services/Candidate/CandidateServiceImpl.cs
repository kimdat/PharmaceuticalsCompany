using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using PharmaceuticalsCompany.Models.Candidate;

namespace PharmaceuticalsCompany.Services.Candidate
{
    public class CandidateServiceImpl : ICandidateService
    {
        private readonly UserManager<IdentityUser> _um;
        private readonly SignInManager<IdentityUser> _sm;
        public CandidateServiceImpl(UserManager<IdentityUser> um, SignInManager<IdentityUser> sm)
        {
            _um = um;
            _sm = sm;

        }
        public async Task<CandidateModel> Login(CandidateModel candidate)
        {
                var result = await _sm.PasswordSignInAsync(candidate.Email, candidate.PassWord, false, false);
                if(result.Succeeded)
                {
                    return candidate;
                }
                else
                {
                    return null;
                }
        }

        public async Task<CandidateModel> Logout()
        {
            await _sm.SignOutAsync();
            return null;
        }

        public  async Task<CandidateModel> Register(CandidateModel model)
        {
            var user = new IdentityUser
            {
                UserName = model.Email,
                Email = model.Email,
                
            };
         
            var result = await _um.CreateAsync(user, model.PassWord);
            if(result.Succeeded)
            {

                await _sm.SignInAsync(user, isPersistent: false);
                return model;
            }
              
            
                return null;
        }
    }
}
