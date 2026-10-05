using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System.Net.NetworkInformation
{
	// Token: 0x0200038A RID: 906
	[Token(Token = "0x200038A")]
	internal struct Win32_FIXED_INFO_Marshal
	{
		// Token: 0x04000ED7 RID: 3799
		[Token(Token = "0x4000ED7")]
		[FieldOffset(Offset = "0x0")]
		[FixedBuffer(typeof(byte), 132)]
		public Win32_FIXED_INFO_Marshal.<HostName>e__FixedBuffer HostName;

		// Token: 0x04000ED8 RID: 3800
		[Token(Token = "0x4000ED8")]
		[FieldOffset(Offset = "0x84")]
		[FixedBuffer(typeof(byte), 132)]
		public Win32_FIXED_INFO_Marshal.<DomainName>e__FixedBuffer DomainName;

		// Token: 0x04000ED9 RID: 3801
		[Token(Token = "0x4000ED9")]
		[FieldOffset(Offset = "0x108")]
		public IntPtr CurrentDnsServer;

		// Token: 0x04000EDA RID: 3802
		[Token(Token = "0x4000EDA")]
		[FieldOffset(Offset = "0x110")]
		public Win32_IP_ADDR_STRING DnsServerList;

		// Token: 0x04000EDB RID: 3803
		[Token(Token = "0x4000EDB")]
		[FieldOffset(Offset = "0x130")]
		public NetBiosNodeType NodeType;

		// Token: 0x04000EDC RID: 3804
		[Token(Token = "0x4000EDC")]
		[FieldOffset(Offset = "0x134")]
		[FixedBuffer(typeof(byte), 260)]
		public Win32_FIXED_INFO_Marshal.<ScopeId>e__FixedBuffer ScopeId;

		// Token: 0x04000EDD RID: 3805
		[Token(Token = "0x4000EDD")]
		[FieldOffset(Offset = "0x238")]
		public uint EnableRouting;

		// Token: 0x04000EDE RID: 3806
		[Token(Token = "0x4000EDE")]
		[FieldOffset(Offset = "0x23C")]
		public uint EnableProxy;

		// Token: 0x04000EDF RID: 3807
		[Token(Token = "0x4000EDF")]
		[FieldOffset(Offset = "0x240")]
		public uint EnableDns;

		// Token: 0x0200038B RID: 907
		[Token(Token = "0x200038B")]
		[CompilerGenerated]
		[UnsafeValueType]
		public struct <HostName>e__FixedBuffer
		{
			// Token: 0x04000EE0 RID: 3808
			[Token(Token = "0x4000EE0")]
			[FieldOffset(Offset = "0x0")]
			public byte FixedElementField;
		}

		// Token: 0x0200038C RID: 908
		[Token(Token = "0x200038C")]
		[CompilerGenerated]
		[UnsafeValueType]
		public struct <DomainName>e__FixedBuffer
		{
			// Token: 0x04000EE1 RID: 3809
			[Token(Token = "0x4000EE1")]
			[FieldOffset(Offset = "0x0")]
			public byte FixedElementField;
		}

		// Token: 0x0200038D RID: 909
		[Token(Token = "0x200038D")]
		[CompilerGenerated]
		[UnsafeValueType]
		public struct <ScopeId>e__FixedBuffer
		{
			// Token: 0x04000EE2 RID: 3810
			[Token(Token = "0x4000EE2")]
			[FieldOffset(Offset = "0x0")]
			public byte FixedElementField;
		}
	}
}
