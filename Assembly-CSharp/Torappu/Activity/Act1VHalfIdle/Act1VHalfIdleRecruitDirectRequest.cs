using System;
using Il2CppDummyDll;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x020076C9 RID: 30409
	[Token(Token = "0x20076C9")]
	public class Act1VHalfIdleRecruitDirectRequest
	{
		// Token: 0x0602AC14 RID: 175124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AC14")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Act1VHalfIdleRecruitDirectRequest()
		{
		}

		// Token: 0x0403D9B3 RID: 252339
		[Token(Token = "0x403D9B3")]
		[FieldOffset(Offset = "0x10")]
		public string activityId;

		// Token: 0x0403D9B4 RID: 252340
		[Token(Token = "0x403D9B4")]
		[FieldOffset(Offset = "0x18")]
		public string poolId;

		// Token: 0x0403D9B5 RID: 252341
		[Token(Token = "0x403D9B5")]
		[FieldOffset(Offset = "0x20")]
		public string charId;
	}
}
