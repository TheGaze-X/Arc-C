using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Net.NetworkInformation
{
	// Token: 0x0200038F RID: 911
	[Token(Token = "0x200038F")]
	[StructLayout(0, CharSet = CharSet.Unicode)]
	internal struct Win32_IP_ADAPTER_ADDRESSES
	{
		// Token: 0x04000EE6 RID: 3814
		[Token(Token = "0x4000EE6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public AlignmentUnion Alignment;

		// Token: 0x04000EE7 RID: 3815
		[Token(Token = "0x4000EE7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public IntPtr Next;

		// Token: 0x04000EE8 RID: 3816
		[Token(Token = "0x4000EE8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string AdapterName;

		// Token: 0x04000EE9 RID: 3817
		[Token(Token = "0x4000EE9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IntPtr FirstUnicastAddress;

		// Token: 0x04000EEA RID: 3818
		[Token(Token = "0x4000EEA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IntPtr FirstAnycastAddress;

		// Token: 0x04000EEB RID: 3819
		[Token(Token = "0x4000EEB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public IntPtr FirstMulticastAddress;

		// Token: 0x04000EEC RID: 3820
		[Token(Token = "0x4000EEC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public IntPtr FirstDnsServerAddress;

		// Token: 0x04000EED RID: 3821
		[Token(Token = "0x4000EED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string DnsSuffix;

		// Token: 0x04000EEE RID: 3822
		[Token(Token = "0x4000EEE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string Description;

		// Token: 0x04000EEF RID: 3823
		[Token(Token = "0x4000EEF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string FriendlyName;

		// Token: 0x04000EF0 RID: 3824
		[Token(Token = "0x4000EF0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public byte[] PhysicalAddress;

		// Token: 0x04000EF1 RID: 3825
		[Token(Token = "0x4000EF1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public uint PhysicalAddressLength;

		// Token: 0x04000EF2 RID: 3826
		[Token(Token = "0x4000EF2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public uint Flags;

		// Token: 0x04000EF3 RID: 3827
		[Token(Token = "0x4000EF3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public uint Mtu;

		// Token: 0x04000EF4 RID: 3828
		[Token(Token = "0x4000EF4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public NetworkInterfaceType IfType;

		// Token: 0x04000EF5 RID: 3829
		[Token(Token = "0x4000EF5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public OperationalStatus OperStatus;

		// Token: 0x04000EF6 RID: 3830
		[Token(Token = "0x4000EF6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public int Ipv6IfIndex;

		// Token: 0x04000EF7 RID: 3831
		[Token(Token = "0x4000EF7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public uint[] ZoneIndices;

		// Token: 0x04000EF8 RID: 3832
		[Token(Token = "0x4000EF8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public IntPtr FirstPrefix;

		// Token: 0x04000EF9 RID: 3833
		[Token(Token = "0x4000EF9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public ulong TransmitLinkSpeed;

		// Token: 0x04000EFA RID: 3834
		[Token(Token = "0x4000EFA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public ulong ReceiveLinkSpeed;

		// Token: 0x04000EFB RID: 3835
		[Token(Token = "0x4000EFB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public IntPtr FirstWinsServerAddress;

		// Token: 0x04000EFC RID: 3836
		[Token(Token = "0x4000EFC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public IntPtr FirstGatewayAddress;

		// Token: 0x04000EFD RID: 3837
		[Token(Token = "0x4000EFD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public uint Ipv4Metric;

		// Token: 0x04000EFE RID: 3838
		[Token(Token = "0x4000EFE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public uint Ipv6Metric;

		// Token: 0x04000EFF RID: 3839
		[Token(Token = "0x4000EFF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public ulong Luid;

		// Token: 0x04000F00 RID: 3840
		[Token(Token = "0x4000F00")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public Win32_SOCKET_ADDRESS Dhcpv4Server;

		// Token: 0x04000F01 RID: 3841
		[Token(Token = "0x4000F01")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public uint CompartmentId;

		// Token: 0x04000F02 RID: 3842
		[Token(Token = "0x4000F02")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public ulong NetworkGuid;

		// Token: 0x04000F03 RID: 3843
		[Token(Token = "0x4000F03")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public int ConnectionType;

		// Token: 0x04000F04 RID: 3844
		[Token(Token = "0x4000F04")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		public int TunnelType;

		// Token: 0x04000F05 RID: 3845
		[Token(Token = "0x4000F05")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public Win32_SOCKET_ADDRESS Dhcpv6Server;

		// Token: 0x04000F06 RID: 3846
		[Token(Token = "0x4000F06")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public byte[] Dhcpv6ClientDuid;

		// Token: 0x04000F07 RID: 3847
		[Token(Token = "0x4000F07")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public ulong Dhcpv6ClientDuidLength;

		// Token: 0x04000F08 RID: 3848
		[Token(Token = "0x4000F08")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public ulong Dhcpv6Iaid;

		// Token: 0x04000F09 RID: 3849
		[Token(Token = "0x4000F09")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public IntPtr FirstDnsSuffix;
	}
}
