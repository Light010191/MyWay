using System;
using System.IO;
using System.Threading.Tasks;

namespace BooksHub.Helpers
{
    public class FileUploadHelper
    {
        static public async Task<string> UploadAsync(Microsoft.AspNetCore.Http.IFormFile fromFile)
        {
            if (fromFile != null)
            {               
                var filename = $"{Guid.NewGuid()}{Path.GetExtension(fromFile.FileName)}";
                using var fs = new FileStream(@$"wwwroot/uploads/img/{filename}", FileMode.Create);
                await fromFile.CopyToAsync(fs);
                return @$"/uploads/img/{filename}";

            }

            throw new Exception("File was not upload");
        }
    }
}
