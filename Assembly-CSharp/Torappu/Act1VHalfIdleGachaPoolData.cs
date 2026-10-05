using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000C8B RID: 3211
	[Token(Token = "0x2000C8B")]
	public class Act1VHalfIdleGachaPoolData
	{
		// Token: 0x06006963 RID: 26979 RVA: 0x00030D08 File Offset: 0x0002EF08
		[Token(Token = "0x6006963")]
		[Address(RVA = "0x1FF3CE0", Offset = "0x1FF28E0", VA = "0x181FF3CE0")]
		public bool ShouldSerializecharData()
		{
			return default(bool);
		}

		// Token: 0x06006964 RID: 26980 RVA: 0x00030D20 File Offset: 0x0002EF20
		[Token(Token = "0x6006964")]
		[Address(RVA = "0x1FF3B40", Offset = "0x1FF2740", VA = "0x181FF3B40")]
		public int GetGachaItemCost(int currGachaTimes, int gachaTimesToUse)
		{
			return 0;
		}

		// Token: 0x06006965 RID: 26981 RVA: 0x00030D38 File Offset: 0x0002EF38
		[Token(Token = "0x6006965")]
		[Address(RVA = "0x1FF3970", Offset = "0x1FF2570", VA = "0x181FF3970")]
		public int GetAvailableGachaTimes(int currGachaTimes, int currItemCount)
		{
			return 0;
		}

		// Token: 0x06006966 RID: 26982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006966")]
		[Address(RVA = "0x1FF3D00", Offset = "0x1FF2900", VA = "0x181FF3D00")]
		public Act1VHalfIdleGachaPoolData()
		{
		}

		// Token: 0x04004196 RID: 16790
		[Token(Token = "0x4004196")]
		[FieldOffset(Offset = "0x10")]
		public string poolId;

		// Token: 0x04004197 RID: 16791
		[Token(Token = "0x4004197")]
		[FieldOffset(Offset = "0x18")]
		public string itemId;

		// Token: 0x04004198 RID: 16792
		[Token(Token = "0x4004198")]
		[FieldOffset(Offset = "0x20")]
		public Act1VHalfIdleGachaPoolType poolType;

		// Token: 0x04004199 RID: 16793
		[Token(Token = "0x4004199")]
		[FieldOffset(Offset = "0x24")]
		public int sortId;

		// Token: 0x0400419A RID: 16794
		[Token(Token = "0x400419A")]
		[FieldOffset(Offset = "0x28")]
		public string name;

		// Token: 0x0400419B RID: 16795
		[Token(Token = "0x400419B")]
		[FieldOffset(Offset = "0x30")]
		public List<string> charData;

		// Token: 0x0400419C RID: 16796
		[Token(Token = "0x400419C")]
		[FieldOffset(Offset = "0x38")]
		public List<Act1VHalfIdleGachaPoolData.ConsumeData> consumeData;

		// Token: 0x02000C8C RID: 3212
		[Token(Token = "0x2000C8C")]
		public class ConsumeData
		{
			// Token: 0x06006967 RID: 26983 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006967")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ConsumeData()
			{
			}

			// Token: 0x0400419D RID: 16797
			[Token(Token = "0x400419D")]
			[FieldOffset(Offset = "0x10")]
			public int gachaTimes;

			// Token: 0x0400419E RID: 16798
			[Token(Token = "0x400419E")]
			[FieldOffset(Offset = "0x14")]
			public int consume;
		}
	}
}
