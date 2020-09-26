using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ProductManager.Models
{
    public class Product
    {
        public string Id { get; set; }

        [JsonPropertyName("img")] /*Khi muốn chuyển sang ánh xạ kiểu khác theo project của mình, chỉ về thư mục gốc */
        public string Image { get; set; }

        public string Name { get; set; }

        public float Price { get; set; }

        public override string ToString() => JsonSerializer.Serialize<Product>(this);
    }
}
