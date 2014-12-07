using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieOrganizer
{
    public class StringMatch
    {
        /*
        * String matching algorithm
        * The algorithm looks for a match and returns true once it finds match
        * accepts string and its pattern to look for
        */
        public static bool match(String search, String toFind)
        {
            if (search.Length == 0)
			    return false;
		    search = search.ToLower();
		    toFind = toFind.ToLower();
		 
		    int n=search.Length, m=toFind.Length;
		    int[] next = new int[m];
		    int j=0;
		 
		    for(int i = 1; i < m; i++) 
		    {
			    while (j > 0 && toFind.ElementAt<Char>(j) != toFind.ElementAt<Char>(i))  
				    j = next[j - 1];
			 
			    if(toFind.ElementAt<Char>(j) == toFind.ElementAt<Char>(i)) 
				    j++; 
			 
			    next[i] = j;
	        }

		    j = 0;
		    for (int i = 0; i < n; i++) 
		    {
		            while (j > 0 && toFind.ElementAt<Char>(j) != search.ElementAt<Char>(i))
		    	        j = next[j - 1];
		      
		            if (toFind.ElementAt<Char>(j) == search.ElementAt<Char>(i))
		    	        j++;
		      
		            if (j == m) 
		                return true;
		    }
		    return false;
        }
    }
}
