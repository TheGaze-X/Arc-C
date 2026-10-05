using System;
using Il2CppDummyDll;

namespace System.Net.NetworkInformation
{
	// Token: 0x02000389 RID: 905
	[Token(Token = "0x2000389")]
	internal struct Win32_FIXED_INFO
	{
		// Token: 0x04000ECE RID: 3790
		[Token(Token = "0x4000ECE")]
		[FieldOffset(Offset = "0x0")]
		public string HostName;

		// Token: 0x04000ECF RID: 3791
		[Token(Token = "0x4000ECF")]
		[FieldOffset(Offset = "0x8")]
		public string DomainName;

		// Token: 0x04000ED0 RID: 3792
		[Token(Token = "0x4000ED0")]
		[FieldOffset(Offset = "0x10")]
		public IntPtr CurrentDnsServer;

		// Token: 0x04000ED1 RID: 3793
		[Token(Token = "0x4000ED1")]
		[FieldOffset(Offset = "0x18")]
		public Win32_IP_ADDR_STRING DnsServerList;

		// Token: 0x04000ED2 RID: 3794
		[Token(Token = "0x4000ED2")]
		[FieldOffset(Offset = "0x38")]
		public NetBiosNodeType NodeType;

		// Token: 0x04000ED3 RID: 3795
		[Token(Token = "0x4000ED3")]
		[FieldOffset(Offset = "0x40")]
		public string ScopeId;

		// Token: 0x04000ED4 RID: 3796
		[Token(Token = "0x4000ED4")]
		[FieldOffset(Offset = "0x48")]
		public uint EnableRouting;

		// Token: 0x04000ED5 RID: 3797
		[Token(Token = "0x4000ED5")]
		[FieldOffset(Offset = "0x4C")]
		public uint EnableProxy;

		// Token: 0x04000ED6 RID: 3798
		[Token(Token = "0x4000ED6")]
		[FieldOffset(Offset = "0x50")]
		public uint EnableDns;
	}
}
