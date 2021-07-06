using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalRecipeApp.BackEnd
{
    public class RecipeModel
    {
        public string Name { get; set; }

        public int portioner { get; set; }

        public string tagg { get; set; }

        public List<IngModel> ingrediens { get; set; }
    }
}
