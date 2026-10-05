using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02000D9E RID: 3486
	[Token(Token = "0x2000D9E")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ActAutoChessModeDifficultyType
	{
		// Token: 0x040047D8 RID: 18392
		[Token(Token = "0x40047D8")]
		NONE = -1,
		// Token: 0x040047D9 RID: 18393
		[Token(Token = "0x40047D9")]
		TRAINING,
		// Token: 0x040047DA RID: 18394
		[Token(Token = "0x40047DA")]
		FUNNY,
		// Token: 0x040047DB RID: 18395
		[Token(Token = "0x40047DB")]
		NORMAL,
		// Token: 0x040047DC RID: 18396
		[Token(Token = "0x40047DC")]
		HARD,
		// Token: 0x040047DD RID: 18397
		[Token(Token = "0x40047DD")]
		ABYSS
	}
}
