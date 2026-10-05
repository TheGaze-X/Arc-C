using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000487 RID: 1159
	[Token(Token = "0x2000487")]
	public interface ITweenHandler
	{
		// Token: 0x06004CA4 RID: 19620
		[Token(Token = "0x6004CA4")]
		bool IsActive();

		// Token: 0x06004CA5 RID: 19621
		[Token(Token = "0x6004CA5")]
		void Kill(bool complete = false);
	}
}
