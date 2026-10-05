using System;
using Il2CppDummyDll;

namespace Torappu.Battle
{
	// Token: 0x0200222E RID: 8750
	[Token(Token = "0x200222E")]
	public interface IChargeableAbility : IMultiChargeUberEffectEmitterAbility, IChargeableSource
	{
		// Token: 0x0600DC11 RID: 56337
		[Token(Token = "0x600DC11")]
		void SetChargeTimes(int times);

		// Token: 0x0600DC12 RID: 56338
		[Token(Token = "0x600DC12")]
		void SetIsChargeAction(bool isChargeAttack);

		// Token: 0x0600DC13 RID: 56339
		[Token(Token = "0x600DC13")]
		void FinishAbility(Ability.FinishReason reason);

		// Token: 0x0600DC14 RID: 56340
		[Token(Token = "0x600DC14")]
		void OnChargeCastEvent(AbilityStandard.Event ev);
	}
}
