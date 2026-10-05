using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Campaign
{
	// Token: 0x02006132 RID: 24882
	[Token(Token = "0x2006132")]
	public class CampaignStagePreviewConfigController : DataBinder<CampaignZoneMapProperty>, IHotfixable
	{
		// Token: 0x06023ED6 RID: 147158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023ED6")]
		[Address(RVA = "0x1E88690", Offset = "0x1E87290", VA = "0x181E88690", Slot = "7")]
		public override void OnValueChanged(CampaignZoneMapProperty property)
		{
		}

		// Token: 0x06023ED7 RID: 147159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023ED7")]
		[Address(RVA = "0x1E88A00", Offset = "0x1E87600", VA = "0x181E88A00")]
		private void _UpdateDefaultSwitch(AutoCampConfigModel model)
		{
		}

		// Token: 0x06023ED8 RID: 147160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023ED8")]
		[Address(RVA = "0x1E88B70", Offset = "0x1E87770", VA = "0x181E88B70")]
		private void _UpdateFastBattleSwitch(AutoCampConfigModel model)
		{
		}

		// Token: 0x06023ED9 RID: 147161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023ED9")]
		[Address(RVA = "0x1E88600", Offset = "0x1E87200", VA = "0x181E88600")]
		public void EventOnFastCampInfoClicked()
		{
		}

		// Token: 0x06023EDA RID: 147162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023EDA")]
		[Address(RVA = "0x1E88CD0", Offset = "0x1E878D0", VA = "0x181E88CD0")]
		public CampaignStagePreviewConfigController()
		{
		}

		// Token: 0x04031DEC RID: 204268
		[Token(Token = "0x4031DEC")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CampaignAutoDefaultSwitchView _dftAutoBattle;

		// Token: 0x04031DED RID: 204269
		[Token(Token = "0x4031DED")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _fastAutoBattleHolder;

		// Token: 0x04031DEE RID: 204270
		[Token(Token = "0x4031DEE")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private CampaignAutoFastBattleSwitchView _fastAutoPrefab;

		// Token: 0x04031DEF RID: 204271
		[Token(Token = "0x4031DEF")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelFastTtkCost;

		// Token: 0x04031DF0 RID: 204272
		[Token(Token = "0x4031DF0")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _panelFastTktInfo;

		// Token: 0x04031DF1 RID: 204273
		[Token(Token = "0x4031DF1")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _textFastTktCount;

		// Token: 0x04031DF2 RID: 204274
		[Token(Token = "0x4031DF2")]
		[FieldOffset(Offset = "0x50")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04031DF3 RID: 204275
		[Token(Token = "0x4031DF3")]
		[FieldOffset(Offset = "0x60")]
		private CampaignAutoFastBattleSwitchView m_fastAutoBattle;

		// Token: 0x04031DF4 RID: 204276
		[Token(Token = "0x4031DF4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04031DF5 RID: 204277
		[Token(Token = "0x4031DF5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__UpdateDefaultSwitch;

		// Token: 0x04031DF6 RID: 204278
		[Token(Token = "0x4031DF6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__UpdateFastBattleSwitch;

		// Token: 0x04031DF7 RID: 204279
		[Token(Token = "0x4031DF7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnFastCampInfoClicked;

		// Token: 0x04031DF8 RID: 204280
		[Token(Token = "0x4031DF8")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
