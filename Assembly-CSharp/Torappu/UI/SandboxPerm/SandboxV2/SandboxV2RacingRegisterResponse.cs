using System;
using Il2CppDummyDll;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020043B6 RID: 17334
	[Token(Token = "0x20043B6")]
	public class SandboxV2RacingRegisterResponse : PlayerDeltaResponse
	{
		// Token: 0x0601A961 RID: 108897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A961")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public SandboxV2RacingRegisterResponse()
		{
		}

		// Token: 0x04021E2E RID: 138798
		[Token(Token = "0x4021E2E")]
		[FieldOffset(Offset = "0x28")]
		public PlayerSandboxV2.Racing.RacerName name;
	}
}
