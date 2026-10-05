using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.UI.Float
{
	// Token: 0x02001DEC RID: 7660
	[Token(Token = "0x2001DEC")]
	public class BuildingFloatVisitState : BuildingFloatState, IPlayerDataListener, IHotfixable
	{
		// Token: 0x170016E3 RID: 5859
		// (get) Token: 0x0600BD30 RID: 48432 RVA: 0x00046428 File Offset: 0x00044628
		[Token(Token = "0x170016E3")]
		protected override FloatState state
		{
			[Token(Token = "0x600BD30")]
			[Address(RVA = "0x33B0250", Offset = "0x33AEE50", VA = "0x1833B0250", Slot = "4")]
			get
			{
				return FloatState.NONE;
			}
		}

		// Token: 0x0600BD31 RID: 48433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD31")]
		[Address(RVA = "0x33B0080", Offset = "0x33AEC80", VA = "0x1833B0080")]
		private void _UpdateSocialPoint()
		{
		}

		// Token: 0x0600BD32 RID: 48434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD32")]
		[Address(RVA = "0x33AFFA0", Offset = "0x33AEBA0", VA = "0x1833AFFA0")]
		private void _UpdateRoomName(string roomOwner)
		{
		}

		// Token: 0x0600BD33 RID: 48435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD33")]
		[Address(RVA = "0x33AFE70", Offset = "0x33AEA70", VA = "0x1833AFE70")]
		private void _OpenFriendNameCard(GetOtherPlayerNameCardResponse response)
		{
		}

		// Token: 0x0600BD34 RID: 48436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD34")]
		[Address(RVA = "0x33AF5D0", Offset = "0x33AE1D0", VA = "0x1833AF5D0", Slot = "6")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0600BD35 RID: 48437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD35")]
		[Address(RVA = "0x33AFD70", Offset = "0x33AE970", VA = "0x1833AFD70", Slot = "8")]
		protected override void OnStateUpdated(bool isActive)
		{
		}

		// Token: 0x0600BD36 RID: 48438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD36")]
		[Address(RVA = "0x33AFC40", Offset = "0x33AE840", VA = "0x1833AFC40")]
		public void OnSendClueButtonPressed()
		{
		}

		// Token: 0x0600BD37 RID: 48439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD37")]
		[Address(RVA = "0x33AF410", Offset = "0x33AE010", VA = "0x1833AF410")]
		public void EventOnVisitNextClicked()
		{
		}

		// Token: 0x0600BD38 RID: 48440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD38")]
		[Address(RVA = "0x33AF160", Offset = "0x33ADD60", VA = "0x1833AF160")]
		public void EventOnNameCardClicked()
		{
		}

		// Token: 0x0600BD39 RID: 48441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD39")]
		[Address(RVA = "0x33AF570", Offset = "0x33AE170", VA = "0x1833AF570")]
		private void OnEnable()
		{
		}

		// Token: 0x0600BD3A RID: 48442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD3A")]
		[Address(RVA = "0x33AF510", Offset = "0x33AE110", VA = "0x1833AF510")]
		private void OnDisable()
		{
		}

		// Token: 0x0600BD3B RID: 48443 RVA: 0x00046440 File Offset: 0x00044640
		[Token(Token = "0x600BD3B")]
		[Address(RVA = "0x33AF020", Offset = "0x33ADC20", VA = "0x1833AF020", Slot = "14")]
		public bool CheckIfDataChanged(PlayerDataModel prevData, PlayerDataModel curData, PlayerDataDelta delta)
		{
			return default(bool);
		}

		// Token: 0x0600BD3C RID: 48444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD3C")]
		[Address(RVA = "0x33AFBE0", Offset = "0x33AE7E0", VA = "0x1833AFBE0", Slot = "15")]
		public void OnPlayerDataChanged()
		{
		}

		// Token: 0x0600BD3D RID: 48445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD3D")]
		[Address(RVA = "0x33B0160", Offset = "0x33AED60", VA = "0x1833B0160")]
		public BuildingFloatVisitState()
		{
		}

		// Token: 0x0600BD3F RID: 48447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD3F")]
		[Address(RVA = "0x33A2B20", Offset = "0x33A1720", VA = "0x1833A2B20")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0600BD40 RID: 48448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD40")]
		[Address(RVA = "0x33A31C0", Offset = "0x33A1DC0", VA = "0x1833A31C0")]
		private void <>xLuaBaseProxy_OnStateUpdated(bool P0)
		{
		}

		// Token: 0x0400BD65 RID: 48485
		[Token(Token = "0x400BD65")]
		private const string NAMECARD_REQUEST_SRC = "VISIT_BUILDING_HOST";

		// Token: 0x0400BD66 RID: 48486
		[Token(Token = "0x400BD66")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private BuildingTwoContentNotify _notify;

		// Token: 0x0400BD67 RID: 48487
		[Token(Token = "0x400BD67")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _btnVisitNext;

		// Token: 0x0400BD68 RID: 48488
		[Token(Token = "0x400BD68")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _iconVisitOrange;

		// Token: 0x0400BD69 RID: 48489
		[Token(Token = "0x400BD69")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _iconVisitGray;

		// Token: 0x0400BD6A RID: 48490
		[Token(Token = "0x400BD6A")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _textSocialPoint;

		// Token: 0x0400BD6B RID: 48491
		[Token(Token = "0x400BD6B")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _textRoomName;

		// Token: 0x0400BD6C RID: 48492
		[Token(Token = "0x400BD6C")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private BuildingNameCardView _nameCardView;

		// Token: 0x0400BD6D RID: 48493
		[Token(Token = "0x400BD6D")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private BuildingFloatVisitFocusBtn _focusBtn;

		// Token: 0x0400BD6E RID: 48494
		[Token(Token = "0x400BD6E")]
		[FieldOffset(Offset = "0x80")]
		private GetOtherPlayerNameCardResponse m_cachedResponse;

		// Token: 0x0400BD6F RID: 48495
		[Token(Token = "0x400BD6F")]
		[FieldOffset(Offset = "0x88")]
		private BuildingVisitContext.FriendInfo m_nextFriend;

		// Token: 0x0400BD70 RID: 48496
		[Token(Token = "0x400BD70")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_state;

		// Token: 0x0400BD71 RID: 48497
		[Token(Token = "0x400BD71")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__UpdateSocialPoint;

		// Token: 0x0400BD72 RID: 48498
		[Token(Token = "0x400BD72")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__UpdateRoomName;

		// Token: 0x0400BD73 RID: 48499
		[Token(Token = "0x400BD73")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OpenFriendNameCard;

		// Token: 0x0400BD74 RID: 48500
		[Token(Token = "0x400BD74")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0400BD75 RID: 48501
		[Token(Token = "0x400BD75")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnStateUpdated;

		// Token: 0x0400BD76 RID: 48502
		[Token(Token = "0x400BD76")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnSendClueButtonPressed;

		// Token: 0x0400BD77 RID: 48503
		[Token(Token = "0x400BD77")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_EventOnVisitNextClicked;

		// Token: 0x0400BD78 RID: 48504
		[Token(Token = "0x400BD78")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_EventOnNameCardClicked;

		// Token: 0x0400BD79 RID: 48505
		[Token(Token = "0x400BD79")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x0400BD7A RID: 48506
		[Token(Token = "0x400BD7A")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnDisable;

		// Token: 0x0400BD7B RID: 48507
		[Token(Token = "0x400BD7B")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_CheckIfDataChanged;

		// Token: 0x0400BD7C RID: 48508
		[Token(Token = "0x400BD7C")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnPlayerDataChanged;

		// Token: 0x0400BD7D RID: 48509
		[Token(Token = "0x400BD7D")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
