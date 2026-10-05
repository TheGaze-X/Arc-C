using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002586 RID: 9606
	[Token(Token = "0x2002586")]
	public class InAttackRangeTargetValidator : TargetValidator
	{
		// Token: 0x0600F7C0 RID: 63424 RVA: 0x0005CB38 File Offset: 0x0005AD38
		[Token(Token = "0x600F7C0")]
		[Address(RVA = "0x70F0C0", Offset = "0x70DCC0", VA = "0x18070F0C0", Slot = "5")]
		public override bool Validate(Entity target)
		{
			return default(bool);
		}

		// Token: 0x0600F7C1 RID: 63425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F7C1")]
		[Address(RVA = "0x70F280", Offset = "0x70DE80", VA = "0x18070F280")]
		public InAttackRangeTargetValidator()
		{
		}

		// Token: 0x0600F7C2 RID: 63426 RVA: 0x0005CB50 File Offset: 0x0005AD50
		[Token(Token = "0x600F7C2")]
		[Address(RVA = "0x6EEA80", Offset = "0x6ED680", VA = "0x1806EEA80")]
		private bool <>xLuaBaseProxy_Validate(Entity P0)
		{
			return default(bool);
		}

		// Token: 0x0401134F RID: 70479
		[Token(Token = "0x401134F")]
		private const int DEFAULT_MODE_INDEX = 0;

		// Token: 0x04011350 RID: 70480
		[Token(Token = "0x4011350")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Validate;

		// Token: 0x04011351 RID: 70481
		[Token(Token = "0x4011351")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
