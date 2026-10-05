using System;
using Il2CppDummyDll;

namespace Torappu.Activity.Act1Lock
{
	// Token: 0x0200786A RID: 30826
	[Token(Token = "0x200786A")]
	public class Act1LockFinalBattleStartRequest
	{
		// Token: 0x0602B33A RID: 176954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B33A")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Act1LockFinalBattleStartRequest()
		{
		}

		// Token: 0x0403E75D RID: 255837
		[Token(Token = "0x403E75D")]
		[FieldOffset(Offset = "0x10")]
		public string activityId;

		// Token: 0x0403E75E RID: 255838
		[Token(Token = "0x403E75E")]
		[FieldOffset(Offset = "0x18")]
		public string stageId;

		// Token: 0x0403E75F RID: 255839
		[Token(Token = "0x403E75F")]
		[FieldOffset(Offset = "0x20")]
		public bool useSpecial;

		// Token: 0x0403E760 RID: 255840
		[Token(Token = "0x403E760")]
		[FieldOffset(Offset = "0x21")]
		public bool usePracticeTicket;

		// Token: 0x0403E761 RID: 255841
		[Token(Token = "0x403E761")]
		[FieldOffset(Offset = "0x22")]
		public bool isReplay;
	}
}
