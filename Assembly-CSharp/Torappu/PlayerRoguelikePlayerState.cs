using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02000B19 RID: 2841
	[Token(Token = "0x2000B19")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum PlayerRoguelikePlayerState
	{
		// Token: 0x04003B6B RID: 15211
		[Token(Token = "0x4003B6B")]
		NONE,
		// Token: 0x04003B6C RID: 15212
		[Token(Token = "0x4003B6C")]
		INIT,
		// Token: 0x04003B6D RID: 15213
		[Token(Token = "0x4003B6D")]
		PENDING,
		// Token: 0x04003B6E RID: 15214
		[Token(Token = "0x4003B6E")]
		WAIT_MOVE
	}
}
