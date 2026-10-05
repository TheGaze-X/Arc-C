using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x0200122E RID: 4654
	[Token(Token = "0x200122E")]
	public class RoguelikeGameRelicParamData
	{
		// Token: 0x0600702D RID: 28717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600702D")]
		[Address(RVA = "0x2111BD0", Offset = "0x21107D0", VA = "0x182111BD0")]
		public RoguelikeGameRelicParamData()
		{
		}

		// Token: 0x0400647D RID: 25725
		[Token(Token = "0x400647D")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x0400647E RID: 25726
		[Token(Token = "0x400647E")]
		[FieldOffset(Offset = "0x18")]
		[JsonProperty(ItemConverterType = typeof(StringEnumConverter))]
		public List<RoguelikeGameRelicCheckType> checkCharBoxTypes;

		// Token: 0x0400647F RID: 25727
		[Token(Token = "0x400647F")]
		[FieldOffset(Offset = "0x20")]
		public List<RoguelikeGameRelicCheckParam> checkCharBoxParams;
	}
}
