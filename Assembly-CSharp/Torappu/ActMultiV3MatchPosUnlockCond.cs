using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000E43 RID: 3651
	[Token(Token = "0x2000E43")]
	public class ActMultiV3MatchPosUnlockCond
	{
		// Token: 0x06006B11 RID: 27409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B11")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ActMultiV3MatchPosUnlockCond()
		{
		}

		// Token: 0x04004C0B RID: 19467
		[Token(Token = "0x4004C0B")]
		[FieldOffset(Offset = "0x10")]
		public ActMultiV3MapDiffType diff;

		// Token: 0x04004C0C RID: 19468
		[Token(Token = "0x4004C0C")]
		[FieldOffset(Offset = "0x14")]
		public int completeMapCount;

		// Token: 0x04004C0D RID: 19469
		[Token(Token = "0x4004C0D")]
		[FieldOffset(Offset = "0x18")]
		public int requireMapStar;

		// Token: 0x04004C0E RID: 19470
		[Token(Token = "0x4004C0E")]
		[FieldOffset(Offset = "0x20")]
		public string unlockHint;
	}
}
