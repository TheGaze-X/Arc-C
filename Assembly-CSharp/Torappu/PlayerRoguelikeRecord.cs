using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000AB7 RID: 2743
	[Token(Token = "0x2000AB7")]
	public class PlayerRoguelikeRecord
	{
		// Token: 0x06006774 RID: 26484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006774")]
		[Address(RVA = "0x1EFCE60", Offset = "0x1EFBA60", VA = "0x181EFCE60")]
		public PlayerRoguelikeRecord()
		{
		}

		// Token: 0x040039CD RID: 14797
		[Token(Token = "0x40039CD")]
		[FieldOffset(Offset = "0x10")]
		public int passedZone;

		// Token: 0x040039CE RID: 14798
		[Token(Token = "0x40039CE")]
		[FieldOffset(Offset = "0x14")]
		public int moveTimes;

		// Token: 0x040039CF RID: 14799
		[Token(Token = "0x40039CF")]
		[FieldOffset(Offset = "0x18")]
		public int battleNormalTimes;

		// Token: 0x040039D0 RID: 14800
		[Token(Token = "0x40039D0")]
		[FieldOffset(Offset = "0x1C")]
		public int battleEliteTimes;

		// Token: 0x040039D1 RID: 14801
		[Token(Token = "0x40039D1")]
		[FieldOffset(Offset = "0x20")]
		public int battleBossTimes;

		// Token: 0x040039D2 RID: 14802
		[Token(Token = "0x40039D2")]
		[FieldOffset(Offset = "0x24")]
		public int holdRelicCount;

		// Token: 0x040039D3 RID: 14803
		[Token(Token = "0x40039D3")]
		[FieldOffset(Offset = "0x28")]
		public int recruitChars;

		// Token: 0x040039D4 RID: 14804
		[Token(Token = "0x40039D4")]
		[FieldOffset(Offset = "0x30")]
		public string initialRelic;

		// Token: 0x040039D5 RID: 14805
		[Token(Token = "0x40039D5")]
		[FieldOffset(Offset = "0x38")]
		public int totalSeconds;

		// Token: 0x040039D6 RID: 14806
		[Token(Token = "0x40039D6")]
		[FieldOffset(Offset = "0x40")]
		public string ending;

		// Token: 0x040039D7 RID: 14807
		[Token(Token = "0x40039D7")]
		[FieldOffset(Offset = "0x48")]
		public bool isDead;

		// Token: 0x040039D8 RID: 14808
		[Token(Token = "0x40039D8")]
		[FieldOffset(Offset = "0x4C")]
		public int totalScore;

		// Token: 0x040039D9 RID: 14809
		[Token(Token = "0x40039D9")]
		[FieldOffset(Offset = "0x50")]
		public List<string> unlockRelic;

		// Token: 0x040039DA RID: 14810
		[Token(Token = "0x40039DA")]
		[FieldOffset(Offset = "0x58")]
		public List<string> unlockMode;
	}
}
