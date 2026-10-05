using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02001304 RID: 4868
	[Token(Token = "0x2001304")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ShopUnlockType
	{
		// Token: 0x04006BD3 RID: 27603
		[Token(Token = "0x4006BD3")]
		ALWAYS_UNLOCK,
		// Token: 0x04006BD4 RID: 27604
		[Token(Token = "0x4006BD4")]
		SKIN_UNLOCK,
		// Token: 0x04006BD5 RID: 27605
		[Token(Token = "0x4006BD5")]
		FURN_UNLOCK,
		// Token: 0x04006BD6 RID: 27606
		[Token(Token = "0x4006BD6")]
		BOTH_SKIN_FURN
	}
}
