using System;
using Il2CppDummyDll;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020043BC RID: 17340
	[Token(Token = "0x20043BC")]
	public class SandboxV2RacingSaveMarkResponse : PlayerDeltaResponse
	{
		// Token: 0x0601A967 RID: 108903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A967")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public SandboxV2RacingSaveMarkResponse()
		{
		}

		// Token: 0x04021E39 RID: 138809
		[Token(Token = "0x4021E39")]
		[FieldOffset(Offset = "0x28")]
		public string instId;

		// Token: 0x04021E3A RID: 138810
		[Token(Token = "0x4021E3A")]
		[FieldOffset(Offset = "0x30")]
		public bool mark;
	}
}
