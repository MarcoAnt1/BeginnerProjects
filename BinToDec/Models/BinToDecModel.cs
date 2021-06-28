using System.ComponentModel.DataAnnotations;

namespace BinToDec.Models
{
    public class BinToDecModel
    {
        public int Decimal { get; set; }

        [Required]
        [RegularExpression(@"^[0-1]*$")]
        [MaxLength(8)]
        public int Binary { get; set; }
    }
}
