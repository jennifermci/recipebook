using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace RecipeBook.Models
{
    public class UserPageWrapper
    {
        public RegisterUser RegisterUser {get;set;}
        public List<Recipe> MyRecipes { get; set; }
        
    }
}