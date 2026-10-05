using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200257D RID: 9597
	[Token(Token = "0x200257D")]
	public class FeverValidator : TargetValidator
	{
		// Token: 0x0600F7A4 RID: 63396 RVA: 0x0005C970 File Offset: 0x0005AB70
		[Token(Token = "0x600F7A4")]
		[Address(RVA = "0x70B3E0", Offset = "0x709FE0", VA = "0x18070B3E0", Slot = "5")]
		public override bool Validate(Entity target)
		{
			return default(bool);
		}

		// Token: 0x0600F7A5 RID: 63397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F7A5")]
		[Address(RVA = "0x70B570", Offset = "0x70A170", VA = "0x18070B570")]
		public FeverValidator()
		{
		}

		// Token: 0x0600F7A6 RID: 63398 RVA: 0x0005C988 File Offset: 0x0005AB88
		[Token(Token = "0x600F7A6")]
		[Address(RVA = "0x6EEA80", Offset = "0x6ED680", VA = "0x1806EEA80")]
		private bool <>xLuaBaseProxy_Validate(Entity P0)
		{
			return default(bool);
		}

		// Token: 0x0401132C RID: 70444
		[Token(Token = "0x401132C")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private string _feverKey;

		// Token: 0x0401132D RID: 70445
		[Token(Token = "0x401132D")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private bool _invertResult;

		// Token: 0x0401132E RID: 70446
		[Token(Token = "0x401132E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Validate;

		// Token: 0x0401132F RID: 70447
		[Token(Token = "0x401132F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
