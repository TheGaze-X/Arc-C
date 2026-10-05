using System;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;

namespace Torappu.UI.Home.Theme
{
	// Token: 0x02004C55 RID: 19541
	[Token(Token = "0x2004C55")]
	public class HomeThemeBlurGeneratorData : HomeThemeElemData
	{
		// Token: 0x0601D52C RID: 120108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D52C")]
		[Address(RVA = "0x16E5E90", Offset = "0x16E4A90", VA = "0x1816E5E90", Slot = "4")]
		public override void ParseFromJson(JObject jdata)
		{
		}

		// Token: 0x0601D52D RID: 120109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D52D")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public HomeThemeBlurGeneratorData()
		{
		}

		// Token: 0x04026955 RID: 158037
		[Token(Token = "0x4026955")]
		[FieldOffset(Offset = "0x18")]
		public int blurLevel;
	}
}
