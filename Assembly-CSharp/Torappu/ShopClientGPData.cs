using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001313 RID: 4883
	[Token(Token = "0x2001313")]
	public class ShopClientGPData
	{
		// Token: 0x06007290 RID: 29328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007290")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ShopClientGPData()
		{
		}

		// Token: 0x04006C3E RID: 27710
		[Token(Token = "0x4006C3E")]
		[FieldOffset(Offset = "0x10")]
		public string goodId;

		// Token: 0x04006C3F RID: 27711
		[Token(Token = "0x4006C3F")]
		[FieldOffset(Offset = "0x18")]
		public string displayName;

		// Token: 0x04006C40 RID: 27712
		[Token(Token = "0x4006C40")]
		[FieldOffset(Offset = "0x20")]
		public ShopCondTrigPackageType condTrigPackageType;
	}
}
