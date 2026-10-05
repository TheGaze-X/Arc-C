using System;
using Il2CppDummyDll;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x020076C5 RID: 30405
	[Token(Token = "0x20076C5")]
	public class Act1VHalfIdleReplaceIncomeRequest
	{
		// Token: 0x0602AC10 RID: 175120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AC10")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Act1VHalfIdleReplaceIncomeRequest()
		{
		}

		// Token: 0x0403D9AA RID: 252330
		[Token(Token = "0x403D9AA")]
		[FieldOffset(Offset = "0x10")]
		public string activityId;

		// Token: 0x0403D9AB RID: 252331
		[Token(Token = "0x403D9AB")]
		[FieldOffset(Offset = "0x18")]
		public string stageId;

		// Token: 0x0403D9AC RID: 252332
		[Token(Token = "0x403D9AC")]
		[FieldOffset(Offset = "0x20")]
		public int replace;
	}
}
