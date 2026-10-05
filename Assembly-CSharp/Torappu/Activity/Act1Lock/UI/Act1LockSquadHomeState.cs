using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.BattleFinish;
using Torappu.UI.CharSelect;
using Torappu.UI.Squad;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1Lock.UI
{
	// Token: 0x0200788F RID: 30863
	[Token(Token = "0x200788F")]
	public class Act1LockSquadHomeState : State, IRuneSquadController, ISquadCharSelectContext
	{
		// Token: 0x0602B43B RID: 177211 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B43B")]
		[Address(RVA = "0x2713E00", Offset = "0x2712A00", VA = "0x182713E00", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0602B43C RID: 177212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B43C")]
		[Address(RVA = "0x2713F40", Offset = "0x2712B40", VA = "0x182713F40", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0602B43D RID: 177213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B43D")]
		[Address(RVA = "0x2714180", Offset = "0x2712D80", VA = "0x182714180", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0602B43E RID: 177214 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B43E")]
		[Address(RVA = "0x27143E0", Offset = "0x2712FE0", VA = "0x1827143E0", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0602B43F RID: 177215 RVA: 0x000DB4C8 File Offset: 0x000D96C8
		[Token(Token = "0x602B43F")]
		[Address(RVA = "0x2714A00", Offset = "0x2713600", VA = "0x182714A00", Slot = "12")]
		public override bool UseEarlyFromDataListener(Type fromState)
		{
			return default(bool);
		}

		// Token: 0x0602B440 RID: 177216 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B440")]
		[Address(RVA = "0x2714210", Offset = "0x2712E10", VA = "0x182714210", Slot = "11")]
		public override Dictionary<Type, Action<IStateBean>> RegisterFromDataListener()
		{
			return null;
		}

		// Token: 0x0602B441 RID: 177217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B441")]
		[Address(RVA = "0x27152A0", Offset = "0x2713EA0", VA = "0x1827152A0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602B442 RID: 177218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B442")]
		[Address(RVA = "0x2717150", Offset = "0x2715D50", VA = "0x182717150")]
		private void _RenderRegion()
		{
		}

		// Token: 0x0602B443 RID: 177219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B443")]
		[Address(RVA = "0x2716520", Offset = "0x2715120", VA = "0x182716520")]
		private void _OnTopMenuRoutedToOtherPage(UIRouteTarget routeTarget, object param, Action<UIRouteTarget, object> baseHandler)
		{
		}

		// Token: 0x0602B444 RID: 177220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B444")]
		[Address(RVA = "0x27174D0", Offset = "0x27160D0", VA = "0x1827174D0")]
		private void _SaveSquadFormationIfNeeded(Action<Act1LockSetSquadResponse> nextStep, bool mustGoNext = true, bool checkImmutable = true)
		{
		}

		// Token: 0x0602B445 RID: 177221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B445")]
		[Address(RVA = "0x2717780", Offset = "0x2716380", VA = "0x182717780")]
		private void _SaveSquadIfNeededBeforeStartBattle(Action<Act1LockSetSquadResponse> nextStep)
		{
		}

		// Token: 0x0602B446 RID: 177222 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B446")]
		[Address(RVA = "0x2716670", Offset = "0x2715270", VA = "0x182716670")]
		private Act1LockSetSquadRequest _ParseSquadFormationRequest()
		{
			return null;
		}

		// Token: 0x0602B447 RID: 177223 RVA: 0x000DB4E0 File Offset: 0x000D96E0
		[Token(Token = "0x602B447")]
		[Address(RVA = "0x2714B60", Offset = "0x2713760", VA = "0x182714B60")]
		private bool _CheckIfStartBattleValid()
		{
			return default(bool);
		}

		// Token: 0x0602B448 RID: 177224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B448")]
		[Address(RVA = "0x2714A70", Offset = "0x2713670", VA = "0x182714A70")]
		private void _AlertSquadInvalid()
		{
		}

		// Token: 0x0602B449 RID: 177225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B449")]
		[Address(RVA = "0x2716400", Offset = "0x2715000", VA = "0x182716400")]
		private void _OnSlotClicked(int index)
		{
		}

		// Token: 0x0602B44A RID: 177226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B44A")]
		[Address(RVA = "0x2714EB0", Offset = "0x2713AB0", VA = "0x182714EB0")]
		private void _DeleteCurrentSquad()
		{
		}

		// Token: 0x0602B44B RID: 177227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B44B")]
		[Address(RVA = "0x27150A0", Offset = "0x2713CA0", VA = "0x1827150A0")]
		private void _DoStartBattle()
		{
		}

		// Token: 0x0602B44C RID: 177228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B44C")]
		[Address(RVA = "0x2715530", Offset = "0x2714130", VA = "0x182715530")]
		private void _InvokedStartBattle(Act1LockSetSquadResponse squadResponse)
		{
		}

		// Token: 0x0602B44D RID: 177229 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B44D")]
		[Address(RVA = "0x2716FB0", Offset = "0x2715BB0", VA = "0x182716FB0")]
		private static CharacterCardViewModel _PickRandomCharacter(SquadItemStruct[] squad)
		{
			return null;
		}

		// Token: 0x0602B44E RID: 177230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B44E")]
		[Address(RVA = "0x27164C0", Offset = "0x27150C0", VA = "0x1827164C0")]
		private void _OnStartBattleSuccess()
		{
		}

		// Token: 0x0602B44F RID: 177231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B44F")]
		[Address(RVA = "0x27172A0", Offset = "0x2715EA0", VA = "0x1827172A0")]
		private void _SaveCacheStageConfig()
		{
		}

		// Token: 0x0602B450 RID: 177232 RVA: 0x000DB4F8 File Offset: 0x000D96F8
		[Token(Token = "0x602B450")]
		[Address(RVA = "0x2716A50", Offset = "0x2715650", VA = "0x182716A50")]
		private CharSelectStateBean.Input _ParseSquadSelectParam()
		{
			return default(CharSelectStateBean.Input);
		}

		// Token: 0x0602B451 RID: 177233 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B451")]
		[Address(RVA = "0x27151D0", Offset = "0x2713DD0", VA = "0x1827151D0")]
		private SquadItemStruct[] _GetCurSquadMembers()
		{
			return null;
		}

		// Token: 0x0602B452 RID: 177234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B452")]
		[Address(RVA = "0x27161B0", Offset = "0x2714DB0", VA = "0x1827161B0")]
		private void _OnCharSelectFinished(IStateBean stateBean)
		{
		}

		// Token: 0x0602B453 RID: 177235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B453")]
		[Address(RVA = "0x2716030", Offset = "0x2714C30", VA = "0x182716030")]
		private void _OnAssistSelectFinished(IStateBean stateBean)
		{
		}

		// Token: 0x0602B454 RID: 177236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B454")]
		[Address(RVA = "0x2713B20", Offset = "0x2712720", VA = "0x182713B20")]
		public void EventOnMultiFormatClick()
		{
		}

		// Token: 0x0602B455 RID: 177237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B455")]
		[Address(RVA = "0x27138C0", Offset = "0x27124C0", VA = "0x1827138C0")]
		public void EventOnClearBtnClick()
		{
		}

		// Token: 0x0602B456 RID: 177238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B456")]
		[Address(RVA = "0x27136A0", Offset = "0x27122A0", VA = "0x1827136A0")]
		public void EventOnAssistBtnClick()
		{
		}

		// Token: 0x0602B457 RID: 177239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B457")]
		[Address(RVA = "0x27137E0", Offset = "0x27123E0", VA = "0x1827137E0")]
		public void EventOnAssistClearClick()
		{
		}

		// Token: 0x0602B458 RID: 177240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B458")]
		[Address(RVA = "0x2713C80", Offset = "0x2712880", VA = "0x182713C80")]
		public void EventOnStartBtnClick()
		{
		}

		// Token: 0x0602B459 RID: 177241 RVA: 0x000DB510 File Offset: 0x000D9710
		[Token(Token = "0x602B459")]
		[Address(RVA = "0x2713550", Offset = "0x2712150", VA = "0x182713550")]
		public bool CheckCharInstSelectable(int instId)
		{
			return default(bool);
		}

		// Token: 0x0602B45A RID: 177242 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B45A")]
		[Address(RVA = "0x2713EE0", Offset = "0x2712AE0", VA = "0x182713EE0", Slot = "24")]
		public List<int> GetTempListForExclusiveInstIds()
		{
			return null;
		}

		// Token: 0x0602B45B RID: 177243 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B45B")]
		[Address(RVA = "0x2713E60", Offset = "0x2712A60", VA = "0x182713E60", Slot = "25")]
		public SquadGroupViewModel GetSquadGroupViewModel()
		{
			return null;
		}

		// Token: 0x0602B45C RID: 177244 RVA: 0x000DB528 File Offset: 0x000D9728
		[Token(Token = "0x602B45C")]
		[Address(RVA = "0x27135E0", Offset = "0x27121E0", VA = "0x1827135E0", Slot = "23")]
		public bool CheckIfCharSelectable(CharQuery charQuery)
		{
			return default(bool);
		}

		// Token: 0x0602B45D RID: 177245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B45D")]
		[Address(RVA = "0x2717800", Offset = "0x2716400", VA = "0x182717800")]
		public Act1LockSquadHomeState()
		{
		}

		// Token: 0x0602B463 RID: 177251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B463")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0602B464 RID: 177252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B464")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0602B465 RID: 177253 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B465")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0602B466 RID: 177254 RVA: 0x000DB540 File Offset: 0x000D9740
		[Token(Token = "0x602B466")]
		[Address(RVA = "0x11033F0", Offset = "0x1101FF0", VA = "0x1811033F0")]
		private bool <>xLuaBaseProxy_UseEarlyFromDataListener(Type P0)
		{
			return default(bool);
		}

		// Token: 0x0602B467 RID: 177255 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B467")]
		[Address(RVA = "0xE63470", Offset = "0xE62070", VA = "0x180E63470")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterFromDataListener()
		{
			return null;
		}

		// Token: 0x0403E874 RID: 256116
		[Token(Token = "0x403E874")]
		private const string ANIMATORPARAM = "delete";

		// Token: 0x0403E875 RID: 256117
		[Token(Token = "0x403E875")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private SquadCharSelectMaskPlugin _charSelectMaskPluginPrefab;

		// Token: 0x0403E876 RID: 256118
		[Token(Token = "0x403E876")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private RectTransform _topMenuContainer;

		// Token: 0x0403E877 RID: 256119
		[Token(Token = "0x403E877")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Animator _deleteState;

		// Token: 0x0403E878 RID: 256120
		[Token(Token = "0x403E878")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Act1LockSquadGroupController _squadGroupController;

		// Token: 0x0403E879 RID: 256121
		[Token(Token = "0x403E879")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Act1LockAssistCardView _assistCard;

		// Token: 0x0403E87A RID: 256122
		[Token(Token = "0x403E87A")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Image _startBattleImg;

		// Token: 0x0403E87B RID: 256123
		[Token(Token = "0x403E87B")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("region")]
		private Image _finRegionImg;

		// Token: 0x0403E87C RID: 256124
		[Token(Token = "0x403E87C")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("region")]
		private Image _interlockRegionImg;

		// Token: 0x0403E87D RID: 256125
		[Token(Token = "0x403E87D")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Group("region")]
		private Sprite[] _interlockRegionSprites;

		// Token: 0x0403E87E RID: 256126
		[Token(Token = "0x403E87E")]
		[FieldOffset(Offset = "0x98")]
		private bool m_isInited;

		// Token: 0x0403E87F RID: 256127
		[Token(Token = "0x403E87F")]
		[FieldOffset(Offset = "0xA0")]
		private Act1LockSquadStateBean m_stateBean;

		// Token: 0x0403E880 RID: 256128
		[Token(Token = "0x403E880")]
		[FieldOffset(Offset = "0xA8")]
		private Act1LockSquadHomeState.CharSelectContext m_charSelectContext;

		// Token: 0x0403E881 RID: 256129
		[Token(Token = "0x403E881")]
		[FieldOffset(Offset = "0xB0")]
		private bool m_deleteFlag;

		// Token: 0x0403E882 RID: 256130
		[Token(Token = "0x403E882")]
		[FieldOffset(Offset = "0xB8")]
		private SquadHomeState.DefaultCharSelectInput m_charSelectInputParam;

		// Token: 0x0403E883 RID: 256131
		[Token(Token = "0x403E883")]
		[FieldOffset(Offset = "0x100")]
		private List<int> m_tempListForExclusiveInstIds;

		// Token: 0x0403E884 RID: 256132
		[Token(Token = "0x403E884")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0403E885 RID: 256133
		[Token(Token = "0x403E885")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403E886 RID: 256134
		[Token(Token = "0x403E886")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0403E887 RID: 256135
		[Token(Token = "0x403E887")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x0403E888 RID: 256136
		[Token(Token = "0x403E888")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_UseEarlyFromDataListener;

		// Token: 0x0403E889 RID: 256137
		[Token(Token = "0x403E889")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_RegisterFromDataListener;

		// Token: 0x0403E88A RID: 256138
		[Token(Token = "0x403E88A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403E88B RID: 256139
		[Token(Token = "0x403E88B")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__RenderRegion;

		// Token: 0x0403E88C RID: 256140
		[Token(Token = "0x403E88C")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnTopMenuRoutedToOtherPage;

		// Token: 0x0403E88D RID: 256141
		[Token(Token = "0x403E88D")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__SaveSquadFormationIfNeeded;

		// Token: 0x0403E88E RID: 256142
		[Token(Token = "0x403E88E")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__SaveSquadIfNeededBeforeStartBattle;

		// Token: 0x0403E88F RID: 256143
		[Token(Token = "0x403E88F")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__ParseSquadFormationRequest;

		// Token: 0x0403E890 RID: 256144
		[Token(Token = "0x403E890")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__CheckIfStartBattleValid;

		// Token: 0x0403E891 RID: 256145
		[Token(Token = "0x403E891")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__AlertSquadInvalid;

		// Token: 0x0403E892 RID: 256146
		[Token(Token = "0x403E892")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__OnSlotClicked;

		// Token: 0x0403E893 RID: 256147
		[Token(Token = "0x403E893")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__DeleteCurrentSquad;

		// Token: 0x0403E894 RID: 256148
		[Token(Token = "0x403E894")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__DoStartBattle;

		// Token: 0x0403E895 RID: 256149
		[Token(Token = "0x403E895")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__InvokedStartBattle;

		// Token: 0x0403E896 RID: 256150
		[Token(Token = "0x403E896")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__PickRandomCharacter;

		// Token: 0x0403E897 RID: 256151
		[Token(Token = "0x403E897")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__OnStartBattleSuccess;

		// Token: 0x0403E898 RID: 256152
		[Token(Token = "0x403E898")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__SaveCacheStageConfig;

		// Token: 0x0403E899 RID: 256153
		[Token(Token = "0x403E899")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__ParseSquadSelectParam;

		// Token: 0x0403E89A RID: 256154
		[Token(Token = "0x403E89A")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__GetCurSquadMembers;

		// Token: 0x0403E89B RID: 256155
		[Token(Token = "0x403E89B")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__OnCharSelectFinished;

		// Token: 0x0403E89C RID: 256156
		[Token(Token = "0x403E89C")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__OnAssistSelectFinished;

		// Token: 0x0403E89D RID: 256157
		[Token(Token = "0x403E89D")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_EventOnMultiFormatClick;

		// Token: 0x0403E89E RID: 256158
		[Token(Token = "0x403E89E")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_EventOnClearBtnClick;

		// Token: 0x0403E89F RID: 256159
		[Token(Token = "0x403E89F")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_EventOnAssistBtnClick;

		// Token: 0x0403E8A0 RID: 256160
		[Token(Token = "0x403E8A0")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_EventOnAssistClearClick;

		// Token: 0x0403E8A1 RID: 256161
		[Token(Token = "0x403E8A1")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_EventOnStartBtnClick;

		// Token: 0x0403E8A2 RID: 256162
		[Token(Token = "0x403E8A2")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_CheckCharInstSelectable;

		// Token: 0x0403E8A3 RID: 256163
		[Token(Token = "0x403E8A3")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_GetTempListForExclusiveInstIds;

		// Token: 0x0403E8A4 RID: 256164
		[Token(Token = "0x403E8A4")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_GetSquadGroupViewModel;

		// Token: 0x0403E8A5 RID: 256165
		[Token(Token = "0x403E8A5")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_CheckIfCharSelectable;

		// Token: 0x0403E8A6 RID: 256166
		[Token(Token = "0x403E8A6")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007890 RID: 30864
		[Token(Token = "0x2007890")]
		private struct CharSelectContext
		{
			// Token: 0x0403E8A7 RID: 256167
			[Token(Token = "0x403E8A7")]
			[FieldOffset(Offset = "0x0")]
			public int editIndex;

			// Token: 0x0403E8A8 RID: 256168
			[Token(Token = "0x403E8A8")]
			[FieldOffset(Offset = "0x4")]
			public bool isSingleMode;
		}

		// Token: 0x02007891 RID: 30865
		[Token(Token = "0x2007891")]
		public class CharSelectPlugin : UICharacterSelectState.Plugin<Act1LockSquadHomeState>
		{
			// Token: 0x0602B468 RID: 177256 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602B468")]
			[Address(RVA = "0x271B6F0", Offset = "0x271A2F0", VA = "0x18271B6F0", Slot = "25")]
			public override void OverrideCharSelect(int instId, Action<int> selfCharSelect)
			{
			}

			// Token: 0x0602B469 RID: 177257 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602B469")]
			[Address(RVA = "0x271B9A0", Offset = "0x271A5A0", VA = "0x18271B9A0", Slot = "30")]
			public override void OverrideSkillSelect(string skillId, Action<string> selfSkillSelect)
			{
			}

			// Token: 0x0602B46A RID: 177258 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602B46A")]
			[Address(RVA = "0x271B650", Offset = "0x271A250", VA = "0x18271B650", Slot = "31")]
			public override void OverrideBranchSelect(string equipId, Action<string> selfBranchSelect)
			{
			}

			// Token: 0x0602B46B RID: 177259 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602B46B")]
			[Address(RVA = "0x271B820", Offset = "0x271A420", VA = "0x18271B820", Slot = "33")]
			public override void OverrideDismiss(Action selfDismiss)
			{
			}

			// Token: 0x0602B46C RID: 177260 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602B46C")]
			[Address(RVA = "0x271B4A0", Offset = "0x271A0A0", VA = "0x18271B4A0", Slot = "37")]
			public override void AddCharMultiSelectExcludeRule(int instId, List<int> excludeInstIds)
			{
			}

			// Token: 0x17006536 RID: 25910
			// (get) Token: 0x0602B46D RID: 177261 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17006536")]
			public override CharSelectCardMaskPlugin cardMaskPrefab
			{
				[Token(Token = "0x602B46D")]
				[Address(RVA = "0x271BC50", Offset = "0x271A850", VA = "0x18271BC50", Slot = "32")]
				get
				{
					return null;
				}
			}

			// Token: 0x0602B46E RID: 177262 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602B46E")]
			[Address(RVA = "0x271B920", Offset = "0x271A520", VA = "0x18271B920", Slot = "26")]
			public override void OverrideSelectConfirmed(Action selfConfirm)
			{
			}

			// Token: 0x0602B46F RID: 177263 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602B46F")]
			[Address(RVA = "0x271B8A0", Offset = "0x271A4A0", VA = "0x18271B8A0", Slot = "27")]
			public override void OverrideSelectCanceled(Action selfCancel)
			{
			}

			// Token: 0x17006537 RID: 25911
			// (get) Token: 0x0602B470 RID: 177264 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17006537")]
			public override string overrideNoCharText
			{
				[Token(Token = "0x602B470")]
				[Address(RVA = "0x271BCD0", Offset = "0x271A8D0", VA = "0x18271BCD0", Slot = "28")]
				get
				{
					return null;
				}
			}

			// Token: 0x17006538 RID: 25912
			// (get) Token: 0x0602B471 RID: 177265 RVA: 0x000DB558 File Offset: 0x000D9758
			[Token(Token = "0x17006538")]
			public override bool showCharInfoEntry
			{
				[Token(Token = "0x602B471")]
				[Address(RVA = "0x271BD40", Offset = "0x271A940", VA = "0x18271BD40", Slot = "29")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0602B472 RID: 177266 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602B472")]
			[Address(RVA = "0x271BB10", Offset = "0x271A710", VA = "0x18271BB10", Slot = "34")]
			public override string OverrideUpdateSelectedSkill(int instId, string prevSkill, Func<int, string, string> selfUpdateSelectSkill)
			{
				return null;
			}

			// Token: 0x0602B473 RID: 177267 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602B473")]
			[Address(RVA = "0x271BA40", Offset = "0x271A640", VA = "0x18271BA40", Slot = "35")]
			public override string OverrideUpdateSelectedBranch(int instId, string prevBranch, Func<int, string, string> selfUpdateSelectBranch)
			{
				return null;
			}

			// Token: 0x0602B474 RID: 177268 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602B474")]
			[Address(RVA = "0x271BBE0", Offset = "0x271A7E0", VA = "0x18271BBE0")]
			public CharSelectPlugin()
			{
			}

			// Token: 0x0403E8A9 RID: 256169
			[Token(Token = "0x403E8A9")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_OverrideCharSelect;

			// Token: 0x0403E8AA RID: 256170
			[Token(Token = "0x403E8AA")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OverrideSkillSelect;

			// Token: 0x0403E8AB RID: 256171
			[Token(Token = "0x403E8AB")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_OverrideBranchSelect;

			// Token: 0x0403E8AC RID: 256172
			[Token(Token = "0x403E8AC")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_OverrideDismiss;

			// Token: 0x0403E8AD RID: 256173
			[Token(Token = "0x403E8AD")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_AddCharMultiSelectExcludeRule;

			// Token: 0x0403E8AE RID: 256174
			[Token(Token = "0x403E8AE")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_get_cardMaskPrefab;

			// Token: 0x0403E8AF RID: 256175
			[Token(Token = "0x403E8AF")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_OverrideSelectConfirmed;

			// Token: 0x0403E8B0 RID: 256176
			[Token(Token = "0x403E8B0")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_OverrideSelectCanceled;

			// Token: 0x0403E8B1 RID: 256177
			[Token(Token = "0x403E8B1")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_get_overrideNoCharText;

			// Token: 0x0403E8B2 RID: 256178
			[Token(Token = "0x403E8B2")]
			[FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0_get_showCharInfoEntry;

			// Token: 0x0403E8B3 RID: 256179
			[Token(Token = "0x403E8B3")]
			[FieldOffset(Offset = "0x50")]
			private static DelegateBridge __Hotfix0_OverrideUpdateSelectedSkill;

			// Token: 0x0403E8B4 RID: 256180
			[Token(Token = "0x403E8B4")]
			[FieldOffset(Offset = "0x58")]
			private static DelegateBridge __Hotfix0_OverrideUpdateSelectedBranch;

			// Token: 0x0403E8B5 RID: 256181
			[Token(Token = "0x403E8B5")]
			[FieldOffset(Offset = "0x60")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02007892 RID: 30866
		[Token(Token = "0x2007892")]
		public class InterlockStageBattleFinishIndexPlugin : BattleFinishIndexState.IPlugin, IHotfixable
		{
			// Token: 0x0602B475 RID: 177269 RVA: 0x000DB570 File Offset: 0x000D9770
			[Token(Token = "0x602B475")]
			[Address(RVA = "0x271BDA0", Offset = "0x271A9A0", VA = "0x18271BDA0", Slot = "4")]
			public bool HandleRedirection()
			{
				return default(bool);
			}

			// Token: 0x0602B476 RID: 177270 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602B476")]
			[Address(RVA = "0x271C0B0", Offset = "0x271ACB0", VA = "0x18271C0B0")]
			public InterlockStageBattleFinishIndexPlugin()
			{
			}

			// Token: 0x0403E8B6 RID: 256182
			[Token(Token = "0x403E8B6")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_HandleRedirection;

			// Token: 0x0403E8B7 RID: 256183
			[Token(Token = "0x403E8B7")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
