using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000E50 RID: 3664
	[Token(Token = "0x2000E50")]
	public class ActMultiV3TempCharData
	{
		// Token: 0x06006B1E RID: 27422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B1E")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ActMultiV3TempCharData()
		{
		}

		// Token: 0x04004C45 RID: 19525
		[Token(Token = "0x4004C45")]
		[FieldOffset(Offset = "0x10")]
		public string charId;

		// Token: 0x04004C46 RID: 19526
		[Token(Token = "0x4004C46")]
		[FieldOffset(Offset = "0x18")]
		public int level;

		// Token: 0x04004C47 RID: 19527
		[Token(Token = "0x4004C47")]
		[FieldOffset(Offset = "0x1C")]
		public EvolvePhase evolvePhase;

		// Token: 0x04004C48 RID: 19528
		[Token(Token = "0x4004C48")]
		[FieldOffset(Offset = "0x20")]
		public int mainSkillLevel;

		// Token: 0x04004C49 RID: 19529
		[Token(Token = "0x4004C49")]
		[FieldOffset(Offset = "0x24")]
		public int specializeLevel;

		// Token: 0x04004C4A RID: 19530
		[Token(Token = "0x4004C4A")]
		[FieldOffset(Offset = "0x28")]
		public int potentialRank;

		// Token: 0x04004C4B RID: 19531
		[Token(Token = "0x4004C4B")]
		[FieldOffset(Offset = "0x2C")]
		public int favorPoint;

		// Token: 0x04004C4C RID: 19532
		[Token(Token = "0x4004C4C")]
		[FieldOffset(Offset = "0x30")]
		public string skinId;
	}
}
