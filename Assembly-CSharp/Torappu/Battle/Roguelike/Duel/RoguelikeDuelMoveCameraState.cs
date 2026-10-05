using System;
using Il2CppDummyDll;
using Torappu.Battle.UI;
using XLua;

namespace Torappu.Battle.Roguelike.Duel
{
	// Token: 0x02002932 RID: 10546
	[Token(Token = "0x2002932")]
	public class RoguelikeDuelMoveCameraState : UIStateNode
	{
		// Token: 0x170026AD RID: 9901
		// (get) Token: 0x060117DD RID: 71645 RVA: 0x0006B9E8 File Offset: 0x00069BE8
		[Token(Token = "0x170026AD")]
		public override UIStateEnum uiState
		{
			[Token(Token = "0x60117DD")]
			[Address(RVA = "0x962570", Offset = "0x961170", VA = "0x180962570", Slot = "23")]
			get
			{
				return UIStateEnum.DEFAULT;
			}
		}

		// Token: 0x170026AE RID: 9902
		// (get) Token: 0x060117DE RID: 71646 RVA: 0x0006BA00 File Offset: 0x00069C00
		[Token(Token = "0x170026AE")]
		public override bool enablePause
		{
			[Token(Token = "0x60117DE")]
			[Address(RVA = "0x9623F0", Offset = "0x960FF0", VA = "0x1809623F0", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170026AF RID: 9903
		// (get) Token: 0x060117DF RID: 71647 RVA: 0x0006BA18 File Offset: 0x00069C18
		[Token(Token = "0x170026AF")]
		public override bool enableShowRange
		{
			[Token(Token = "0x60117DF")]
			[Address(RVA = "0x9624B0", Offset = "0x9610B0", VA = "0x1809624B0", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170026B0 RID: 9904
		// (get) Token: 0x060117E0 RID: 71648 RVA: 0x0006BA30 File Offset: 0x00069C30
		[Token(Token = "0x170026B0")]
		public override bool enableSpeedSwitch
		{
			[Token(Token = "0x60117E0")]
			[Address(RVA = "0x962510", Offset = "0x961110", VA = "0x180962510", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170026B1 RID: 9905
		// (get) Token: 0x060117E1 RID: 71649 RVA: 0x0006BA48 File Offset: 0x00069C48
		[Token(Token = "0x170026B1")]
		public override bool enablePerspectiveCanvas
		{
			[Token(Token = "0x60117E1")]
			[Address(RVA = "0x962450", Offset = "0x961050", VA = "0x180962450", Slot = "20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060117E2 RID: 71650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60117E2")]
		[Address(RVA = "0x962320", Offset = "0x960F20", VA = "0x180962320", Slot = "26")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x060117E3 RID: 71651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60117E3")]
		[Address(RVA = "0x962140", Offset = "0x960D40", VA = "0x180962140", Slot = "25")]
		public override void OnEnter(int lastState)
		{
		}

		// Token: 0x060117E4 RID: 71652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60117E4")]
		[Address(RVA = "0x962270", Offset = "0x960E70", VA = "0x180962270", Slot = "27")]
		public override void OnExit(int nextState)
		{
		}

		// Token: 0x060117E5 RID: 71653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60117E5")]
		[Address(RVA = "0x962390", Offset = "0x960F90", VA = "0x180962390")]
		public RoguelikeDuelMoveCameraState()
		{
		}

		// Token: 0x060117E6 RID: 71654 RVA: 0x0006BA60 File Offset: 0x00069C60
		[Token(Token = "0x60117E6")]
		[Address(RVA = "0x785E30", Offset = "0x784A30", VA = "0x180785E30")]
		private bool <>xLuaBaseProxy_get_enablePause()
		{
			return default(bool);
		}

		// Token: 0x060117E7 RID: 71655 RVA: 0x0006BA78 File Offset: 0x00069C78
		[Token(Token = "0x60117E7")]
		[Address(RVA = "0x7E9420", Offset = "0x7E8020", VA = "0x1807E9420")]
		private bool <>xLuaBaseProxy_get_enableShowRange()
		{
			return default(bool);
		}

		// Token: 0x060117E8 RID: 71656 RVA: 0x0006BA90 File Offset: 0x00069C90
		[Token(Token = "0x60117E8")]
		[Address(RVA = "0x785E40", Offset = "0x784A40", VA = "0x180785E40")]
		private bool <>xLuaBaseProxy_get_enableSpeedSwitch()
		{
			return default(bool);
		}

		// Token: 0x060117E9 RID: 71657 RVA: 0x0006BAA8 File Offset: 0x00069CA8
		[Token(Token = "0x60117E9")]
		[Address(RVA = "0x962380", Offset = "0x960F80", VA = "0x180962380")]
		private bool <>xLuaBaseProxy_get_enablePerspectiveCanvas()
		{
			return default(bool);
		}

		// Token: 0x060117EA RID: 71658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60117EA")]
		[Address(RVA = "0x785DF0", Offset = "0x7849F0", VA = "0x180785DF0")]
		private void <>xLuaBaseProxy_OnEnter(int P0)
		{
		}

		// Token: 0x060117EB RID: 71659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60117EB")]
		[Address(RVA = "0x785E00", Offset = "0x784A00", VA = "0x180785E00")]
		private void <>xLuaBaseProxy_OnExit(int P0)
		{
		}

		// Token: 0x04013902 RID: 80130
		[Token(Token = "0x4013902")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_uiState;

		// Token: 0x04013903 RID: 80131
		[Token(Token = "0x4013903")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_enablePause;

		// Token: 0x04013904 RID: 80132
		[Token(Token = "0x4013904")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_enableShowRange;

		// Token: 0x04013905 RID: 80133
		[Token(Token = "0x4013905")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_enableSpeedSwitch;

		// Token: 0x04013906 RID: 80134
		[Token(Token = "0x4013906")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_enablePerspectiveCanvas;

		// Token: 0x04013907 RID: 80135
		[Token(Token = "0x4013907")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04013908 RID: 80136
		[Token(Token = "0x4013908")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04013909 RID: 80137
		[Token(Token = "0x4013909")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x0401390A RID: 80138
		[Token(Token = "0x401390A")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
