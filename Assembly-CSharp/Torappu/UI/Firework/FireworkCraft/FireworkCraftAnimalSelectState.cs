using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Firework.FireworkCraft
{
	// Token: 0x02004E77 RID: 20087
	[Token(Token = "0x2004E77")]
	public class FireworkCraftAnimalSelectState : PopupFadeState, IValueMsgReceiver
	{
		// Token: 0x0601DFA7 RID: 122791 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601DFA7")]
		[Address(RVA = "0x179A3C0", Offset = "0x1798FC0", VA = "0x18179A3C0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601DFA8 RID: 122792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DFA8")]
		[Address(RVA = "0x179A420", Offset = "0x1799020", VA = "0x18179A420", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601DFA9 RID: 122793 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DFA9")]
		[Address(RVA = "0x179A6E0", Offset = "0x17992E0", VA = "0x18179A6E0", Slot = "17")]
		protected override void OnPause()
		{
		}

		// Token: 0x0601DFAA RID: 122794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DFAA")]
		[Address(RVA = "0x179A750", Offset = "0x1799350", VA = "0x18179A750", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0601DFAB RID: 122795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DFAB")]
		[Address(RVA = "0x179A970", Offset = "0x1799570", VA = "0x18179A970")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601DFAC RID: 122796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DFAC")]
		[Address(RVA = "0x179A5F0", Offset = "0x17991F0", VA = "0x18179A5F0", Slot = "31")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x0601DFAD RID: 122797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DFAD")]
		[Address(RVA = "0x179A8E0", Offset = "0x17994E0", VA = "0x18179A8E0")]
		private void _EventOnBackBtnClicked()
		{
		}

		// Token: 0x0601DFAE RID: 122798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DFAE")]
		[Address(RVA = "0x179ACD0", Offset = "0x17998D0", VA = "0x18179ACD0")]
		private void _OnAnimalClicked(string animalId)
		{
		}

		// Token: 0x0601DFAF RID: 122799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DFAF")]
		[Address(RVA = "0x179AEE0", Offset = "0x1799AE0", VA = "0x18179AEE0")]
		private void _OnEquipClicked()
		{
		}

		// Token: 0x0601DFB0 RID: 122800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DFB0")]
		[Address(RVA = "0x179AB40", Offset = "0x1799740", VA = "0x18179AB40")]
		private void _OnAnimalChangeProceed(FireworkChangeAnimalResponse response)
		{
		}

		// Token: 0x0601DFB1 RID: 122801 RVA: 0x000AD130 File Offset: 0x000AB330
		[Token(Token = "0x601DFB1")]
		[Address(RVA = "0x179AA80", Offset = "0x1799680", VA = "0x18179AA80")]
		private bool _IsUIStable()
		{
			return default(bool);
		}

		// Token: 0x0601DFB2 RID: 122802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DFB2")]
		[Address(RVA = "0x179B2E0", Offset = "0x1799EE0", VA = "0x18179B2E0")]
		private void _TriggerTutorialCoroutine()
		{
		}

		// Token: 0x0601DFB3 RID: 122803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DFB3")]
		[Address(RVA = "0x179B230", Offset = "0x1799E30", VA = "0x18179B230")]
		private void _StopTutorialCoroutine()
		{
		}

		// Token: 0x0601DFB4 RID: 122804 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601DFB4")]
		[Address(RVA = "0x179B410", Offset = "0x179A010", VA = "0x18179B410")]
		private IEnumerator _WaitAndTrigTutorial()
		{
			return null;
		}

		// Token: 0x0601DFB5 RID: 122805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DFB5")]
		[Address(RVA = "0x179B4C0", Offset = "0x179A0C0", VA = "0x18179B4C0")]
		public FireworkCraftAnimalSelectState()
		{
		}

		// Token: 0x0601DFB6 RID: 122806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DFB6")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0601DFB7 RID: 122807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DFB7")]
		[Address(RVA = "0xF807D0", Offset = "0xF7F3D0", VA = "0x180F807D0")]
		private void <>xLuaBaseProxy_OnPause()
		{
		}

		// Token: 0x0601DFB8 RID: 122808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DFB8")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x04027D11 RID: 163089
		[Token(Token = "0x4027D11")]
		[NonSerialized]
		public const int ON_ANIMAL_CLICKED = 0;

		// Token: 0x04027D12 RID: 163090
		[Token(Token = "0x4027D12")]
		[NonSerialized]
		public const int ON_EQUIP_BTN_CLICKED = 1;

		// Token: 0x04027D13 RID: 163091
		[Token(Token = "0x4027D13")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RectTransform _topMenuHolder;

		// Token: 0x04027D14 RID: 163092
		[Token(Token = "0x4027D14")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private FireworkCraftAnimalSelectView _view;

		// Token: 0x04027D15 RID: 163093
		[Token(Token = "0x4027D15")]
		[FieldOffset(Offset = "0x80")]
		private bool m_inited;

		// Token: 0x04027D16 RID: 163094
		[Token(Token = "0x4027D16")]
		[FieldOffset(Offset = "0x88")]
		private FireworkCraftAnimalSelectState.StateBean m_stateBean;

		// Token: 0x04027D17 RID: 163095
		[Token(Token = "0x4027D17")]
		[FieldOffset(Offset = "0x90")]
		private Coroutine m_tutorialCoroutine;

		// Token: 0x04027D18 RID: 163096
		[Token(Token = "0x4027D18")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04027D19 RID: 163097
		[Token(Token = "0x4027D19")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04027D1A RID: 163098
		[Token(Token = "0x4027D1A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnPause;

		// Token: 0x04027D1B RID: 163099
		[Token(Token = "0x4027D1B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x04027D1C RID: 163100
		[Token(Token = "0x4027D1C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04027D1D RID: 163101
		[Token(Token = "0x4027D1D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x04027D1E RID: 163102
		[Token(Token = "0x4027D1E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__EventOnBackBtnClicked;

		// Token: 0x04027D1F RID: 163103
		[Token(Token = "0x4027D1F")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnAnimalClicked;

		// Token: 0x04027D20 RID: 163104
		[Token(Token = "0x4027D20")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnEquipClicked;

		// Token: 0x04027D21 RID: 163105
		[Token(Token = "0x4027D21")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OnAnimalChangeProceed;

		// Token: 0x04027D22 RID: 163106
		[Token(Token = "0x4027D22")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__IsUIStable;

		// Token: 0x04027D23 RID: 163107
		[Token(Token = "0x4027D23")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__TriggerTutorialCoroutine;

		// Token: 0x04027D24 RID: 163108
		[Token(Token = "0x4027D24")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__StopTutorialCoroutine;

		// Token: 0x04027D25 RID: 163109
		[Token(Token = "0x4027D25")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__WaitAndTrigTutorial;

		// Token: 0x04027D26 RID: 163110
		[Token(Token = "0x4027D26")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004E78 RID: 20088
		[Token(Token = "0x2004E78")]
		public class StateBean : IStateBean, IHotfixable
		{
			// Token: 0x0601DFB9 RID: 122809 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601DFB9")]
			[Address(RVA = "0x17B09B0", Offset = "0x17AF5B0", VA = "0x1817B09B0")]
			public void SetSelectedAnimalId(string selectedAnimalId)
			{
			}

			// Token: 0x0601DFBA RID: 122810 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601DFBA")]
			[Address(RVA = "0x17B0A50", Offset = "0x17AF650", VA = "0x1817B0A50")]
			public StateBean()
			{
			}

			// Token: 0x04027D27 RID: 163111
			[Token(Token = "0x4027D27")]
			[FieldOffset(Offset = "0x10")]
			public FireworkCraftAnimalSelectProperty property;

			// Token: 0x04027D28 RID: 163112
			[Token(Token = "0x4027D28")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_SetSelectedAnimalId;

			// Token: 0x04027D29 RID: 163113
			[Token(Token = "0x4027D29")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
