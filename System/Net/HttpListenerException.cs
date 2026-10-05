using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace System.Net
{
	// Token: 0x020002AA RID: 682
	[Token(Token = "0x20002AA")]
	[Serializable]
	public class HttpListenerException : Win32Exception
	{
		// Token: 0x06001334 RID: 4916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001334")]
		[Address(RVA = "0x51AB890", Offset = "0x51AA490", VA = "0x1851AB890")]
		public HttpListenerException()
		{
		}

		// Token: 0x06001335 RID: 4917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001335")]
		[Address(RVA = "0x50C1D50", Offset = "0x50C0950", VA = "0x1850C1D50")]
		public HttpListenerException(int errorCode, string message)
		{
		}

		// Token: 0x06001336 RID: 4918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001336")]
		[Address(RVA = "0x509DFE0", Offset = "0x509CBE0", VA = "0x18509DFE0")]
		protected HttpListenerException(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
		}
	}
}
