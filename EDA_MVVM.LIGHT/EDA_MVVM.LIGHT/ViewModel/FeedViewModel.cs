using EDA_MVVM.LIGHT.Model;
using EDA_MVVM.LIGHT.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace EDA_MVVM.LIGHT.ViewModel
{
    public class FeedViewModel : BaseVM
    {
        FeedService feed;
        public ObservableCollection<FeedModel> FeedCollection { get; set; }
        public FeedViewModel()
        {
            FeedCollection = new ObservableCollection<FeedModel>();
            feed = new FeedService();
            LoadList();
        }

        public void LoadList()
        {
            var Collection = feed.GetFeeds();
            foreach (var feed in Collection)
            {
                FeedCollection.Add(feed);
            }
        }
    }
}
