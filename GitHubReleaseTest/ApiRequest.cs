using System;
using System.Net;

namespace GitHubReleaseTest
{
    class ApiRequest
    {
        readonly static WebClient WebClient = new WebClient();

        public static string GetJson(Uri uri)
        {
            WebClient.Headers.Add("user-agent", "Jenny's Awesome Release Automator App");

            return WebClient.DownloadString(uri);

              
        }
    }
}
