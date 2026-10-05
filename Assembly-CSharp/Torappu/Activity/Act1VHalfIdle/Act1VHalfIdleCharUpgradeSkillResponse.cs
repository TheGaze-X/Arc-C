using System;
using Il2CppDummyDll;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x020076D2 RID: 30418
	[Token(Token = "0x20076D2")]
	public class Act1VHalfIdleCharUpgradeSkillResponse : PlayerDeltaResponse
	{
		// Token: 0x0602AC1D RID: 175133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AC1D")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public Act1VHalfIdleCharUpgradeSkillResponse()
		{
		}

		// Token: 0x0403D9C5 RID: 252357
		[Token(Token = "0x403D9C5")]
		[FieldOffset(Offset = "0x28")]
		public string charId;

		// Token: 0x0403D9C6 RID: 252358
		[Token(Token = "0x403D9C6")]
		[FieldOffset(Offset = "0x30")]
		public int currentLvl;
	}
}
