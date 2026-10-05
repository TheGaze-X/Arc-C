using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020012EA RID: 4842
	[Token(Token = "0x20012EA")]
	public class SandboxV2TutorialRepoCharData
	{
		// Token: 0x06007263 RID: 29283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007263")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SandboxV2TutorialRepoCharData()
		{
		}

		// Token: 0x04006AF4 RID: 27380
		[Token(Token = "0x4006AF4")]
		[FieldOffset(Offset = "0x10")]
		public int instId;

		// Token: 0x04006AF5 RID: 27381
		[Token(Token = "0x4006AF5")]
		[FieldOffset(Offset = "0x18")]
		public string charId;

		// Token: 0x04006AF6 RID: 27382
		[Token(Token = "0x4006AF6")]
		[FieldOffset(Offset = "0x20")]
		public EvolvePhase evolvePhase;

		// Token: 0x04006AF7 RID: 27383
		[Token(Token = "0x4006AF7")]
		[FieldOffset(Offset = "0x24")]
		public int level;

		// Token: 0x04006AF8 RID: 27384
		[Token(Token = "0x4006AF8")]
		[FieldOffset(Offset = "0x28")]
		public int favorPoint;

		// Token: 0x04006AF9 RID: 27385
		[Token(Token = "0x4006AF9")]
		[FieldOffset(Offset = "0x2C")]
		public int potentialRank;

		// Token: 0x04006AFA RID: 27386
		[Token(Token = "0x4006AFA")]
		[FieldOffset(Offset = "0x30")]
		public int mainSkillLv;

		// Token: 0x04006AFB RID: 27387
		[Token(Token = "0x4006AFB")]
		[FieldOffset(Offset = "0x38")]
		public List<int> specSkillList;
	}
}
