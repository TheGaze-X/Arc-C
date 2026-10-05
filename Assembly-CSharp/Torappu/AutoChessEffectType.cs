using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02000D93 RID: 3475
	[Token(Token = "0x2000D93")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum AutoChessEffectType
	{
		// Token: 0x0400478D RID: 18317
		[Token(Token = "0x400478D")]
		NONE,
		// Token: 0x0400478E RID: 18318
		[Token(Token = "0x400478E")]
		BAND_INITIAL,
		// Token: 0x0400478F RID: 18319
		[Token(Token = "0x400478F")]
		ENEMY,
		// Token: 0x04004790 RID: 18320
		[Token(Token = "0x4004790")]
		ENEMY_TEMPORARY,
		// Token: 0x04004791 RID: 18321
		[Token(Token = "0x4004791")]
		ALLY,
		// Token: 0x04004792 RID: 18322
		[Token(Token = "0x4004792")]
		EQUIP,
		// Token: 0x04004793 RID: 18323
		[Token(Token = "0x4004793")]
		MAGIC,
		// Token: 0x04004794 RID: 18324
		[Token(Token = "0x4004794")]
		CHAR_MAP,
		// Token: 0x04004795 RID: 18325
		[Token(Token = "0x4004795")]
		BOND,
		// Token: 0x04004796 RID: 18326
		[Token(Token = "0x4004796")]
		ENEMY_GAIN,
		// Token: 0x04004797 RID: 18327
		[Token(Token = "0x4004797")]
		BUFF_GAIN,
		// Token: 0x04004798 RID: 18328
		[Token(Token = "0x4004798")]
		GARRISON
	}
}
