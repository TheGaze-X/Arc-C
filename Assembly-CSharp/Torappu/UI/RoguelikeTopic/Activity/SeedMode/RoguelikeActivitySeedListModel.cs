using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.RoguelikeTopic.Activity.SeedMode
{
	// Token: 0x020046A9 RID: 18089
	[Token(Token = "0x20046A9")]
	public class RoguelikeActivitySeedListModel : IHotfixable
	{
		// Token: 0x1700414E RID: 16718
		// (get) Token: 0x0601B710 RID: 112400 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700414E")]
		public List<RoguelikeActivitySeedItemModel> curSeedItemModelList
		{
			[Token(Token = "0x601B710")]
			[Address(RVA = "0x14D5DA0", Offset = "0x14D49A0", VA = "0x1814D5DA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601B711 RID: 112401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B711")]
		[Address(RVA = "0x14D52C0", Offset = "0x14D3EC0", VA = "0x1814D52C0")]
		public void LoadData(string inputTopicId, string inputRlActId)
		{
		}

		// Token: 0x0601B712 RID: 112402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B712")]
		[Address(RVA = "0x14D5670", Offset = "0x14D4270", VA = "0x1814D5670")]
		private void _LoadHistory()
		{
		}

		// Token: 0x0601B713 RID: 112403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B713")]
		[Address(RVA = "0x14D59A0", Offset = "0x14D45A0", VA = "0x1814D59A0")]
		private void _LoadPredefine(RoguelikeActivitySeedModeData seedModeData)
		{
		}

		// Token: 0x0601B714 RID: 112404 RVA: 0x000A52D0 File Offset: 0x000A34D0
		[Token(Token = "0x601B714")]
		[Address(RVA = "0x14D51B0", Offset = "0x14D3DB0", VA = "0x1814D51B0")]
		public bool CheckIsCurEnableSeed()
		{
			return default(bool);
		}

		// Token: 0x0601B715 RID: 112405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B715")]
		[Address(RVA = "0x14D55F0", Offset = "0x14D41F0", VA = "0x1814D55F0")]
		public void SwitchTagType(SeedItemType type)
		{
		}

		// Token: 0x0601B716 RID: 112406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B716")]
		[Address(RVA = "0x14D5CB0", Offset = "0x14D48B0", VA = "0x1814D5CB0")]
		public RoguelikeActivitySeedListModel()
		{
		}

		// Token: 0x04023830 RID: 145456
		[Token(Token = "0x4023830")]
		[FieldOffset(Offset = "0x10")]
		private List<RoguelikeActivitySeedItemModel> m_historySeedItemModelList;

		// Token: 0x04023831 RID: 145457
		[Token(Token = "0x4023831")]
		[FieldOffset(Offset = "0x18")]
		private List<RoguelikeActivitySeedItemModel> m_predefineSeedItemModelList;

		// Token: 0x04023832 RID: 145458
		[Token(Token = "0x4023832")]
		[FieldOffset(Offset = "0x20")]
		private int m_itemCnt;

		// Token: 0x04023833 RID: 145459
		[Token(Token = "0x4023833")]
		[FieldOffset(Offset = "0x28")]
		public string topicId;

		// Token: 0x04023834 RID: 145460
		[Token(Token = "0x4023834")]
		[FieldOffset(Offset = "0x30")]
		public string rlActId;

		// Token: 0x04023835 RID: 145461
		[Token(Token = "0x4023835")]
		[FieldOffset(Offset = "0x38")]
		public SeedItemType curTagType;

		// Token: 0x04023836 RID: 145462
		[Token(Token = "0x4023836")]
		[FieldOffset(Offset = "0x40")]
		public RoguelikeActivitySeedModeData.RoguelikeActivitySeedModeConstData constData;

		// Token: 0x04023837 RID: 145463
		[Token(Token = "0x4023837")]
		[FieldOffset(Offset = "0x48")]
		public bool isPlaying;

		// Token: 0x04023838 RID: 145464
		[Token(Token = "0x4023838")]
		[FieldOffset(Offset = "0x50")]
		public string copySeedFormat;

		// Token: 0x04023839 RID: 145465
		[Token(Token = "0x4023839")]
		[FieldOffset(Offset = "0x58")]
		public string copySucceededTextHint;

		// Token: 0x0402383A RID: 145466
		[Token(Token = "0x402383A")]
		[FieldOffset(Offset = "0x60")]
		public int switchTagSequenceNum;

		// Token: 0x0402383B RID: 145467
		[Token(Token = "0x402383B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_curSeedItemModelList;

		// Token: 0x0402383C RID: 145468
		[Token(Token = "0x402383C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402383D RID: 145469
		[Token(Token = "0x402383D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__LoadHistory;

		// Token: 0x0402383E RID: 145470
		[Token(Token = "0x402383E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__LoadPredefine;

		// Token: 0x0402383F RID: 145471
		[Token(Token = "0x402383F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_CheckIsCurEnableSeed;

		// Token: 0x04023840 RID: 145472
		[Token(Token = "0x4023840")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_SwitchTagType;

		// Token: 0x04023841 RID: 145473
		[Token(Token = "0x4023841")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
