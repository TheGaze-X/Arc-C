using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Recruit
{
	// Token: 0x02004714 RID: 18196
	[Token(Token = "0x2004714")]
	public class RecruitUpCharSlotSelectViewModel : IHotfixable
	{
		// Token: 0x0601B958 RID: 112984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B958")]
		[Address(RVA = "0x14EEE00", Offset = "0x14EDA00", VA = "0x1814EEE00")]
		public void InitData()
		{
		}

		// Token: 0x0601B959 RID: 112985 RVA: 0x000A59A8 File Offset: 0x000A3BA8
		[Token(Token = "0x601B959")]
		[Address(RVA = "0x14EEFC0", Offset = "0x14EDBC0", VA = "0x1814EEFC0")]
		public bool IsCharSelectCompleted()
		{
			return default(bool);
		}

		// Token: 0x0601B95A RID: 112986 RVA: 0x000A59C0 File Offset: 0x000A3BC0
		[Token(Token = "0x601B95A")]
		[Address(RVA = "0x14EECD0", Offset = "0x14ED8D0", VA = "0x1814EECD0")]
		public int GetCardDetailDataCount()
		{
			return 0;
		}

		// Token: 0x0601B95B RID: 112987 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601B95B")]
		[Address(RVA = "0x14EED40", Offset = "0x14ED940", VA = "0x1814EED40")]
		public RecruitUpCharSlotSelectViewModel.RecruitCharSlotCardDetail GetCharCardDetailWithIndex(int index)
		{
			return null;
		}

		// Token: 0x0601B95C RID: 112988 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601B95C")]
		[Address(RVA = "0x14EEAB0", Offset = "0x14ED6B0", VA = "0x1814EEAB0")]
		public Dictionary<int, List<string>> GeneRarityCharsDict()
		{
			return null;
		}

		// Token: 0x0601B95D RID: 112989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B95D")]
		[Address(RVA = "0x14EF0D0", Offset = "0x14EDCD0", VA = "0x1814EF0D0")]
		public void SetCardSelectChar(int index, string charId)
		{
		}

		// Token: 0x0601B95E RID: 112990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B95E")]
		[Address(RVA = "0x14EF240", Offset = "0x14EDE40", VA = "0x1814EF240")]
		public RecruitUpCharSlotSelectViewModel()
		{
		}

		// Token: 0x04023BBC RID: 146364
		[Token(Token = "0x4023BBC")]
		private const int COUNT_RARITY_SIX = 2;

		// Token: 0x04023BBD RID: 146365
		[Token(Token = "0x4023BBD")]
		private const int COUNT_RARITY_FIVE = 3;

		// Token: 0x04023BBE RID: 146366
		[Token(Token = "0x4023BBE")]
		private const int INDEX_WITHIN_SHOP = 0;

		// Token: 0x04023BBF RID: 146367
		[Token(Token = "0x4023BBF")]
		[FieldOffset(Offset = "0x10")]
		private List<RecruitUpCharSlotSelectViewModel.RecruitCharSlotCardDetail> m_charSlotCardDetails;

		// Token: 0x04023BC0 RID: 146368
		[Token(Token = "0x4023BC0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x04023BC1 RID: 146369
		[Token(Token = "0x4023BC1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_IsCharSelectCompleted;

		// Token: 0x04023BC2 RID: 146370
		[Token(Token = "0x4023BC2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetCardDetailDataCount;

		// Token: 0x04023BC3 RID: 146371
		[Token(Token = "0x4023BC3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetCharCardDetailWithIndex;

		// Token: 0x04023BC4 RID: 146372
		[Token(Token = "0x4023BC4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GeneRarityCharsDict;

		// Token: 0x04023BC5 RID: 146373
		[Token(Token = "0x4023BC5")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_SetCardSelectChar;

		// Token: 0x04023BC6 RID: 146374
		[Token(Token = "0x4023BC6")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004715 RID: 18197
		[Token(Token = "0x2004715")]
		public class RecruitCharSlotCardDetail
		{
			// Token: 0x0601B95F RID: 112991 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B95F")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public RecruitCharSlotCardDetail()
			{
			}

			// Token: 0x04023BC7 RID: 146375
			[Token(Token = "0x4023BC7")]
			[FieldOffset(Offset = "0x10")]
			public string charId;

			// Token: 0x04023BC8 RID: 146376
			[Token(Token = "0x4023BC8")]
			[FieldOffset(Offset = "0x18")]
			public RarityRank rarityRank;

			// Token: 0x04023BC9 RID: 146377
			[Token(Token = "0x4023BC9")]
			[FieldOffset(Offset = "0x1C")]
			public bool withinShop;
		}
	}
}
