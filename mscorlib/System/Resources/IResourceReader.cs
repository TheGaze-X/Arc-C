using System;
using System.Collections;
using Il2CppDummyDll;

namespace System.Resources
{
	// Token: 0x020004CC RID: 1228
	[Token(Token = "0x20004CC")]
	public interface IResourceReader : System.Collections.IEnumerable, System.IDisposable
	{
		// Token: 0x06002385 RID: 9093
		[Token(Token = "0x6002385")]
		void Close();

		// Token: 0x06002386 RID: 9094
		[Token(Token = "0x6002386")]
		System.Collections.IDictionaryEnumerator GetEnumerator();
	}
}
