using System;
using Il2CppDummyDll;

namespace Torappu.Battle
{
	// Token: 0x0200223B RID: 8763
	[Token(Token = "0x200223B")]
	public interface IPausableAbility
	{
		// Token: 0x0600DC28 RID: 56360
		[Token(Token = "0x600DC28")]
		void Pause();

		// Token: 0x0600DC29 RID: 56361
		[Token(Token = "0x600DC29")]
		void Recover();
	}
}
