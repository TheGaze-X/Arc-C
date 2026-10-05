using System;
using Il2CppDummyDll;

namespace Torappu.Battle
{
	// Token: 0x020020E9 RID: 8425
	[Token(Token = "0x20020E9")]
	public interface IAbilityAttachment
	{
		// Token: 0x0600CE50 RID: 52816
		[Token(Token = "0x600CE50")]
		void Apply(Entity target, Entity owner, Ability ability, Blackboard blackboard);
	}
}
