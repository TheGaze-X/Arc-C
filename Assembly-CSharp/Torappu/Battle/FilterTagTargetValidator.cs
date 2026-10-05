using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002583 RID: 9603
	[Token(Token = "0x2002583")]
	public class FilterTagTargetValidator : TargetValidator
	{
		// Token: 0x0600F7B7 RID: 63415 RVA: 0x0005CAA8 File Offset: 0x0005ACA8
		[Token(Token = "0x600F7B7")]
		[Address(RVA = "0x70C0B0", Offset = "0x70ACB0", VA = "0x18070C0B0", Slot = "5")]
		public override bool Validate(Entity target)
		{
			return default(bool);
		}

		// Token: 0x0600F7B8 RID: 63416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F7B8")]
		[Address(RVA = "0x70C210", Offset = "0x70AE10", VA = "0x18070C210")]
		public FilterTagTargetValidator()
		{
		}

		// Token: 0x0600F7B9 RID: 63417 RVA: 0x0005CAC0 File Offset: 0x0005ACC0
		[Token(Token = "0x600F7B9")]
		[Address(RVA = "0x6EEA80", Offset = "0x6ED680", VA = "0x1806EEA80")]
		private bool <>xLuaBaseProxy_Validate(Entity P0)
		{
			return default(bool);
		}

		// Token: 0x04011345 RID: 70469
		[Token(Token = "0x4011345")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private bool _isUnset;

		// Token: 0x04011346 RID: 70470
		[Token(Token = "0x4011346")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private string[] _tags;

		// Token: 0x04011347 RID: 70471
		[Token(Token = "0x4011347")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Validate;

		// Token: 0x04011348 RID: 70472
		[Token(Token = "0x4011348")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
