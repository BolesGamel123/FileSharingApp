using FileSharingApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FileSharingApp.Services
{
    public interface IUploadService
    {
        IQueryable<UploadViewModel> GetAll();
        IQueryable<UploadViewModel> Getby(string userId);
        IQueryable<UploadViewModel> Search(string term);
        Task CreateAsync(InputUpload model);
        Task<UploadViewModel> FindAsync(string Id);
        Task<UploadViewModel> FindAsync(string Id,string userId);

        Task DeleteAsync(string Id, string userId);
        Task IncreamentDownloadCount(string id);
        Task<int> GetUploadCount(); 
    }
}
