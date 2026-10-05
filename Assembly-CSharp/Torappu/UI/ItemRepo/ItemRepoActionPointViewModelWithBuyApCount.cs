using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ItemRepo
{
	// Token: 0x02005E92 RID: 24210
	[Token(Token = "0x2005E92")]
	public class ItemRepoActionPointViewModelWithBuyApCount : ActionPointViewModel, IHotfixable
	{
		// Token: 0x1700531B RID: 21275
		// (get) Token: 0x0602313A RID: 143674 RVA: 0x000BFE08 File Offset: 0x000BE008
		// (set) Token: 0x0602313B RID: 143675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700531B")]
		public int buyAPCount
		{
			[Token(Token = "0x602313A")]
			[Address(RVA = "0x1D8F300", Offset = "0x1D8DF00", VA = "0x181D8F300")]
			get
			{
				return 0;
			}
			[Token(Token = "0x602313B")]
			[Address(RVA = "0x1D8F400", Offset = "0x1D8E000", VA = "0x181D8F400")]
			set
			{
			}
		}

		// Token: 0x1700531C RID: 21276
		// (get) Token: 0x0602313C RID: 143676 RVA: 0x000BFE20 File Offset: 0x000BE020
		// (set) Token: 0x0602313D RID: 143677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700531C")]
		public bool blockApCountRefresh
		{
			[Token(Token = "0x602313C")]
			[Address(RVA = "0x1D8F2A0", Offset = "0x1D8DEA0", VA = "0x181D8F2A0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x602313D")]
			[Address(RVA = "0x1D8F360", Offset = "0x1D8DF60", VA = "0x181D8F360")]
			set
			{
			}
		}

		// Token: 0x0602313E RID: 143678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602313E")]
		[Address(RVA = "0x1D8F0E0", Offset = "0x1D8DCE0", VA = "0x181D8F0E0", Slot = "15")]
		protected override void UpdateApInfo()
		{
		}

		// Token: 0x0602313F RID: 143679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602313F")]
		[Address(RVA = "0x1D8F200", Offset = "0x1D8DE00", VA = "0x181D8F200")]
		public ItemRepoActionPointViewModelWithBuyApCount()
		{
		}

		// Token: 0x06023140 RID: 143680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023140")]
		[Address(RVA = "0x1D8F0D0", Offset = "0x1D8DCD0", VA = "0x181D8F0D0")]
		private void <>xLuaBaseProxy_UpdateApInfo()
		{
		}

		// Token: 0x040304FD RID: 197885
		[Token(Token = "0x40304FD")]
		[FieldOffset(Offset = "0x50")]
		public IntProperty afterBuyProperty;

		// Token: 0x040304FE RID: 197886
		[Token(Token = "0x40304FE")]
		[FieldOffset(Offset = "0x58")]
		private int m_buyAPCount;

		// Token: 0x040304FF RID: 197887
		[Token(Token = "0x40304FF")]
		[FieldOffset(Offset = "0x5C")]
		private bool m_blockApCountRefresh;

		// Token: 0x04030500 RID: 197888
		[Token(Token = "0x4030500")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_buyAPCount;

		// Token: 0x04030501 RID: 197889
		[Token(Token = "0x4030501")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_buyAPCount;

		// Token: 0x04030502 RID: 197890
		[Token(Token = "0x4030502")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_blockApCountRefresh;

		// Token: 0x04030503 RID: 197891
		[Token(Token = "0x4030503")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_blockApCountRefresh;

		// Token: 0x04030504 RID: 197892
		[Token(Token = "0x4030504")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_UpdateApInfo;

		// Token: 0x04030505 RID: 197893
		[Token(Token = "0x4030505")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
