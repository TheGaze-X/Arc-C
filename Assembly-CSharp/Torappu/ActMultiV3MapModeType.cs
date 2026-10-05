using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02000E36 RID: 3638
	[Token(Token = "0x2000E36")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ActMultiV3MapModeType
	{
		// Token: 0x04004BAD RID: 19373
		[Token(Token = "0x4004BAD")]
		NONE,
		// Token: 0x04004BAE RID: 19374
		[Token(Token = "0x4004BAE")]
		NORMAL,
		// Token: 0x04004BAF RID: 19375
		[Token(Token = "0x4004BAF")]
		FOOTBALL,
		// Token: 0x04004BB0 RID: 19376
		[Token(Token = "0x4004BB0")]
		DEFENCE,
		// Token: 0x04004BB1 RID: 19377
		[Token(Token = "0x4004BB1")]
		RAFT
	}
}
