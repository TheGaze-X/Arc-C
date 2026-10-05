using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002582 RID: 9602
	[Token(Token = "0x2002582")]
	public class FilterSkillDurationTypeTargetValidator : TargetValidator
	{
		// Token: 0x0600F7B4 RID: 63412 RVA: 0x0005CA78 File Offset: 0x0005AC78
		[Token(Token = "0x600F7B4")]
		[Address(RVA = "0x70BE70", Offset = "0x70AA70", VA = "0x18070BE70", Slot = "5")]
		public override bool Validate(Entity target)
		{
			return default(bool);
		}

		// Token: 0x0600F7B5 RID: 63413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F7B5")]
		[Address(RVA = "0x70C010", Offset = "0x70AC10", VA = "0x18070C010")]
		public FilterSkillDurationTypeTargetValidator()
		{
		}

		// Token: 0x0600F7B6 RID: 63414 RVA: 0x0005CA90 File Offset: 0x0005AC90
		[Token(Token = "0x600F7B6")]
		[Address(RVA = "0x6EEA80", Offset = "0x6ED680", VA = "0x1806EEA80")]
		private bool <>xLuaBaseProxy_Validate(Entity P0)
		{
			return default(bool);
		}

		// Token: 0x04011342 RID: 70466
		[Token(Token = "0x4011342")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private SkillDurationType[] _checkTypes;

		// Token: 0x04011343 RID: 70467
		[Token(Token = "0x4011343")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Validate;

		// Token: 0x04011344 RID: 70468
		[Token(Token = "0x4011344")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
