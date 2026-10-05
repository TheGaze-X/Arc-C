using System;
using Il2CppDummyDll;

namespace System.Runtime.Serialization
{
	// Token: 0x020003ED RID: 1005
	[Token(Token = "0x20003ED")]
	public interface ISerializable
	{
		// Token: 0x06001F73 RID: 8051
		[Token(Token = "0x6001F73")]
		void GetObjectData(SerializationInfo info, StreamingContext context);
	}
}
