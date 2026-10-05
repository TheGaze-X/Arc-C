using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02000AAC RID: 2732
	[Token(Token = "0x2000AAC")]
	public class PlayerRoguelikeCursor
	{
		// Token: 0x0600676A RID: 26474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600676A")]
		[Address(RVA = "0x1EFC930", Offset = "0x1EFB530", VA = "0x181EFC930")]
		public PlayerRoguelikeCursor()
		{
		}

		// Token: 0x04003992 RID: 14738
		[Token(Token = "0x4003992")]
		[FieldOffset(Offset = "0x10")]
		public int zoneIndex;

		// Token: 0x04003993 RID: 14739
		[Token(Token = "0x4003993")]
		[FieldOffset(Offset = "0x18")]
		public RoguelikeNodePosition position;

		// Token: 0x04003994 RID: 14740
		[Token(Token = "0x4003994")]
		[FieldOffset(Offset = "0x20")]
		[JsonConverter(typeof(StringEnumConverter))]
		public PlayerRoguelikeState state;
	}
}
