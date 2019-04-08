using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace RefactorApp.Services
{
    public static class StreamExtensions
    {
        public async static Task<string> ReadAsStringAsync(this System.IO.Stream stream)
        {
            using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))
            {
                return await reader.ReadToEndAsync();
            }
        }
    }
}
