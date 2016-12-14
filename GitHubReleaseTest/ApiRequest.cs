using System;
using System.Net;

namespace GitHubReleaseTest
{
    class ApiRequest
    {
        readonly static WebClient WebClient = new WebClient();

        public static string GetJson(Uri uri)
        {
            return WebClient.DownloadString(uri);
              
        }
    }
}
