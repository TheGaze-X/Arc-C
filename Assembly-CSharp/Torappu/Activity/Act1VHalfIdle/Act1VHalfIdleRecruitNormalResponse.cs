using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x020076C8 RID: 30408
	[Token(Token = "0x20076C8")]
	public class Act1VHalfIdleRecruitNormalResponse : PlayerDeltaResponse
	{
		// Token: 0x0602AC13 RID: 175123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AC13")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public Act1VHalfIdleRecruitNormalResponse()
		{
		}

		// Token: 0x0403D9B0 RID: 252336
		[Token(Token = "0x403D9B0")]
		[FieldOffset(Offset = "0x28")]
		public List<string> newChar;

		// Token: 0x0403D9B1 RID: 252337
		[Token(Token = "0x403D9B1")]
		[FieldOffset(Offset = "0x30")]
		public List<string> oldChar;

		// Token: 0x0403D9B2 RID: 252338
		[Token(Token = "0x403D9B2")]
		[FieldOffset(Offset = "0x38")]
		public int ticketCount;
	}
}
