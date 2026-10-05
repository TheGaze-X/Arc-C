using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x020011D6 RID: 4566
	[Token(Token = "0x20011D6")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum RoguelikeCharState
	{
		// Token: 0x040061CB RID: 25035
		[Token(Token = "0x40061CB")]
		NORMAL,
		// Token: 0x040061CC RID: 25036
		[Token(Token = "0x40061CC")]
		UPGRADE,
		// Token: 0x040061CD RID: 25037
		[Token(Token = "0x40061CD")]
		UPGRADE_BUFF,
		// Token: 0x040061CE RID: 25038
		[Token(Token = "0x40061CE")]
		UPGRADE_BONUS,
		// Token: 0x040061CF RID: 25039
		[Token(Token = "0x40061CF")]
		FREE,
		// Token: 0x040061D0 RID: 25040
		[Token(Token = "0x40061D0")]
		ASSIST,
		// Token: 0x040061D1 RID: 25041
		[Token(Token = "0x40061D1")]
		THIRD,
		// Token: 0x040061D2 RID: 25042
		[Token(Token = "0x40061D2")]
		MONTHLY,
		// Token: 0x040061D3 RID: 25043
		[Token(Token = "0x40061D3")]
		THIRD_LOW
	}
}
