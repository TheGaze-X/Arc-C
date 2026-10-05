using System;
using Il2CppDummyDll;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x020076D0 RID: 30416
	[Token(Token = "0x20076D0")]
	public class Act1VHalfIdleCharUpgradeLevelResponse : PlayerDeltaResponse
	{
		// Token: 0x0602AC1B RID: 175131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AC1B")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public Act1VHalfIdleCharUpgradeLevelResponse()
		{
		}

		// Token: 0x0403D9C0 RID: 252352
		[Token(Token = "0x403D9C0")]
		[FieldOffset(Offset = "0x28")]
		public string charId;

		// Token: 0x0403D9C1 RID: 252353
		[Token(Token = "0x403D9C1")]
		[FieldOffset(Offset = "0x30")]
		public int currentLvl;
	}
}
