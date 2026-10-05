using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x02003319 RID: 13081
	[Token(Token = "0x2003319")]
	public class UIBattleClearState : UIStateNode
	{
		// Token: 0x17003136 RID: 12598
		// (get) Token: 0x06014C91 RID: 85137 RVA: 0x00088620 File Offset: 0x00086820
		[Token(Token = "0x17003136")]
		public override UIStateEnum uiState
		{
			[Token(Token = "0x6014C91")]
			[Address(RVA = "0xD38990", Offset = "0xD37590", VA = "0x180D38990", Slot = "23")]
			get
			{
				return UIStateEnum.DEFAULT;
			}
		}

		// Token: 0x17003137 RID: 12599
		// (get) Token: 0x06014C92 RID: 85138 RVA: 0x00088638 File Offset: 0x00086838
		[Token(Token = "0x17003137")]
		public override bool enablePause
		{
			[Token(Token = "0x6014C92")]
			[Address(RVA = "0xD38870", Offset = "0xD37470", VA = "0x180D38870", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003138 RID: 12600
		// (get) Token: 0x06014C93 RID: 85139 RVA: 0x00088650 File Offset: 0x00086850
		[Token(Token = "0x17003138")]
		public override bool enableShowRange
		{
			[Token(Token = "0x6014C93")]
			[Address(RVA = "0xD388D0", Offset = "0xD374D0", VA = "0x180D388D0", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003139 RID: 12601
		// (get) Token: 0x06014C94 RID: 85140 RVA: 0x00088668 File Offset: 0x00086868
		[Token(Token = "0x17003139")]
		public override bool enableSpeedSwitch
		{
			[Token(Token = "0x6014C94")]
			[Address(RVA = "0xD38930", Offset = "0xD37530", VA = "0x180D38930", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06014C95 RID: 85141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014C95")]
		[Address(RVA = "0xD37D80", Offset = "0xD36980", VA = "0x180D37D80")]
		public void OnRestart()
		{
		}

		// Token: 0x06014C96 RID: 85142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014C96")]
		[Address(RVA = "0xD37CC0", Offset = "0xD368C0", VA = "0x180D37CC0", Slot = "24")]
		public override void OnInit(UIStateEnum state, UIStateMachine stateMachine)
		{
		}

		// Token: 0x06014C97 RID: 85143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014C97")]
		[Address(RVA = "0xD37A70", Offset = "0xD36670", VA = "0x180D37A70", Slot = "25")]
		public override void OnEnter(int lastState)
		{
		}

		// Token: 0x06014C98 RID: 85144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014C98")]
		[Address(RVA = "0xD37E00", Offset = "0xD36A00", VA = "0x180D37E00", Slot = "26")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x06014C99 RID: 85145 RVA: 0x00088680 File Offset: 0x00086880
		[Token(Token = "0x6014C99")]
		[Address(RVA = "0xD37A00", Offset = "0xD36600", VA = "0x180D37A00", Slot = "28")]
		public override bool CheckSwitchOut(int nextState)
		{
			return default(bool);
		}

		// Token: 0x06014C9A RID: 85146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014C9A")]
		[Address(RVA = "0xD37E60", Offset = "0xD36A60", VA = "0x180D37E60")]
		private void _ClearImpl()
		{
		}

		// Token: 0x06014C9B RID: 85147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014C9B")]
		[Address(RVA = "0xD38050", Offset = "0xD36C50", VA = "0x180D38050")]
		private void _JumpToBattleFinish(BattleClearStateParam clearParam)
		{
		}

		// Token: 0x06014C9C RID: 85148 RVA: 0x00088698 File Offset: 0x00086898
		[Token(Token = "0x6014C9C")]
		[Address(RVA = "0xD385C0", Offset = "0xD371C0", VA = "0x180D385C0")]
		private static bool _UseLiteBattleFinish()
		{
			return default(bool);
		}

		// Token: 0x06014C9D RID: 85149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014C9D")]
		[Address(RVA = "0xD38810", Offset = "0xD37410", VA = "0x180D38810")]
		public UIBattleClearState()
		{
		}

		// Token: 0x06014C9E RID: 85150 RVA: 0x000886B0 File Offset: 0x000868B0
		[Token(Token = "0x6014C9E")]
		[Address(RVA = "0x785E30", Offset = "0x784A30", VA = "0x180785E30")]
		private bool <>xLuaBaseProxy_get_enablePause()
		{
			return default(bool);
		}

		// Token: 0x06014C9F RID: 85151 RVA: 0x000886C8 File Offset: 0x000868C8
		[Token(Token = "0x6014C9F")]
		[Address(RVA = "0x7E9420", Offset = "0x7E8020", VA = "0x1807E9420")]
		private bool <>xLuaBaseProxy_get_enableShowRange()
		{
			return default(bool);
		}

		// Token: 0x06014CA0 RID: 85152 RVA: 0x000886E0 File Offset: 0x000868E0
		[Token(Token = "0x6014CA0")]
		[Address(RVA = "0x785E40", Offset = "0x784A40", VA = "0x180785E40")]
		private bool <>xLuaBaseProxy_get_enableSpeedSwitch()
		{
			return default(bool);
		}

		// Token: 0x06014CA1 RID: 85153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014CA1")]
		[Address(RVA = "0x785E10", Offset = "0x784A10", VA = "0x180785E10")]
		private void <>xLuaBaseProxy_OnInit(UIStateEnum P0, UIStateMachine P1)
		{
		}

		// Token: 0x06014CA2 RID: 85154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014CA2")]
		[Address(RVA = "0x785DF0", Offset = "0x7849F0", VA = "0x180785DF0")]
		private void <>xLuaBaseProxy_OnEnter(int P0)
		{
		}

		// Token: 0x06014CA3 RID: 85155 RVA: 0x000886F8 File Offset: 0x000868F8
		[Token(Token = "0x6014CA3")]
		[Address(RVA = "0x7E9410", Offset = "0x7E8010", VA = "0x1807E9410")]
		private bool <>xLuaBaseProxy_CheckSwitchOut(int P0)
		{
			return default(bool);
		}

		// Token: 0x04018BAD RID: 101293
		[Token(Token = "0x4018BAD")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _battleClearPanel;

		// Token: 0x04018BAE RID: 101294
		[Token(Token = "0x4018BAE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_uiState;

		// Token: 0x04018BAF RID: 101295
		[Token(Token = "0x4018BAF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_enablePause;

		// Token: 0x04018BB0 RID: 101296
		[Token(Token = "0x4018BB0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_enableShowRange;

		// Token: 0x04018BB1 RID: 101297
		[Token(Token = "0x4018BB1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_enableSpeedSwitch;

		// Token: 0x04018BB2 RID: 101298
		[Token(Token = "0x4018BB2")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnRestart;

		// Token: 0x04018BB3 RID: 101299
		[Token(Token = "0x4018BB3")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04018BB4 RID: 101300
		[Token(Token = "0x4018BB4")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04018BB5 RID: 101301
		[Token(Token = "0x4018BB5")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04018BB6 RID: 101302
		[Token(Token = "0x4018BB6")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_CheckSwitchOut;

		// Token: 0x04018BB7 RID: 101303
		[Token(Token = "0x4018BB7")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__ClearImpl;

		// Token: 0x04018BB8 RID: 101304
		[Token(Token = "0x4018BB8")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__JumpToBattleFinish;

		// Token: 0x04018BB9 RID: 101305
		[Token(Token = "0x4018BB9")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__UseLiteBattleFinish;

		// Token: 0x04018BBA RID: 101306
		[Token(Token = "0x4018BBA")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
