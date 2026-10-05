using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Building.UI.LaborAccel;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Building.UI.Trading
{
	// Token: 0x02001C1B RID: 7195
	[Token(Token = "0x2001C1B")]
	public class BuildingTradingHomeState : State
	{
		// Token: 0x0600B355 RID: 45909 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B355")]
		[Address(RVA = "0x32D49F0", Offset = "0x32D35F0", VA = "0x1832D49F0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0600B356 RID: 45910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B356")]
		[Address(RVA = "0x32D4A50", Offset = "0x32D3650", VA = "0x1832D4A50", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0600B357 RID: 45911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B357")]
		[Address(RVA = "0x32D50F0", Offset = "0x32D3CF0", VA = "0x1832D50F0", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0600B358 RID: 45912 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B358")]
		[Address(RVA = "0x32D51E0", Offset = "0x32D3DE0", VA = "0x1832D51E0", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0600B359 RID: 45913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B359")]
		[Address(RVA = "0x32D4950", Offset = "0x32D3550", VA = "0x1832D4950")]
		public void EventOnNegotiationClicked()
		{
		}

		// Token: 0x0600B35A RID: 45914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B35A")]
		[Address(RVA = "0x32D58F0", Offset = "0x32D44F0", VA = "0x1832D58F0")]
		private void _OnCharClicked(BuildingCharModel model, int index)
		{
		}

		// Token: 0x0600B35B RID: 45915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B35B")]
		[Address(RVA = "0x32D6570", Offset = "0x32D5170", VA = "0x1832D6570")]
		private void _OnRoomSelected(string slotId)
		{
		}

		// Token: 0x0600B35C RID: 45916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B35C")]
		[Address(RVA = "0x32D5CE0", Offset = "0x32D48E0", VA = "0x1832D5CE0")]
		private void _OnFinishOrder(long orderId)
		{
		}

		// Token: 0x0600B35D RID: 45917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B35D")]
		[Address(RVA = "0x32D5A20", Offset = "0x32D4620", VA = "0x1832D5A20")]
		private void _OnDeleteOrder(long orderId)
		{
		}

		// Token: 0x0600B35E RID: 45918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B35E")]
		[Address(RVA = "0x32D6440", Offset = "0x32D5040", VA = "0x1832D6440")]
		private void _OnLaborAccelClicked()
		{
		}

		// Token: 0x0600B35F RID: 45919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B35F")]
		[Address(RVA = "0x32D6500", Offset = "0x32D5100", VA = "0x1832D6500")]
		private void _OnPlayerDataChanged()
		{
		}

		// Token: 0x0600B360 RID: 45920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B360")]
		[Address(RVA = "0x32D5820", Offset = "0x32D4420", VA = "0x1832D5820")]
		private void _InitTopMenu()
		{
		}

		// Token: 0x0600B361 RID: 45921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B361")]
		[Address(RVA = "0x32D60E0", Offset = "0x32D4CE0", VA = "0x1832D60E0")]
		private void _OnJumpToLaborAccel(LaborAccelStateBean stateBean)
		{
		}

		// Token: 0x0600B362 RID: 45922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B362")]
		[Address(RVA = "0x32D6350", Offset = "0x32D4F50", VA = "0x1832D6350")]
		private void _OnJumpToNegotiationState(TradingNegoiationBean stateBean)
		{
		}

		// Token: 0x0600B363 RID: 45923 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B363")]
		[Address(RVA = "0x32D5770", Offset = "0x32D4370", VA = "0x1832D5770")]
		private IEnumerator _DeliveryOrderEffectCoroutine()
		{
			return null;
		}

		// Token: 0x0600B364 RID: 45924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B364")]
		[Address(RVA = "0x32D6600", Offset = "0x32D5200", VA = "0x1832D6600")]
		private void _SendDeleteOrderService(string slotId, long orderId)
		{
		}

		// Token: 0x0600B365 RID: 45925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B365")]
		[Address(RVA = "0x32D6800", Offset = "0x32D5400", VA = "0x1832D6800")]
		public BuildingTradingHomeState()
		{
		}

		// Token: 0x0600B36B RID: 45931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B36B")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0600B36C RID: 45932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B36C")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0600B36D RID: 45933 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B36D")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0400AEB0 RID: 44720
		[Token(Token = "0x400AEB0")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private PrefabInstHolder _topMenuHolder;

		// Token: 0x0400AEB1 RID: 44721
		[Token(Token = "0x400AEB1")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private BuildingTradingRoomTitleView _roomTitle;

		// Token: 0x0400AEB2 RID: 44722
		[Token(Token = "0x400AEB2")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private BuildingTradingTabGroup _roomTabGroup;

		// Token: 0x0400AEB3 RID: 44723
		[Token(Token = "0x400AEB3")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private BuildingTradingStationView _stationView;

		// Token: 0x0400AEB4 RID: 44724
		[Token(Token = "0x400AEB4")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private BuildingTradingStatusView _statusView;

		// Token: 0x0400AEB5 RID: 44725
		[Token(Token = "0x400AEB5")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private BuildingTradingOrderList _orderList;

		// Token: 0x0400AEB6 RID: 44726
		[Token(Token = "0x400AEB6")]
		[FieldOffset(Offset = "0x80")]
		private TradingStateBean m_stateBean;

		// Token: 0x0400AEB7 RID: 44727
		[Token(Token = "0x400AEB7")]
		[FieldOffset(Offset = "0x88")]
		private long m_laborAccelOrderCache;

		// Token: 0x0400AEB8 RID: 44728
		[Token(Token = "0x400AEB8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0400AEB9 RID: 44729
		[Token(Token = "0x400AEB9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0400AEBA RID: 44730
		[Token(Token = "0x400AEBA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0400AEBB RID: 44731
		[Token(Token = "0x400AEBB")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x0400AEBC RID: 44732
		[Token(Token = "0x400AEBC")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnNegotiationClicked;

		// Token: 0x0400AEBD RID: 44733
		[Token(Token = "0x400AEBD")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnCharClicked;

		// Token: 0x0400AEBE RID: 44734
		[Token(Token = "0x400AEBE")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnRoomSelected;

		// Token: 0x0400AEBF RID: 44735
		[Token(Token = "0x400AEBF")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnFinishOrder;

		// Token: 0x0400AEC0 RID: 44736
		[Token(Token = "0x400AEC0")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnDeleteOrder;

		// Token: 0x0400AEC1 RID: 44737
		[Token(Token = "0x400AEC1")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OnLaborAccelClicked;

		// Token: 0x0400AEC2 RID: 44738
		[Token(Token = "0x400AEC2")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnPlayerDataChanged;

		// Token: 0x0400AEC3 RID: 44739
		[Token(Token = "0x400AEC3")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__InitTopMenu;

		// Token: 0x0400AEC4 RID: 44740
		[Token(Token = "0x400AEC4")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__OnJumpToLaborAccel;

		// Token: 0x0400AEC5 RID: 44741
		[Token(Token = "0x400AEC5")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__OnJumpToNegotiationState;

		// Token: 0x0400AEC6 RID: 44742
		[Token(Token = "0x400AEC6")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__DeliveryOrderEffectCoroutine;

		// Token: 0x0400AEC7 RID: 44743
		[Token(Token = "0x400AEC7")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__SendDeleteOrderService;

		// Token: 0x0400AEC8 RID: 44744
		[Token(Token = "0x400AEC8")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001C1C RID: 7196
		[Token(Token = "0x2001C1C")]
		private class LaborAccelPlugin : BuildingLaborAccelState.Plugin<BuildingTradingHomeState>
		{
			// Token: 0x0600B36E RID: 45934 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B36E")]
			[Address(RVA = "0x32E4490", Offset = "0x32E3090", VA = "0x1832E4490", Slot = "7")]
			public override void OnConfirm(Action dismissSelf)
			{
			}

			// Token: 0x0600B36F RID: 45935 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B36F")]
			[Address(RVA = "0x32E4890", Offset = "0x32E3490", VA = "0x1832E4890")]
			public LaborAccelPlugin()
			{
			}
		}
	}
}
