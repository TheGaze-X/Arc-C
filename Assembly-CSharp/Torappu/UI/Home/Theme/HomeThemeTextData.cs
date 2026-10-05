using System;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;

namespace Torappu.UI.Home.Theme
{
	// Token: 0x02004C67 RID: 19559
	[Token(Token = "0x2004C67")]
	public class HomeThemeTextData : HomeThemeUIElemData
	{
		// Token: 0x0601D573 RID: 120179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D573")]
		[Address(RVA = "0x16E89C0", Offset = "0x16E75C0", VA = "0x1816E89C0", Slot = "5")]
		protected override void OnParseFromJson(JObject jdata)
		{
		}

		// Token: 0x0601D574 RID: 120180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D574")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public HomeThemeTextData()
		{
		}

		// Token: 0x040269A2 RID: 158114
		[Token(Token = "0x40269A2")]
		[FieldOffset(Offset = "0x28")]
		public string clr;

		// Token: 0x040269A3 RID: 158115
		[Token(Token = "0x40269A3")]
		[FieldOffset(Offset = "0x30")]
		public int fontSize;
	}
}
