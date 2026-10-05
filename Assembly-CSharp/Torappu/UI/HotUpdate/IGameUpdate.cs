using System;
using System.Collections;
using Il2CppDummyDll;

namespace Torappu.UI.HotUpdate
{
	// Token: 0x02004ACC RID: 19148
	[Token(Token = "0x2004ACC")]
	public interface IGameUpdate
	{
		// Token: 0x0601CC15 RID: 117781
		[Token(Token = "0x601CC15")]
		IEnumerator DoUpdate(GameUpdateResult result);
	}
}
