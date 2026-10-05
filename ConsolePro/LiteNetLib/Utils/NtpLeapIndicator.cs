using System;
using Il2CppDummyDll;

namespace FlyingWormConsole3.LiteNetLib.Utils
{
	// Token: 0x02000074 RID: 116
	[Token(Token = "0x2000074")]
	public enum NtpLeapIndicator
	{
		// Token: 0x04000192 RID: 402
		[Token(Token = "0x4000192")]
		NoWarning,
		// Token: 0x04000193 RID: 403
		[Token(Token = "0x4000193")]
		LastMinuteHas61Seconds,
		// Token: 0x04000194 RID: 404
		[Token(Token = "0x4000194")]
		LastMinuteHas59Seconds,
		// Token: 0x04000195 RID: 405
		[Token(Token = "0x4000195")]
		AlarmCondition
	}
}
