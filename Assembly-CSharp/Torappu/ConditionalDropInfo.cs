using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001371 RID: 4977
	[Token(Token = "0x2001371")]
	[Serializable]
	public class ConditionalDropInfo
	{
		// Token: 0x0600733C RID: 29500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600733C")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ConditionalDropInfo()
		{
		}

		// Token: 0x04006E4B RID: 28235
		[Token(Token = "0x4006E4B")]
		[FieldOffset(Offset = "0x10")]
		public string template;

		// Token: 0x04006E4C RID: 28236
		[Token(Token = "0x4006E4C")]
		[FieldOffset(Offset = "0x18")]
		public List<string> param;

		// Token: 0x04006E4D RID: 28237
		[Token(Token = "0x4006E4D")]
		[FieldOffset(Offset = "0x20")]
		public int countLimit;
	}
}
