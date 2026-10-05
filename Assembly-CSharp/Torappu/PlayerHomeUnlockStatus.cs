using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace Torappu
{
	// Token: 0x02000B73 RID: 2931
	[Token(Token = "0x2000B73")]
	public class PlayerHomeUnlockStatus
	{
		// Token: 0x06006811 RID: 26641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006811")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public PlayerHomeUnlockStatus()
		{
		}

		// Token: 0x04003CEE RID: 15598
		[Token(Token = "0x4003CEE")]
		[FieldOffset(Offset = "0x10")]
		[JsonProperty(PropertyName = "unlock")]
		public long unlockTime;

		// Token: 0x04003CEF RID: 15599
		[Token(Token = "0x4003CEF")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, PlayerHomeConditionProgress> conditions;
	}
}
