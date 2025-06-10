namespace KeamogetsoePotfolio.Models
{
   

    public class Project
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string GithubUrl { get; set; }
        public string LiveDemoUrl { get; set; }
        public List<string> Technologies { get; set; }
    }
}
