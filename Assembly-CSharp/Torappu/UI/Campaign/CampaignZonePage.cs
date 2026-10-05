using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Campaign
{
	// Token: 0x020060E1 RID: 24801
	[Token(Token = "0x20060E1")]
	public class CampaignZonePage : StateEnginePage, IDialogMgrHolder
	{
		// Token: 0x170054B0 RID: 21680
		// (get) Token: 0x06023D9C RID: 146844 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170054B0")]
		public string entryZoneId
		{
			[Token(Token = "0x6023D9C")]
			[Address(RVA = "0x1E78280", Offset = "0x1E76E80", VA = "0x181E78280")]
			get
			{
				return null;
			}
		}

		// Token: 0x170054B1 RID: 21681
		// (get) Token: 0x06023D9D RID: 146845 RVA: 0x000C2400 File Offset: 0x000C0600
		[Token(Token = "0x170054B1")]
		public bool isToBreakingDetail
		{
			[Token(Token = "0x6023D9D")]
			[Address(RVA = "0x1E78390", Offset = "0x1E76F90", VA = "0x181E78390")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170054B2 RID: 21682
		// (get) Token: 0x06023D9E RID: 146846 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170054B2")]
		public string entryStageId
		{
			[Token(Token = "0x6023D9E")]
			[Address(RVA = "0x1E781D0", Offset = "0x1E76DD0", VA = "0x181E781D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170054B3 RID: 21683
		// (get) Token: 0x06023D9F RID: 146847 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170054B3")]
		public CampaignFeeViewProperty feeProperty
		{
			[Token(Token = "0x6023D9F")]
			[Address(RVA = "0x1E78330", Offset = "0x1E76F30", VA = "0x181E78330")]
			get
			{
				return null;
			}
		}

		// Token: 0x06023DA0 RID: 146848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023DA0")]
		[Address(RVA = "0x1E78000", Offset = "0x1E76C00", VA = "0x181E78000", Slot = "8")]
		protected override void OnCreate(DataBundle savedInst)
		{
		}

		// Token: 0x06023DA1 RID: 146849 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023DA1")]
		[Address(RVA = "0x1E77FA0", Offset = "0x1E76BA0", VA = "0x181E77FA0", Slot = "29")]
		public UICompDialogMgr GetDialogMgr()
		{
			return null;
		}

		// Token: 0x06023DA2 RID: 146850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023DA2")]
		[Address(RVA = "0x1E780E0", Offset = "0x1E76CE0", VA = "0x181E780E0")]
		public CampaignZonePage()
		{
		}

		// Token: 0x06023DA3 RID: 146851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023DA3")]
		[Address(RVA = "0xE66190", Offset = "0xE64D90", VA = "0x180E66190")]
		private void <>xLuaBaseProxy_OnCreate(DataBundle P0)
		{
		}

		// Token: 0x04031B6B RID: 203627
		[Token(Token = "0x4031B6B")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private RectTransform _dialogContainer;

		// Token: 0x04031B6C RID: 203628
		[Token(Token = "0x4031B6C")]
		[FieldOffset(Offset = "0xF8")]
		private UICompDialogMgr m_dialogMgr;

		// Token: 0x04031B6D RID: 203629
		[Token(Token = "0x4031B6D")]
		[FieldOffset(Offset = "0x100")]
		private CampaignFeeViewProperty m_feeProperty;

		// Token: 0x04031B6E RID: 203630
		[Token(Token = "0x4031B6E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_entryZoneId;

		// Token: 0x04031B6F RID: 203631
		[Token(Token = "0x4031B6F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isToBreakingDetail;

		// Token: 0x04031B70 RID: 203632
		[Token(Token = "0x4031B70")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_entryStageId;

		// Token: 0x04031B71 RID: 203633
		[Token(Token = "0x4031B71")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_feeProperty;

		// Token: 0x04031B72 RID: 203634
		[Token(Token = "0x4031B72")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x04031B73 RID: 203635
		[Token(Token = "0x4031B73")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetDialogMgr;

		// Token: 0x04031B74 RID: 203636
		[Token(Token = "0x4031B74")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020060E2 RID: 24802
		[Token(Token = "0x20060E2")]
		public class Param
		{
			// Token: 0x06023DA4 RID: 146852 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6023DA4")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Param()
			{
			}

			// Token: 0x04031B75 RID: 203637
			[Token(Token = "0x4031B75")]
			[FieldOffset(Offset = "0x10")]
			public string zoneId;

			// Token: 0x04031B76 RID: 203638
			[Token(Token = "0x4031B76")]
			[FieldOffset(Offset = "0x18")]
			public bool isToBreakingDetail;

			// Token: 0x04031B77 RID: 203639
			[Token(Token = "0x4031B77")]
			[FieldOffset(Offset = "0x20")]
			public string stageId;
		}
	}
}
