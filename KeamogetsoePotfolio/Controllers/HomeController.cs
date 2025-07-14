using KeamogetsoePotfolio.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Collections.Generic; // Add this using directive if not already present

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
                    Title = "AI Chatbot (No-Code)",
                    Description = "An educational AI chatbot powered by GPT, designed for interactive learning without code.",
                    ImageUrl = "/images/chatbot.png",
                    GithubUrl = "https://github.com/Keamo0713/AI-Learning-Chatbot",
                    LiveDemoUrl = "https://landbot.online/v3/H-2940441-CCTNIO0OAQ85JZDJ/index.html",
                    Technologies = new List<string> {"Landbot", "GPT"}
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
                },
                new Project
{
                     Title = "Whisper: Anonymous Confessions with AI Advice",
                     Description = "A secure web application built with ASP.NET Core MVC, allowing users to anonymously share confessions and receive empathetic AI-generated advice via the Google Gemini API. Features anonymous publishing to a public feed and a professional, dark-themed UI with transparent elements.",
                     ImageUrl = "/images/whisper-app.png", // You'll need to create this image and place it in your wwwroot/images folder
                     GithubUrl = "https://github.com/your-github-username/Whisper", // IMPORTANT: Replace with your actual GitHub repository URL
                     LiveDemoUrl = "https://whisper-hsgq.onrender.com/",
                     Technologies = new List<string> { "ASP.NET Core MVC", "C#", "Razor Pages", "Tailwind CSS", "Google Gemini API", "Render" }
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