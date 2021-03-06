﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieOrganizer
{
    
    public enum Rating {Zero, One, Two, Three, Four, Five};

    public class MovieEntry
    {
        public int ID;
        public String Title;
        public int Year;
        public String Director;
        public String Actors;
        public Rating Rate;
        public String Genre;
        public String Description;
        public String Tags;
        public String PictureName;

        public MovieEntry(String ti, int y, String di, String a, Rating r, String g, String de, String ta, String pp)
        {
            Title = ti;
            Year = y;
            Director = di;
            Actors = a;
            Rate = r;
            Genre = g;
            Description = de;
            Tags = ta;
            PictureName = pp;
        }

        public MovieEntry()
        {
            ID = -1;
            Title = "";
            Year = 0;
            Director = "";
            Actors = "";
            Rate = Rating.One;
            Genre = "";
            Description = "";
            Tags = "";
            PictureName = "";
        }
    }
}
