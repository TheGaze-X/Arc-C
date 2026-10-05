using System;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;

namespace Torappu.UI.Home.Theme
{
	// Token: 0x02004C5D RID: 19549
	[Token(Token = "0x2004C5D")]
	public class HomeThemeGraphicData : HomeThemeUIElemData
	{
		// Token: 0x0601D554 RID: 120148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D554")]
		[Address(RVA = "0x16E69E0", Offset = "0x16E55E0", VA = "0x1816E69E0", Slot = "5")]
		protected override void OnParseFromJson(JObject jdata)
		{
		}

		// Token: 0x0601D555 RID: 120149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D555")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public HomeThemeGraphicData()
		{
		}

		// Token: 0x0402697A RID: 158074
		[Token(Token = "0x402697A")]
		[FieldOffset(Offset = "0x28")]
		public string clr;
	}
}
