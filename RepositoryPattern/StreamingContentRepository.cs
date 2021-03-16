using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern
{
    public class StreamingContentRepository
    {
        protected readonly List<StreamingContent> _contentDirectory = new List<StreamingContent>();
        //Create
        public bool AddContentToDirectory(StreamingContent content)
        {
            int startingCount = _contentDirectory.Count; //starting to count content directory

            _contentDirectory.Add(content); //adding content to the directory
                                                        //is greater than the starting count, is it true of false
            bool wasAdded = (_contentDirectory.Count > startingCount) ? true : false; //will tell us was the content added
            return wasAdded; //true, was added because the starting counting was 4, will be updated to 5, now move on
        }
        //read
        public List<StreamingContent> GetContent() 
        {
            return _contentDirectory;     //getting all of the content, returning the list   
        }
        //Read = helper method b/c used thorughout this repo
        public StreamingContent GetContentByTitle(string title)
        {
            foreach(StreamingContent content in _contentDirectory)
            {
                if(content.Title.ToLower() == title.ToLower())
                {
                    return content;
                }
            }
            return null;
        }

        public StreamingContent GetContentByStarRating(double starRating )
        {
            foreach(StreamingContent content in _contentDirectory)
            {
                if(content.StarRating == starRating)
                {
                    return content;
                }
            }

            return null;
        }

        public StreamingContent GetContentByMaturityRating(MaturityRating maturityRating)
        {
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content.MaturityRating == maturityRating)
                {
                    return content;
                }
            }
            return null;
        }

        public StreamingContent GetContentByGenreType(GenreType genreType)
        {
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content.GenreType == genreType)
                {
                    return content;
                }
            }

            return null;
        }

        public StreamingContent GetContentByReleaseYear(bool isFamilyFriendly)
        {
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content.IsFamilyFriendly == isFamilyFriendly)
                {
                    return content;
                }
            }

            return null;
        }

        public bool UpdateExistingContent(string originalTitle, StreamingContent newContent)
        {
            StreamingContent oldContent = GetContentByTitle(originalTitle); //bringing in the content we want to update

            if(oldContent != null)
            {
                oldContent.Title = newContent.Title;
                oldContent.Description = newContent.Description;
                oldContent.MaturityRating = newContent.MaturityRating;
                oldContent.GenreType = newContent.GenreType;
                oldContent.StarRating = newContent.StarRating;

                return true;
            }
            else
            {
                return false;
            }
        }

        public bool UpdateExistingContent(string v, object newContent)
        {
            throw new NotImplementedException();
        }

        public bool DeleteExistingContent(StreamingContent existingContent) //method is used to delete content
        {
            bool deleteResult = _contentDirectory.Remove(existingContent);
            return deleteResult;
        }



    }
}
