using System;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace System.Runtime.Remoting.Messaging
{
	// Token: 0x020003DF RID: 991
	[Token(Token = "0x20003DF")]
	internal class RemotingSurrogate : System.Runtime.Serialization.ISerializationSurrogate
	{
		// Token: 0x06001F3B RID: 7995 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F3B")]
		[Address(RVA = "0x4BA8FC0", Offset = "0x4BA7BC0", VA = "0x184BA8FC0", Slot = "6")]
		public virtual void GetObjectData(object obj, System.Runtime.Serialization.SerializationInfo si, System.Runtime.Serialization.StreamingContext sc)
		{
		}

		// Token: 0x06001F3C RID: 7996 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001F3C")]
		[Address(RVA = "0x4BA9120", Offset = "0x4BA7D20", VA = "0x184BA9120", Slot = "7")]
		public virtual object SetObjectData(object obj, System.Runtime.Serialization.SerializationInfo si, System.Runtime.Serialization.StreamingContext sc, System.Runtime.Serialization.ISurrogateSelector selector)
		{
			return null;
		}

		// Token: 0x06001F3D RID: 7997 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F3D")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RemotingSurrogate()
		{
		}
	}
}
