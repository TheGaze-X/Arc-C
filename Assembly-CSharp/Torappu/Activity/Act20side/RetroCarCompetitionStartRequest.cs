using System;
using Il2CppDummyDll;

namespace Torappu.Activity.Act20side
{
	// Token: 0x02007634 RID: 30260
	[Token(Token = "0x2007634")]
	public class RetroCarCompetitionStartRequest
	{
		// Token: 0x0602A990 RID: 174480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A990")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RetroCarCompetitionStartRequest()
		{
		}

		// Token: 0x0403D54D RID: 251213
		[Token(Token = "0x403D54D")]
		[FieldOffset(Offset = "0x10")]
		public string retroId;

		// Token: 0x0403D54E RID: 251214
		[Token(Token = "0x403D54E")]
		[FieldOffset(Offset = "0x18")]
		public string stageId;

		// Token: 0x0403D54F RID: 251215
		[Token(Token = "0x403D54F")]
		[FieldOffset(Offset = "0x20")]
		public PlayerCartInfo.Cart car;
	}
}
