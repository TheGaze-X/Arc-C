using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace Torappu
{
	// Token: 0x02000AA2 RID: 2722
	[Token(Token = "0x2000AA2")]
	public class PlayerRecalRuneStage
	{
		// Token: 0x06006763 RID: 26467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006763")]
		[Address(RVA = "0x1EFC320", Offset = "0x1EFAF20", VA = "0x181EFC320")]
		public PlayerRecalRuneStage()
		{
		}

		// Token: 0x0400396F RID: 14703
		[Token(Token = "0x400396F")]
		[FieldOffset(Offset = "0x10")]
		public PlayerRecalRuneStage.State state;

		// Token: 0x04003970 RID: 14704
		[Token(Token = "0x4003970")]
		[FieldOffset(Offset = "0x14")]
		public int record;

		// Token: 0x04003971 RID: 14705
		[Token(Token = "0x4003971")]
		[FieldOffset(Offset = "0x18")]
		[JsonProperty(PropertyName = "runes")]
		public List<string> passedRunes;

		// Token: 0x02000AA3 RID: 2723
		[Token(Token = "0x2000AA3")]
		public enum State
		{
			// Token: 0x04003973 RID: 14707
			[Token(Token = "0x4003973")]
			NO_PASS,
			// Token: 0x04003974 RID: 14708
			[Token(Token = "0x4003974")]
			PASSED
		}
	}
}
