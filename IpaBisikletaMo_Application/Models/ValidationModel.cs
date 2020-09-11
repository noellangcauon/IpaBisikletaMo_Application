using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IpaBisikletaMo_Application.Models
{
    public class ValidationModel
    {
        public static List<string> Errors(ICollection<ModelState> errors)
        {
            var errorList = new List<string>();

            foreach (ModelState modelState in errors)
            {
                foreach (ModelError error in modelState.Errors)
                {
                    errorList.Add(error.ErrorMessage);
                }
            }

            return errorList;
        }
    }
}