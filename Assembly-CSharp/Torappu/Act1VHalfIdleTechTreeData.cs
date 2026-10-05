using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000CAF RID: 3247
	[Token(Token = "0x2000CAF")]
	public class Act1VHalfIdleTechTreeData
	{
		// Token: 0x0600698E RID: 27022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600698E")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Act1VHalfIdleTechTreeData()
		{
		}

		// Token: 0x0400423E RID: 16958
		[Token(Token = "0x400423E")]
		[FieldOffset(Offset = "0x10")]
		public string nodeId;

		// Token: 0x0400423F RID: 16959
		[Token(Token = "0x400423F")]
		[FieldOffset(Offset = "0x18")]
		public Act1VHalfIdleTechTreeNodeType nodeType;

		// Token: 0x04004240 RID: 16960
		[Token(Token = "0x4004240")]
		[FieldOffset(Offset = "0x20")]
		public List<string> prevNodeId;

		// Token: 0x04004241 RID: 16961
		[Token(Token = "0x4004241")]
		[FieldOffset(Offset = "0x28")]
		public int tokenCost;

		// Token: 0x04004242 RID: 16962
		[Token(Token = "0x4004242")]
		[FieldOffset(Offset = "0x30")]
		public string name;

		// Token: 0x04004243 RID: 16963
		[Token(Token = "0x4004243")]
		[FieldOffset(Offset = "0x38")]
		public string iconId;

		// Token: 0x04004244 RID: 16964
		[Token(Token = "0x4004244")]
		[FieldOffset(Offset = "0x40")]
		public bool showPrevLockTips;

		// Token: 0x04004245 RID: 16965
		[Token(Token = "0x4004245")]
		[FieldOffset(Offset = "0x48")]
		public List<Act1VHalfIdleTechTreeData.Effect> effect;

		// Token: 0x02000CB0 RID: 3248
		[Token(Token = "0x2000CB0")]
		public class Effect
		{
			// Token: 0x0600698F RID: 27023 RVA: 0x00030DB0 File Offset: 0x0002EFB0
			[Token(Token = "0x600698F")]
			[Address(RVA = "0x5C59B0", Offset = "0x5C45B0", VA = "0x1805C59B0")]
			public bool ShouldSerializeruneDatas()
			{
				return default(bool);
			}

			// Token: 0x06006990 RID: 27024 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006990")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Effect()
			{
			}

			// Token: 0x04004246 RID: 16966
			[Token(Token = "0x4004246")]
			[FieldOffset(Offset = "0x10")]
			public string desc;

			// Token: 0x04004247 RID: 16967
			[Token(Token = "0x4004247")]
			[FieldOffset(Offset = "0x18")]
			public string title;

			// Token: 0x04004248 RID: 16968
			[Token(Token = "0x4004248")]
			[FieldOffset(Offset = "0x20")]
			public string iconId;

			// Token: 0x04004249 RID: 16969
			[Token(Token = "0x4004249")]
			[FieldOffset(Offset = "0x28")]
			public List<RuneTable.PackedRuneData> runeDatas;
		}
	}
}
