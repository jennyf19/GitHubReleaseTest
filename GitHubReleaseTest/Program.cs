﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Octokit;
using Newtonsoft.Json;
using NuGet;

namespace GitHubReleaseTest
{
    class Program
    {
        const string GitHubPath = "https://api.github.com/repos/jennyf19/BinaryTree/releases/latest";

        static void Main(string[] args)
        {
            try
            {

                var gitHubUri = new Uri(GitHubPath);

                var json = ApiRequest.GetJson(gitHubUri);

                GitHubRepoLatestRelease jsonObject = JsonConvert.DeserializeObject<GitHubRepoLatestRelease>(json);
                Author jsonObject2 = JsonConvert.DeserializeObject<Author>(json);

                Console.WriteLine("The name of the release is: " + jsonObject.name + "\nThe version number is: " + jsonObject.tag_name);
                // + "\nThe markdown is: " + jsonObject.body
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex);

            }


            Console.ReadLine();
        }
    }
    
    public class Author
    {
        public string login { get; set; }
        public int id { get; set; }
        public string avatar_url { get; set; }
        public string gravatar_id { get; set; }
        public string url { get; set; }
        public string html_url { get; set; }
        public string followers_url { get; set; }
        public string following_url { get; set; }
        public string gists_url { get; set; }
        public string starred_url { get; set; }
        public string subscriptions_url { get; set; }
        public string organizations_url { get; set; }
        public string repos_url { get; set; }
        public string events_url { get; set; }
        public string received_events_url { get; set; }
        public string type { get; set; }
        public bool site_admin { get; set; }
    }


    public class GitHubRepoLatestRelease
    {
        public string url { get; set; }
        public string assets_url { get; set; }
        public string upload_url { get; set; }
        public string html_url { get; set; }
        public int id { get; set; }
        public string tag_name { get; set; }
        public string target_commitish { get; set; }
        public string name { get; set; }
        public bool draft { get; set; }
        public Author author { get; set; }
        public bool prerelease { get; set; }
        public string created_at { get; set; }
        public string published_at { get; set; }
        public List<object> assets { get; set; }
        public string tarball_url { get; set; }
        public string zipball_url { get; set; }
        public string body { get; set; }
    }
}


