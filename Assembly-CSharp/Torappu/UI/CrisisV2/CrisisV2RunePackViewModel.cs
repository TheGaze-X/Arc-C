using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.CrisisV2
{
	// Token: 0x02005982 RID: 22914
	[Token(Token = "0x2005982")]
	public class CrisisV2RunePackViewModel : CrisisV2RuneBaseViewModel, IComparable<CrisisV2RunePackViewModel>
	{
		// Token: 0x17004E9A RID: 20122
		// (get) Token: 0x06021692 RID: 136850 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004E9A")]
		public string bagId
		{
			[Token(Token = "0x6021692")]
			[Address(RVA = "0x1BCE180", Offset = "0x1BCCD80", VA = "0x181BCE180")]
			get
			{
				return null;
			}
		}

		// Token: 0x06021693 RID: 136851 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021693")]
		[Address(RVA = "0x1BCDEE0", Offset = "0x1BCCAE0", VA = "0x181BCDEE0", Slot = "4")]
		public override string GetGlobalId()
		{
			return null;
		}

		// Token: 0x06021694 RID: 136852 RVA: 0x000BA2E8 File Offset: 0x000B84E8
		[Token(Token = "0x6021694")]
		[Address(RVA = "0x1BCDE80", Offset = "0x1BCCA80", VA = "0x181BCDE80", Slot = "5")]
		public override CrisisV2RuneBaseViewModel.ViewType GetDetailViewType()
		{
			return CrisisV2RuneBaseViewModel.ViewType.NONE;
		}

		// Token: 0x06021695 RID: 136853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021695")]
		[Address(RVA = "0x1BCDF60", Offset = "0x1BCCB60", VA = "0x181BCDF60")]
		public void LoadData(string mapId, string bagId, int bagSortId)
		{
		}

		// Token: 0x06021696 RID: 136854 RVA: 0x000BA300 File Offset: 0x000B8500
		[Token(Token = "0x6021696")]
		[Address(RVA = "0x1BCDDE0", Offset = "0x1BCC9E0", VA = "0x181BCDDE0", Slot = "8")]
		public int CompareTo(CrisisV2RunePackViewModel other)
		{
			return 0;
		}

		// Token: 0x06021697 RID: 136855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021697")]
		[Address(RVA = "0x1BCE080", Offset = "0x1BCCC80", VA = "0x181BCE080")]
		public CrisisV2RunePackViewModel()
		{
		}

		// Token: 0x06021698 RID: 136856 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021698")]
		[Address(RVA = "0x1BCE010", Offset = "0x1BCCC10", VA = "0x181BCE010")]
		private string <>xLuaBaseProxy_GetGlobalId()
		{
			return null;
		}

		// Token: 0x06021699 RID: 136857 RVA: 0x000BA318 File Offset: 0x000B8518
		[Token(Token = "0x6021699")]
		[Address(RVA = "0x1BCB6D0", Offset = "0x1BCA2D0", VA = "0x181BCB6D0")]
		private CrisisV2RuneBaseViewModel.ViewType <>xLuaBaseProxy_GetDetailViewType()
		{
			return CrisisV2RuneBaseViewModel.ViewType.NONE;
		}

		// Token: 0x0402D920 RID: 186656
		[Token(Token = "0x402D920")]
		[FieldOffset(Offset = "0x18")]
		public List<CrisisV2RuneMergedSingleItemViewModel> runeItemViewModels;

		// Token: 0x0402D921 RID: 186657
		[Token(Token = "0x402D921")]
		[FieldOffset(Offset = "0x20")]
		private string m_mapId;

		// Token: 0x0402D922 RID: 186658
		[Token(Token = "0x402D922")]
		[FieldOffset(Offset = "0x28")]
		private string m_bagId;

		// Token: 0x0402D923 RID: 186659
		[Token(Token = "0x402D923")]
		[FieldOffset(Offset = "0x30")]
		private int m_bagSortId;

		// Token: 0x0402D924 RID: 186660
		[Token(Token = "0x402D924")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_bagId;

		// Token: 0x0402D925 RID: 186661
		[Token(Token = "0x402D925")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetGlobalId;

		// Token: 0x0402D926 RID: 186662
		[Token(Token = "0x402D926")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetDetailViewType;

		// Token: 0x0402D927 RID: 186663
		[Token(Token = "0x402D927")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402D928 RID: 186664
		[Token(Token = "0x402D928")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_CompareTo;

		// Token: 0x0402D929 RID: 186665
		[Token(Token = "0x402D929")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
