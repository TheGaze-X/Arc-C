using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02001177 RID: 4471
	[Token(Token = "0x2001177")]
	public class RoguelikeUpgradeTicketFeature
	{
		// Token: 0x06006F65 RID: 28517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F65")]
		[Address(RVA = "0x2114820", Offset = "0x2113420", VA = "0x182114820")]
		public RoguelikeUpgradeTicketFeature()
		{
		}

		// Token: 0x04005FD6 RID: 24534
		[Token(Token = "0x4005FD6")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x04005FD7 RID: 24535
		[Token(Token = "0x4005FD7")]
		[FieldOffset(Offset = "0x18")]
		public ProfessionCategory profession;

		// Token: 0x04005FD8 RID: 24536
		[Token(Token = "0x4005FD8")]
		[FieldOffset(Offset = "0x1C")]
		public RarityRankMask rarity;

		// Token: 0x04005FD9 RID: 24537
		[Token(Token = "0x4005FD9")]
		[FieldOffset(Offset = "0x20")]
		[JsonProperty(ItemConverterType = typeof(StringEnumConverter))]
		public List<ProfessionID> professionList;

		// Token: 0x04005FDA RID: 24538
		[Token(Token = "0x4005FDA")]
		[FieldOffset(Offset = "0x28")]
		public List<RarityRank> rarityList;
	}
}
