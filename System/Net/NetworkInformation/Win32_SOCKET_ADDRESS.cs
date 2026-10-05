using System;
using Il2CppDummyDll;

namespace System.Net.NetworkInformation
{
	// Token: 0x02000396 RID: 918
	[Token(Token = "0x2000396")]
	internal struct Win32_SOCKET_ADDRESS
	{
		// Token: 0x0600189F RID: 6303 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600189F")]
		[Address(RVA = "0x50B9C60", Offset = "0x50B8860", VA = "0x1850B9C60")]
		public IPAddress GetIPAddress()
		{
			return null;
		}

		// Token: 0x04000F37 RID: 3895
		[Token(Token = "0x4000F37")]
		[FieldOffset(Offset = "0x0")]
		public IntPtr Sockaddr;

		// Token: 0x04000F38 RID: 3896
		[Token(Token = "0x4000F38")]
		[FieldOffset(Offset = "0x8")]
		public int SockaddrLength;
	}
}
