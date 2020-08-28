using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASMNews.Model
{
    class NewsManager
    {
        public static void GetAllNews(ObservableCollection<News> news)
        {
            var allNews = GetNews();
            news.Clear();
            allNews.ForEach(p => news.Add(p));
        }

        public static void GetNewsByCategory(ObservableCollection<News> news, NewsCategory newsCategory)
        {
            var allNews = GetNews();
            var filteredNews = allNews.Where(p => p.Category == newsCategory).ToList();
            news.Clear();
            filteredNews.ForEach(p => news.Add(p));
        }

        private static List<News> GetNews()
        {
            var news = new List<News>();

            news.Add(new News("arsenal", NewsCategory.Sports, "Arsenal vô địch FA cup"));
            news.Add(new News("bayern", NewsCategory.Sports, "Bayern vô địch FA cup"));

            news.Add(new News("america", NewsCategory.International, "Mỹ căng thẳng với Nga"));
            news.Add(new News("russia", NewsCategory.International, "Nga căng thẳng với Mỹ"));

            news.Add(new News("reply", NewsCategory.Entertainment, "Reply 1988 rất đáng xem"));
            news.Add(new News("blooms", NewsCategory.Entertainment, "Blooms Camelia cực hay"));

            news.Add(new News("study", NewsCategory.Education, "Học sinh mầm non nghỉ học"));
            news.Add(new News("hatinh", NewsCategory.Education, "Hà Tĩnh tổ chức thi THPTQG"));

            news.Add(new News("bmw", NewsCategory.Car, "BMW bán chạy nhất 2020"));
            news.Add(new News("electric", NewsCategory.Car, "Xe điện Audi vừa ra mắt"));

            news.Add(new News("bun", NewsCategory.Food, "Bún đậu xuất khẩu sang Mỹ"));
            news.Add(new News("rau", NewsCategory.Food, "Rau sạch giảm giá mùa dịch"));

            return news;
        }
    }
}
