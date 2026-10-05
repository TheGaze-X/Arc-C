using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace YoStar.SDK.Util
{
	// Token: 0x0200009B RID: 155
	[Token(Token = "0x200009B")]
	public class LocalizationUtils
	{
		// Token: 0x06000445 RID: 1093 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000445")]
		[Address(RVA = "0x5C0AF30", Offset = "0x5C09B30", VA = "0x185C0AF30")]
		public static void LoadLocalizationData()
		{
		}

		// Token: 0x06000446 RID: 1094 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000446")]
		[Address(RVA = "0x5C0AD70", Offset = "0x5C09970", VA = "0x185C0AD70")]
		public static string GetLocalizedString(string key)
		{
			return null;
		}

		// Token: 0x06000447 RID: 1095 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000447")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public LocalizationUtils()
		{
		}

		// Token: 0x0400026A RID: 618
		[Token(Token = "0x400026A")]
		[FieldOffset(Offset = "0x0")]
		public static string currentLanguage;

		// Token: 0x0400026B RID: 619
		[Token(Token = "0x400026B")]
		[FieldOffset(Offset = "0x8")]
		private static Dictionary<string, string> localizedData;
	}
}
