using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x02005048 RID: 20552
	[Token(Token = "0x2005048")]
	public class EnemyDuelPrepareSelectModeState : UIPopupState, IValueMsgReceiver, IPopupCustomActive
	{
		// Token: 0x0601E780 RID: 124800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E780")]
		[Address(RVA = "0x182DA00", Offset = "0x182C600", VA = "0x18182DA00")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601E781 RID: 124801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E781")]
		[Address(RVA = "0x182C960", Offset = "0x182B560", VA = "0x18182C960", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601E782 RID: 124802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E782")]
		[Address(RVA = "0x182CF30", Offset = "0x182BB30", VA = "0x18182CF30", Slot = "17")]
		protected override void OnPause()
		{
		}

		// Token: 0x0601E783 RID: 124803 RVA: 0x000AE888 File Offset: 0x000ACA88
		[Token(Token = "0x601E783")]
		[Address(RVA = "0x182C2A0", Offset = "0x182AEA0", VA = "0x18182C2A0", Slot = "30")]
		public bool CustomSetActive(bool active)
		{
			return default(bool);
		}

		// Token: 0x0601E784 RID: 124804 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E784")]
		[Address(RVA = "0x182C6D0", Offset = "0x182B2D0", VA = "0x18182C6D0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601E785 RID: 124805 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E785")]
		[Address(RVA = "0x182CFA0", Offset = "0x182BBA0", VA = "0x18182CFA0", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0601E786 RID: 124806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E786")]
		[Address(RVA = "0x182DD50", Offset = "0x182C950", VA = "0x18182DD50")]
		private void _PassDataToRoomState(IStateBean iStatebean)
		{
		}

		// Token: 0x0601E787 RID: 124807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E787")]
		[Address(RVA = "0x182DB20", Offset = "0x182C720", VA = "0x18182DB20")]
		private void _PassDataToMatchState(IStateBean iStatebean)
		{
		}

		// Token: 0x0601E788 RID: 124808 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E788")]
		[Address(RVA = "0x182D170", Offset = "0x182BD70", VA = "0x18182D170", Slot = "23")]
		protected override IEnumerator ShowCoroutine(UIPopupState.TransactionContext context)
		{
			return null;
		}

		// Token: 0x0601E789 RID: 124809 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E789")]
		[Address(RVA = "0x182C730", Offset = "0x182B330", VA = "0x18182C730", Slot = "24")]
		protected override IEnumerator HideCoroutine(UIPopupState.TransactionContext context)
		{
			return null;
		}

		// Token: 0x0601E78A RID: 124810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E78A")]
		[Address(RVA = "0x182D2B0", Offset = "0x182BEB0", VA = "0x18182D2B0", Slot = "25")]
		protected override void ShowImmediately(UIPopupState.TransactionContext context)
		{
		}

		// Token: 0x0601E78B RID: 124811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E78B")]
		[Address(RVA = "0x182C870", Offset = "0x182B470", VA = "0x18182C870", Slot = "26")]
		protected override void HideImmediately(UIPopupState.TransactionContext context)
		{
		}

		// Token: 0x0601E78C RID: 124812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E78C")]
		[Address(RVA = "0x182CE50", Offset = "0x182BA50", VA = "0x18182CE50", Slot = "29")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x0601E78D RID: 124813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E78D")]
		[Address(RVA = "0x182D7A0", Offset = "0x182C3A0", VA = "0x18182D7A0")]
		private void _EventOnSelectMode(ValueBundle msg)
		{
		}

		// Token: 0x0601E78E RID: 124814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E78E")]
		[Address(RVA = "0x182D3A0", Offset = "0x182BFA0", VA = "0x18182D3A0")]
		private void _EventOnCreateRoom()
		{
		}

		// Token: 0x0601E78F RID: 124815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E78F")]
		[Address(RVA = "0x182E010", Offset = "0x182CC10", VA = "0x18182E010")]
		private void _StartSingleGame(string actId, ActivityEnemyDuelModeData modeData)
		{
		}

		// Token: 0x0601E790 RID: 124816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E790")]
		[Address(RVA = "0x182C320", Offset = "0x182AF20", VA = "0x18182C320")]
		public void EventOnExitClick()
		{
		}

		// Token: 0x0601E791 RID: 124817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E791")]
		[Address(RVA = "0x182C480", Offset = "0x182B080", VA = "0x18182C480")]
		public void EventOnMatchClick()
		{
		}

		// Token: 0x0601E792 RID: 124818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E792")]
		[Address(RVA = "0x182E2F0", Offset = "0x182CEF0", VA = "0x18182E2F0")]
		public EnemyDuelPrepareSelectModeState()
		{
		}

		// Token: 0x0601E793 RID: 124819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E793")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0601E794 RID: 124820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E794")]
		[Address(RVA = "0xF807D0", Offset = "0xF7F3D0", VA = "0x180F807D0")]
		private void <>xLuaBaseProxy_OnPause()
		{
		}

		// Token: 0x0601E795 RID: 124821 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E795")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x04028CE6 RID: 167142
		[Token(Token = "0x4028CE6")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private EnemyDuelPrepareSelectModeView _view;

		// Token: 0x04028CE7 RID: 167143
		[Token(Token = "0x4028CE7")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private RectTransform _backBtnRect;

		// Token: 0x04028CE8 RID: 167144
		[Token(Token = "0x4028CE8")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _backBtnObj;

		// Token: 0x04028CE9 RID: 167145
		[Token(Token = "0x4028CE9")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UIAnimationLocation _enterAnim;

		// Token: 0x04028CEA RID: 167146
		[Token(Token = "0x4028CEA")]
		[FieldOffset(Offset = "0x88")]
		private bool m_isInited;

		// Token: 0x04028CEB RID: 167147
		[Token(Token = "0x4028CEB")]
		[FieldOffset(Offset = "0x90")]
		private AnimationSwitchTween m_enterAnimSwitchTween;

		// Token: 0x04028CEC RID: 167148
		[Token(Token = "0x4028CEC")]
		[FieldOffset(Offset = "0x98")]
		private EnemyDuelPrepareSelectModeStateBean m_stateBean;

		// Token: 0x04028CED RID: 167149
		[Token(Token = "0x4028CED")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04028CEE RID: 167150
		[Token(Token = "0x4028CEE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04028CEF RID: 167151
		[Token(Token = "0x4028CEF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnPause;

		// Token: 0x04028CF0 RID: 167152
		[Token(Token = "0x4028CF0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_CustomSetActive;

		// Token: 0x04028CF1 RID: 167153
		[Token(Token = "0x4028CF1")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04028CF2 RID: 167154
		[Token(Token = "0x4028CF2")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x04028CF3 RID: 167155
		[Token(Token = "0x4028CF3")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__PassDataToRoomState;

		// Token: 0x04028CF4 RID: 167156
		[Token(Token = "0x4028CF4")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__PassDataToMatchState;

		// Token: 0x04028CF5 RID: 167157
		[Token(Token = "0x4028CF5")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_ShowCoroutine;

		// Token: 0x04028CF6 RID: 167158
		[Token(Token = "0x4028CF6")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_HideCoroutine;

		// Token: 0x04028CF7 RID: 167159
		[Token(Token = "0x4028CF7")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_ShowImmediately;

		// Token: 0x04028CF8 RID: 167160
		[Token(Token = "0x4028CF8")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_HideImmediately;

		// Token: 0x04028CF9 RID: 167161
		[Token(Token = "0x4028CF9")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x04028CFA RID: 167162
		[Token(Token = "0x4028CFA")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__EventOnSelectMode;

		// Token: 0x04028CFB RID: 167163
		[Token(Token = "0x4028CFB")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__EventOnCreateRoom;

		// Token: 0x04028CFC RID: 167164
		[Token(Token = "0x4028CFC")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__StartSingleGame;

		// Token: 0x04028CFD RID: 167165
		[Token(Token = "0x4028CFD")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_EventOnExitClick;

		// Token: 0x04028CFE RID: 167166
		[Token(Token = "0x4028CFE")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_EventOnMatchClick;

		// Token: 0x04028CFF RID: 167167
		[Token(Token = "0x4028CFF")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005049 RID: 20553
		[Token(Token = "0x2005049")]
		public static class Event
		{
			// Token: 0x04028D00 RID: 167168
			[Token(Token = "0x4028D00")]
			public const int SELECT_MODE = 1;

			// Token: 0x04028D01 RID: 167169
			[Token(Token = "0x4028D01")]
			public const int CREATE_ROOM = 2;
		}
	}
}
