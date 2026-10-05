using System;
using Il2CppDummyDll;
using Torappu.Resource;

namespace Torappu.UI
{
	// Token: 0x020036C3 RID: 14019
	[Token(Token = "0x20036C3")]
	[Serializable]
	public class LanFonts
	{
		// Token: 0x06016474 RID: 91252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016474")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public LanFonts()
		{
		}

		// Token: 0x0401ACB8 RID: 109752
		[Token(Token = "0x401ACB8")]
		[FieldOffset(Offset = "0x10")]
		public ResourceOptions.ResLanguage lan;

		// Token: 0x0401ACB9 RID: 109753
		[Token(Token = "0x401ACB9")]
		[FieldOffset(Offset = "0x18")]
		public string[] fontGUIDs;
	}
}
