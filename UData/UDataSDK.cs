using System;
using Il2CppDummyDll;

namespace UDatasdk
{
	// Token: 0x02000011 RID: 17
	[Token(Token = "0x2000011")]
	public sealed class UDataSDK
	{
		// Token: 0x0600003F RID: 63 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600003F")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		private UDataSDK()
		{
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000040 RID: 64 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x1700000B")]
		public static IUDataSDK Instance
		{
			[Token(Token = "0x6000040")]
			[Address(RVA = "0x55C64E0", Offset = "0x55C50E0", VA = "0x1855C64E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000034 RID: 52
		[Token(Token = "0x4000034")]
		[FieldOffset(Offset = "0x0")]
		private static IUDataSDK m_instance;
	}
}
