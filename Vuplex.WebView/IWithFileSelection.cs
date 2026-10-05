using System;
using Il2CppDummyDll;

namespace Vuplex.WebView
{
	// Token: 0x02000025 RID: 37
	[Token(Token = "0x2000025")]
	public interface IWithFileSelection
	{
		// Token: 0x1400002C RID: 44
		// (add) Token: 0x06000150 RID: 336
		// (remove) Token: 0x06000151 RID: 337
		[Token(Token = "0x1400002C")]
		event EventHandler<FileSelectionEventArgs> FileSelectionRequested;
	}
}
