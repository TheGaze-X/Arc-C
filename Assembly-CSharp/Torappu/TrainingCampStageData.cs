using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200138E RID: 5006
	[Token(Token = "0x200138E")]
	[Serializable]
	public class TrainingCampStageData
	{
		// Token: 0x0600736D RID: 29549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600736D")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public TrainingCampStageData()
		{
		}

		// Token: 0x04006F2A RID: 28458
		[Token(Token = "0x4006F2A")]
		[FieldOffset(Offset = "0x10")]
		public string stageId;

		// Token: 0x04006F2B RID: 28459
		[Token(Token = "0x4006F2B")]
		[FieldOffset(Offset = "0x18")]
		public string stageIconId;

		// Token: 0x04006F2C RID: 28460
		[Token(Token = "0x4006F2C")]
		[FieldOffset(Offset = "0x20")]
		public int sortId;

		// Token: 0x04006F2D RID: 28461
		[Token(Token = "0x4006F2D")]
		[FieldOffset(Offset = "0x28")]
		public string levelId;

		// Token: 0x04006F2E RID: 28462
		[Token(Token = "0x4006F2E")]
		[FieldOffset(Offset = "0x30")]
		public string code;

		// Token: 0x04006F2F RID: 28463
		[Token(Token = "0x4006F2F")]
		[FieldOffset(Offset = "0x38")]
		public string name;

		// Token: 0x04006F30 RID: 28464
		[Token(Token = "0x4006F30")]
		[FieldOffset(Offset = "0x40")]
		public string loadingPicId;

		// Token: 0x04006F31 RID: 28465
		[Token(Token = "0x4006F31")]
		[FieldOffset(Offset = "0x48")]
		public string description;

		// Token: 0x04006F32 RID: 28466
		[Token(Token = "0x4006F32")]
		[FieldOffset(Offset = "0x50")]
		public string endCharId;

		// Token: 0x04006F33 RID: 28467
		[Token(Token = "0x4006F33")]
		[FieldOffset(Offset = "0x58")]
		public long updateTs;
	}
}
