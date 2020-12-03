using iFeedback.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iFeedback.DAL
{
    public class SqlFeedbackRepository : IFeedbackRepository
    {
        private readonly AppDBContext db;

        public SqlFeedbackRepository(AppDBContext db)
        {
            this.db = db;
        }

        public Feedback Add(Feedback feedbackData)
        {
            db.Add(feedbackData);
            return feedbackData;
        }

        public int Commit()
        {
           return db.SaveChanges();
        }

        public IEnumerable<Feedback> GetAll()
        {
            return from fb in db.Feedbacks select fb;
        }

        public double GetAverageRating()
        {
            var data = this.GetAll();
            int totalRatings = data.Sum(feedback => feedback.Rating);
            int totalFeedbacks = data.Count();
            if (totalFeedbacks == 0)
            {
                return 0;
            }
            return totalRatings / totalFeedbacks;
        }

        public Feedback GetFeedbackByCustomer(int CustomerId)
        {
            return db.Feedbacks.FirstOrDefault(c => c.Id == CustomerId);
        }

        public IEnumerable<ChartViewModel> GetGroupedRating()
        {
            return db.Feedbacks.GroupBy(p => p.Rating).OrderBy(x => x.Key)
                  .Select(g => new ChartViewModel() { Name = $"{g.Key} Stars", Count = g.Count() });
        }

        public int GetTotalCustomers()
        {
            return db.Feedbacks.Count();
        }
    }
}
