using System;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace System.Runtime.Remoting.Messaging
{
	// Token: 0x020003E0 RID: 992
	[Token(Token = "0x20003E0")]
	internal class ObjRefSurrogate : System.Runtime.Serialization.ISerializationSurrogate
	{
		// Token: 0x06001F3E RID: 7998 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F3E")]
		[Address(RVA = "0x4BA18E0", Offset = "0x4BA04E0", VA = "0x184BA18E0", Slot = "6")]
		public virtual void GetObjectData(object obj, System.Runtime.Serialization.SerializationInfo si, System.Runtime.Serialization.StreamingContext sc)
		{
		}

		// Token: 0x06001F3F RID: 7999 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001F3F")]
		[Address(RVA = "0x4BA1BD0", Offset = "0x4BA07D0", VA = "0x184BA1BD0", Slot = "7")]
		public virtual object SetObjectData(object obj, System.Runtime.Serialization.SerializationInfo si, System.Runtime.Serialization.StreamingContext sc, System.Runtime.Serialization.ISurrogateSelector selector)
		{
			return null;
		}

		// Token: 0x06001F40 RID: 8000 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F40")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ObjRefSurrogate()
		{
		}
	}
}
