using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02001369 RID: 4969
	[Token(Token = "0x2001369")]
	[JsonConverter(typeof(StringEnumConverter))]
	[Serializable]
	public enum OverrideGameMode
	{
		// Token: 0x04006E31 RID: 28209
		[Token(Token = "0x4006E31")]
		NONE,
		// Token: 0x04006E32 RID: 28210
		[Token(Token = "0x4006E32")]
		ACT27SIDE
	}
}
