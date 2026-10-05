using System;
using Il2CppDummyDll;

namespace System.Net.NetworkInformation
{
	// Token: 0x02000378 RID: 888
	[Token(Token = "0x2000378")]
	internal abstract class NetworkInterfaceFactory
	{
		// Token: 0x06001866 RID: 6246
		[Token(Token = "0x6001866")]
		public abstract NetworkInterface[] GetAllNetworkInterfaces();

		// Token: 0x06001867 RID: 6247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001867")]
		[Address(RVA = "0x509E010", Offset = "0x509CC10", VA = "0x18509E010")]
		public static NetworkInterfaceFactory Create()
		{
			return null;
		}

		// Token: 0x06001868 RID: 6248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001868")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected NetworkInterfaceFactory()
		{
		}
	}
}
