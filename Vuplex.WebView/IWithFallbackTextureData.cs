using System;
using System.Threading.Tasks;
using Il2CppDummyDll;

namespace Vuplex.WebView
{
	// Token: 0x02000023 RID: 35
	[Token(Token = "0x2000023")]
	public interface IWithFallbackTextureData
	{
		// Token: 0x0600014B RID: 331
		[Token(Token = "0x600014B")]
		Task<byte[]> GetFallbackTextureData();
	}
}
