using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x0200105C RID: 4188
	[Token(Token = "0x200105C")]
	[Serializable]
	public class GachaPoolData
	{
		// Token: 0x06006DE3 RID: 28131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DE3")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public GachaPoolData()
		{
		}

		// Token: 0x04005917 RID: 22807
		[Token(Token = "0x4005917")]
		[FieldOffset(Offset = "0x10")]
		public string gachaPoolId;

		// Token: 0x04005918 RID: 22808
		[Token(Token = "0x4005918")]
		[FieldOffset(Offset = "0x18")]
		public GachaPoolData.GachaPoolItem[] gachaPoolItems;

		// Token: 0x04005919 RID: 22809
		[Token(Token = "0x4005919")]
		[FieldOffset(Offset = "0x20")]
		public GachaPoolData.GachaPoolConstants gachaPoolConstants;

		// Token: 0x0200105D RID: 4189
		[Token(Token = "0x200105D")]
		public class GachaPoolItem
		{
			// Token: 0x06006DE4 RID: 28132 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006DE4")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public GachaPoolItem()
			{
			}

			// Token: 0x0400591A RID: 22810
			[Token(Token = "0x400591A")]
			[FieldOffset(Offset = "0x10")]
			public string charId;

			// Token: 0x0400591B RID: 22811
			[Token(Token = "0x400591B")]
			[FieldOffset(Offset = "0x18")]
			public string charName;

			// Token: 0x0400591C RID: 22812
			[Token(Token = "0x400591C")]
			[FieldOffset(Offset = "0x20")]
			[JsonConverter(typeof(StringEnumConverter))]
			public RarityRank rarity;

			// Token: 0x0400591D RID: 22813
			[Token(Token = "0x400591D")]
			[FieldOffset(Offset = "0x28")]
			public string professionName;

			// Token: 0x0400591E RID: 22814
			[Token(Token = "0x400591E")]
			[FieldOffset(Offset = "0x30")]
			public int weight;

			// Token: 0x0400591F RID: 22815
			[Token(Token = "0x400591F")]
			[FieldOffset(Offset = "0x34")]
			public float dedicatedRate;

			// Token: 0x04005920 RID: 22816
			[Token(Token = "0x4005920")]
			[FieldOffset(Offset = "0x38")]
			public float rateLockRatio;

			// Token: 0x04005921 RID: 22817
			[Token(Token = "0x4005921")]
			[FieldOffset(Offset = "0x3C")]
			public float computedRate;
		}

		// Token: 0x0200105E RID: 4190
		[Token(Token = "0x200105E")]
		[Serializable]
		public class GachaPoolConstants
		{
			// Token: 0x06006DE5 RID: 28133 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006DE5")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public GachaPoolConstants()
			{
			}

			// Token: 0x04005922 RID: 22818
			[Token(Token = "0x4005922")]
			[FieldOffset(Offset = "0x10")]
			public Dictionary<int, float> baseRarityRate;
		}
	}
}
