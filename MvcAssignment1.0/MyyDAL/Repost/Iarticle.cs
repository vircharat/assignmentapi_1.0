using MyyEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyyDAL.Repost
{
    public interface Iarticle
    {
        void AddArticle(Article article);

        void RemoveArticle(int articleId);

        void EditArticle(Article article);

        Article GetArticleById(int articleId);

        IEnumerable<Article> GetArticles();
    }
}
