using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment4.Models
{
    public class TempStorage
    {
        private static List<Submission> submissions = new List<Submission>();

        public static IEnumerable<Submission> AllSubmissions => submissions;

        public static void AddSubmission(Submission submission)
        {
            submissions.Add(submission);
        }
    }
}
