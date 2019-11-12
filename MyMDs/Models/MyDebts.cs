using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyMDs.Models
{
    public class MyDebts
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MyDebtsId { get; set; }

        public int Mas_debts_Id { get; set; }

        [Range(1, 12, ErrorMessage = "The Month should be between 1 and 12")]
        public int Month { get; set; }

        [Range(2019, 2050, ErrorMessage = "The year should be between Current Year to Next Year")]
         public int Year { get; set; }

        [Required]
        [Range(1, 12, ErrorMessage = "The Number should be between 1 = First Quincenal and 2 = Second Quincenal")]
        public int Quincenal { get; set; } // 1 or 2

        [DataType(DataType.Currency)]
        public decimal DebtQuantity { get; set; }

        

    }
}
