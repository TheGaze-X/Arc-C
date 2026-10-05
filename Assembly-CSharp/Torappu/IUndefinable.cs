using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001034 RID: 4148
	[Token(Token = "0x2001034")]
	public interface IUndefinable
	{
		// Token: 0x06006D95 RID: 28053
		[Token(Token = "0x6006D95")]
		object GetValue();

		// Token: 0x17000D15 RID: 3349
		// (get) Token: 0x06006D96 RID: 28054
		[Token(Token = "0x17000D15")]
		bool isDefined { [Token(Token = "0x6006D96")] get; }
	}
}
