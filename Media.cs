using System;
using System.Collections.Generic;

namespace MediaLibrary2._0
{
    public abstract class Media
    {
        // public properties
        public UInt64 mediaId { get; set; }
        public string title { get; set; }
        public List<string> genres { get; set; }
        

        // constructor
        public Media()
        {
            genres = new List<string>();
        }

        // public method
        public virtual string Display()
        {
            return $"Id: {mediaId}\nTitle: {title}\nGenres: {string.Join(", ", genres)}\n";
        }

        
    // Movie class is derived from Media class
    public class Movie : Media
    {
        public string director { get; set; }
        public TimeSpan runningTime { get; set; }
        public string rTime{get; set;}

        public override string Display()
        {
            if(rTime == null){
                return $"Id: {mediaId}\nTitle: {title}\nDirector: {director}\nRun time: {runningTime}\nGenres: {string.Join(", ", genres)}\n";
            }
            else{
                return $"Id: {mediaId}\nTitle: {title}\nDirector: {director}\nRun time: {rTime}\nGenres: {string.Join(", ", genres)}\n";
            }
            
        }
    }



    }
}