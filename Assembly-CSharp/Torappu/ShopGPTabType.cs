using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x0200131C RID: 4892
	[Token(Token = "0x200131C")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ShopGPTabType
	{
		// Token: 0x04006C62 RID: 27746
		[Token(Token = "0x4006C62")]
		DEFAULT_ALL,
		// Token: 0x04006C63 RID: 27747
		[Token(Token = "0x4006C63")]
		MONTH_CARD,
		// Token: 0x04006C64 RID: 27748
		[Token(Token = "0x4006C64")]
		PERM,
		// Token: 0x04006C65 RID: 27749
		[Token(Token = "0x4006C65")]
		NEWBIE,
		// Token: 0x04006C66 RID: 27750
		[Token(Token = "0x4006C66")]
		RETURN,
		// Token: 0x04006C67 RID: 27751
		[Token(Token = "0x4006C67")]
		RECOMMOND,
		// Token: 0x04006C68 RID: 27752
		[Token(Token = "0x4006C68")]
		TIMELY
	}
}
