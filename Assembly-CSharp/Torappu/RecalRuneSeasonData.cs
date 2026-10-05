using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200112F RID: 4399
	[Token(Token = "0x200112F")]
	public class RecalRuneSeasonData
	{
		// Token: 0x06006F03 RID: 28419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F03")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RecalRuneSeasonData()
		{
		}

		// Token: 0x04005E3B RID: 24123
		[Token(Token = "0x4005E3B")]
		[FieldOffset(Offset = "0x10")]
		public string seasonId;

		// Token: 0x04005E3C RID: 24124
		[Token(Token = "0x4005E3C")]
		[FieldOffset(Offset = "0x18")]
		public int sortId;

		// Token: 0x04005E3D RID: 24125
		[Token(Token = "0x4005E3D")]
		[FieldOffset(Offset = "0x20")]
		public long startTs;

		// Token: 0x04005E3E RID: 24126
		[Token(Token = "0x4005E3E")]
		[FieldOffset(Offset = "0x28")]
		public string seasonCode;

		// Token: 0x04005E3F RID: 24127
		[Token(Token = "0x4005E3F")]
		[FieldOffset(Offset = "0x30")]
		public ItemBundle juniorReward;

		// Token: 0x04005E40 RID: 24128
		[Token(Token = "0x4005E40")]
		[FieldOffset(Offset = "0x38")]
		public ItemBundle seniorReward;

		// Token: 0x04005E41 RID: 24129
		[Token(Token = "0x4005E41")]
		[FieldOffset(Offset = "0x40")]
		public string seniorRewardHint;

		// Token: 0x04005E42 RID: 24130
		[Token(Token = "0x4005E42")]
		[FieldOffset(Offset = "0x48")]
		public string mainMedalId;

		// Token: 0x04005E43 RID: 24131
		[Token(Token = "0x4005E43")]
		[FieldOffset(Offset = "0x50")]
		public string picId;

		// Token: 0x04005E44 RID: 24132
		[Token(Token = "0x4005E44")]
		[FieldOffset(Offset = "0x58")]
		public Dictionary<string, RecalRuneStageData> stages;
	}
}
