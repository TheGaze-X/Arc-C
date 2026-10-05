using System;
using Il2CppDummyDll;

namespace System.Net.NetworkInformation
{
	// Token: 0x02000383 RID: 899
	[Token(Token = "0x2000383")]
	internal class Win32IPInterfaceProperties2 : IPInterfaceProperties
	{
		// Token: 0x0600188A RID: 6282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600188A")]
		[Address(RVA = "0x50B7F90", Offset = "0x50B6B90", VA = "0x1850B7F90")]
		public Win32IPInterfaceProperties2(Win32_IP_ADAPTER_ADDRESSES addr, Win32_MIB_IFROW mib4, Win32_MIB_IFROW mib6)
		{
		}

		// Token: 0x17000565 RID: 1381
		// (get) Token: 0x0600188B RID: 6283 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000565")]
		public override GatewayIPAddressInformationCollection GatewayAddresses
		{
			[Token(Token = "0x600188B")]
			[Address(RVA = "0x50B80C0", Offset = "0x50B6CC0", VA = "0x1850B80C0", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000566 RID: 1382
		// (get) Token: 0x0600188C RID: 6284 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000566")]
		public override UnicastIPAddressInformationCollection UnicastAddresses
		{
			[Token(Token = "0x600188C")]
			[Address(RVA = "0x50B8330", Offset = "0x50B6F30", VA = "0x1850B8330", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600188D RID: 6285 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600188D")]
		[Address(RVA = "0x50B7BF0", Offset = "0x50B67F0", VA = "0x1850B7BF0")]
		private static UnicastIPAddressInformationCollection Win32FromUnicast(IntPtr ptr)
		{
			return null;
		}

		// Token: 0x04000EC3 RID: 3779
		[Token(Token = "0x4000EC3")]
		[FieldOffset(Offset = "0x10")]
		private readonly Win32_IP_ADAPTER_ADDRESSES addr;

		// Token: 0x04000EC4 RID: 3780
		[Token(Token = "0x4000EC4")]
		[FieldOffset(Offset = "0x118")]
		private readonly Win32_MIB_IFROW mib4;

		// Token: 0x04000EC5 RID: 3781
		[Token(Token = "0x4000EC5")]
		[FieldOffset(Offset = "0x188")]
		private readonly Win32_MIB_IFROW mib6;
	}
}
