using System;
using Il2CppDummyDll;

namespace System.Runtime.Serialization
{
	// Token: 0x020003F4 RID: 1012
	[Token(Token = "0x20003F4")]
	public interface ISerializationSurrogate
	{
		// Token: 0x06001F90 RID: 8080
		[Token(Token = "0x6001F90")]
		void GetObjectData(object obj, SerializationInfo info, StreamingContext context);

		// Token: 0x06001F91 RID: 8081
		[Token(Token = "0x6001F91")]
		object SetObjectData(object obj, SerializationInfo info, StreamingContext context, ISurrogateSelector selector);
	}
}
