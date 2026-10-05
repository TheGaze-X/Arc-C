using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace System.Net.Sockets
{
	// Token: 0x020003B1 RID: 945
	[Token(Token = "0x20003B1")]
	[Serializable]
	public class SocketException : Win32Exception
	{
		// Token: 0x060019D4 RID: 6612
		[Token(Token = "0x60019D4")]
		[Address(RVA = "0x50C1D40", Offset = "0x50C0940", VA = "0x1850C1D40")]
		[MethodImpl(4096)]
		private static extern int WSAGetLastError_icall();

		// Token: 0x060019D5 RID: 6613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019D5")]
		[Address(RVA = "0x50C1D60", Offset = "0x50C0960", VA = "0x1850C1D60")]
		public SocketException()
		{
		}

		// Token: 0x060019D6 RID: 6614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019D6")]
		[Address(RVA = "0x50C1D50", Offset = "0x50C0950", VA = "0x1850C1D50")]
		internal SocketException(int error, string message)
		{
		}

		// Token: 0x060019D7 RID: 6615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019D7")]
		[Address(RVA = "0x509E000", Offset = "0x509CC00", VA = "0x18509E000")]
		public SocketException(int errorCode)
		{
		}

		// Token: 0x060019D8 RID: 6616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019D8")]
		[Address(RVA = "0x509E000", Offset = "0x509CC00", VA = "0x18509E000")]
		internal SocketException(SocketError socketError)
		{
		}

		// Token: 0x060019D9 RID: 6617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019D9")]
		[Address(RVA = "0x509DFE0", Offset = "0x509CBE0", VA = "0x18509DFE0")]
		protected SocketException(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
		}

		// Token: 0x170005A0 RID: 1440
		// (get) Token: 0x060019DA RID: 6618 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005A0")]
		public override string Message
		{
			[Token(Token = "0x60019DA")]
			[Address(RVA = "0x50C1D80", Offset = "0x50C0980", VA = "0x1850C1D80", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005A1 RID: 1441
		// (get) Token: 0x060019DB RID: 6619 RVA: 0x0000B9D0 File Offset: 0x00009BD0
		[Token(Token = "0x170005A1")]
		public SocketError SocketErrorCode
		{
			[Token(Token = "0x60019DB")]
			[Address(RVA = "0x4D67380", Offset = "0x4D65F80", VA = "0x184D67380")]
			get
			{
				return SocketError.Success;
			}
		}

		// Token: 0x04000FC4 RID: 4036
		[Token(Token = "0x4000FC4")]
		[FieldOffset(Offset = "0x98")]
		[NonSerialized]
		private EndPoint m_EndPoint;
	}
}
