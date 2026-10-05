using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200258E RID: 9614
	[Token(Token = "0x200258E")]
	public class TargetBlockModeValidator : TargetValidator
	{
		// Token: 0x0600F7E0 RID: 63456 RVA: 0x0005CCA0 File Offset: 0x0005AEA0
		[Token(Token = "0x600F7E0")]
		[Address(RVA = "0x7154B0", Offset = "0x7140B0", VA = "0x1807154B0", Slot = "5")]
		public override bool Validate(Entity target)
		{
			return default(bool);
		}

		// Token: 0x0600F7E1 RID: 63457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F7E1")]
		[Address(RVA = "0x7155F0", Offset = "0x7141F0", VA = "0x1807155F0")]
		public TargetBlockModeValidator()
		{
		}

		// Token: 0x0600F7E2 RID: 63458 RVA: 0x0005CCB8 File Offset: 0x0005AEB8
		[Token(Token = "0x600F7E2")]
		[Address(RVA = "0x6EEA80", Offset = "0x6ED680", VA = "0x1806EEA80")]
		private bool <>xLuaBaseProxy_Validate(Entity P0)
		{
			return default(bool);
		}

		// Token: 0x04011378 RID: 70520
		[Token(Token = "0x4011378")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private MotionMode _blockMode;

		// Token: 0x04011379 RID: 70521
		[Token(Token = "0x4011379")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Validate;

		// Token: 0x0401137A RID: 70522
		[Token(Token = "0x401137A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
