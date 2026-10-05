using System;
using Il2CppDummyDll;

namespace Torappu.UI
{
	// Token: 0x0200365A RID: 13914
	[Token(Token = "0x200365A")]
	public interface IStateCacheHandler
	{
		// Token: 0x06016241 RID: 90689
		[Token(Token = "0x6016241")]
		object Save();

		// Token: 0x06016242 RID: 90690
		[Token(Token = "0x6016242")]
		void Load(object bundle);
	}
}
