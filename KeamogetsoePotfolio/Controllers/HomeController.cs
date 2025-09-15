using KeamogetsoePotfolio.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Net.Mail;
using System.Net;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace KeamogetsoePotfolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly IConfiguration _configuration;

        public HomeController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

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
                    Title = "Reel Trailers",
                    Description = "A responsive React web app for discovering movies, TV shows, celebrities, and entertainment news with integrated trailer viewing. Reel Trailers is a modern, responsive web application built with React that allows users to discover movies, TV shows, celebrities. The platform features an intuitive interface with trailer viewing capabilities, detailed information, and powerful search functionality.",
                    ImageUrl = "/images/MovieDB.PNG",
                    GithubUrl = "https://github.com/Keamo0713/MovieDB",
                    LiveDemoUrl = "https://movie-db-rust-pi.vercel.app/",
                    Technologies = new List<string> { "React", "Responsive Design", "Movie-DB API", "Entertainment News" }
                },

                new Project
                {
                    Title = "Bank Account System",
                    Description = "Manage your finances with clarity. Sign in to view your accounts, create budgets, and transfer funds securely.",
                    ImageUrl = "/images/BankAccount.PNG",
                    GithubUrl = "https://github.com/Keamo0713/Bank-Account-System",
                    LiveDemoUrl = "https://bank-account-system.onrender.com/",
                    Technologies = new List<string> { "HTML5", "CSS3", "JavaScript (ES6+)", "Custom CSS", "Flexbox/Grid", "Font Awesome", "Google Fonts", "RESTful API (Java Spring Boot)" }
                },
                new Project
                {
                    Title = "Mercedes Configurator",
                    Description = "Discover the perfect Mercedes-Benz model tailored to your preferences and market requirements. I used .NET and the Mercedes API to allow users to see cars in the market and filter them based on price and steering side.",
                    ImageUrl = "/images/MercedesConfigurator.PNG",
                    GithubUrl = "https://github.com/Keamo0713/MercedesConfigurator",
                    LiveDemoUrl = "https://mercedesconfigurator.onrender.com",
                    Technologies = new List<string> { ".NET", "Mercedes API", "Car Configuration", "Filtering" , "C#" }
                },
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
                    Description = "An application that summarizes uploaded books and online books using AI, OpenLibrary for the online books, ElevenLabs API for voice and Gemini API for NLP and Summary genertion.",
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
                    Title = "todo-app",
                    Description = "A feature-rich to-do list application with task history, completion tracking, and interactive UI elements.",
                    ImageUrl = "/images/ToDoList.PNG",
                    GithubUrl = "https://github.com/Keamo0713/todo-app",
                    LiveDemoUrl = "https://todo-app-ipv0.onrender.com/",
                    Technologies = new List<string> { "HTML5", "CSS3", "JavaScript (ES6+)", "Node.js", "Express", "CSS Animations", "Font Awesome Icons", "Vercel" }
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

        [HttpPost]
        public async Task<IActionResult> SendEmail(ContactForm form)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var fromEmail = _configuration["Email:Username"] ?? throw new InvalidOperationException("Email:Username configuration is missing.");
                    var password = _configuration["Email:Password"] ?? string.Empty;
                    var smtpServer = _configuration["Email:SmtpServer"] ?? throw new InvalidOperationException("Email:SmtpServer configuration is missing.");
                    var portString = _configuration["Email:Port"] ?? "587";
                    int port = int.Parse(portString);

                    var mailMessage = new MailMessage
                    {
                        From = new MailAddress(fromEmail),
                        Subject = $"Portfolio Contact Form: {form.Subject}",
                        Body = $"<h1>New Contact Form Submission</h1>" +
                               $"<p><b>Name:</b> {form.FullName}</p>" +
                               $"<p><b>Email:</b> {form.Email}</p>" +
                               $"<p><b>Message:</b> {form.Message}</p>",
                        IsBodyHtml = true,
                    };
                    mailMessage.To.Add(new MailAddress("selekeamogetsoe@gmail.com"));

                    using (var smtpClient = new SmtpClient(smtpServer)
                    {
                        Port = port,
                        Credentials = new NetworkCredential(fromEmail, password),
                        EnableSsl = true,
                    })
                    {
                        await smtpClient.SendMailAsync(mailMessage);
                    }

                    TempData["SuccessMessage"] = "Your message has been sent successfully!";
                    return RedirectToAction("Contact");
                }
                catch (Exception ex)
                {
                    TempData["ErrorMessage"] = "Failed to send your message. Please try again later.";
                    // Log 'ex' for debugging purposes
                    return RedirectToAction("Contact");
                }
            }

            return View("Contact", form);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}