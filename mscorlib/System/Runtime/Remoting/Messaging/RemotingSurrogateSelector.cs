using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace System.Runtime.Remoting.Messaging
{
	// Token: 0x020003E1 RID: 993
	[Token(Token = "0x20003E1")]
	[System.Runtime.InteropServices.ComVisible(true)]
	public class RemotingSurrogateSelector : System.Runtime.Serialization.ISurrogateSelector
	{
		// Token: 0x06001F41 RID: 8001 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F41")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RemotingSurrogateSelector()
		{
		}

		// Token: 0x06001F42 RID: 8002 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001F42")]
		[Address(RVA = "0x4BA8CC0", Offset = "0x4BA78C0", VA = "0x184BA8CC0", Slot = "5")]
		public virtual System.Runtime.Serialization.ISerializationSurrogate GetSurrogate(System.Type type, System.Runtime.Serialization.StreamingContext context, out System.Runtime.Serialization.ISurrogateSelector ssout)
		{
			return null;
		}

		// Token: 0x04001082 RID: 4226
		[Token(Token = "0x4001082")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static System.Type s_cachedTypeObjRef;

		// Token: 0x04001083 RID: 4227
		[Token(Token = "0x4001083")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static ObjRefSurrogate _objRefSurrogate;

		// Token: 0x04001084 RID: 4228
		[Token(Token = "0x4001084")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static RemotingSurrogate _objRemotingSurrogate;

		// Token: 0x04001085 RID: 4229
		[Token(Token = "0x4001085")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private System.Runtime.Serialization.ISurrogateSelector _next;
	}
}
