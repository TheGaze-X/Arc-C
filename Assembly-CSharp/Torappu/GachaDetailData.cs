using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02001071 RID: 4209
	[Token(Token = "0x2001071")]
	public class GachaDetailData
	{
		// Token: 0x06006E03 RID: 28163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E03")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public GachaDetailData()
		{
		}

		// Token: 0x04005979 RID: 22905
		[Token(Token = "0x4005979")]
		[FieldOffset(Offset = "0x10")]
		public GachaDetailData.GachaAvailChar availCharInfo;

		// Token: 0x0400597A RID: 22906
		[Token(Token = "0x400597A")]
		[FieldOffset(Offset = "0x18")]
		public GachaDetailData.GachaUpChar upCharInfo;

		// Token: 0x0400597B RID: 22907
		[Token(Token = "0x400597B")]
		[FieldOffset(Offset = "0x20")]
		public List<GachaDetailData.GachaWeightUpChar> weightUpCharInfoList;

		// Token: 0x0400597C RID: 22908
		[Token(Token = "0x400597C")]
		[FieldOffset(Offset = "0x28")]
		public List<string> limitedChar;

		// Token: 0x0400597D RID: 22909
		[Token(Token = "0x400597D")]
		[FieldOffset(Offset = "0x30")]
		public List<GachaDetailData.GachaObject> gachaObjList;

		// Token: 0x02001072 RID: 4210
		[Token(Token = "0x2001072")]
		[JsonConverter(typeof(StringEnumConverter))]
		public enum GachaType
		{
			// Token: 0x0400597F RID: 22911
			[Token(Token = "0x400597F")]
			TEXT,
			// Token: 0x04005980 RID: 22912
			[Token(Token = "0x4005980")]
			UP_CHAR,
			// Token: 0x04005981 RID: 22913
			[Token(Token = "0x4005981")]
			AVAIL_CHAR,
			// Token: 0x04005982 RID: 22914
			[Token(Token = "0x4005982")]
			PICKUP_WITH_6,
			// Token: 0x04005983 RID: 22915
			[Token(Token = "0x4005983")]
			PICKUP_WITH_56,
			// Token: 0x04005984 RID: 22916
			[Token(Token = "0x4005984")]
			UP_CHAR_WITH_LIMIT,
			// Token: 0x04005985 RID: 22917
			[Token(Token = "0x4005985")]
			ATTAIN_CHAR,
			// Token: 0x04005986 RID: 22918
			[Token(Token = "0x4005986")]
			AVAIL_CHAR_WITHOUT_6,
			// Token: 0x04005987 RID: 22919
			[Token(Token = "0x4005987")]
			AVAIL_PROTRAIT_ONLY_6,
			// Token: 0x04005988 RID: 22920
			[Token(Token = "0x4005988")]
			IMAGE,
			// Token: 0x04005989 RID: 22921
			[Token(Token = "0x4005989")]
			FES_CLASSIC_CHAR,
			// Token: 0x0400598A RID: 22922
			[Token(Token = "0x400598A")]
			FES_CLASSIC_UP_CHAR,
			// Token: 0x0400598B RID: 22923
			[Token(Token = "0x400598B")]
			SPECIAL_PICKUP_CHAR,
			// Token: 0x0400598C RID: 22924
			[Token(Token = "0x400598C")]
			SPECIAL_PICKUP_SELECT_CHAR,
			// Token: 0x0400598D RID: 22925
			[Token(Token = "0x400598D")]
			SPECIAL_PICKUP_AVAIL_CHAR,
			// Token: 0x0400598E RID: 22926
			[Token(Token = "0x400598E")]
			RATE_UP_6
		}

		// Token: 0x02001073 RID: 4211
		[Token(Token = "0x2001073")]
		public enum GachaTextType
		{
			// Token: 0x04005990 RID: 22928
			[Token(Token = "0x4005990")]
			NORMAL_HIGHLIGHT,
			// Token: 0x04005991 RID: 22929
			[Token(Token = "0x4005991")]
			NORMAL_GRAY,
			// Token: 0x04005992 RID: 22930
			[Token(Token = "0x4005992")]
			NORMAL_GRAY_UP,
			// Token: 0x04005993 RID: 22931
			[Token(Token = "0x4005993")]
			NEWBEE_HIGHLIGHT,
			// Token: 0x04005994 RID: 22932
			[Token(Token = "0x4005994")]
			NEWBEE_NORMAL_TEXT,
			// Token: 0x04005995 RID: 22933
			[Token(Token = "0x4005995")]
			NORMAL_TEXT,
			// Token: 0x04005996 RID: 22934
			[Token(Token = "0x4005996")]
			ORANGE_HIGHLIGHT,
			// Token: 0x04005997 RID: 22935
			[Token(Token = "0x4005997")]
			RED_HIGHLIGHT
		}

		// Token: 0x02001074 RID: 4212
		[Token(Token = "0x2001074")]
		public enum GachaImageType
		{
			// Token: 0x04005999 RID: 22937
			[Token(Token = "0x4005999")]
			CLASSIC_SHD_RULE
		}

		// Token: 0x02001075 RID: 4213
		[Token(Token = "0x2001075")]
		public enum GachaObjGroupType
		{
			// Token: 0x0400599B RID: 22939
			[Token(Token = "0x400599B")]
			ALL,
			// Token: 0x0400599C RID: 22940
			[Token(Token = "0x400599C")]
			BEFORE_FES_CLASSIC_CHOSEN,
			// Token: 0x0400599D RID: 22941
			[Token(Token = "0x400599D")]
			AFTER_FES_CLASSIC_CHOSEN,
			// Token: 0x0400599E RID: 22942
			[Token(Token = "0x400599E")]
			BEFORE_SPECIAL_PICKUP_CHOSEN,
			// Token: 0x0400599F RID: 22943
			[Token(Token = "0x400599F")]
			AFTER_SPECIAL_PICKUP_CHOSEN
		}

		// Token: 0x02001076 RID: 4214
		[Token(Token = "0x2001076")]
		public class GachaObject
		{
			// Token: 0x06006E04 RID: 28164 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006E04")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public GachaObject()
			{
			}

			// Token: 0x040059A0 RID: 22944
			[Token(Token = "0x40059A0")]
			[FieldOffset(Offset = "0x10")]
			public GachaDetailData.GachaType gachaObject;

			// Token: 0x040059A1 RID: 22945
			[Token(Token = "0x40059A1")]
			[FieldOffset(Offset = "0x14")]
			public GachaDetailData.GachaTextType type;

			// Token: 0x040059A2 RID: 22946
			[Token(Token = "0x40059A2")]
			[FieldOffset(Offset = "0x18")]
			public GachaDetailData.GachaImageType imageType;

			// Token: 0x040059A3 RID: 22947
			[Token(Token = "0x40059A3")]
			[FieldOffset(Offset = "0x20")]
			public string param;
		}

		// Token: 0x02001077 RID: 4215
		[Token(Token = "0x2001077")]
		public class GachaUpChar
		{
			// Token: 0x06006E05 RID: 28165 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006E05")]
			[Address(RVA = "0x21051C0", Offset = "0x2103DC0", VA = "0x1821051C0")]
			public GachaUpChar()
			{
			}

			// Token: 0x040059A4 RID: 22948
			[Token(Token = "0x40059A4")]
			[FieldOffset(Offset = "0x10")]
			public List<GachaDetailData.GachaUpChar.GachaPerChar> perCharList;

			// Token: 0x02001078 RID: 4216
			[Token(Token = "0x2001078")]
			public class GachaPerChar : IComparable<GachaDetailData.GachaUpChar.GachaPerChar>
			{
				// Token: 0x06006E06 RID: 28166 RVA: 0x00031F08 File Offset: 0x00030108
				[Token(Token = "0x6006E06")]
				[Address(RVA = "0x2105110", Offset = "0x2103D10", VA = "0x182105110", Slot = "4")]
				public int CompareTo(GachaDetailData.GachaUpChar.GachaPerChar obj)
				{
					return 0;
				}

				// Token: 0x06006E07 RID: 28167 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006E07")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public GachaPerChar()
				{
				}

				// Token: 0x040059A5 RID: 22949
				[Token(Token = "0x40059A5")]
				[FieldOffset(Offset = "0x10")]
				public RarityRank rarityRank;

				// Token: 0x040059A6 RID: 22950
				[Token(Token = "0x40059A6")]
				[FieldOffset(Offset = "0x18")]
				public List<string> charIdList;

				// Token: 0x040059A7 RID: 22951
				[Token(Token = "0x40059A7")]
				[FieldOffset(Offset = "0x20")]
				public float percent;

				// Token: 0x040059A8 RID: 22952
				[Token(Token = "0x40059A8")]
				[FieldOffset(Offset = "0x24")]
				public int count;
			}
		}

		// Token: 0x02001079 RID: 4217
		[Token(Token = "0x2001079")]
		public class GachaAvailChar
		{
			// Token: 0x06006E08 RID: 28168 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006E08")]
			[Address(RVA = "0x2104C40", Offset = "0x2103840", VA = "0x182104C40")]
			public List<GachaDetailData.GachaAvailChar.GachaPerAvail> GetEqualRarityList(RarityRank rarity)
			{
				return null;
			}

			// Token: 0x06006E09 RID: 28169 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006E09")]
			[Address(RVA = "0x2104B20", Offset = "0x2103720", VA = "0x182104B20")]
			public List<GachaDetailData.GachaAvailChar.GachaPerAvail> GetBelowRarityList(RarityRank rarity)
			{
				return null;
			}

			// Token: 0x06006E0A RID: 28170 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006E0A")]
			[Address(RVA = "0x2104D60", Offset = "0x2103960", VA = "0x182104D60")]
			public GachaAvailChar()
			{
			}

			// Token: 0x040059A9 RID: 22953
			[Token(Token = "0x40059A9")]
			[FieldOffset(Offset = "0x10")]
			public List<GachaDetailData.GachaAvailChar.GachaPerAvail> perAvailList;

			// Token: 0x0200107A RID: 4218
			[Token(Token = "0x200107A")]
			public class GachaPerAvail
			{
				// Token: 0x06006E0B RID: 28171 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006E0B")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public GachaPerAvail()
				{
				}

				// Token: 0x040059AA RID: 22954
				[Token(Token = "0x40059AA")]
				[FieldOffset(Offset = "0x10")]
				public RarityRank rarityRank;

				// Token: 0x040059AB RID: 22955
				[Token(Token = "0x40059AB")]
				[FieldOffset(Offset = "0x18")]
				public List<string> charIdList;

				// Token: 0x040059AC RID: 22956
				[Token(Token = "0x40059AC")]
				[FieldOffset(Offset = "0x20")]
				public float totalPercent;
			}
		}

		// Token: 0x0200107B RID: 4219
		[Token(Token = "0x200107B")]
		public class GachaWeightUpChar
		{
			// Token: 0x06006E0C RID: 28172 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006E0C")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public GachaWeightUpChar()
			{
			}

			// Token: 0x040059AD RID: 22957
			[Token(Token = "0x40059AD")]
			[FieldOffset(Offset = "0x10")]
			public RarityRank rarityRank;

			// Token: 0x040059AE RID: 22958
			[Token(Token = "0x40059AE")]
			[FieldOffset(Offset = "0x18")]
			public string charId;

			// Token: 0x040059AF RID: 22959
			[Token(Token = "0x40059AF")]
			[FieldOffset(Offset = "0x20")]
			public int weight;
		}

		// Token: 0x0200107C RID: 4220
		[Token(Token = "0x200107C")]
		public class GachaDetailText
		{
			// Token: 0x06006E0D RID: 28173 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006E0D")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public GachaDetailText()
			{
			}

			// Token: 0x040059B0 RID: 22960
			[Token(Token = "0x40059B0")]
			[FieldOffset(Offset = "0x10")]
			public int type;

			// Token: 0x040059B1 RID: 22961
			[Token(Token = "0x40059B1")]
			[FieldOffset(Offset = "0x18")]
			public string title;

			// Token: 0x040059B2 RID: 22962
			[Token(Token = "0x40059B2")]
			[FieldOffset(Offset = "0x20")]
			public string text;
		}
	}
}
