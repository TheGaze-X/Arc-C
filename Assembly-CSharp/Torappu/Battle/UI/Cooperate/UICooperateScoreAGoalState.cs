using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.UI.Cooperate
{
	// Token: 0x02003402 RID: 13314
	[Token(Token = "0x2003402")]
	public class UICooperateScoreAGoalState : CommonUIStateNode, IFixedUpdateState
	{
		// Token: 0x1700326D RID: 12909
		// (get) Token: 0x06015448 RID: 87112 RVA: 0x0008B008 File Offset: 0x00089208
		[Token(Token = "0x1700326D")]
		public override UIStateEnum uiState
		{
			[Token(Token = "0x6015448")]
			[Address(RVA = "0xDBBA80", Offset = "0xDBA680", VA = "0x180DBBA80", Slot = "23")]
			get
			{
				return UIStateEnum.DEFAULT;
			}
		}

		// Token: 0x1700326E RID: 12910
		// (get) Token: 0x06015449 RID: 87113 RVA: 0x0008B020 File Offset: 0x00089220
		[Token(Token = "0x1700326E")]
		public override bool enablePause
		{
			[Token(Token = "0x6015449")]
			[Address(RVA = "0xDBB900", Offset = "0xDBA500", VA = "0x180DBB900", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700326F RID: 12911
		// (get) Token: 0x0601544A RID: 87114 RVA: 0x0008B038 File Offset: 0x00089238
		[Token(Token = "0x1700326F")]
		public override bool enableShowRange
		{
			[Token(Token = "0x601544A")]
			[Address(RVA = "0xDBB9C0", Offset = "0xDBA5C0", VA = "0x180DBB9C0", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003270 RID: 12912
		// (get) Token: 0x0601544B RID: 87115 RVA: 0x0008B050 File Offset: 0x00089250
		[Token(Token = "0x17003270")]
		public override bool enableSpeedSwitch
		{
			[Token(Token = "0x601544B")]
			[Address(RVA = "0xDBBA20", Offset = "0xDBA620", VA = "0x180DBBA20", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003271 RID: 12913
		// (get) Token: 0x0601544C RID: 87116 RVA: 0x0008B068 File Offset: 0x00089268
		[Token(Token = "0x17003271")]
		public override bool enablePerspectiveCanvas
		{
			[Token(Token = "0x601544C")]
			[Address(RVA = "0xDBB960", Offset = "0xDBA560", VA = "0x180DBB960", Slot = "20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0601544D RID: 87117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601544D")]
		[Address(RVA = "0xDBB5B0", Offset = "0xDBA1B0", VA = "0x180DBB5B0", Slot = "24")]
		public override void OnInit(UIStateEnum state, UIStateMachine stateMachine)
		{
		}

		// Token: 0x0601544E RID: 87118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601544E")]
		[Address(RVA = "0xDBB240", Offset = "0xDB9E40", VA = "0x180DBB240", Slot = "25")]
		public override void OnEnter(int lastState)
		{
		}

		// Token: 0x0601544F RID: 87119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601544F")]
		[Address(RVA = "0xDBB7B0", Offset = "0xDBA3B0", VA = "0x180DBB7B0", Slot = "26")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x06015450 RID: 87120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015450")]
		[Address(RVA = "0xDBB810", Offset = "0xDBA410", VA = "0x180DBB810")]
		private void _HideAllPerform(object param)
		{
		}

		// Token: 0x06015451 RID: 87121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015451")]
		[Address(RVA = "0xDBB4C0", Offset = "0xDBA0C0", VA = "0x180DBB4C0", Slot = "30")]
		public void OnFixedUpdate(FP deltaTime)
		{
		}

		// Token: 0x06015452 RID: 87122 RVA: 0x0008B080 File Offset: 0x00089280
		[Token(Token = "0x6015452")]
		[Address(RVA = "0xDBB1B0", Offset = "0xDB9DB0", VA = "0x180DBB1B0", Slot = "28")]
		public override bool CheckSwitchOut(int nextState)
		{
			return default(bool);
		}

		// Token: 0x06015453 RID: 87123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015453")]
		[Address(RVA = "0xDBB8A0", Offset = "0xDBA4A0", VA = "0x180DBB8A0")]
		public UICooperateScoreAGoalState()
		{
		}

		// Token: 0x06015454 RID: 87124 RVA: 0x0008B098 File Offset: 0x00089298
		[Token(Token = "0x6015454")]
		[Address(RVA = "0x785E30", Offset = "0x784A30", VA = "0x180785E30")]
		private bool <>xLuaBaseProxy_get_enablePause()
		{
			return default(bool);
		}

		// Token: 0x06015455 RID: 87125 RVA: 0x0008B0B0 File Offset: 0x000892B0
		[Token(Token = "0x6015455")]
		[Address(RVA = "0x7E9420", Offset = "0x7E8020", VA = "0x1807E9420")]
		private bool <>xLuaBaseProxy_get_enableShowRange()
		{
			return default(bool);
		}

		// Token: 0x06015456 RID: 87126 RVA: 0x0008B0C8 File Offset: 0x000892C8
		[Token(Token = "0x6015456")]
		[Address(RVA = "0x785E40", Offset = "0x784A40", VA = "0x180785E40")]
		private bool <>xLuaBaseProxy_get_enableSpeedSwitch()
		{
			return default(bool);
		}

		// Token: 0x06015457 RID: 87127 RVA: 0x0008B0E0 File Offset: 0x000892E0
		[Token(Token = "0x6015457")]
		[Address(RVA = "0x962380", Offset = "0x960F80", VA = "0x180962380")]
		private bool <>xLuaBaseProxy_get_enablePerspectiveCanvas()
		{
			return default(bool);
		}

		// Token: 0x06015458 RID: 87128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015458")]
		[Address(RVA = "0x7EA8F0", Offset = "0x7E94F0", VA = "0x1807EA8F0")]
		private void <>xLuaBaseProxy_OnInit(UIStateEnum P0, UIStateMachine P1)
		{
		}

		// Token: 0x06015459 RID: 87129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015459")]
		[Address(RVA = "0x7EA8D0", Offset = "0x7E94D0", VA = "0x1807EA8D0")]
		private void <>xLuaBaseProxy_OnEnter(int P0)
		{
		}

		// Token: 0x0601545A RID: 87130 RVA: 0x0008B0F8 File Offset: 0x000892F8
		[Token(Token = "0x601545A")]
		[Address(RVA = "0x7E9410", Offset = "0x7E8010", VA = "0x1807E9410")]
		private bool <>xLuaBaseProxy_CheckSwitchOut(int P0)
		{
			return default(bool);
		}

		// Token: 0x04019694 RID: 104084
		[Token(Token = "0x4019694")]
		[FieldOffset(Offset = "0x50")]
		private Vector3 m_offset;

		// Token: 0x04019695 RID: 104085
		[Token(Token = "0x4019695")]
		[FieldOffset(Offset = "0x5C")]
		private Vector3 m_originLocalPosition;

		// Token: 0x04019696 RID: 104086
		[Token(Token = "0x4019696")]
		[FieldOffset(Offset = "0x68")]
		private UICooperateScoreAGoalPanel m_panel;

		// Token: 0x04019697 RID: 104087
		[Token(Token = "0x4019697")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_uiState;

		// Token: 0x04019698 RID: 104088
		[Token(Token = "0x4019698")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_enablePause;

		// Token: 0x04019699 RID: 104089
		[Token(Token = "0x4019699")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_enableShowRange;

		// Token: 0x0401969A RID: 104090
		[Token(Token = "0x401969A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_enableSpeedSwitch;

		// Token: 0x0401969B RID: 104091
		[Token(Token = "0x401969B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_enablePerspectiveCanvas;

		// Token: 0x0401969C RID: 104092
		[Token(Token = "0x401969C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0401969D RID: 104093
		[Token(Token = "0x401969D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0401969E RID: 104094
		[Token(Token = "0x401969E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x0401969F RID: 104095
		[Token(Token = "0x401969F")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__HideAllPerform;

		// Token: 0x040196A0 RID: 104096
		[Token(Token = "0x40196A0")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnFixedUpdate;

		// Token: 0x040196A1 RID: 104097
		[Token(Token = "0x40196A1")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_CheckSwitchOut;

		// Token: 0x040196A2 RID: 104098
		[Token(Token = "0x40196A2")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
