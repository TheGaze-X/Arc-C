using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x0200086B RID: 2155
	[Token(Token = "0x200086B")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ShopQCGoodType
	{
		// Token: 0x040031B4 RID: 12724
		[Token(Token = "0x40031B4")]
		NORMAL,
		// Token: 0x040031B5 RID: 12725
		[Token(Token = "0x40031B5")]
		PROGRESS
	}
}
