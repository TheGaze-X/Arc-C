using System;
using Il2CppDummyDll;

namespace Torappu.Multiplayer
{
	// Token: 0x02001545 RID: 5445
	[Token(Token = "0x2001545")]
	public enum GamePauseParam
	{
		// Token: 0x04007D15 RID: 32021
		[Token(Token = "0x4007D15")]
		None,
		// Token: 0x04007D16 RID: 32022
		[Token(Token = "0x4007D16")]
		Ask,
		// Token: 0x04007D17 RID: 32023
		[Token(Token = "0x4007D17")]
		Stop,
		// Token: 0x04007D18 RID: 32024
		[Token(Token = "0x4007D18")]
		Cancel,
		// Token: 0x04007D19 RID: 32025
		[Token(Token = "0x4007D19")]
		Refuse,
		// Token: 0x04007D1A RID: 32026
		[Token(Token = "0x4007D1A")]
		Sys_StartPause = 100,
		// Token: 0x04007D1B RID: 32027
		[Token(Token = "0x4007D1B")]
		Sys_StopPause
	}
}
