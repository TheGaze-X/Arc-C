using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001066 RID: 4198
	[Token(Token = "0x2001066")]
	[Serializable]
	public class SpecialRecruitPool : BasedRecruitPool
	{
		// Token: 0x06006DF1 RID: 28145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DF1")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SpecialRecruitPool()
		{
		}

		// Token: 0x04005945 RID: 22853
		[Token(Token = "0x4005945")]
		[FieldOffset(Offset = "0x18")]
		public string recruitId;

		// Token: 0x04005946 RID: 22854
		[Token(Token = "0x4005946")]
		[FieldOffset(Offset = "0x20")]
		public string tagName;

		// Token: 0x04005947 RID: 22855
		[Token(Token = "0x4005947")]
		[FieldOffset(Offset = "0x28")]
		public int tagId;

		// Token: 0x04005948 RID: 22856
		[Token(Token = "0x4005948")]
		[FieldOffset(Offset = "0x2C")]
		public int order;

		// Token: 0x04005949 RID: 22857
		[Token(Token = "0x4005949")]
		[FieldOffset(Offset = "0x30")]
		public long startDateTime;

		// Token: 0x0400594A RID: 22858
		[Token(Token = "0x400594A")]
		[FieldOffset(Offset = "0x38")]
		public long endDateTime;

		// Token: 0x0400594B RID: 22859
		[Token(Token = "0x400594B")]
		[FieldOffset(Offset = "0x40")]
		public SpecialRecruitPool.SpecialRecruitCostData[] recruitTimeTable;

		// Token: 0x02001067 RID: 4199
		[Token(Token = "0x2001067")]
		public class SpecialRecruitCostData
		{
			// Token: 0x06006DF2 RID: 28146 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006DF2")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public SpecialRecruitCostData()
			{
			}

			// Token: 0x0400594C RID: 22860
			[Token(Token = "0x400594C")]
			[FieldOffset(Offset = "0x10")]
			public int timeLength;

			// Token: 0x0400594D RID: 22861
			[Token(Token = "0x400594D")]
			[FieldOffset(Offset = "0x14")]
			public int recruitPrice;

			// Token: 0x0400594E RID: 22862
			[Token(Token = "0x400594E")]
			[FieldOffset(Offset = "0x18")]
			public ItemBundle[] itemCosts;
		}
	}
}
