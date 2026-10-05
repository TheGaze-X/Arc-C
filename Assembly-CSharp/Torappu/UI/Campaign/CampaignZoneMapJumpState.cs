using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Campaign
{
	// Token: 0x02006138 RID: 24888
	[Token(Token = "0x2006138")]
	public class CampaignZoneMapJumpState : PopupFloatState
	{
		// Token: 0x06023EE8 RID: 147176 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023EE8")]
		[Address(RVA = "0x1E93E90", Offset = "0x1E92A90", VA = "0x181E93E90", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06023EE9 RID: 147177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023EE9")]
		[Address(RVA = "0x1E93F90", Offset = "0x1E92B90", VA = "0x181E93F90", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06023EEA RID: 147178 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023EEA")]
		[Address(RVA = "0x1E94040", Offset = "0x1E92C40", VA = "0x181E94040", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x06023EEB RID: 147179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023EEB")]
		[Address(RVA = "0x1E941A0", Offset = "0x1E92DA0", VA = "0x181E941A0")]
		private void _OnJumpToCampaignZoneMapState(IStateBean bean)
		{
		}

		// Token: 0x06023EEC RID: 147180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023EEC")]
		[Address(RVA = "0x1E93EF0", Offset = "0x1E92AF0", VA = "0x181E93EF0")]
		public void JumpToStage(CampaignZoneJumpViewModel jumpToViewModel)
		{
		}

		// Token: 0x06023EED RID: 147181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023EED")]
		[Address(RVA = "0x1E94280", Offset = "0x1E92E80", VA = "0x181E94280")]
		public CampaignZoneMapJumpState()
		{
		}

		// Token: 0x06023EEE RID: 147182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023EEE")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x06023EEF RID: 147183 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023EEF")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x04031E17 RID: 204311
		[Token(Token = "0x4031E17")]
		[FieldOffset(Offset = "0x70")]
		private CampaignZoneMapJumpStateBean m_stateBean;

		// Token: 0x04031E18 RID: 204312
		[Token(Token = "0x4031E18")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private CampaignZoneMapJumpView _jumpView;

		// Token: 0x04031E19 RID: 204313
		[Token(Token = "0x4031E19")]
		[FieldOffset(Offset = "0x80")]
		private CampaignZoneJumpViewModel m_jumpViewModel;

		// Token: 0x04031E1A RID: 204314
		[Token(Token = "0x4031E1A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04031E1B RID: 204315
		[Token(Token = "0x4031E1B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04031E1C RID: 204316
		[Token(Token = "0x4031E1C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x04031E1D RID: 204317
		[Token(Token = "0x4031E1D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnJumpToCampaignZoneMapState;

		// Token: 0x04031E1E RID: 204318
		[Token(Token = "0x4031E1E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_JumpToStage;

		// Token: 0x04031E1F RID: 204319
		[Token(Token = "0x4031E1F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
