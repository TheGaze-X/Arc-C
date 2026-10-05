using System;
using Il2CppDummyDll;

namespace Torappu.Battle
{
	// Token: 0x0200222D RID: 8749
	[Token(Token = "0x200222D")]
	public interface IChargeableAbilityCounter : IChargeableAbility, IMultiChargeUberEffectEmitterAbility, IChargeableSource
	{
		// Token: 0x0600DC10 RID: 56336
		[Token(Token = "0x600DC10")]
		void OnCastOnTargetBehaviours(Entity target);
	}
}
