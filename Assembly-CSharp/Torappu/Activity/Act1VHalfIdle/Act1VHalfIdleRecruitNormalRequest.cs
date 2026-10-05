using System;
using Il2CppDummyDll;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x020076C7 RID: 30407
	[Token(Token = "0x20076C7")]
	public class Act1VHalfIdleRecruitNormalRequest
	{
		// Token: 0x0602AC12 RID: 175122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AC12")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Act1VHalfIdleRecruitNormalRequest()
		{
		}

		// Token: 0x0403D9AD RID: 252333
		[Token(Token = "0x403D9AD")]
		[FieldOffset(Offset = "0x10")]
		public string activityId;

		// Token: 0x0403D9AE RID: 252334
		[Token(Token = "0x403D9AE")]
		[FieldOffset(Offset = "0x18")]
		public string poolId;

		// Token: 0x0403D9AF RID: 252335
		[Token(Token = "0x403D9AF")]
		[FieldOffset(Offset = "0x20")]
		public int count;
	}
}
