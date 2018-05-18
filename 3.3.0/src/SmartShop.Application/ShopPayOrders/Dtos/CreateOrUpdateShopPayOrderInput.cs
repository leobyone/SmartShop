using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using SmartShop.Entities;

namespace SmartShop.ShopPayOrders.Dtos
{
    public class CreateOrUpdateShopPayOrderInput
{
////BCC/ BEGIN CUSTOM CODE SECTION
////ECC/ END CUSTOM CODE SECTION
        [Required]
        public ShopPayOrderEditDto ShopPayOrder { get; set; }

}
}