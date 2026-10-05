using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Effects
{
	// Token: 0x02003252 RID: 12882
	[Token(Token = "0x2003252")]
	public class SetAnimatorParameters : Effect.Behaviour
	{
		// Token: 0x060146E3 RID: 83683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60146E3")]
		[Address(RVA = "0xCAD420", Offset = "0xCAC020", VA = "0x180CAD420", Slot = "4")]
		public override void Init(Effect eff)
		{
		}

		// Token: 0x060146E4 RID: 83684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60146E4")]
		[Address(RVA = "0xCAD4C0", Offset = "0xCAC0C0", VA = "0x180CAD4C0")]
		public void ToggleAnimatorSwitch(bool state)
		{
		}

		// Token: 0x060146E5 RID: 83685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60146E5")]
		[Address(RVA = "0xCAD590", Offset = "0xCAC190", VA = "0x180CAD590")]
		public SetAnimatorParameters()
		{
		}

		// Token: 0x060146E6 RID: 83686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60146E6")]
		[Address(RVA = "0xC9CCD0", Offset = "0xC9B8D0", VA = "0x180C9CCD0")]
		private void <>xLuaBaseProxy_Init(Effect P0)
		{
		}

		// Token: 0x0401821C RID: 98844
		[Token(Token = "0x401821C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _switchKey;

		// Token: 0x0401821D RID: 98845
		[Token(Token = "0x401821D")]
		[FieldOffset(Offset = "0x28")]
		private Animator m_animator;

		// Token: 0x0401821E RID: 98846
		[Token(Token = "0x401821E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0401821F RID: 98847
		[Token(Token = "0x401821F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ToggleAnimatorSwitch;

		// Token: 0x04018220 RID: 98848
		[Token(Token = "0x4018220")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
