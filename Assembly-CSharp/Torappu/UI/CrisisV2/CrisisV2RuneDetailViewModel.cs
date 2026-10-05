using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.CrisisV2
{
	// Token: 0x02005984 RID: 22916
	[Token(Token = "0x2005984")]
	public class CrisisV2RuneDetailViewModel : IHotfixable
	{
		// Token: 0x17004E9B RID: 20123
		// (get) Token: 0x060216A5 RID: 136869 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004E9B")]
		public List<CrisisV2RuneSingleViewModel> singleViewModels
		{
			[Token(Token = "0x60216A5")]
			[Address(RVA = "0x1BCCE80", Offset = "0x1BCBA80", VA = "0x181BCCE80")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004E9C RID: 20124
		// (get) Token: 0x060216A6 RID: 136870 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004E9C")]
		public List<CrisisV2RunePackViewModel> packViewModels
		{
			[Token(Token = "0x60216A6")]
			[Address(RVA = "0x1BCCE20", Offset = "0x1BCBA20", VA = "0x181BCCE20")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004E9D RID: 20125
		// (get) Token: 0x060216A7 RID: 136871 RVA: 0x000BA378 File Offset: 0x000B8578
		[Token(Token = "0x17004E9D")]
		public int focusSeq
		{
			[Token(Token = "0x60216A7")]
			[Address(RVA = "0x1BCCDC0", Offset = "0x1BCB9C0", VA = "0x181BCCDC0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060216A8 RID: 136872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60216A8")]
		[Address(RVA = "0x1BCBAB0", Offset = "0x1BCA6B0", VA = "0x181BCBAB0")]
		public void RefreshFocus(CrisisV2MapModel.ViewType viewType, CrisisV2MapModel.TargetType targetType, string targetId)
		{
		}

		// Token: 0x060216A9 RID: 136873 RVA: 0x000BA390 File Offset: 0x000B8590
		[Token(Token = "0x60216A9")]
		[Address(RVA = "0x1BCBA10", Offset = "0x1BCA610", VA = "0x181BCBA10")]
		public bool IsSlotNodeFocus(string nodeId)
		{
			return default(bool);
		}

		// Token: 0x060216AA RID: 136874 RVA: 0x000BA3A8 File Offset: 0x000B85A8
		[Token(Token = "0x60216AA")]
		[Address(RVA = "0x1BCB970", Offset = "0x1BCA570", VA = "0x181BCB970")]
		public bool IsSlotBagFocus(string bagId)
		{
			return default(bool);
		}

		// Token: 0x060216AB RID: 136875 RVA: 0x000BA3C0 File Offset: 0x000B85C0
		[Token(Token = "0x60216AB")]
		[Address(RVA = "0x1BCB8D0", Offset = "0x1BCA4D0", VA = "0x181BCB8D0")]
		public bool IsPackBagFocus(string bagId)
		{
			return default(bool);
		}

		// Token: 0x060216AC RID: 136876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60216AC")]
		[Address(RVA = "0x1BCC550", Offset = "0x1BCB150", VA = "0x181BCC550")]
		public void RefreshSlotRuneSingleViewList(HashSet<string> selectNodeSet, CrisisV2MapModel.ViewType viewType, string mapId, CrisisV2MapDetailData mapDetailData, bool curMapHasRunePack, string highlightRuneId)
		{
		}

		// Token: 0x060216AD RID: 136877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60216AD")]
		[Address(RVA = "0x1BCCAD0", Offset = "0x1BCB6D0", VA = "0x181BCCAD0")]
		private void _RefreshSingleItemBgType()
		{
		}

		// Token: 0x060216AE RID: 136878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60216AE")]
		[Address(RVA = "0x1BCBB70", Offset = "0x1BCA770", VA = "0x181BCBB70")]
		public void RefreshSlotRunePackViewList(HashSet<string> selectNodeSet, CrisisV2MapModel.ViewType viewType, string mapId, CrisisV2MapDetailData mapDetailData)
		{
		}

		// Token: 0x060216AF RID: 136879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60216AF")]
		[Address(RVA = "0x1BCCCC0", Offset = "0x1BCB8C0", VA = "0x181BCCCC0")]
		public CrisisV2RuneDetailViewModel()
		{
		}

		// Token: 0x0402D93B RID: 186683
		[Token(Token = "0x402D93B")]
		[FieldOffset(Offset = "0x10")]
		private List<CrisisV2RuneSingleViewModel> m_singleViewModels;

		// Token: 0x0402D93C RID: 186684
		[Token(Token = "0x402D93C")]
		[FieldOffset(Offset = "0x18")]
		private List<CrisisV2RunePackViewModel> m_packViewModels;

		// Token: 0x0402D93D RID: 186685
		[Token(Token = "0x402D93D")]
		[FieldOffset(Offset = "0x20")]
		private CrisisV2MapModel.ViewType m_viewType;

		// Token: 0x0402D93E RID: 186686
		[Token(Token = "0x402D93E")]
		[FieldOffset(Offset = "0x24")]
		private CrisisV2MapModel.TargetType m_targetType;

		// Token: 0x0402D93F RID: 186687
		[Token(Token = "0x402D93F")]
		[FieldOffset(Offset = "0x28")]
		private string m_focusTargetId;

		// Token: 0x0402D940 RID: 186688
		[Token(Token = "0x402D940")]
		[FieldOffset(Offset = "0x30")]
		private int m_focusSeq;

		// Token: 0x0402D941 RID: 186689
		[Token(Token = "0x402D941")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_singleViewModels;

		// Token: 0x0402D942 RID: 186690
		[Token(Token = "0x402D942")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_packViewModels;

		// Token: 0x0402D943 RID: 186691
		[Token(Token = "0x402D943")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_focusSeq;

		// Token: 0x0402D944 RID: 186692
		[Token(Token = "0x402D944")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RefreshFocus;

		// Token: 0x0402D945 RID: 186693
		[Token(Token = "0x402D945")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_IsSlotNodeFocus;

		// Token: 0x0402D946 RID: 186694
		[Token(Token = "0x402D946")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_IsSlotBagFocus;

		// Token: 0x0402D947 RID: 186695
		[Token(Token = "0x402D947")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_IsPackBagFocus;

		// Token: 0x0402D948 RID: 186696
		[Token(Token = "0x402D948")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_RefreshSlotRuneSingleViewList;

		// Token: 0x0402D949 RID: 186697
		[Token(Token = "0x402D949")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__RefreshSingleItemBgType;

		// Token: 0x0402D94A RID: 186698
		[Token(Token = "0x402D94A")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_RefreshSlotRunePackViewList;

		// Token: 0x0402D94B RID: 186699
		[Token(Token = "0x402D94B")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
