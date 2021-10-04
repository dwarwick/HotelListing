using System;
using System.ComponentModel.DataAnnotations;

namespace HotelListing.Model
{
    public class CreateHotelDTO
    {
        [Required]
        [StringLength(maximumLength: 50, ErrorMessage = "Hotel name cannot be longer than 50 characters.")]
        public string Name { get; set; }
        [StringLength(maximumLength: 50, ErrorMessage = "Hotel address cannot be longer than 150 characters.")]
        [Required]
        public string Address { get; set; }
        [Range(1,5)]
        [Required]
        public double Rating { get; set; }

        [Required]
        public int CountryId { get; set; }        
    }

    public class HotelDTO : CreateHotelDTO
    {
        public int Id { get; set; }
        public CreateCountryDTO Country { get; set; }
        
    }
}
