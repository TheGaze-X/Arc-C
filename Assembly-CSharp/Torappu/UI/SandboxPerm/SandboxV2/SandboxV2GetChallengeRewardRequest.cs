using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020043FA RID: 17402
	[Token(Token = "0x20043FA")]
	public class SandboxV2GetChallengeRewardRequest
	{
		// Token: 0x0601A9A4 RID: 108964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A9A4")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SandboxV2GetChallengeRewardRequest()
		{
		}

		// Token: 0x04021E96 RID: 138902
		[Token(Token = "0x4021E96")]
		[FieldOffset(Offset = "0x10")]
		public string topicId;

		// Token: 0x04021E97 RID: 138903
		[Token(Token = "0x4021E97")]
		[FieldOffset(Offset = "0x18")]
		public List<string> rewardIds;
	}
}
