using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Interfaces;

namespace BusinessLayer.Classes
{
    public class VanillaIceCream : IIngredients
    {
        public string AddIngredients()
        {
            return "\n Add 1 Scoop of Vanilla Ice cream";
        }
    }
}
