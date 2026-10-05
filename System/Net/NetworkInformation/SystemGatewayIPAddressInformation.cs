using System;
using Il2CppDummyDll;

namespace System.Net.NetworkInformation
{
	// Token: 0x02000370 RID: 880
	[Token(Token = "0x2000370")]
	internal class SystemGatewayIPAddressInformation : GatewayIPAddressInformation
	{
		// Token: 0x06001853 RID: 6227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001853")]
		[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
		internal SystemGatewayIPAddressInformation(IPAddress address)
		{
		}

		// Token: 0x1700055C RID: 1372
		// (get) Token: 0x06001854 RID: 6228 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700055C")]
		public override IPAddress Address
		{
			[Token(Token = "0x6001854")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000E88 RID: 3720
		[Token(Token = "0x4000E88")]
		[FieldOffset(Offset = "0x10")]
		private IPAddress address;
	}
}
