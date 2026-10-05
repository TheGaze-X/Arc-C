using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200105A RID: 4186
	[Token(Token = "0x200105A")]
	public interface IGachaTimeData
	{
		// Token: 0x06006DE0 RID: 28128
		[Token(Token = "0x6006DE0")]
		long GetEndTime();

		// Token: 0x06006DE1 RID: 28129
		[Token(Token = "0x6006DE1")]
		bool IsValid(long curTs);
	}
}
