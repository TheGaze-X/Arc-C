using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000E64 RID: 3684
	[Token(Token = "0x2000E64")]
	public class ActVecBreakV2DefenseDetailData
	{
		// Token: 0x06006B33 RID: 27443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B33")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ActVecBreakV2DefenseDetailData()
		{
		}

		// Token: 0x04004D1E RID: 19742
		[Token(Token = "0x4004D1E")]
		[FieldOffset(Offset = "0x10")]
		public string stageId;

		// Token: 0x04004D1F RID: 19743
		[Token(Token = "0x4004D1F")]
		[FieldOffset(Offset = "0x18")]
		public string buffId;

		// Token: 0x04004D20 RID: 19744
		[Token(Token = "0x4004D20")]
		[FieldOffset(Offset = "0x20")]
		public int defenseCharLimit;

		// Token: 0x04004D21 RID: 19745
		[Token(Token = "0x4004D21")]
		[FieldOffset(Offset = "0x28")]
		public string bossIconId;
	}
}
