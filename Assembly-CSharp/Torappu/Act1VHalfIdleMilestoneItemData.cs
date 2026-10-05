using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000CB1 RID: 3249
	[Token(Token = "0x2000CB1")]
	public class Act1VHalfIdleMilestoneItemData
	{
		// Token: 0x06006991 RID: 27025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006991")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Act1VHalfIdleMilestoneItemData()
		{
		}

		// Token: 0x0400424A RID: 16970
		[Token(Token = "0x400424A")]
		[FieldOffset(Offset = "0x10")]
		public string milestoneId;

		// Token: 0x0400424B RID: 16971
		[Token(Token = "0x400424B")]
		[FieldOffset(Offset = "0x18")]
		public int orderId;

		// Token: 0x0400424C RID: 16972
		[Token(Token = "0x400424C")]
		[FieldOffset(Offset = "0x1C")]
		public int tokenNum;

		// Token: 0x0400424D RID: 16973
		[Token(Token = "0x400424D")]
		[FieldOffset(Offset = "0x20")]
		public ItemBundle reward;

		// Token: 0x0400424E RID: 16974
		[Token(Token = "0x400424E")]
		[FieldOffset(Offset = "0x28")]
		public long availTime;
	}
}
