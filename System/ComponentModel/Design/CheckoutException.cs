using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace System.ComponentModel.Design
{
	// Token: 0x02000230 RID: 560
	[Token(Token = "0x2000230")]
	[Serializable]
	public class CheckoutException : ExternalException
	{
		// Token: 0x06000F70 RID: 3952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F70")]
		[Address(RVA = "0x5177560", Offset = "0x5176160", VA = "0x185177560")]
		public CheckoutException()
		{
		}

		// Token: 0x06000F71 RID: 3953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F71")]
		[Address(RVA = "0x5177570", Offset = "0x5176170", VA = "0x185177570")]
		public CheckoutException(string message, int errorCode)
		{
		}

		// Token: 0x06000F72 RID: 3954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F72")]
		[Address(RVA = "0x4AE1A60", Offset = "0x4AE0660", VA = "0x184AE1A60")]
		protected CheckoutException(SerializationInfo info, StreamingContext context)
		{
		}

		// Token: 0x04000816 RID: 2070
		[Token(Token = "0x4000816")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly CheckoutException Canceled;
	}
}
