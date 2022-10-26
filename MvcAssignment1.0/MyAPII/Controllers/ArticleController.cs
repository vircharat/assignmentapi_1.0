using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyyBLL.services;
using MyyEntity;
using System.Collections.Generic;

namespace MyAPII.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticleController : ControllerBase
    {
        private ArticleService _ArticleService;

        public ArticleController(ArticleService ArticleService)
        {
            _ArticleService = ArticleService;
        }


        [HttpGet("GetArticles")] //attributes called inside square brackets 
        // by default get method fires if we not specify attributes

        public IEnumerable<Article> GetArticles()
        {
            return _ArticleService.Getarticles();
        }



        [HttpPost("AddArticle")]
        public IActionResult AddArticle([FromBody] Article Article)
        {
            _ArticleService.Addarticle(Article);
            return Ok("Article Created successfully!!");
        }

        [HttpDelete("DeleteArticle")]

        public IActionResult DeleteArticle(int articleId)  //iactionresult it can return anything like integer string json etc
        {
            _ArticleService.Removearticle(articleId);

            return Ok("Article Deleted successfully!!");


        }

        [HttpPut("UpdateArticle")]

        public IActionResult UpdateArticle([FromBody] Article Article)
        {
            _ArticleService.Editarticle(Article);
            return Ok("Article updated successfully!!");
        }


        [HttpGet("GetArticlebyId")]
        public Article GetArticlebyId(int articleId)
        {

            return _ArticleService.GetarticlebyId(articleId);

        }
    }
}
