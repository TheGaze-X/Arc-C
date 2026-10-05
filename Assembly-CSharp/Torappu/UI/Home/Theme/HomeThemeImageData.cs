using System;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;

namespace Torappu.UI.Home.Theme
{
	// Token: 0x02004C5F RID: 19551
	[Token(Token = "0x2004C5F")]
	public class HomeThemeImageData : HomeThemeUIElemData
	{
		// Token: 0x0601D559 RID: 120153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D559")]
		[Address(RVA = "0x16E6D40", Offset = "0x16E5940", VA = "0x1816E6D40", Slot = "5")]
		protected override void OnParseFromJson(JObject jdata)
		{
		}

		// Token: 0x0601D55A RID: 120154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D55A")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public HomeThemeImageData()
		{
		}

		// Token: 0x0402697F RID: 158079
		[Token(Token = "0x402697F")]
		[FieldOffset(Offset = "0x28")]
		public string spritePath;

		// Token: 0x04026980 RID: 158080
		[Token(Token = "0x4026980")]
		[FieldOffset(Offset = "0x30")]
		public string matPath;

		// Token: 0x04026981 RID: 158081
		[Token(Token = "0x4026981")]
		[FieldOffset(Offset = "0x38")]
		public string clr;
	}
}
