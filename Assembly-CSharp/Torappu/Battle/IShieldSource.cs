using System;
using Il2CppDummyDll;

namespace Torappu.Battle
{
	// Token: 0x02002238 RID: 8760
	[Token(Token = "0x2002238")]
	public interface IShieldSource
	{
		// Token: 0x17001BC3 RID: 7107
		// (get) Token: 0x0600DC22 RID: 56354
		[Token(Token = "0x17001BC3")]
		bool hasShield { [Token(Token = "0x600DC22")] get; }

		// Token: 0x0600DC23 RID: 56355
		[Token(Token = "0x600DC23")]
		Entity.ShieldUIController.ShieldData CalculateShieldData();
	}
}
