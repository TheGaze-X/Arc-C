using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002584 RID: 9604
	[Token(Token = "0x2002584")]
	public class FilterTargetIsBornInStartTileValidator : TargetValidator
	{
		// Token: 0x0600F7BA RID: 63418 RVA: 0x0005CAD8 File Offset: 0x0005ACD8
		[Token(Token = "0x600F7BA")]
		[Address(RVA = "0x70C2B0", Offset = "0x70AEB0", VA = "0x18070C2B0", Slot = "5")]
		public override bool Validate(Entity target)
		{
			return default(bool);
		}

		// Token: 0x0600F7BB RID: 63419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F7BB")]
		[Address(RVA = "0x70C440", Offset = "0x70B040", VA = "0x18070C440")]
		public FilterTargetIsBornInStartTileValidator()
		{
		}

		// Token: 0x0600F7BC RID: 63420 RVA: 0x0005CAF0 File Offset: 0x0005ACF0
		[Token(Token = "0x600F7BC")]
		[Address(RVA = "0x6EEA80", Offset = "0x6ED680", VA = "0x1806EEA80")]
		private bool <>xLuaBaseProxy_Validate(Entity P0)
		{
			return default(bool);
		}

		// Token: 0x04011349 RID: 70473
		[Token(Token = "0x4011349")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Validate;

		// Token: 0x0401134A RID: 70474
		[Token(Token = "0x401134A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
