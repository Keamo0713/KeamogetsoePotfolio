using KeamogetsoePotfolio.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

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
                    Title = "Whisper Vault (Whisper API)",
                    Description = "An anonymous confession platform with AI-generated emotional support. Built with ASP.NET Core MVC and OpenAI.",
                    ImageUrl = "/images/AI_Whisper.PNG",
                    GithubUrl = "https://github.com/Keamo0713/Whisper",
                    LiveDemoUrl = "https://whisper-hsgq.onrender.com",
                    Technologies = new List<string> { "ASP.NET Core MVC", "C#", "Entity Framework", "OpenAI API", "Bootstrap", "AzureDevOps", "AI" }
                },
                new Project
                {
                    Title = "SecureLock",
                    Description = "A secure document request and approval system using face recognition, email authentication, and Firebase logging.",
                    ImageUrl = "/images/SecureLock.png",
                    GithubUrl = "https://github.com/Keamo0713/pleSecureDoc",
                    LiveDemoUrl = "https://plesecuredoc.onrender.com/",
                    Technologies = new List<string> { "ASP.NET Core MVC", "Azure Face API", "Firebase", "Gmail SMTP", "C#", "Entity Framework", "REST API", "Security" }
                },
                new Project
                {
                    Title = "Resume Builder",
                    Description = "A responsive web-based tool for building professional resumes.",
                    ImageUrl = "/images/AI_Resume_builder.png",
                    GithubUrl = "https://github.com/Keamo0713/ResumeBuilder",
                    LiveDemoUrl = "https://keamo0713.github.io/ResumeBuilder/",
                    Technologies = new List<string> { "HTML", "CSS", "JavaScript", "Responsive Design", "Web Development" }
                },
                new Project
                {
                    Title = "Company Sentiment Dashboard",
                    Description = "A dashboard for analyzing company sentiment from various data sources using NLP models.",
                    ImageUrl = "/images/Sentimental_Dshboard_AI.PNG",
                    GithubUrl = "https://github.com/Keamo0713/CompanySentimentalDashboard",
                    LiveDemoUrl = "https://companysentimentaldashboard.onrender.com",
                    Technologies = new List<string> { "Python", "Streamlit", "Gemini API", "Pandas", "Matplotlib", "Sentiment Analysis", "Data Visualization", "NLP" }
                },
                new Project
                {
                    Title = "Book Summarizer",
                    Description = "An application that summarizes uploaded books and documents using AI and Gemini API.",
                    ImageUrl = "/images/Book_SUmmerizor_AI.PNG",
                    GithubUrl = "https://github.com/Keamo0713/BookAndDocumentSummerizer",
                    LiveDemoUrl = "https://lumireads-frontend.onrender.com/",
                    Technologies = new List<string> { "Python", "Streamlit", "Gemini API", "NLP", "elevenlabs API", "AI", "Open Library" }
                },
                new Project
                {
                    Title = "Story & Poem Generator App",
                    Description = "A Streamlit web app that uses the Hugging Face API to generate creative stories and poems based on user input.",
                    ImageUrl = "/images/creative_writing_AI.PNG",
                    GithubUrl = "https://github.com/yourusername/story-poem-generator",
                    LiveDemoUrl = "https://poem-and-storycraft.onrender.com/",
                    Technologies = new List<string> { "Python", "Streamlit", "Hugging Face API", "requests", "pandas", "fpdf", "AI", "NLP" }
                },
                new Project
                {
                    Title = "BirdGaze",
                    Description = "A bird recognition and logging system for bird watchers using image classification and geolocation.",
                    ImageUrl = "/images/ebird api 2.0.PNG",
                    GithubUrl = "https://github.com/Keamo0713/BirdGaze",
                    LiveDemoUrl = "#",
                    Technologies = new List<string> { "ASP.NET Core", "ML.NET", "GeoLocation API", "C#", "Entity Framework",  "ebird 2.0 API" }
                },
                new Project
                {
                    Title = "AI Chatbot",
                    Description = "A no-code educational AI chatbot built using Landbot, trained on AI fundamentals.",
                    ImageUrl = "/images/AI_Landbot.PNG",
                    GithubUrl = "https://github.com/Keamo0713/AI-Learning-Chatbot",
                    LiveDemoUrl = "https://landbot.online/v3/H-2940441-CCTNIO0OAQ85JZDJ/index.html",
                    Technologies = new List<string> { "Landbot", "GPT", "No-Code", "AI", "Educational Chatbot" }
                },
            };

            return View(projects);
        }

        public IActionResult Resume()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
