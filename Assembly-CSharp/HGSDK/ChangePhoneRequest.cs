using System;
using Il2CppDummyDll;

namespace HGSDK
{
	// Token: 0x02000150 RID: 336
	[Token(Token = "0x2000150")]
	public class ChangePhoneRequest
	{
		// Token: 0x0600050D RID: 1293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600050D")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ChangePhoneRequest()
		{
		}

		// Token: 0x04000684 RID: 1668
		[Token(Token = "0x4000684")]
		[FieldOffset(Offset = "0x10")]
		public string token;

		// Token: 0x04000685 RID: 1669
		[Token(Token = "0x4000685")]
		[FieldOffset(Offset = "0x18")]
		public string phoneCode;

		// Token: 0x04000686 RID: 1670
		[Token(Token = "0x4000686")]
		[FieldOffset(Offset = "0x20")]
		public string newPhone;

		// Token: 0x04000687 RID: 1671
		[Token(Token = "0x4000687")]
		[FieldOffset(Offset = "0x28")]
		public string newPhoneCode;
	}
}
