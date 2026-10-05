using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Activity
{
	// Token: 0x02006D4E RID: 27982
	[Token(Token = "0x2006D4E")]
	public class ActivityLocalCache
	{
		// Token: 0x06027E1F RID: 163359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027E1F")]
		[Address(RVA = "0x22F1AA0", Offset = "0x22F06A0", VA = "0x1822F1AA0")]
		public ActivityLocalCache()
		{
		}

		// Token: 0x04038885 RID: 231557
		[Token(Token = "0x4038885")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, int> localIntDict;

		// Token: 0x04038886 RID: 231558
		[Token(Token = "0x4038886")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, string> localStringDict;
	}
}
