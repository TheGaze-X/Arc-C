using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001010 RID: 4112
	[Token(Token = "0x2001010")]
	public class GuidebookConfigData
	{
		// Token: 0x06006D65 RID: 28005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D65")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public GuidebookConfigData()
		{
		}

		// Token: 0x0400575B RID: 22363
		[Token(Token = "0x400575B")]
		[FieldOffset(Offset = "0x10")]
		public string configId;

		// Token: 0x0400575C RID: 22364
		[Token(Token = "0x400575C")]
		[FieldOffset(Offset = "0x18")]
		public int sortId;

		// Token: 0x0400575D RID: 22365
		[Token(Token = "0x400575D")]
		[FieldOffset(Offset = "0x20")]
		public List<string> pageIdList;
	}
}
