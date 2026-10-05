using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000564 RID: 1380
	[Token(Token = "0x2000564")]
	public interface IPeriodicTicker
	{
		// Token: 0x17000CA1 RID: 3233
		// (get) Token: 0x06005B42 RID: 23362
		[Token(Token = "0x17000CA1")]
		bool isReady { [Token(Token = "0x6005B42")] get; }

		// Token: 0x06005B43 RID: 23363
		[Token(Token = "0x6005B43")]
		void Reset(bool waitFirstPeriod);

		// Token: 0x06005B44 RID: 23364
		[Token(Token = "0x6005B44")]
		void Reset(int newPeriod, bool waitFirstPeriod);

		// Token: 0x06005B45 RID: 23365
		[Token(Token = "0x6005B45")]
		bool Tick();

		// Token: 0x06005B46 RID: 23366
		[Token(Token = "0x6005B46")]
		bool Next();
	}
}
