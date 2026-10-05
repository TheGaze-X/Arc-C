using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200257F RID: 9599
	[Token(Token = "0x200257F")]
	public class FilterGroupTagTargetValidator : TargetValidator
	{
		// Token: 0x0600F7AA RID: 63402 RVA: 0x0005C9D0 File Offset: 0x0005ABD0
		[Token(Token = "0x600F7AA")]
		[Address(RVA = "0x70B890", Offset = "0x70A490", VA = "0x18070B890", Slot = "5")]
		public override bool Validate(Entity target)
		{
			return default(bool);
		}

		// Token: 0x0600F7AB RID: 63403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F7AB")]
		[Address(RVA = "0x70BA00", Offset = "0x70A600", VA = "0x18070BA00")]
		public FilterGroupTagTargetValidator()
		{
		}

		// Token: 0x0600F7AC RID: 63404 RVA: 0x0005C9E8 File Offset: 0x0005ABE8
		[Token(Token = "0x600F7AC")]
		[Address(RVA = "0x6EEA80", Offset = "0x6ED680", VA = "0x1806EEA80")]
		private bool <>xLuaBaseProxy_Validate(Entity P0)
		{
			return default(bool);
		}

		// Token: 0x04011336 RID: 70454
		[Token(Token = "0x4011336")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private string[] _tags;

		// Token: 0x04011337 RID: 70455
		[Token(Token = "0x4011337")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Validate;

		// Token: 0x04011338 RID: 70456
		[Token(Token = "0x4011338")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
