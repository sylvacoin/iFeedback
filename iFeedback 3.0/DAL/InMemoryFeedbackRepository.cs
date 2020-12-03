using iFeedback.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace iFeedback.DAL
{
    //An in memory datasource for demo purposes. Will be swapped with SQLFeedbackRepository later.
    //InMemoryFeedbackRepository fulfils contract in IFeedBackRepository.
    
    public class InMemoryFeedbackRepository : IFeedbackRepository
    {
        private readonly List<Feedback> data;
        public InMemoryFeedbackRepository()
        {
            data = new List<Feedback>
            {
                new Feedback{Id=1,CustomerName="John Wu Chan", CustomerEmail="john.wu@email.com", CustomerPhone="08112345678", Comment="Nice Store had everything i ever dreamt of", Rating = 4},
                new Feedback{Id=2,CustomerName="Sandra Bullock", CustomerEmail="sandra.bullock@email.com", CustomerPhone="08112345679", Comment="Still coming up but the best so far", Rating = 4},
                new Feedback{Id=3,CustomerName="Dare Golden", CustomerEmail="dare.golden@email.com", CustomerPhone="08112345670", Comment="Everything i ever wanted", Rating = 5},
                new Feedback{Id=4,CustomerName="Mctavish Kosnovich", CustomerEmail="mctavish.kosno@email.com", CustomerPhone="08112345677", Comment="Not much but better than nothing", Rating = 3},
            };
        }
        public IEnumerable<Feedback> GetAll()

        {
            return from fb in data
                   orderby fb.Id
                   select fb;
        }

        public Feedback GetFeedbackByCustomer(int CustomerId)
        {
            return data.FirstOrDefault(col => col.Id == CustomerId);            
        }

        public IEnumerable<Feedback> GetFeedbackByRating(int ratingId)
        {
           return data.Where(x => x.Rating == ratingId);
        }

        public Feedback Add(Feedback newFeedbackData)
        {
            data.Add(newFeedbackData);
            newFeedbackData.Id = data.Max(r => r.Id) + 1;
            return newFeedbackData;
        }

        public int Commit()
        {
            return 1;
        }

        public int GetTotalCustomers()
        {
            return data.Count();
        }

        public double GetAverageRating()
        {
            int totalRatings = data.Sum(feedback => feedback.Rating);
            int totalFeedbacks = data.Count();
            if (totalFeedbacks == 0)
            {
                return 0;
            }
            return totalRatings / totalFeedbacks;
        }
        
        public IEnumerable<ChartViewModel> GetGroupedRating()
        {
            return data.GroupBy(p => p.Rating).OrderBy(x => x.Key)
                   .Select(g => new ChartViewModel(){ Name = $"{g.Key} Stars", Count = g.Count() });
        }
    }
}
