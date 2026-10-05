using System;
using Il2CppDummyDll;

namespace XDSDK
{
	// Token: 0x020000D5 RID: 213
	[Token(Token = "0x20000D5")]
	public class AppstoreOrder
	{
		// Token: 0x0600039F RID: 927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600039F")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public AppstoreOrder()
		{
		}

		// Token: 0x04000453 RID: 1107
		[Token(Token = "0x4000453")]
		[FieldOffset(Offset = "0x10")]
		public string txId;

		// Token: 0x04000454 RID: 1108
		[Token(Token = "0x4000454")]
		[FieldOffset(Offset = "0x18")]
		public string orderId;
	}
}
