using System;
using Il2CppDummyDll;

namespace Torappu.Activity.Act20side
{
	// Token: 0x02007632 RID: 30258
	[Token(Token = "0x2007632")]
	public class CarCompetitionStartRequest
	{
		// Token: 0x0602A98E RID: 174478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A98E")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public CarCompetitionStartRequest()
		{
		}

		// Token: 0x0403D54A RID: 251210
		[Token(Token = "0x403D54A")]
		[FieldOffset(Offset = "0x10")]
		public string activityId;

		// Token: 0x0403D54B RID: 251211
		[Token(Token = "0x403D54B")]
		[FieldOffset(Offset = "0x18")]
		public string stageId;

		// Token: 0x0403D54C RID: 251212
		[Token(Token = "0x403D54C")]
		[FieldOffset(Offset = "0x20")]
		public PlayerCartInfo.Cart car;
	}
}
