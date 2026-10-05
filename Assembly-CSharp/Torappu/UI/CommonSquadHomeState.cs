using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI.Squad;
using Torappu.UI.TemplateCharSelect;
using Torappu.UI.TemplateCharSelect.Common;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020035BC RID: 13756
	[Token(Token = "0x20035BC")]
	public class CommonSquadHomeState : PopupFadeState, ICommonSquadMsgReceiver, IHotfixable, IValueMsgReceiver, ICompDialogCallBack
	{
		// Token: 0x17003487 RID: 13447
		// (get) Token: 0x06015E28 RID: 89640 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003487")]
		private CommonSquadGroupViewProperty squadGroupProp
		{
			[Token(Token = "0x6015E28")]
			[Address(RVA = "0xE65EB0", Offset = "0xE64AB0", VA = "0x180E65EB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003488 RID: 13448
		// (get) Token: 0x06015E29 RID: 89641 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003488")]
		public CommonSquadGroupViewModel commonSquadGroupViewModel
		{
			[Token(Token = "0x6015E29")]
			[Address(RVA = "0xE65DD0", Offset = "0xE649D0", VA = "0x180E65DD0", Slot = "32")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003489 RID: 13449
		// (get) Token: 0x06015E2A RID: 89642 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003489")]
		public TemplateCharSelectController.InputParam paramToSelectState
		{
			[Token(Token = "0x6015E2A")]
			[Address(RVA = "0xE65E50", Offset = "0xE64A50", VA = "0x180E65E50", Slot = "33")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700348A RID: 13450
		// (get) Token: 0x06015E2B RID: 89643 RVA: 0x0008E920 File Offset: 0x0008CB20
		[Token(Token = "0x1700348A")]
		public CommonCharSelectCustomization charSelectCustomization
		{
			[Token(Token = "0x6015E2B")]
			[Address(RVA = "0xE65D20", Offset = "0xE64920", VA = "0x180E65D20", Slot = "34")]
			get
			{
				return default(CommonCharSelectCustomization);
			}
		}

		// Token: 0x1700348B RID: 13451
		// (get) Token: 0x06015E2C RID: 89644 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700348B")]
		public ICommonSquadPlugin squadPlugin
		{
			[Token(Token = "0x6015E2C")]
			[Address(RVA = "0xE65F20", Offset = "0xE64B20", VA = "0x180E65F20")]
			get
			{
				return null;
			}
		}

		// Token: 0x06015E2D RID: 89645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015E2D")]
		[Address(RVA = "0xE64930", Offset = "0xE63530", VA = "0x180E64930")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06015E2E RID: 89646 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015E2E")]
		[Address(RVA = "0xE62420", Offset = "0xE61020", VA = "0x180E62420", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06015E2F RID: 89647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015E2F")]
		[Address(RVA = "0xE62760", Offset = "0xE61360", VA = "0x180E62760", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06015E30 RID: 89648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015E30")]
		[Address(RVA = "0xE631E0", Offset = "0xE61DE0", VA = "0x180E631E0", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x06015E31 RID: 89649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015E31")]
		[Address(RVA = "0xE62B20", Offset = "0xE61720", VA = "0x180E62B20", Slot = "18")]
		protected override void OnExit()
		{
		}

		// Token: 0x06015E32 RID: 89650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015E32")]
		[Address(RVA = "0xE62700", Offset = "0xE61300", VA = "0x180E62700")]
		private void OnDestroy()
		{
		}

		// Token: 0x06015E33 RID: 89651 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015E33")]
		[Address(RVA = "0xE63310", Offset = "0xE61F10", VA = "0x180E63310", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x06015E34 RID: 89652 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015E34")]
		[Address(RVA = "0xE63280", Offset = "0xE61E80", VA = "0x180E63280", Slot = "11")]
		public override Dictionary<Type, Action<IStateBean>> RegisterFromDataListener()
		{
			return null;
		}

		// Token: 0x06015E35 RID: 89653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015E35")]
		[Address(RVA = "0xE63910", Offset = "0xE62510", VA = "0x180E63910")]
		private void _CreateAndBindView(ICommonSquadPage.ISquadInputs pageParam)
		{
		}

		// Token: 0x06015E36 RID: 89654 RVA: 0x0008E938 File Offset: 0x0008CB38
		[Token(Token = "0x6015E36")]
		[Address(RVA = "0xE63D30", Offset = "0xE62930", VA = "0x180E63D30")]
		private CommonCharSelectCustomization _GenCharSelectCustomization(ICommonSquadPage.ISquadInputs pageParam)
		{
			return default(CommonCharSelectCustomization);
		}

		// Token: 0x06015E37 RID: 89655 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015E37")]
		[Address(RVA = "0xE640C0", Offset = "0xE62CC0", VA = "0x180E640C0")]
		private CommonCharSelectResHolder _GetAvailCharSelectResHolder(ICommonSquadPage.ISquadInputs pageParam)
		{
			return null;
		}

		// Token: 0x06015E38 RID: 89656 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015E38")]
		private T _TryCreateAndBindSingleView<T>(T binderAsset, RectTransform root) where T : DataBinder<CommonSquadGroupViewProperty>
		{
			return null;
		}

		// Token: 0x06015E39 RID: 89657 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015E39")]
		[Address(RVA = "0xE642E0", Offset = "0xE62EE0", VA = "0x180E642E0")]
		private CommonSquadResHolder _GetAvailCommonSquadResHolder(ICommonSquadPage.ISquadInputs pageParam)
		{
			return null;
		}

		// Token: 0x06015E3A RID: 89658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015E3A")]
		[Address(RVA = "0xE633A0", Offset = "0xE61FA0", VA = "0x180E633A0", Slot = "31")]
		public void SendMsg(int key, ValueBundle msg)
		{
		}

		// Token: 0x06015E3B RID: 89659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015E3B")]
		[Address(RVA = "0xE62B90", Offset = "0xE61790", VA = "0x180E62B90", Slot = "37")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x06015E3C RID: 89660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015E3C")]
		[Address(RVA = "0xE64450", Offset = "0xE63050", VA = "0x180E64450")]
		private void _GoToCharSelect(CommonSquadHomeState.SelectCharParam selectCharParam)
		{
		}

		// Token: 0x06015E3D RID: 89661 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015E3D")]
		[Address(RVA = "0xE650E0", Offset = "0xE63CE0", VA = "0x180E650E0")]
		private TemplateCharSelectController.InputParam _ParseTemplateCharSelectInputParam(CommonSquadHomeState.SelectCharParam selectCharParam)
		{
			return null;
		}

		// Token: 0x06015E3E RID: 89662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015E3E")]
		[Address(RVA = "0xE645D0", Offset = "0xE631D0", VA = "0x180E645D0")]
		private void _GoToFriendAssist()
		{
		}

		// Token: 0x06015E3F RID: 89663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015E3F")]
		[Address(RVA = "0xE63850", Offset = "0xE62450", VA = "0x180E63850")]
		private void _ClearFiendAssist()
		{
		}

		// Token: 0x06015E40 RID: 89664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015E40")]
		[Address(RVA = "0xE63C60", Offset = "0xE62860", VA = "0x180E63C60")]
		private void _DoStartBattle()
		{
		}

		// Token: 0x06015E41 RID: 89665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015E41")]
		[Address(RVA = "0xE64B30", Offset = "0xE63730", VA = "0x180E64B30")]
		private void _InvokedStartBattle()
		{
		}

		// Token: 0x06015E42 RID: 89666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015E42")]
		[Address(RVA = "0xE64DB0", Offset = "0xE639B0", VA = "0x180E64DB0")]
		private void _OnStartBattleSuccess()
		{
		}

		// Token: 0x06015E43 RID: 89667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015E43")]
		[Address(RVA = "0xE656A0", Offset = "0xE642A0", VA = "0x180E656A0")]
		private void _SaveCacheStageConfig()
		{
		}

		// Token: 0x06015E44 RID: 89668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015E44")]
		[Address(RVA = "0xE657B0", Offset = "0xE643B0", VA = "0x180E657B0")]
		private void _SaveSquadFormationIfNeeded([Optional] Action nextStep)
		{
		}

		// Token: 0x06015E45 RID: 89669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015E45")]
		[Address(RVA = "0xE64F00", Offset = "0xE63B00", VA = "0x180E64F00")]
		private void _OnTopMenuBackButtonClicked()
		{
		}

		// Token: 0x06015E46 RID: 89670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015E46")]
		[Address(RVA = "0xE64FC0", Offset = "0xE63BC0", VA = "0x180E64FC0")]
		private void _OnTopMenuRouteToOtherPage(CommonSquadTopMenuViewBase.CommonSquadTopMenuRouteToOtherOutput output)
		{
		}

		// Token: 0x06015E47 RID: 89671 RVA: 0x0008E950 File Offset: 0x0008CB50
		[Token(Token = "0x6015E47")]
		[Address(RVA = "0xE63530", Offset = "0xE62130", VA = "0x180E63530")]
		private bool _CheckIfStartBattleValid()
		{
			return default(bool);
		}

		// Token: 0x06015E48 RID: 89672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015E48")]
		[Address(RVA = "0xE62480", Offset = "0xE61080", VA = "0x180E62480", Slot = "38")]
		public void HandleCallBack(int instId, ValueBundle output)
		{
		}

		// Token: 0x06015E49 RID: 89673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015E49")]
		[Address(RVA = "0xE62670", Offset = "0xE61270", VA = "0x180E62670", Slot = "36")]
		public void NotifyUpdate()
		{
		}

		// Token: 0x06015E4A RID: 89674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015E4A")]
		[Address(RVA = "0xE65A20", Offset = "0xE64620", VA = "0x180E65A20")]
		private void _TryRaiseAVGSignal()
		{
		}

		// Token: 0x06015E4B RID: 89675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015E4B")]
		[Address(RVA = "0xE65940", Offset = "0xE64540", VA = "0x180E65940")]
		private void _StopTutorialCoroutine()
		{
		}

		// Token: 0x06015E4C RID: 89676 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015E4C")]
		[Address(RVA = "0xE65BC0", Offset = "0xE647C0", VA = "0x180E65BC0")]
		private IEnumerator _WaitAndRaiseSignal()
		{
			return null;
		}

		// Token: 0x06015E4D RID: 89677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015E4D")]
		[Address(RVA = "0xE65C70", Offset = "0xE64870", VA = "0x180E65C70")]
		public CommonSquadHomeState()
		{
		}

		// Token: 0x06015E50 RID: 89680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015E50")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x06015E51 RID: 89681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015E51")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x06015E52 RID: 89682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015E52")]
		[Address(RVA = "0xE63460", Offset = "0xE62060", VA = "0x180E63460")]
		private void <>xLuaBaseProxy_OnExit()
		{
		}

		// Token: 0x06015E53 RID: 89683 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015E53")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x06015E54 RID: 89684 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015E54")]
		[Address(RVA = "0xE63470", Offset = "0xE62070", VA = "0x180E63470")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterFromDataListener()
		{
			return null;
		}

		// Token: 0x0401A519 RID: 107801
		[Token(Token = "0x401A519")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RectTransform _layoutViewHolder;

		// Token: 0x0401A51A RID: 107802
		[Token(Token = "0x401A51A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform _floatViewHolder;

		// Token: 0x0401A51B RID: 107803
		[Token(Token = "0x401A51B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private RectTransform _topMenuViewHolder;

		// Token: 0x0401A51C RID: 107804
		[Token(Token = "0x401A51C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private CommonSquadLayoutViewBase m_layoutView;

		// Token: 0x0401A51D RID: 107805
		[Token(Token = "0x401A51D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private CommonSquadFloatViewBase m_floatView;

		// Token: 0x0401A51E RID: 107806
		[Token(Token = "0x401A51E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private CommonSquadTopMenuViewBase m_topMenuView;

		// Token: 0x0401A51F RID: 107807
		[Token(Token = "0x401A51F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private CommonSquadStateBean m_stateBean;

		// Token: 0x0401A520 RID: 107808
		[Token(Token = "0x401A520")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private ICommonSquadPage.ISquadInputs m_cacheInput;

		// Token: 0x0401A521 RID: 107809
		[Token(Token = "0x401A521")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private TemplateCharSelectController.InputParam m_paramToSelectState;

		// Token: 0x0401A522 RID: 107810
		[Token(Token = "0x401A522")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private UICompDialogMgr m_dlgMgr;

		// Token: 0x0401A523 RID: 107811
		[Token(Token = "0x401A523")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private CommonCharSelectCustomization m_charSelectCustomization;

		// Token: 0x0401A524 RID: 107812
		[Token(Token = "0x401A524")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private bool m_isInited;

		// Token: 0x0401A525 RID: 107813
		[Token(Token = "0x401A525")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private Coroutine m_tutorialCoroutine;

		// Token: 0x0401A526 RID: 107814
		[Token(Token = "0x401A526")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_squadGroupProp;

		// Token: 0x0401A527 RID: 107815
		[Token(Token = "0x401A527")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_commonSquadGroupViewModel;

		// Token: 0x0401A528 RID: 107816
		[Token(Token = "0x401A528")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_paramToSelectState;

		// Token: 0x0401A529 RID: 107817
		[Token(Token = "0x401A529")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_charSelectCustomization;

		// Token: 0x0401A52A RID: 107818
		[Token(Token = "0x401A52A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_squadPlugin;

		// Token: 0x0401A52B RID: 107819
		[Token(Token = "0x401A52B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401A52C RID: 107820
		[Token(Token = "0x401A52C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0401A52D RID: 107821
		[Token(Token = "0x401A52D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0401A52E RID: 107822
		[Token(Token = "0x401A52E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0401A52F RID: 107823
		[Token(Token = "0x401A52F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x0401A530 RID: 107824
		[Token(Token = "0x401A530")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0401A531 RID: 107825
		[Token(Token = "0x401A531")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x0401A532 RID: 107826
		[Token(Token = "0x401A532")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_RegisterFromDataListener;

		// Token: 0x0401A533 RID: 107827
		[Token(Token = "0x401A533")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__CreateAndBindView;

		// Token: 0x0401A534 RID: 107828
		[Token(Token = "0x401A534")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__GenCharSelectCustomization;

		// Token: 0x0401A535 RID: 107829
		[Token(Token = "0x401A535")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__GetAvailCharSelectResHolder;

		// Token: 0x0401A536 RID: 107830
		[Token(Token = "0x401A536")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__TryCreateAndBindSingleView;

		// Token: 0x0401A537 RID: 107831
		[Token(Token = "0x401A537")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__GetAvailCommonSquadResHolder;

		// Token: 0x0401A538 RID: 107832
		[Token(Token = "0x401A538")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_SendMsg;

		// Token: 0x0401A539 RID: 107833
		[Token(Token = "0x401A539")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x0401A53A RID: 107834
		[Token(Token = "0x401A53A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__GoToCharSelect;

		// Token: 0x0401A53B RID: 107835
		[Token(Token = "0x401A53B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__ParseTemplateCharSelectInputParam;

		// Token: 0x0401A53C RID: 107836
		[Token(Token = "0x401A53C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__GoToFriendAssist;

		// Token: 0x0401A53D RID: 107837
		[Token(Token = "0x401A53D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__ClearFiendAssist;

		// Token: 0x0401A53E RID: 107838
		[Token(Token = "0x401A53E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__DoStartBattle;

		// Token: 0x0401A53F RID: 107839
		[Token(Token = "0x401A53F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__InvokedStartBattle;

		// Token: 0x0401A540 RID: 107840
		[Token(Token = "0x401A540")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__OnStartBattleSuccess;

		// Token: 0x0401A541 RID: 107841
		[Token(Token = "0x401A541")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__SaveCacheStageConfig;

		// Token: 0x0401A542 RID: 107842
		[Token(Token = "0x401A542")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__SaveSquadFormationIfNeeded;

		// Token: 0x0401A543 RID: 107843
		[Token(Token = "0x401A543")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0__OnTopMenuBackButtonClicked;

		// Token: 0x0401A544 RID: 107844
		[Token(Token = "0x401A544")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0__OnTopMenuRouteToOtherPage;

		// Token: 0x0401A545 RID: 107845
		[Token(Token = "0x401A545")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0__CheckIfStartBattleValid;

		// Token: 0x0401A546 RID: 107846
		[Token(Token = "0x401A546")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_HandleCallBack;

		// Token: 0x0401A547 RID: 107847
		[Token(Token = "0x401A547")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_NotifyUpdate;

		// Token: 0x0401A548 RID: 107848
		[Token(Token = "0x401A548")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0__TryRaiseAVGSignal;

		// Token: 0x0401A549 RID: 107849
		[Token(Token = "0x401A549")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0__StopTutorialCoroutine;

		// Token: 0x0401A54A RID: 107850
		[Token(Token = "0x401A54A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0__WaitAndRaiseSignal;

		// Token: 0x0401A54B RID: 107851
		[Token(Token = "0x401A54B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020035BD RID: 13757
		[Token(Token = "0x20035BD")]
		public class SelectCharParam : IHotfixable
		{
			// Token: 0x06015E55 RID: 89685 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015E55")]
			[Address(RVA = "0xE73740", Offset = "0xE72340", VA = "0x180E73740")]
			public SelectCharParam()
			{
			}

			// Token: 0x0401A54C RID: 107852
			[Token(Token = "0x401A54C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool isSingleMode;

			// Token: 0x0401A54D RID: 107853
			[Token(Token = "0x401A54D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public int memberIndex;

			// Token: 0x0401A54E RID: 107854
			[Token(Token = "0x401A54E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x020035BE RID: 13758
		[Token(Token = "0x20035BE")]
		public class CommonSquadAssistPlugin : SquadFriendAssistState.Plugin<CommonSquadHomeState>
		{
			// Token: 0x06015E56 RID: 89686 RVA: 0x0008E968 File Offset: 0x0008CB68
			[Token(Token = "0x6015E56")]
			[Address(RVA = "0xE61500", Offset = "0xE60100", VA = "0x180E61500", Slot = "9")]
			public override bool CheckIfCharValid(CharQuery charQuery, ref SquadFriendListItem.LockedStyle lockStyleConfig)
			{
				return default(bool);
			}

			// Token: 0x06015E57 RID: 89687 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015E57")]
			[Address(RVA = "0xE61910", Offset = "0xE60510", VA = "0x180E61910")]
			public CommonSquadAssistPlugin()
			{
			}
		}
	}
}
