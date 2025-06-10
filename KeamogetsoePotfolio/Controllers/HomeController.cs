using KeamogetsoePotfolio.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using static System.Net.WebRequestMethods;

namespace KeamogetsoePotfolio.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Projects()
        {
            var projects = new List<Project>
            {
                new Project
                {
                    Title = "AI Chatbot",
                    Description = "A no-code educational AI chatbot using GPT.",
                    ImageUrl = "/images/chatbot.png",
                    GithubUrl = "https://github.com/Keamo0713/AI-Learning-Chatbot",
                    LiveDemoUrl = "https://landbot.online/v3/H-2940441-CCTNIO0OAQ85JZDJ/index.html",
                    Technologies = new List<string> {"Landbot"}
                },
                new Project
                {
                    Title = "Whisper Vault",
                    Description = "An anonymous confession platform with AI-generated emotional support. Built with ASP.NET Core MVC and OpenAI.",
                    ImageUrl = "/images/whisper-vault.png", // Add your screenshot to wwwroot/images
                    GithubUrl = " https://github.com/Keamo0713/WhisperAIt",
                    LiveDemoUrl = "https://whispervaultapi20250605093017-d6g5fzdrhqggdue9.canadacentral-01.azurewebsites.net/",
                    Technologies = new List<string> { "ASP.NET Core MVC", "C#", "Entity Framework", "OpenAI API", "Bootstrap" ,"AzureDevOps"}
}


               
            };
            return View(projects);
        }

        public IActionResult Contact()
        {
            return View();
        }
    }
}