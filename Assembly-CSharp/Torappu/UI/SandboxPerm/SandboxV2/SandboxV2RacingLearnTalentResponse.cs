using System;
using Il2CppDummyDll;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020043BA RID: 17338
	[Token(Token = "0x20043BA")]
	public class SandboxV2RacingLearnTalentResponse : PlayerDeltaResponse
	{
		// Token: 0x0601A965 RID: 108901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A965")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public SandboxV2RacingLearnTalentResponse()
		{
		}

		// Token: 0x04021E34 RID: 138804
		[Token(Token = "0x4021E34")]
		[FieldOffset(Offset = "0x28")]
		public string instId;

		// Token: 0x04021E35 RID: 138805
		[Token(Token = "0x4021E35")]
		[FieldOffset(Offset = "0x30")]
		public string talent;
	}
}
