using System;
using Il2CppDummyDll;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x020076D3 RID: 30419
	[Token(Token = "0x20076D3")]
	public class Act1VHalfIdleCharUpgradeEliteRequest
	{
		// Token: 0x0602AC1E RID: 175134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AC1E")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Act1VHalfIdleCharUpgradeEliteRequest()
		{
		}

		// Token: 0x0403D9C7 RID: 252359
		[Token(Token = "0x403D9C7")]
		[FieldOffset(Offset = "0x10")]
		public string activityId;

		// Token: 0x0403D9C8 RID: 252360
		[Token(Token = "0x403D9C8")]
		[FieldOffset(Offset = "0x18")]
		public string charId;

		// Token: 0x0403D9C9 RID: 252361
		[Token(Token = "0x403D9C9")]
		[FieldOffset(Offset = "0x20")]
		public int destEvolvePhase;
	}
}
