using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02000CE8 RID: 3304
	[Token(Token = "0x2000CE8")]
	public class Act25SideData
	{
		// Token: 0x060069C8 RID: 27080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069C8")]
		[Address(RVA = "0x1FF4620", Offset = "0x1FF3220", VA = "0x181FF4620")]
		public Act25SideData()
		{
		}

		// Token: 0x040043B2 RID: 17330
		[Token(Token = "0x40043B2")]
		[FieldOffset(Offset = "0x10")]
		public string tokenItemId;

		// Token: 0x040043B3 RID: 17331
		[Token(Token = "0x40043B3")]
		[FieldOffset(Offset = "0x18")]
		public Act25SideData.ConstData constData;

		// Token: 0x040043B4 RID: 17332
		[Token(Token = "0x40043B4")]
		[FieldOffset(Offset = "0x20")]
		public ListDict<string, Act25SideData.ZoneDescInfo> zoneDescList;

		// Token: 0x040043B5 RID: 17333
		[Token(Token = "0x40043B5")]
		[FieldOffset(Offset = "0x28")]
		public Dictionary<string, Act25SideData.ArchiveItemData> archiveItemData;

		// Token: 0x040043B6 RID: 17334
		[Token(Token = "0x40043B6")]
		[FieldOffset(Offset = "0x30")]
		public Dictionary<string, Act25SideData.ArchiveMapInfoData> arcMapInfoData;

		// Token: 0x040043B7 RID: 17335
		[Token(Token = "0x40043B7")]
		[FieldOffset(Offset = "0x38")]
		public Dictionary<string, Act25SideData.AreaInfoData> areaInfoData;

		// Token: 0x040043B8 RID: 17336
		[Token(Token = "0x40043B8")]
		[FieldOffset(Offset = "0x40")]
		public Dictionary<string, Act25SideData.AreaMissionData> areaMissionData;

		// Token: 0x040043B9 RID: 17337
		[Token(Token = "0x40043B9")]
		[FieldOffset(Offset = "0x48")]
		public Dictionary<string, Act25SideData.BattlePerformanceData> battlePerformanceData;

		// Token: 0x040043BA RID: 17338
		[Token(Token = "0x40043BA")]
		[FieldOffset(Offset = "0x50")]
		public Dictionary<string, Act25SideData.KeyData> keyData;

		// Token: 0x040043BB RID: 17339
		[Token(Token = "0x40043BB")]
		[FieldOffset(Offset = "0x58")]
		public Dictionary<string, Act25SideData.FogUnlockData> fogUnlockData;

		// Token: 0x040043BC RID: 17340
		[Token(Token = "0x40043BC")]
		[FieldOffset(Offset = "0x60")]
		public List<Act25SideData.DailyFarmData> farmList;

		// Token: 0x02000CE9 RID: 3305
		[Token(Token = "0x2000CE9")]
		public class ZoneDescInfo
		{
			// Token: 0x060069C9 RID: 27081 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60069C9")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ZoneDescInfo()
			{
			}

			// Token: 0x040043BD RID: 17341
			[Token(Token = "0x40043BD")]
			[FieldOffset(Offset = "0x10")]
			public string zoneId;

			// Token: 0x040043BE RID: 17342
			[Token(Token = "0x40043BE")]
			[FieldOffset(Offset = "0x18")]
			public string unlockText;

			// Token: 0x040043BF RID: 17343
			[Token(Token = "0x40043BF")]
			[FieldOffset(Offset = "0x20")]
			public long displayStartTime;
		}

		// Token: 0x02000CEA RID: 3306
		[Token(Token = "0x2000CEA")]
		public enum Act25SideArchiveItemType
		{
			// Token: 0x040043C1 RID: 17345
			[Token(Token = "0x40043C1")]
			PIC,
			// Token: 0x040043C2 RID: 17346
			[Token(Token = "0x40043C2")]
			STORY,
			// Token: 0x040043C3 RID: 17347
			[Token(Token = "0x40043C3")]
			BATTLE_PERFORMANCE,
			// Token: 0x040043C4 RID: 17348
			[Token(Token = "0x40043C4")]
			KEY,
			// Token: 0x040043C5 RID: 17349
			[Token(Token = "0x40043C5")]
			ENUM
		}

		// Token: 0x02000CEB RID: 3307
		[Token(Token = "0x2000CEB")]
		public enum Act25SideArchiveItemUnlockType
		{
			// Token: 0x040043C7 RID: 17351
			[Token(Token = "0x40043C7")]
			MISSION,
			// Token: 0x040043C8 RID: 17352
			[Token(Token = "0x40043C8")]
			STAGE,
			// Token: 0x040043C9 RID: 17353
			[Token(Token = "0x40043C9")]
			BUFF
		}

		// Token: 0x02000CEC RID: 3308
		[Token(Token = "0x2000CEC")]
		[JsonConverter(typeof(StringEnumConverter))]
		public enum Act25sideTechType
		{
			// Token: 0x040043CB RID: 17355
			[Token(Token = "0x40043CB")]
			TECH_1,
			// Token: 0x040043CC RID: 17356
			[Token(Token = "0x40043CC")]
			TECH_2,
			// Token: 0x040043CD RID: 17357
			[Token(Token = "0x40043CD")]
			TECH_3,
			// Token: 0x040043CE RID: 17358
			[Token(Token = "0x40043CE")]
			TECH_4,
			// Token: 0x040043CF RID: 17359
			[Token(Token = "0x40043CF")]
			TECH_NUM
		}

		// Token: 0x02000CED RID: 3309
		[Token(Token = "0x2000CED")]
		public class ArchiveMapInfoData
		{
			// Token: 0x060069CA RID: 27082 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60069CA")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ArchiveMapInfoData()
			{
			}

			// Token: 0x040043D0 RID: 17360
			[Token(Token = "0x40043D0")]
			[FieldOffset(Offset = "0x10")]
			public string objectId;

			// Token: 0x040043D1 RID: 17361
			[Token(Token = "0x40043D1")]
			[FieldOffset(Offset = "0x18")]
			public Act25SideData.Act25SideArchiveItemType type;

			// Token: 0x040043D2 RID: 17362
			[Token(Token = "0x40043D2")]
			[FieldOffset(Offset = "0x20")]
			public string numberId;

			// Token: 0x040043D3 RID: 17363
			[Token(Token = "0x40043D3")]
			[FieldOffset(Offset = "0x28")]
			public string areaId;

			// Token: 0x040043D4 RID: 17364
			[Token(Token = "0x40043D4")]
			[FieldOffset(Offset = "0x30")]
			public int sortId;

			// Token: 0x040043D5 RID: 17365
			[Token(Token = "0x40043D5")]
			[FieldOffset(Offset = "0x34")]
			public int position;

			// Token: 0x040043D6 RID: 17366
			[Token(Token = "0x40043D6")]
			[FieldOffset(Offset = "0x38")]
			public bool hasDot;
		}

		// Token: 0x02000CEE RID: 3310
		[Token(Token = "0x2000CEE")]
		public class ArchiveItemData
		{
			// Token: 0x060069CB RID: 27083 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60069CB")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ArchiveItemData()
			{
			}

			// Token: 0x040043D7 RID: 17367
			[Token(Token = "0x40043D7")]
			[FieldOffset(Offset = "0x10")]
			public string itemId;

			// Token: 0x040043D8 RID: 17368
			[Token(Token = "0x40043D8")]
			[FieldOffset(Offset = "0x18")]
			public Act25SideData.Act25SideArchiveItemType itemType;

			// Token: 0x040043D9 RID: 17369
			[Token(Token = "0x40043D9")]
			[FieldOffset(Offset = "0x1C")]
			public Act25SideData.Act25SideArchiveItemUnlockType itemUnlockType;

			// Token: 0x040043DA RID: 17370
			[Token(Token = "0x40043DA")]
			[FieldOffset(Offset = "0x20")]
			public string itemUnlockParam;

			// Token: 0x040043DB RID: 17371
			[Token(Token = "0x40043DB")]
			[FieldOffset(Offset = "0x28")]
			public string unlockDesc;

			// Token: 0x040043DC RID: 17372
			[Token(Token = "0x40043DC")]
			[FieldOffset(Offset = "0x30")]
			public string iconId;

			// Token: 0x040043DD RID: 17373
			[Token(Token = "0x40043DD")]
			[FieldOffset(Offset = "0x38")]
			public string itemName;
		}

		// Token: 0x02000CEF RID: 3311
		[Token(Token = "0x2000CEF")]
		public class AreaInfoData
		{
			// Token: 0x060069CC RID: 27084 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60069CC")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public AreaInfoData()
			{
			}

			// Token: 0x040043DE RID: 17374
			[Token(Token = "0x40043DE")]
			[FieldOffset(Offset = "0x10")]
			public string areaId;

			// Token: 0x040043DF RID: 17375
			[Token(Token = "0x40043DF")]
			[FieldOffset(Offset = "0x18")]
			public int sortId;

			// Token: 0x040043E0 RID: 17376
			[Token(Token = "0x40043E0")]
			[FieldOffset(Offset = "0x20")]
			public string areaIcon;

			// Token: 0x040043E1 RID: 17377
			[Token(Token = "0x40043E1")]
			[FieldOffset(Offset = "0x28")]
			public string areaName;

			// Token: 0x040043E2 RID: 17378
			[Token(Token = "0x40043E2")]
			[FieldOffset(Offset = "0x30")]
			public string unlockText;

			// Token: 0x040043E3 RID: 17379
			[Token(Token = "0x40043E3")]
			[FieldOffset(Offset = "0x38")]
			public string preposedStage;

			// Token: 0x040043E4 RID: 17380
			[Token(Token = "0x40043E4")]
			[FieldOffset(Offset = "0x40")]
			public string areaInitialDesc;

			// Token: 0x040043E5 RID: 17381
			[Token(Token = "0x40043E5")]
			[FieldOffset(Offset = "0x48")]
			public string areaEndingDesc;

			// Token: 0x040043E6 RID: 17382
			[Token(Token = "0x40043E6")]
			[FieldOffset(Offset = "0x50")]
			public string areaEndingAud;

			// Token: 0x040043E7 RID: 17383
			[Token(Token = "0x40043E7")]
			[FieldOffset(Offset = "0x58")]
			public ItemBundle reward;

			// Token: 0x040043E8 RID: 17384
			[Token(Token = "0x40043E8")]
			[FieldOffset(Offset = "0x60")]
			public string finalId;

			// Token: 0x040043E9 RID: 17385
			[Token(Token = "0x40043E9")]
			[FieldOffset(Offset = "0x68")]
			public bool areaNewIcon;
		}

		// Token: 0x02000CF0 RID: 3312
		[Token(Token = "0x2000CF0")]
		public class AreaMissionData
		{
			// Token: 0x060069CD RID: 27085 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60069CD")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public AreaMissionData()
			{
			}

			// Token: 0x040043EA RID: 17386
			[Token(Token = "0x40043EA")]
			[FieldOffset(Offset = "0x10")]
			public string id;

			// Token: 0x040043EB RID: 17387
			[Token(Token = "0x40043EB")]
			[FieldOffset(Offset = "0x18")]
			public string areaId;

			// Token: 0x040043EC RID: 17388
			[Token(Token = "0x40043EC")]
			[FieldOffset(Offset = "0x20")]
			public string preposedMissionId;

			// Token: 0x040043ED RID: 17389
			[Token(Token = "0x40043ED")]
			[FieldOffset(Offset = "0x28")]
			public int sortId;

			// Token: 0x040043EE RID: 17390
			[Token(Token = "0x40043EE")]
			[FieldOffset(Offset = "0x2C")]
			public bool isZone;

			// Token: 0x040043EF RID: 17391
			[Token(Token = "0x40043EF")]
			[FieldOffset(Offset = "0x30")]
			public string stageId;

			// Token: 0x040043F0 RID: 17392
			[Token(Token = "0x40043F0")]
			[FieldOffset(Offset = "0x38")]
			public int costCount;

			// Token: 0x040043F1 RID: 17393
			[Token(Token = "0x40043F1")]
			[FieldOffset(Offset = "0x3C")]
			public int transform;

			// Token: 0x040043F2 RID: 17394
			[Token(Token = "0x40043F2")]
			[FieldOffset(Offset = "0x40")]
			public int progress;

			// Token: 0x040043F3 RID: 17395
			[Token(Token = "0x40043F3")]
			[FieldOffset(Offset = "0x48")]
			public string progressPicId;

			// Token: 0x040043F4 RID: 17396
			[Token(Token = "0x40043F4")]
			[FieldOffset(Offset = "0x50")]
			public string template;

			// Token: 0x040043F5 RID: 17397
			[Token(Token = "0x40043F5")]
			[FieldOffset(Offset = "0x58")]
			public int templateType;

			// Token: 0x040043F6 RID: 17398
			[Token(Token = "0x40043F6")]
			[FieldOffset(Offset = "0x60")]
			public string desc;

			// Token: 0x040043F7 RID: 17399
			[Token(Token = "0x40043F7")]
			[FieldOffset(Offset = "0x68")]
			public List<string> param;

			// Token: 0x040043F8 RID: 17400
			[Token(Token = "0x40043F8")]
			[FieldOffset(Offset = "0x70")]
			public List<ItemBundle> rewards;

			// Token: 0x040043F9 RID: 17401
			[Token(Token = "0x40043F9")]
			[FieldOffset(Offset = "0x78")]
			public List<string> archiveItems;
		}

		// Token: 0x02000CF1 RID: 3313
		[Token(Token = "0x2000CF1")]
		public class BattlePerformanceData
		{
			// Token: 0x060069CE RID: 27086 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60069CE")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public BattlePerformanceData()
			{
			}

			// Token: 0x040043FA RID: 17402
			[Token(Token = "0x40043FA")]
			[FieldOffset(Offset = "0x10")]
			public string itemId;

			// Token: 0x040043FB RID: 17403
			[Token(Token = "0x40043FB")]
			[FieldOffset(Offset = "0x18")]
			public int sortId;

			// Token: 0x040043FC RID: 17404
			[Token(Token = "0x40043FC")]
			[FieldOffset(Offset = "0x20")]
			public string itemName;

			// Token: 0x040043FD RID: 17405
			[Token(Token = "0x40043FD")]
			[FieldOffset(Offset = "0x28")]
			public string itemIcon;

			// Token: 0x040043FE RID: 17406
			[Token(Token = "0x40043FE")]
			[FieldOffset(Offset = "0x30")]
			public string itemDesc;

			// Token: 0x040043FF RID: 17407
			[Token(Token = "0x40043FF")]
			[FieldOffset(Offset = "0x38")]
			public Act25SideData.Act25sideTechType itemTechType;

			// Token: 0x04004400 RID: 17408
			[Token(Token = "0x4004400")]
			[FieldOffset(Offset = "0x40")]
			public RuneTable.PackedRuneData runeData;
		}

		// Token: 0x02000CF2 RID: 3314
		[Token(Token = "0x2000CF2")]
		public class KeyData
		{
			// Token: 0x060069CF RID: 27087 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60069CF")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public KeyData()
			{
			}

			// Token: 0x04004401 RID: 17409
			[Token(Token = "0x4004401")]
			[FieldOffset(Offset = "0x10")]
			public string keyId;

			// Token: 0x04004402 RID: 17410
			[Token(Token = "0x4004402")]
			[FieldOffset(Offset = "0x18")]
			public string keyName;

			// Token: 0x04004403 RID: 17411
			[Token(Token = "0x4004403")]
			[FieldOffset(Offset = "0x20")]
			public string keyIcon;

			// Token: 0x04004404 RID: 17412
			[Token(Token = "0x4004404")]
			[FieldOffset(Offset = "0x28")]
			public string toastText;
		}

		// Token: 0x02000CF3 RID: 3315
		[Token(Token = "0x2000CF3")]
		public class FogUnlockData
		{
			// Token: 0x060069D0 RID: 27088 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60069D0")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public FogUnlockData()
			{
			}

			// Token: 0x04004405 RID: 17413
			[Token(Token = "0x4004405")]
			[FieldOffset(Offset = "0x10")]
			public string lockId;

			// Token: 0x04004406 RID: 17414
			[Token(Token = "0x4004406")]
			[FieldOffset(Offset = "0x18")]
			public string lockedCollectionIconId;

			// Token: 0x04004407 RID: 17415
			[Token(Token = "0x4004407")]
			[FieldOffset(Offset = "0x20")]
			public string unlockedCollectionIconId;
		}

		// Token: 0x02000CF4 RID: 3316
		[Token(Token = "0x2000CF4")]
		public class ConstData
		{
			// Token: 0x060069D1 RID: 27089 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60069D1")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ConstData()
			{
			}

			// Token: 0x04004408 RID: 17416
			[Token(Token = "0x4004408")]
			[FieldOffset(Offset = "0x10")]
			public int getDailyCount;

			// Token: 0x04004409 RID: 17417
			[Token(Token = "0x4004409")]
			[FieldOffset(Offset = "0x18")]
			public string costName;

			// Token: 0x0400440A RID: 17418
			[Token(Token = "0x400440A")]
			[FieldOffset(Offset = "0x20")]
			public string costDesc;

			// Token: 0x0400440B RID: 17419
			[Token(Token = "0x400440B")]
			[FieldOffset(Offset = "0x28")]
			public int costLimit;

			// Token: 0x0400440C RID: 17420
			[Token(Token = "0x400440C")]
			[FieldOffset(Offset = "0x2C")]
			public int rewardLimit;

			// Token: 0x0400440D RID: 17421
			[Token(Token = "0x400440D")]
			[FieldOffset(Offset = "0x30")]
			public string researchUnlockText;

			// Token: 0x0400440E RID: 17422
			[Token(Token = "0x400440E")]
			[FieldOffset(Offset = "0x38")]
			public ItemBundle harvestReward;

			// Token: 0x0400440F RID: 17423
			[Token(Token = "0x400440F")]
			[FieldOffset(Offset = "0x40")]
			public int costCount;

			// Token: 0x04004410 RID: 17424
			[Token(Token = "0x4004410")]
			[FieldOffset(Offset = "0x44")]
			public int costCountLimit;

			// Token: 0x04004411 RID: 17425
			[Token(Token = "0x4004411")]
			[FieldOffset(Offset = "0x48")]
			public int basicProgress;

			// Token: 0x04004412 RID: 17426
			[Token(Token = "0x4004412")]
			[FieldOffset(Offset = "0x50")]
			public string harvestDesc;
		}

		// Token: 0x02000CF5 RID: 3317
		[Token(Token = "0x2000CF5")]
		public class DailyFarmData
		{
			// Token: 0x060069D2 RID: 27090 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60069D2")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public DailyFarmData()
			{
			}

			// Token: 0x04004413 RID: 17427
			[Token(Token = "0x4004413")]
			[FieldOffset(Offset = "0x10")]
			public int transform;

			// Token: 0x04004414 RID: 17428
			[Token(Token = "0x4004414")]
			[FieldOffset(Offset = "0x18")]
			public long unitTime;
		}
	}
}
