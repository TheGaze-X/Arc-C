using System;
using Il2CppDummyDll;

namespace Torappu.Multiplayer
{
	// Token: 0x02001547 RID: 5447
	[Token(Token = "0x2001547")]
	public enum GameFastModeParam
	{
		// Token: 0x04007D23 RID: 32035
		[Token(Token = "0x4007D23")]
		None,
		// Token: 0x04007D24 RID: 32036
		[Token(Token = "0x4007D24")]
		Ask,
		// Token: 0x04007D25 RID: 32037
		[Token(Token = "0x4007D25")]
		Stop,
		// Token: 0x04007D26 RID: 32038
		[Token(Token = "0x4007D26")]
		Cancel,
		// Token: 0x04007D27 RID: 32039
		[Token(Token = "0x4007D27")]
		Refuse,
		// Token: 0x04007D28 RID: 32040
		[Token(Token = "0x4007D28")]
		Sys_StartFastMode = 100,
		// Token: 0x04007D29 RID: 32041
		[Token(Token = "0x4007D29")]
		Sys_StopFastMode
	}
}
