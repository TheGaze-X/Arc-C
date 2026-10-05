using System;
using Il2CppDummyDll;

namespace Torappu.Lua
{
	// Token: 0x0200019B RID: 411
	[Token(Token = "0x200019B")]
	public interface ILuaEnv : IDisposable
	{
		// Token: 0x060009C8 RID: 2504
		[Token(Token = "0x60009C8")]
		void AddLoader(Func<string, byte[]> loader);

		// Token: 0x060009C9 RID: 2505
		[Token(Token = "0x60009C9")]
		void DoLoad(string filePath);

		// Token: 0x060009CA RID: 2506
		[Token(Token = "0x60009CA")]
		void DoString(string script);

		// Token: 0x060009CB RID: 2507
		[Token(Token = "0x60009CB")]
		object[] Eval(string chunk, string chunkName);

		// Token: 0x060009CC RID: 2508
		[Token(Token = "0x60009CC")]
		void FullGC();
	}
}
