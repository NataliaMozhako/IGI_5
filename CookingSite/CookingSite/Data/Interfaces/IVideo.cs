using CookingSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CookingSite.Data.Interfaces
{
    interface IVideo
    {
        public void AddVideoDB(Video video);
        public IEnumerable<Video> AllVideos();
        public void DeleteVideo(Video video);
        public Video GetVideoDB(int id);
        public void UpdateVideo(Video video);
    }
}
