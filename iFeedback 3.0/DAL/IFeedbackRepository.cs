using iFeedback.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iFeedback.DAL
{
    //Create a contract which all datasource we retrieving information from must fullfil
    public interface IFeedbackRepository
    {
        //Get all feedbacks from any datasource
        IEnumerable<Feedback> GetAll();
       
        //Get feedback of a particular customer for any datasource
        Feedback GetFeedbackByCustomer(int CustomerId);

        //Create a new feedback in any datasource
        Feedback Add(Feedback feedbackData);

        //Commit entry to any datasource
        int Commit();

        //Get Total Customer count in feedback table in any datasource
        int GetTotalCustomers();

        //Get Average Rating for any datasource
        double GetAverageRating();
        
        //Get total count per rating (for barchart);
        IEnumerable<ChartViewModel> GetGroupedRating();
    }
}
