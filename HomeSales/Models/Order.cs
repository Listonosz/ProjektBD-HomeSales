using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace HomeSales.Models
{
    public class Order
    {
        [BindNever]
        public int OrderId { get; set; }
        [Required(ErrorMessage="Please enter name")]
        [Display(Name = "First Name")]
        [StringLength(50)]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Please enter lastname")]
        [Display(Name = "Last Name")]
        [StringLength(50)]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Please enter correct adress")]
        [Display(Name = "Street Address")]
        [StringLength(50)]
        public string Address { get; set; }
        [Required(ErrorMessage = "Please enter city")]
        [Display(Name = "City")]
        [StringLength(50)]
        public string City { get; set; }
        [Required(ErrorMessage = "Please enter zip-code")]
        [Display(Name = "Zip-Code")]
        //TODO: Add REGEX validation
        public string ZipCode { get; set; }
        [Required(ErrorMessage = "Please enter phonenumber")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber {get; set;}

        public List<OrderDetail> OrderdDetails { get; set; }
        [BindNever]
        public decimal OrderTotal { get; set; }
        [BindNever]
        public DateTime OrderPlaced { get; set; }

        public string OwnerID { get; set; }
    }
}
