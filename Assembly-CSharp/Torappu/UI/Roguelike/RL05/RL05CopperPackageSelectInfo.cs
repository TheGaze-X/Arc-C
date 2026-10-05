using System;
using Il2CppDummyDll;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x020055B2 RID: 21938
	[Token(Token = "0x20055B2")]
	public struct RL05CopperPackageSelectInfo
	{
		// Token: 0x06020362 RID: 131938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020362")]
		[Address(RVA = "0x1A4E6E0", Offset = "0x1A4D2E0", VA = "0x181A4E6E0")]
		public void ResetPrev()
		{
		}

		// Token: 0x0402B90D RID: 178445
		[Token(Token = "0x402B90D")]
		[FieldOffset(Offset = "0x0")]
		public string prevSelectInstId;

		// Token: 0x0402B90E RID: 178446
		[Token(Token = "0x402B90E")]
		[FieldOffset(Offset = "0x8")]
		public string currSelectInstId;
	}
}
