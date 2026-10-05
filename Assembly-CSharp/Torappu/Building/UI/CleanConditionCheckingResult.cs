using System;
using Il2CppDummyDll;

namespace Torappu.Building.UI
{
	// Token: 0x02001BA4 RID: 7076
	[Token(Token = "0x2001BA4")]
	public struct CleanConditionCheckingResult
	{
		// Token: 0x0600B089 RID: 45193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B089")]
		[Address(RVA = "0x4F1E60", Offset = "0x4F0A60", VA = "0x1804F1E60")]
		public CleanConditionCheckingResult(CleanConditionCheckingResult.Reason reason, int targetLevel)
		{
		}

		// Token: 0x0400AAFF RID: 43775
		[Token(Token = "0x400AAFF")]
		[FieldOffset(Offset = "0x0")]
		public CleanConditionCheckingResult.Reason reason;

		// Token: 0x0400AB00 RID: 43776
		[Token(Token = "0x400AB00")]
		[FieldOffset(Offset = "0x4")]
		public int targetLevel;

		// Token: 0x02001BA5 RID: 7077
		[Token(Token = "0x2001BA5")]
		public enum Reason
		{
			// Token: 0x0400AB02 RID: 43778
			[Token(Token = "0x400AB02")]
			NONE,
			// Token: 0x0400AB03 RID: 43779
			[Token(Token = "0x400AB03")]
			NOT_CONNECT_TO_CONTROL,
			// Token: 0x0400AB04 RID: 43780
			[Token(Token = "0x400AB04")]
			LOW_CONTROL_LEVEL
		}
	}
}
