using System;
using System.Net.Sockets;
using Il2CppDummyDll;

namespace System.Net.NetworkInformation
{
	// Token: 0x02000397 RID: 919
	[Token(Token = "0x2000397")]
	internal class Win32UnicastIPAddressInformation : UnicastIPAddressInformation
	{
		// Token: 0x060018A0 RID: 6304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018A0")]
		[Address(RVA = "0x50B9AF0", Offset = "0x50B86F0", VA = "0x1850B9AF0")]
		public Win32UnicastIPAddressInformation(Win32_IP_ADAPTER_UNICAST_ADDRESS info)
		{
		}

		// Token: 0x1700056B RID: 1387
		// (get) Token: 0x060018A1 RID: 6305 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700056B")]
		public override IPAddress Address
		{
			[Token(Token = "0x60018A1")]
			[Address(RVA = "0x50B9C50", Offset = "0x50B8850", VA = "0x1850B9C50", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x060018A2 RID: 6306 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018A2")]
		[Address(RVA = "0x50B9A10", Offset = "0x50B8610", VA = "0x1850B9A10")]
		private static IPAddress PrefixLengthToSubnetMask(byte prefixLength, AddressFamily family)
		{
			return null;
		}

		// Token: 0x04000F39 RID: 3897
		[Token(Token = "0x4000F39")]
		[FieldOffset(Offset = "0x10")]
		private Win32_IP_ADAPTER_UNICAST_ADDRESS info;

		// Token: 0x04000F3A RID: 3898
		[Token(Token = "0x4000F3A")]
		[FieldOffset(Offset = "0x50")]
		private IPAddress ipv4Mask;
	}
}
