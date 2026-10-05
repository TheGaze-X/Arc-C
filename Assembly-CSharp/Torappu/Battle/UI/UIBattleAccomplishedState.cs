using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x02003318 RID: 13080
	[Token(Token = "0x2003318")]
	public class UIBattleAccomplishedState : UIStateNode
	{
		// Token: 0x17003130 RID: 12592
		// (get) Token: 0x06014C79 RID: 85113 RVA: 0x000884E8 File Offset: 0x000866E8
		[Token(Token = "0x17003130")]
		public override UIStateEnum uiState
		{
			[Token(Token = "0x6014C79")]
			[Address(RVA = "0xD379A0", Offset = "0xD365A0", VA = "0x180D379A0", Slot = "23")]
			get
			{
				return UIStateEnum.DEFAULT;
			}
		}

		// Token: 0x17003131 RID: 12593
		// (get) Token: 0x06014C7A RID: 85114 RVA: 0x00088500 File Offset: 0x00086700
		[Token(Token = "0x17003131")]
		public override bool enablePause
		{
			[Token(Token = "0x6014C7A")]
			[Address(RVA = "0xD37820", Offset = "0xD36420", VA = "0x180D37820", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003132 RID: 12594
		// (get) Token: 0x06014C7B RID: 85115 RVA: 0x00088518 File Offset: 0x00086718
		[Token(Token = "0x17003132")]
		public override bool enableShowRange
		{
			[Token(Token = "0x6014C7B")]
			[Address(RVA = "0xD378E0", Offset = "0xD364E0", VA = "0x180D378E0", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003133 RID: 12595
		// (get) Token: 0x06014C7C RID: 85116 RVA: 0x00088530 File Offset: 0x00086730
		[Token(Token = "0x17003133")]
		public override bool enableSpeedSwitch
		{
			[Token(Token = "0x6014C7C")]
			[Address(RVA = "0xD37940", Offset = "0xD36540", VA = "0x180D37940", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003134 RID: 12596
		// (get) Token: 0x06014C7D RID: 85117 RVA: 0x00088548 File Offset: 0x00086748
		[Token(Token = "0x17003134")]
		public override bool enablePerspectiveCanvas
		{
			[Token(Token = "0x6014C7D")]
			[Address(RVA = "0xD37880", Offset = "0xD36480", VA = "0x180D37880", Slot = "20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003135 RID: 12597
		// (get) Token: 0x06014C7E RID: 85118 RVA: 0x00088560 File Offset: 0x00086760
		[Token(Token = "0x17003135")]
		public override bool enableBackpress
		{
			[Token(Token = "0x6014C7E")]
			[Address(RVA = "0xD377C0", Offset = "0xD363C0", VA = "0x180D377C0", Slot = "21")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06014C7F RID: 85119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014C7F")]
		[Address(RVA = "0xD37020", Offset = "0xD35C20", VA = "0x180D37020", Slot = "24")]
		public override void OnInit(UIStateEnum state, UIStateMachine stateMachine)
		{
		}

		// Token: 0x06014C80 RID: 85120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014C80")]
		[Address(RVA = "0xD36C40", Offset = "0xD35840", VA = "0x180D36C40", Slot = "25")]
		public override void OnEnter(int lastState)
		{
		}

		// Token: 0x06014C81 RID: 85121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014C81")]
		[Address(RVA = "0xD37470", Offset = "0xD36070", VA = "0x180D37470", Slot = "26")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x06014C82 RID: 85122 RVA: 0x00088578 File Offset: 0x00086778
		[Token(Token = "0x6014C82")]
		[Address(RVA = "0xD36BD0", Offset = "0xD357D0", VA = "0x180D36BD0", Slot = "28")]
		public override bool CheckSwitchOut(int nextState)
		{
			return default(bool);
		}

		// Token: 0x06014C83 RID: 85123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014C83")]
		[Address(RVA = "0xD374E0", Offset = "0xD360E0", VA = "0x180D374E0")]
		private void _ResetPerformPositionByCameraPos()
		{
		}

		// Token: 0x06014C84 RID: 85124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014C84")]
		[Address(RVA = "0xD376D0", Offset = "0xD362D0", VA = "0x180D376D0")]
		private void _SwitchToBattleFinishService()
		{
		}

		// Token: 0x06014C85 RID: 85125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014C85")]
		[Address(RVA = "0xD36FA0", Offset = "0xD35BA0", VA = "0x180D36FA0", Slot = "27")]
		public override void OnExit(int nextState)
		{
		}

		// Token: 0x06014C86 RID: 85126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014C86")]
		[Address(RVA = "0xD37760", Offset = "0xD36360", VA = "0x180D37760")]
		public UIBattleAccomplishedState()
		{
		}

		// Token: 0x06014C88 RID: 85128 RVA: 0x00088590 File Offset: 0x00086790
		[Token(Token = "0x6014C88")]
		[Address(RVA = "0x785E30", Offset = "0x784A30", VA = "0x180785E30")]
		private bool <>xLuaBaseProxy_get_enablePause()
		{
			return default(bool);
		}

		// Token: 0x06014C89 RID: 85129 RVA: 0x000885A8 File Offset: 0x000867A8
		[Token(Token = "0x6014C89")]
		[Address(RVA = "0x7E9420", Offset = "0x7E8020", VA = "0x1807E9420")]
		private bool <>xLuaBaseProxy_get_enableShowRange()
		{
			return default(bool);
		}

		// Token: 0x06014C8A RID: 85130 RVA: 0x000885C0 File Offset: 0x000867C0
		[Token(Token = "0x6014C8A")]
		[Address(RVA = "0x785E40", Offset = "0x784A40", VA = "0x180785E40")]
		private bool <>xLuaBaseProxy_get_enableSpeedSwitch()
		{
			return default(bool);
		}

		// Token: 0x06014C8B RID: 85131 RVA: 0x000885D8 File Offset: 0x000867D8
		[Token(Token = "0x6014C8B")]
		[Address(RVA = "0x962380", Offset = "0x960F80", VA = "0x180962380")]
		private bool <>xLuaBaseProxy_get_enablePerspectiveCanvas()
		{
			return default(bool);
		}

		// Token: 0x06014C8C RID: 85132 RVA: 0x000885F0 File Offset: 0x000867F0
		[Token(Token = "0x6014C8C")]
		[Address(RVA = "0x785E20", Offset = "0x784A20", VA = "0x180785E20")]
		private bool <>xLuaBaseProxy_get_enableBackpress()
		{
			return default(bool);
		}

		// Token: 0x06014C8D RID: 85133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014C8D")]
		[Address(RVA = "0x785E10", Offset = "0x784A10", VA = "0x180785E10")]
		private void <>xLuaBaseProxy_OnInit(UIStateEnum P0, UIStateMachine P1)
		{
		}

		// Token: 0x06014C8E RID: 85134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014C8E")]
		[Address(RVA = "0x785DF0", Offset = "0x7849F0", VA = "0x180785DF0")]
		private void <>xLuaBaseProxy_OnEnter(int P0)
		{
		}

		// Token: 0x06014C8F RID: 85135 RVA: 0x00088608 File Offset: 0x00086808
		[Token(Token = "0x6014C8F")]
		[Address(RVA = "0x7E9410", Offset = "0x7E8010", VA = "0x1807E9410")]
		private bool <>xLuaBaseProxy_CheckSwitchOut(int P0)
		{
			return default(bool);
		}

		// Token: 0x06014C90 RID: 85136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014C90")]
		[Address(RVA = "0x785E00", Offset = "0x784A00", VA = "0x180785E00")]
		private void <>xLuaBaseProxy_OnExit(int P0)
		{
		}

		// Token: 0x04018B9B RID: 101275
		[Token(Token = "0x4018B9B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAnimationPerform _perform;

		// Token: 0x04018B9C RID: 101276
		[Token(Token = "0x4018B9C")]
		[FieldOffset(Offset = "0x28")]
		private bool m_skipPerform;

		// Token: 0x04018B9D RID: 101277
		[Token(Token = "0x4018B9D")]
		[FieldOffset(Offset = "0x2C")]
		private Vector3 m_offset;

		// Token: 0x04018B9E RID: 101278
		[Token(Token = "0x4018B9E")]
		[FieldOffset(Offset = "0x38")]
		private UIAnimationPerform m_perform;

		// Token: 0x04018B9F RID: 101279
		[Token(Token = "0x4018B9F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_uiState;

		// Token: 0x04018BA0 RID: 101280
		[Token(Token = "0x4018BA0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_enablePause;

		// Token: 0x04018BA1 RID: 101281
		[Token(Token = "0x4018BA1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_enableShowRange;

		// Token: 0x04018BA2 RID: 101282
		[Token(Token = "0x4018BA2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_enableSpeedSwitch;

		// Token: 0x04018BA3 RID: 101283
		[Token(Token = "0x4018BA3")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_enablePerspectiveCanvas;

		// Token: 0x04018BA4 RID: 101284
		[Token(Token = "0x4018BA4")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_enableBackpress;

		// Token: 0x04018BA5 RID: 101285
		[Token(Token = "0x4018BA5")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04018BA6 RID: 101286
		[Token(Token = "0x4018BA6")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04018BA7 RID: 101287
		[Token(Token = "0x4018BA7")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04018BA8 RID: 101288
		[Token(Token = "0x4018BA8")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_CheckSwitchOut;

		// Token: 0x04018BA9 RID: 101289
		[Token(Token = "0x4018BA9")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__ResetPerformPositionByCameraPos;

		// Token: 0x04018BAA RID: 101290
		[Token(Token = "0x4018BAA")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__SwitchToBattleFinishService;

		// Token: 0x04018BAB RID: 101291
		[Token(Token = "0x4018BAB")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x04018BAC RID: 101292
		[Token(Token = "0x4018BAC")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
