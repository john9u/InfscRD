using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace infosecrd.Models
{
    public class dbManage
    {
        public List<tblArticle> SelectRecentArticles()
        {
            List<tblArticle> list = new List<tblArticle>();
            List<tblArticle> list6 = new List<tblArticle>();
            using (DBinfosecEntities db= new DBinfosecEntities())
            {

                list = db.tblArticles.ToList();                                
            }
            list.Reverse();
            for (int i = 0; i < 6; i++)
            {
                list6.Add(list[i]);
            }
            return list6;
        }
        public tblArticle SelectArticlebyid(int? id)
        {
            tblArticle articulo = new tblArticle();
            using (DBinfosecEntities db = new DBinfosecEntities())
            {

                articulo = db.tblArticles.Find(id);
            }
            return articulo;
        }

    }
}