using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000E59 RID: 3673
	[Token(Token = "0x2000E59")]
	public class ActRecruitOnlyData
	{
		// Token: 0x06006B28 RID: 27432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B28")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ActRecruitOnlyData()
		{
		}

		// Token: 0x04004CDF RID: 19679
		[Token(Token = "0x4004CDF")]
		[FieldOffset(Offset = "0x10")]
		public ActRecruitOnlyData.RecruitOnlyItemData recruitData;

		// Token: 0x04004CE0 RID: 19680
		[Token(Token = "0x4004CE0")]
		[FieldOffset(Offset = "0x18")]
		public ActRecruitOnlyData.RecruitOnlyItemData previewData;

		// Token: 0x02000E5A RID: 3674
		[Token(Token = "0x2000E5A")]
		public class RecruitOnlyItemData
		{
			// Token: 0x06006B29 RID: 27433 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006B29")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public RecruitOnlyItemData()
			{
			}

			// Token: 0x04004CE1 RID: 19681
			[Token(Token = "0x4004CE1")]
			[FieldOffset(Offset = "0x10")]
			public string id;

			// Token: 0x04004CE2 RID: 19682
			[Token(Token = "0x4004CE2")]
			[FieldOffset(Offset = "0x18")]
			public int phaseNum;

			// Token: 0x04004CE3 RID: 19683
			[Token(Token = "0x4004CE3")]
			[FieldOffset(Offset = "0x1C")]
			public int tagId;

			// Token: 0x04004CE4 RID: 19684
			[Token(Token = "0x4004CE4")]
			[FieldOffset(Offset = "0x20")]
			public int tagTimes;

			// Token: 0x04004CE5 RID: 19685
			[Token(Token = "0x4004CE5")]
			[FieldOffset(Offset = "0x28")]
			public long startTime;

			// Token: 0x04004CE6 RID: 19686
			[Token(Token = "0x4004CE6")]
			[FieldOffset(Offset = "0x30")]
			public long endTime;

			// Token: 0x04004CE7 RID: 19687
			[Token(Token = "0x4004CE7")]
			[FieldOffset(Offset = "0x38")]
			public string startTimeDesc;

			// Token: 0x04004CE8 RID: 19688
			[Token(Token = "0x4004CE8")]
			[FieldOffset(Offset = "0x40")]
			public string endTimeDesc;

			// Token: 0x04004CE9 RID: 19689
			[Token(Token = "0x4004CE9")]
			[FieldOffset(Offset = "0x48")]
			public string desc1;

			// Token: 0x04004CEA RID: 19690
			[Token(Token = "0x4004CEA")]
			[FieldOffset(Offset = "0x50")]
			public string desc2;
		}
	}
}
