using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.Squad;
using Torappu.UI.TemplateCharSelect;
using Torappu.UI.TemplateCharSelect.Common;
using UnityEngine;
using XLua;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006E7C RID: 28284
	[Token(Token = "0x2006E7C")]
	public class VecBreakSquadHomeState : State, IValueMsgReceiver
	{
		// Token: 0x06028400 RID: 164864 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028400")]
		[Address(RVA = "0x239CF70", Offset = "0x239BB70", VA = "0x18239CF70", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06028401 RID: 164865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028401")]
		[Address(RVA = "0x239CFF0", Offset = "0x239BBF0", VA = "0x18239CFF0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06028402 RID: 164866 RVA: 0x000D1070 File Offset: 0x000CF270
		[Token(Token = "0x6028402")]
		[Address(RVA = "0x239F210", Offset = "0x239DE10", VA = "0x18239F210")]
		private SquadHomePlugin.PluginInputParams _CreatePluginParam(string stageId)
		{
			return default(SquadHomePlugin.PluginInputParams);
		}

		// Token: 0x06028403 RID: 164867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028403")]
		[Address(RVA = "0x239D820", Offset = "0x239C420", VA = "0x18239D820", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x06028404 RID: 164868 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028404")]
		[Address(RVA = "0x239DC60", Offset = "0x239C860", VA = "0x18239DC60", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x06028405 RID: 164869 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028405")]
		[Address(RVA = "0x239DA70", Offset = "0x239C670", VA = "0x18239DA70", Slot = "11")]
		public override Dictionary<Type, Action<IStateBean>> RegisterFromDataListener()
		{
			return null;
		}

		// Token: 0x06028406 RID: 164870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028406")]
		[Address(RVA = "0x239D4C0", Offset = "0x239C0C0", VA = "0x18239D4C0", Slot = "23")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x06028407 RID: 164871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028407")]
		[Address(RVA = "0x23A07A0", Offset = "0x239F3A0", VA = "0x1823A07A0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06028408 RID: 164872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028408")]
		[Address(RVA = "0x23A1230", Offset = "0x239FE30", VA = "0x1823A1230")]
		private void _OnInitTopMenu(GameObject topMenuObj)
		{
		}

		// Token: 0x06028409 RID: 164873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028409")]
		[Address(RVA = "0x23A13F0", Offset = "0x239FFF0", VA = "0x1823A13F0")]
		private void _OnTopMenuRoutedToOtherPage(UIRouteTarget routeTarget, object param, Action<UIRouteTarget, object> baseHandler)
		{
		}

		// Token: 0x0602840A RID: 164874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602840A")]
		[Address(RVA = "0x23A0890", Offset = "0x239F490", VA = "0x1823A0890")]
		private void _InitSquadPlugin()
		{
		}

		// Token: 0x0602840B RID: 164875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602840B")]
		[Address(RVA = "0x23A2270", Offset = "0x23A0E70", VA = "0x1823A2270")]
		private void _TriggerSquadPluginResume()
		{
		}

		// Token: 0x0602840C RID: 164876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602840C")]
		[Address(RVA = "0x23A1D30", Offset = "0x23A0930", VA = "0x1823A1D30")]
		private void _PassDataToFriendAssist(IStateBean stateBean)
		{
		}

		// Token: 0x0602840D RID: 164877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602840D")]
		[Address(RVA = "0x23A0EE0", Offset = "0x239FAE0", VA = "0x1823A0EE0")]
		private void _OnAssistSelectFinished(IStateBean stateBean)
		{
		}

		// Token: 0x0602840E RID: 164878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602840E")]
		[Address(RVA = "0x23A0450", Offset = "0x239F050", VA = "0x1823A0450")]
		private void _GoToFriendAssist()
		{
		}

		// Token: 0x0602840F RID: 164879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602840F")]
		[Address(RVA = "0x239EC40", Offset = "0x239D840", VA = "0x18239EC40")]
		private void _ClearFiendAssist()
		{
		}

		// Token: 0x06028410 RID: 164880 RVA: 0x000D1088 File Offset: 0x000CF288
		[Token(Token = "0x6028410")]
		[Address(RVA = "0x23A01A0", Offset = "0x239EDA0", VA = "0x1823A01A0")]
		private static SquadFriendListItem.LockedStyle _GenLockedStyle4CharRuneInvalid()
		{
			return default(SquadFriendListItem.LockedStyle);
		}

		// Token: 0x06028411 RID: 164881 RVA: 0x000D10A0 File Offset: 0x000CF2A0
		[Token(Token = "0x6028411")]
		[Address(RVA = "0x23A0030", Offset = "0x239EC30", VA = "0x1823A0030")]
		private static SquadFriendListItem.LockedStyle _GenLockedStyle4CharInDefense()
		{
			return default(SquadFriendListItem.LockedStyle);
		}

		// Token: 0x06028412 RID: 164882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028412")]
		[Address(RVA = "0x239F3D0", Offset = "0x239DFD0", VA = "0x18239F3D0")]
		private void _DoStartBattle()
		{
		}

		// Token: 0x06028413 RID: 164883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028413")]
		[Address(RVA = "0x23A0C50", Offset = "0x239F850", VA = "0x1823A0C50")]
		private void _InvokedStartBattle()
		{
		}

		// Token: 0x06028414 RID: 164884 RVA: 0x000D10B8 File Offset: 0x000CF2B8
		[Token(Token = "0x6028414")]
		[Address(RVA = "0x239E850", Offset = "0x239D450", VA = "0x18239E850")]
		private bool _CheckIfStartBattleValid()
		{
			return default(bool);
		}

		// Token: 0x06028415 RID: 164885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028415")]
		[Address(RVA = "0x23A1BD0", Offset = "0x23A07D0", VA = "0x1823A1BD0")]
		private void _PassDataToCharSelect(IStateBean stateBean)
		{
		}

		// Token: 0x06028416 RID: 164886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028416")]
		[Address(RVA = "0x23A1140", Offset = "0x239FD40", VA = "0x1823A1140")]
		private void _OnCharSelectFinished(IStateBean stateBean)
		{
		}

		// Token: 0x06028417 RID: 164887 RVA: 0x000D10D0 File Offset: 0x000CF2D0
		[Token(Token = "0x6028417")]
		[Address(RVA = "0x239F950", Offset = "0x239E550", VA = "0x18239F950")]
		private CommonCharSelectCustomization _GenCharSelectCustomization()
		{
			return default(CommonCharSelectCustomization);
		}

		// Token: 0x06028418 RID: 164888 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028418")]
		[Address(RVA = "0x239EDC0", Offset = "0x239D9C0", VA = "0x18239EDC0")]
		private TemplateCharSelectCardViewModel _CreateCharSelectCardViewModel(int instId, TemplateCharSelectCharInputData inputNullable, [Optional] PlayerCharacter playerData)
		{
			return null;
		}

		// Token: 0x06028419 RID: 164889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028419")]
		[Address(RVA = "0x23A2450", Offset = "0x23A1050", VA = "0x1823A2450")]
		private void _TryRefreshSquadsBackFromCharSelect_Common(CommonCharSelectStateBean selectStateBean)
		{
		}

		// Token: 0x0602841A RID: 164890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602841A")]
		[Address(RVA = "0x239E2E0", Offset = "0x239CEE0", VA = "0x18239E2E0")]
		private void _ApplySquadFromCharSelectSingleMode(TemplateCharSelectCardViewModel target, int singleTargetInstId, SquadViewModel squad)
		{
		}

		// Token: 0x0602841B RID: 164891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602841B")]
		[Address(RVA = "0x239DED0", Offset = "0x239CAD0", VA = "0x18239DED0")]
		private void _ApplySquadFromCharSelectMultiMode(List<VecBreakSquadCharSelectCardViewModel> selectCardViewModels, SquadViewModel squad)
		{
		}

		// Token: 0x0602841C RID: 164892 RVA: 0x000D10E8 File Offset: 0x000CF2E8
		[Token(Token = "0x602841C")]
		[Address(RVA = "0x239F600", Offset = "0x239E200", VA = "0x18239F600")]
		private SquadItemStruct _FindInstInSquad(int instId, IList<SquadItemStruct> squad)
		{
			return default(SquadItemStruct);
		}

		// Token: 0x0602841D RID: 164893 RVA: 0x000D1100 File Offset: 0x000CF300
		[Token(Token = "0x602841D")]
		[Address(RVA = "0x239F7D0", Offset = "0x239E3D0", VA = "0x18239F7D0")]
		private int _FindInstIndexInSquad(int instId, IList<SquadItemStruct> squad)
		{
			return 0;
		}

		// Token: 0x0602841E RID: 164894 RVA: 0x000D1118 File Offset: 0x000CF318
		[Token(Token = "0x602841E")]
		[Address(RVA = "0x239F4B0", Offset = "0x239E0B0", VA = "0x18239F4B0")]
		private int _FindFirstEmptyMemberIndexInSquad(IList<SquadItemStruct> squad)
		{
			return 0;
		}

		// Token: 0x0602841F RID: 164895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602841F")]
		[Address(RVA = "0x23A1F70", Offset = "0x23A0B70", VA = "0x1823A1F70")]
		private void _PlaySquadVoiceFromSelectCardList(List<VecBreakSquadCharSelectCardViewModel> selectCardViewModels)
		{
		}

		// Token: 0x06028420 RID: 164896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028420")]
		[Address(RVA = "0x23A2100", Offset = "0x23A0D00", VA = "0x1823A2100")]
		private void _SaveSquadFormationIfNeeded(Action nextStep)
		{
		}

		// Token: 0x06028421 RID: 164897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028421")]
		[Address(RVA = "0x23A0310", Offset = "0x239EF10", VA = "0x1823A0310")]
		private void _GoToCharSelect(VecBreakSquadHomeState.SelectSquadParam selectSquadParam)
		{
		}

		// Token: 0x06028422 RID: 164898 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028422")]
		[Address(RVA = "0x23A1550", Offset = "0x23A0150", VA = "0x1823A1550")]
		private TemplateCharSelectController.InputParam _ParseTemplateCharSelectInputParam(VecBreakSquadHomeState.SelectSquadParam selectSquadParam)
		{
			return null;
		}

		// Token: 0x06028423 RID: 164899 RVA: 0x000D1130 File Offset: 0x000CF330
		[Token(Token = "0x6028423")]
		[Address(RVA = "0x23A2300", Offset = "0x23A0F00", VA = "0x1823A2300")]
		private int _TryFetchCharSelectFocusInstId(VecBreakSquadHomeState.SelectSquadParam selectSquadParam)
		{
			return 0;
		}

		// Token: 0x06028424 RID: 164900 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028424")]
		[Address(RVA = "0x239FD20", Offset = "0x239E920", VA = "0x18239FD20")]
		private List<TemplateCharSelectCharInputData> _GenCharSelectInputDataList()
		{
			return null;
		}

		// Token: 0x06028425 RID: 164901 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028425")]
		[Address(RVA = "0x239FF20", Offset = "0x239EB20", VA = "0x18239FF20")]
		private CommonSquadToCharSelectInputData _GenCharSelectInputData(CharacterCardViewModel cardViewModel)
		{
			return null;
		}

		// Token: 0x06028426 RID: 164902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028426")]
		[Address(RVA = "0x23A2F00", Offset = "0x23A1B00", VA = "0x1823A2F00")]
		public VecBreakSquadHomeState()
		{
		}

		// Token: 0x0602842B RID: 164907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602842B")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0602842C RID: 164908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602842C")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0602842D RID: 164909 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602842D")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0602842E RID: 164910 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602842E")]
		[Address(RVA = "0xE63470", Offset = "0xE62070", VA = "0x180E63470")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterFromDataListener()
		{
			return null;
		}

		// Token: 0x04039358 RID: 234328
		[Token(Token = "0x4039358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly List<CharacterSortTypePair> CUSTOM_CHAR_SORT_TYPE_LIST;

		// Token: 0x04039359 RID: 234329
		[Token(Token = "0x4039359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private TopMenuDynamicPrefabInstHolder _topMenuHolder;

		// Token: 0x0403935A RID: 234330
		[Token(Token = "0x403935A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private VecBreakSquadGroupController _squadGroupController;

		// Token: 0x0403935B RID: 234331
		[Token(Token = "0x403935B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private SquadAssistCardView _assistCard;

		// Token: 0x0403935C RID: 234332
		[Token(Token = "0x403935C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private SquadHomePluginLoader _homePluginLoader;

		// Token: 0x0403935D RID: 234333
		[Token(Token = "0x403935D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool m_isInited;

		// Token: 0x0403935E RID: 234334
		[Token(Token = "0x403935E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0403935F RID: 234335
		[Token(Token = "0x403935F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private VecBreakSquadStateBean m_stateBean;

		// Token: 0x04039360 RID: 234336
		[Token(Token = "0x4039360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private TemplateCharSelectController.InputParam m_paramToSelectState;

		// Token: 0x04039361 RID: 234337
		[Token(Token = "0x4039361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private SquadHomePlugin m_squadHomePlugin;

		// Token: 0x04039362 RID: 234338
		[Token(Token = "0x4039362")]
		[NonSerialized]
		public const int MSG_CHAR_SINGLE_FORMATION_CLICK = 0;

		// Token: 0x04039363 RID: 234339
		[Token(Token = "0x4039363")]
		[NonSerialized]
		public const int MSG_CHAR_MULTI_FORMATION_CLICK = 1;

		// Token: 0x04039364 RID: 234340
		[Token(Token = "0x4039364")]
		[NonSerialized]
		public const int MSG_ASSIST_BTN_CLICK = 2;

		// Token: 0x04039365 RID: 234341
		[Token(Token = "0x4039365")]
		[NonSerialized]
		public const int MSG_ASSIST_CLEAR_CLICK = 3;

		// Token: 0x04039366 RID: 234342
		[Token(Token = "0x4039366")]
		[NonSerialized]
		public const int MSG_START_BTN_CLICK = 4;

		// Token: 0x04039367 RID: 234343
		[Token(Token = "0x4039367")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04039368 RID: 234344
		[Token(Token = "0x4039368")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04039369 RID: 234345
		[Token(Token = "0x4039369")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__CreatePluginParam;

		// Token: 0x0403936A RID: 234346
		[Token(Token = "0x403936A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0403936B RID: 234347
		[Token(Token = "0x403936B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x0403936C RID: 234348
		[Token(Token = "0x403936C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_RegisterFromDataListener;

		// Token: 0x0403936D RID: 234349
		[Token(Token = "0x403936D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x0403936E RID: 234350
		[Token(Token = "0x403936E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403936F RID: 234351
		[Token(Token = "0x403936F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OnInitTopMenu;

		// Token: 0x04039370 RID: 234352
		[Token(Token = "0x4039370")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnTopMenuRoutedToOtherPage;

		// Token: 0x04039371 RID: 234353
		[Token(Token = "0x4039371")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__InitSquadPlugin;

		// Token: 0x04039372 RID: 234354
		[Token(Token = "0x4039372")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__TriggerSquadPluginResume;

		// Token: 0x04039373 RID: 234355
		[Token(Token = "0x4039373")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__PassDataToFriendAssist;

		// Token: 0x04039374 RID: 234356
		[Token(Token = "0x4039374")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__OnAssistSelectFinished;

		// Token: 0x04039375 RID: 234357
		[Token(Token = "0x4039375")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__GoToFriendAssist;

		// Token: 0x04039376 RID: 234358
		[Token(Token = "0x4039376")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__ClearFiendAssist;

		// Token: 0x04039377 RID: 234359
		[Token(Token = "0x4039377")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__GenLockedStyle4CharRuneInvalid;

		// Token: 0x04039378 RID: 234360
		[Token(Token = "0x4039378")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__GenLockedStyle4CharInDefense;

		// Token: 0x04039379 RID: 234361
		[Token(Token = "0x4039379")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__DoStartBattle;

		// Token: 0x0403937A RID: 234362
		[Token(Token = "0x403937A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__InvokedStartBattle;

		// Token: 0x0403937B RID: 234363
		[Token(Token = "0x403937B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__CheckIfStartBattleValid;

		// Token: 0x0403937C RID: 234364
		[Token(Token = "0x403937C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__PassDataToCharSelect;

		// Token: 0x0403937D RID: 234365
		[Token(Token = "0x403937D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__OnCharSelectFinished;

		// Token: 0x0403937E RID: 234366
		[Token(Token = "0x403937E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__GenCharSelectCustomization;

		// Token: 0x0403937F RID: 234367
		[Token(Token = "0x403937F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__CreateCharSelectCardViewModel;

		// Token: 0x04039380 RID: 234368
		[Token(Token = "0x4039380")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__TryRefreshSquadsBackFromCharSelect_Common;

		// Token: 0x04039381 RID: 234369
		[Token(Token = "0x4039381")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__ApplySquadFromCharSelectSingleMode;

		// Token: 0x04039382 RID: 234370
		[Token(Token = "0x4039382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__ApplySquadFromCharSelectMultiMode;

		// Token: 0x04039383 RID: 234371
		[Token(Token = "0x4039383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0__FindInstInSquad;

		// Token: 0x04039384 RID: 234372
		[Token(Token = "0x4039384")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0__FindInstIndexInSquad;

		// Token: 0x04039385 RID: 234373
		[Token(Token = "0x4039385")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0__FindFirstEmptyMemberIndexInSquad;

		// Token: 0x04039386 RID: 234374
		[Token(Token = "0x4039386")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0__PlaySquadVoiceFromSelectCardList;

		// Token: 0x04039387 RID: 234375
		[Token(Token = "0x4039387")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0__SaveSquadFormationIfNeeded;

		// Token: 0x04039388 RID: 234376
		[Token(Token = "0x4039388")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0__GoToCharSelect;

		// Token: 0x04039389 RID: 234377
		[Token(Token = "0x4039389")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0__ParseTemplateCharSelectInputParam;

		// Token: 0x0403938A RID: 234378
		[Token(Token = "0x403938A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0__TryFetchCharSelectFocusInstId;

		// Token: 0x0403938B RID: 234379
		[Token(Token = "0x403938B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0__GenCharSelectInputDataList;

		// Token: 0x0403938C RID: 234380
		[Token(Token = "0x403938C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0__GenCharSelectInputData;

		// Token: 0x0403938D RID: 234381
		[Token(Token = "0x403938D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006E7D RID: 28285
		[Token(Token = "0x2006E7D")]
		private class SquadAssistPlugin : SquadFriendAssistState.Plugin<VecBreakSquadHomeState>
		{
			// Token: 0x0602842F RID: 164911 RVA: 0x000D1148 File Offset: 0x000CF348
			[Token(Token = "0x602842F")]
			[Address(RVA = "0x23969D0", Offset = "0x23955D0", VA = "0x1823969D0", Slot = "9")]
			public override bool CheckIfCharValid(CharQuery charQuery, ref SquadFriendListItem.LockedStyle lockStyleConfig)
			{
				return default(bool);
			}

			// Token: 0x06028430 RID: 164912 RVA: 0x000D1160 File Offset: 0x000CF360
			[Token(Token = "0x6028430")]
			[Address(RVA = "0x2396FA0", Offset = "0x2395BA0", VA = "0x182396FA0")]
			private bool _CheckIfCharDefend(string charId)
			{
				return default(bool);
			}

			// Token: 0x06028431 RID: 164913 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6028431")]
			[Address(RVA = "0x2397120", Offset = "0x2395D20", VA = "0x182397120")]
			public SquadAssistPlugin()
			{
			}
		}

		// Token: 0x02006E7E RID: 28286
		[Token(Token = "0x2006E7E")]
		public class SelectSquadParam : IHotfixable
		{
			// Token: 0x06028432 RID: 164914 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6028432")]
			[Address(RVA = "0x2396560", Offset = "0x2395160", VA = "0x182396560")]
			public SelectSquadParam()
			{
			}

			// Token: 0x0403938E RID: 234382
			[Token(Token = "0x403938E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool isSingleMode;

			// Token: 0x0403938F RID: 234383
			[Token(Token = "0x403938F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public int memberIndex;

			// Token: 0x04039390 RID: 234384
			[Token(Token = "0x4039390")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
