using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02000816 RID: 2070
	[Token(Token = "0x2000816")]
	public class RoguelikeDiceChoiceRequest
	{
		// Token: 0x060064A6 RID: 25766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064A6")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RoguelikeDiceChoiceRequest()
		{
		}

		// Token: 0x04003125 RID: 12581
		[Token(Token = "0x4003125")]
		[FieldOffset(Offset = "0x10")]
		public RoguelikeDiceChoiceRequest.Choice choice;

		// Token: 0x02000817 RID: 2071
		[Token(Token = "0x2000817")]
		[JsonConverter(typeof(StringEnumConverter))]
		public enum Choice
		{
			// Token: 0x04003127 RID: 12583
			[Token(Token = "0x4003127")]
			REROLL,
			// Token: 0x04003128 RID: 12584
			[Token(Token = "0x4003128")]
			LEAVE
		}
	}
}
