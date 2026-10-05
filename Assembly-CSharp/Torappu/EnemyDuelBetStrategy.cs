using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02000DFA RID: 3578
	[Token(Token = "0x2000DFA")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum EnemyDuelBetStrategy
	{
		// Token: 0x04004A34 RID: 18996
		[Token(Token = "0x4004A34")]
		DEFAULT,
		// Token: 0x04004A35 RID: 18997
		[Token(Token = "0x4004A35")]
		CHOOSE_WIN,
		// Token: 0x04004A36 RID: 18998
		[Token(Token = "0x4004A36")]
		CHOOSE_ODD,
		// Token: 0x04004A37 RID: 18999
		[Token(Token = "0x4004A37")]
		FOLLOW_FEWER,
		// Token: 0x04004A38 RID: 19000
		[Token(Token = "0x4004A38")]
		FOLLOW_MORE,
		// Token: 0x04004A39 RID: 19001
		[Token(Token = "0x4004A39")]
		CHOOSE_ODD_ENEMY_COUNT,
		// Token: 0x04004A3A RID: 19002
		[Token(Token = "0x4004A3A")]
		CHOOSE_EVEN_ENEMY_COUNT,
		// Token: 0x04004A3B RID: 19003
		[Token(Token = "0x4004A3B")]
		ALWAYS_LEFT
	}
}
