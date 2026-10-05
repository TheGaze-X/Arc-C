using System;
using Il2CppDummyDll;

namespace Torappu.UI.AutoChess
{
	// Token: 0x0200627E RID: 25214
	[Token(Token = "0x200627E")]
	public class AutoChessStartMatchRequest
	{
		// Token: 0x060245A1 RID: 148897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60245A1")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public AutoChessStartMatchRequest()
		{
		}

		// Token: 0x040328EA RID: 207082
		[Token(Token = "0x40328EA")]
		[FieldOffset(Offset = "0x10")]
		public string activityId;

		// Token: 0x040328EB RID: 207083
		[Token(Token = "0x40328EB")]
		[FieldOffset(Offset = "0x18")]
		public AutoChessStartMatchRequest.Option option;

		// Token: 0x0200627F RID: 25215
		[Token(Token = "0x200627F")]
		public class Option
		{
			// Token: 0x060245A2 RID: 148898 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60245A2")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Option()
			{
			}

			// Token: 0x040328EC RID: 207084
			[Token(Token = "0x40328EC")]
			[FieldOffset(Offset = "0x10")]
			public string mode;

			// Token: 0x040328ED RID: 207085
			[Token(Token = "0x40328ED")]
			[FieldOffset(Offset = "0x18")]
			public int matchType;
		}
	}
}
