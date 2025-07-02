using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingModels.Models
{
    public class BaseResponseModel
    {


        public Boolean Success { get; set; }

        public string ErrorMessage { get; set; }

        public object data { get; set; }

    }
}
