using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace TranscribersMvc.Views.Transcribers
{
    public class IndexVM
    {
        
        [Display(Name = "Enter text in Cyrillic:")]
        [Required(ErrorMessage = "Please enter some text!")]
        public string? InputText { get; set; }

        public string? OutputText { get; set; }

        public List<string>? LanguagesList { get; set; }

		[Display(Name = "Languages")]
		[Required(ErrorMessage = "Please select a language!")]
		public string? SelectedLanguage { get; set; }

    }
}
