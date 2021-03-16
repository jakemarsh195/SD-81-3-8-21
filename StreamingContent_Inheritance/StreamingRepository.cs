using RepositoryPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingContent_Inheritance
{
    public class StreamingRepository : StreamingContentRepository
    {//Read
        public Show GetShowByTitle(string title)
        {
            //To find a specific show
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content.Title.ToLower()==title.ToLower() && content.GetType() == typeof(Show))
                {
                    return (Show)content;
                }
            }
            return null;
        }
        //Read = Movie
        public Movie GetMovieByTitle(string title)
        {
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content.Title.ToLower() == title.ToLower() && content is Movie)
                {
                    return (Movie)content;
                }
            }
            return null;
        }
        //Read get all
        public List<Show> GetAllShows()
        {   //use this to add our shows = starts empty (we will return this list)
            List<Show> allshows = new List<Show>();

            foreach (StreamingContent content in _contentDirectory)
            {   //if the content that we find is of type Show..
                if (content is Show)
                {//add the show to the allShows list
                    allshows.Add((Show)content);
                }
            }
            return allshows;
        }

        //Read get all movies
        public List<Movie> GetAllMovies()
        {
            List<Movie> allMovies = new List<Movie>();
            
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content is Movie)
                {
                    allMovies.Add(content as Movie);
                }
            }
            return allMovies;
        }
    }
}
