using KeamogetsoePotfolio.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Collections.Generic; // Keeping this directive for clarity

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
                    Title = "Whisper Vault (Whisper API)", // Updated title for clarity
                    Description = "An anonymous confession platform with AI-generated emotional support. Built with ASP.NET Core MVC and OpenAI.",
                    ImageUrl = "/images/AI_Whisper.PNG", // Ensure this file exists in wwwroot/images
                    GithubUrl = "https://github.com/Keamo0713/Whisper", // Updated GitHub URL
                    LiveDemoUrl = "https://whisper-hsgq.onrender.com", // Updated Live Demo URL
                    Technologies = new List<string> { "ASP.NET Core MVC", "C#", "Entity Framework", "OpenAI API", "Bootstrap", "AzureDevOps", "AI" } // Added AI
                },
                new Project
                {
                    Title = "SecureLock", // Renamed from pleSecureDoc to SecureLock
                    Description = "A secure document request and approval system using face recognition, email authentication, and Firebase logging.",
                    ImageUrl = "/images/SecureLock.png", // Ensure this image exists in wwwroot/images
                    GithubUrl = "https://github.com/Keamo0713/pleSecureDoc",
                    LiveDemoUrl = "https://plesecuredoc.onrender.com/", // Updated Live Demo URL
                    Technologies = new List<string> { "ASP.NET Core MVC", "Azure Face API", "Firebase", "Gmail SMTP", "C#", "Entity Framework", "Security" } // Added Security
                },
                new Project // New Project: Resume Builder
                {
                    Title = "Resume Builder",
                    Description = "A web-based tool for building professional resumes.",
                    ImageUrl = "/images/AI_Resume_builder.png", // Placeholder image: Create this in wwwroot/images
                    GithubUrl = "https://github.com/Keamo0713/ResumeBuilder",
                    LiveDemoUrl = "https://keamo0713.github.io/ResumeBuilder/",
                    Technologies = new List<string> { "HTML", "CSS", "JavaScript", "Web Development" }
                },
                new Project // New Project: Company Sentiment Dashboard
                {
                    Title = "Company Sentiment Dashboard",
                    Description = "A dashboard for analyzing company sentiment from various data sources.",
                    ImageUrl = "/images/Sentimental_Dshboard_AI.PNG", // Placeholder image: Create this in wwwroot/images
                    GithubUrl = "https://github.com/Keamo0713/CompanySentimentalDashboard",
                    LiveDemoUrl = "https://companysentimentaldashboard.onrender.com",
                    Technologies = new List<string> { "Python", "Machine Learning", "Data Visualization", "Web Dashboard", "Sentiment Analysis" }
                },
                new Project // New Project: Book Summarizer
                {
                    Title = "Book Summarizer",
                    Description = "An application that summarizes books and documents using AI.",
                    ImageUrl = "/images/Book_SUmmerizor_AI.PNG", // Placeholder image: Create this in wwwroot/images
                    GithubUrl = "https://github.com/Keamo0713/BookAndDocumentSummerizer",
                    LiveDemoUrl = "https://bookanddocumentsummerizer.onrender.com/",
                    Technologies = new List<string> { "Python", "AI", "Natural Language Processing (NLP)", "Web Application" }
                },
                new Project // NEW PROJECT: Story & Poem Generator App
                {
                    Title = "Story & Poem Generator App",
                    Description = "A Streamlit web app that uses the Hugging Face API to generate creative stories and poems based on user input. The app offers a fun and interactive way to experiment with storytelling by customizing key elements of the narrative.",
                    ImageUrl = "/images/creative_writing_AI.PNG", // Placeholder image: Create this in wwwroot/images
                    GithubUrl = "https://github.com/yourusername/story-poem-generator", // Assuming 'yourusername' is a placeholder, please update if you have the actual repo
                    LiveDemoUrl = "https://poem-and-storycraft.onrender.com/", // Updated Live Demo URL
                    Technologies = new List<string> { "Streamlit", "Hugging Face API", "Python", "requests", "python-dotenv", "fpdf", "pandas", "numpy", "AI", "NLP" }
                },
                new Project
                {
                    Title = "BirdGaze",
                    Description = "A bird recognition and logging system for bird watchers using image classification and geolocation.",
                    ImageUrl = "/images/birdgaze.png", // Ensure this image exists in wwwroot/images
                    GithubUrl = "https://github.com/Keamo0713/BirdGaze",
                    LiveDemoUrl = "#", // Replace with actual URL if hosted
                    Technologies = new List<string> { "ASP.NET Core", "ML.NET", "GeoLocation API", "C#", "Entity Framework", "Machine Learning" } // Added Machine Learning
                },
                new Project
                {
                    Title = "AI Chatbot",
                    Description = "A no-code educational AI chatbot using GPT.",
                    ImageUrl = "/images/AI_Landbot.PNG", // Ensure this image exists in wwwroot/images
                    GithubUrl = "https://github.com/Keamo0713/AI-Learning-Chatbot",
                    LiveDemoUrl = "https://landbot.online/v3/H-2940441-CCTNIO0OAQ85JZDJ/index.html",
                    Technologies = new List<string> { "Landbot", "AI/GPT" } // Added AI/GPT for clarity
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
