using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Building.UI.LaborAccel;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Building.UI.Manufact
{
	// Token: 0x02001D97 RID: 7575
	[Token(Token = "0x2001D97")]
	public class BuildingManufactHomeState : State, ITimeWatcher
	{
		// Token: 0x0600BAD7 RID: 47831 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600BAD7")]
		[Address(RVA = "0x336DEB0", Offset = "0x336CAB0", VA = "0x18336DEB0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0600BAD8 RID: 47832 RVA: 0x00045DE0 File Offset: 0x00043FE0
		[Token(Token = "0x600BAD8")]
		[Address(RVA = "0x336F3C0", Offset = "0x336DFC0", VA = "0x18336F3C0", Slot = "12")]
		public override bool UseEarlyFromDataListener(Type fromState)
		{
			return default(bool);
		}

		// Token: 0x0600BAD9 RID: 47833 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600BAD9")]
		[Address(RVA = "0x336E910", Offset = "0x336D510", VA = "0x18336E910", Slot = "11")]
		public override Dictionary<Type, Action<IStateBean>> RegisterFromDataListener()
		{
			return null;
		}

		// Token: 0x0600BADA RID: 47834 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600BADA")]
		[Address(RVA = "0x336EA70", Offset = "0x336D670", VA = "0x18336EA70", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0600BADB RID: 47835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BADB")]
		[Address(RVA = "0x336DF10", Offset = "0x336CB10", VA = "0x18336DF10", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0600BADC RID: 47836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BADC")]
		[Address(RVA = "0x336E8A0", Offset = "0x336D4A0", VA = "0x18336E8A0", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0600BADD RID: 47837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BADD")]
		[Address(RVA = "0x336E7E0", Offset = "0x336D3E0", VA = "0x18336E7E0", Slot = "18")]
		protected override void OnExit()
		{
		}

		// Token: 0x0600BADE RID: 47838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BADE")]
		[Address(RVA = "0x336F500", Offset = "0x336E100", VA = "0x18336F500")]
		private void _InitTopMenu()
		{
		}

		// Token: 0x0600BADF RID: 47839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BADF")]
		[Address(RVA = "0x336DC90", Offset = "0x336C890", VA = "0x18336DC90")]
		public void EventOnHarestClick()
		{
		}

		// Token: 0x0600BAE0 RID: 47840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BAE0")]
		[Address(RVA = "0x336DD30", Offset = "0x336C930", VA = "0x18336DD30")]
		public void EventOnLaborAccelClick()
		{
		}

		// Token: 0x0600BAE1 RID: 47841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BAE1")]
		[Address(RVA = "0x336FE60", Offset = "0x336EA60", VA = "0x18336FE60")]
		private void _OnJumpToFormulaState(MFormulaStateBean formulaBean)
		{
		}

		// Token: 0x0600BAE2 RID: 47842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BAE2")]
		[Address(RVA = "0x336FD00", Offset = "0x336E900", VA = "0x18336FD00")]
		private void _OnJumpBackFromFormulaState(MFormulaStateBean formulaBean)
		{
		}

		// Token: 0x0600BAE3 RID: 47843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BAE3")]
		[Address(RVA = "0x336FF80", Offset = "0x336EB80", VA = "0x18336FF80")]
		private void _OnJumpToLaborAccelState(LaborAccelStateBean laborAccelBean)
		{
		}

		// Token: 0x0600BAE4 RID: 47844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BAE4")]
		[Address(RVA = "0x33701F0", Offset = "0x336EDF0", VA = "0x1833701F0")]
		private void _OnRoomSelected(string slotId)
		{
		}

		// Token: 0x0600BAE5 RID: 47845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BAE5")]
		[Address(RVA = "0x336F9B0", Offset = "0x336E5B0", VA = "0x18336F9B0")]
		private void _OnConfirmEdit()
		{
		}

		// Token: 0x0600BAE6 RID: 47846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BAE6")]
		[Address(RVA = "0x336F5D0", Offset = "0x336E1D0", VA = "0x18336F5D0")]
		private void _OnCancelEdit()
		{
		}

		// Token: 0x0600BAE7 RID: 47847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BAE7")]
		[Address(RVA = "0x336FC60", Offset = "0x336E860", VA = "0x18336FC60")]
		private void _OnEditFormula()
		{
		}

		// Token: 0x0600BAE8 RID: 47848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BAE8")]
		[Address(RVA = "0x336F640", Offset = "0x336E240", VA = "0x18336F640")]
		private void _OnChangeCount(int delta)
		{
		}

		// Token: 0x0600BAE9 RID: 47849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BAE9")]
		[Address(RVA = "0x336F760", Offset = "0x336E360", VA = "0x18336F760")]
		private void _OnCharAvatarClick(BuildingCharModel charModel, int index)
		{
		}

		// Token: 0x0600BAEA RID: 47850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BAEA")]
		[Address(RVA = "0x336F2E0", Offset = "0x336DEE0", VA = "0x18336F2E0", Slot = "23")]
		public void UpdateTime(float deltaTime)
		{
		}

		// Token: 0x0600BAEB RID: 47851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BAEB")]
		[Address(RVA = "0x3370180", Offset = "0x336ED80", VA = "0x183370180")]
		private void _OnPlayerDataChanged()
		{
		}

		// Token: 0x0600BAEC RID: 47852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BAEC")]
		[Address(RVA = "0x33708D0", Offset = "0x336F4D0", VA = "0x1833708D0")]
		private void _SettleManufact()
		{
		}

		// Token: 0x0600BAED RID: 47853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BAED")]
		[Address(RVA = "0x3370490", Offset = "0x336F090", VA = "0x183370490")]
		private void _SendConfirmFormulaChangeService()
		{
		}

		// Token: 0x0600BAEE RID: 47854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BAEE")]
		[Address(RVA = "0x3370AD0", Offset = "0x336F6D0", VA = "0x183370AD0")]
		private void _TryRequestSettleEffect()
		{
		}

		// Token: 0x0600BAEF RID: 47855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BAEF")]
		[Address(RVA = "0x336F430", Offset = "0x336E030", VA = "0x18336F430")]
		private void _ClearResEffects()
		{
		}

		// Token: 0x0600BAF0 RID: 47856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BAF0")]
		[Address(RVA = "0x3370DB0", Offset = "0x336F9B0", VA = "0x183370DB0")]
		public BuildingManufactHomeState()
		{
		}

		// Token: 0x0600BAF7 RID: 47863 RVA: 0x00045DF8 File Offset: 0x00043FF8
		[Token(Token = "0x600BAF7")]
		[Address(RVA = "0x11033F0", Offset = "0x1101FF0", VA = "0x1811033F0")]
		private bool <>xLuaBaseProxy_UseEarlyFromDataListener(Type P0)
		{
			return default(bool);
		}

		// Token: 0x0600BAF8 RID: 47864 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600BAF8")]
		[Address(RVA = "0xE63470", Offset = "0xE62070", VA = "0x180E63470")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterFromDataListener()
		{
			return null;
		}

		// Token: 0x0600BAF9 RID: 47865 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600BAF9")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0600BAFA RID: 47866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BAFA")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0600BAFB RID: 47867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BAFB")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0600BAFC RID: 47868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BAFC")]
		[Address(RVA = "0xE63460", Offset = "0xE62060", VA = "0x180E63460")]
		private void <>xLuaBaseProxy_OnExit()
		{
		}

		// Token: 0x0400BA25 RID: 47653
		[Token(Token = "0x400BA25")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private TopMenuDynamicPrefabInstHolder _topMenuHolder;

		// Token: 0x0400BA26 RID: 47654
		[Token(Token = "0x400BA26")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private BuildingManufactTabGroup _tabGroup;

		// Token: 0x0400BA27 RID: 47655
		[Token(Token = "0x400BA27")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private PrefabInstHolder[] _inputSlots;

		// Token: 0x0400BA28 RID: 47656
		[Token(Token = "0x400BA28")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private BuildingManufactRemainCountView _remainCount;

		// Token: 0x0400BA29 RID: 47657
		[Token(Token = "0x400BA29")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private BuildingManufactOutputSlot _outputSlot;

		// Token: 0x0400BA2A RID: 47658
		[Token(Token = "0x400BA2A")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private BuildingManufactOutputCountView _outputCount;

		// Token: 0x0400BA2B RID: 47659
		[Token(Token = "0x400BA2B")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private BuildingManufactStationView _stationView;

		// Token: 0x0400BA2C RID: 47660
		[Token(Token = "0x400BA2C")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private BuildingManufactRoomTitle _roomTitle;

		// Token: 0x0400BA2D RID: 47661
		[Token(Token = "0x400BA2D")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private BuildingManufactSpeedInfoView _speedInfo;

		// Token: 0x0400BA2E RID: 47662
		[Token(Token = "0x400BA2E")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private RectTransform _settleAnchor;

		// Token: 0x0400BA2F RID: 47663
		[Token(Token = "0x400BA2F")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private TwoStateToggle _labelAccelButton;

		// Token: 0x0400BA30 RID: 47664
		[Token(Token = "0x400BA30")]
		[FieldOffset(Offset = "0xA8")]
		private MHomeStateBean m_stateBean;

		// Token: 0x0400BA31 RID: 47665
		[Token(Token = "0x400BA31")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0400BA32 RID: 47666
		[Token(Token = "0x400BA32")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UseEarlyFromDataListener;

		// Token: 0x0400BA33 RID: 47667
		[Token(Token = "0x400BA33")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RegisterFromDataListener;

		// Token: 0x0400BA34 RID: 47668
		[Token(Token = "0x400BA34")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x0400BA35 RID: 47669
		[Token(Token = "0x400BA35")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0400BA36 RID: 47670
		[Token(Token = "0x400BA36")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0400BA37 RID: 47671
		[Token(Token = "0x400BA37")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x0400BA38 RID: 47672
		[Token(Token = "0x400BA38")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__InitTopMenu;

		// Token: 0x0400BA39 RID: 47673
		[Token(Token = "0x400BA39")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_EventOnHarestClick;

		// Token: 0x0400BA3A RID: 47674
		[Token(Token = "0x400BA3A")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_EventOnLaborAccelClick;

		// Token: 0x0400BA3B RID: 47675
		[Token(Token = "0x400BA3B")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnJumpToFormulaState;

		// Token: 0x0400BA3C RID: 47676
		[Token(Token = "0x400BA3C")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__OnJumpBackFromFormulaState;

		// Token: 0x0400BA3D RID: 47677
		[Token(Token = "0x400BA3D")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__OnJumpToLaborAccelState;

		// Token: 0x0400BA3E RID: 47678
		[Token(Token = "0x400BA3E")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__OnRoomSelected;

		// Token: 0x0400BA3F RID: 47679
		[Token(Token = "0x400BA3F")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__OnConfirmEdit;

		// Token: 0x0400BA40 RID: 47680
		[Token(Token = "0x400BA40")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__OnCancelEdit;

		// Token: 0x0400BA41 RID: 47681
		[Token(Token = "0x400BA41")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__OnEditFormula;

		// Token: 0x0400BA42 RID: 47682
		[Token(Token = "0x400BA42")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__OnChangeCount;

		// Token: 0x0400BA43 RID: 47683
		[Token(Token = "0x400BA43")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__OnCharAvatarClick;

		// Token: 0x0400BA44 RID: 47684
		[Token(Token = "0x400BA44")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_UpdateTime;

		// Token: 0x0400BA45 RID: 47685
		[Token(Token = "0x400BA45")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__OnPlayerDataChanged;

		// Token: 0x0400BA46 RID: 47686
		[Token(Token = "0x400BA46")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__SettleManufact;

		// Token: 0x0400BA47 RID: 47687
		[Token(Token = "0x400BA47")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__SendConfirmFormulaChangeService;

		// Token: 0x0400BA48 RID: 47688
		[Token(Token = "0x400BA48")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__TryRequestSettleEffect;

		// Token: 0x0400BA49 RID: 47689
		[Token(Token = "0x400BA49")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__ClearResEffects;

		// Token: 0x0400BA4A RID: 47690
		[Token(Token = "0x400BA4A")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001D98 RID: 7576
		[Token(Token = "0x2001D98")]
		private class LaborAccelPlugin : BuildingLaborAccelState.Plugin<BuildingManufactHomeState>
		{
			// Token: 0x0600BAFD RID: 47869 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600BAFD")]
			[Address(RVA = "0x3372600", Offset = "0x3371200", VA = "0x183372600", Slot = "7")]
			public override void OnConfirm(Action dismissSelf)
			{
			}

			// Token: 0x0600BAFE RID: 47870 RVA: 0x00045E10 File Offset: 0x00044010
			[Token(Token = "0x600BAFE")]
			[Address(RVA = "0x33729E0", Offset = "0x33715E0", VA = "0x1833729E0", Slot = "8")]
			public override BuildingLaborAccelState.AccelResultOptions UpdateAccelResult()
			{
				return default(BuildingLaborAccelState.AccelResultOptions);
			}

			// Token: 0x0600BAFF RID: 47871 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600BAFF")]
			[Address(RVA = "0x3372BB0", Offset = "0x33717B0", VA = "0x183372BB0")]
			public LaborAccelPlugin()
			{
			}
		}
	}
}
