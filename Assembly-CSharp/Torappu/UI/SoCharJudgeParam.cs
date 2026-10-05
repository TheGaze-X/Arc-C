using System;
using Il2CppDummyDll;

namespace Torappu.UI
{
	// Token: 0x02003ADA RID: 15066
	[Token(Token = "0x2003ADA")]
	public class SoCharJudgeParam
	{
		// Token: 0x06017C0C RID: 97292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017C0C")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SoCharJudgeParam()
		{
		}

		// Token: 0x0401CAEF RID: 117487
		[Token(Token = "0x401CAEF")]
		[FieldOffset(Offset = "0x10")]
		public int maxLv;

		// Token: 0x0401CAF0 RID: 117488
		[Token(Token = "0x401CAF0")]
		[FieldOffset(Offset = "0x18")]
		public Action onConfirm;
	}
}
