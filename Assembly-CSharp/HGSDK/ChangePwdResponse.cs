using System;
using Il2CppDummyDll;

namespace HGSDK
{
	// Token: 0x0200014D RID: 333
	[Token(Token = "0x200014D")]
	public class ChangePwdResponse
	{
		// Token: 0x0600050A RID: 1290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600050A")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ChangePwdResponse()
		{
		}

		// Token: 0x0400067F RID: 1663
		[Token(Token = "0x400067F")]
		[FieldOffset(Offset = "0x10")]
		public int result;

		// Token: 0x04000680 RID: 1664
		[Token(Token = "0x4000680")]
		[FieldOffset(Offset = "0x18")]
		public string errMsg;
	}
}
