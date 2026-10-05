using System;
using Il2CppDummyDll;

namespace Torappu.UI
{
	// Token: 0x020037A7 RID: 14247
	[Token(Token = "0x20037A7")]
	public interface IUIMusicConfig : IHotfixable
	{
		// Token: 0x060169A1 RID: 92577
		[Token(Token = "0x60169A1")]
		string GenerateLocalCacheKey();

		// Token: 0x060169A2 RID: 92578
		[Token(Token = "0x60169A2")]
		string DefaultAudioEventName();
	}
}
