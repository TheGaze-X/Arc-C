using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002AB9 RID: 10937
	[Token(Token = "0x2002AB9")]
	public class MultiRangedAttackWithResetSpellCnt : MultiRangedAttack
	{
		// Token: 0x0601234F RID: 74575 RVA: 0x0006F918 File Offset: 0x0006DB18
		[Token(Token = "0x601234F")]
		[Address(RVA = "0xA429D0", Offset = "0xA415D0", VA = "0x180A429D0", Slot = "60")]
		protected override bool FinishIfNot(Ability.FinishReason reason, bool resetCd)
		{
			return default(bool);
		}

		// Token: 0x06012350 RID: 74576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012350")]
		[Address(RVA = "0xA42AA0", Offset = "0xA416A0", VA = "0x180A42AA0")]
		public MultiRangedAttackWithResetSpellCnt()
		{
		}

		// Token: 0x06012351 RID: 74577 RVA: 0x0006F930 File Offset: 0x0006DB30
		[Token(Token = "0x6012351")]
		[Address(RVA = "0xA42A90", Offset = "0xA41690", VA = "0x180A42A90")]
		private bool <>xLuaBaseProxy_FinishIfNot(Ability.FinishReason P0, bool P1)
		{
			return default(bool);
		}

		// Token: 0x04014975 RID: 84341
		[Token(Token = "0x4014975")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_FinishIfNot;

		// Token: 0x04014976 RID: 84342
		[Token(Token = "0x4014976")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
