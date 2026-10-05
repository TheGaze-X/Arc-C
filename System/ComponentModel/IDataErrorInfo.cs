using System;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x020001A8 RID: 424
	[Token(Token = "0x20001A8")]
	public interface IDataErrorInfo
	{
		// Token: 0x17000234 RID: 564
		[Token(Token = "0x17000234")]
		string this[string columnName]
		{
			[Token(Token = "0x6000B07")]
			get;
		}

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x06000B08 RID: 2824
		[Token(Token = "0x17000235")]
		string Error { [Token(Token = "0x6000B08")] get; }
	}
}
