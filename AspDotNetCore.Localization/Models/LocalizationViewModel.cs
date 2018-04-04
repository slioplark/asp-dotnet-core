using System.ComponentModel.DataAnnotations;

namespace AspDotNetCore.Localization.Models
{
    public class LocalizationViewModel
    {
        [Display(Name = "Language")]
        public string Language { get; set; }
        [Display(Name = "Translation")]
        public string Translation { get; set; }
        [Display(Name = "One")]
        public string One { get; set; }
        [Display(Name = "Two")]
        public string Two { get; set; }
        [Display(Name = "Three")]
        public string Three { get; set; }
        [Display(Name = "Four")]
        public string Four { get; set; }
        [Display(Name = "Five")]
        public string Five { get; set; }
        [Display(Name = "Six")]
        public string Six { get; set; }
        [Display(Name = "Seven")]
        public string Seven { get; set; }
        [Display(Name = "Eight")]
        public string Eight { get; set; }
        [Display(Name = "Nine")]
        public string Nine { get; set; }
        [Display(Name = "Ten")]
        public string Ten { get; set; }
    }
}
