using System;
using Il2CppDummyDll;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020043CE RID: 17358
	[Token(Token = "0x20043CE")]
	public class SandboxV2AlchemyResponse : PlayerDeltaResponse
	{
		// Token: 0x0601A979 RID: 108921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A979")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public SandboxV2AlchemyResponse()
		{
		}

		// Token: 0x04021E59 RID: 138841
		[Token(Token = "0x4021E59")]
		[FieldOffset(Offset = "0x28")]
		public SandboxV2CommonRewardItem item;
	}
}
