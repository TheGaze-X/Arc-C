using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02000D9A RID: 3482
	[Token(Token = "0x2000D9A")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum AutoChessSpecialEnemyType
	{
		// Token: 0x040047C3 RID: 18371
		[Token(Token = "0x40047C3")]
		NONE,
		// Token: 0x040047C4 RID: 18372
		[Token(Token = "0x40047C4")]
		FLY,
		// Token: 0x040047C5 RID: 18373
		[Token(Token = "0x40047C5")]
		TIMES,
		// Token: 0x040047C6 RID: 18374
		[Token(Token = "0x40047C6")]
		ELEMENT,
		// Token: 0x040047C7 RID: 18375
		[Token(Token = "0x40047C7")]
		DOT,
		// Token: 0x040047C8 RID: 18376
		[Token(Token = "0x40047C8")]
		INVISIBLE,
		// Token: 0x040047C9 RID: 18377
		[Token(Token = "0x40047C9")]
		REFLECTION,
		// Token: 0x040047CA RID: 18378
		[Token(Token = "0x40047CA")]
		SPECIAL
	}
}
