using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001130 RID: 4400
	[Token(Token = "0x2001130")]
	public class RecalRuneStageData
	{
		// Token: 0x06006F04 RID: 28420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F04")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RecalRuneStageData()
		{
		}

		// Token: 0x04005E45 RID: 24133
		[Token(Token = "0x4005E45")]
		[FieldOffset(Offset = "0x10")]
		public string stageId;

		// Token: 0x04005E46 RID: 24134
		[Token(Token = "0x4005E46")]
		[FieldOffset(Offset = "0x18")]
		public string levelId;

		// Token: 0x04005E47 RID: 24135
		[Token(Token = "0x4005E47")]
		[FieldOffset(Offset = "0x20")]
		public string juniorMedalId;

		// Token: 0x04005E48 RID: 24136
		[Token(Token = "0x4005E48")]
		[FieldOffset(Offset = "0x28")]
		public string seniorMedalId;

		// Token: 0x04005E49 RID: 24137
		[Token(Token = "0x4005E49")]
		[FieldOffset(Offset = "0x30")]
		public int juniorMedalScore;

		// Token: 0x04005E4A RID: 24138
		[Token(Token = "0x4005E4A")]
		[FieldOffset(Offset = "0x34")]
		public int seniorMedalScore;

		// Token: 0x04005E4B RID: 24139
		[Token(Token = "0x4005E4B")]
		[FieldOffset(Offset = "0x38")]
		public Dictionary<string, RecalRuneRuneData> runes;

		// Token: 0x04005E4C RID: 24140
		[Token(Token = "0x4005E4C")]
		[FieldOffset(Offset = "0x40")]
		public string sourceName;

		// Token: 0x04005E4D RID: 24141
		[Token(Token = "0x4005E4D")]
		[FieldOffset(Offset = "0x48")]
		public string sourceType;

		// Token: 0x04005E4E RID: 24142
		[Token(Token = "0x4005E4E")]
		[FieldOffset(Offset = "0x50")]
		public bool useName;

		// Token: 0x04005E4F RID: 24143
		[Token(Token = "0x4005E4F")]
		[FieldOffset(Offset = "0x58")]
		public string levelName;

		// Token: 0x04005E50 RID: 24144
		[Token(Token = "0x4005E50")]
		[FieldOffset(Offset = "0x60")]
		public string levelCode;

		// Token: 0x04005E51 RID: 24145
		[Token(Token = "0x4005E51")]
		[FieldOffset(Offset = "0x68")]
		public string levelDesc;

		// Token: 0x04005E52 RID: 24146
		[Token(Token = "0x4005E52")]
		[FieldOffset(Offset = "0x70")]
		public string fixedRuneSeriesName;

		// Token: 0x04005E53 RID: 24147
		[Token(Token = "0x4005E53")]
		[FieldOffset(Offset = "0x78")]
		public string logoId;

		// Token: 0x04005E54 RID: 24148
		[Token(Token = "0x4005E54")]
		[FieldOffset(Offset = "0x80")]
		public string mainPicId;

		// Token: 0x04005E55 RID: 24149
		[Token(Token = "0x4005E55")]
		[FieldOffset(Offset = "0x88")]
		public string loadingPicId;
	}
}
