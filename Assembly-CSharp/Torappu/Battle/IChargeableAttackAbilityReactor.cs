using System;
using Il2CppDummyDll;

namespace Torappu.Battle
{
	// Token: 0x0200222B RID: 8747
	[Token(Token = "0x200222B")]
	public interface IChargeableAttackAbilityReactor : IChargeableAbilityReactor, IChargeableAbility, IMultiChargeUberEffectEmitterAbility, IChargeableSource
	{
		// Token: 0x0600DC0B RID: 56331
		[Token(Token = "0x600DC0B")]
		void MergeAtkScale(FP atkScale);

		// Token: 0x0600DC0C RID: 56332
		[Token(Token = "0x600DC0C")]
		void ResetAtkScale();
	}
}
