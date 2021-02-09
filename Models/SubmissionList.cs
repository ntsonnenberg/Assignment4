using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment4.Models
{
    //The SubmissionList class contains a list of restaurant objects
    //The addSubmission method takes the Submission obejct as the parameter and adds it to the restaurants property (list of restaurant objects)
    public class SubmissionList
    {
        private static List<Submission> restaurants = new List<Submission>();

        public static IEnumerable<Submission> Restaurants => restaurants;

        public static void addSubmission(Submission sub)
        {
            restaurants.Add(sub);
        }
    }
}
