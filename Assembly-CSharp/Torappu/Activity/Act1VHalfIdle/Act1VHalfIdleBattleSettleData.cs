using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x020076C1 RID: 30401
	[Token(Token = "0x20076C1")]
	public class Act1VHalfIdleBattleSettleData
	{
		// Token: 0x0602AC0C RID: 175116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AC0C")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Act1VHalfIdleBattleSettleData()
		{
		}

		// Token: 0x0403D99D RID: 252317
		[Token(Token = "0x403D99D")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, int> characterLevelDict;

		// Token: 0x0403D99E RID: 252318
		[Token(Token = "0x403D99E")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, int> resourceNumDict;

		// Token: 0x0403D99F RID: 252319
		[Token(Token = "0x403D99F")]
		[FieldOffset(Offset = "0x20")]
		public PlayerActivity.PlayerAct1VHalfIdleActivity.BossState bossState;

		// Token: 0x0403D9A0 RID: 252320
		[Token(Token = "0x403D9A0")]
		[FieldOffset(Offset = "0x24")]
		public int battleProcess;
	}
}
