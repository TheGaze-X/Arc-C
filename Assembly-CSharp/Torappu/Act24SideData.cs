using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02000CDA RID: 3290
	[Token(Token = "0x2000CDA")]
	public class Act24SideData
	{
		// Token: 0x060069B8 RID: 27064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069B8")]
		[Address(RVA = "0x1FF4220", Offset = "0x1FF2E20", VA = "0x181FF4220")]
		public Act24SideData()
		{
		}

		// Token: 0x04004339 RID: 17209
		[Token(Token = "0x4004339")]
		[FieldOffset(Offset = "0x10")]
		public ListDict<string, Act24SideData.ToolData> toolDataList;

		// Token: 0x0400433A RID: 17210
		[Token(Token = "0x400433A")]
		[FieldOffset(Offset = "0x18")]
		public ListDict<string, Act24SideData.MealData> mealDataList;

		// Token: 0x0400433B RID: 17211
		[Token(Token = "0x400433B")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<string, Act24SideData.MeldingItemData> meldingDict;

		// Token: 0x0400433C RID: 17212
		[Token(Token = "0x400433C")]
		[FieldOffset(Offset = "0x28")]
		public ListDict<string, Act24SideData.MeldingGachaBoxData> meldingGachaBoxDataList;

		// Token: 0x0400433D RID: 17213
		[Token(Token = "0x400433D")]
		[FieldOffset(Offset = "0x30")]
		public Dictionary<string, List<Act24SideData.MeldingGachaBoxGoodData>> meldingGachaBoxGoodDataMap;

		// Token: 0x0400433E RID: 17214
		[Token(Token = "0x400433E")]
		[FieldOffset(Offset = "0x38")]
		public Dictionary<string, string> mealWelcomeTxtDataMap;

		// Token: 0x0400433F RID: 17215
		[Token(Token = "0x400433F")]
		[FieldOffset(Offset = "0x40")]
		public Dictionary<string, Act24SideData.ZoneAdditionData> zoneAdditionDataMap;

		// Token: 0x04004340 RID: 17216
		[Token(Token = "0x4004340")]
		[FieldOffset(Offset = "0x48")]
		public List<QuestStageData> questStageList;

		// Token: 0x04004341 RID: 17217
		[Token(Token = "0x4004341")]
		[FieldOffset(Offset = "0x50")]
		public ListDict<string, Act24SideData.MissionExtraData> missionDataList;

		// Token: 0x04004342 RID: 17218
		[Token(Token = "0x4004342")]
		[FieldOffset(Offset = "0x58")]
		public Dictionary<string, StageData.StageDropInfo> meldingDropDict;

		// Token: 0x04004343 RID: 17219
		[Token(Token = "0x4004343")]
		[FieldOffset(Offset = "0x60")]
		public Dictionary<string, List<string>> stageMapPreviewDict;

		// Token: 0x04004344 RID: 17220
		[Token(Token = "0x4004344")]
		[FieldOffset(Offset = "0x68")]
		public Dictionary<string, Act24SideData.HuntDatabaseData> huntDatabaseDict;

		// Token: 0x04004345 RID: 17221
		[Token(Token = "0x4004345")]
		[FieldOffset(Offset = "0x70")]
		public Dictionary<string, string> stageIdToUnlockItemIdDict;

		// Token: 0x04004346 RID: 17222
		[Token(Token = "0x4004346")]
		[FieldOffset(Offset = "0x78")]
		public Act24SideData.ConstData constData;

		// Token: 0x02000CDB RID: 3291
		[Token(Token = "0x2000CDB")]
		[JsonConverter(typeof(StringEnumConverter))]
		public enum MeldingGoodDisplayType
		{
			// Token: 0x04004348 RID: 17224
			[Token(Token = "0x4004348")]
			NONE,
			// Token: 0x04004349 RID: 17225
			[Token(Token = "0x4004349")]
			RARE_1,
			// Token: 0x0400434A RID: 17226
			[Token(Token = "0x400434A")]
			RARE_2,
			// Token: 0x0400434B RID: 17227
			[Token(Token = "0x400434B")]
			RARE_3
		}

		// Token: 0x02000CDC RID: 3292
		[Token(Token = "0x2000CDC")]
		[JsonConverter(typeof(StringEnumConverter))]
		public enum MeldingGoodGachaType
		{
			// Token: 0x0400434D RID: 17229
			[Token(Token = "0x400434D")]
			NONE,
			// Token: 0x0400434E RID: 17230
			[Token(Token = "0x400434E")]
			LIMITED,
			// Token: 0x0400434F RID: 17231
			[Token(Token = "0x400434F")]
			UNLIMITED
		}

		// Token: 0x02000CDD RID: 3293
		[Token(Token = "0x2000CDD")]
		[JsonConverter(typeof(StringEnumConverter))]
		public enum MissionType
		{
			// Token: 0x04004351 RID: 17233
			[Token(Token = "0x4004351")]
			NONE,
			// Token: 0x04004352 RID: 17234
			[Token(Token = "0x4004352")]
			HUNTING_TASK,
			// Token: 0x04004353 RID: 17235
			[Token(Token = "0x4004353")]
			COLLECTION_TASK,
			// Token: 0x04004354 RID: 17236
			[Token(Token = "0x4004354")]
			EXPLORATION_TASK,
			// Token: 0x04004355 RID: 17237
			[Token(Token = "0x4004355")]
			MONSTER_TASK,
			// Token: 0x04004356 RID: 17238
			[Token(Token = "0x4004356")]
			INVATION_TASK
		}

		// Token: 0x02000CDE RID: 3294
		[Token(Token = "0x2000CDE")]
		public enum MeldingItemRarityType
		{
			// Token: 0x04004358 RID: 17240
			[Token(Token = "0x4004358")]
			NONE,
			// Token: 0x04004359 RID: 17241
			[Token(Token = "0x4004359")]
			RARITY_1,
			// Token: 0x0400435A RID: 17242
			[Token(Token = "0x400435A")]
			RARITY_2,
			// Token: 0x0400435B RID: 17243
			[Token(Token = "0x400435B")]
			RARITY_3,
			// Token: 0x0400435C RID: 17244
			[Token(Token = "0x400435C")]
			RARITY_4,
			// Token: 0x0400435D RID: 17245
			[Token(Token = "0x400435D")]
			RARITY_5,
			// Token: 0x0400435E RID: 17246
			[Token(Token = "0x400435E")]
			RARITY_6
		}

		// Token: 0x02000CDF RID: 3295
		[Token(Token = "0x2000CDF")]
		public class MeldingItemData
		{
			// Token: 0x060069B9 RID: 27065 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60069B9")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public MeldingItemData()
			{
			}

			// Token: 0x0400435F RID: 17247
			[Token(Token = "0x400435F")]
			[FieldOffset(Offset = "0x10")]
			public string meldingId;

			// Token: 0x04004360 RID: 17248
			[Token(Token = "0x4004360")]
			[FieldOffset(Offset = "0x18")]
			public string bgId;

			// Token: 0x04004361 RID: 17249
			[Token(Token = "0x4004361")]
			[FieldOffset(Offset = "0x20")]
			public int sortId;

			// Token: 0x04004362 RID: 17250
			[Token(Token = "0x4004362")]
			[FieldOffset(Offset = "0x24")]
			public int meldingPrice;

			// Token: 0x04004363 RID: 17251
			[Token(Token = "0x4004363")]
			[FieldOffset(Offset = "0x28")]
			public Act24SideData.MeldingItemRarityType rarity;
		}

		// Token: 0x02000CE0 RID: 3296
		[Token(Token = "0x2000CE0")]
		public class ZoneAdditionData
		{
			// Token: 0x060069BA RID: 27066 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60069BA")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ZoneAdditionData()
			{
			}

			// Token: 0x04004364 RID: 17252
			[Token(Token = "0x4004364")]
			[FieldOffset(Offset = "0x10")]
			public string zoneId;

			// Token: 0x04004365 RID: 17253
			[Token(Token = "0x4004365")]
			[FieldOffset(Offset = "0x18")]
			public string zoneIcon;

			// Token: 0x04004366 RID: 17254
			[Token(Token = "0x4004366")]
			[FieldOffset(Offset = "0x20")]
			public string unlockText;

			// Token: 0x04004367 RID: 17255
			[Token(Token = "0x4004367")]
			[FieldOffset(Offset = "0x28")]
			public string displayTime;
		}

		// Token: 0x02000CE1 RID: 3297
		[Token(Token = "0x2000CE1")]
		public class HuntDatabaseData
		{
			// Token: 0x060069BB RID: 27067 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60069BB")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public HuntDatabaseData()
			{
			}

			// Token: 0x04004368 RID: 17256
			[Token(Token = "0x4004368")]
			[FieldOffset(Offset = "0x10")]
			public string id;

			// Token: 0x04004369 RID: 17257
			[Token(Token = "0x4004369")]
			[FieldOffset(Offset = "0x18")]
			public string name;

			// Token: 0x0400436A RID: 17258
			[Token(Token = "0x400436A")]
			[FieldOffset(Offset = "0x20")]
			public int sortId;

			// Token: 0x0400436B RID: 17259
			[Token(Token = "0x400436B")]
			[FieldOffset(Offset = "0x24")]
			public int level;

			// Token: 0x0400436C RID: 17260
			[Token(Token = "0x400436C")]
			[FieldOffset(Offset = "0x28")]
			public bool isBoss;

			// Token: 0x0400436D RID: 17261
			[Token(Token = "0x400436D")]
			[FieldOffset(Offset = "0x30")]
			public string bossPicId;

			// Token: 0x0400436E RID: 17262
			[Token(Token = "0x400436E")]
			[FieldOffset(Offset = "0x38")]
			public string iconSmallId;

			// Token: 0x0400436F RID: 17263
			[Token(Token = "0x400436F")]
			[FieldOffset(Offset = "0x40")]
			public string iconLargeId;

			// Token: 0x04004370 RID: 17264
			[Token(Token = "0x4004370")]
			[FieldOffset(Offset = "0x48")]
			public string basicDesc;

			// Token: 0x04004371 RID: 17265
			[Token(Token = "0x4004371")]
			[FieldOffset(Offset = "0x50")]
			public string rideIcon;

			// Token: 0x04004372 RID: 17266
			[Token(Token = "0x4004372")]
			[FieldOffset(Offset = "0x58")]
			public string rideDesc;

			// Token: 0x04004373 RID: 17267
			[Token(Token = "0x4004373")]
			[FieldOffset(Offset = "0x60")]
			public string secretTaskId;

			// Token: 0x04004374 RID: 17268
			[Token(Token = "0x4004374")]
			[FieldOffset(Offset = "0x68")]
			public string secretTaskItemId;

			// Token: 0x04004375 RID: 17269
			[Token(Token = "0x4004375")]
			[FieldOffset(Offset = "0x70")]
			public string secretTaskDesc;

			// Token: 0x04004376 RID: 17270
			[Token(Token = "0x4004376")]
			[FieldOffset(Offset = "0x78")]
			public string secretContent;
		}

		// Token: 0x02000CE2 RID: 3298
		[Token(Token = "0x2000CE2")]
		public class ConstData
		{
			// Token: 0x060069BC RID: 27068 RVA: 0x00030E58 File Offset: 0x0002F058
			[Token(Token = "0x60069BC")]
			[Address(RVA = "0x2008670", Offset = "0x2007270", VA = "0x182008670", Slot = "4")]
			public virtual bool ShouldSerializegachaDefaultProb()
			{
				return default(bool);
			}

			// Token: 0x060069BD RID: 27069 RVA: 0x00030E70 File Offset: 0x0002F070
			[Token(Token = "0x60069BD")]
			[Address(RVA = "0x2008680", Offset = "0x2007280", VA = "0x182008680", Slot = "5")]
			public virtual bool ShouldSerializegachagachaExtraProb()
			{
				return default(bool);
			}

			// Token: 0x060069BE RID: 27070 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60069BE")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ConstData()
			{
			}

			// Token: 0x04004377 RID: 17271
			[Token(Token = "0x4004377")]
			[FieldOffset(Offset = "0x10")]
			public string stageUnlockToolDesc;

			// Token: 0x04004378 RID: 17272
			[Token(Token = "0x4004378")]
			[FieldOffset(Offset = "0x18")]
			public string mealLackMoney;

			// Token: 0x04004379 RID: 17273
			[Token(Token = "0x4004379")]
			[FieldOffset(Offset = "0x20")]
			public int mealDayTimesLimit;

			// Token: 0x0400437A RID: 17274
			[Token(Token = "0x400437A")]
			[FieldOffset(Offset = "0x24")]
			public int toolMaximum;

			// Token: 0x0400437B RID: 17275
			[Token(Token = "0x400437B")]
			[FieldOffset(Offset = "0x28")]
			public List<string> stageCanNotUseToTool;

			// Token: 0x0400437C RID: 17276
			[Token(Token = "0x400437C")]
			[FieldOffset(Offset = "0x30")]
			public string hunterGuideRewardItemId;

			// Token: 0x0400437D RID: 17277
			[Token(Token = "0x400437D")]
			[FieldOffset(Offset = "0x38")]
			public string hunterGuideRewardItemType;

			// Token: 0x0400437E RID: 17278
			[Token(Token = "0x400437E")]
			[FieldOffset(Offset = "0x40")]
			public int hunterGuideRewardItemCount;

			// Token: 0x0400437F RID: 17279
			[Token(Token = "0x400437F")]
			[FieldOffset(Offset = "0x44")]
			public int hunterGuideDetailTabPosition;

			// Token: 0x04004380 RID: 17280
			[Token(Token = "0x4004380")]
			[FieldOffset(Offset = "0x48")]
			public string taskRewardItemNoIconDisplayId;

			// Token: 0x04004381 RID: 17281
			[Token(Token = "0x4004381")]
			[FieldOffset(Offset = "0x50")]
			public string specialLevelUnlockTaskId;

			// Token: 0x04004382 RID: 17282
			[Token(Token = "0x4004382")]
			[FieldOffset(Offset = "0x58")]
			public string missionProgressFormat;

			// Token: 0x04004383 RID: 17283
			[Token(Token = "0x4004383")]
			[FieldOffset(Offset = "0x60")]
			public float gachaDefaultProb;

			// Token: 0x04004384 RID: 17284
			[Token(Token = "0x4004384")]
			[FieldOffset(Offset = "0x64")]
			public float gachaExtraProb;
		}

		// Token: 0x02000CE3 RID: 3299
		[Token(Token = "0x2000CE3")]
		public class ToolData
		{
			// Token: 0x060069BF RID: 27071 RVA: 0x00030E88 File Offset: 0x0002F088
			[Token(Token = "0x60069BF")]
			[Address(RVA = "0x1FF9C40", Offset = "0x1FF8840", VA = "0x181FF9C40", Slot = "4")]
			public virtual bool ShouldSerializetoolStageId()
			{
				return default(bool);
			}

			// Token: 0x060069C0 RID: 27072 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60069C0")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ToolData()
			{
			}

			// Token: 0x04004385 RID: 17285
			[Token(Token = "0x4004385")]
			[FieldOffset(Offset = "0x10")]
			public string toolId;

			// Token: 0x04004386 RID: 17286
			[Token(Token = "0x4004386")]
			[FieldOffset(Offset = "0x18")]
			public int sortId;

			// Token: 0x04004387 RID: 17287
			[Token(Token = "0x4004387")]
			[FieldOffset(Offset = "0x20")]
			public string toolName;

			// Token: 0x04004388 RID: 17288
			[Token(Token = "0x4004388")]
			[FieldOffset(Offset = "0x28")]
			public string toolDesc;

			// Token: 0x04004389 RID: 17289
			[Token(Token = "0x4004389")]
			[FieldOffset(Offset = "0x30")]
			public string toolIcon1;

			// Token: 0x0400438A RID: 17290
			[Token(Token = "0x400438A")]
			[FieldOffset(Offset = "0x38")]
			public string toolIcon2;

			// Token: 0x0400438B RID: 17291
			[Token(Token = "0x400438B")]
			[FieldOffset(Offset = "0x40")]
			public string toolUnlockDesc;

			// Token: 0x0400438C RID: 17292
			[Token(Token = "0x400438C")]
			[FieldOffset(Offset = "0x48")]
			public string toolBuffId;

			// Token: 0x0400438D RID: 17293
			[Token(Token = "0x400438D")]
			[FieldOffset(Offset = "0x50")]
			public RuneTable.PackedRuneData runeData;

			// Token: 0x0400438E RID: 17294
			[Token(Token = "0x400438E")]
			[FieldOffset(Offset = "0x58")]
			public string toolStageId;
		}

		// Token: 0x02000CE4 RID: 3300
		[Token(Token = "0x2000CE4")]
		public class MealData
		{
			// Token: 0x060069C1 RID: 27073 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60069C1")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public MealData()
			{
			}

			// Token: 0x0400438F RID: 17295
			[Token(Token = "0x400438F")]
			[FieldOffset(Offset = "0x10")]
			public string mealId;

			// Token: 0x04004390 RID: 17296
			[Token(Token = "0x4004390")]
			[FieldOffset(Offset = "0x18")]
			public int sortId;

			// Token: 0x04004391 RID: 17297
			[Token(Token = "0x4004391")]
			[FieldOffset(Offset = "0x20")]
			public string mealName;

			// Token: 0x04004392 RID: 17298
			[Token(Token = "0x4004392")]
			[FieldOffset(Offset = "0x28")]
			public string mealEffectDesc;

			// Token: 0x04004393 RID: 17299
			[Token(Token = "0x4004393")]
			[FieldOffset(Offset = "0x30")]
			public string mealDesc;

			// Token: 0x04004394 RID: 17300
			[Token(Token = "0x4004394")]
			[FieldOffset(Offset = "0x38")]
			public string mealIcon;

			// Token: 0x04004395 RID: 17301
			[Token(Token = "0x4004395")]
			[FieldOffset(Offset = "0x40")]
			public int mealCost;

			// Token: 0x04004396 RID: 17302
			[Token(Token = "0x4004396")]
			[FieldOffset(Offset = "0x44")]
			public int mealRewardAP;

			// Token: 0x04004397 RID: 17303
			[Token(Token = "0x4004397")]
			[FieldOffset(Offset = "0x48")]
			public ItemBundle mealRewardItemInfo;
		}

		// Token: 0x02000CE5 RID: 3301
		[Token(Token = "0x2000CE5")]
		public class MeldingGachaBoxData
		{
			// Token: 0x060069C2 RID: 27074 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60069C2")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public MeldingGachaBoxData()
			{
			}

			// Token: 0x04004398 RID: 17304
			[Token(Token = "0x4004398")]
			[FieldOffset(Offset = "0x10")]
			public string gachaBoxId;

			// Token: 0x04004399 RID: 17305
			[Token(Token = "0x4004399")]
			[FieldOffset(Offset = "0x18")]
			public int gachaSortId;

			// Token: 0x0400439A RID: 17306
			[Token(Token = "0x400439A")]
			[FieldOffset(Offset = "0x20")]
			public string gachaIcon;

			// Token: 0x0400439B RID: 17307
			[Token(Token = "0x400439B")]
			[FieldOffset(Offset = "0x28")]
			public string gachaBoxName;

			// Token: 0x0400439C RID: 17308
			[Token(Token = "0x400439C")]
			[FieldOffset(Offset = "0x30")]
			public int gachaCost;

			// Token: 0x0400439D RID: 17309
			[Token(Token = "0x400439D")]
			[FieldOffset(Offset = "0x34")]
			public int gachaTimesLimit;

			// Token: 0x0400439E RID: 17310
			[Token(Token = "0x400439E")]
			[FieldOffset(Offset = "0x38")]
			public string themeColor;

			// Token: 0x0400439F RID: 17311
			[Token(Token = "0x400439F")]
			[FieldOffset(Offset = "0x40")]
			public string remainItemBgColor;
		}

		// Token: 0x02000CE6 RID: 3302
		[Token(Token = "0x2000CE6")]
		public class MeldingGachaBoxGoodData
		{
			// Token: 0x060069C3 RID: 27075 RVA: 0x00030EA0 File Offset: 0x0002F0A0
			[Token(Token = "0x60069C3")]
			[Address(RVA = "0x200B860", Offset = "0x200A460", VA = "0x18200B860", Slot = "4")]
			public virtual bool ShouldSerializeweight()
			{
				return default(bool);
			}

			// Token: 0x060069C4 RID: 27076 RVA: 0x00030EB8 File Offset: 0x0002F0B8
			[Token(Token = "0x60069C4")]
			[Address(RVA = "0x200B850", Offset = "0x200A450", VA = "0x18200B850", Slot = "5")]
			public virtual bool ShouldSerializegachaOrderId()
			{
				return default(bool);
			}

			// Token: 0x060069C5 RID: 27077 RVA: 0x00030ED0 File Offset: 0x0002F0D0
			[Token(Token = "0x60069C5")]
			[Address(RVA = "0x200B840", Offset = "0x200A440", VA = "0x18200B840", Slot = "6")]
			public virtual bool ShouldSerializegachaNum()
			{
				return default(bool);
			}

			// Token: 0x060069C6 RID: 27078 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60069C6")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public MeldingGachaBoxGoodData()
			{
			}

			// Token: 0x040043A0 RID: 17312
			[Token(Token = "0x40043A0")]
			[FieldOffset(Offset = "0x10")]
			public string goodId;

			// Token: 0x040043A1 RID: 17313
			[Token(Token = "0x40043A1")]
			[FieldOffset(Offset = "0x18")]
			public string gachaBoxId;

			// Token: 0x040043A2 RID: 17314
			[Token(Token = "0x40043A2")]
			[FieldOffset(Offset = "0x20")]
			public int orderId;

			// Token: 0x040043A3 RID: 17315
			[Token(Token = "0x40043A3")]
			[FieldOffset(Offset = "0x28")]
			public string itemId;

			// Token: 0x040043A4 RID: 17316
			[Token(Token = "0x40043A4")]
			[FieldOffset(Offset = "0x30")]
			[JsonConverter(typeof(StringEnumConverter))]
			public ItemType itemType;

			// Token: 0x040043A5 RID: 17317
			[Token(Token = "0x40043A5")]
			[FieldOffset(Offset = "0x34")]
			public Act24SideData.MeldingGoodDisplayType displayType;

			// Token: 0x040043A6 RID: 17318
			[Token(Token = "0x40043A6")]
			[FieldOffset(Offset = "0x38")]
			public int perCount;

			// Token: 0x040043A7 RID: 17319
			[Token(Token = "0x40043A7")]
			[FieldOffset(Offset = "0x3C")]
			public int totalCount;

			// Token: 0x040043A8 RID: 17320
			[Token(Token = "0x40043A8")]
			[FieldOffset(Offset = "0x40")]
			public Act24SideData.MeldingGoodGachaType gachaType;

			// Token: 0x040043A9 RID: 17321
			[Token(Token = "0x40043A9")]
			[FieldOffset(Offset = "0x44")]
			public int weight;

			// Token: 0x040043AA RID: 17322
			[Token(Token = "0x40043AA")]
			[FieldOffset(Offset = "0x48")]
			public int gachaOrderId;

			// Token: 0x040043AB RID: 17323
			[Token(Token = "0x40043AB")]
			[FieldOffset(Offset = "0x4C")]
			public int gachaNum;
		}

		// Token: 0x02000CE7 RID: 3303
		[Token(Token = "0x2000CE7")]
		public class MissionExtraData
		{
			// Token: 0x060069C7 RID: 27079 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60069C7")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public MissionExtraData()
			{
			}

			// Token: 0x040043AC RID: 17324
			[Token(Token = "0x40043AC")]
			[FieldOffset(Offset = "0x10")]
			public string taskTypeName;

			// Token: 0x040043AD RID: 17325
			[Token(Token = "0x40043AD")]
			[FieldOffset(Offset = "0x18")]
			public string taskTypeIcon;

			// Token: 0x040043AE RID: 17326
			[Token(Token = "0x40043AE")]
			[FieldOffset(Offset = "0x20")]
			public Act24SideData.MissionType taskType;

			// Token: 0x040043AF RID: 17327
			[Token(Token = "0x40043AF")]
			[FieldOffset(Offset = "0x28")]
			public string taskTitle;

			// Token: 0x040043B0 RID: 17328
			[Token(Token = "0x40043B0")]
			[FieldOffset(Offset = "0x30")]
			public string taskClient;

			// Token: 0x040043B1 RID: 17329
			[Token(Token = "0x40043B1")]
			[FieldOffset(Offset = "0x38")]
			public string taskClientDesc;
		}
	}
}
