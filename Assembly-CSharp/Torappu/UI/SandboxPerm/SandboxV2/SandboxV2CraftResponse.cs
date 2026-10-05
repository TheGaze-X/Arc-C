using System;
using Il2CppDummyDll;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020043CC RID: 17356
	[Token(Token = "0x20043CC")]
	public class SandboxV2CraftResponse : PlayerDeltaResponse
	{
		// Token: 0x0601A977 RID: 108919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A977")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public SandboxV2CraftResponse()
		{
		}

		// Token: 0x04021E54 RID: 138836
		[Token(Token = "0x4021E54")]
		[FieldOffset(Offset = "0x28")]
		public SandboxV2CommonRewardItem item;

		// Token: 0x04021E55 RID: 138837
		[Token(Token = "0x4021E55")]
		[FieldOffset(Offset = "0x30")]
		public bool toSquad;
	}
}
