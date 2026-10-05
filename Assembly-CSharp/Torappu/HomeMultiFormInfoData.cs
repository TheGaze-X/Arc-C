using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000FF9 RID: 4089
	[Token(Token = "0x2000FF9")]
	public class HomeMultiFormInfoData
	{
		// Token: 0x06006D54 RID: 27988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D54")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public HomeMultiFormInfoData()
		{
		}

		// Token: 0x040056BF RID: 22207
		[Token(Token = "0x40056BF")]
		[FieldOffset(Offset = "0x10")]
		public HomeMultiFormChangeRule changeRule;

		// Token: 0x040056C0 RID: 22208
		[Token(Token = "0x40056C0")]
		[FieldOffset(Offset = "0x18")]
		public string bgDesc;

		// Token: 0x040056C1 RID: 22209
		[Token(Token = "0x40056C1")]
		[FieldOffset(Offset = "0x20")]
		public string tmDesc;
	}
}
