using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ItemRepo
{
	// Token: 0x02005E87 RID: 24199
	[Token(Token = "0x2005E87")]
	public class ItemRepoVoucherSkillViewModel : IHotfixable
	{
		// Token: 0x17005319 RID: 21273
		// (get) Token: 0x0602311A RID: 143642 RVA: 0x000BFDF0 File Offset: 0x000BDFF0
		// (set) Token: 0x0602311B RID: 143643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005319")]
		public int selectedIdx
		{
			[Token(Token = "0x602311A")]
			[Address(RVA = "0x1DA5180", Offset = "0x1DA3D80", VA = "0x181DA5180")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x602311B")]
			[Address(RVA = "0x1DA51E0", Offset = "0x1DA3DE0", VA = "0x181DA51E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0602311C RID: 143644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602311C")]
		[Address(RVA = "0x1DA4F40", Offset = "0x1DA3B40", VA = "0x181DA4F40")]
		public void LoadData(PlayerCharacter playerChar, CharacterData charData, UIItemViewModel itemModel)
		{
		}

		// Token: 0x0602311D RID: 143645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602311D")]
		[Address(RVA = "0x1DA5000", Offset = "0x1DA3C00", VA = "0x181DA5000")]
		public void SetChooseState(int idx)
		{
		}

		// Token: 0x0602311E RID: 143646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602311E")]
		[Address(RVA = "0x1DA50A0", Offset = "0x1DA3CA0", VA = "0x181DA50A0")]
		public ItemRepoVoucherSkillViewModel()
		{
		}

		// Token: 0x040304BC RID: 197820
		[Token(Token = "0x40304BC")]
		[FieldOffset(Offset = "0x10")]
		public SkillGroupViewModel skillGroupViewModel;

		// Token: 0x040304BD RID: 197821
		[Token(Token = "0x40304BD")]
		[FieldOffset(Offset = "0x18")]
		public UIItemViewModel voucherItemViewModel;

		// Token: 0x040304BF RID: 197823
		[Token(Token = "0x40304BF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_selectedIdx;

		// Token: 0x040304C0 RID: 197824
		[Token(Token = "0x40304C0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_selectedIdx;

		// Token: 0x040304C1 RID: 197825
		[Token(Token = "0x40304C1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x040304C2 RID: 197826
		[Token(Token = "0x40304C2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SetChooseState;

		// Token: 0x040304C3 RID: 197827
		[Token(Token = "0x40304C3")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
