using System;
using Il2CppDummyDll;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020043D1 RID: 17361
	[Token(Token = "0x20043D1")]
	public class SandboxV2ShopBuyResponse : PlayerDeltaResponse
	{
		// Token: 0x0601A97C RID: 108924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A97C")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public SandboxV2ShopBuyResponse()
		{
		}

		// Token: 0x04021E5F RID: 138847
		[Token(Token = "0x4021E5F")]
		[FieldOffset(Offset = "0x28")]
		public SandboxV2ShopBuyItem item;
	}
}
