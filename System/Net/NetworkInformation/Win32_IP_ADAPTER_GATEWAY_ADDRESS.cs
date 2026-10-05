using System;
using Il2CppDummyDll;

namespace System.Net.NetworkInformation
{
	// Token: 0x02000393 RID: 915
	[Token(Token = "0x2000393")]
	internal struct Win32_IP_ADAPTER_GATEWAY_ADDRESS
	{
		// Token: 0x04000F28 RID: 3880
		[Token(Token = "0x4000F28")]
		[FieldOffset(Offset = "0x0")]
		public Win32LengthFlagsUnion LengthFlags;

		// Token: 0x04000F29 RID: 3881
		[Token(Token = "0x4000F29")]
		[FieldOffset(Offset = "0x8")]
		public IntPtr Next;

		// Token: 0x04000F2A RID: 3882
		[Token(Token = "0x4000F2A")]
		[FieldOffset(Offset = "0x10")]
		public Win32_SOCKET_ADDRESS Address;
	}
}
