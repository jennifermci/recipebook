using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace RecipeBook.Models
{
    public class MainWrapper
    {
        public RegisterUser RegisterUser {get;set;}
        public List<Recipe> RecipeList { get; set; }
        
    }
}