using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.CrisisV2
{
	// Token: 0x02005980 RID: 22912
	[Token(Token = "0x2005980")]
	public class CrisisV2RuneSingleItemViewModel : CrisisV2RuneSingleViewModel, ICrisisV2RuneSingleItemInfo, IHotfixable
	{
		// Token: 0x06021671 RID: 136817 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021671")]
		[Address(RVA = "0x1BCE2A0", Offset = "0x1BCCEA0", VA = "0x181BCE2A0", Slot = "4")]
		public override string GetGlobalId()
		{
			return null;
		}

		// Token: 0x06021672 RID: 136818 RVA: 0x000BA1E0 File Offset: 0x000B83E0
		[Token(Token = "0x6021672")]
		[Address(RVA = "0x1BCE4A0", Offset = "0x1BCD0A0", VA = "0x181BCE4A0", Slot = "9")]
		public override CrisisV2RuneSingleViewModel.SingleViewInfoType GetViewType()
		{
			return CrisisV2RuneSingleViewModel.SingleViewInfoType.NONE;
		}

		// Token: 0x06021673 RID: 136819 RVA: 0x000BA1F8 File Offset: 0x000B83F8
		[Token(Token = "0x6021673")]
		[Address(RVA = "0x1BCE440", Offset = "0x1BCD040", VA = "0x181BCE440", Slot = "12")]
		public override int GetUniqueSortId()
		{
			return 0;
		}

		// Token: 0x06021674 RID: 136820 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021674")]
		[Address(RVA = "0x1BCE320", Offset = "0x1BCCF20", VA = "0x181BCE320", Slot = "10")]
		public override string GetItemId()
		{
			return null;
		}

		// Token: 0x06021675 RID: 136821 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021675")]
		[Address(RVA = "0x1BCE1E0", Offset = "0x1BCCDE0", VA = "0x181BCE1E0", Slot = "11")]
		public override string GetBagId()
		{
			return null;
		}

		// Token: 0x06021676 RID: 136822 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021676")]
		[Address(RVA = "0x1BCE240", Offset = "0x1BCCE40", VA = "0x181BCE240", Slot = "13")]
		public string GetDesc()
		{
			return null;
		}

		// Token: 0x06021677 RID: 136823 RVA: 0x000BA210 File Offset: 0x000B8410
		[Token(Token = "0x6021677")]
		[Address(RVA = "0x1BCE380", Offset = "0x1BCCF80", VA = "0x181BCE380", Slot = "14")]
		public int GetPoint()
		{
			return 0;
		}

		// Token: 0x06021678 RID: 136824 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021678")]
		[Address(RVA = "0x1BCE3E0", Offset = "0x1BCCFE0", VA = "0x181BCE3E0", Slot = "15")]
		public string GetTutorialHighLightKey()
		{
			return null;
		}

		// Token: 0x06021679 RID: 136825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021679")]
		[Address(RVA = "0x1BCE500", Offset = "0x1BCD100", VA = "0x181BCE500")]
		public void LoadData(string mapId, string nodeId, CrisisV2RuneData runeData, string slotPackId, CrisisV2MapDetailData mapDetailData, bool isHighLightRune)
		{
		}

		// Token: 0x0602167A RID: 136826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602167A")]
		[Address(RVA = "0x1BCE8B0", Offset = "0x1BCD4B0", VA = "0x181BCE8B0")]
		public CrisisV2RuneSingleItemViewModel()
		{
		}

		// Token: 0x0602167B RID: 136827 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602167B")]
		[Address(RVA = "0x1BCE010", Offset = "0x1BCCC10", VA = "0x181BCE010")]
		private string <>xLuaBaseProxy_GetGlobalId()
		{
			return null;
		}

		// Token: 0x0602167C RID: 136828 RVA: 0x000BA228 File Offset: 0x000B8428
		[Token(Token = "0x602167C")]
		[Address(RVA = "0x1BCE850", Offset = "0x1BCD450", VA = "0x181BCE850")]
		private CrisisV2RuneSingleViewModel.SingleViewInfoType <>xLuaBaseProxy_GetViewType()
		{
			return CrisisV2RuneSingleViewModel.SingleViewInfoType.NONE;
		}

		// Token: 0x0602167D RID: 136829 RVA: 0x000BA240 File Offset: 0x000B8440
		[Token(Token = "0x602167D")]
		[Address(RVA = "0x1BCE7F0", Offset = "0x1BCD3F0", VA = "0x181BCE7F0")]
		private int <>xLuaBaseProxy_GetUniqueSortId()
		{
			return 0;
		}

		// Token: 0x0602167E RID: 136830 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602167E")]
		[Address(RVA = "0x1BCE780", Offset = "0x1BCD380", VA = "0x181BCE780")]
		private string <>xLuaBaseProxy_GetItemId()
		{
			return null;
		}

		// Token: 0x0602167F RID: 136831 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602167F")]
		[Address(RVA = "0x1BCE710", Offset = "0x1BCD310", VA = "0x181BCE710")]
		private string <>xLuaBaseProxy_GetBagId()
		{
			return null;
		}

		// Token: 0x0402D8FC RID: 186620
		[Token(Token = "0x402D8FC")]
		[FieldOffset(Offset = "0x20")]
		private string m_mapId;

		// Token: 0x0402D8FD RID: 186621
		[Token(Token = "0x402D8FD")]
		[FieldOffset(Offset = "0x28")]
		private string m_bagId;

		// Token: 0x0402D8FE RID: 186622
		[Token(Token = "0x402D8FE")]
		[FieldOffset(Offset = "0x30")]
		private string m_nodeId;

		// Token: 0x0402D8FF RID: 186623
		[Token(Token = "0x402D8FF")]
		[FieldOffset(Offset = "0x38")]
		private string m_description;

		// Token: 0x0402D900 RID: 186624
		[Token(Token = "0x402D900")]
		[FieldOffset(Offset = "0x40")]
		private int m_point;

		// Token: 0x0402D901 RID: 186625
		[Token(Token = "0x402D901")]
		[FieldOffset(Offset = "0x44")]
		private int m_uniqueSortId;

		// Token: 0x0402D902 RID: 186626
		[Token(Token = "0x402D902")]
		[FieldOffset(Offset = "0x48")]
		private string m_tutorialHighLightKey;

		// Token: 0x0402D903 RID: 186627
		[Token(Token = "0x402D903")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetGlobalId;

		// Token: 0x0402D904 RID: 186628
		[Token(Token = "0x402D904")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetViewType;

		// Token: 0x0402D905 RID: 186629
		[Token(Token = "0x402D905")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetUniqueSortId;

		// Token: 0x0402D906 RID: 186630
		[Token(Token = "0x402D906")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetItemId;

		// Token: 0x0402D907 RID: 186631
		[Token(Token = "0x402D907")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetBagId;

		// Token: 0x0402D908 RID: 186632
		[Token(Token = "0x402D908")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetDesc;

		// Token: 0x0402D909 RID: 186633
		[Token(Token = "0x402D909")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetPoint;

		// Token: 0x0402D90A RID: 186634
		[Token(Token = "0x402D90A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetTutorialHighLightKey;

		// Token: 0x0402D90B RID: 186635
		[Token(Token = "0x402D90B")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402D90C RID: 186636
		[Token(Token = "0x402D90C")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
