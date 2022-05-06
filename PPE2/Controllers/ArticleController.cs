using Blaguotech.Areas.Models;
using Microsoft.AspNetCore.Mvc;

namespace Blaguotech.Areas
{
    public class ArticleController : Controller
    {
        public static List<ArticleModel> Articles { get; set; } = new List<ArticleModel>
            {
                new ArticleModel
                {
                    Id = 1,
                    Titre = "Best Of Coluche",
                    Auteur = "Coluche",
                    Note = 4.5m
                },
                new ArticleModel
                {
                    Id = 2,
                    Titre = "Best Of Bigard",
                    Auteur = "Jean Marie Bigard",
                    Note = 4.0m
                },
                new ArticleModel
                {
                    Id = 3,
                    Titre = "Best Of Kev Adams",
                    Auteur = "Kev Adams",
                    Note = 3.2m
                }
            };

        public ArticleController()
        {
        }
        public IActionResult Index()
        {
            return View(Articles);
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Create(ArticleModel article)
        {
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Edit(int id)
        {
            var article = Articles.Find(a => a.Id == id);
            return View(article);
        }
        [HttpPost]
        public IActionResult Edit (ArticleModel article)
        {
            if(!ModelState.IsValid)
            {
                return View(article);
            }
            Articles.RemoveAll(a => a.Id == article.Id);
            Articles.Add(article);
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Delete(int id)
        {
            return View();
        }

        public IActionResult Delete(ArticleModel article)
        {
            return RedirectToAction(nameof(Index));
        }
    }

}
