using System;
using Il2CppDummyDll;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x020076D6 RID: 30422
	[Token(Token = "0x20076D6")]
	public class Act1VHalfIdleUnlockTechRequest
	{
		// Token: 0x0602AC21 RID: 175137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AC21")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Act1VHalfIdleUnlockTechRequest()
		{
		}

		// Token: 0x0403D9CF RID: 252367
		[Token(Token = "0x403D9CF")]
		[FieldOffset(Offset = "0x10")]
		public string activityId;

		// Token: 0x0403D9D0 RID: 252368
		[Token(Token = "0x403D9D0")]
		[FieldOffset(Offset = "0x18")]
		public string techId;
	}
}
