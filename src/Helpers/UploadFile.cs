﻿using System.Security.Cryptography.X509Certificates;

namespace src.Helpers
{
    public static class UploadFile
    {
        public static async Task<string> SaveAndReturnFileName(IFormFile file, string typeOfDocument)
        {
            string path = "";
            try
            {
                if (file.Length > 0)
                {
                    path = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, "Uploads", typeOfDocument));
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }
                    using (var fileStream = new FileStream(Path.Combine(path, file.FileName), FileMode.Create))
                    {
                        await file.CopyToAsync(fileStream);
                    }
                }
                return ($"{file.FileName}_{DateTime.Now}"); 
            }
            catch (Exception ex)
            {
                throw new Exception("File Copy Failed", ex);
            }
        }
        public static async Task<string> SaveAndReturnFileName(IFormFile file, string typeOfDocument, string pathToFile)
        {
            string path = "";
            try
            {
                if (file.Length > 0)
                {
                    
                    path = pathToFile;
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }
                    using (var fileStream = new FileStream(Path.Combine(path, file.FileName), FileMode.Create))
                    {
                        await file.CopyToAsync(fileStream);
                    }
                }
                return ($"{file.FileName}_{DateTime.Now}");
            }
            catch (Exception ex)
            {
                throw new Exception("File Copy Failed", ex);
            }
        }
    }
}
