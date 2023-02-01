using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Response
{
    public class ExceptionResponseModel
    {
        public ExceptionResponseModel(int Status, string Title, string Errors)
        {
            this.Status = Status;
            this.Errors = Errors;
            this.Title = Title;
        }
        public ExceptionResponseModel(string Errors)
        {
            this.Errors = Errors;
        }
        public int Status { get; set; } = 400;
        public string Title { get; set; } = "An error occured";
        public string Errors { get; set; } = "Bad Request";
    }
}
