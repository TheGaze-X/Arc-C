using System;
using System.Threading.Tasks;
using Il2CppDummyDll;

namespace Vuplex.WebView
{
	// Token: 0x0200002F RID: 47
	[Token(Token = "0x200002F")]
	public interface IWithPdfCreation
	{
		// Token: 0x06000168 RID: 360
		[Token(Token = "0x6000168")]
		Task<string> CreatePdf();
	}
}
