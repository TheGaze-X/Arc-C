using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Runtime.Remoting.Contexts
{
	// Token: 0x02000392 RID: 914
	[Token(Token = "0x2000392")]
	[System.Runtime.InteropServices.ComVisible(true)]
	public interface IContextProperty
	{
		// Token: 0x17000377 RID: 887
		// (get) Token: 0x06001DBE RID: 7614
		[Token(Token = "0x17000377")]
		string Name { [Token(Token = "0x6001DBE")] get; }

		// Token: 0x06001DBF RID: 7615
		[Token(Token = "0x6001DBF")]
		void Freeze(Context newContext);

		// Token: 0x06001DC0 RID: 7616
		[Token(Token = "0x6001DC0")]
		bool IsNewContextOK(Context newCtx);
	}
}
