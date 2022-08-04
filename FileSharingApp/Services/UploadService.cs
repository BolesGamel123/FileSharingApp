using AutoMapper;
using AutoMapper.QueryableExtensions;
using FileSharingApp.Data;
using FileSharingApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FileSharingApp.Services
{
    public class UploadService : IUploadService
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public UploadService(ApplicationDbContext context,IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }
        public async Task CreateAsync(InputUpload model)
        {
            var mappedobj = mapper.Map<Uploads>(model);
            await context.Uploads.AddAsync(mappedobj);
            await context.SaveChangesAsync();
        }

        public async Task DeleteAsync(string Id, string userId)
        {
            var result = await context.Uploads.FirstOrDefaultAsync(u => u.Id == Id && u.UserId == userId);
            if (result != null)
            {
                context.Uploads.Remove(result);
                await context.SaveChangesAsync();
            }
           
        }

        public async Task<UploadViewModel> FindAsync(string Id, string userId)
        {
         var result=await context.Uploads.FirstOrDefaultAsync(u=>u.Id==Id && u.UserId==userId);
            if(result !=null)
            {

                return mapper.Map<UploadViewModel>(result);
    
            }
            return null;
        }

        public async Task<UploadViewModel> FindAsync(string Id)
        {
             var result = await context.Uploads.FindAsync(Id);
            if (result != null)
            {
                return mapper.Map<UploadViewModel>(result);
            }
            return null;
        }

        public IQueryable<UploadViewModel> GetAll()
        {
            var result = context.Uploads.OrderByDescending(u => u.DownloadCount)
                 .ProjectTo<UploadViewModel>(mapper.ConfigurationProvider);   
            return result;
        }

        public IQueryable<UploadViewModel> Getby(string userId)
        {
           var result= context.Uploads.Where(u => u.UserId == userId).OrderByDescending(u => u.UploadDate)
                 .ProjectTo<UploadViewModel>(mapper.ConfigurationProvider);  
            return result;
        }

        public async Task<int> GetUploadCount()
        {
            return await context.Uploads.CountAsync();
        }

        public async Task IncreamentDownloadCount(string id)
        {
            var result = await context.Uploads.FindAsync(id);
            if (result != null)
            {
                result.DownloadCount++;
                context.Update(result);
                await context.SaveChangesAsync();
            }
        }

        public IQueryable<UploadViewModel> Search(string term)
        {
          var result= context.Uploads
               .Where(u => u.OriginFileName.Contains(term))
               .ProjectTo<UploadViewModel>(mapper.ConfigurationProvider);
            return result;
        }
    }
}
