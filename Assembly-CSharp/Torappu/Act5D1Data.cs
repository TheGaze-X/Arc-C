using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02000D71 RID: 3441
	[Token(Token = "0x2000D71")]
	public class Act5D1Data
	{
		// Token: 0x06006A42 RID: 27202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A42")]
		[Address(RVA = "0x1FF7680", Offset = "0x1FF6280", VA = "0x181FF7680")]
		public Act5D1Data()
		{
		}

		// Token: 0x040046CA RID: 18122
		[Token(Token = "0x40046CA")]
		[FieldOffset(Offset = "0x10")]
		public List<Act5D1Data.RuneStageData> stageCommonData;

		// Token: 0x040046CB RID: 18123
		[Token(Token = "0x40046CB")]
		[FieldOffset(Offset = "0x18")]
		public List<Act5D1Data.RuneRecurrentStateData> runeStageData;

		// Token: 0x040046CC RID: 18124
		[Token(Token = "0x40046CC")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<string, List<Act5D1Data.RuneUnlockData>> runeUnlockDict;

		// Token: 0x040046CD RID: 18125
		[Token(Token = "0x40046CD")]
		[FieldOffset(Offset = "0x28")]
		public List<Act5D1Data.RuneReleaseData> runeReleaseData;

		// Token: 0x040046CE RID: 18126
		[Token(Token = "0x40046CE")]
		[FieldOffset(Offset = "0x30")]
		public List<MissionData> missionData;

		// Token: 0x040046CF RID: 18127
		[Token(Token = "0x40046CF")]
		[FieldOffset(Offset = "0x38")]
		public List<MissionGroup> missionGroup;

		// Token: 0x040046D0 RID: 18128
		[Token(Token = "0x40046D0")]
		[FieldOffset(Offset = "0x40")]
		public Dictionary<string, bool> useBenefitMissionDict;

		// Token: 0x040046D1 RID: 18129
		[Token(Token = "0x40046D1")]
		[FieldOffset(Offset = "0x48")]
		public Act5D1Data.ShopData shopData;

		// Token: 0x040046D2 RID: 18130
		[Token(Token = "0x40046D2")]
		[FieldOffset(Offset = "0x50")]
		public string coinItemId;

		// Token: 0x040046D3 RID: 18131
		[Token(Token = "0x40046D3")]
		[FieldOffset(Offset = "0x58")]
		public string ptItemId;

		// Token: 0x040046D4 RID: 18132
		[Token(Token = "0x40046D4")]
		[FieldOffset(Offset = "0x60")]
		public List<RuneTable.RuneStageExtraData> stageRune;

		// Token: 0x040046D5 RID: 18133
		[Token(Token = "0x40046D5")]
		[FieldOffset(Offset = "0x68")]
		public List<string> showRuneMissionList;

		// Token: 0x02000D72 RID: 3442
		[Token(Token = "0x2000D72")]
		public class RewardGroup
		{
			// Token: 0x06006A43 RID: 27203 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A43")]
			[Address(RVA = "0x200CAA0", Offset = "0x200B6A0", VA = "0x18200CAA0")]
			public RewardGroup()
			{
			}

			// Token: 0x040046D6 RID: 18134
			[Token(Token = "0x40046D6")]
			[FieldOffset(Offset = "0x10")]
			public Dictionary<int, List<ItemBundle>> itemList;
		}

		// Token: 0x02000D73 RID: 3443
		[Token(Token = "0x2000D73")]
		public class RuneStageData
		{
			// Token: 0x06006A44 RID: 27204 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A44")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public RuneStageData()
			{
			}

			// Token: 0x040046D7 RID: 18135
			[Token(Token = "0x40046D7")]
			[FieldOffset(Offset = "0x10")]
			public string stageId;

			// Token: 0x040046D8 RID: 18136
			[Token(Token = "0x40046D8")]
			[FieldOffset(Offset = "0x18")]
			public string levelId;

			// Token: 0x040046D9 RID: 18137
			[Token(Token = "0x40046D9")]
			[FieldOffset(Offset = "0x20")]
			public string code;

			// Token: 0x040046DA RID: 18138
			[Token(Token = "0x40046DA")]
			[FieldOffset(Offset = "0x28")]
			public string name;

			// Token: 0x040046DB RID: 18139
			[Token(Token = "0x40046DB")]
			[FieldOffset(Offset = "0x30")]
			public string loadingPicId;

			// Token: 0x040046DC RID: 18140
			[Token(Token = "0x40046DC")]
			[FieldOffset(Offset = "0x38")]
			public string description;

			// Token: 0x040046DD RID: 18141
			[Token(Token = "0x40046DD")]
			[FieldOffset(Offset = "0x40")]
			public string picId;
		}

		// Token: 0x02000D74 RID: 3444
		[Token(Token = "0x2000D74")]
		public class RuneRecurrentStateData
		{
			// Token: 0x06006A45 RID: 27205 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A45")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public RuneRecurrentStateData()
			{
			}

			// Token: 0x040046DE RID: 18142
			[Token(Token = "0x40046DE")]
			[FieldOffset(Offset = "0x10")]
			public string runeReId;

			// Token: 0x040046DF RID: 18143
			[Token(Token = "0x40046DF")]
			[FieldOffset(Offset = "0x18")]
			public string stageId;

			// Token: 0x040046E0 RID: 18144
			[Token(Token = "0x40046E0")]
			[FieldOffset(Offset = "0x20")]
			public int slotId;

			// Token: 0x040046E1 RID: 18145
			[Token(Token = "0x40046E1")]
			[FieldOffset(Offset = "0x28")]
			public long startTime;

			// Token: 0x040046E2 RID: 18146
			[Token(Token = "0x40046E2")]
			[FieldOffset(Offset = "0x30")]
			public long endTime;

			// Token: 0x040046E3 RID: 18147
			[Token(Token = "0x40046E3")]
			[FieldOffset(Offset = "0x38")]
			public List<string> runeList;

			// Token: 0x040046E4 RID: 18148
			[Token(Token = "0x40046E4")]
			[FieldOffset(Offset = "0x40")]
			public bool isAvail;

			// Token: 0x040046E5 RID: 18149
			[Token(Token = "0x40046E5")]
			[FieldOffset(Offset = "0x44")]
			public int warningPoint;
		}

		// Token: 0x02000D75 RID: 3445
		[Token(Token = "0x2000D75")]
		public class RuneUnlockData
		{
			// Token: 0x06006A46 RID: 27206 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A46")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public RuneUnlockData()
			{
			}

			// Token: 0x040046E6 RID: 18150
			[Token(Token = "0x40046E6")]
			[FieldOffset(Offset = "0x10")]
			public string runeId;

			// Token: 0x040046E7 RID: 18151
			[Token(Token = "0x40046E7")]
			[FieldOffset(Offset = "0x18")]
			public ItemBundle priceItem;

			// Token: 0x040046E8 RID: 18152
			[Token(Token = "0x40046E8")]
			[FieldOffset(Offset = "0x20")]
			public string runeName;

			// Token: 0x040046E9 RID: 18153
			[Token(Token = "0x40046E9")]
			[FieldOffset(Offset = "0x28")]
			public string bgPic;

			// Token: 0x040046EA RID: 18154
			[Token(Token = "0x40046EA")]
			[FieldOffset(Offset = "0x30")]
			public string runeDesc;

			// Token: 0x040046EB RID: 18155
			[Token(Token = "0x40046EB")]
			[FieldOffset(Offset = "0x38")]
			public int sortId;

			// Token: 0x040046EC RID: 18156
			[Token(Token = "0x40046EC")]
			[FieldOffset(Offset = "0x40")]
			public string iconId;
		}

		// Token: 0x02000D76 RID: 3446
		[Token(Token = "0x2000D76")]
		public class RuneReleaseData
		{
			// Token: 0x06006A47 RID: 27207 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A47")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public RuneReleaseData()
			{
			}

			// Token: 0x040046ED RID: 18157
			[Token(Token = "0x40046ED")]
			[FieldOffset(Offset = "0x10")]
			public string runeId;

			// Token: 0x040046EE RID: 18158
			[Token(Token = "0x40046EE")]
			[FieldOffset(Offset = "0x18")]
			public string stageId;

			// Token: 0x040046EF RID: 18159
			[Token(Token = "0x40046EF")]
			[FieldOffset(Offset = "0x20")]
			public long releaseTime;
		}

		// Token: 0x02000D77 RID: 3447
		[Token(Token = "0x2000D77")]
		public enum GoodType
		{
			// Token: 0x040046F1 RID: 18161
			[Token(Token = "0x40046F1")]
			NORMAL,
			// Token: 0x040046F2 RID: 18162
			[Token(Token = "0x40046F2")]
			PROGRESS
		}

		// Token: 0x02000D78 RID: 3448
		[Token(Token = "0x2000D78")]
		public class ShopGood
		{
			// Token: 0x06006A48 RID: 27208 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A48")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ShopGood()
			{
			}

			// Token: 0x040046F3 RID: 18163
			[Token(Token = "0x40046F3")]
			[FieldOffset(Offset = "0x10")]
			public string goodId;

			// Token: 0x040046F4 RID: 18164
			[Token(Token = "0x40046F4")]
			[FieldOffset(Offset = "0x18")]
			public int slotId;

			// Token: 0x040046F5 RID: 18165
			[Token(Token = "0x40046F5")]
			[FieldOffset(Offset = "0x1C")]
			public int price;

			// Token: 0x040046F6 RID: 18166
			[Token(Token = "0x40046F6")]
			[FieldOffset(Offset = "0x20")]
			public int availCount;

			// Token: 0x040046F7 RID: 18167
			[Token(Token = "0x40046F7")]
			[FieldOffset(Offset = "0x28")]
			public ItemBundle item;

			// Token: 0x040046F8 RID: 18168
			[Token(Token = "0x40046F8")]
			[FieldOffset(Offset = "0x30")]
			public string progressGoodId;

			// Token: 0x040046F9 RID: 18169
			[Token(Token = "0x40046F9")]
			[FieldOffset(Offset = "0x38")]
			[JsonConverter(typeof(StringEnumConverter))]
			public Act5D1Data.GoodType goodType;

			// Token: 0x040046FA RID: 18170
			[Token(Token = "0x40046FA")]
			[FieldOffset(Offset = "0x40")]
			public string rarity;
		}

		// Token: 0x02000D79 RID: 3449
		[Token(Token = "0x2000D79")]
		public class ShopData
		{
			// Token: 0x06006A49 RID: 27209 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A49")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ShopData()
			{
			}

			// Token: 0x040046FB RID: 18171
			[Token(Token = "0x40046FB")]
			[FieldOffset(Offset = "0x10")]
			public Dictionary<string, Act5D1Data.ShopGood> shopGoods;

			// Token: 0x040046FC RID: 18172
			[Token(Token = "0x40046FC")]
			[FieldOffset(Offset = "0x18")]
			public Dictionary<string, List<Act5D1Data.ProgessGoodItem>> progressGoods;
		}

		// Token: 0x02000D7A RID: 3450
		[Token(Token = "0x2000D7A")]
		public class ProgessGoodItem
		{
			// Token: 0x06006A4A RID: 27210 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A4A")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ProgessGoodItem()
			{
			}

			// Token: 0x040046FD RID: 18173
			[Token(Token = "0x40046FD")]
			[FieldOffset(Offset = "0x10")]
			public int order;

			// Token: 0x040046FE RID: 18174
			[Token(Token = "0x40046FE")]
			[FieldOffset(Offset = "0x14")]
			public int price;

			// Token: 0x040046FF RID: 18175
			[Token(Token = "0x40046FF")]
			[FieldOffset(Offset = "0x18")]
			public string displayName;

			// Token: 0x04004700 RID: 18176
			[Token(Token = "0x4004700")]
			[FieldOffset(Offset = "0x20")]
			public ItemBundle item;
		}
	}
}
