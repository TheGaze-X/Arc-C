using System;
using Il2CppDummyDll;

namespace Torappu.Battle
{
	// Token: 0x0200222C RID: 8748
	[Token(Token = "0x200222C")]
	public interface IChargeableAbilityReactor : IChargeableAbility, IMultiChargeUberEffectEmitterAbility, IChargeableSource
	{
		// Token: 0x17001BC0 RID: 7104
		// (get) Token: 0x0600DC0D RID: 56333
		// (set) Token: 0x0600DC0E RID: 56334
		[Token(Token = "0x17001BC0")]
		IChargeableAbilityCounter chargeCounter { [Token(Token = "0x600DC0D")] get; [Token(Token = "0x600DC0E")] set; }

		// Token: 0x0600DC0F RID: 56335
		[Token(Token = "0x600DC0F")]
		void SetChargeCounter(IChargeableAbilityCounter counter);
	}
}
