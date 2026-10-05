using System;
using Il2CppDummyDll;

namespace Vuplex.WebView
{
	// Token: 0x02000030 RID: 48
	[Token(Token = "0x2000030")]
	public interface IWithPixelDensity
	{
		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000169 RID: 361
		[Token(Token = "0x17000024")]
		float PixelDensity { [Token(Token = "0x6000169")] get; }

		// Token: 0x0600016A RID: 362
		[Token(Token = "0x600016A")]
		void SetPixelDensity(float pixelDensity);
	}
}
