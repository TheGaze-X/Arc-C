using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace Torappu
{
	// Token: 0x02000B76 RID: 2934
	[Token(Token = "0x2000B76")]
	public class PlayerHomeTheme
	{
		// Token: 0x06006815 RID: 26645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006815")]
		[Address(RVA = "0x1EFAE50", Offset = "0x1EF9A50", VA = "0x181EFAE50")]
		public PlayerHomeTheme()
		{
		}

		// Token: 0x04003CF5 RID: 15605
		[Token(Token = "0x4003CF5")]
		[FieldOffset(Offset = "0x10")]
		[JsonProperty(PropertyName = "selected")]
		public string selectedId;

		// Token: 0x04003CF6 RID: 15606
		[Token(Token = "0x4003CF6")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, PlayerHomeUnlockStatus> themes;
	}
}
