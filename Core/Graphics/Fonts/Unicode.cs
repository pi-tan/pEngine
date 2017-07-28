﻿using System.Collections.Generic;

namespace pEngine.Core.Graphics.Fonts
{
	public class Charset
	{
		public static KeyValuePair<int, int> ControlCharacters = new KeyValuePair<int, int>(0x0000, 0x001F);
		public static KeyValuePair<int, int> BasicLatin = new KeyValuePair<int, int>(0x0020, 0x007F);
		public static KeyValuePair<int, int> BlockElements = new KeyValuePair<int, int>(0x2580, 0x259F);
		public static KeyValuePair<int, int> Latin1Supplement = new KeyValuePair<int, int>(0x00A0, 0x00FF);
		public static KeyValuePair<int, int> GeometricShapes = new KeyValuePair<int, int>(0x25A0, 0x25FF);
		public static KeyValuePair<int, int> LatinExtendedA = new KeyValuePair<int, int>(0x0100, 0x017F);
		public static KeyValuePair<int, int> MiscellaneousSymbols = new KeyValuePair<int, int>(0x2600, 0x26FF);
		public static KeyValuePair<int, int> LatinExtendedB = new KeyValuePair<int, int>(0x0180, 0x024F);
		public static KeyValuePair<int, int> Dingbats = new KeyValuePair<int, int>(0x2700, 0x27BF);
		public static KeyValuePair<int, int> IPAExtensions = new KeyValuePair<int, int>(0x0250, 0x02AF);
		public static KeyValuePair<int, int> MiscellaneousMathematicalSymbolsA = new KeyValuePair<int, int>(0x27C0, 0x27EF);
		public static KeyValuePair<int, int> SpacingModifierLetters = new KeyValuePair<int, int>(0x02B0, 0x02FF);
		public static KeyValuePair<int, int> SupplementalArrowsA = new KeyValuePair<int, int>(0x27F0, 0x27FF);
		public static KeyValuePair<int, int> CombiningDiacriticalMarks = new KeyValuePair<int, int>(0x0300, 0x036F);
		public static KeyValuePair<int, int> BraillePatterns = new KeyValuePair<int, int>(0x2800, 0x28FF);
		public static KeyValuePair<int, int> GreekandCoptic = new KeyValuePair<int, int>(0x0370, 0x03FF);
		public static KeyValuePair<int, int> SupplementalArrowsB = new KeyValuePair<int, int>(0x2900, 0x297F);
		public static KeyValuePair<int, int> Cyrillic = new KeyValuePair<int, int>(0x0400, 0x04FF);
		public static KeyValuePair<int, int> MiscellaneousMathematicalSymbolsB = new KeyValuePair<int, int>(0x2980, 0x29FF);
		public static KeyValuePair<int, int> CyrillicSupplementary = new KeyValuePair<int, int>(0x0500, 0x052F);
		public static KeyValuePair<int, int> SupplementalMathematicalOperators = new KeyValuePair<int, int>(0x2A00, 0x2AFF);
		public static KeyValuePair<int, int> Armenian = new KeyValuePair<int, int>(0x0530, 0x058F);
		public static KeyValuePair<int, int> MiscellaneousSymbolsandArrows = new KeyValuePair<int, int>(0x2B00, 0x2BFF);
		public static KeyValuePair<int, int> Hebrew = new KeyValuePair<int, int>(0x0590, 0x05FF);
		public static KeyValuePair<int, int> CJKRadicalsSupplement = new KeyValuePair<int, int>(0x2E80, 0x2EFF);
		public static KeyValuePair<int, int> Arabic = new KeyValuePair<int, int>(0x0600, 0x06FF);
		public static KeyValuePair<int, int> KangxiRadicals = new KeyValuePair<int, int>(0x2F00, 0x2FDF);
		public static KeyValuePair<int, int> Syriac = new KeyValuePair<int, int>(0x0700, 0x074F);
		public static KeyValuePair<int, int> IdeographicDescriptionCharacters = new KeyValuePair<int, int>(0x2FF0, 0x2FFF);
		public static KeyValuePair<int, int> Thaana = new KeyValuePair<int, int>(0x0780, 0x07BF);
		public static KeyValuePair<int, int> CJKSymbolsandPunctuation = new KeyValuePair<int, int>(0x3000, 0x303F);
		public static KeyValuePair<int, int> Devanagari = new KeyValuePair<int, int>(0x0900, 0x097F);
		public static KeyValuePair<int, int> Hiragana = new KeyValuePair<int, int>(0x3040, 0x309F);
		public static KeyValuePair<int, int> Bengali = new KeyValuePair<int, int>(0x0980, 0x09FF);
		public static KeyValuePair<int, int> Katakana = new KeyValuePair<int, int>(0x30A0, 0x30FF);
		public static KeyValuePair<int, int> Gurmukhi = new KeyValuePair<int, int>(0x0A00, 0x0A7F);
		public static KeyValuePair<int, int> Bopomofo = new KeyValuePair<int, int>(0x3100, 0x312F);
		public static KeyValuePair<int, int> Gujarati = new KeyValuePair<int, int>(0x0A80, 0x0AFF);
		public static KeyValuePair<int, int> HangulCompatibilityJamo = new KeyValuePair<int, int>(0x3130, 0x318F);
		public static KeyValuePair<int, int> Oriya = new KeyValuePair<int, int>(0x0B00, 0x0B7F);
		public static KeyValuePair<int, int> Kanbun = new KeyValuePair<int, int>(0x3190, 0x319F);
		public static KeyValuePair<int, int> Tamil = new KeyValuePair<int, int>(0x0B80, 0x0BFF);
		public static KeyValuePair<int, int> BopomofoExtended = new KeyValuePair<int, int>(0x31A0, 0x31BF);
		public static KeyValuePair<int, int> Telugu = new KeyValuePair<int, int>(0x0C00, 0x0C7F);
		public static KeyValuePair<int, int> KatakanaPhoneticExtensions = new KeyValuePair<int, int>(0x31F0, 0x31FF);
		public static KeyValuePair<int, int> Kannada = new KeyValuePair<int, int>(0x0C80, 0x0CFF);
		public static KeyValuePair<int, int> EnclosedCJKLettersandMonths = new KeyValuePair<int, int>(0x3200, 0x32FF);
		public static KeyValuePair<int, int> Malayalam = new KeyValuePair<int, int>(0x0D00, 0x0D7F);
		public static KeyValuePair<int, int> CJKCompatibility = new KeyValuePair<int, int>(0x3300, 0x33FF);
		public static KeyValuePair<int, int> Sinhala = new KeyValuePair<int, int>(0x0D80, 0x0DFF);
		public static KeyValuePair<int, int> CJKUnifiedIdeographsExtensionA = new KeyValuePair<int, int>(0x3400, 0x4DBF);
		public static KeyValuePair<int, int> Thai = new KeyValuePair<int, int>(0x0E00, 0x0E7F);
		public static KeyValuePair<int, int> YijingHexagramSymbols = new KeyValuePair<int, int>(0x4DC0, 0x4DFF);
		public static KeyValuePair<int, int> Lao = new KeyValuePair<int, int>(0x0E80, 0x0EFF);
		public static KeyValuePair<int, int> CJKUnifiedIdeographs = new KeyValuePair<int, int>(0x4E00, 0x9FFF);
		public static KeyValuePair<int, int> Tibetan = new KeyValuePair<int, int>(0x0F00, 0x0FFF);
		public static KeyValuePair<int, int> YiSyllables = new KeyValuePair<int, int>(0xA000, 0xA48F);
		public static KeyValuePair<int, int> Myanmar = new KeyValuePair<int, int>(0x1000, 0x109F);
		public static KeyValuePair<int, int> YiRadicals = new KeyValuePair<int, int>(0xA490, 0xA4CF);
		public static KeyValuePair<int, int> Georgian = new KeyValuePair<int, int>(0x10A0, 0x10FF);
		public static KeyValuePair<int, int> HangulSyllables = new KeyValuePair<int, int>(0xAC00, 0xD7AF);
		public static KeyValuePair<int, int> HangulJamo = new KeyValuePair<int, int>(0x1100, 0x11FF);
		public static KeyValuePair<int, int> HighSurrogates = new KeyValuePair<int, int>(0xD800, 0xDB7F);
		public static KeyValuePair<int, int> Ethiopic = new KeyValuePair<int, int>(0x1200, 0x137F);
		public static KeyValuePair<int, int> HighPrivateUseSurrogates = new KeyValuePair<int, int>(0xDB80, 0xDBFF);
		public static KeyValuePair<int, int> Cherokee = new KeyValuePair<int, int>(0x13A0, 0x13FF);
		public static KeyValuePair<int, int> LowSurrogates = new KeyValuePair<int, int>(0xDC00, 0xDFFF);
		public static KeyValuePair<int, int> UnifiedCanadianAboriginalSyllabics = new KeyValuePair<int, int>(0x1400, 0x167F);
		public static KeyValuePair<int, int> PrivateUseArea = new KeyValuePair<int, int>(0xE000, 0xF8FF);
		public static KeyValuePair<int, int> Ogham = new KeyValuePair<int, int>(0x1680, 0x169F);
		public static KeyValuePair<int, int> CJKCompatibilityIdeographs = new KeyValuePair<int, int>(0xF900, 0xFAFF);
		public static KeyValuePair<int, int> Runic = new KeyValuePair<int, int>(0x16A0, 0x16FF);
		public static KeyValuePair<int, int> AlphabeticPresentationForms = new KeyValuePair<int, int>(0xFB00, 0xFB4F);
		public static KeyValuePair<int, int> Tagalog = new KeyValuePair<int, int>(0x1700, 0x171F);
		public static KeyValuePair<int, int> ArabicPresentationFormsA = new KeyValuePair<int, int>(0xFB50, 0xFDFF);
		public static KeyValuePair<int, int> Hanunoo = new KeyValuePair<int, int>(0x1720, 0x173F);
		public static KeyValuePair<int, int> VariationSelectors = new KeyValuePair<int, int>(0xFE00, 0xFE0F);
		public static KeyValuePair<int, int> Buhid = new KeyValuePair<int, int>(0x1740, 0x175F);
		public static KeyValuePair<int, int> CombiningHalfMarks = new KeyValuePair<int, int>(0xFE20, 0xFE2F);
		public static KeyValuePair<int, int> Tagbanwa = new KeyValuePair<int, int>(0x1760, 0x177F);
		public static KeyValuePair<int, int> CJKCompatibilityForms = new KeyValuePair<int, int>(0xFE30, 0xFE4F);
		public static KeyValuePair<int, int> Khmer = new KeyValuePair<int, int>(0x1780, 0x17FF);
		public static KeyValuePair<int, int> SmallFormVariants = new KeyValuePair<int, int>(0xFE50, 0xFE6F);
		public static KeyValuePair<int, int> Mongolian = new KeyValuePair<int, int>(0x1800, 0x18AF);
		public static KeyValuePair<int, int> ArabicPresentationFormsB = new KeyValuePair<int, int>(0xFE70, 0xFEFF);
		public static KeyValuePair<int, int> Limbu = new KeyValuePair<int, int>(0x1900, 0x194F);
		public static KeyValuePair<int, int> HalfwidthandFullwidthForms = new KeyValuePair<int, int>(0xFF00, 0xFFEF);
		public static KeyValuePair<int, int> TaiLe = new KeyValuePair<int, int>(0x1950, 0x197F);
		public static KeyValuePair<int, int> Specials = new KeyValuePair<int, int>(0xFFF0, 0xFFFF);
		public static KeyValuePair<int, int> KhmerSymbols = new KeyValuePair<int, int>(0x19E0, 0x19FF);
		public static KeyValuePair<int, int> LinearBSyllabary = new KeyValuePair<int, int>(0x10000, 0x1007F);
		public static KeyValuePair<int, int> PhoneticExtensions = new KeyValuePair<int, int>(0x1D00, 0x1D7F);
		public static KeyValuePair<int, int> LinearBIdeograms = new KeyValuePair<int, int>(0x10080, 0x100FF);
		public static KeyValuePair<int, int> LatinExtendedAdditional = new KeyValuePair<int, int>(0x1E00, 0x1EFF);
		public static KeyValuePair<int, int> AegeanNumbers = new KeyValuePair<int, int>(0x10100, 0x1013F);
		public static KeyValuePair<int, int> GreekExtended = new KeyValuePair<int, int>(0x1F00, 0x1FFF);
		public static KeyValuePair<int, int> OldItalic = new KeyValuePair<int, int>(0x10300, 0x1032F);
		public static KeyValuePair<int, int> GeneralPunctuation = new KeyValuePair<int, int>(0x2000, 0x206F);
		public static KeyValuePair<int, int> Gothic = new KeyValuePair<int, int>(0x10330, 0x1034F);
		public static KeyValuePair<int, int> SuperscriptsandSubscripts = new KeyValuePair<int, int>(0x2070, 0x209F);
		public static KeyValuePair<int, int> Ugaritic = new KeyValuePair<int, int>(0x10380, 0x1039F);
		public static KeyValuePair<int, int> CurrencySymbols = new KeyValuePair<int, int>(0x20A0, 0x20CF);
		public static KeyValuePair<int, int> Deseret = new KeyValuePair<int, int>(0x10400, 0x1044F);
		public static KeyValuePair<int, int> CombiningDiacriticalMarksforSymbols = new KeyValuePair<int, int>(0x20D0, 0x20FF);
		public static KeyValuePair<int, int> Shavian = new KeyValuePair<int, int>(0x10450, 0x1047F);
		public static KeyValuePair<int, int> LetterlikeSymbols = new KeyValuePair<int, int>(0x2100, 0x214F);
		public static KeyValuePair<int, int> Osmanya = new KeyValuePair<int, int>(0x10480, 0x104AF);
		public static KeyValuePair<int, int> NumberForms = new KeyValuePair<int, int>(0x2150, 0x218F);
		public static KeyValuePair<int, int> CypriotSyllabary = new KeyValuePair<int, int>(0x10800, 0x1083F);
		public static KeyValuePair<int, int> Arrows = new KeyValuePair<int, int>(0x2190, 0x21FF);
		public static KeyValuePair<int, int> ByzantineMusicalSymbols = new KeyValuePair<int, int>(0x1D000, 0x1D0FF);
		public static KeyValuePair<int, int> MathematicalOperators = new KeyValuePair<int, int>(0x2200, 0x22FF);
		public static KeyValuePair<int, int> MusicalSymbols = new KeyValuePair<int, int>(0x1D100, 0x1D1FF);
		public static KeyValuePair<int, int> MiscellaneousTechnical = new KeyValuePair<int, int>(0x2300, 0x23FF);
		public static KeyValuePair<int, int> TaiXuanJingSymbols = new KeyValuePair<int, int>(0x1D300, 0x1D35F);
		public static KeyValuePair<int, int> ControlPictures = new KeyValuePair<int, int>(0x2400, 0x243F);
		public static KeyValuePair<int, int> MathematicalAlphanumericSymbols = new KeyValuePair<int, int>(0x1D400, 0x1D7FF);
		public static KeyValuePair<int, int> OpticalCharacterRecognition = new KeyValuePair<int, int>(0x2440, 0x245F);
		public static KeyValuePair<int, int> CJKUnifiedIdeographsExtensionB = new KeyValuePair<int, int>(0x20000, 0x2A6DF);
		public static KeyValuePair<int, int> EnclosedAlphanumerics = new KeyValuePair<int, int>(0x2460, 0x24FF);
		public static KeyValuePair<int, int> CJKCompatibilityIdeographsSupplement = new KeyValuePair<int, int>(0x2F800, 0x2FA1F);
		public static KeyValuePair<int, int> BoxDrawing = new KeyValuePair<int, int>(0x2500, 0x257F);
		public static KeyValuePair<int, int> Tags = new KeyValuePair<int, int>(0xE0000, 0xE007F);
		public static KeyValuePair<int, int> All = new KeyValuePair<int, int>(0x0020, 0xE007F);
	}

}