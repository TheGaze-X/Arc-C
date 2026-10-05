using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Battle.UI.Sandbox
{
	// Token: 0x020033B5 RID: 13237
	[Token(Token = "0x20033B5")]
	public class UIBattleSandboxBagState : UIBattleSandboxStateNode
	{
		// Token: 0x17003220 RID: 12832
		// (get) Token: 0x060151FA RID: 86522 RVA: 0x0008A720 File Offset: 0x00088920
		[Token(Token = "0x17003220")]
		public override bool enablePause
		{
			[Token(Token = "0x60151FA")]
			[Address(RVA = "0xD84A30", Offset = "0xD83630", VA = "0x180D84A30", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003221 RID: 12833
		// (get) Token: 0x060151FB RID: 86523 RVA: 0x0008A738 File Offset: 0x00088938
		[Token(Token = "0x17003221")]
		public override bool enableShowRange
		{
			[Token(Token = "0x60151FB")]
			[Address(RVA = "0xD84A90", Offset = "0xD83690", VA = "0x180D84A90", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003222 RID: 12834
		// (get) Token: 0x060151FC RID: 86524 RVA: 0x0008A750 File Offset: 0x00088950
		[Token(Token = "0x17003222")]
		public override bool enableSpeedSwitch
		{
			[Token(Token = "0x60151FC")]
			[Address(RVA = "0xD84AF0", Offset = "0xD836F0", VA = "0x180D84AF0", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003223 RID: 12835
		// (get) Token: 0x060151FD RID: 86525 RVA: 0x0008A768 File Offset: 0x00088968
		[Token(Token = "0x17003223")]
		public override UIStateEnum uiState
		{
			[Token(Token = "0x60151FD")]
			[Address(RVA = "0xD84D30", Offset = "0xD83930", VA = "0x180D84D30", Slot = "23")]
			get
			{
				return UIStateEnum.DEFAULT;
			}
		}

		// Token: 0x17003224 RID: 12836
		// (get) Token: 0x060151FE RID: 86526 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003224")]
		public UIBattleSandboxBagPanel bagPanel
		{
			[Token(Token = "0x60151FE")]
			[Address(RVA = "0xD849D0", Offset = "0xD835D0", VA = "0x180D849D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003225 RID: 12837
		// (get) Token: 0x060151FF RID: 86527 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003225")]
		protected FadeSwitchTween fadeTween
		{
			[Token(Token = "0x60151FF")]
			[Address(RVA = "0xD84B50", Offset = "0xD83750", VA = "0x180D84B50")]
			get
			{
				return null;
			}
		}

		// Token: 0x06015200 RID: 86528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015200")]
		[Address(RVA = "0xD84870", Offset = "0xD83470", VA = "0x180D84870")]
		private void _InitCanvasGroup()
		{
		}

		// Token: 0x06015201 RID: 86529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015201")]
		[Address(RVA = "0xD843A0", Offset = "0xD82FA0", VA = "0x180D843A0", Slot = "24")]
		public override void OnInit(UIStateEnum state, UIStateMachine stateMachine)
		{
		}

		// Token: 0x06015202 RID: 86530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015202")]
		[Address(RVA = "0xD84220", Offset = "0xD82E20", VA = "0x180D84220", Slot = "25")]
		public override void OnEnter(int lastState)
		{
		}

		// Token: 0x06015203 RID: 86531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015203")]
		[Address(RVA = "0xD84590", Offset = "0xD83190", VA = "0x180D84590")]
		public void ShowBag()
		{
		}

		// Token: 0x06015204 RID: 86532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015204")]
		[Address(RVA = "0xD842D0", Offset = "0xD82ED0", VA = "0x180D842D0", Slot = "27")]
		public override void OnExit(int nextState)
		{
		}

		// Token: 0x06015205 RID: 86533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015205")]
		[Address(RVA = "0xD840E0", Offset = "0xD82CE0", VA = "0x180D840E0")]
		public void CloseBagPanel()
		{
		}

		// Token: 0x06015206 RID: 86534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015206")]
		[Address(RVA = "0xD84930", Offset = "0xD83530", VA = "0x180D84930")]
		public UIBattleSandboxBagState()
		{
		}

		// Token: 0x06015208 RID: 86536 RVA: 0x0008A780 File Offset: 0x00088980
		[Token(Token = "0x6015208")]
		[Address(RVA = "0x785E30", Offset = "0x784A30", VA = "0x180785E30")]
		private bool <>xLuaBaseProxy_get_enablePause()
		{
			return default(bool);
		}

		// Token: 0x06015209 RID: 86537 RVA: 0x0008A798 File Offset: 0x00088998
		[Token(Token = "0x6015209")]
		[Address(RVA = "0x7E9420", Offset = "0x7E8020", VA = "0x1807E9420")]
		private bool <>xLuaBaseProxy_get_enableShowRange()
		{
			return default(bool);
		}

		// Token: 0x0601520A RID: 86538 RVA: 0x0008A7B0 File Offset: 0x000889B0
		[Token(Token = "0x601520A")]
		[Address(RVA = "0x785E40", Offset = "0x784A40", VA = "0x180785E40")]
		private bool <>xLuaBaseProxy_get_enableSpeedSwitch()
		{
			return default(bool);
		}

		// Token: 0x0601520B RID: 86539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601520B")]
		[Address(RVA = "0x785E10", Offset = "0x784A10", VA = "0x180785E10")]
		private void <>xLuaBaseProxy_OnInit(UIStateEnum P0, UIStateMachine P1)
		{
		}

		// Token: 0x0601520C RID: 86540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601520C")]
		[Address(RVA = "0x785DF0", Offset = "0x7849F0", VA = "0x180785DF0")]
		private void <>xLuaBaseProxy_OnEnter(int P0)
		{
		}

		// Token: 0x0601520D RID: 86541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601520D")]
		[Address(RVA = "0x785E00", Offset = "0x784A00", VA = "0x180785E00")]
		private void <>xLuaBaseProxy_OnExit(int P0)
		{
		}

		// Token: 0x040192DD RID: 103133
		[Token(Token = "0x40192DD")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIBattleSandboxBagPanel _bagPanelPrefab;

		// Token: 0x040192DE RID: 103134
		[Token(Token = "0x40192DE")]
		[FieldOffset(Offset = "0x38")]
		private FadeSwitchTween m_fadeTween;

		// Token: 0x040192DF RID: 103135
		[Token(Token = "0x40192DF")]
		[FieldOffset(Offset = "0x40")]
		private CanvasGroup m_canvasGroup;

		// Token: 0x040192E0 RID: 103136
		[Token(Token = "0x40192E0")]
		[FieldOffset(Offset = "0x48")]
		private UIBattleSandboxBagPanel m_bagPanel;

		// Token: 0x040192E1 RID: 103137
		[Token(Token = "0x40192E1")]
		[FieldOffset(Offset = "0x50")]
		private SandboxUIPlugin m_plugin;

		// Token: 0x040192E2 RID: 103138
		[Token(Token = "0x40192E2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_enablePause;

		// Token: 0x040192E3 RID: 103139
		[Token(Token = "0x40192E3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_enableShowRange;

		// Token: 0x040192E4 RID: 103140
		[Token(Token = "0x40192E4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_enableSpeedSwitch;

		// Token: 0x040192E5 RID: 103141
		[Token(Token = "0x40192E5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_uiState;

		// Token: 0x040192E6 RID: 103142
		[Token(Token = "0x40192E6")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_bagPanel;

		// Token: 0x040192E7 RID: 103143
		[Token(Token = "0x40192E7")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_fadeTween;

		// Token: 0x040192E8 RID: 103144
		[Token(Token = "0x40192E8")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__InitCanvasGroup;

		// Token: 0x040192E9 RID: 103145
		[Token(Token = "0x40192E9")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x040192EA RID: 103146
		[Token(Token = "0x40192EA")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x040192EB RID: 103147
		[Token(Token = "0x40192EB")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_ShowBag;

		// Token: 0x040192EC RID: 103148
		[Token(Token = "0x40192EC")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x040192ED RID: 103149
		[Token(Token = "0x40192ED")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_CloseBagPanel;

		// Token: 0x040192EE RID: 103150
		[Token(Token = "0x40192EE")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
