using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DockerDemo.Models;
using static DockerDemo.Models.ArticlesViewModel;

namespace DockerDemo
{
    public class ArticleRepository
    {
        private List<Article> articles = new List<Article>
        {
                new Article{
                    Id=1,
                    Title="What is lorem ipsum?",
                    Author="Dabing",
                    PublisheddOn=new DateTime(2019,01,20),
                    Content="Lorem Ipsum is simply dummy text of the printing and typesetting industry."
                },
        };
        public List<Article> GetLatest() {
            return articles;
        }
    }
}
