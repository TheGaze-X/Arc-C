using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02000E7E RID: 3710
	[Token(Token = "0x2000E7E")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ActivityThemeType
	{
		// Token: 0x04004E16 RID: 19990
		[Token(Token = "0x4004E16")]
		NONE,
		// Token: 0x04004E17 RID: 19991
		[Token(Token = "0x4004E17")]
		ACTIVITY,
		// Token: 0x04004E18 RID: 19992
		[Token(Token = "0x4004E18")]
		CRISIS,
		// Token: 0x04004E19 RID: 19993
		[Token(Token = "0x4004E19")]
		MAINLINE,
		// Token: 0x04004E1A RID: 19994
		[Token(Token = "0x4004E1A")]
		ROGUELIKE,
		// Token: 0x04004E1B RID: 19995
		[Token(Token = "0x4004E1B")]
		CRISISV2,
		// Token: 0x04004E1C RID: 19996
		[Token(Token = "0x4004E1C")]
		SANDBOX_PERM,
		// Token: 0x04004E1D RID: 19997
		[Token(Token = "0x4004E1D")]
		ACTIVITY_COMP
	}
}
