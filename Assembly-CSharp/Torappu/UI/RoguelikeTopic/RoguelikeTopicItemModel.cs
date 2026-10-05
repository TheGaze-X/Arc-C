using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x02004534 RID: 17716
	[Token(Token = "0x2004534")]
	public struct RoguelikeTopicItemModel : IHotfixable
	{
		// Token: 0x0601B05C RID: 110684 RVA: 0x000A3E78 File Offset: 0x000A2078
		[Token(Token = "0x601B05C")]
		[Address(RVA = "0x1438B20", Offset = "0x1437720", VA = "0x181438B20")]
		public bool IsEmpty()
		{
			return default(bool);
		}

		// Token: 0x17004045 RID: 16453
		// (get) Token: 0x0601B05D RID: 110685 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601B05E RID: 110686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004045")]
		public string usage
		{
			[Token(Token = "0x601B05D")]
			[Address(RVA = "0x1438F30", Offset = "0x1437B30", VA = "0x181438F30")]
			get
			{
				return null;
			}
			[Token(Token = "0x601B05E")]
			[Address(RVA = "0x14390F0", Offset = "0x1437CF0", VA = "0x1814390F0")]
			set
			{
			}
		}

		// Token: 0x17004046 RID: 16454
		// (get) Token: 0x0601B05F RID: 110687 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004046")]
		public string archiveUsage
		{
			[Token(Token = "0x601B05F")]
			[Address(RVA = "0x1438D80", Offset = "0x1437980", VA = "0x181438D80")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004047 RID: 16455
		// (set) Token: 0x0601B060 RID: 110688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004047")]
		public string shortUsage
		{
			[Token(Token = "0x601B060")]
			[Address(RVA = "0x1439010", Offset = "0x1437C10", VA = "0x181439010")]
			set
			{
			}
		}

		// Token: 0x17004048 RID: 16456
		// (get) Token: 0x0601B061 RID: 110689 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004048")]
		public string usageConsiderShort
		{
			[Token(Token = "0x601B061")]
			[Address(RVA = "0x1438E30", Offset = "0x1437A30", VA = "0x181438E30")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601B062 RID: 110690 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601B062")]
		[Address(RVA = "0x1438BE0", Offset = "0x14377E0", VA = "0x181438BE0")]
		private string _GetCompleteUsage(string oriUsage)
		{
			return null;
		}

		// Token: 0x04022B5E RID: 142174
		[Token(Token = "0x4022B5E")]
		[FieldOffset(Offset = "0x0")]
		public static readonly RoguelikeTopicItemModel EMPTY;

		// Token: 0x04022B5F RID: 142175
		[Token(Token = "0x4022B5F")]
		[FieldOffset(Offset = "0x0")]
		private string m_usage;

		// Token: 0x04022B60 RID: 142176
		[Token(Token = "0x4022B60")]
		[FieldOffset(Offset = "0x8")]
		private string m_shortUsage;

		// Token: 0x04022B61 RID: 142177
		[Token(Token = "0x4022B61")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x04022B62 RID: 142178
		[Token(Token = "0x4022B62")]
		[FieldOffset(Offset = "0x18")]
		public string name;

		// Token: 0x04022B63 RID: 142179
		[Token(Token = "0x4022B63")]
		[FieldOffset(Offset = "0x20")]
		public string description;

		// Token: 0x04022B64 RID: 142180
		[Token(Token = "0x4022B64")]
		[FieldOffset(Offset = "0x28")]
		public string iconId;

		// Token: 0x04022B65 RID: 142181
		[Token(Token = "0x4022B65")]
		[FieldOffset(Offset = "0x30")]
		public RoguelikeGameItemType type;

		// Token: 0x04022B66 RID: 142182
		[Token(Token = "0x4022B66")]
		[FieldOffset(Offset = "0x34")]
		public RoguelikeGameItemSubType subType;

		// Token: 0x04022B67 RID: 142183
		[Token(Token = "0x4022B67")]
		[FieldOffset(Offset = "0x38")]
		public RoguelikeGameItemRarity rarity;

		// Token: 0x04022B68 RID: 142184
		[Token(Token = "0x4022B68")]
		[FieldOffset(Offset = "0x3C")]
		public bool canSacrifice;

		// Token: 0x04022B69 RID: 142185
		[Token(Token = "0x4022B69")]
		[FieldOffset(Offset = "0x40")]
		public string trapDesc;

		// Token: 0x04022B6A RID: 142186
		[Token(Token = "0x4022B6A")]
		[FieldOffset(Offset = "0x48")]
		public string trapId;

		// Token: 0x04022B6B RID: 142187
		[Token(Token = "0x4022B6B")]
		[FieldOffset(Offset = "0x50")]
		public string innerColor;

		// Token: 0x04022B6C RID: 142188
		[Token(Token = "0x4022B6C")]
		[FieldOffset(Offset = "0x58")]
		public string unlockCondDesc;

		// Token: 0x04022B6D RID: 142189
		[Token(Token = "0x4022B6D")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_IsEmpty;

		// Token: 0x04022B6E RID: 142190
		[Token(Token = "0x4022B6E")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_get_usage;

		// Token: 0x04022B6F RID: 142191
		[Token(Token = "0x4022B6F")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_set_usage;

		// Token: 0x04022B70 RID: 142192
		[Token(Token = "0x4022B70")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_get_archiveUsage;

		// Token: 0x04022B71 RID: 142193
		[Token(Token = "0x4022B71")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_set_shortUsage;

		// Token: 0x04022B72 RID: 142194
		[Token(Token = "0x4022B72")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_get_usageConsiderShort;

		// Token: 0x04022B73 RID: 142195
		[Token(Token = "0x4022B73")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__GetCompleteUsage;
	}
}
