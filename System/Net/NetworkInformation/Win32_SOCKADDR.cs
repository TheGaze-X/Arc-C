using System;
using Il2CppDummyDll;

namespace System.Net.NetworkInformation
{
	// Token: 0x02000395 RID: 917
	[Token(Token = "0x2000395")]
	internal struct Win32_SOCKADDR
	{
		// Token: 0x04000F35 RID: 3893
		[Token(Token = "0x4000F35")]
		[FieldOffset(Offset = "0x0")]
		public ushort AddressFamily;

		// Token: 0x04000F36 RID: 3894
		[Token(Token = "0x4000F36")]
		[FieldOffset(Offset = "0x8")]
		public byte[] AddressData;
	}
}
