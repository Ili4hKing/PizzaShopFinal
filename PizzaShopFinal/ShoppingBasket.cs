//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PizzaShopFinal
{
    using System;
    using System.Collections.Generic;
    
    public partial class ShoppingBasket
    {
        public int id { get; set; }
        public string Pizza { get; set; }
        public string Size { get; set; }
        public string Dough { get; set; }
        public string Cost { get; set; }
    
        public virtual MenuPizza MenuPizza { get; set; }
        public virtual SizePizza SizePizza { get; set; }
        public virtual typeDoughPizza typeDoughPizza { get; set; }
    }
}
