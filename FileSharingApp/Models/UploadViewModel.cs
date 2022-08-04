using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FileSharingApp.Models
{
    public class InputFile
    {
        [Required]
        public IFormFile File { get; set; }
    }
    public class InputUpload
    {
          public string FileName { set; get; }
          public string OriginFileName {set;get;}
          public string ContentType {set;get;}
          public long Size  {set;get;}
          public string UserId  {set;get;}

    }     

    public class UploadViewModel
    {
        [Required]
        public string FileName { get; set; }
        public string OriginFileName { get; set; }
        public decimal Size { get; set; }
        public string ContentType { get; set; }
        public DateTime UploadDate { get; set; }
        public string Id { get; internal set; }
        public long DownloadCount { get; set; }
    }
}
