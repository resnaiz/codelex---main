using System;
using System.Collections.Generic;
using System.Linq;

namespace VideoStore
{
    class Video
    {
        public string videoTitle { get; set; }
        public bool CheckedOut { get; set; }
        private List<int> videoRatings = new List<int>();

        public Video(string title)
        {
            this.videoTitle = title;
            this.CheckedOut = false;
        }

        public void BeingCheckedOut()
        {
            this.CheckedOut = true;
        }

        public void BeingReturned()
        {
            this.CheckedOut = false;
        }

        public void ReceivingRating(int rating)
        {
            this.videoRatings.Add(rating);
        }

        public double AverageRating()
        {
            if(videoRatings.Count == 0)
            {
                return 0;
            }
            else
            {
                return videoRatings.Average();
            }
        }

        public bool Available()
        {
            return !CheckedOut;
        }

        public string Title => videoTitle;

        public override string ToString()
        {
            return $"{Title} {AverageRating()} {Available()}";
        }
    }
}
