using System;
using Il2CppDummyDll;

namespace Prime31
{
	// Token: 0x0200042E RID: 1070
	[Token(Token = "0x200042E")]
	public class StoreKitAppReceipt
	{
		// Token: 0x06004954 RID: 18772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004954")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public StoreKitAppReceipt()
		{
		}

		// Token: 0x04000DD9 RID: 3545
		[Token(Token = "0x4000DD9")]
		[FieldOffset(Offset = "0x10")]
		public int status;

		// Token: 0x04000DDA RID: 3546
		[Token(Token = "0x4000DDA")]
		[FieldOffset(Offset = "0x18")]
		public string environment;

		// Token: 0x04000DDB RID: 3547
		[Token(Token = "0x4000DDB")]
		[FieldOffset(Offset = "0x20")]
		public StoreKitReceipt receipt;
	}
}
