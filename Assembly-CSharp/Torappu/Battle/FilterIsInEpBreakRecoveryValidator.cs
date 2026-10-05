using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002580 RID: 9600
	[Token(Token = "0x2002580")]
	public class FilterIsInEpBreakRecoveryValidator : TargetValidator
	{
		// Token: 0x0600F7AD RID: 63405 RVA: 0x0005CA00 File Offset: 0x0005AC00
		[Token(Token = "0x600F7AD")]
		[Address(RVA = "0x70BAA0", Offset = "0x70A6A0", VA = "0x18070BAA0", Slot = "5")]
		public override bool Validate(Entity target)
		{
			return default(bool);
		}

		// Token: 0x0600F7AE RID: 63406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F7AE")]
		[Address(RVA = "0x70BB60", Offset = "0x70A760", VA = "0x18070BB60")]
		public FilterIsInEpBreakRecoveryValidator()
		{
		}

		// Token: 0x0600F7AF RID: 63407 RVA: 0x0005CA18 File Offset: 0x0005AC18
		[Token(Token = "0x600F7AF")]
		[Address(RVA = "0x6EEA80", Offset = "0x6ED680", VA = "0x1806EEA80")]
		private bool <>xLuaBaseProxy_Validate(Entity P0)
		{
			return default(bool);
		}

		// Token: 0x04011339 RID: 70457
		[Token(Token = "0x4011339")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private bool _filterElementDamageType;

		// Token: 0x0401133A RID: 70458
		[Token(Token = "0x401133A")]
		[FieldOffset(Offset = "0x94")]
		[SerializeField]
		private ElementType _elementType;

		// Token: 0x0401133B RID: 70459
		[Token(Token = "0x401133B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Validate;

		// Token: 0x0401133C RID: 70460
		[Token(Token = "0x401133C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
