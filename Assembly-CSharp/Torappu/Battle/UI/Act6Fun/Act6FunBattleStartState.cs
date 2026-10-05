using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Battle.UI.Act6Fun
{
	// Token: 0x0200342B RID: 13355
	[Token(Token = "0x200342B")]
	public class Act6FunBattleStartState : UIStateNode
	{
		// Token: 0x17003290 RID: 12944
		// (get) Token: 0x0601560B RID: 87563 RVA: 0x0008B8F0 File Offset: 0x00089AF0
		[Token(Token = "0x17003290")]
		public override UIStateEnum uiState
		{
			[Token(Token = "0x601560B")]
			[Address(RVA = "0xDC54B0", Offset = "0xDC40B0", VA = "0x180DC54B0", Slot = "23")]
			get
			{
				return UIStateEnum.DEFAULT;
			}
		}

		// Token: 0x17003291 RID: 12945
		// (get) Token: 0x0601560C RID: 87564 RVA: 0x0008B908 File Offset: 0x00089B08
		[Token(Token = "0x17003291")]
		public override bool enablePause
		{
			[Token(Token = "0x601560C")]
			[Address(RVA = "0xDC5390", Offset = "0xDC3F90", VA = "0x180DC5390", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003292 RID: 12946
		// (get) Token: 0x0601560D RID: 87565 RVA: 0x0008B920 File Offset: 0x00089B20
		[Token(Token = "0x17003292")]
		public override bool enableShowRange
		{
			[Token(Token = "0x601560D")]
			[Address(RVA = "0xDC53F0", Offset = "0xDC3FF0", VA = "0x180DC53F0", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003293 RID: 12947
		// (get) Token: 0x0601560E RID: 87566 RVA: 0x0008B938 File Offset: 0x00089B38
		[Token(Token = "0x17003293")]
		public override bool enableSpeedSwitch
		{
			[Token(Token = "0x601560E")]
			[Address(RVA = "0xDC5450", Offset = "0xDC4050", VA = "0x180DC5450", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003294 RID: 12948
		// (get) Token: 0x0601560F RID: 87567 RVA: 0x0008B950 File Offset: 0x00089B50
		[Token(Token = "0x17003294")]
		public override bool enableBackpress
		{
			[Token(Token = "0x601560F")]
			[Address(RVA = "0xDC5330", Offset = "0xDC3F30", VA = "0x180DC5330", Slot = "21")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06015610 RID: 87568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015610")]
		[Address(RVA = "0xDC4F90", Offset = "0xDC3B90", VA = "0x180DC4F90", Slot = "25")]
		public override void OnEnter(int lastState)
		{
		}

		// Token: 0x06015611 RID: 87569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015611")]
		[Address(RVA = "0xDC51F0", Offset = "0xDC3DF0", VA = "0x180DC51F0")]
		private void _OnAnimComplete()
		{
		}

		// Token: 0x06015612 RID: 87570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015612")]
		[Address(RVA = "0xDC5190", Offset = "0xDC3D90", VA = "0x180DC5190", Slot = "26")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x06015613 RID: 87571 RVA: 0x0008B968 File Offset: 0x00089B68
		[Token(Token = "0x6015613")]
		[Address(RVA = "0xDC4F00", Offset = "0xDC3B00", VA = "0x180DC4F00", Slot = "28")]
		public override bool CheckSwitchOut(int nextState)
		{
			return default(bool);
		}

		// Token: 0x06015614 RID: 87572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015614")]
		[Address(RVA = "0xDC52D0", Offset = "0xDC3ED0", VA = "0x180DC52D0")]
		public Act6FunBattleStartState()
		{
		}

		// Token: 0x06015615 RID: 87573 RVA: 0x0008B980 File Offset: 0x00089B80
		[Token(Token = "0x6015615")]
		[Address(RVA = "0x785E30", Offset = "0x784A30", VA = "0x180785E30")]
		private bool <>xLuaBaseProxy_get_enablePause()
		{
			return default(bool);
		}

		// Token: 0x06015616 RID: 87574 RVA: 0x0008B998 File Offset: 0x00089B98
		[Token(Token = "0x6015616")]
		[Address(RVA = "0x7E9420", Offset = "0x7E8020", VA = "0x1807E9420")]
		private bool <>xLuaBaseProxy_get_enableShowRange()
		{
			return default(bool);
		}

		// Token: 0x06015617 RID: 87575 RVA: 0x0008B9B0 File Offset: 0x00089BB0
		[Token(Token = "0x6015617")]
		[Address(RVA = "0x785E40", Offset = "0x784A40", VA = "0x180785E40")]
		private bool <>xLuaBaseProxy_get_enableSpeedSwitch()
		{
			return default(bool);
		}

		// Token: 0x06015618 RID: 87576 RVA: 0x0008B9C8 File Offset: 0x00089BC8
		[Token(Token = "0x6015618")]
		[Address(RVA = "0x785E20", Offset = "0x784A20", VA = "0x180785E20")]
		private bool <>xLuaBaseProxy_get_enableBackpress()
		{
			return default(bool);
		}

		// Token: 0x06015619 RID: 87577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015619")]
		[Address(RVA = "0x785DF0", Offset = "0x7849F0", VA = "0x180785DF0")]
		private void <>xLuaBaseProxy_OnEnter(int P0)
		{
		}

		// Token: 0x0601561A RID: 87578 RVA: 0x0008B9E0 File Offset: 0x00089BE0
		[Token(Token = "0x601561A")]
		[Address(RVA = "0x7E9410", Offset = "0x7E8010", VA = "0x1807E9410")]
		private bool <>xLuaBaseProxy_CheckSwitchOut(int P0)
		{
			return default(bool);
		}

		// Token: 0x0401993A RID: 104762
		[Token(Token = "0x401993A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AnimationWrapper _animWrapper;

		// Token: 0x0401993B RID: 104763
		[Token(Token = "0x401993B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _clipName;

		// Token: 0x0401993C RID: 104764
		[Token(Token = "0x401993C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_uiState;

		// Token: 0x0401993D RID: 104765
		[Token(Token = "0x401993D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_enablePause;

		// Token: 0x0401993E RID: 104766
		[Token(Token = "0x401993E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_enableShowRange;

		// Token: 0x0401993F RID: 104767
		[Token(Token = "0x401993F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_enableSpeedSwitch;

		// Token: 0x04019940 RID: 104768
		[Token(Token = "0x4019940")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_enableBackpress;

		// Token: 0x04019941 RID: 104769
		[Token(Token = "0x4019941")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04019942 RID: 104770
		[Token(Token = "0x4019942")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnAnimComplete;

		// Token: 0x04019943 RID: 104771
		[Token(Token = "0x4019943")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04019944 RID: 104772
		[Token(Token = "0x4019944")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_CheckSwitchOut;

		// Token: 0x04019945 RID: 104773
		[Token(Token = "0x4019945")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
