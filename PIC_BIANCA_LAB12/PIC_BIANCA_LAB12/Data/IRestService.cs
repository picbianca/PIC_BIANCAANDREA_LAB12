using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using PIC_BIANCA_LAB12.Models;

namespace PIC_BIANCA_LAB12.Data
{
    public interface IRestService
    {
     
            Task<List<ShopList>> RefreshDataAsync();
            Task SaveShopListAsync(ShopList item, bool isNewItem);
            Task DeleteShopListAsync(int id);
        
    }
}
