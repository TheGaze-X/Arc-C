using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Building.UI.SM
{
	// Token: 0x02001CB4 RID: 7348
	[Token(Token = "0x2001CB4")]
	public class BuildingStationManageHomeState : State, IValueMsgReceiver
	{
		// Token: 0x0600B617 RID: 46615 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B617")]
		[Address(RVA = "0x330B1E0", Offset = "0x3309DE0", VA = "0x18330B1E0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0600B618 RID: 46616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B618")]
		[Address(RVA = "0x330BBF0", Offset = "0x330A7F0", VA = "0x18330BBF0", Slot = "23")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x0600B619 RID: 46617 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B619")]
		[Address(RVA = "0x330C590", Offset = "0x330B190", VA = "0x18330C590", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0600B61A RID: 46618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B61A")]
		[Address(RVA = "0x330D1F0", Offset = "0x330BDF0", VA = "0x18330D1F0")]
		private void _OnJumpToEditQueueState(StationManageEditQueueStateBean stateBean)
		{
		}

		// Token: 0x0600B61B RID: 46619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B61B")]
		[Address(RVA = "0x330B7D0", Offset = "0x330A3D0", VA = "0x18330B7D0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0600B61C RID: 46620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B61C")]
		[Address(RVA = "0x330C4D0", Offset = "0x330B0D0", VA = "0x18330C4D0", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0600B61D RID: 46621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B61D")]
		[Address(RVA = "0x330B6E0", Offset = "0x330A2E0", VA = "0x18330B6E0")]
		public void OnEnterDormEditLockClicked()
		{
		}

		// Token: 0x0600B61E RID: 46622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B61E")]
		[Address(RVA = "0x330B240", Offset = "0x3309E40", VA = "0x18330B240")]
		public void OnClearDormEditLockClicked()
		{
		}

		// Token: 0x0600B61F RID: 46623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B61F")]
		[Address(RVA = "0x330B380", Offset = "0x3309F80", VA = "0x18330B380")]
		public void OnConfirmDormEditLockClicked()
		{
		}

		// Token: 0x0600B620 RID: 46624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B620")]
		[Address(RVA = "0x330D3E0", Offset = "0x330BFE0", VA = "0x18330D3E0")]
		private void _OnRoomClicked(StationRoomStructModel target)
		{
		}

		// Token: 0x0600B621 RID: 46625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B621")]
		[Address(RVA = "0x330D2A0", Offset = "0x330BEA0", VA = "0x18330D2A0")]
		private void _OnPlayerDataChanged()
		{
		}

		// Token: 0x0600B622 RID: 46626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B622")]
		[Address(RVA = "0x330D860", Offset = "0x330C460", VA = "0x18330D860")]
		private void _OnUseQueueClicked(StationRoomStructModel target)
		{
		}

		// Token: 0x0600B623 RID: 46627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B623")]
		[Address(RVA = "0x330D060", Offset = "0x330BC60", VA = "0x18330D060")]
		private void _OnEditQueueClicked(StationRoomStructModel target)
		{
		}

		// Token: 0x0600B624 RID: 46628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B624")]
		[Address(RVA = "0x330D6C0", Offset = "0x330C2C0", VA = "0x18330D6C0")]
		private void _OnSwitchModeClicked()
		{
		}

		// Token: 0x0600B625 RID: 46629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B625")]
		[Address(RVA = "0x330CAB0", Offset = "0x330B6B0", VA = "0x18330CAB0")]
		private void _OnBatchWork()
		{
		}

		// Token: 0x0600B626 RID: 46630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B626")]
		[Address(RVA = "0x330CCB0", Offset = "0x330B8B0", VA = "0x18330CCB0")]
		private void _OnCannotBatchWork()
		{
		}

		// Token: 0x0600B627 RID: 46631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B627")]
		[Address(RVA = "0x330CA50", Offset = "0x330B650", VA = "0x18330CA50")]
		private void _OnBatchRest()
		{
		}

		// Token: 0x0600B628 RID: 46632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B628")]
		[Address(RVA = "0x330CB10", Offset = "0x330B710", VA = "0x18330CB10")]
		private void _OnCannotBatchRest()
		{
		}

		// Token: 0x0600B629 RID: 46633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B629")]
		[Address(RVA = "0x330CEC0", Offset = "0x330BAC0", VA = "0x18330CEC0")]
		private void _OnEditDormLock(EditLockInfo editLockInfo)
		{
		}

		// Token: 0x0600B62A RID: 46634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B62A")]
		[Address(RVA = "0x330D950", Offset = "0x330C550", VA = "0x18330D950")]
		private void _SendSaveDormLockRequest(Dictionary<string, int[]> lockData)
		{
		}

		// Token: 0x0600B62B RID: 46635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B62B")]
		[Address(RVA = "0x330C7B0", Offset = "0x330B3B0", VA = "0x18330C7B0")]
		private void _OnBackBtnClicked()
		{
		}

		// Token: 0x0600B62C RID: 46636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B62C")]
		[Address(RVA = "0x330DA20", Offset = "0x330C620", VA = "0x18330DA20")]
		public BuildingStationManageHomeState()
		{
		}

		// Token: 0x0600B631 RID: 46641 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B631")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0600B632 RID: 46642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B632")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0600B633 RID: 46643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B633")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0400B2E0 RID: 45792
		[Token(Token = "0x400B2E0")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private BuildingStationManageView _view;

		// Token: 0x0400B2E1 RID: 45793
		[Token(Token = "0x400B2E1")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private TopMenuDynamicPrefabInstHolder _topMenuHodler;

		// Token: 0x0400B2E2 RID: 45794
		[Token(Token = "0x400B2E2")]
		[NonSerialized]
		public const int MSG_ROOM_CLICK = 0;

		// Token: 0x0400B2E3 RID: 45795
		[Token(Token = "0x400B2E3")]
		[NonSerialized]
		public const int MSG_USE_QUEUE_CLICK = 1;

		// Token: 0x0400B2E4 RID: 45796
		[Token(Token = "0x400B2E4")]
		[NonSerialized]
		public const int MSG_EDIT_QUEUE_CLICK = 2;

		// Token: 0x0400B2E5 RID: 45797
		[Token(Token = "0x400B2E5")]
		[NonSerialized]
		public const int MSG_BATCH_WORK_CLICK = 3;

		// Token: 0x0400B2E6 RID: 45798
		[Token(Token = "0x400B2E6")]
		[NonSerialized]
		public const int MSG_BATCH_WORK_INACTIVE_CLICK = 4;

		// Token: 0x0400B2E7 RID: 45799
		[Token(Token = "0x400B2E7")]
		[NonSerialized]
		public const int MSG_BATCH_REST_CLICK = 5;

		// Token: 0x0400B2E8 RID: 45800
		[Token(Token = "0x400B2E8")]
		[NonSerialized]
		public const int MSG_BATCH_REST_INACTIVE_CLICK = 6;

		// Token: 0x0400B2E9 RID: 45801
		[Token(Token = "0x400B2E9")]
		[NonSerialized]
		public const int MSG_USE_QUEUE_NOT_AVAIL_CLICK = 7;

		// Token: 0x0400B2EA RID: 45802
		[Token(Token = "0x400B2EA")]
		[NonSerialized]
		public const int MSG_ON_CHAR_ANIM = 8;

		// Token: 0x0400B2EB RID: 45803
		[Token(Token = "0x400B2EB")]
		[NonSerialized]
		public const int MSG_ON_EDIT_DORM_LOCK = 9;

		// Token: 0x0400B2EC RID: 45804
		[Token(Token = "0x400B2EC")]
		[FieldOffset(Offset = "0x60")]
		private StationHomeStateBean m_stateBean;

		// Token: 0x0400B2ED RID: 45805
		[Token(Token = "0x400B2ED")]
		[FieldOffset(Offset = "0x68")]
		private RoomSlotModel m_curEditSlotModel;

		// Token: 0x0400B2EE RID: 45806
		[Token(Token = "0x400B2EE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0400B2EF RID: 45807
		[Token(Token = "0x400B2EF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x0400B2F0 RID: 45808
		[Token(Token = "0x400B2F0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x0400B2F1 RID: 45809
		[Token(Token = "0x400B2F1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnJumpToEditQueueState;

		// Token: 0x0400B2F2 RID: 45810
		[Token(Token = "0x400B2F2")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0400B2F3 RID: 45811
		[Token(Token = "0x400B2F3")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0400B2F4 RID: 45812
		[Token(Token = "0x400B2F4")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnEnterDormEditLockClicked;

		// Token: 0x0400B2F5 RID: 45813
		[Token(Token = "0x400B2F5")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnClearDormEditLockClicked;

		// Token: 0x0400B2F6 RID: 45814
		[Token(Token = "0x400B2F6")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnConfirmDormEditLockClicked;

		// Token: 0x0400B2F7 RID: 45815
		[Token(Token = "0x400B2F7")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OnRoomClicked;

		// Token: 0x0400B2F8 RID: 45816
		[Token(Token = "0x400B2F8")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnPlayerDataChanged;

		// Token: 0x0400B2F9 RID: 45817
		[Token(Token = "0x400B2F9")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__OnUseQueueClicked;

		// Token: 0x0400B2FA RID: 45818
		[Token(Token = "0x400B2FA")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__OnEditQueueClicked;

		// Token: 0x0400B2FB RID: 45819
		[Token(Token = "0x400B2FB")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__OnSwitchModeClicked;

		// Token: 0x0400B2FC RID: 45820
		[Token(Token = "0x400B2FC")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__OnBatchWork;

		// Token: 0x0400B2FD RID: 45821
		[Token(Token = "0x400B2FD")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__OnCannotBatchWork;

		// Token: 0x0400B2FE RID: 45822
		[Token(Token = "0x400B2FE")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__OnBatchRest;

		// Token: 0x0400B2FF RID: 45823
		[Token(Token = "0x400B2FF")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__OnCannotBatchRest;

		// Token: 0x0400B300 RID: 45824
		[Token(Token = "0x400B300")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__OnEditDormLock;

		// Token: 0x0400B301 RID: 45825
		[Token(Token = "0x400B301")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__SendSaveDormLockRequest;

		// Token: 0x0400B302 RID: 45826
		[Token(Token = "0x400B302")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__OnBackBtnClicked;

		// Token: 0x0400B303 RID: 45827
		[Token(Token = "0x400B303")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
