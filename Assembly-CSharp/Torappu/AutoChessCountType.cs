using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02000D98 RID: 3480
	[Token(Token = "0x2000D98")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum AutoChessCountType
	{
		// Token: 0x040047B4 RID: 18356
		[Token(Token = "0x40047B4")]
		NONE,
		// Token: 0x040047B5 RID: 18357
		[Token(Token = "0x40047B5")]
		BATTLE_LAYER,
		// Token: 0x040047B6 RID: 18358
		[Token(Token = "0x40047B6")]
		COUNTING,
		// Token: 0x040047B7 RID: 18359
		[Token(Token = "0x40047B7")]
		PROFESSIONS,
		// Token: 0x040047B8 RID: 18360
		[Token(Token = "0x40047B8")]
		GROUPS,
		// Token: 0x040047B9 RID: 18361
		[Token(Token = "0x40047B9")]
		LEVEL,
		// Token: 0x040047BA RID: 18362
		[Token(Token = "0x40047BA")]
		PURCHASE
	}
}
