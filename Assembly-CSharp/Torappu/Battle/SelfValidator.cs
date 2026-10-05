using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200258C RID: 9612
	[Token(Token = "0x200258C")]
	public class SelfValidator : TargetValidator
	{
		// Token: 0x0600F7D8 RID: 63448 RVA: 0x0005CC40 File Offset: 0x0005AE40
		[Token(Token = "0x600F7D8")]
		[Address(RVA = "0x714B20", Offset = "0x713720", VA = "0x180714B20", Slot = "5")]
		public override bool Validate(Entity target)
		{
			return default(bool);
		}

		// Token: 0x0600F7D9 RID: 63449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F7D9")]
		[Address(RVA = "0x714BC0", Offset = "0x7137C0", VA = "0x180714BC0")]
		public SelfValidator()
		{
		}

		// Token: 0x0600F7DA RID: 63450 RVA: 0x0005CC58 File Offset: 0x0005AE58
		[Token(Token = "0x600F7DA")]
		[Address(RVA = "0x6EEA80", Offset = "0x6ED680", VA = "0x1806EEA80")]
		private bool <>xLuaBaseProxy_Validate(Entity P0)
		{
			return default(bool);
		}

		// Token: 0x0401136F RID: 70511
		[Token(Token = "0x401136F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Validate;

		// Token: 0x04011370 RID: 70512
		[Token(Token = "0x4011370")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
