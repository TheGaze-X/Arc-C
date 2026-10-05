using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002592 RID: 9618
	[Token(Token = "0x2002592")]
	public class TokenOrHostTargetValidator : TargetValidator
	{
		// Token: 0x0600F7F3 RID: 63475 RVA: 0x0005CD90 File Offset: 0x0005AF90
		[Token(Token = "0x600F7F3")]
		[Address(RVA = "0x717CD0", Offset = "0x7168D0", VA = "0x180717CD0", Slot = "5")]
		public override bool Validate(Entity target)
		{
			return default(bool);
		}

		// Token: 0x0600F7F4 RID: 63476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F7F4")]
		[Address(RVA = "0x718090", Offset = "0x716C90", VA = "0x180718090")]
		public TokenOrHostTargetValidator()
		{
		}

		// Token: 0x0600F7F5 RID: 63477 RVA: 0x0005CDA8 File Offset: 0x0005AFA8
		[Token(Token = "0x600F7F5")]
		[Address(RVA = "0x6EEA80", Offset = "0x6ED680", VA = "0x1806EEA80")]
		private bool <>xLuaBaseProxy_Validate(Entity P0)
		{
			return default(bool);
		}

		// Token: 0x04011391 RID: 70545
		[Token(Token = "0x4011391")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private bool _isTargetEnemy;

		// Token: 0x04011392 RID: 70546
		[Token(Token = "0x4011392")]
		[FieldOffset(Offset = "0x91")]
		[SerializeField]
		private bool _isOwnerEnemy;

		// Token: 0x04011393 RID: 70547
		[Token(Token = "0x4011393")]
		[FieldOffset(Offset = "0x92")]
		[SerializeField]
		private bool _checkIsSameHost;

		// Token: 0x04011394 RID: 70548
		[Token(Token = "0x4011394")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Validate;

		// Token: 0x04011395 RID: 70549
		[Token(Token = "0x4011395")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
