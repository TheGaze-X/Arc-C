using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.TemplateCharSelect;
using Torappu.UI.TemplateCharSelect.Common;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x0200772F RID: 30511
	[Token(Token = "0x200772F")]
	public class Act1VHalfIdleDepotState : PopupFadeState, IValueMsgReceiver
	{
		// Token: 0x0602ADD5 RID: 175573 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602ADD5")]
		[Address(RVA = "0x26A5280", Offset = "0x26A3E80", VA = "0x1826A5280", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0602ADD6 RID: 175574 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602ADD6")]
		[Address(RVA = "0x26A5120", Offset = "0x26A3D20", VA = "0x1826A5120", Slot = "11")]
		public override Dictionary<Type, Action<IStateBean>> RegisterFromDataListener()
		{
			return null;
		}

		// Token: 0x0602ADD7 RID: 175575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ADD7")]
		[Address(RVA = "0x26A5BA0", Offset = "0x26A47A0", VA = "0x1826A5BA0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602ADD8 RID: 175576 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602ADD8")]
		[Address(RVA = "0x26A44D0", Offset = "0x26A30D0", VA = "0x1826A44D0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0602ADD9 RID: 175577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ADD9")]
		[Address(RVA = "0x26A46F0", Offset = "0x26A32F0", VA = "0x1826A46F0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0602ADDA RID: 175578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ADDA")]
		[Address(RVA = "0x26A4DE0", Offset = "0x26A39E0", VA = "0x1826A4DE0", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0602ADDB RID: 175579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ADDB")]
		[Address(RVA = "0x26A48E0", Offset = "0x26A34E0", VA = "0x1826A48E0", Slot = "18")]
		protected override void OnExit()
		{
		}

		// Token: 0x0602ADDC RID: 175580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ADDC")]
		[Address(RVA = "0x26A4690", Offset = "0x26A3290", VA = "0x1826A4690")]
		private void OnDestroy()
		{
		}

		// Token: 0x0602ADDD RID: 175581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ADDD")]
		[Address(RVA = "0x26A4530", Offset = "0x26A3130", VA = "0x1826A4530")]
		public void OnBackFromRecruitPage()
		{
		}

		// Token: 0x0602ADDE RID: 175582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ADDE")]
		[Address(RVA = "0x26A4960", Offset = "0x26A3560", VA = "0x1826A4960", Slot = "31")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x0602ADDF RID: 175583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ADDF")]
		[Address(RVA = "0x26A6860", Offset = "0x26A5460", VA = "0x1826A6860")]
		private void _OnTabClicked(string tabId)
		{
		}

		// Token: 0x0602ADE0 RID: 175584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ADE0")]
		[Address(RVA = "0x26A6020", Offset = "0x26A4C20", VA = "0x1826A6020")]
		private void _OnBtnRecruitClicked()
		{
		}

		// Token: 0x0602ADE1 RID: 175585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ADE1")]
		[Address(RVA = "0x26A5F80", Offset = "0x26A4B80", VA = "0x1826A5F80")]
		protected void _OnBtnBuffClicked()
		{
		}

		// Token: 0x0602ADE2 RID: 175586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ADE2")]
		[Address(RVA = "0x26A5DE0", Offset = "0x26A49E0", VA = "0x1826A5DE0")]
		protected void _OnBtnAssistClicked()
		{
		}

		// Token: 0x0602ADE3 RID: 175587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ADE3")]
		[Address(RVA = "0x26A65F0", Offset = "0x26A51F0", VA = "0x1826A65F0")]
		protected void _OnReqOpenCharSelect(Act1VHalfIdleDepotState.CharDepotCardClickOutPut outPut)
		{
		}

		// Token: 0x0602ADE4 RID: 175588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ADE4")]
		[Address(RVA = "0x26A6910", Offset = "0x26A5510", VA = "0x1826A6910")]
		private void _OnTopMenuCreated(GameObject obj)
		{
		}

		// Token: 0x0602ADE5 RID: 175589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ADE5")]
		[Address(RVA = "0x26A53E0", Offset = "0x26A3FE0", VA = "0x1826A53E0")]
		private void _ConsumeAllNewCharTrackpoint()
		{
		}

		// Token: 0x0602ADE6 RID: 175590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ADE6")]
		[Address(RVA = "0x26A5E80", Offset = "0x26A4A80", VA = "0x1826A5E80")]
		private void _OnBtnBackClicked()
		{
		}

		// Token: 0x0602ADE7 RID: 175591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ADE7")]
		[Address(RVA = "0x26A61A0", Offset = "0x26A4DA0", VA = "0x1826A61A0")]
		private void _OnGuideBookClicked()
		{
		}

		// Token: 0x0602ADE8 RID: 175592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ADE8")]
		[Address(RVA = "0x26A62A0", Offset = "0x26A4EA0", VA = "0x1826A62A0")]
		private void _OnJumpFromCharSelectState(IStateBean stateBean)
		{
		}

		// Token: 0x0602ADE9 RID: 175593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ADE9")]
		[Address(RVA = "0x26A6DA0", Offset = "0x26A59A0", VA = "0x1826A6DA0")]
		private void _PassDataToCharSelect(IStateBean stateBean)
		{
		}

		// Token: 0x0602ADEA RID: 175594 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602ADEA")]
		[Address(RVA = "0x26A6AB0", Offset = "0x26A56B0", VA = "0x1826A6AB0")]
		private TemplateCharSelectController.InputParam _ParseTemplateCharSelectInputParam(Act1VHalfIdleDepotState.CharDepotCardClickOutPut outPut)
		{
			return null;
		}

		// Token: 0x0602ADEB RID: 175595 RVA: 0x000DA4F0 File Offset: 0x000D86F0
		[Token(Token = "0x602ADEB")]
		[Address(RVA = "0x26A5700", Offset = "0x26A4300", VA = "0x1826A5700")]
		private CommonCharSelectCustomization _GenCharSelectCustomization(string actId)
		{
			return default(CommonCharSelectCustomization);
		}

		// Token: 0x0602ADEC RID: 175596 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602ADEC")]
		[Address(RVA = "0x26A5A20", Offset = "0x26A4620", VA = "0x1826A5A20")]
		private TemplateCharSelectController.TemplateCustomInput _GetCharSelectCustomInput(Act1VHalfIdleDepotState.CharDepotCardClickOutPut outPut)
		{
			return null;
		}

		// Token: 0x0602ADED RID: 175597 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602ADED")]
		[Address(RVA = "0x26A5460", Offset = "0x26A4060", VA = "0x1826A5460")]
		private TemplateCharSelectCardViewModel _CreateCharSelectCardViewModel(int instId, TemplateCharSelectCharInputData inputNullable, [Optional] PlayerCharacter playerData)
		{
			return null;
		}

		// Token: 0x0602ADEE RID: 175598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ADEE")]
		[Address(RVA = "0x26A7100", Offset = "0x26A5D00", VA = "0x1826A7100")]
		private void _TryRaiseAVGSignal()
		{
		}

		// Token: 0x0602ADEF RID: 175599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ADEF")]
		[Address(RVA = "0x26A6ED0", Offset = "0x26A5AD0", VA = "0x1826A6ED0")]
		private void _StopTutorialCoroutine()
		{
		}

		// Token: 0x0602ADF0 RID: 175600 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602ADF0")]
		[Address(RVA = "0x26A72A0", Offset = "0x26A5EA0", VA = "0x1826A72A0")]
		private IEnumerator _WaitAndTriggerTutorialAVG()
		{
			return null;
		}

		// Token: 0x0602ADF1 RID: 175601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ADF1")]
		[Address(RVA = "0x26A6FB0", Offset = "0x26A5BB0", VA = "0x1826A6FB0")]
		private void _TryConsumeGuidebook()
		{
		}

		// Token: 0x0602ADF2 RID: 175602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ADF2")]
		[Address(RVA = "0x26A7350", Offset = "0x26A5F50", VA = "0x1826A7350")]
		public Act1VHalfIdleDepotState()
		{
		}

		// Token: 0x0602ADF3 RID: 175603 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602ADF3")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0602ADF4 RID: 175604 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602ADF4")]
		[Address(RVA = "0xE63470", Offset = "0xE62070", VA = "0x180E63470")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterFromDataListener()
		{
			return null;
		}

		// Token: 0x0602ADF5 RID: 175605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ADF5")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0602ADF6 RID: 175606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ADF6")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0602ADF7 RID: 175607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ADF7")]
		[Address(RVA = "0xE63460", Offset = "0xE62060", VA = "0x180E63460")]
		private void <>xLuaBaseProxy_OnExit()
		{
		}

		// Token: 0x0403DCBF RID: 253119
		[Token(Token = "0x403DCBF")]
		private const int TAB_COUNT = 3;

		// Token: 0x0403DCC0 RID: 253120
		[Token(Token = "0x403DCC0")]
		private const string GUIDE_BOOK_SUB_SIGNAL = "depot";

		// Token: 0x0403DCC1 RID: 253121
		[Token(Token = "0x403DCC1")]
		[NonSerialized]
		public const int MSG_ON_TAB_CLICKED = 0;

		// Token: 0x0403DCC2 RID: 253122
		[Token(Token = "0x403DCC2")]
		[NonSerialized]
		public const int MSG_ON_BTN_RECRUIT_CLICKED = 1;

		// Token: 0x0403DCC3 RID: 253123
		[Token(Token = "0x403DCC3")]
		[NonSerialized]
		public const int MSG_ON_BTN_BUFF_CLICKED = 2;

		// Token: 0x0403DCC4 RID: 253124
		[Token(Token = "0x403DCC4")]
		[NonSerialized]
		public const int MSG_ON_BTN_ASSIST_CLICKED = 3;

		// Token: 0x0403DCC5 RID: 253125
		[Token(Token = "0x403DCC5")]
		[NonSerialized]
		public const int MSG_ON_REQ_OPEN_CHAR_SELECT = 4;

		// Token: 0x0403DCC6 RID: 253126
		[Token(Token = "0x403DCC6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private PrefabInstHolder _topMenuPrefabHolder;

		// Token: 0x0403DCC7 RID: 253127
		[Token(Token = "0x403DCC7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UITabPager _tabPager;

		// Token: 0x0403DCC8 RID: 253128
		[Token(Token = "0x403DCC8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Act1VHalfIdleDepotTabListView _tabListView;

		// Token: 0x0403DCC9 RID: 253129
		[Token(Token = "0x403DCC9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private UIGuidebookTrigger _guidebookTrigger;

		// Token: 0x0403DCCA RID: 253130
		[Token(Token = "0x403DCCA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Act1VHalfIdleDepotStateBean m_stateBean;

		// Token: 0x0403DCCB RID: 253131
		[Token(Token = "0x403DCCB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private UITabPager.Core m_tabPagerCore;

		// Token: 0x0403DCCC RID: 253132
		[Token(Token = "0x403DCCC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private bool m_inited;

		// Token: 0x0403DCCD RID: 253133
		[Token(Token = "0x403DCCD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Act1VHalfIdleDepotPage m_page;

		// Token: 0x0403DCCE RID: 253134
		[Token(Token = "0x403DCCE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Dictionary<string, Act1VHalfIdleCharViewModel.Act1VHalfIdleCharType> m_cachedCharStatusDict;

		// Token: 0x0403DCCF RID: 253135
		[Token(Token = "0x403DCCF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private TemplateCharSelectController.InputParam m_paramToSelectState;

		// Token: 0x0403DCD0 RID: 253136
		[Token(Token = "0x403DCD0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private CommonCharSelectCustomization m_charSelectCustomization;

		// Token: 0x0403DCD1 RID: 253137
		[Token(Token = "0x403DCD1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Coroutine m_tutorialCoroutine;

		// Token: 0x0403DCD2 RID: 253138
		[Token(Token = "0x403DCD2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x0403DCD3 RID: 253139
		[Token(Token = "0x403DCD3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RegisterFromDataListener;

		// Token: 0x0403DCD4 RID: 253140
		[Token(Token = "0x403DCD4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403DCD5 RID: 253141
		[Token(Token = "0x403DCD5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0403DCD6 RID: 253142
		[Token(Token = "0x403DCD6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403DCD7 RID: 253143
		[Token(Token = "0x403DCD7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0403DCD8 RID: 253144
		[Token(Token = "0x403DCD8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x0403DCD9 RID: 253145
		[Token(Token = "0x403DCD9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0403DCDA RID: 253146
		[Token(Token = "0x403DCDA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnBackFromRecruitPage;

		// Token: 0x0403DCDB RID: 253147
		[Token(Token = "0x403DCDB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x0403DCDC RID: 253148
		[Token(Token = "0x403DCDC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnTabClicked;

		// Token: 0x0403DCDD RID: 253149
		[Token(Token = "0x403DCDD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__OnBtnRecruitClicked;

		// Token: 0x0403DCDE RID: 253150
		[Token(Token = "0x403DCDE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__OnBtnBuffClicked;

		// Token: 0x0403DCDF RID: 253151
		[Token(Token = "0x403DCDF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__OnBtnAssistClicked;

		// Token: 0x0403DCE0 RID: 253152
		[Token(Token = "0x403DCE0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__OnReqOpenCharSelect;

		// Token: 0x0403DCE1 RID: 253153
		[Token(Token = "0x403DCE1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__OnTopMenuCreated;

		// Token: 0x0403DCE2 RID: 253154
		[Token(Token = "0x403DCE2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__ConsumeAllNewCharTrackpoint;

		// Token: 0x0403DCE3 RID: 253155
		[Token(Token = "0x403DCE3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__OnBtnBackClicked;

		// Token: 0x0403DCE4 RID: 253156
		[Token(Token = "0x403DCE4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__OnGuideBookClicked;

		// Token: 0x0403DCE5 RID: 253157
		[Token(Token = "0x403DCE5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__OnJumpFromCharSelectState;

		// Token: 0x0403DCE6 RID: 253158
		[Token(Token = "0x403DCE6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__PassDataToCharSelect;

		// Token: 0x0403DCE7 RID: 253159
		[Token(Token = "0x403DCE7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__ParseTemplateCharSelectInputParam;

		// Token: 0x0403DCE8 RID: 253160
		[Token(Token = "0x403DCE8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__GenCharSelectCustomization;

		// Token: 0x0403DCE9 RID: 253161
		[Token(Token = "0x403DCE9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__GetCharSelectCustomInput;

		// Token: 0x0403DCEA RID: 253162
		[Token(Token = "0x403DCEA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__CreateCharSelectCardViewModel;

		// Token: 0x0403DCEB RID: 253163
		[Token(Token = "0x403DCEB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__TryRaiseAVGSignal;

		// Token: 0x0403DCEC RID: 253164
		[Token(Token = "0x403DCEC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__StopTutorialCoroutine;

		// Token: 0x0403DCED RID: 253165
		[Token(Token = "0x403DCED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__WaitAndTriggerTutorialAVG;

		// Token: 0x0403DCEE RID: 253166
		[Token(Token = "0x403DCEE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__TryConsumeGuidebook;

		// Token: 0x0403DCEF RID: 253167
		[Token(Token = "0x403DCEF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007730 RID: 30512
		[Token(Token = "0x2007730")]
		private class TabDataSource : UITabPager.TabDataSource
		{
			// Token: 0x0602ADF8 RID: 175608 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602ADF8")]
			[Address(RVA = "0x26A9D30", Offset = "0x26A8930", VA = "0x1826A9D30")]
			public TabDataSource(Act1VHalfIdleDepotState closure)
			{
			}

			// Token: 0x0602ADF9 RID: 175609 RVA: 0x000DA508 File Offset: 0x000D8708
			[Token(Token = "0x602ADF9")]
			[Address(RVA = "0x26A9BE0", Offset = "0x26A87E0", VA = "0x1826A9BE0", Slot = "4")]
			public override int GetTabCount()
			{
				return 0;
			}

			// Token: 0x0602ADFA RID: 175610 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602ADFA")]
			[Address(RVA = "0x26A9C40", Offset = "0x26A8840", VA = "0x1826A9C40", Slot = "5")]
			public override UITabPager.TabPageViewModel GetTab(int index)
			{
				return null;
			}

			// Token: 0x0403DCF0 RID: 253168
			[Token(Token = "0x403DCF0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private Act1VHalfIdleDepotState m_closure;

			// Token: 0x0403DCF1 RID: 253169
			[Token(Token = "0x403DCF1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0403DCF2 RID: 253170
			[Token(Token = "0x403DCF2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GetTabCount;

			// Token: 0x0403DCF3 RID: 253171
			[Token(Token = "0x403DCF3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GetTab;
		}

		// Token: 0x02007731 RID: 30513
		[Token(Token = "0x2007731")]
		public class CharDepotCardClickOutPut : IHotfixable
		{
			// Token: 0x0602ADFB RID: 175611 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602ADFB")]
			[Address(RVA = "0x26A77C0", Offset = "0x26A63C0", VA = "0x1826A77C0")]
			public CharDepotCardClickOutPut()
			{
			}

			// Token: 0x0403DCF4 RID: 253172
			[Token(Token = "0x403DCF4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int instId;

			// Token: 0x0403DCF5 RID: 253173
			[Token(Token = "0x403DCF5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public CharacterProfessionFilterParam filterParam;

			// Token: 0x0403DCF6 RID: 253174
			[Token(Token = "0x403DCF6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public CharacterSortType sortType;

			// Token: 0x0403DCF7 RID: 253175
			[Token(Token = "0x403DCF7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public int index;

			// Token: 0x0403DCF8 RID: 253176
			[Token(Token = "0x403DCF8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
