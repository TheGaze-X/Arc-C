using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x02003337 RID: 13111
	[Token(Token = "0x2003337")]
	public class CommonCameraMoveState : UIStateNode
	{
		// Token: 0x1700319D RID: 12701
		// (get) Token: 0x06014E9B RID: 85659 RVA: 0x00089520 File Offset: 0x00087720
		[Token(Token = "0x1700319D")]
		public override UIStateEnum uiState
		{
			[Token(Token = "0x6014E9B")]
			[Address(RVA = "0xD56E30", Offset = "0xD55A30", VA = "0x180D56E30", Slot = "23")]
			get
			{
				return UIStateEnum.DEFAULT;
			}
		}

		// Token: 0x1700319E RID: 12702
		// (get) Token: 0x06014E9C RID: 85660 RVA: 0x00089538 File Offset: 0x00087738
		[Token(Token = "0x1700319E")]
		public override bool enablePause
		{
			[Token(Token = "0x6014E9C")]
			[Address(RVA = "0xD56CB0", Offset = "0xD558B0", VA = "0x180D56CB0", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700319F RID: 12703
		// (get) Token: 0x06014E9D RID: 85661 RVA: 0x00089550 File Offset: 0x00087750
		[Token(Token = "0x1700319F")]
		public override bool enableShowRange
		{
			[Token(Token = "0x6014E9D")]
			[Address(RVA = "0xD56D70", Offset = "0xD55970", VA = "0x180D56D70", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170031A0 RID: 12704
		// (get) Token: 0x06014E9E RID: 85662 RVA: 0x00089568 File Offset: 0x00087768
		[Token(Token = "0x170031A0")]
		public override bool enableSpeedSwitch
		{
			[Token(Token = "0x6014E9E")]
			[Address(RVA = "0xD56DD0", Offset = "0xD559D0", VA = "0x180D56DD0", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170031A1 RID: 12705
		// (get) Token: 0x06014E9F RID: 85663 RVA: 0x00089580 File Offset: 0x00087780
		[Token(Token = "0x170031A1")]
		public override bool enablePerspectiveCanvas
		{
			[Token(Token = "0x6014E9F")]
			[Address(RVA = "0xD56D10", Offset = "0xD55910", VA = "0x180D56D10", Slot = "20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06014EA0 RID: 85664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014EA0")]
		[Address(RVA = "0xD56A30", Offset = "0xD55630", VA = "0x180D56A30", Slot = "26")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x06014EA1 RID: 85665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014EA1")]
		[Address(RVA = "0xD568A0", Offset = "0xD554A0", VA = "0x180D568A0", Slot = "25")]
		public override void OnEnter(int lastState)
		{
		}

		// Token: 0x06014EA2 RID: 85666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014EA2")]
		[Address(RVA = "0xD56980", Offset = "0xD55580", VA = "0x180D56980", Slot = "27")]
		public override void OnExit(int nextState)
		{
		}

		// Token: 0x06014EA3 RID: 85667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014EA3")]
		[Address(RVA = "0xD56C10", Offset = "0xD55810", VA = "0x180D56C10")]
		public CommonCameraMoveState()
		{
		}

		// Token: 0x06014EA4 RID: 85668 RVA: 0x00089598 File Offset: 0x00087798
		[Token(Token = "0x6014EA4")]
		[Address(RVA = "0xD56A90", Offset = "0xD55690", VA = "0x180D56A90")]
		private bool <>xLuaBaseProxy_get_enablePause()
		{
			return default(bool);
		}

		// Token: 0x06014EA5 RID: 85669 RVA: 0x000895B0 File Offset: 0x000877B0
		[Token(Token = "0x6014EA5")]
		[Address(RVA = "0xD56B50", Offset = "0xD55750", VA = "0x180D56B50")]
		private bool <>xLuaBaseProxy_get_enableShowRange()
		{
			return default(bool);
		}

		// Token: 0x06014EA6 RID: 85670 RVA: 0x000895C8 File Offset: 0x000877C8
		[Token(Token = "0x6014EA6")]
		[Address(RVA = "0xD56BB0", Offset = "0xD557B0", VA = "0x180D56BB0")]
		private bool <>xLuaBaseProxy_get_enableSpeedSwitch()
		{
			return default(bool);
		}

		// Token: 0x06014EA7 RID: 85671 RVA: 0x000895E0 File Offset: 0x000877E0
		[Token(Token = "0x6014EA7")]
		[Address(RVA = "0xD56AF0", Offset = "0xD556F0", VA = "0x180D56AF0")]
		private bool <>xLuaBaseProxy_get_enablePerspectiveCanvas()
		{
			return default(bool);
		}

		// Token: 0x06014EA8 RID: 85672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014EA8")]
		[Address(RVA = "0x785DF0", Offset = "0x7849F0", VA = "0x180785DF0")]
		private void <>xLuaBaseProxy_OnEnter(int P0)
		{
		}

		// Token: 0x06014EA9 RID: 85673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014EA9")]
		[Address(RVA = "0x785E00", Offset = "0x784A00", VA = "0x180785E00")]
		private void <>xLuaBaseProxy_OnExit(int P0)
		{
		}

		// Token: 0x04018DFA RID: 101882
		[Token(Token = "0x4018DFA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_uiState;

		// Token: 0x04018DFB RID: 101883
		[Token(Token = "0x4018DFB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_enablePause;

		// Token: 0x04018DFC RID: 101884
		[Token(Token = "0x4018DFC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_enableShowRange;

		// Token: 0x04018DFD RID: 101885
		[Token(Token = "0x4018DFD")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_enableSpeedSwitch;

		// Token: 0x04018DFE RID: 101886
		[Token(Token = "0x4018DFE")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_enablePerspectiveCanvas;

		// Token: 0x04018DFF RID: 101887
		[Token(Token = "0x4018DFF")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04018E00 RID: 101888
		[Token(Token = "0x4018E00")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04018E01 RID: 101889
		[Token(Token = "0x4018E01")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x04018E02 RID: 101890
		[Token(Token = "0x4018E02")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
