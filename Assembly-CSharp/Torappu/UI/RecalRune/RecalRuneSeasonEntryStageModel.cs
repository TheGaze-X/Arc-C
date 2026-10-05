using System;
using Il2CppDummyDll;

namespace Torappu.UI.RecalRune
{
	// Token: 0x0200478E RID: 18318
	[Token(Token = "0x200478E")]
	public class RecalRuneSeasonEntryStageModel
	{
		// Token: 0x0601BBC3 RID: 113603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BBC3")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RecalRuneSeasonEntryStageModel()
		{
		}

		// Token: 0x040240BF RID: 147647
		[Token(Token = "0x40240BF")]
		[FieldOffset(Offset = "0x10")]
		public string stageId;

		// Token: 0x040240C0 RID: 147648
		[Token(Token = "0x40240C0")]
		[FieldOffset(Offset = "0x18")]
		public string bgId;

		// Token: 0x040240C1 RID: 147649
		[Token(Token = "0x40240C1")]
		[FieldOffset(Offset = "0x20")]
		public string iconId;

		// Token: 0x040240C2 RID: 147650
		[Token(Token = "0x40240C2")]
		[FieldOffset(Offset = "0x28")]
		public string displayMedalId;

		// Token: 0x040240C3 RID: 147651
		[Token(Token = "0x40240C3")]
		[FieldOffset(Offset = "0x30")]
		public bool gotSeniorMedal;

		// Token: 0x040240C4 RID: 147652
		[Token(Token = "0x40240C4")]
		[FieldOffset(Offset = "0x38")]
		public string textFrom;

		// Token: 0x040240C5 RID: 147653
		[Token(Token = "0x40240C5")]
		[FieldOffset(Offset = "0x40")]
		public string textFromType;

		// Token: 0x040240C6 RID: 147654
		[Token(Token = "0x40240C6")]
		[FieldOffset(Offset = "0x48")]
		public string textCode;

		// Token: 0x040240C7 RID: 147655
		[Token(Token = "0x40240C7")]
		[FieldOffset(Offset = "0x50")]
		public int record;

		// Token: 0x040240C8 RID: 147656
		[Token(Token = "0x40240C8")]
		[FieldOffset(Offset = "0x54")]
		public bool hasPassed;
	}
}
