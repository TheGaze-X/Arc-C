using System;
using Il2CppDummyDll;

namespace System.Runtime.Serialization
{
	// Token: 0x020003F5 RID: 1013
	[Token(Token = "0x20003F5")]
	public interface ISurrogateSelector
	{
		// Token: 0x06001F92 RID: 8082
		[Token(Token = "0x6001F92")]
		ISerializationSurrogate GetSurrogate(System.Type type, StreamingContext context, out ISurrogateSelector selector);
	}
}
