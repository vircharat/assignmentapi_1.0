using Microsoft.EntityFrameworkCore;
using MyyEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyyDAL.Repost
{
    public class ArticleRepsot : Iarticle
    {

        DBContext _dbContext;
        public ArticleRepsot(DBContext dBContext)
        {
            _dbContext = dBContext;
        }
        public void AddArticle(Article article)
        {
            _dbContext.article_tbl.Add(article);
            _dbContext.SaveChanges();
        }



        public void EditArticle(Article article)
        {
            _dbContext.Entry(article).State = EntityState.Modified;

            _dbContext.SaveChanges();

        }

        public Article GetArticleById(int articleId)
        {
            return _dbContext.article_tbl.Find(articleId);
        }

        public IEnumerable<Article> GetArticles()
        {
            return _dbContext.article_tbl.ToList();
        }

        public void RemoveArticle(int ArticleId)
        {
            var article = _dbContext.article_tbl.Find(ArticleId);
            _dbContext.article_tbl.Remove(article);
            _dbContext.SaveChanges();
        }
    }
}
