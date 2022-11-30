using Application.Common.Interfaces.Repository;
using Domain.Entities;
using Infrastructure.Factories;
using Infrastructure.Persistence.Factories;
using Microsoft.EntityFrameworkCore;
using Polly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.Repositories
{
    public class ProfileRepository : Repository<CustomerProfile>, IProfileRepository
    {
        public ProfileRepository(ProfileDbContext context) : base(context)
        {
        }
       
    }
}
