using System;
using Il2CppDummyDll;

namespace Torappu.Battle
{
	// Token: 0x02002235 RID: 8757
	[Token(Token = "0x2002235")]
	public interface IDeckAura : IHotfixable
	{
		// Token: 0x17001BC1 RID: 7105
		// (get) Token: 0x0600DC1B RID: 56347
		[Token(Token = "0x17001BC1")]
		string key { [Token(Token = "0x600DC1B")] get; }

		// Token: 0x17001BC2 RID: 7106
		// (get) Token: 0x0600DC1C RID: 56348
		[Token(Token = "0x17001BC2")]
		int priority { [Token(Token = "0x600DC1C")] get; }

		// Token: 0x0600DC1D RID: 56349
		[Token(Token = "0x600DC1D")]
		void OnEnable(Deck deck);

		// Token: 0x0600DC1E RID: 56350
		[Token(Token = "0x600DC1E")]
		void OnDisable(Deck deck);

		// Token: 0x0600DC1F RID: 56351
		[Token(Token = "0x600DC1F")]
		void OnDirty(Deck deck);
	}
}
