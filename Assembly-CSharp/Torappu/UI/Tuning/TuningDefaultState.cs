using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Tuning
{
	// Token: 0x02003C8B RID: 15499
	[Token(Token = "0x2003C8B")]
	public class TuningDefaultState : State, IHotfixable
	{
		// Token: 0x0601834F RID: 99151 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601834F")]
		[Address(RVA = "0x10B38D0", Offset = "0x10B24D0", VA = "0x1810B38D0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06018350 RID: 99152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018350")]
		[Address(RVA = "0x10B3930", Offset = "0x10B2530", VA = "0x1810B3930")]
		public TuningDefaultState()
		{
		}

		// Token: 0x0401D7AA RID: 120746
		[Token(Token = "0x401D7AA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0401D7AB RID: 120747
		[Token(Token = "0x401D7AB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
