using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AplicatieVanzariMasini_Back.Helpers
{
    public static class Extentions
    {
        public static void AddApplicationError(this HttpResponse response, string message) 
        {
            response.Headers.Add("Application-Error", message);
            response.Headers.Add("Application-Control-Expose-Headers", "Applcation-Error");
            response.Headers.Add("Application-Control-Allow-Origin", "*");
            //
        }
        public static int CalculatorAge(this DateTime theDateTime)
        {
            var age = DateTime.Today.Year - theDateTime.Year;
            if (theDateTime.AddYears(age) > DateTime.Today)
                age--;

            return age;
        }
    }
}
