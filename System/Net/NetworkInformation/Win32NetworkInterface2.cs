using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Net.NetworkInformation
{
	// Token: 0x02000386 RID: 902
	[Token(Token = "0x2000386")]
	internal sealed class Win32NetworkInterface2 : NetworkInterface
	{
		// Token: 0x06001893 RID: 6291
		[Token(Token = "0x6001893")]
		[Address(RVA = "0x50B8400", Offset = "0x50B7000", VA = "0x1850B8400")]
		[PreserveSig]
		private static extern int GetIfEntry(ref Win32_MIB_IFROW row);

		// Token: 0x06001894 RID: 6292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001894")]
		[Address(RVA = "0x50B8600", Offset = "0x50B7200", VA = "0x1850B8600")]
		internal Win32NetworkInterface2(Win32_IP_ADAPTER_ADDRESSES addr)
		{
		}

		// Token: 0x06001895 RID: 6293 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001895")]
		[Address(RVA = "0x50B83F0", Offset = "0x50B6FF0", VA = "0x1850B83F0", Slot = "5")]
		public override IPInterfaceProperties GetIPProperties()
		{
			return null;
		}

		// Token: 0x06001896 RID: 6294 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001896")]
		[Address(RVA = "0x50B8540", Offset = "0x50B7140", VA = "0x1850B8540", Slot = "7")]
		public override PhysicalAddress GetPhysicalAddress()
		{
			return null;
		}

		// Token: 0x17000567 RID: 1383
		// (get) Token: 0x06001897 RID: 6295 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000567")]
		public override string Description
		{
			[Token(Token = "0x6001897")]
			[Address(RVA = "0x5EC460", Offset = "0x5EB060", VA = "0x1805EC460", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000568 RID: 1384
		// (get) Token: 0x06001898 RID: 6296 RVA: 0x0000B088 File Offset: 0x00009288
		[Token(Token = "0x17000568")]
		public override NetworkInterfaceType NetworkInterfaceType
		{
			[Token(Token = "0x6001898")]
			[Address(RVA = "0x4D7C600", Offset = "0x4D7B200", VA = "0x184D7C600", Slot = "8")]
			get
			{
				return (NetworkInterfaceType)0;
			}
		}

		// Token: 0x17000569 RID: 1385
		// (get) Token: 0x06001899 RID: 6297 RVA: 0x0000B0A0 File Offset: 0x000092A0
		[Token(Token = "0x17000569")]
		public override OperationalStatus OperationalStatus
		{
			[Token(Token = "0x6001899")]
			[Address(RVA = "0x1820C10", Offset = "0x181F810", VA = "0x181820C10", Slot = "6")]
			get
			{
				return (OperationalStatus)0;
			}
		}

		// Token: 0x04000EC7 RID: 3783
		[Token(Token = "0x4000EC7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Win32_IP_ADAPTER_ADDRESSES addr;

		// Token: 0x04000EC8 RID: 3784
		[Token(Token = "0x4000EC8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Win32_MIB_IFROW mib4;

		// Token: 0x04000EC9 RID: 3785
		[Token(Token = "0x4000EC9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private Win32_MIB_IFROW mib6;

		// Token: 0x04000ECA RID: 3786
		[Token(Token = "0x4000ECA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		private Win32IPv4InterfaceStatistics ip4stats;

		// Token: 0x04000ECB RID: 3787
		[Token(Token = "0x4000ECB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		private IPInterfaceProperties ip_if_props;
	}
}
