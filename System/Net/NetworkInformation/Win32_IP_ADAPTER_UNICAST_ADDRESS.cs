using System;
using Il2CppDummyDll;

namespace System.Net.NetworkInformation
{
	// Token: 0x02000394 RID: 916
	[Token(Token = "0x2000394")]
	internal struct Win32_IP_ADAPTER_UNICAST_ADDRESS
	{
		// Token: 0x04000F2B RID: 3883
		[Token(Token = "0x4000F2B")]
		[FieldOffset(Offset = "0x0")]
		public Win32LengthFlagsUnion LengthFlags;

		// Token: 0x04000F2C RID: 3884
		[Token(Token = "0x4000F2C")]
		[FieldOffset(Offset = "0x8")]
		public IntPtr Next;

		// Token: 0x04000F2D RID: 3885
		[Token(Token = "0x4000F2D")]
		[FieldOffset(Offset = "0x10")]
		public Win32_SOCKET_ADDRESS Address;

		// Token: 0x04000F2E RID: 3886
		[Token(Token = "0x4000F2E")]
		[FieldOffset(Offset = "0x20")]
		public PrefixOrigin PrefixOrigin;

		// Token: 0x04000F2F RID: 3887
		[Token(Token = "0x4000F2F")]
		[FieldOffset(Offset = "0x24")]
		public SuffixOrigin SuffixOrigin;

		// Token: 0x04000F30 RID: 3888
		[Token(Token = "0x4000F30")]
		[FieldOffset(Offset = "0x28")]
		public DuplicateAddressDetectionState DadState;

		// Token: 0x04000F31 RID: 3889
		[Token(Token = "0x4000F31")]
		[FieldOffset(Offset = "0x2C")]
		public uint ValidLifetime;

		// Token: 0x04000F32 RID: 3890
		[Token(Token = "0x4000F32")]
		[FieldOffset(Offset = "0x30")]
		public uint PreferredLifetime;

		// Token: 0x04000F33 RID: 3891
		[Token(Token = "0x4000F33")]
		[FieldOffset(Offset = "0x34")]
		public uint LeaseLifetime;

		// Token: 0x04000F34 RID: 3892
		[Token(Token = "0x4000F34")]
		[FieldOffset(Offset = "0x38")]
		public byte OnLinkPrefixLength;
	}
}
