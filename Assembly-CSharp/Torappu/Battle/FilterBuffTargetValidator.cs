using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200257E RID: 9598
	[Token(Token = "0x200257E")]
	public class FilterBuffTargetValidator : TargetValidator
	{
		// Token: 0x0600F7A7 RID: 63399 RVA: 0x0005C9A0 File Offset: 0x0005ABA0
		[Token(Token = "0x600F7A7")]
		[Address(RVA = "0x70B640", Offset = "0x70A240", VA = "0x18070B640", Slot = "5")]
		public override bool Validate(Entity target)
		{
			return default(bool);
		}

		// Token: 0x0600F7A8 RID: 63400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F7A8")]
		[Address(RVA = "0x70B7F0", Offset = "0x70A3F0", VA = "0x18070B7F0")]
		public FilterBuffTargetValidator()
		{
		}

		// Token: 0x0600F7A9 RID: 63401 RVA: 0x0005C9B8 File Offset: 0x0005ABB8
		[Token(Token = "0x600F7A9")]
		[Address(RVA = "0x6EEA80", Offset = "0x6ED680", VA = "0x1806EEA80")]
		private bool <>xLuaBaseProxy_Validate(Entity P0)
		{
			return default(bool);
		}

		// Token: 0x04011330 RID: 70448
		[Token(Token = "0x4011330")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private bool _excludeKey;

		// Token: 0x04011331 RID: 70449
		[Token(Token = "0x4011331")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private string[] _buffs;

		// Token: 0x04011332 RID: 70450
		[Token(Token = "0x4011332")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private bool _filterBuffSource;

		// Token: 0x04011333 RID: 70451
		[Token(Token = "0x4011333")]
		[FieldOffset(Offset = "0xA1")]
		[SerializeField]
		private bool _hostAsTarget;

		// Token: 0x04011334 RID: 70452
		[Token(Token = "0x4011334")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Validate;

		// Token: 0x04011335 RID: 70453
		[Token(Token = "0x4011335")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
