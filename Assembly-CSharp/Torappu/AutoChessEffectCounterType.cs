using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02000D99 RID: 3481
	[Token(Token = "0x2000D99")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum AutoChessEffectCounterType
	{
		// Token: 0x040047BC RID: 18364
		[Token(Token = "0x40047BC")]
		NONE,
		// Token: 0x040047BD RID: 18365
		[Token(Token = "0x40047BD")]
		TURN_COUNT,
		// Token: 0x040047BE RID: 18366
		[Token(Token = "0x40047BE")]
		TRIGGER_COUNT,
		// Token: 0x040047BF RID: 18367
		[Token(Token = "0x40047BF")]
		CHAR_COUNT,
		// Token: 0x040047C0 RID: 18368
		[Token(Token = "0x40047C0")]
		STACK_COUNT,
		// Token: 0x040047C1 RID: 18369
		[Token(Token = "0x40047C1")]
		COIN_JAR
	}
}
