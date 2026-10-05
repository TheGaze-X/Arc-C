using System;
using Il2CppDummyDll;

namespace System.Runtime.Serialization
{
	// Token: 0x020003EC RID: 1004
	[Token(Token = "0x20003EC")]
	public interface IObjectReference
	{
		// Token: 0x06001F72 RID: 8050
		[Token(Token = "0x6001F72")]
		object GetRealObject(StreamingContext context);
	}
}
