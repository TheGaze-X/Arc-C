using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Activity.Act24side
{
	// Token: 0x0200754B RID: 30027
	[Token(Token = "0x200754B")]
	public class Act24SideSetToolRequest
	{
		// Token: 0x0602A4CD RID: 173261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A4CD")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Act24SideSetToolRequest()
		{
		}

		// Token: 0x0403CD23 RID: 249123
		[Token(Token = "0x403CD23")]
		[FieldOffset(Offset = "0x10")]
		public string activityId;

		// Token: 0x0403CD24 RID: 249124
		[Token(Token = "0x403CD24")]
		[FieldOffset(Offset = "0x18")]
		public List<string> tools;
	}
}
