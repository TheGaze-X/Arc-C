using System;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace Torappu
{
	// Token: 0x02000A17 RID: 2583
	[Token(Token = "0x2000A17")]
	public class PlayerMedalBoard
	{
		// Token: 0x060066D7 RID: 26327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066D7")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public PlayerMedalBoard()
		{
		}

		// Token: 0x040037A1 RID: 14241
		[Token(Token = "0x40037A1")]
		[FieldOffset(Offset = "0x10")]
		public NameCardMedalType type;

		// Token: 0x040037A2 RID: 14242
		[Token(Token = "0x40037A2")]
		[FieldOffset(Offset = "0x18")]
		[JsonProperty(PropertyName = "custom")]
		public string customIndex;

		// Token: 0x040037A3 RID: 14243
		[Token(Token = "0x40037A3")]
		[FieldOffset(Offset = "0x20")]
		[JsonProperty(PropertyName = "template")]
		public string templateGroupId;
	}
}
