using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC323_project.comments
{
   public  class Comments
    {
        
        string comment { get; set; }
       DateTime comment_time { get; set; }
        List<Comments> lcomment;
        public Comments(string _comments,DateTime _comment_time)
        {
            comment = _comments;
            comment_time = _comment_time;
        }
       
    }
}
