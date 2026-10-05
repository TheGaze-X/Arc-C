using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Campaign
{
	// Token: 0x020060E8 RID: 24808
	[Token(Token = "0x20060E8")]
	public class CampaignMissionState : PopupFloatState
	{
		// Token: 0x06023DB9 RID: 146873 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023DB9")]
		[Address(RVA = "0x1E72060", Offset = "0x1E70C60", VA = "0x181E72060", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06023DBA RID: 146874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023DBA")]
		[Address(RVA = "0x1E720C0", Offset = "0x1E70CC0", VA = "0x181E720C0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06023DBB RID: 146875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023DBB")]
		[Address(RVA = "0x1E71F80", Offset = "0x1E70B80", VA = "0x181E71F80")]
		public void EventOnJumpToRotateClicked()
		{
		}

		// Token: 0x06023DBC RID: 146876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023DBC")]
		[Address(RVA = "0x1E71F20", Offset = "0x1E70B20", VA = "0x181E71F20")]
		public void EventOnBackClicked()
		{
		}

		// Token: 0x06023DBD RID: 146877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023DBD")]
		[Address(RVA = "0x1E72770", Offset = "0x1E71370", VA = "0x181E72770")]
		private void _EventOnPermanentObjClicked(CampaignPermanentMissionViewModel permanentMission)
		{
		}

		// Token: 0x06023DBE RID: 146878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023DBE")]
		[Address(RVA = "0x1E724C0", Offset = "0x1E710C0", VA = "0x181E724C0")]
		private void _EventOnCommonObjClicked(CampaignCommonMissionViewModel commonMission)
		{
		}

		// Token: 0x06023DBF RID: 146879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023DBF")]
		[Address(RVA = "0x1E72850", Offset = "0x1E71450", VA = "0x181E72850")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06023DC0 RID: 146880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023DC0")]
		[Address(RVA = "0x1E72B60", Offset = "0x1E71760", VA = "0x181E72B60")]
		public CampaignMissionState()
		{
		}

		// Token: 0x06023DC2 RID: 146882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023DC2")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x04031BAE RID: 203694
		[Token(Token = "0x4031BAE")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private CampaignMissionView _view;

		// Token: 0x04031BAF RID: 203695
		[Token(Token = "0x4031BAF")]
		[FieldOffset(Offset = "0x78")]
		private bool m_inited;

		// Token: 0x04031BB0 RID: 203696
		[Token(Token = "0x4031BB0")]
		[FieldOffset(Offset = "0x80")]
		private CampaignMissionStateBean m_stateBean;

		// Token: 0x04031BB1 RID: 203697
		[Token(Token = "0x4031BB1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04031BB2 RID: 203698
		[Token(Token = "0x4031BB2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04031BB3 RID: 203699
		[Token(Token = "0x4031BB3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnJumpToRotateClicked;

		// Token: 0x04031BB4 RID: 203700
		[Token(Token = "0x4031BB4")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnBackClicked;

		// Token: 0x04031BB5 RID: 203701
		[Token(Token = "0x4031BB5")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__EventOnPermanentObjClicked;

		// Token: 0x04031BB6 RID: 203702
		[Token(Token = "0x4031BB6")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__EventOnCommonObjClicked;

		// Token: 0x04031BB7 RID: 203703
		[Token(Token = "0x4031BB7")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04031BB8 RID: 203704
		[Token(Token = "0x4031BB8")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
