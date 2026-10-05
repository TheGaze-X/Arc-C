using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Informant
{
	// Token: 0x02004A39 RID: 19001
	[Token(Token = "0x2004A39")]
	public class InformantSelectChoiceViewModel : IHotfixable
	{
		// Token: 0x0601C937 RID: 117047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C937")]
		[Address(RVA = "0x1618420", Offset = "0x1617020", VA = "0x181618420")]
		public void LoadData(string actId)
		{
		}

		// Token: 0x0601C938 RID: 117048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C938")]
		[Address(RVA = "0x16184D0", Offset = "0x16170D0", VA = "0x1816184D0")]
		public void RefreshData(string actId)
		{
		}

		// Token: 0x0601C939 RID: 117049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C939")]
		[Address(RVA = "0x1618BA0", Offset = "0x16177A0", VA = "0x181618BA0")]
		public void SelectChoice(int choiceIndex)
		{
		}

		// Token: 0x0601C93A RID: 117050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C93A")]
		[Address(RVA = "0x1618C90", Offset = "0x1617890", VA = "0x181618C90")]
		public void SetShowInsightPanel(bool show)
		{
		}

		// Token: 0x0601C93B RID: 117051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C93B")]
		[Address(RVA = "0x1618C20", Offset = "0x1617820", VA = "0x181618C20")]
		public void SetSettleConfirmShow(bool show)
		{
		}

		// Token: 0x0601C93C RID: 117052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C93C")]
		[Address(RVA = "0x1618ED0", Offset = "0x1617AD0", VA = "0x181618ED0")]
		private void _UpdateInsight()
		{
		}

		// Token: 0x0601C93D RID: 117053 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C93D")]
		[Address(RVA = "0x1618D10", Offset = "0x1617910", VA = "0x181618D10")]
		private string _GetInsightDesc(Act44SideData.InsightType insightType, InformantInsightParam param)
		{
			return null;
		}

		// Token: 0x0601C93E RID: 117054 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C93E")]
		[Address(RVA = "0x1619150", Offset = "0x1617D50", VA = "0x181619150")]
		public InformantSelectChoiceViewModel()
		{
		}

		// Token: 0x04025812 RID: 153618
		[Token(Token = "0x4025812")]
		public const int EMPTY_CHOICE_SELECT = -1;

		// Token: 0x04025813 RID: 153619
		[Token(Token = "0x4025813")]
		[FieldOffset(Offset = "0x10")]
		public string actId;

		// Token: 0x04025814 RID: 153620
		[Token(Token = "0x4025814")]
		[FieldOffset(Offset = "0x18")]
		public int round;

		// Token: 0x04025815 RID: 153621
		[Token(Token = "0x4025815")]
		[FieldOffset(Offset = "0x20")]
		public List<InformantSelectChoiceItemViewModel> choiceModelList;

		// Token: 0x04025816 RID: 153622
		[Token(Token = "0x4025816")]
		[FieldOffset(Offset = "0x28")]
		public string customerId;

		// Token: 0x04025817 RID: 153623
		[Token(Token = "0x4025817")]
		[FieldOffset(Offset = "0x30")]
		public bool isSpCustomer;

		// Token: 0x04025818 RID: 153624
		[Token(Token = "0x4025818")]
		[FieldOffset(Offset = "0x38")]
		public string tagId;

		// Token: 0x04025819 RID: 153625
		[Token(Token = "0x4025819")]
		[FieldOffset(Offset = "0x40")]
		public string customerName;

		// Token: 0x0402581A RID: 153626
		[Token(Token = "0x402581A")]
		[FieldOffset(Offset = "0x48")]
		public string tagName;

		// Token: 0x0402581B RID: 153627
		[Token(Token = "0x402581B")]
		[FieldOffset(Offset = "0x50")]
		public string customerDesc;

		// Token: 0x0402581C RID: 153628
		[Token(Token = "0x402581C")]
		[FieldOffset(Offset = "0x58")]
		public string tagDesc;

		// Token: 0x0402581D RID: 153629
		[Token(Token = "0x402581D")]
		[FieldOffset(Offset = "0x60")]
		public string customerIllustId;

		// Token: 0x0402581E RID: 153630
		[Token(Token = "0x402581E")]
		[FieldOffset(Offset = "0x68")]
		public string customerDialogText;

		// Token: 0x0402581F RID: 153631
		[Token(Token = "0x402581F")]
		[FieldOffset(Offset = "0x70")]
		public string keeperDialogText;

		// Token: 0x04025820 RID: 153632
		[Token(Token = "0x4025820")]
		[FieldOffset(Offset = "0x78")]
		public bool showKeeperDialog;

		// Token: 0x04025821 RID: 153633
		[Token(Token = "0x4025821")]
		[FieldOffset(Offset = "0x7C")]
		public int selectingChoiceIndex;

		// Token: 0x04025822 RID: 153634
		[Token(Token = "0x4025822")]
		[FieldOffset(Offset = "0x80")]
		public int remainInsightTimes;

		// Token: 0x04025823 RID: 153635
		[Token(Token = "0x4025823")]
		[FieldOffset(Offset = "0x84")]
		public bool usedInsight;

		// Token: 0x04025824 RID: 153636
		[Token(Token = "0x4025824")]
		[FieldOffset(Offset = "0x85")]
		public bool showInsightPanel;

		// Token: 0x04025825 RID: 153637
		[Token(Token = "0x4025825")]
		[FieldOffset(Offset = "0x88")]
		public InformantInsightBarModel insightBarModel;

		// Token: 0x04025826 RID: 153638
		[Token(Token = "0x4025826")]
		[FieldOffset(Offset = "0x90")]
		public string insightPatienceDesc;

		// Token: 0x04025827 RID: 153639
		[Token(Token = "0x4025827")]
		[FieldOffset(Offset = "0x98")]
		public string insightTrustDesc;

		// Token: 0x04025828 RID: 153640
		[Token(Token = "0x4025828")]
		[FieldOffset(Offset = "0xA0")]
		public string insightAttentionDesc;

		// Token: 0x04025829 RID: 153641
		[Token(Token = "0x4025829")]
		[FieldOffset(Offset = "0xA8")]
		public int enterSeqNum;

		// Token: 0x0402582A RID: 153642
		[Token(Token = "0x402582A")]
		[FieldOffset(Offset = "0xAC")]
		public bool isSettleConfirmShow;

		// Token: 0x0402582B RID: 153643
		[Token(Token = "0x402582B")]
		[FieldOffset(Offset = "0xAD")]
		public bool isInChoiceState;

		// Token: 0x0402582C RID: 153644
		[Token(Token = "0x402582C")]
		[FieldOffset(Offset = "0xAE")]
		public bool showPatienceNoticeCutin;

		// Token: 0x0402582D RID: 153645
		[Token(Token = "0x402582D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402582E RID: 153646
		[Token(Token = "0x402582E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RefreshData;

		// Token: 0x0402582F RID: 153647
		[Token(Token = "0x402582F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SelectChoice;

		// Token: 0x04025830 RID: 153648
		[Token(Token = "0x4025830")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SetShowInsightPanel;

		// Token: 0x04025831 RID: 153649
		[Token(Token = "0x4025831")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_SetSettleConfirmShow;

		// Token: 0x04025832 RID: 153650
		[Token(Token = "0x4025832")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__UpdateInsight;

		// Token: 0x04025833 RID: 153651
		[Token(Token = "0x4025833")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__GetInsightDesc;

		// Token: 0x04025834 RID: 153652
		[Token(Token = "0x4025834")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
