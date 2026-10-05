using System;
using Il2CppDummyDll;

namespace HGSDK
{
	// Token: 0x02000132 RID: 306
	[Token(Token = "0x2000132")]
	public class AuthResponse
	{
		// Token: 0x060004F1 RID: 1265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004F1")]
		[Address(RVA = "0x1028510", Offset = "0x1027110", VA = "0x181028510")]
		public AuthResponse()
		{
		}

		// Token: 0x0400061B RID: 1563
		[Token(Token = "0x400061B")]
		[FieldOffset(Offset = "0x10")]
		public string uid;

		// Token: 0x0400061C RID: 1564
		[Token(Token = "0x400061C")]
		[FieldOffset(Offset = "0x18")]
		public bool isAuthenticate;

		// Token: 0x0400061D RID: 1565
		[Token(Token = "0x400061D")]
		[FieldOffset(Offset = "0x19")]
		public bool isMinor;

		// Token: 0x0400061E RID: 1566
		[Token(Token = "0x400061E")]
		[FieldOffset(Offset = "0x1A")]
		public bool needAuthenticate;

		// Token: 0x0400061F RID: 1567
		[Token(Token = "0x400061F")]
		[FieldOffset(Offset = "0x1B")]
		public bool isLatestUserAgreement;
	}
}
