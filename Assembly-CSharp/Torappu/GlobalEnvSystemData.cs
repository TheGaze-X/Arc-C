using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001263 RID: 4707
	[Token(Token = "0x2001263")]
	[Serializable]
	public class GlobalEnvSystemData
	{
		// Token: 0x060071E2 RID: 29154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071E2")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public GlobalEnvSystemData()
		{
		}

		// Token: 0x040067DD RID: 26589
		[Token(Token = "0x40067DD")]
		[FieldOffset(Offset = "0x10")]
		public string prefabKey;

		// Token: 0x040067DE RID: 26590
		[Token(Token = "0x40067DE")]
		[FieldOffset(Offset = "0x18")]
		public Blackboard blackboard;
	}
}
