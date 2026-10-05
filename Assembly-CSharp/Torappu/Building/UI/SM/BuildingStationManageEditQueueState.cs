using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.Building.UI.StationSelect;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.UI.SM
{
	// Token: 0x02001CB1 RID: 7345
	[Token(Token = "0x2001CB1")]
	public class BuildingStationManageEditQueueState : PopupFloatState
	{
		// Token: 0x170015DD RID: 5597
		// (get) Token: 0x0600B5F7 RID: 46583 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170015DD")]
		private RoomSlotModel m_curSlotModel
		{
			[Token(Token = "0x600B5F7")]
			[Address(RVA = "0x330B150", Offset = "0x3309D50", VA = "0x18330B150")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600B5F8 RID: 46584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B5F8")]
		[Address(RVA = "0x33096C0", Offset = "0x33082C0", VA = "0x1833096C0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0600B5F9 RID: 46585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B5F9")]
		[Address(RVA = "0x33090D0", Offset = "0x3307CD0", VA = "0x1833090D0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0600B5FA RID: 46586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B5FA")]
		[Address(RVA = "0x33092E0", Offset = "0x3307EE0", VA = "0x1833092E0", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0600B5FB RID: 46587 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B5FB")]
		[Address(RVA = "0x33094C0", Offset = "0x33080C0", VA = "0x1833094C0", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0600B5FC RID: 46588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B5FC")]
		[Address(RVA = "0x330AD70", Offset = "0x3309970", VA = "0x18330AD70")]
		private void _RenderRoomView(BuildingModel buildingModel, RoomSlotModel roomSlotModel)
		{
		}

		// Token: 0x0600B5FD RID: 46589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B5FD")]
		[Address(RVA = "0x330A6E0", Offset = "0x33092E0", VA = "0x18330A6E0")]
		private void _Refresh()
		{
		}

		// Token: 0x0600B5FE RID: 46590 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B5FE")]
		[Address(RVA = "0x3309070", Offset = "0x3307C70", VA = "0x183309070", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0600B5FF RID: 46591 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B5FF")]
		[Address(RVA = "0x330AE30", Offset = "0x3309A30", VA = "0x18330AE30")]
		private IEnumerator _SwitchRoomCoroutine(string outAnimName, AnimationWrapper outAnimWrapper, string inAnimName, AnimationWrapper inAnimWrapper, TweenCallback outAnimCallback)
		{
			return null;
		}

		// Token: 0x0600B600 RID: 46592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B600")]
		[Address(RVA = "0x330A8B0", Offset = "0x33094B0", VA = "0x18330A8B0")]
		private void _RenderNextRoom()
		{
		}

		// Token: 0x0600B601 RID: 46593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B601")]
		[Address(RVA = "0x330AB10", Offset = "0x3309710", VA = "0x18330AB10")]
		private void _RenderPrefRoom()
		{
		}

		// Token: 0x0600B602 RID: 46594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B602")]
		[Address(RVA = "0x330A4A0", Offset = "0x33090A0", VA = "0x18330A4A0")]
		private void _OnPlayerDataUpdate()
		{
		}

		// Token: 0x0600B603 RID: 46595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B603")]
		[Address(RVA = "0x330A1B0", Offset = "0x3308DB0", VA = "0x18330A1B0")]
		private void _OnJumpToSelectConfirmState(StationSelectConfirmStateBean selectConfirmBean)
		{
		}

		// Token: 0x0600B604 RID: 46596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B604")]
		[Address(RVA = "0x3308D70", Offset = "0x3307970", VA = "0x183308D70")]
		public void EventOnBackgroundClicked()
		{
		}

		// Token: 0x0600B605 RID: 46597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B605")]
		[Address(RVA = "0x3308E10", Offset = "0x3307A10", VA = "0x183308E10")]
		public void EventOnNextClicked()
		{
		}

		// Token: 0x0600B606 RID: 46598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B606")]
		[Address(RVA = "0x3308F40", Offset = "0x3307B40", VA = "0x183308F40")]
		public void EventOnPrefClicked()
		{
		}

		// Token: 0x0600B607 RID: 46599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B607")]
		[Address(RVA = "0x330A030", Offset = "0x3308C30", VA = "0x18330A030")]
		private void _OnCharClicked(BuildingCharModel target, object param)
		{
		}

		// Token: 0x0600B608 RID: 46600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B608")]
		[Address(RVA = "0x330A550", Offset = "0x3309150", VA = "0x18330A550")]
		private void _OnPreQueueCharClicked(BuildingCharModel target, object param)
		{
		}

		// Token: 0x0600B609 RID: 46601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B609")]
		[Address(RVA = "0x3309A70", Offset = "0x3308670", VA = "0x183309A70")]
		private void _OnApplyPreQueueClicked(RoomSlotModel roomSlotModel, int preQueueIndex)
		{
		}

		// Token: 0x0600B60A RID: 46602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B60A")]
		[Address(RVA = "0x330AF80", Offset = "0x3309B80", VA = "0x18330AF80")]
		public BuildingStationManageEditQueueState()
		{
		}

		// Token: 0x0600B60C RID: 46604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B60C")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0600B60D RID: 46605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B60D")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0600B60E RID: 46606 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B60E")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0400B2B5 RID: 45749
		[Token(Token = "0x400B2B5")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private BuildingStationManageRoomStatusView _editRoomStatusView;

		// Token: 0x0400B2B6 RID: 45750
		[Token(Token = "0x400B2B6")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Button _btnArrowLeft;

		// Token: 0x0400B2B7 RID: 45751
		[Token(Token = "0x400B2B7")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Button _btnArrowRight;

		// Token: 0x0400B2B8 RID: 45752
		[Token(Token = "0x400B2B8")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private UIAnimationLocation _animLeftIn;

		// Token: 0x0400B2B9 RID: 45753
		[Token(Token = "0x400B2B9")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private UIAnimationLocation _animLeftOut;

		// Token: 0x0400B2BA RID: 45754
		[Token(Token = "0x400B2BA")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private UIAnimationLocation _animRightIn;

		// Token: 0x0400B2BB RID: 45755
		[Token(Token = "0x400B2BB")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private UIAnimationLocation _animRightOut;

		// Token: 0x0400B2BC RID: 45756
		[Token(Token = "0x400B2BC")]
		[FieldOffset(Offset = "0xC8")]
		private bool m_isInited;

		// Token: 0x0400B2BD RID: 45757
		[Token(Token = "0x400B2BD")]
		[FieldOffset(Offset = "0xD0")]
		private Tween m_switchAnim;

		// Token: 0x0400B2BE RID: 45758
		[Token(Token = "0x400B2BE")]
		[FieldOffset(Offset = "0xD8")]
		private bool m_enableClick;

		// Token: 0x0400B2BF RID: 45759
		[Token(Token = "0x400B2BF")]
		[FieldOffset(Offset = "0xE0")]
		private List<BuildingCharModel> m_tempSelectedChars;

		// Token: 0x0400B2C0 RID: 45760
		[Token(Token = "0x400B2C0")]
		[FieldOffset(Offset = "0xE8")]
		private StationManageEditQueueStateBean m_stateBean;

		// Token: 0x0400B2C1 RID: 45761
		[Token(Token = "0x400B2C1")]
		[FieldOffset(Offset = "0xF0")]
		private BuildingModel m_curBuildingModel;

		// Token: 0x0400B2C2 RID: 45762
		[Token(Token = "0x400B2C2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_m_curSlotModel;

		// Token: 0x0400B2C3 RID: 45763
		[Token(Token = "0x400B2C3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0400B2C4 RID: 45764
		[Token(Token = "0x400B2C4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0400B2C5 RID: 45765
		[Token(Token = "0x400B2C5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0400B2C6 RID: 45766
		[Token(Token = "0x400B2C6")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x0400B2C7 RID: 45767
		[Token(Token = "0x400B2C7")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RenderRoomView;

		// Token: 0x0400B2C8 RID: 45768
		[Token(Token = "0x400B2C8")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__Refresh;

		// Token: 0x0400B2C9 RID: 45769
		[Token(Token = "0x400B2C9")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0400B2CA RID: 45770
		[Token(Token = "0x400B2CA")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__SwitchRoomCoroutine;

		// Token: 0x0400B2CB RID: 45771
		[Token(Token = "0x400B2CB")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__RenderNextRoom;

		// Token: 0x0400B2CC RID: 45772
		[Token(Token = "0x400B2CC")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__RenderPrefRoom;

		// Token: 0x0400B2CD RID: 45773
		[Token(Token = "0x400B2CD")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__OnPlayerDataUpdate;

		// Token: 0x0400B2CE RID: 45774
		[Token(Token = "0x400B2CE")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__OnJumpToSelectConfirmState;

		// Token: 0x0400B2CF RID: 45775
		[Token(Token = "0x400B2CF")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_EventOnBackgroundClicked;

		// Token: 0x0400B2D0 RID: 45776
		[Token(Token = "0x400B2D0")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_EventOnNextClicked;

		// Token: 0x0400B2D1 RID: 45777
		[Token(Token = "0x400B2D1")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_EventOnPrefClicked;

		// Token: 0x0400B2D2 RID: 45778
		[Token(Token = "0x400B2D2")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__OnCharClicked;

		// Token: 0x0400B2D3 RID: 45779
		[Token(Token = "0x400B2D3")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__OnPreQueueCharClicked;

		// Token: 0x0400B2D4 RID: 45780
		[Token(Token = "0x400B2D4")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__OnApplyPreQueueClicked;

		// Token: 0x0400B2D5 RID: 45781
		[Token(Token = "0x400B2D5")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
