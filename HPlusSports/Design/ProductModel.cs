using System;
using HPlusSports.Services;

namespace HPlusSports.Design
{
    public class ProductModel
    {
        public static Product Product
        {
            get
            {
                return new Product
                {
                    Name = "V-Neck T-Shirt",
                    Description = "Our pre-shrunk organic cotton t-shirt, with its slightly fitted waist and elegant V-neck is designed to flatter. You\u0092ll want one in every color!",
                    Id = 524,
                    Image_Title = "v-neck-t-shirt-for-women_lynda_29948",
                    Image = "https://hplussport.com/wp-content/uploads/2016/12/v-neck-T-shirt-for-women_LYNDA_29948.jpg"
                };
            }
        }
        
       

    }
}
