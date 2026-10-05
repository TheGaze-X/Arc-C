using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Net.NetworkInformation
{
	// Token: 0x02000385 RID: 901
	[Token(Token = "0x2000385")]
	internal class Win32NetworkInterfaceAPI : NetworkInterfaceFactory
	{
		// Token: 0x0600188F RID: 6287
		[Token(Token = "0x600188F")]
		[Address(RVA = "0x50B9010", Offset = "0x50B7C10", VA = "0x1850B9010")]
		[PreserveSig]
		private static extern int GetAdaptersAddresses(uint family, uint flags, IntPtr reserved, IntPtr info, ref int size);

		// Token: 0x06001890 RID: 6288 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001890")]
		[Address(RVA = "0x50B8B20", Offset = "0x50B7720", VA = "0x1850B8B20")]
		private static Win32_IP_ADAPTER_ADDRESSES[] GetAdaptersAddresses()
		{
			return null;
		}

		// Token: 0x06001891 RID: 6289 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001891")]
		[Address(RVA = "0x50B90D0", Offset = "0x50B7CD0", VA = "0x1850B90D0", Slot = "4")]
		public override NetworkInterface[] GetAllNetworkInterfaces()
		{
			return null;
		}

		// Token: 0x06001892 RID: 6290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001892")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Win32NetworkInterfaceAPI()
		{
		}
	}
}
