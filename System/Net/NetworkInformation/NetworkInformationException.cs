using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace System.Net.NetworkInformation
{
	// Token: 0x02000367 RID: 871
	[Token(Token = "0x2000367")]
	[Serializable]
	public class NetworkInformationException : Win32Exception
	{
		// Token: 0x0600183F RID: 6207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600183F")]
		[Address(RVA = "0x509DF80", Offset = "0x509CB80", VA = "0x18509DF80")]
		public NetworkInformationException()
		{
		}

		// Token: 0x06001840 RID: 6208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001840")]
		[Address(RVA = "0x509E000", Offset = "0x509CC00", VA = "0x18509E000")]
		public NetworkInformationException(int errorCode)
		{
		}

		// Token: 0x06001841 RID: 6209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001841")]
		[Address(RVA = "0x509DFE0", Offset = "0x509CBE0", VA = "0x18509DFE0")]
		protected NetworkInformationException(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
		}
	}
}
