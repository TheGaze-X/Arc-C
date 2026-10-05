using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace Torappu
{
	// Token: 0x02001156 RID: 4438
	[Token(Token = "0x2001156")]
	public class RoguelikeActivityTable
	{
		// Token: 0x06006F30 RID: 28464 RVA: 0x00032568 File Offset: 0x00030768
		[Token(Token = "0x6006F30")]
		[Address(RVA = "0x2110500", Offset = "0x210F100", VA = "0x182110500")]
		public bool ShouldSerializeseedModeDict()
		{
			return default(bool);
		}

		// Token: 0x06006F31 RID: 28465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F31")]
		[Address(RVA = "0x2110540", Offset = "0x210F140", VA = "0x182110540")]
		public RoguelikeActivityTable()
		{
		}

		// Token: 0x04005F16 RID: 24342
		[Token(Token = "0x4005F16")]
		[FieldOffset(Offset = "0x10")]
		[JsonProperty("SEED_MODE")]
		public Dictionary<string, RoguelikeActivitySeedModeData> seedModeDict;
	}
}
