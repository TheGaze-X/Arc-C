using System;
using Il2CppDummyDll;

namespace HGSDK
{
	// Token: 0x02000151 RID: 337
	[Token(Token = "0x2000151")]
	public class ChangePhoneResponse
	{
		// Token: 0x0600050E RID: 1294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600050E")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ChangePhoneResponse()
		{
		}

		// Token: 0x04000688 RID: 1672
		[Token(Token = "0x4000688")]
		[FieldOffset(Offset = "0x10")]
		public int result;

		// Token: 0x04000689 RID: 1673
		[Token(Token = "0x4000689")]
		[FieldOffset(Offset = "0x18")]
		public string errMsg;
	}
}
