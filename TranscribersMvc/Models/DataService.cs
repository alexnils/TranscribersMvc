using System.Reflection;
using TranscribersMvc.Views.Transcribers;

namespace TranscribersMvc.Models
{
	public class DataService




	{
		static Dictionary<char, string> TajikDictionary = new Dictionary<char, string>() {
				{ 'А', "A" },
				{ 'а', "a" },
				{ 'Б', "B" },
				{ 'б', "b" },
				{ 'В', "V" },
				{ 'в', "v" },
				{ 'Г', "G" },
				{ 'г', "g" },
				{ 'Ғ', "Ġ" },
				{ 'ғ', "ġ" },
				{ 'Д', "D" },
				{ 'д', "d" },
				{ 'Е', "E" },
				{ 'е', "e" },
				{ 'Ё', "Yo" },
				{ 'ё', "yo" },
				{ 'Ж', "Ž" },
				{ 'ж', "ž" },
				{ 'З', "Z" },
				{ 'з', "z" },
				{ 'И', "I" },
				{ 'и', "i" },
				{ 'Ӣ', "Ī" },
				{ 'ӣ', "ī" },
				{ 'Й', "Y" },
				{ 'й', "y" },
				{ 'К', "K" },
				{ 'к', "k" },
				{ 'Қ', "Q" },
				{ 'қ', "q" },
				{ 'Л', "L" },
				{ 'л', "l" },
				{ 'М', "M" },
				{ 'м', "m" },
				{ 'Н', "N" },
				{ 'н', "n" },
				{'О', "O" },
				{'о', "o" },
				{'П', "P"},
				{'п', "p"},
				{'Р', "R"},
				{'р', "r"},
				{'С', "S"},
				{'с', "s"},
				{'Т', "T"},
				{'т', "t"},
				{'У', "U"},
				{'у', "u"},
				{'Ӯ', "Ū"},
				{'ӯ', "ū"},
				{'Ф', "F" },
				{'ф',"f" },
				{'Х',"X" },
				{'х',"x" },
				{'Ҳ',"H" },
				{'ҳ',"h" },
				{'Ч',"Č" },
				{'ч', "č" },
				{'Ҷ', "J" },
				{'ҷ', "j" },
				{'Ш', "Š" },
				{'ш', "š" },
				{'Ъ', "’" },
				{'ъ', "’" },
				{'Э', "E" },
				{'э', "e" },
				{'Ю', "Yu" },
				{'ю', "yu" },
				{'Я', "Ya" },
				{'я', "ya" },
			};


		static Dictionary<char, string> UzbekDictionary = new Dictionary<char, string>() {
				{ 'А', "A" },
				{ 'а', "a" },
				{ 'Б', "B" },
				{ 'б', "b" },
				{ 'В', "V" },
				{ 'в', "v" },
				{ 'Г', "G" },
				{ 'г', "g" },
				{ 'Ғ', "Gʻ" },
				{ 'ғ', "gʻ" },
				{ 'Д', "D" },
				{ 'д', "d" },
				{ 'Е', "E" },
				{ 'е', "e" },
				{ 'Ё', "Yo" },
				{ 'ё', "yo" },
				{ 'Ж', "J" },
				{ 'ж', "j" },
				{ 'З', "Z" },
				{ 'з', "z" },
				{ 'И', "I" },
				{ 'и', "i" },
				{ 'Й', "Y" },
				{ 'й', "y" },
				{ 'К', "K" },
				{ 'к', "k" },
				{ 'Қ', "Q" },
				{ 'қ', "q" },
				{ 'Л', "L" },
				{ 'л', "l" },
				{ 'М', "M" },
				{ 'м', "m" },
				{ 'Н', "N" },
				{ 'н', "n" },
				{'О', "O" },
				{'о', "o" },
				{'П', "P"},
				{'п', "p"},
				{'Р', "R"},
				{'р', "r"},
				{'С', "S"},
				{'с', "s"},
				{'Т', "T"},
				{'т', "t"},
				{'У', "U"},
				{'у', "u"},
				{'Ў', "Oʻ"},
				{'ў', "oʻ"},
				{'Ф', "F" },
				{'ф',"f" },
				{'Х',"X" },
				{'х',"x" },
				{'Ҳ',"H" },
				{'ҳ',"h" },
				{'Ч',"Ch" },
				{'ч', "ch" },
				{'Ш', "Sh" },
				{'ш', "sh" },
				{'Ъ', "’" },
				{'ъ', "’" },
				{'Э', "E" },
				{'э', "e" },
				{'Ю', "Yu" },
				{'ю', "yu" },
				{'Я', "Ya" },
				{'я', "ya" },
			};

		static List<string> list = new List<string>() { "Tajik", "Uzbek" };
		internal IndexVM GetTranscriber()
		{
			IndexVM transcriber = new IndexVM();

			transcriber.LanguagesList = list;



			return transcriber;
		}

		internal IndexVM TranscribeText(IndexVM model)
		{


			if (model.InputText != null)
			{
				string text = "";
				var dic = model.SelectedLanguage == "Tajik" ? TajikDictionary : UzbekDictionary;
				foreach (var character in model.InputText)
				{
					if (dic.ContainsKey(character))
					{
						text += dic[character];
					}
					else
					{
						text += character;
					}
				}



				model.OutputText = text.ToString();
			}


			model.LanguagesList = list;
			return model;

		}
	}
}
