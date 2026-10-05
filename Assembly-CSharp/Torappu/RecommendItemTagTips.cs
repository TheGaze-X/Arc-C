using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x0200130C RID: 4876
	[Token(Token = "0x200130C")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum RecommendItemTagTips
	{
		// Token: 0x04006C10 RID: 27664
		[Token(Token = "0x4006C10")]
		ONSALE,
		// Token: 0x04006C11 RID: 27665
		[Token(Token = "0x4006C11")]
		DEADLINE,
		// Token: 0x04006C12 RID: 27666
		[Token(Token = "0x4006C12")]
		NONE
	}
}
