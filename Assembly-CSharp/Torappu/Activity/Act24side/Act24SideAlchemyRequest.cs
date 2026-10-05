using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Activity.Act24side
{
	// Token: 0x0200754D RID: 30029
	[Token(Token = "0x200754D")]
	public class Act24SideAlchemyRequest
	{
		// Token: 0x0602A4CF RID: 173263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A4CF")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Act24SideAlchemyRequest()
		{
		}

		// Token: 0x0403CD25 RID: 249125
		[Token(Token = "0x403CD25")]
		[FieldOffset(Offset = "0x10")]
		public string activityId;

		// Token: 0x0403CD26 RID: 249126
		[Token(Token = "0x403CD26")]
		[FieldOffset(Offset = "0x18")]
		public string gachaBox;

		// Token: 0x0403CD27 RID: 249127
		[Token(Token = "0x403CD27")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<string, int> items;
	}
}
