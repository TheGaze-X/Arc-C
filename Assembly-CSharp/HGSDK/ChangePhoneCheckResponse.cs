using System;
using Il2CppDummyDll;

namespace HGSDK
{
	// Token: 0x0200014F RID: 335
	[Token(Token = "0x200014F")]
	public class ChangePhoneCheckResponse
	{
		// Token: 0x0600050C RID: 1292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600050C")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ChangePhoneCheckResponse()
		{
		}

		// Token: 0x04000682 RID: 1666
		[Token(Token = "0x4000682")]
		[FieldOffset(Offset = "0x10")]
		public int result;

		// Token: 0x04000683 RID: 1667
		[Token(Token = "0x4000683")]
		[FieldOffset(Offset = "0x18")]
		public string errMsg;
	}
}
