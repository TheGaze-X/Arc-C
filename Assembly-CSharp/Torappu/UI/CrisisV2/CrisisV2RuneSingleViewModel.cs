using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.CrisisV2
{
	// Token: 0x0200597C RID: 22908
	[Token(Token = "0x200597C")]
	public abstract class CrisisV2RuneSingleViewModel : CrisisV2RuneBaseViewModel, IComparable<CrisisV2RuneSingleViewModel>
	{
		// Token: 0x06021666 RID: 136806 RVA: 0x000BA168 File Offset: 0x000B8368
		[Token(Token = "0x6021666")]
		[Address(RVA = "0x1BCE850", Offset = "0x1BCD450", VA = "0x181BCE850", Slot = "9")]
		public virtual CrisisV2RuneSingleViewModel.SingleViewInfoType GetViewType()
		{
			return CrisisV2RuneSingleViewModel.SingleViewInfoType.NONE;
		}

		// Token: 0x06021667 RID: 136807 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021667")]
		[Address(RVA = "0x1BCF230", Offset = "0x1BCDE30", VA = "0x181BCF230", Slot = "10")]
		public virtual string GetItemId()
		{
			return null;
		}

		// Token: 0x06021668 RID: 136808 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021668")]
		[Address(RVA = "0x1BCF160", Offset = "0x1BCDD60", VA = "0x181BCF160", Slot = "11")]
		public virtual string GetBagId()
		{
			return null;
		}

		// Token: 0x06021669 RID: 136809 RVA: 0x000BA180 File Offset: 0x000B8380
		[Token(Token = "0x6021669")]
		[Address(RVA = "0x1BCE7F0", Offset = "0x1BCD3F0", VA = "0x181BCE7F0", Slot = "12")]
		public virtual int GetUniqueSortId()
		{
			return 0;
		}

		// Token: 0x0602166A RID: 136810 RVA: 0x000BA198 File Offset: 0x000B8398
		[Token(Token = "0x602166A")]
		[Address(RVA = "0x1BCF1D0", Offset = "0x1BCDDD0", VA = "0x181BCF1D0", Slot = "5")]
		public override CrisisV2RuneBaseViewModel.ViewType GetDetailViewType()
		{
			return CrisisV2RuneBaseViewModel.ViewType.NONE;
		}

		// Token: 0x0602166B RID: 136811 RVA: 0x000BA1B0 File Offset: 0x000B83B0
		[Token(Token = "0x602166B")]
		[Address(RVA = "0x1BCF010", Offset = "0x1BCDC10", VA = "0x181BCF010", Slot = "8")]
		public int CompareTo(CrisisV2RuneSingleViewModel other)
		{
			return 0;
		}

		// Token: 0x0602166C RID: 136812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602166C")]
		[Address(RVA = "0x1BCF2A0", Offset = "0x1BCDEA0", VA = "0x181BCF2A0")]
		protected CrisisV2RuneSingleViewModel()
		{
		}

		// Token: 0x0602166D RID: 136813 RVA: 0x000BA1C8 File Offset: 0x000B83C8
		[Token(Token = "0x602166D")]
		[Address(RVA = "0x1BCB6D0", Offset = "0x1BCA2D0", VA = "0x181BCB6D0")]
		private CrisisV2RuneBaseViewModel.ViewType <>xLuaBaseProxy_GetDetailViewType()
		{
			return CrisisV2RuneBaseViewModel.ViewType.NONE;
		}

		// Token: 0x0402D8EB RID: 186603
		[Token(Token = "0x402D8EB")]
		[FieldOffset(Offset = "0x18")]
		protected int BAG_START_SORT_INDEX;

		// Token: 0x0402D8EC RID: 186604
		[Token(Token = "0x402D8EC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetViewType;

		// Token: 0x0402D8ED RID: 186605
		[Token(Token = "0x402D8ED")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetItemId;

		// Token: 0x0402D8EE RID: 186606
		[Token(Token = "0x402D8EE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetBagId;

		// Token: 0x0402D8EF RID: 186607
		[Token(Token = "0x402D8EF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetUniqueSortId;

		// Token: 0x0402D8F0 RID: 186608
		[Token(Token = "0x402D8F0")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetDetailViewType;

		// Token: 0x0402D8F1 RID: 186609
		[Token(Token = "0x402D8F1")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_CompareTo;

		// Token: 0x0402D8F2 RID: 186610
		[Token(Token = "0x402D8F2")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200597D RID: 22909
		[Token(Token = "0x200597D")]
		public enum SingleViewInfoType
		{
			// Token: 0x0402D8F4 RID: 186612
			[Token(Token = "0x402D8F4")]
			NONE,
			// Token: 0x0402D8F5 RID: 186613
			[Token(Token = "0x402D8F5")]
			TITLE,
			// Token: 0x0402D8F6 RID: 186614
			[Token(Token = "0x402D8F6")]
			ITEM
		}
	}
}
