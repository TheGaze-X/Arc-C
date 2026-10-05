using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.TemplateCharSelect.Common
{
	// Token: 0x02005C11 RID: 23569
	[Token(Token = "0x2005C11")]
	public class CommonCharSelectShuffleDefaultViewModel : TemplateShuffleViewModelBase<TemplateCharSelectCardViewModel>
	{
		// Token: 0x1700501C RID: 20508
		// (get) Token: 0x060222BB RID: 139963 RVA: 0x000BC838 File Offset: 0x000BAA38
		[Token(Token = "0x1700501C")]
		public override CharacterSortType sortType
		{
			[Token(Token = "0x60222BB")]
			[Address(RVA = "0x1CAF7F0", Offset = "0x1CAE3F0", VA = "0x181CAF7F0", Slot = "4")]
			get
			{
				return CharacterSortType.BY_LEVEL_UP;
			}
		}

		// Token: 0x1700501D RID: 20509
		// (get) Token: 0x060222BC RID: 139964 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700501D")]
		public override CharacterProfessionFilterViewModel profFilter
		{
			[Token(Token = "0x60222BC")]
			[Address(RVA = "0x1CAF730", Offset = "0x1CAE330", VA = "0x181CAF730", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700501E RID: 20510
		// (get) Token: 0x060222BD RID: 139965 RVA: 0x000BC850 File Offset: 0x000BAA50
		[Token(Token = "0x1700501E")]
		public int resetSeq
		{
			[Token(Token = "0x60222BD")]
			[Address(RVA = "0x1CAF790", Offset = "0x1CAE390", VA = "0x181CAF790")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060222BE RID: 139966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60222BE")]
		[Address(RVA = "0x1CAF130", Offset = "0x1CADD30", VA = "0x181CAF130", Slot = "7")]
		public override void OnReset(TemplateCharSelectModelResetData data)
		{
		}

		// Token: 0x060222BF RID: 139967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60222BF")]
		[Address(RVA = "0x1CAF570", Offset = "0x1CAE170", VA = "0x181CAF570")]
		public void UpdateFilter(UICharacterProfessionFilterHolder.FilterParam filterParam)
		{
		}

		// Token: 0x060222C0 RID: 139968 RVA: 0x000BC868 File Offset: 0x000BAA68
		[Token(Token = "0x60222C0")]
		[Address(RVA = "0x1CAF1F0", Offset = "0x1CADDF0", VA = "0x181CAF1F0", Slot = "10")]
		protected override int OnSortChar(TemplateCharSelectCardViewModel a, TemplateCharSelectCardViewModel b)
		{
			return 0;
		}

		// Token: 0x060222C1 RID: 139969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60222C1")]
		[Address(RVA = "0x1CAF620", Offset = "0x1CAE220", VA = "0x181CAF620")]
		public CommonCharSelectShuffleDefaultViewModel()
		{
		}

		// Token: 0x060222C2 RID: 139970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60222C2")]
		[Address(RVA = "0x1CAF540", Offset = "0x1CAE140", VA = "0x181CAF540")]
		private void <>xLuaBaseProxy_OnReset(TemplateCharSelectModelResetData P0)
		{
		}

		// Token: 0x0402EDCB RID: 191947
		[Token(Token = "0x402EDCB")]
		[FieldOffset(Offset = "0x10")]
		private int m_resetSeq;

		// Token: 0x0402EDCC RID: 191948
		[Token(Token = "0x402EDCC")]
		[FieldOffset(Offset = "0x18")]
		public CharacterProfessionFilterViewModel filter;

		// Token: 0x0402EDCD RID: 191949
		[Token(Token = "0x402EDCD")]
		[FieldOffset(Offset = "0x20")]
		public CharacterCardSortTypeViewModel sort;

		// Token: 0x0402EDCE RID: 191950
		[Token(Token = "0x402EDCE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_sortType;

		// Token: 0x0402EDCF RID: 191951
		[Token(Token = "0x402EDCF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_profFilter;

		// Token: 0x0402EDD0 RID: 191952
		[Token(Token = "0x402EDD0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_resetSeq;

		// Token: 0x0402EDD1 RID: 191953
		[Token(Token = "0x402EDD1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnReset;

		// Token: 0x0402EDD2 RID: 191954
		[Token(Token = "0x402EDD2")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_UpdateFilter;

		// Token: 0x0402EDD3 RID: 191955
		[Token(Token = "0x402EDD3")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnSortChar;

		// Token: 0x0402EDD4 RID: 191956
		[Token(Token = "0x402EDD4")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
