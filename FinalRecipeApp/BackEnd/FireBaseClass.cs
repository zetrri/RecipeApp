using Firebase.Database;
using Firebase.Database.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalRecipeApp.BackEnd
{
    class FireBaseClass
    {
        
        //public async Task getfromFireBaseAsync(String addr)
        //{
        //    var firebase = new FirebaseClient(addr);
        //    var ingredients = await firebase.Child("Ingredienser").OnceAsync<ingclass>();
        //    foreach(var ing in ingredients)
        //    {
        //        Console.WriteLine(ing.Object.name);
        //        Console.WriteLine(ing.Object.unit);
        //        Console.WriteLine(ing.Object.type);
                
        //    }
            
        //}
        public async Task sendtofirebase(String addr, List<IngModel> IngredientsTotal)
        {

            var firebase = new FirebaseClient(addr);
            await firebase.Child("List").DeleteAsync();
            foreach (var ingredient in IngredientsTotal)
            {
                var newingredient = new ingclass();
                newingredient.name = ingredient.Name;
                newingredient.amount = ingredient.Antal;
                
                newingredient.type = ingredient.typ;
                newingredient.unit = ingredient.Enhet;
                await firebase.Child("List").PostAsync(newingredient);



            }
            
        }
        
    }
}
