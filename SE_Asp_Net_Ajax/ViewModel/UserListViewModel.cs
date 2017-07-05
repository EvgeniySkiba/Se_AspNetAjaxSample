using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SE_Asp_Net_Ajax.Models;

namespace SE_Asp_Net_Ajax.ViewModel
{
    public class UserListViewModel
    {
        public  IEnumerable<User>users { get; set; }
        public int CurrentPage { get; set; }

        public int TotalCount { get; set; }
    }
}