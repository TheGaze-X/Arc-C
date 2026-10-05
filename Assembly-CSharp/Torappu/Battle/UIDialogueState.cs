using System;
using Il2CppDummyDll;
using Torappu.Battle.Dialog;
using Torappu.Battle.UI;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002650 RID: 9808
	[Token(Token = "0x2002650")]
	public class UIDialogueState : UIStateNode
	{
		// Token: 0x170022FE RID: 8958
		// (get) Token: 0x0601006C RID: 65644 RVA: 0x00061920 File Offset: 0x0005FB20
		[Token(Token = "0x170022FE")]
		public override bool enablePause
		{
			[Token(Token = "0x601006C")]
			[Address(RVA = "0x785F10", Offset = "0x784B10", VA = "0x180785F10", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170022FF RID: 8959
		// (get) Token: 0x0601006D RID: 65645 RVA: 0x00061938 File Offset: 0x0005FB38
		[Token(Token = "0x170022FF")]
		public override bool enableSpeedSwitch
		{
			[Token(Token = "0x601006D")]
			[Address(RVA = "0x785F70", Offset = "0x784B70", VA = "0x180785F70", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002300 RID: 8960
		// (get) Token: 0x0601006E RID: 65646 RVA: 0x00061950 File Offset: 0x0005FB50
		[Token(Token = "0x17002300")]
		public override bool enableBackpress
		{
			[Token(Token = "0x601006E")]
			[Address(RVA = "0x785EB0", Offset = "0x784AB0", VA = "0x180785EB0", Slot = "21")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002301 RID: 8961
		// (get) Token: 0x0601006F RID: 65647 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002301")]
		public DialogPanel panel
		{
			[Token(Token = "0x601006F")]
			[Address(RVA = "0x785FD0", Offset = "0x784BD0", VA = "0x180785FD0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17002302 RID: 8962
		// (get) Token: 0x06010070 RID: 65648 RVA: 0x00061968 File Offset: 0x0005FB68
		[Token(Token = "0x17002302")]
		public override UIStateEnum uiState
		{
			[Token(Token = "0x6010070")]
			[Address(RVA = "0x786030", Offset = "0x784C30", VA = "0x180786030", Slot = "23")]
			get
			{
				return UIStateEnum.DEFAULT;
			}
		}

		// Token: 0x06010071 RID: 65649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010071")]
		[Address(RVA = "0x7859A0", Offset = "0x7845A0", VA = "0x1807859A0", Slot = "24")]
		public override void OnInit(UIStateEnum state, UIStateMachine stateMachine)
		{
		}

		// Token: 0x06010072 RID: 65650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010072")]
		[Address(RVA = "0x7854F0", Offset = "0x7840F0", VA = "0x1807854F0", Slot = "25")]
		public override void OnEnter(int lastState)
		{
		}

		// Token: 0x06010073 RID: 65651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010073")]
		[Address(RVA = "0x785D90", Offset = "0x784990", VA = "0x180785D90", Slot = "26")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x06010074 RID: 65652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010074")]
		[Address(RVA = "0x7857A0", Offset = "0x7843A0", VA = "0x1807857A0", Slot = "27")]
		public override void OnExit(int nextState)
		{
		}

		// Token: 0x06010075 RID: 65653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010075")]
		[Address(RVA = "0x785E50", Offset = "0x784A50", VA = "0x180785E50")]
		public UIDialogueState()
		{
		}

		// Token: 0x06010076 RID: 65654 RVA: 0x00061980 File Offset: 0x0005FB80
		[Token(Token = "0x6010076")]
		[Address(RVA = "0x785E30", Offset = "0x784A30", VA = "0x180785E30")]
		private bool <>xLuaBaseProxy_get_enablePause()
		{
			return default(bool);
		}

		// Token: 0x06010077 RID: 65655 RVA: 0x00061998 File Offset: 0x0005FB98
		[Token(Token = "0x6010077")]
		[Address(RVA = "0x785E40", Offset = "0x784A40", VA = "0x180785E40")]
		private bool <>xLuaBaseProxy_get_enableSpeedSwitch()
		{
			return default(bool);
		}

		// Token: 0x06010078 RID: 65656 RVA: 0x000619B0 File Offset: 0x0005FBB0
		[Token(Token = "0x6010078")]
		[Address(RVA = "0x785E20", Offset = "0x784A20", VA = "0x180785E20")]
		private bool <>xLuaBaseProxy_get_enableBackpress()
		{
			return default(bool);
		}

		// Token: 0x06010079 RID: 65657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010079")]
		[Address(RVA = "0x785E10", Offset = "0x784A10", VA = "0x180785E10")]
		private void <>xLuaBaseProxy_OnInit(UIStateEnum P0, UIStateMachine P1)
		{
		}

		// Token: 0x0601007A RID: 65658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601007A")]
		[Address(RVA = "0x785DF0", Offset = "0x7849F0", VA = "0x180785DF0")]
		private void <>xLuaBaseProxy_OnEnter(int P0)
		{
		}

		// Token: 0x0601007B RID: 65659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601007B")]
		[Address(RVA = "0x785E00", Offset = "0x784A00", VA = "0x180785E00")]
		private void <>xLuaBaseProxy_OnExit(int P0)
		{
		}

		// Token: 0x04011D37 RID: 73015
		[Token(Token = "0x4011D37")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _dialogueGroup;

		// Token: 0x04011D38 RID: 73016
		[Token(Token = "0x4011D38")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private DialogPanel _dialogPanel;

		// Token: 0x04011D39 RID: 73017
		[Token(Token = "0x4011D39")]
		[FieldOffset(Offset = "0x30")]
		private BattleDialogParam m_stateParam;

		// Token: 0x04011D3A RID: 73018
		[Token(Token = "0x4011D3A")]
		[FieldOffset(Offset = "0x34")]
		private SpeedLevel m_cachedSpeedLevel;

		// Token: 0x04011D3B RID: 73019
		[Token(Token = "0x4011D3B")]
		[FieldOffset(Offset = "0x38")]
		private int m_cachedMaxCostOffset;

		// Token: 0x04011D3C RID: 73020
		[Token(Token = "0x4011D3C")]
		[FieldOffset(Offset = "0x40")]
		private DialogPanel m_dialogPanel;

		// Token: 0x04011D3D RID: 73021
		[Token(Token = "0x4011D3D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_enablePause;

		// Token: 0x04011D3E RID: 73022
		[Token(Token = "0x4011D3E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_enableSpeedSwitch;

		// Token: 0x04011D3F RID: 73023
		[Token(Token = "0x4011D3F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_enableBackpress;

		// Token: 0x04011D40 RID: 73024
		[Token(Token = "0x4011D40")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_panel;

		// Token: 0x04011D41 RID: 73025
		[Token(Token = "0x4011D41")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_uiState;

		// Token: 0x04011D42 RID: 73026
		[Token(Token = "0x4011D42")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04011D43 RID: 73027
		[Token(Token = "0x4011D43")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04011D44 RID: 73028
		[Token(Token = "0x4011D44")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04011D45 RID: 73029
		[Token(Token = "0x4011D45")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x04011D46 RID: 73030
		[Token(Token = "0x4011D46")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
