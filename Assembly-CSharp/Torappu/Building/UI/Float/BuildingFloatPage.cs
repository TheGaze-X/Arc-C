using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Building.DIY.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.UI.Float
{
	// Token: 0x02001DBD RID: 7613
	[Token(Token = "0x2001DBD")]
	public class BuildingFloatPage : BuildingCommonPage
	{
		// Token: 0x170016BD RID: 5821
		// (get) Token: 0x0600BBB5 RID: 48053 RVA: 0x00046038 File Offset: 0x00044238
		[Token(Token = "0x170016BD")]
		public override AVGPageKey avgPage
		{
			[Token(Token = "0x600BBB5")]
			[Address(RVA = "0x338EAE0", Offset = "0x338D6E0", VA = "0x18338EAE0", Slot = "20")]
			get
			{
				return AVGPageKey.NONE;
			}
		}

		// Token: 0x170016BE RID: 5822
		// (get) Token: 0x0600BBB6 RID: 48054 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170016BE")]
		public BuildingFloatArchSwitchView switchView
		{
			[Token(Token = "0x600BBB6")]
			[Address(RVA = "0x338EB50", Offset = "0x338D750", VA = "0x18338EB50")]
			get
			{
				return null;
			}
		}

		// Token: 0x170016BF RID: 5823
		// (get) Token: 0x0600BBB7 RID: 48055 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170016BF")]
		public UIArchitectureRoomDetailView arcRoomDetailView
		{
			[Token(Token = "0x600BBB7")]
			[Address(RVA = "0x338EA60", Offset = "0x338D660", VA = "0x18338EA60")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600BBB8 RID: 48056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BBB8")]
		[Address(RVA = "0x338AB20", Offset = "0x3389720", VA = "0x18338AB20", Slot = "8")]
		protected override void OnCreate(DataBundle savedInstance)
		{
		}

		// Token: 0x0600BBB9 RID: 48057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BBB9")]
		[Address(RVA = "0x338AE80", Offset = "0x3389A80", VA = "0x18338AE80", Slot = "10")]
		protected override void OnStart()
		{
		}

		// Token: 0x0600BBBA RID: 48058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BBBA")]
		[Address(RVA = "0x338B320", Offset = "0x3389F20", VA = "0x18338B320", Slot = "14")]
		protected override void OnStop()
		{
		}

		// Token: 0x0600BBBB RID: 48059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BBBB")]
		[Address(RVA = "0x338B040", Offset = "0x3389C40", VA = "0x18338B040", Slot = "28")]
		protected override void OnStateEngineReady(bool isFromStack)
		{
		}

		// Token: 0x0600BBBC RID: 48060 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600BBBC")]
		[Address(RVA = "0x338BD10", Offset = "0x338A910", VA = "0x18338BD10", Slot = "30")]
		public override ListDict<BuildingEvent, EventPool.EventCallbackDelegate> RegisterBuildingEvents()
		{
			return null;
		}

		// Token: 0x0600BBBD RID: 48061 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600BBBD")]
		[Address(RVA = "0x338A890", Offset = "0x3389490", VA = "0x18338A890", Slot = "26")]
		protected override IEnumerator EffectsOnHide(bool isIntoStack, bool isRemoveVirtualTop)
		{
			return null;
		}

		// Token: 0x0600BBBE RID: 48062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BBBE")]
		[Address(RVA = "0x338AA40", Offset = "0x3389640", VA = "0x18338AA40")]
		public void NotifyArchPopViewShow(IUIArchitectureBaseView view)
		{
		}

		// Token: 0x0600BBBF RID: 48063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BBBF")]
		[Address(RVA = "0x338A990", Offset = "0x3389590", VA = "0x18338A990")]
		public void NotifyArchPopViewClose(IUIArchitectureBaseView view)
		{
		}

		// Token: 0x0600BBC0 RID: 48064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BBC0")]
		[Address(RVA = "0x338C120", Offset = "0x338AD20", VA = "0x18338C120")]
		public void SendFloatStateSignal(string signal)
		{
		}

		// Token: 0x0600BBC1 RID: 48065 RVA: 0x00046050 File Offset: 0x00044250
		[Token(Token = "0x600BBC1")]
		[Address(RVA = "0x338CCA0", Offset = "0x338B8A0", VA = "0x18338CCA0")]
		private bool _ClosePopupViewAndInterruptBackEvent()
		{
			return default(bool);
		}

		// Token: 0x0600BBC2 RID: 48066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BBC2")]
		[Address(RVA = "0x338E160", Offset = "0x338CD60", VA = "0x18338E160")]
		private void _OnSelectRoom(object arg)
		{
		}

		// Token: 0x0600BBC3 RID: 48067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BBC3")]
		[Address(RVA = "0x338E3B0", Offset = "0x338CFB0", VA = "0x18338E3B0")]
		private void _OnUnSelectRoom(object arg)
		{
		}

		// Token: 0x0600BBC4 RID: 48068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BBC4")]
		[Address(RVA = "0x338E0D0", Offset = "0x338CCD0", VA = "0x18338E0D0")]
		private void _OnRoomRouteFail(object arg)
		{
		}

		// Token: 0x0600BBC5 RID: 48069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BBC5")]
		[Address(RVA = "0x338DC90", Offset = "0x338C890", VA = "0x18338DC90")]
		private void _OnBuildingModeChanged(object arg)
		{
		}

		// Token: 0x0600BBC6 RID: 48070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BBC6")]
		[Address(RVA = "0x338DD20", Offset = "0x338C920", VA = "0x18338DD20")]
		private void _OnOperationModeChanged(object arg)
		{
		}

		// Token: 0x0600BBC7 RID: 48071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BBC7")]
		[Address(RVA = "0x338E320", Offset = "0x338CF20", VA = "0x18338E320")]
		private void _OnToDoNotifyStateChanged(object arg)
		{
		}

		// Token: 0x0600BBC8 RID: 48072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BBC8")]
		[Address(RVA = "0x338DDB0", Offset = "0x338C9B0", VA = "0x18338DDB0")]
		private void _OnPlayerDataChanged()
		{
		}

		// Token: 0x0600BBC9 RID: 48073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BBC9")]
		[Address(RVA = "0x338DFF0", Offset = "0x338CBF0", VA = "0x18338DFF0")]
		private void _OnRequestDIY(object arg)
		{
		}

		// Token: 0x0600BBCA RID: 48074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BBCA")]
		[Address(RVA = "0x338DB30", Offset = "0x338C730", VA = "0x18338DB30")]
		private void _OnBpRoomSettleRequested(object arg)
		{
		}

		// Token: 0x0600BBCB RID: 48075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BBCB")]
		[Address(RVA = "0x338D9D0", Offset = "0x338C5D0", VA = "0x18338D9D0")]
		private void _OnBpRoomSettleImmediateRequested(object arg)
		{
		}

		// Token: 0x0600BBCC RID: 48076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BBCC")]
		[Address(RVA = "0x338D620", Offset = "0x338C220", VA = "0x18338D620")]
		private void _OnBackBtnClicked()
		{
		}

		// Token: 0x0600BBCD RID: 48077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BBCD")]
		[Address(RVA = "0x338DE30", Offset = "0x338CA30", VA = "0x18338DE30")]
		private void _OnRequestCharCtrlMode(object arg)
		{
		}

		// Token: 0x0600BBCE RID: 48078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BBCE")]
		[Address(RVA = "0x338E1F0", Offset = "0x338CDF0", VA = "0x18338E1F0")]
		private void _OnStateUpdated(object arg)
		{
		}

		// Token: 0x0600BBCF RID: 48079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BBCF")]
		[Address(RVA = "0x338B430", Offset = "0x338A030", VA = "0x18338B430")]
		public void OnSwitchModeBtnClicked()
		{
		}

		// Token: 0x0600BBD0 RID: 48080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BBD0")]
		[Address(RVA = "0x338ADB0", Offset = "0x33899B0", VA = "0x18338ADB0")]
		public void OnOperationModeSwitchClicked()
		{
		}

		// Token: 0x0600BBD1 RID: 48081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BBD1")]
		[Address(RVA = "0x338B290", Offset = "0x3389E90", VA = "0x18338B290")]
		public void OnStationManageClicked()
		{
		}

		// Token: 0x0600BBD2 RID: 48082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BBD2")]
		[Address(RVA = "0x338B6E0", Offset = "0x338A2E0", VA = "0x18338B6E0")]
		public void PopupCleanDialog(UIArchitectureCleanView.Argument arg, Func<bool> onConfirm)
		{
		}

		// Token: 0x0600BBD3 RID: 48083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BBD3")]
		[Address(RVA = "0x338B4D0", Offset = "0x338A0D0", VA = "0x18338B4D0")]
		public void PopupBuildDialog(UIArchitectureBuildView.Argument arg, Func<bool> onConfirm)
		{
		}

		// Token: 0x0600BBD4 RID: 48084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BBD4")]
		[Address(RVA = "0x338B8F0", Offset = "0x338A4F0", VA = "0x18338B8F0")]
		public void PopupLevelupDialog(UIArchitectureLevelupView.Argument arg, Func<bool> onConfirm)
		{
		}

		// Token: 0x0600BBD5 RID: 48085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BBD5")]
		[Address(RVA = "0x338BB00", Offset = "0x338A700", VA = "0x18338BB00")]
		public void PopupTeardownDialog(UIArchitectureTeardownView.Argument arg, Func<bool> onConfirm)
		{
		}

		// Token: 0x0600BBD6 RID: 48086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BBD6")]
		[Address(RVA = "0x338C2F0", Offset = "0x338AEF0", VA = "0x18338C2F0")]
		public void ShowRoomDetailView(RoomSlotModel model, Action onTeardown, Action onLevelup)
		{
		}

		// Token: 0x0600BBD7 RID: 48087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BBD7")]
		[Address(RVA = "0x338C250", Offset = "0x338AE50", VA = "0x18338C250")]
		public void SetDIYShopPanel(DIYShopPanel shop)
		{
		}

		// Token: 0x0600BBD8 RID: 48088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BBD8")]
		[Address(RVA = "0x338E6B0", Offset = "0x338D2B0", VA = "0x18338E6B0")]
		private void _UpdateState()
		{
		}

		// Token: 0x0600BBD9 RID: 48089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BBD9")]
		[Address(RVA = "0x338E440", Offset = "0x338D040", VA = "0x18338E440")]
		private void _ShowBlurMask()
		{
		}

		// Token: 0x0600BBDA RID: 48090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BBDA")]
		[Address(RVA = "0x338CB70", Offset = "0x338B770", VA = "0x18338CB70")]
		private void _ClearBlurMask()
		{
		}

		// Token: 0x0600BBDB RID: 48091 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600BBDB")]
		[Address(RVA = "0x338D020", Offset = "0x338BC20", VA = "0x18338D020")]
		private Func<bool> _GetBuildingDialogConfirmCallback(Func<bool> callback)
		{
			return null;
		}

		// Token: 0x0600BBDC RID: 48092 RVA: 0x00046068 File Offset: 0x00044268
		[Token(Token = "0x600BBDC")]
		[Address(RVA = "0x338C830", Offset = "0x338B430", VA = "0x18338C830")]
		private FloatState _CalculateCurrentState()
		{
			return FloatState.NONE;
		}

		// Token: 0x0600BBDD RID: 48093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BBDD")]
		[Address(RVA = "0x338E5A0", Offset = "0x338D1A0", VA = "0x18338E5A0")]
		private void _SwitchFloatState(FloatState state)
		{
		}

		// Token: 0x0600BBDE RID: 48094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BBDE")]
		[Address(RVA = "0x338D140", Offset = "0x338BD40", VA = "0x18338D140")]
		private void _GoBackFromVisitMode()
		{
		}

		// Token: 0x0600BBDF RID: 48095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BBDF")]
		[Address(RVA = "0x338CEA0", Offset = "0x338BAA0", VA = "0x18338CEA0")]
		private void _ConfirmExit(string content, Action exitAction)
		{
		}

		// Token: 0x0600BBE0 RID: 48096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BBE0")]
		[Address(RVA = "0x338D4C0", Offset = "0x338C0C0", VA = "0x18338D4C0")]
		private void _InitBuildingMusic()
		{
		}

		// Token: 0x0600BBE1 RID: 48097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BBE1")]
		[Address(RVA = "0x338E940", Offset = "0x338D540", VA = "0x18338E940")]
		public BuildingFloatPage()
		{
		}

		// Token: 0x0600BBE6 RID: 48102 RVA: 0x00046080 File Offset: 0x00044280
		[Token(Token = "0x600BBE6")]
		[Address(RVA = "0x101CF00", Offset = "0x101BB00", VA = "0x18101CF00")]
		private AVGPageKey <>xLuaBaseProxy_get_avgPage()
		{
			return AVGPageKey.NONE;
		}

		// Token: 0x0600BBE7 RID: 48103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BBE7")]
		[Address(RVA = "0x327F490", Offset = "0x327E090", VA = "0x18327F490")]
		private void <>xLuaBaseProxy_OnCreate(DataBundle P0)
		{
		}

		// Token: 0x0600BBE8 RID: 48104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BBE8")]
		[Address(RVA = "0x1071290", Offset = "0x106FE90", VA = "0x181071290")]
		private void <>xLuaBaseProxy_OnStart()
		{
		}

		// Token: 0x0600BBE9 RID: 48105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BBE9")]
		[Address(RVA = "0x12C3F80", Offset = "0x12C2B80", VA = "0x1812C3F80")]
		private void <>xLuaBaseProxy_OnStop()
		{
		}

		// Token: 0x0600BBEA RID: 48106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BBEA")]
		[Address(RVA = "0x1232DA0", Offset = "0x12319A0", VA = "0x181232DA0")]
		private void <>xLuaBaseProxy_OnStateEngineReady(bool P0)
		{
		}

		// Token: 0x0600BBEB RID: 48107 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600BBEB")]
		[Address(RVA = "0x338C820", Offset = "0x338B420", VA = "0x18338C820")]
		private ListDict<BuildingEvent, EventPool.EventCallbackDelegate> <>xLuaBaseProxy_RegisterBuildingEvents()
		{
			return null;
		}

		// Token: 0x0600BBEC RID: 48108 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600BBEC")]
		[Address(RVA = "0x12172E0", Offset = "0x1215EE0", VA = "0x1812172E0")]
		private IEnumerator <>xLuaBaseProxy_EffectsOnHide(bool P0, bool P1)
		{
			return null;
		}

		// Token: 0x0400BB95 RID: 48021
		[Token(Token = "0x400BB95")]
		[FieldOffset(Offset = "0x0")]
		private static readonly ListSet<string> FADEOUT_TO_PAGES;

		// Token: 0x0400BB96 RID: 48022
		[Token(Token = "0x400BB96")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		private PrefabInstHolder _topMenuHolder;

		// Token: 0x0400BB97 RID: 48023
		[Token(Token = "0x400BB97")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		private DynamicBuildingFloatStateInstHolder[] _floatStateInstHolder;

		// Token: 0x0400BB98 RID: 48024
		[Token(Token = "0x400BB98")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		private UIArchitectureCleanView _cleanPopupDialog;

		// Token: 0x0400BB99 RID: 48025
		[Token(Token = "0x400BB99")]
		[FieldOffset(Offset = "0x130")]
		[SerializeField]
		private UIArchitectureBuildView _buildPopupDialog;

		// Token: 0x0400BB9A RID: 48026
		[Token(Token = "0x400BB9A")]
		[FieldOffset(Offset = "0x138")]
		[SerializeField]
		private UIArchitectureLevelupView _levelupPopupDialog;

		// Token: 0x0400BB9B RID: 48027
		[Token(Token = "0x400BB9B")]
		[FieldOffset(Offset = "0x140")]
		[SerializeField]
		private UIArchitectureTeardownView _teardownPopupDialog;

		// Token: 0x0400BB9C RID: 48028
		[Token(Token = "0x400BB9C")]
		[FieldOffset(Offset = "0x148")]
		[SerializeField]
		private UIArchitectureRoomDetailView _roomDetailView;

		// Token: 0x0400BB9D RID: 48029
		[Token(Token = "0x400BB9D")]
		[FieldOffset(Offset = "0x150")]
		[SerializeField]
		private Image _blurMask;

		// Token: 0x0400BB9E RID: 48030
		[Token(Token = "0x400BB9E")]
		[FieldOffset(Offset = "0x158")]
		[SerializeField]
		private Shader _blurShader;

		// Token: 0x0400BB9F RID: 48031
		[Token(Token = "0x400BB9F")]
		[FieldOffset(Offset = "0x160")]
		[SerializeField]
		private UIRoomTypeColorMap _roomTypeColorMap;

		// Token: 0x0400BBA0 RID: 48032
		[Token(Token = "0x400BBA0")]
		[FieldOffset(Offset = "0x168")]
		[SerializeField]
		private BuildingFloatArchSwitchView _switchView;

		// Token: 0x0400BBA1 RID: 48033
		[Token(Token = "0x400BBA1")]
		[FieldOffset(Offset = "0x170")]
		private List<IUIArchitectureBaseView> m_showingArchPopupViews;

		// Token: 0x0400BBA2 RID: 48034
		[Token(Token = "0x400BBA2")]
		[FieldOffset(Offset = "0x178")]
		private DIYShopPanel m_diyShop;

		// Token: 0x0400BBA3 RID: 48035
		[Token(Token = "0x400BBA3")]
		[FieldOffset(Offset = "0x180")]
		private List<BuildingFloatState> m_floatStateList;

		// Token: 0x0400BBA4 RID: 48036
		[Token(Token = "0x400BBA4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_avgPage;

		// Token: 0x0400BBA5 RID: 48037
		[Token(Token = "0x400BBA5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_switchView;

		// Token: 0x0400BBA6 RID: 48038
		[Token(Token = "0x400BBA6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_arcRoomDetailView;

		// Token: 0x0400BBA7 RID: 48039
		[Token(Token = "0x400BBA7")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x0400BBA8 RID: 48040
		[Token(Token = "0x400BBA8")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnStart;

		// Token: 0x0400BBA9 RID: 48041
		[Token(Token = "0x400BBA9")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnStop;

		// Token: 0x0400BBAA RID: 48042
		[Token(Token = "0x400BBAA")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnStateEngineReady;

		// Token: 0x0400BBAB RID: 48043
		[Token(Token = "0x400BBAB")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_RegisterBuildingEvents;

		// Token: 0x0400BBAC RID: 48044
		[Token(Token = "0x400BBAC")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_EffectsOnHide;

		// Token: 0x0400BBAD RID: 48045
		[Token(Token = "0x400BBAD")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_NotifyArchPopViewShow;

		// Token: 0x0400BBAE RID: 48046
		[Token(Token = "0x400BBAE")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_NotifyArchPopViewClose;

		// Token: 0x0400BBAF RID: 48047
		[Token(Token = "0x400BBAF")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_SendFloatStateSignal;

		// Token: 0x0400BBB0 RID: 48048
		[Token(Token = "0x400BBB0")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__ClosePopupViewAndInterruptBackEvent;

		// Token: 0x0400BBB1 RID: 48049
		[Token(Token = "0x400BBB1")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__OnSelectRoom;

		// Token: 0x0400BBB2 RID: 48050
		[Token(Token = "0x400BBB2")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__OnUnSelectRoom;

		// Token: 0x0400BBB3 RID: 48051
		[Token(Token = "0x400BBB3")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__OnRoomRouteFail;

		// Token: 0x0400BBB4 RID: 48052
		[Token(Token = "0x400BBB4")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__OnBuildingModeChanged;

		// Token: 0x0400BBB5 RID: 48053
		[Token(Token = "0x400BBB5")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__OnOperationModeChanged;

		// Token: 0x0400BBB6 RID: 48054
		[Token(Token = "0x400BBB6")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__OnToDoNotifyStateChanged;

		// Token: 0x0400BBB7 RID: 48055
		[Token(Token = "0x400BBB7")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__OnPlayerDataChanged;

		// Token: 0x0400BBB8 RID: 48056
		[Token(Token = "0x400BBB8")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__OnRequestDIY;

		// Token: 0x0400BBB9 RID: 48057
		[Token(Token = "0x400BBB9")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__OnBpRoomSettleRequested;

		// Token: 0x0400BBBA RID: 48058
		[Token(Token = "0x400BBBA")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__OnBpRoomSettleImmediateRequested;

		// Token: 0x0400BBBB RID: 48059
		[Token(Token = "0x400BBBB")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__OnBackBtnClicked;

		// Token: 0x0400BBBC RID: 48060
		[Token(Token = "0x400BBBC")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__OnRequestCharCtrlMode;

		// Token: 0x0400BBBD RID: 48061
		[Token(Token = "0x400BBBD")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__OnStateUpdated;

		// Token: 0x0400BBBE RID: 48062
		[Token(Token = "0x400BBBE")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_OnSwitchModeBtnClicked;

		// Token: 0x0400BBBF RID: 48063
		[Token(Token = "0x400BBBF")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_OnOperationModeSwitchClicked;

		// Token: 0x0400BBC0 RID: 48064
		[Token(Token = "0x400BBC0")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_OnStationManageClicked;

		// Token: 0x0400BBC1 RID: 48065
		[Token(Token = "0x400BBC1")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_PopupCleanDialog;

		// Token: 0x0400BBC2 RID: 48066
		[Token(Token = "0x400BBC2")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_PopupBuildDialog;

		// Token: 0x0400BBC3 RID: 48067
		[Token(Token = "0x400BBC3")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_PopupLevelupDialog;

		// Token: 0x0400BBC4 RID: 48068
		[Token(Token = "0x400BBC4")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_PopupTeardownDialog;

		// Token: 0x0400BBC5 RID: 48069
		[Token(Token = "0x400BBC5")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_ShowRoomDetailView;

		// Token: 0x0400BBC6 RID: 48070
		[Token(Token = "0x400BBC6")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_SetDIYShopPanel;

		// Token: 0x0400BBC7 RID: 48071
		[Token(Token = "0x400BBC7")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0__UpdateState;

		// Token: 0x0400BBC8 RID: 48072
		[Token(Token = "0x400BBC8")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0__ShowBlurMask;

		// Token: 0x0400BBC9 RID: 48073
		[Token(Token = "0x400BBC9")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0__ClearBlurMask;

		// Token: 0x0400BBCA RID: 48074
		[Token(Token = "0x400BBCA")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0__GetBuildingDialogConfirmCallback;

		// Token: 0x0400BBCB RID: 48075
		[Token(Token = "0x400BBCB")]
		[FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0__CalculateCurrentState;

		// Token: 0x0400BBCC RID: 48076
		[Token(Token = "0x400BBCC")]
		[FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0__SwitchFloatState;

		// Token: 0x0400BBCD RID: 48077
		[Token(Token = "0x400BBCD")]
		[FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0__GoBackFromVisitMode;

		// Token: 0x0400BBCE RID: 48078
		[Token(Token = "0x400BBCE")]
		[FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0__ConfirmExit;

		// Token: 0x0400BBCF RID: 48079
		[Token(Token = "0x400BBCF")]
		[FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix0__InitBuildingMusic;

		// Token: 0x0400BBD0 RID: 48080
		[Token(Token = "0x400BBD0")]
		[FieldOffset(Offset = "0x168")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
