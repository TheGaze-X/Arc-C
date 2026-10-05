using System;
using Il2CppDummyDll;

namespace HGSDK
{
	// Token: 0x02000133 RID: 307
	[Token(Token = "0x2000133")]
	public struct PayCreateOrderAppstoreRequest
	{
		// Token: 0x04000620 RID: 1568
		[Token(Token = "0x4000620")]
		[FieldOffset(Offset = "0x0")]
		public string token;

		// Token: 0x04000621 RID: 1569
		[Token(Token = "0x4000621")]
		[FieldOffset(Offset = "0x8")]
		public string version;

		// Token: 0x04000622 RID: 1570
		[Token(Token = "0x4000622")]
		[FieldOffset(Offset = "0x10")]
		public string orderId;

		// Token: 0x04000623 RID: 1571
		[Token(Token = "0x4000623")]
		[FieldOffset(Offset = "0x18")]
		public long time;
	}
}
