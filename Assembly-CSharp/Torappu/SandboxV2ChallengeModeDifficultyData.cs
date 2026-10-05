using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020012F6 RID: 4854
	[Token(Token = "0x20012F6")]
	public class SandboxV2ChallengeModeDifficultyData
	{
		// Token: 0x0600726F RID: 29295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600726F")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SandboxV2ChallengeModeDifficultyData()
		{
		}

		// Token: 0x04006B4A RID: 27466
		[Token(Token = "0x4006B4A")]
		[FieldOffset(Offset = "0x10")]
		public int challengeDay;

		// Token: 0x04006B4B RID: 27467
		[Token(Token = "0x4006B4B")]
		[FieldOffset(Offset = "0x18")]
		public string diffDesc;
	}
}
