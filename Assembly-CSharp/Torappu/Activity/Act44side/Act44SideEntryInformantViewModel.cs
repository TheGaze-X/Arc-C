using System;
using Il2CppDummyDll;
using Torappu.UI.ActivityStage;
using Torappu.UI.ActivityStage.Extern;
using XLua;

namespace Torappu.Activity.Act44side
{
	// Token: 0x020072EB RID: 29419
	[Token(Token = "0x20072EB")]
	public class Act44SideEntryInformantViewModel : TemplateActivityViewModel, IHotfixable
	{
		// Token: 0x17006268 RID: 25192
		// (get) Token: 0x06029A0F RID: 170511 RVA: 0x000D6128 File Offset: 0x000D4328
		[Token(Token = "0x17006268")]
		public bool showTrackPoint
		{
			[Token(Token = "0x6029A0F")]
			[Address(RVA = "0x24ED190", Offset = "0x24EBD90", VA = "0x1824ED190")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06029A10 RID: 170512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029A10")]
		[Address(RVA = "0x24ECE70", Offset = "0x24EBA70", VA = "0x1824ECE70")]
		public Act44SideEntryInformantViewModel(object param)
		{
		}

		// Token: 0x06029A11 RID: 170513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029A11")]
		[Address(RVA = "0x24ECC80", Offset = "0x24EB880", VA = "0x1824ECC80")]
		public void RefreshPlayerData()
		{
		}

		// Token: 0x0403B8BA RID: 243898
		[Token(Token = "0x403B8BA")]
		[FieldOffset(Offset = "0x20")]
		public Act44SideEntryInformantViewModel.Status currStatus;

		// Token: 0x0403B8BB RID: 243899
		[Token(Token = "0x403B8BB")]
		[FieldOffset(Offset = "0x28")]
		public string lockedToastDesc;

		// Token: 0x0403B8BC RID: 243900
		[Token(Token = "0x403B8BC")]
		[FieldOffset(Offset = "0x30")]
		public string lockedDesc;

		// Token: 0x0403B8BD RID: 243901
		[Token(Token = "0x403B8BD")]
		[FieldOffset(Offset = "0x38")]
		public string actId;

		// Token: 0x0403B8BE RID: 243902
		[Token(Token = "0x403B8BE")]
		[FieldOffset(Offset = "0x40")]
		private DateTime m_actEndTs;

		// Token: 0x0403B8BF RID: 243903
		[Token(Token = "0x403B8BF")]
		[FieldOffset(Offset = "0x48")]
		private DateTime m_actRewardEndTs;

		// Token: 0x0403B8C0 RID: 243904
		[Token(Token = "0x403B8C0")]
		[FieldOffset(Offset = "0x50")]
		private int m_itemCost;

		// Token: 0x0403B8C1 RID: 243905
		[Token(Token = "0x403B8C1")]
		[FieldOffset(Offset = "0x58")]
		private TemplateActivityMilestoneGroupViewModel m_milestoneGroupViewModel;

		// Token: 0x0403B8C2 RID: 243906
		[Token(Token = "0x403B8C2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_showTrackPoint;

		// Token: 0x0403B8C3 RID: 243907
		[Token(Token = "0x403B8C3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0403B8C4 RID: 243908
		[Token(Token = "0x403B8C4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RefreshPlayerData;

		// Token: 0x020072EC RID: 29420
		[Token(Token = "0x20072EC")]
		public class Input
		{
			// Token: 0x06029A12 RID: 170514 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6029A12")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Input()
			{
			}

			// Token: 0x0403B8C5 RID: 243909
			[Token(Token = "0x403B8C5")]
			[FieldOffset(Offset = "0x10")]
			public Act44SideData gameData;

			// Token: 0x0403B8C6 RID: 243910
			[Token(Token = "0x403B8C6")]
			[FieldOffset(Offset = "0x18")]
			public ActivityBasicInfo actBasicInfo;
		}

		// Token: 0x020072ED RID: 29421
		[Token(Token = "0x20072ED")]
		public enum Status
		{
			// Token: 0x0403B8C8 RID: 243912
			[Token(Token = "0x403B8C8")]
			LOCKED,
			// Token: 0x0403B8C9 RID: 243913
			[Token(Token = "0x403B8C9")]
			UNLOCK,
			// Token: 0x0403B8CA RID: 243914
			[Token(Token = "0x403B8CA")]
			ITEM_LOCKED,
			// Token: 0x0403B8CB RID: 243915
			[Token(Token = "0x403B8CB")]
			PLAYING,
			// Token: 0x0403B8CC RID: 243916
			[Token(Token = "0x403B8CC")]
			TIME_OUT
		}
	}
}
