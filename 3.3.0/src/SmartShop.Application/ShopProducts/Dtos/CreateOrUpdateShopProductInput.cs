using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using SmartShop.Entities;

namespace SmartShop.ShopProducts.Dtos
{
    public class CreateOrUpdateShopProductInput
{
////BCC/ BEGIN CUSTOM CODE SECTION
////ECC/ END CUSTOM CODE SECTION
        [Required]
        public ShopProductEditDto ShopProduct { get; set; }

}
}