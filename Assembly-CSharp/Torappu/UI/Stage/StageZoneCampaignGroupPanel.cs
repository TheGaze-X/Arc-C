using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x0200699B RID: 27035
	[Token(Token = "0x200699B")]
	public class StageZoneCampaignGroupPanel : StageZoneGroupPanel
	{
		// Token: 0x06026AE1 RID: 158433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026AE1")]
		[Address(RVA = "0x21BDD30", Offset = "0x21BC930", VA = "0x1821BDD30", Slot = "8")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06026AE2 RID: 158434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026AE2")]
		[Address(RVA = "0x21BDC20", Offset = "0x21BC820", VA = "0x1821BDC20", Slot = "9")]
		protected override void OnDataUpdated(ZoneGroupViewProperty prop)
		{
		}

		// Token: 0x06026AE3 RID: 158435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026AE3")]
		[Address(RVA = "0x21BE250", Offset = "0x21BCE50", VA = "0x1821BE250")]
		private void _EventOnClimbTowerClicked()
		{
		}

		// Token: 0x06026AE4 RID: 158436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026AE4")]
		[Address(RVA = "0x21BE3E0", Offset = "0x21BCFE0", VA = "0x1821BE3E0")]
		private void _EventOnClimbTowerRotateClicked()
		{
		}

		// Token: 0x06026AE5 RID: 158437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026AE5")]
		[Address(RVA = "0x21BDEF0", Offset = "0x21BCAF0", VA = "0x1821BDEF0")]
		private void _EventOnCampaignClicked()
		{
		}

		// Token: 0x06026AE6 RID: 158438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026AE6")]
		[Address(RVA = "0x21BE030", Offset = "0x21BCC30", VA = "0x1821BE030")]
		private void _EventOnCampaignRotateStageClicked()
		{
		}

		// Token: 0x06026AE7 RID: 158439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026AE7")]
		[Address(RVA = "0x21BE600", Offset = "0x21BD200", VA = "0x1821BE600")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06026AE8 RID: 158440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026AE8")]
		[Address(RVA = "0x21BE9E0", Offset = "0x21BD5E0", VA = "0x1821BE9E0")]
		public StageZoneCampaignGroupPanel()
		{
		}

		// Token: 0x06026AE9 RID: 158441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026AE9")]
		[Address(RVA = "0x21BDE90", Offset = "0x21BCA90", VA = "0x1821BDE90")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x06026AEA RID: 158442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026AEA")]
		[Address(RVA = "0x21BDE30", Offset = "0x21BCA30", VA = "0x1821BDE30")]
		private void <>xLuaBaseProxy_OnDataUpdated(ZoneGroupViewProperty P0)
		{
		}

		// Token: 0x040369B4 RID: 223668
		[Token(Token = "0x40369B4")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private StageZoneCampaignView _campaignView;

		// Token: 0x040369B5 RID: 223669
		[Token(Token = "0x40369B5")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private StageZoneClimbTowerView _towerView;

		// Token: 0x040369B6 RID: 223670
		[Token(Token = "0x40369B6")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private StageZoneWeeklyRecordView _recordView;

		// Token: 0x040369B7 RID: 223671
		[Token(Token = "0x40369B7")]
		[FieldOffset(Offset = "0x78")]
		private StageZoneWeeklyRewardProperty _weeklyRewardProp;

		// Token: 0x040369B8 RID: 223672
		[Token(Token = "0x40369B8")]
		[FieldOffset(Offset = "0x80")]
		private bool m_inited;

		// Token: 0x040369B9 RID: 223673
		[Token(Token = "0x40369B9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x040369BA RID: 223674
		[Token(Token = "0x40369BA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnDataUpdated;

		// Token: 0x040369BB RID: 223675
		[Token(Token = "0x40369BB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__EventOnClimbTowerClicked;

		// Token: 0x040369BC RID: 223676
		[Token(Token = "0x40369BC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__EventOnClimbTowerRotateClicked;

		// Token: 0x040369BD RID: 223677
		[Token(Token = "0x40369BD")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__EventOnCampaignClicked;

		// Token: 0x040369BE RID: 223678
		[Token(Token = "0x40369BE")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__EventOnCampaignRotateStageClicked;

		// Token: 0x040369BF RID: 223679
		[Token(Token = "0x40369BF")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040369C0 RID: 223680
		[Token(Token = "0x40369C0")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
