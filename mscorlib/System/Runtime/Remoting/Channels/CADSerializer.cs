using System;
using System.IO;
using System.Runtime.Remoting.Messaging;
using Il2CppDummyDll;

namespace System.Runtime.Remoting.Channels
{
	// Token: 0x0200039F RID: 927
	[Token(Token = "0x200039F")]
	internal class CADSerializer
	{
		// Token: 0x06001DEA RID: 7658 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001DEA")]
		[Address(RVA = "0x4B72260", Offset = "0x4B70E60", VA = "0x184B72260")]
		internal static System.Runtime.Remoting.Messaging.IMessage DeserializeMessage(System.IO.MemoryStream mem, System.Runtime.Remoting.Messaging.IMethodCallMessage msg)
		{
			return null;
		}

		// Token: 0x06001DEB RID: 7659 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001DEB")]
		[Address(RVA = "0x4B72400", Offset = "0x4B71000", VA = "0x184B72400")]
		internal static System.IO.MemoryStream SerializeMessage(System.Runtime.Remoting.Messaging.IMessage msg)
		{
			return null;
		}

		// Token: 0x06001DEC RID: 7660 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001DEC")]
		[Address(RVA = "0x4B722B0", Offset = "0x4B70EB0", VA = "0x184B722B0")]
		internal static object DeserializeObjectSafe(byte[] mem)
		{
			return null;
		}

		// Token: 0x06001DED RID: 7661 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001DED")]
		[Address(RVA = "0x4B72520", Offset = "0x4B71120", VA = "0x184B72520")]
		internal static System.IO.MemoryStream SerializeObject(object obj)
		{
			return null;
		}

		// Token: 0x06001DEE RID: 7662 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001DEE")]
		[Address(RVA = "0x4B72350", Offset = "0x4B70F50", VA = "0x184B72350")]
		internal static object DeserializeObject(System.IO.MemoryStream mem)
		{
			return null;
		}
	}
}
