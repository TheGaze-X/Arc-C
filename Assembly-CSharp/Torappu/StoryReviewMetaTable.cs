using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200138C RID: 5004
	[Token(Token = "0x200138C")]
	[Serializable]
	public class StoryReviewMetaTable
	{
		// Token: 0x0600736B RID: 29547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600736B")]
		[Address(RVA = "0x22156C0", Offset = "0x22142C0", VA = "0x1822156C0")]
		public StoryReviewMetaTable()
		{
		}

		// Token: 0x04006F23 RID: 28451
		[Token(Token = "0x4006F23")]
		[FieldOffset(Offset = "0x10")]
		public MiniActTrialData miniActTrialData;

		// Token: 0x04006F24 RID: 28452
		[Token(Token = "0x4006F24")]
		[FieldOffset(Offset = "0x18")]
		public ActArchiveResData actArchiveResData;

		// Token: 0x04006F25 RID: 28453
		[Token(Token = "0x4006F25")]
		[FieldOffset(Offset = "0x20")]
		public ActArchiveComponentTable actArchiveData;

		// Token: 0x04006F26 RID: 28454
		[Token(Token = "0x4006F26")]
		[FieldOffset(Offset = "0x28")]
		public TrainingCampData trainingCampData;
	}
}
