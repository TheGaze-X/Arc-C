using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI
{
	// Token: 0x02003B11 RID: 15121
	[Token(Token = "0x2003B11")]
	public class RoguelikeUnlockChallengePushMsg
	{
		// Token: 0x06017CFF RID: 97535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017CFF")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RoguelikeUnlockChallengePushMsg()
		{
		}

		// Token: 0x0401CC33 RID: 117811
		[Token(Token = "0x401CC33")]
		[FieldOffset(Offset = "0x10")]
		public string topicId;

		// Token: 0x0401CC34 RID: 117812
		[Token(Token = "0x401CC34")]
		[FieldOffset(Offset = "0x18")]
		public List<string> unlockChallengesList;
	}
}
