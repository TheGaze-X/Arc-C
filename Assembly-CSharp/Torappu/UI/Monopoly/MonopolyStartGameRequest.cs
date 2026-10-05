using System;
using Il2CppDummyDll;

namespace Torappu.UI.Monopoly
{
	// Token: 0x0200482A RID: 18474
	[Token(Token = "0x200482A")]
	public class MonopolyStartGameRequest
	{
		// Token: 0x0601BEC5 RID: 114373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BEC5")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public MonopolyStartGameRequest()
		{
		}

		// Token: 0x04024678 RID: 149112
		[Token(Token = "0x4024678")]
		[FieldOffset(Offset = "0x10")]
		public string activityId;

		// Token: 0x04024679 RID: 149113
		[Token(Token = "0x4024679")]
		[FieldOffset(Offset = "0x18")]
		public string stageId;
	}
}
