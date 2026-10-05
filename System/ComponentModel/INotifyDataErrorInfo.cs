using System;
using System.Collections;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x020001F4 RID: 500
	[Token(Token = "0x20001F4")]
	public interface INotifyDataErrorInfo
	{
		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x06000D38 RID: 3384
		[Token(Token = "0x170002B7")]
		bool HasErrors { [Token(Token = "0x6000D38")] get; }

		// Token: 0x06000D39 RID: 3385
		[Token(Token = "0x6000D39")]
		IEnumerable GetErrors(string propertyName);

		// Token: 0x1400000A RID: 10
		// (add) Token: 0x06000D3A RID: 3386
		// (remove) Token: 0x06000D3B RID: 3387
		[Token(Token = "0x1400000A")]
		event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged;
	}
}
