using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x020032D3 RID: 13011
	[Token(Token = "0x20032D3")]
	public abstract class CommonUIStateNode : UIStateNode
	{
		// Token: 0x170030FF RID: 12543
		// (get) Token: 0x06014AFC RID: 84732 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170030FF")]
		protected FadeSwitchTween fadeTween
		{
			[Token(Token = "0x6014AFC")]
			[Address(RVA = "0xD18E80", Offset = "0xD17A80", VA = "0x180D18E80")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003100 RID: 12544
		// (get) Token: 0x06014AFD RID: 84733 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003100")]
		protected GameObject statePanel
		{
			[Token(Token = "0x6014AFD")]
			[Address(RVA = "0xD19060", Offset = "0xD17C60", VA = "0x180D19060")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003101 RID: 12545
		// (get) Token: 0x06014AFE RID: 84734 RVA: 0x00087FA8 File Offset: 0x000861A8
		[Token(Token = "0x17003101")]
		public bool useBlur
		{
			[Token(Token = "0x6014AFE")]
			[Address(RVA = "0xD190C0", Offset = "0xD17CC0", VA = "0x180D190C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06014AFF RID: 84735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014AFF")]
		[Address(RVA = "0xD18AC0", Offset = "0xD176C0", VA = "0x180D18AC0", Slot = "24")]
		public override void OnInit(UIStateEnum state, UIStateMachine stateMachine)
		{
		}

		// Token: 0x06014B00 RID: 84736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014B00")]
		[Address(RVA = "0xD18990", Offset = "0xD17590", VA = "0x180D18990", Slot = "25")]
		public override void OnEnter(int lastState)
		{
		}

		// Token: 0x06014B01 RID: 84737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014B01")]
		[Address(RVA = "0xD18A30", Offset = "0xD17630", VA = "0x180D18A30", Slot = "27")]
		public override void OnExit(int nextState)
		{
		}

		// Token: 0x06014B02 RID: 84738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014B02")]
		[Address(RVA = "0xD18C80", Offset = "0xD17880", VA = "0x180D18C80", Slot = "29")]
		public virtual void OnPanelHiden()
		{
		}

		// Token: 0x06014B03 RID: 84739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014B03")]
		[Address(RVA = "0xD18D70", Offset = "0xD17970", VA = "0x180D18D70")]
		private void _InitCanvasGroup()
		{
		}

		// Token: 0x06014B04 RID: 84740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014B04")]
		[Address(RVA = "0xD18E20", Offset = "0xD17A20", VA = "0x180D18E20")]
		protected CommonUIStateNode()
		{
		}

		// Token: 0x06014B06 RID: 84742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014B06")]
		[Address(RVA = "0x785E10", Offset = "0x784A10", VA = "0x180785E10")]
		private void <>xLuaBaseProxy_OnInit(UIStateEnum P0, UIStateMachine P1)
		{
		}

		// Token: 0x06014B07 RID: 84743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014B07")]
		[Address(RVA = "0x785DF0", Offset = "0x7849F0", VA = "0x180785DF0")]
		private void <>xLuaBaseProxy_OnEnter(int P0)
		{
		}

		// Token: 0x06014B08 RID: 84744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014B08")]
		[Address(RVA = "0x785E00", Offset = "0x784A00", VA = "0x180785E00")]
		private void <>xLuaBaseProxy_OnExit(int P0)
		{
		}

		// Token: 0x040188BE RID: 100542
		[Token(Token = "0x40188BE")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _parent;

		// Token: 0x040188BF RID: 100543
		[Token(Token = "0x40188BF")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _statePanel;

		// Token: 0x040188C0 RID: 100544
		[Token(Token = "0x40188C0")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool _useBlur;

		// Token: 0x040188C1 RID: 100545
		[Token(Token = "0x40188C1")]
		[FieldOffset(Offset = "0x38")]
		private GameObject m_statePanel;

		// Token: 0x040188C2 RID: 100546
		[Token(Token = "0x40188C2")]
		[FieldOffset(Offset = "0x40")]
		private CanvasGroup m_canvasGroup;

		// Token: 0x040188C3 RID: 100547
		[Token(Token = "0x40188C3")]
		[FieldOffset(Offset = "0x48")]
		private FadeSwitchTween m_fadeTween;

		// Token: 0x040188C4 RID: 100548
		[Token(Token = "0x40188C4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_fadeTween;

		// Token: 0x040188C5 RID: 100549
		[Token(Token = "0x40188C5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_statePanel;

		// Token: 0x040188C6 RID: 100550
		[Token(Token = "0x40188C6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_useBlur;

		// Token: 0x040188C7 RID: 100551
		[Token(Token = "0x40188C7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x040188C8 RID: 100552
		[Token(Token = "0x40188C8")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x040188C9 RID: 100553
		[Token(Token = "0x40188C9")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x040188CA RID: 100554
		[Token(Token = "0x40188CA")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnPanelHiden;

		// Token: 0x040188CB RID: 100555
		[Token(Token = "0x40188CB")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__InitCanvasGroup;

		// Token: 0x040188CC RID: 100556
		[Token(Token = "0x40188CC")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
