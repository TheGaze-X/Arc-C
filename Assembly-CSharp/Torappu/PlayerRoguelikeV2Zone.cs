using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace Torappu
{
	// Token: 0x02000B1C RID: 2844
	[Token(Token = "0x2000B1C")]
	public class PlayerRoguelikeV2Zone
	{
		// Token: 0x060067CD RID: 26573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60067CD")]
		[Address(RVA = "0x1EFD080", Offset = "0x1EFBC80", VA = "0x181EFD080")]
		public PlayerRoguelikeV2Zone()
		{
		}

		// Token: 0x04003B75 RID: 15221
		[Token(Token = "0x4003B75")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x04003B76 RID: 15222
		[Token(Token = "0x4003B76")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<int, PlayerRoguelikeNode> nodes;

		// Token: 0x04003B77 RID: 15223
		[Token(Token = "0x4003B77")]
		[FieldOffset(Offset = "0x20")]
		public List<string> variation;

		// Token: 0x04003B78 RID: 15224
		[Token(Token = "0x4003B78")]
		[FieldOffset(Offset = "0x28")]
		[JsonProperty(PropertyName = "type")]
		public PlayerRoguelikeZoneType zoneType;
	}
}
