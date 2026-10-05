using System;
using Il2CppDummyDll;

namespace YoStar.SDK
{
	// Token: 0x02000072 RID: 114
	[Token(Token = "0x2000072")]
	public class SwitchServerRet
	{
		// Token: 0x0600024C RID: 588 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600024C")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SwitchServerRet()
		{
		}

		// Token: 0x04000203 RID: 515
		[Token(Token = "0x4000203")]
		[FieldOffset(Offset = "0x10")]
		public int R_CODE;

		// Token: 0x04000204 RID: 516
		[Token(Token = "0x4000204")]
		[FieldOffset(Offset = "0x18")]
		public string R_MSG;
	}
}
