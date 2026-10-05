using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.TemplateCharSelect.Common
{
	// Token: 0x02005C1D RID: 23581
	[Token(Token = "0x2005C1D")]
	public class CommonCharSelectShuffleViewModel : TemplateShuffleViewModelBase<TemplateCharSelectCardViewModel>
	{
		// Token: 0x06022307 RID: 140039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022307")]
		[Address(RVA = "0x1CB0740", Offset = "0x1CAF340", VA = "0x181CB0740", Slot = "7")]
		public override void OnReset(TemplateCharSelectModelResetData data)
		{
		}

		// Token: 0x17005032 RID: 20530
		// (get) Token: 0x06022308 RID: 140040 RVA: 0x000BC940 File Offset: 0x000BAB40
		[Token(Token = "0x17005032")]
		public override CharacterSortType sortType
		{
			[Token(Token = "0x6022308")]
			[Address(RVA = "0x1CB0B30", Offset = "0x1CAF730", VA = "0x181CB0B30", Slot = "4")]
			get
			{
				return CharacterSortType.BY_LEVEL_UP;
			}
		}

		// Token: 0x06022309 RID: 140041 RVA: 0x000BC958 File Offset: 0x000BAB58
		[Token(Token = "0x6022309")]
		[Address(RVA = "0x1CB0920", Offset = "0x1CAF520", VA = "0x181CB0920")]
		public bool SetSortType(CharacterSortType st)
		{
			return default(bool);
		}

		// Token: 0x17005033 RID: 20531
		// (get) Token: 0x0602230A RID: 140042 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005033")]
		public override CharacterProfessionFilterViewModel profFilter
		{
			[Token(Token = "0x602230A")]
			[Address(RVA = "0x1CB0A70", Offset = "0x1CAF670", VA = "0x181CB0A70", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602230B RID: 140043 RVA: 0x000BC970 File Offset: 0x000BAB70
		[Token(Token = "0x602230B")]
		[Address(RVA = "0x1CB0890", Offset = "0x1CAF490", VA = "0x181CB0890")]
		public bool SetProfFilter(ProfessionCategory profFilter)
		{
			return default(bool);
		}

		// Token: 0x17005034 RID: 20532
		// (get) Token: 0x0602230C RID: 140044 RVA: 0x000BC988 File Offset: 0x000BAB88
		[Token(Token = "0x17005034")]
		public bool showFilterPanel
		{
			[Token(Token = "0x602230C")]
			[Address(RVA = "0x1CB0AD0", Offset = "0x1CAF6D0", VA = "0x181CB0AD0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0602230D RID: 140045 RVA: 0x000BC9A0 File Offset: 0x000BABA0
		[Token(Token = "0x602230D")]
		[Address(RVA = "0x1CB0810", Offset = "0x1CAF410", VA = "0x181CB0810")]
		public bool SetFilterPanelVisible(bool v)
		{
			return default(bool);
		}

		// Token: 0x0602230E RID: 140046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602230E")]
		[Address(RVA = "0x1CB09A0", Offset = "0x1CAF5A0", VA = "0x181CB09A0")]
		public CommonCharSelectShuffleViewModel()
		{
		}

		// Token: 0x0602230F RID: 140047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602230F")]
		[Address(RVA = "0x1CAF540", Offset = "0x1CAE140", VA = "0x181CAF540")]
		private void <>xLuaBaseProxy_OnReset(TemplateCharSelectModelResetData P0)
		{
		}

		// Token: 0x0402EE55 RID: 192085
		[Token(Token = "0x402EE55")]
		[FieldOffset(Offset = "0x10")]
		private CharacterSortType m_sortType;

		// Token: 0x0402EE56 RID: 192086
		[Token(Token = "0x402EE56")]
		[FieldOffset(Offset = "0x18")]
		private CharacterProfessionFilterViewModel m_profFilter;

		// Token: 0x0402EE57 RID: 192087
		[Token(Token = "0x402EE57")]
		[FieldOffset(Offset = "0x20")]
		private bool m_showFilterPanel;

		// Token: 0x0402EE58 RID: 192088
		[Token(Token = "0x402EE58")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnReset;

		// Token: 0x0402EE59 RID: 192089
		[Token(Token = "0x402EE59")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_sortType;

		// Token: 0x0402EE5A RID: 192090
		[Token(Token = "0x402EE5A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetSortType;

		// Token: 0x0402EE5B RID: 192091
		[Token(Token = "0x402EE5B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_profFilter;

		// Token: 0x0402EE5C RID: 192092
		[Token(Token = "0x402EE5C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_SetProfFilter;

		// Token: 0x0402EE5D RID: 192093
		[Token(Token = "0x402EE5D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_showFilterPanel;

		// Token: 0x0402EE5E RID: 192094
		[Token(Token = "0x402EE5E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_SetFilterPanelVisible;

		// Token: 0x0402EE5F RID: 192095
		[Token(Token = "0x402EE5F")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
