using System;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x020001AC RID: 428
	[Token(Token = "0x20001AC")]
	public interface INestedContainer : IContainer, IDisposable
	{
		// Token: 0x17000238 RID: 568
		// (get) Token: 0x06000B0E RID: 2830
		[Token(Token = "0x17000238")]
		IComponent Owner { [Token(Token = "0x6000B0E")] get; }
	}
}
