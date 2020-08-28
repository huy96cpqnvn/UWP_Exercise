using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Media.Audio;

namespace ASMNews.Model
{
    class News
    {
        public string Name { get; set; }
        public NewsCategory Category { get; set; }
        public string ImageFile { get; set; }

        public string Title { get; set; }

        public News(string name, NewsCategory category, string title)
        {
            Name = name;
            Category = category;
            Title = title;
            ImageFile = String.Format("/Assets/Images/{0}/{1}.png", category, name);
        }
    }
    public enum NewsCategory
    {
        Sports,
        International,
        Entertainment,
        Education,
        Car,
        Food
    }


}
