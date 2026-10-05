using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02000CB9 RID: 3257
	[Token(Token = "0x2000CB9")]
	public class CartComponents
	{
		// Token: 0x0600699A RID: 27034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600699A")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public CartComponents()
		{
		}

		// Token: 0x0400427E RID: 17022
		[Token(Token = "0x400427E")]
		[FieldOffset(Offset = "0x10")]
		public string compId;

		// Token: 0x0400427F RID: 17023
		[Token(Token = "0x400427F")]
		[FieldOffset(Offset = "0x18")]
		public int sortId;

		// Token: 0x04004280 RID: 17024
		[Token(Token = "0x4004280")]
		[FieldOffset(Offset = "0x1C")]
		public CartComponents.CartAccessoryType type;

		// Token: 0x04004281 RID: 17025
		[Token(Token = "0x4004281")]
		[FieldOffset(Offset = "0x20")]
		public List<CartComponents.CartAccessoryPos> posList;

		// Token: 0x04004282 RID: 17026
		[Token(Token = "0x4004282")]
		[FieldOffset(Offset = "0x28")]
		public ListDict<CartComponents.CartAccessoryPos, List<string>> posIdDict;

		// Token: 0x04004283 RID: 17027
		[Token(Token = "0x4004283")]
		[FieldOffset(Offset = "0x30")]
		public string name;

		// Token: 0x04004284 RID: 17028
		[Token(Token = "0x4004284")]
		[FieldOffset(Offset = "0x38")]
		public string icon;

		// Token: 0x04004285 RID: 17029
		[Token(Token = "0x4004285")]
		[FieldOffset(Offset = "0x40")]
		public int showScores;

		// Token: 0x04004286 RID: 17030
		[Token(Token = "0x4004286")]
		[FieldOffset(Offset = "0x48")]
		public string itemUsage;

		// Token: 0x04004287 RID: 17031
		[Token(Token = "0x4004287")]
		[FieldOffset(Offset = "0x50")]
		public string itemDesc;

		// Token: 0x04004288 RID: 17032
		[Token(Token = "0x4004288")]
		[FieldOffset(Offset = "0x58")]
		public string itemObtain;

		// Token: 0x04004289 RID: 17033
		[Token(Token = "0x4004289")]
		[FieldOffset(Offset = "0x60")]
		public int rarity;

		// Token: 0x0400428A RID: 17034
		[Token(Token = "0x400428A")]
		[FieldOffset(Offset = "0x68")]
		public string detailDesc;

		// Token: 0x0400428B RID: 17035
		[Token(Token = "0x400428B")]
		[FieldOffset(Offset = "0x70")]
		public int price;

		// Token: 0x0400428C RID: 17036
		[Token(Token = "0x400428C")]
		[FieldOffset(Offset = "0x78")]
		public string specialObtain;

		// Token: 0x0400428D RID: 17037
		[Token(Token = "0x400428D")]
		[FieldOffset(Offset = "0x80")]
		public bool obtainInRandom;

		// Token: 0x0400428E RID: 17038
		[Token(Token = "0x400428E")]
		[FieldOffset(Offset = "0x88")]
		public string additiveColor;

		// Token: 0x02000CBA RID: 3258
		[Token(Token = "0x2000CBA")]
		[JsonConverter(typeof(StringEnumConverter))]
		public enum CartAccessoryType
		{
			// Token: 0x04004290 RID: 17040
			[Token(Token = "0x4004290")]
			NONE,
			// Token: 0x04004291 RID: 17041
			[Token(Token = "0x4004291")]
			ROOF,
			// Token: 0x04004292 RID: 17042
			[Token(Token = "0x4004292")]
			HEADSTOCK,
			// Token: 0x04004293 RID: 17043
			[Token(Token = "0x4004293")]
			TRUNK,
			// Token: 0x04004294 RID: 17044
			[Token(Token = "0x4004294")]
			CAR_OS
		}

		// Token: 0x02000CBB RID: 3259
		[Token(Token = "0x2000CBB")]
		[JsonConverter(typeof(StringEnumConverter))]
		[Serializable]
		public enum CartAccessoryPos
		{
			// Token: 0x04004296 RID: 17046
			[Token(Token = "0x4004296")]
			NONE,
			// Token: 0x04004297 RID: 17047
			[Token(Token = "0x4004297")]
			ROOF,
			// Token: 0x04004298 RID: 17048
			[Token(Token = "0x4004298")]
			HEADSTOCK,
			// Token: 0x04004299 RID: 17049
			[Token(Token = "0x4004299")]
			TRUNK_01,
			// Token: 0x0400429A RID: 17050
			[Token(Token = "0x400429A")]
			TRUNK_02,
			// Token: 0x0400429B RID: 17051
			[Token(Token = "0x400429B")]
			CAR_OS_01,
			// Token: 0x0400429C RID: 17052
			[Token(Token = "0x400429C")]
			CAR_OS_02
		}
	}
}
