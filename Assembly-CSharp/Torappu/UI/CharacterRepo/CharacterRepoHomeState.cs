using System;
using Il2CppDummyDll;
using Torappu.AsyncLoader;
using Torappu.AVG;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CharacterRepo
{
	// Token: 0x02005E2C RID: 24108
	[Token(Token = "0x2005E2C")]
	public class CharacterRepoHomeState : CharacterRepoCommonState, ITimeWatcher, IHotfixable
	{
		// Token: 0x06022EEF RID: 143087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022EEF")]
		[Address(RVA = "0x1D7A4A0", Offset = "0x1D790A0", VA = "0x181D7A4A0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06022EF0 RID: 143088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022EF0")]
		[Address(RVA = "0x1D7AE50", Offset = "0x1D79A50", VA = "0x181D7AE50", Slot = "23")]
		public void UpdateTime(float deltaTime)
		{
		}

		// Token: 0x06022EF1 RID: 143089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022EF1")]
		[Address(RVA = "0x1D7B0F0", Offset = "0x1D79CF0", VA = "0x181D7B0F0")]
		private void _InitAnimation(bool isPanelShow)
		{
		}

		// Token: 0x06022EF2 RID: 143090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022EF2")]
		[Address(RVA = "0x1D7A350", Offset = "0x1D78F50", VA = "0x181D7A350")]
		public void EventOnEnableStarMarkEditMode()
		{
		}

		// Token: 0x06022EF3 RID: 143091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022EF3")]
		[Address(RVA = "0x1D7A980", Offset = "0x1D79580", VA = "0x181D7A980")]
		public void OnStarMarkEditConfirm()
		{
		}

		// Token: 0x06022EF4 RID: 143092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022EF4")]
		[Address(RVA = "0x1D7ACD0", Offset = "0x1D798D0", VA = "0x181D7ACD0")]
		public void SelectStarMark(int chrInstId)
		{
		}

		// Token: 0x06022EF5 RID: 143093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022EF5")]
		[Address(RVA = "0x1D7B820", Offset = "0x1D7A420", VA = "0x181D7B820")]
		public void eventOnFilterClick(UICharacterProfessionFilterHolder.FilterParam filterModel)
		{
		}

		// Token: 0x06022EF6 RID: 143094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022EF6")]
		[Address(RVA = "0x1D7B9B0", Offset = "0x1D7A5B0", VA = "0x181D7B9B0")]
		public void eventOnFilterShow(bool isShow)
		{
		}

		// Token: 0x06022EF7 RID: 143095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022EF7")]
		[Address(RVA = "0x1D7BAD0", Offset = "0x1D7A6D0", VA = "0x181D7BAD0")]
		public void eventOnSortClick(CharacterSortType sortType)
		{
		}

		// Token: 0x06022EF8 RID: 143096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022EF8")]
		[Address(RVA = "0x1D7B450", Offset = "0x1D7A050", VA = "0x181D7B450")]
		private void _OnSendStarMarkEditRequest(ListDict<string, int> starMarkDict)
		{
		}

		// Token: 0x06022EF9 RID: 143097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022EF9")]
		[Address(RVA = "0x1D7B360", Offset = "0x1D79F60", VA = "0x181D7B360")]
		private void _OnFilterPanelSwitch(bool isShow)
		{
		}

		// Token: 0x06022EFA RID: 143098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022EFA")]
		[Address(RVA = "0x1D7B240", Offset = "0x1D79E40", VA = "0x181D7B240")]
		private void _InitSortPanelSwitch(bool isShow)
		{
		}

		// Token: 0x06022EFB RID: 143099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022EFB")]
		[Address(RVA = "0x1D7B6E0", Offset = "0x1D7A2E0", VA = "0x181D7B6E0")]
		private void _TryUpdateFilterPanelShow(bool isFilterPanelShow)
		{
		}

		// Token: 0x06022EFC RID: 143100 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022EFC")]
		[Address(RVA = "0x1D7AF20", Offset = "0x1D79B20", VA = "0x181D7AF20")]
		private AVGSignalActions.Trigger _CreateRoutedAVGSignal()
		{
			return null;
		}

		// Token: 0x06022EFD RID: 143101 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022EFD")]
		[Address(RVA = "0x1D7AED0", Offset = "0x1D79AD0", VA = "0x181D7AED0")]
		private static AsyncGameObjectLoader _CreateCardLoader()
		{
			return null;
		}

		// Token: 0x06022EFE RID: 143102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022EFE")]
		[Address(RVA = "0x1D7B780", Offset = "0x1D7A380", VA = "0x181D7B780")]
		public CharacterRepoHomeState()
		{
		}

		// Token: 0x06022F00 RID: 143104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022F00")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x040301F2 RID: 197106
		[Token(Token = "0x40301F2")]
		private const int LOAD_CARD_PER_FRAME = 1;

		// Token: 0x040301F3 RID: 197107
		[Token(Token = "0x40301F3")]
		private const bool USE_ASYNC_CARD_LOADER = false;

		// Token: 0x040301F4 RID: 197108
		[Token(Token = "0x40301F4")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Tooltip("Scrollbar to controll the position of char list")]
		private Scrollbar _charListScrollbar;

		// Token: 0x040301F5 RID: 197109
		[Token(Token = "0x40301F5")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private UIAnimationLocation _repoFilterPanelSwitchAnim;

		// Token: 0x040301F6 RID: 197110
		[Token(Token = "0x40301F6")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UICharacterRepoSortFilterPanelBinder _sortFilterPanelBinder;

		// Token: 0x040301F7 RID: 197111
		[Token(Token = "0x40301F7")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private CharacterRepoGridGroup _charGroupView;

		// Token: 0x040301F8 RID: 197112
		[Token(Token = "0x40301F8")]
		[FieldOffset(Offset = "0x80")]
		private AnimationSwitchTween m_filterPanelSwitch;

		// Token: 0x040301F9 RID: 197113
		[Token(Token = "0x40301F9")]
		[FieldOffset(Offset = "0x88")]
		private string m_cachedPageName;

		// Token: 0x040301FA RID: 197114
		[Token(Token = "0x40301FA")]
		[FieldOffset(Offset = "0x90")]
		private AsyncGameObjectLoader m_cardLoader;

		// Token: 0x040301FB RID: 197115
		[Token(Token = "0x40301FB")]
		[FieldOffset(Offset = "0x98")]
		private StateCacheHandler<CharacterRepoHomeState.StateRuntime> m_runtimeHandler;

		// Token: 0x040301FC RID: 197116
		[Token(Token = "0x40301FC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x040301FD RID: 197117
		[Token(Token = "0x40301FD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateTime;

		// Token: 0x040301FE RID: 197118
		[Token(Token = "0x40301FE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitAnimation;

		// Token: 0x040301FF RID: 197119
		[Token(Token = "0x40301FF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnEnableStarMarkEditMode;

		// Token: 0x04030200 RID: 197120
		[Token(Token = "0x4030200")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnStarMarkEditConfirm;

		// Token: 0x04030201 RID: 197121
		[Token(Token = "0x4030201")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_SelectStarMark;

		// Token: 0x04030202 RID: 197122
		[Token(Token = "0x4030202")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_eventOnFilterClick;

		// Token: 0x04030203 RID: 197123
		[Token(Token = "0x4030203")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_eventOnFilterShow;

		// Token: 0x04030204 RID: 197124
		[Token(Token = "0x4030204")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_eventOnSortClick;

		// Token: 0x04030205 RID: 197125
		[Token(Token = "0x4030205")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OnSendStarMarkEditRequest;

		// Token: 0x04030206 RID: 197126
		[Token(Token = "0x4030206")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnFilterPanelSwitch;

		// Token: 0x04030207 RID: 197127
		[Token(Token = "0x4030207")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__InitSortPanelSwitch;

		// Token: 0x04030208 RID: 197128
		[Token(Token = "0x4030208")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__TryUpdateFilterPanelShow;

		// Token: 0x04030209 RID: 197129
		[Token(Token = "0x4030209")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__CreateRoutedAVGSignal;

		// Token: 0x0403020A RID: 197130
		[Token(Token = "0x403020A")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__CreateCardLoader;

		// Token: 0x0403020B RID: 197131
		[Token(Token = "0x403020B")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005E2D RID: 24109
		[Token(Token = "0x2005E2D")]
		public class StateRuntime
		{
			// Token: 0x06022F01 RID: 143105 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022F01")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public StateRuntime()
			{
			}

			// Token: 0x0403020C RID: 197132
			[Token(Token = "0x403020C")]
			[FieldOffset(Offset = "0x10")]
			public float scrollPosition;

			// Token: 0x0403020D RID: 197133
			[Token(Token = "0x403020D")]
			[FieldOffset(Offset = "0x18")]
			public CharacterFilterViewModel filter;

			// Token: 0x0403020E RID: 197134
			[Token(Token = "0x403020E")]
			[FieldOffset(Offset = "0x20")]
			public CharacterSortType sortType;
		}
	}
}
