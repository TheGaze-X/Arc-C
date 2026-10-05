using System;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;

namespace Torappu.UI.Home.Theme
{
	// Token: 0x02004C59 RID: 19545
	[Token(Token = "0x2004C59")]
	public abstract class HomeThemeElemData
	{
		// Token: 0x0601D539 RID: 120121
		[Token(Token = "0x601D539")]
		public abstract void ParseFromJson(JObject jdata);

		// Token: 0x0601D53A RID: 120122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D53A")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected HomeThemeElemData()
		{
		}

		// Token: 0x0402696B RID: 158059
		[Token(Token = "0x402696B")]
		[FieldOffset(Offset = "0x10")]
		public string name;
	}
}
