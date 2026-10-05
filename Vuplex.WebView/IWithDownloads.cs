using System;
using Il2CppDummyDll;

namespace Vuplex.WebView
{
	// Token: 0x02000022 RID: 34
	[Token(Token = "0x2000022")]
	public interface IWithDownloads
	{
		// Token: 0x06000148 RID: 328
		[Token(Token = "0x6000148")]
		void SetDownloadsEnabled(bool enabled);

		// Token: 0x1400002A RID: 42
		// (add) Token: 0x06000149 RID: 329
		// (remove) Token: 0x0600014A RID: 330
		[Token(Token = "0x1400002A")]
		event EventHandler<DownloadChangedEventArgs> DownloadProgressChanged;
	}
}
