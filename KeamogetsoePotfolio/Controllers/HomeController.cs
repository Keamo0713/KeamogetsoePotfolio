using KeamogetsoePotfolio.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
<<<<<<< HEAD
=======
using System.Collections.Generic; // Add this using directive if not already present
>>>>>>> 37db4e9c58dbff33493972da4b3efae6d2c82c11

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
<<<<<<< HEAD
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
                    LiveDemoUrl = "https://bookanddocumentsummerizer.onrender.com/",
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
=======
                    Title = "AI Chatbot (No-Code)",
                    Description = "An educational AI chatbot powered by GPT, designed for interactive learning without code.",
                    ImageUrl = "/images/chatbot.png",
                    GithubUrl = "https://github.com/Keamo0713/AI-Learning-Chatbot",
                    LiveDemoUrl = "https://landbot.online/v3/H-2940441-CCTNIO0OAQ85JZDJ/index.html",
                    Technologies = new List<string> {"Landbot", "GPT"}
                },
                new Project
                {
                    Title = "Whisper: Anonymous Confessions with AI Advice",
                    Description = "A secure web application built with ASP.NET Core MVC, allowing users to anonymously share confessions and receive empathetic AI-generated advice via the Google Gemini API. Features anonymous publishing to a public feed and a professional, dark-themed UI with transparent elements.",
                    ImageUrl = "/images/whisper-app.png", // You'll need to create this image and place it in your wwwroot/images folder
                    GithubUrl = "https://github.com/your-github-username/Whisper", // IMPORTANT: Replace with your actual GitHub repository URL
                    LiveDemoUrl = "https://whisper-hsgq.onrender.com/",
                    Technologies = new List<string> { "ASP.NET Core MVC", "C#", "Razor Pages", "Tailwind CSS", "Google Gemini API", "Render" }
},
                new Project
                {
                    Title = "SecureDoc",
                    Description = "A security system for companies to manage high-level access requests (funds/documents) via manager approval, facial recognition, and stakeholder notifications. Prevents unauthorized fund/document access.",
                    ImageUrl = "/images/plesecuredoc.png", // You'll need to create this image
                    GithubUrl = "https://github.com/Keamo0713/pleSecureDoc",
                    LiveDemoUrl = "#", // Set to "#" if no live demo is available, or link if it is
                    Technologies = new List<string> { "ASP.NET Core MVC", ".NET 6+", "Azure Face API", "Firebase", "Gmail SMTP" }
                },
                new Project
                {
                    Title = "Resume AI Studio",
                    Description = "An AI-powered online resume builder for creating ATS-friendly resumes, generating cover letters, and scoring resumes. Deployed with GitHub Pages.",
                    ImageUrl = "/images/resume-builder.png", // You'll need to create this image
                    GithubUrl = "https://github.com/Keamo0713/ResumeBuilder",
                    LiveDemoUrl = "https://keamo0713.github.io/ResumeBuilder/",
                    Technologies = new List<string> { "HTML5", "Tailwind CSS", "JavaScript", "Gemini API", "html2pdf.js", "GitHub Pages" }
                },
                new Project
                {
                    Title = "Company Sentiment Dashboard (API)",
                    Description = "A Streamlit dashboard performing real-time company sentiment analysis using the Google Gemini API. Deployed on Render.",
                    ImageUrl = "/images/company-sentiment-dashboard-api.png", // You'll need a distinct image for this
                    GithubUrl = "https://github.com/Keamo0713/CompanySentimentalDashboard",
                    LiveDemoUrl = "https://companysentimentaldashboard.onrender.com",
                    Technologies = new List<string> { "Streamlit", "Google Gemini API", "pandas", "matplotlib", "seaborn", "fpdf", "scikit-learn", "Render", "Python" }
                },
                new Project
                {
                    Title = "Company Sentiment Dashboard (Mock)",
                    Description = "A Streamlit dashboard demonstrating company sentiment analysis using mock data for development and testing purposes. Deployed on Render.",
                    ImageUrl = "/images/company-sentiment-dashboard-mock.png", // You'll need a distinct image for this
                    GithubUrl = "https://github.com/Keamo0713/CompanySentimentalDashboardMock",
                    LiveDemoUrl = "https://companysentimentaldashboardmock.onrender.com/",
                    Technologies = new List<string> { "Streamlit", "pandas", "matplotlib", "seaborn", "fpdf", "scikit-learn", "Render", "Python" }
                },
                new Project
                {
                    Title = "Creative Writing Generator",
                    Description = "A Streamlit application that generates creative writing pieces using AI, deployed on Render.",
                    ImageUrl = "/images/creative-writing-generator.png", // You'll need to create this image
                    GithubUrl = "https://github.com/Keamo0713/creative_writing_generator",
                    LiveDemoUrl = "https://creative-writing-generator.onrender.com/",
                    Technologies = new List<string> { "Streamlit", "Python", "Render" }
                }
>>>>>>> 37db4e9c58dbff33493972da4b3efae6d2c82c11
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
