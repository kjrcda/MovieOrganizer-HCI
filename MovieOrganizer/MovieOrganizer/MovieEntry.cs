using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieOrganizer
{
    public enum Rating {One, Two, Three, Four, Five};
    public class MovieEntry
    { 
        String Title;
        int Year;
        String Director;
        String Actors;
        Rating Rate;
        String Description;
        String Tags;

        public MovieEntry(String ti, int y, String di, String a, Rating r, String de, String ta)
        {
            Title = ti;
            Year = y;
            Director = di;
            Actors = a;
            Rate = r;
            Description = de;
            Tags = ta;
        }

        public MovieEntry()
        {
            Title = "";
            Year = 0;
            Director = "";
            Actors = "";
            Rate = Rating.One;
            Description = "";
            Tags = "";
        }

        public void SetTitle(String title)
        {
            Title = title;
        }

        public void SetYear(int year)
        {
            Year = year;
        }

        public void SetDirector(String dir)
        {
            Director = dir;
        }
        public void SetActor(String act)
        {
            Actors = act;
        }

        public void ChangeRating(Rating r)
        {
            Rate = r;
        }
        public void ChangeRating(int r)
        {
            switch (r)
            {
                case 1:
                    ChangeRating(Rating.One);
                    break;
                case 2:
                    ChangeRating(Rating.Two);
                    break;
                case 3:
                    ChangeRating(Rating.Three);
                    break;
                case 4:
                    ChangeRating(Rating.Four);
                    break;
                case 5:
                    ChangeRating(Rating.Five);
                    break;
                default:
                    break;
            }
        }

        public void SetDescription(String desc)
        {
            Description = desc;
        }

        public void SetTags(String tags)
        {
            Tags = tags;
        }
    }
}
