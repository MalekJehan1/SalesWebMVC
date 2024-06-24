using System.Collections.Generic;


namespace SalesWebMVCx.Models.ViewModels
{
    public class SellerFormViewModel
    {
        public Seller Seller { get; set; }
        public ICollection<Departament> Departaments { get; set; }


    }
}
