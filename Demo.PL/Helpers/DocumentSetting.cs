using Microsoft.AspNetCore.Http;
using System;
using System.IO;

namespace Demo.PL.Helpers
{
    public static class DocumentSetting
    {
        public static string UploadFile(IFormFile file, string folderName)
        {
            //1. Get Located folder path.
            string folderPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\files", folderName);

            //2. Get file name and make it unique.
            string fileName = $"{Guid.NewGuid()}{file.FileName}";

            //3. Get file Path (Have two above mentioned variables 1&2).
            string filePath = Path.Combine(folderPath, fileName);

            //4. Save file as streams : [Data per Time - Like YouTybe]
            using var fs = new FileStream(filePath, FileMode.Create);

            file.CopyTo(fs);

            return fileName;
        }

        public static void DeleteFile(string fileName, string folderName)
        {
            string filePath = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot\\files", folderName, fileName);

            if (File.Exists(filePath))
                File.Delete(filePath);
        }
    }
}
