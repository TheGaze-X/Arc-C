using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Campaign
{
	// Token: 0x0200611E RID: 24862
	[Token(Token = "0x200611E")]
	public class CampaignFastBattleState : PopupFadeState
	{
		// Token: 0x06023E8A RID: 147082 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023E8A")]
		[Address(RVA = "0x1E87520", Offset = "0x1E86120", VA = "0x181E87520", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06023E8B RID: 147083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023E8B")]
		[Address(RVA = "0x1E87580", Offset = "0x1E86180", VA = "0x181E87580", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06023E8C RID: 147084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023E8C")]
		[Address(RVA = "0x1E88220", Offset = "0x1E86E20", VA = "0x181E88220")]
		private void _OnStartBattleClicked()
		{
		}

		// Token: 0x06023E8D RID: 147085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023E8D")]
		[Address(RVA = "0x1E87F50", Offset = "0x1E86B50", VA = "0x181E87F50")]
		private void _OnCancelClicked()
		{
		}

		// Token: 0x06023E8E RID: 147086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023E8E")]
		[Address(RVA = "0x1E87BD0", Offset = "0x1E867D0", VA = "0x181E87BD0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06023E8F RID: 147087 RVA: 0x000C2568 File Offset: 0x000C0768
		[Token(Token = "0x6023E8F")]
		[Address(RVA = "0x1E87660", Offset = "0x1E86260", VA = "0x181E87660")]
		private bool _CheckIfCanFastCampAndAlert()
		{
			return default(bool);
		}

		// Token: 0x06023E90 RID: 147088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023E90")]
		[Address(RVA = "0x1E877E0", Offset = "0x1E863E0", VA = "0x181E877E0")]
		private void _DoStartFastCamp()
		{
		}

		// Token: 0x06023E91 RID: 147089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023E91")]
		[Address(RVA = "0x1E87FD0", Offset = "0x1E86BD0", VA = "0x181E87FD0")]
		private void _OnFastCampServiceSuc(CampaignFinishBattleResponse response, PlayerStatus statusBeforeBattle)
		{
		}

		// Token: 0x06023E92 RID: 147090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023E92")]
		[Address(RVA = "0x1E87320", Offset = "0x1E85F20", VA = "0x181E87320", Slot = "27")]
		protected override void DealWithOtherStateBeforeTransStart(UIPopupState.TransactionContext context, bool isFastMode)
		{
		}

		// Token: 0x06023E93 RID: 147091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023E93")]
		[Address(RVA = "0x1E87420", Offset = "0x1E86020", VA = "0x181E87420", Slot = "28")]
		protected override void DealWithOtherStateWenTransEnd(UIPopupState.TransactionContext context, bool isFastMode)
		{
		}

		// Token: 0x06023E94 RID: 147092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023E94")]
		[Address(RVA = "0x1E88430", Offset = "0x1E87030", VA = "0x181E88430")]
		public CampaignFastBattleState()
		{
		}

		// Token: 0x06023E95 RID: 147093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023E95")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x06023E96 RID: 147094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023E96")]
		[Address(RVA = "0xF80770", Offset = "0xF7F370", VA = "0x180F80770")]
		private void <>xLuaBaseProxy_DealWithOtherStateBeforeTransStart(UIPopupState.TransactionContext P0, bool P1)
		{
		}

		// Token: 0x06023E97 RID: 147095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023E97")]
		[Address(RVA = "0xF807A0", Offset = "0xF7F3A0", VA = "0x180F807A0")]
		private void <>xLuaBaseProxy_DealWithOtherStateWenTransEnd(UIPopupState.TransactionContext P0, bool P1)
		{
		}

		// Token: 0x04031D69 RID: 204137
		[Token(Token = "0x4031D69")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Transform _confirmViewHolder;

		// Token: 0x04031D6A RID: 204138
		[Token(Token = "0x4031D6A")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private CampaignFastBattleConfirmView _confirmViewPrefab;

		// Token: 0x04031D6B RID: 204139
		[Token(Token = "0x4031D6B")]
		[FieldOffset(Offset = "0x80")]
		private CampaignFastBattleStateBean m_stateBean;

		// Token: 0x04031D6C RID: 204140
		[Token(Token = "0x4031D6C")]
		[FieldOffset(Offset = "0x88")]
		private CampaignFastBattleConfirmView m_confirmView;

		// Token: 0x04031D6D RID: 204141
		[Token(Token = "0x4031D6D")]
		[FieldOffset(Offset = "0x90")]
		private bool m_isInited;

		// Token: 0x04031D6E RID: 204142
		[Token(Token = "0x4031D6E")]
		[FieldOffset(Offset = "0x91")]
		private bool m_isBattleStarted;

		// Token: 0x04031D6F RID: 204143
		[Token(Token = "0x4031D6F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04031D70 RID: 204144
		[Token(Token = "0x4031D70")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04031D71 RID: 204145
		[Token(Token = "0x4031D71")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnStartBattleClicked;

		// Token: 0x04031D72 RID: 204146
		[Token(Token = "0x4031D72")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnCancelClicked;

		// Token: 0x04031D73 RID: 204147
		[Token(Token = "0x4031D73")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04031D74 RID: 204148
		[Token(Token = "0x4031D74")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__CheckIfCanFastCampAndAlert;

		// Token: 0x04031D75 RID: 204149
		[Token(Token = "0x4031D75")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__DoStartFastCamp;

		// Token: 0x04031D76 RID: 204150
		[Token(Token = "0x4031D76")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnFastCampServiceSuc;

		// Token: 0x04031D77 RID: 204151
		[Token(Token = "0x4031D77")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_DealWithOtherStateBeforeTransStart;

		// Token: 0x04031D78 RID: 204152
		[Token(Token = "0x4031D78")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_DealWithOtherStateWenTransEnd;

		// Token: 0x04031D79 RID: 204153
		[Token(Token = "0x4031D79")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
