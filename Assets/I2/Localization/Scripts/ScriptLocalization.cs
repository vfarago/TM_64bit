// This class is Auto-Generated by the Script Tool in the Language Source
using UnityEngine;

namespace I2.Loc
{
	public static class ScriptLocalization
	{
		public static string Get( string Term ) { return Get( Term, false, 0); }
		public static string Get( string Term, bool FixForRTL ) { return Get( Term, FixForRTL, 0); }
		public static string Get( string Term, bool FixForRTL, int maxLineLengthForRTL ) { return LocalizationManager.GetTermTranslation(Term, FixForRTL, maxLineLengthForRTL); }
	}
}