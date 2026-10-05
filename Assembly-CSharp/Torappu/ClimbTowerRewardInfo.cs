using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000F9F RID: 3999
	[Token(Token = "0x2000F9F")]
	public class ClimbTowerRewardInfo
	{
		// Token: 0x06006CDF RID: 27871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CDF")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ClimbTowerRewardInfo()
		{
		}

		// Token: 0x0400550D RID: 21773
		[Token(Token = "0x400550D")]
		[FieldOffset(Offset = "0x10")]
		public int stageSort;

		// Token: 0x0400550E RID: 21774
		[Token(Token = "0x400550E")]
		[FieldOffset(Offset = "0x14")]
		public int lowerItemCount;

		// Token: 0x0400550F RID: 21775
		[Token(Token = "0x400550F")]
		[FieldOffset(Offset = "0x18")]
		public int higherItemCount;
	}
}
