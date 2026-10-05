using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x0200122A RID: 4650
	[Token(Token = "0x200122A")]
	public class RoguelikeGameUpgradeTicketData
	{
		// Token: 0x0600702A RID: 28714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600702A")]
		[Address(RVA = "0x2111E70", Offset = "0x2110A70", VA = "0x182111E70")]
		public RoguelikeGameUpgradeTicketData()
		{
		}

		// Token: 0x0400646F RID: 25711
		[Token(Token = "0x400646F")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x04006470 RID: 25712
		[Token(Token = "0x4006470")]
		[FieldOffset(Offset = "0x18")]
		public ProfessionCategory profession;

		// Token: 0x04006471 RID: 25713
		[Token(Token = "0x4006471")]
		[FieldOffset(Offset = "0x1C")]
		public RarityRankMask rarity;

		// Token: 0x04006472 RID: 25714
		[Token(Token = "0x4006472")]
		[FieldOffset(Offset = "0x20")]
		[JsonProperty(ItemConverterType = typeof(StringEnumConverter))]
		public List<ProfessionID> professionList;

		// Token: 0x04006473 RID: 25715
		[Token(Token = "0x4006473")]
		[FieldOffset(Offset = "0x28")]
		public List<RarityRank> rarityList;
	}
}
