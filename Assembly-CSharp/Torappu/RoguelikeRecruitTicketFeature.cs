using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02001176 RID: 4470
	[Token(Token = "0x2001176")]
	public class RoguelikeRecruitTicketFeature
	{
		// Token: 0x06006F64 RID: 28516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F64")]
		[Address(RVA = "0x2112240", Offset = "0x2110E40", VA = "0x182112240")]
		public RoguelikeRecruitTicketFeature()
		{
		}

		// Token: 0x04005FCE RID: 24526
		[Token(Token = "0x4005FCE")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x04005FCF RID: 24527
		[Token(Token = "0x4005FCF")]
		[FieldOffset(Offset = "0x18")]
		public ProfessionCategory profession;

		// Token: 0x04005FD0 RID: 24528
		[Token(Token = "0x4005FD0")]
		[FieldOffset(Offset = "0x1C")]
		public RarityRankMask rarity;

		// Token: 0x04005FD1 RID: 24529
		[Token(Token = "0x4005FD1")]
		[FieldOffset(Offset = "0x20")]
		[JsonProperty(ItemConverterType = typeof(StringEnumConverter))]
		public List<ProfessionID> professionList;

		// Token: 0x04005FD2 RID: 24530
		[Token(Token = "0x4005FD2")]
		[FieldOffset(Offset = "0x28")]
		public List<RarityRank> rarityList;

		// Token: 0x04005FD3 RID: 24531
		[Token(Token = "0x4005FD3")]
		[FieldOffset(Offset = "0x30")]
		public int extraEliteNum;

		// Token: 0x04005FD4 RID: 24532
		[Token(Token = "0x4005FD4")]
		[FieldOffset(Offset = "0x38")]
		public List<RarityRank> extraFreeRarity;

		// Token: 0x04005FD5 RID: 24533
		[Token(Token = "0x4005FD5")]
		[FieldOffset(Offset = "0x40")]
		public List<string> extraCharIds;
	}
}
