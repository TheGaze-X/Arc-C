using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02000C85 RID: 3205
	[Token(Token = "0x2000C85")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum Act1VHalfIdleGachaPoolType
	{
		// Token: 0x0400416F RID: 16751
		[Token(Token = "0x400416F")]
		NONE,
		// Token: 0x04004170 RID: 16752
		[Token(Token = "0x4004170")]
		GACHA_NORMAL,
		// Token: 0x04004171 RID: 16753
		[Token(Token = "0x4004171")]
		GACHA_NEWPLAYER,
		// Token: 0x04004172 RID: 16754
		[Token(Token = "0x4004172")]
		GACHA_PAC,
		// Token: 0x04004173 RID: 16755
		[Token(Token = "0x4004173")]
		GACHA_DIRECT
	}
}
