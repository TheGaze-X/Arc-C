using System;
using Il2CppDummyDll;

namespace System.Threading
{
	// Token: 0x020001E9 RID: 489
	[Token(Token = "0x20001E9")]
	internal interface IAsyncLocal
	{
		// Token: 0x06001197 RID: 4503
		[Token(Token = "0x6001197")]
		void OnValueChanged(object previousValue, object currentValue, bool contextChanged);
	}
}
