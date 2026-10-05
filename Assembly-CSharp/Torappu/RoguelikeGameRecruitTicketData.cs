using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02001229 RID: 4649
	[Token(Token = "0x2001229")]
	public class RoguelikeGameRecruitTicketData
	{
		// Token: 0x06007029 RID: 28713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007029")]
		[Address(RVA = "0x2111A80", Offset = "0x2110680", VA = "0x182111A80")]
		public RoguelikeGameRecruitTicketData()
		{
		}

		// Token: 0x04006467 RID: 25703
		[Token(Token = "0x4006467")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x04006468 RID: 25704
		[Token(Token = "0x4006468")]
		[FieldOffset(Offset = "0x18")]
		public ProfessionCategory profession;

		// Token: 0x04006469 RID: 25705
		[Token(Token = "0x4006469")]
		[FieldOffset(Offset = "0x1C")]
		public RarityRankMask rarity;

		// Token: 0x0400646A RID: 25706
		[Token(Token = "0x400646A")]
		[FieldOffset(Offset = "0x20")]
		[JsonProperty(ItemConverterType = typeof(StringEnumConverter))]
		public List<ProfessionID> professionList;

		// Token: 0x0400646B RID: 25707
		[Token(Token = "0x400646B")]
		[FieldOffset(Offset = "0x28")]
		public List<RarityRank> rarityList;

		// Token: 0x0400646C RID: 25708
		[Token(Token = "0x400646C")]
		[FieldOffset(Offset = "0x30")]
		public int extraEliteNum;

		// Token: 0x0400646D RID: 25709
		[Token(Token = "0x400646D")]
		[FieldOffset(Offset = "0x38")]
		public List<RarityRank> extraFreeRarity;

		// Token: 0x0400646E RID: 25710
		[Token(Token = "0x400646E")]
		[FieldOffset(Offset = "0x40")]
		public List<string> extraCharIds;
	}
}
