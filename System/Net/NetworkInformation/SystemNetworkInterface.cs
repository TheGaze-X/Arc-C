using System;
using Il2CppDummyDll;

namespace System.Net.NetworkInformation
{
	// Token: 0x02000377 RID: 887
	[Token(Token = "0x2000377")]
	internal static class SystemNetworkInterface
	{
		// Token: 0x06001864 RID: 6244 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001864")]
		[Address(RVA = "0x50B2200", Offset = "0x50B0E00", VA = "0x1850B2200")]
		public static NetworkInterface[] GetNetworkInterfaces()
		{
			return null;
		}

		// Token: 0x04000EAD RID: 3757
		[Token(Token = "0x4000EAD")]
		[FieldOffset(Offset = "0x0")]
		private static readonly NetworkInterfaceFactory nif;
	}
}
