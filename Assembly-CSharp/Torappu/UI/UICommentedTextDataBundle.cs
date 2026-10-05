using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI
{
	// Token: 0x020039DF RID: 14815
	[Token(Token = "0x20039DF")]
	public class UICommentedTextDataBundle
	{
		// Token: 0x06017669 RID: 95849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017669")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public UICommentedTextDataBundle()
		{
		}

		// Token: 0x0401C433 RID: 115763
		[Token(Token = "0x401C433")]
		[FieldOffset(Offset = "0x10")]
		public string textContent;

		// Token: 0x0401C434 RID: 115764
		[Token(Token = "0x401C434")]
		[FieldOffset(Offset = "0x18")]
		public List<UICommentedTextData> tagList;
	}
}
