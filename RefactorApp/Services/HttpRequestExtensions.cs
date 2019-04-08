using Microsoft.AspNetCore.Http;
using System;

namespace RefactorApp.Services
{
    public static class HttpRequestExtensions
    {
        public static bool IsJson(this HttpRequest request)
        {
            if (request?.ContentType == null)
            {
                return false;
            }

            string mediaType = request.ContentType;
            return string.Equals(mediaType, "application/json", StringComparison.OrdinalIgnoreCase)
                || string.Equals(mediaType, "text/json", StringComparison.OrdinalIgnoreCase)
                || ((mediaType.StartsWith("application/", StringComparison.OrdinalIgnoreCase) || mediaType.StartsWith("text/", StringComparison.OrdinalIgnoreCase))
                    && mediaType.EndsWith("+json", StringComparison.OrdinalIgnoreCase));
        }
    }
}
