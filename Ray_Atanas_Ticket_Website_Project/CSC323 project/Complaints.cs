using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSC323_project.comments;
namespace CSC323_project
{
    public  class Complaints: Comments
    {
        string Feedback { get; set; }
        string Errortype { get; set; }
        Complaints(string _comment, DateTime _comment_time, string _feedback, string _errortype) : base(_comment, _comment_time)
        {
            Feedback = _feedback;
            Errortype = _errortype;


        }
    }
}
