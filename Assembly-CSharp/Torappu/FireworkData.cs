using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02000E6B RID: 3691
	[Token(Token = "0x2000E6B")]
	public class FireworkData
	{
		// Token: 0x06006B3A RID: 27450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B3A")]
		[Address(RVA = "0x2009D20", Offset = "0x2008920", VA = "0x182009D20")]
		public FireworkData()
		{
		}

		// Token: 0x04004D53 RID: 19795
		[Token(Token = "0x4004D53")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, FireworkData.PlateData> plateData;

		// Token: 0x04004D54 RID: 19796
		[Token(Token = "0x4004D54")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, FireworkData.AnimalData> animalData;

		// Token: 0x04004D55 RID: 19797
		[Token(Token = "0x4004D55")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<string, FireworkData.LevelData> levelData;

		// Token: 0x04004D56 RID: 19798
		[Token(Token = "0x4004D56")]
		[FieldOffset(Offset = "0x28")]
		public FireworkData.ConstData constData;

		// Token: 0x02000E6C RID: 3692
		[Token(Token = "0x2000E6C")]
		[JsonConverter(typeof(StringEnumConverter))]
		public enum FireworkDirectionType
		{
			// Token: 0x04004D58 RID: 19800
			[Token(Token = "0x4004D58")]
			TWO_DIR,
			// Token: 0x04004D59 RID: 19801
			[Token(Token = "0x4004D59")]
			FOUR_DIR
		}

		// Token: 0x02000E6D RID: 3693
		[Token(Token = "0x2000E6D")]
		public class PlateSlotData
		{
			// Token: 0x06006B3B RID: 27451 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006B3B")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public PlateSlotData()
			{
			}

			// Token: 0x04004D5A RID: 19802
			[Token(Token = "0x4004D5A")]
			[FieldOffset(Offset = "0x10")]
			public string id;

			// Token: 0x04004D5B RID: 19803
			[Token(Token = "0x4004D5B")]
			[FieldOffset(Offset = "0x18")]
			public int idx;
		}

		// Token: 0x02000E6E RID: 3694
		[Token(Token = "0x2000E6E")]
		public enum FireworkType
		{
			// Token: 0x04004D5D RID: 19805
			[Token(Token = "0x4004D5D")]
			RED,
			// Token: 0x04004D5E RID: 19806
			[Token(Token = "0x4004D5E")]
			BLUE,
			// Token: 0x04004D5F RID: 19807
			[Token(Token = "0x4004D5F")]
			YELLOW,
			// Token: 0x04004D60 RID: 19808
			[Token(Token = "0x4004D60")]
			GREEN
		}

		// Token: 0x02000E6F RID: 3695
		[Token(Token = "0x2000E6F")]
		public class PlateContent
		{
			// Token: 0x06006B3C RID: 27452 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006B3C")]
			[Address(RVA = "0x200BB30", Offset = "0x200A730", VA = "0x18200BB30")]
			public PlateContent()
			{
			}

			// Token: 0x04004D61 RID: 19809
			[Token(Token = "0x4004D61")]
			[FieldOffset(Offset = "0x10")]
			public List<GridPosition> plateContent;
		}

		// Token: 0x02000E70 RID: 3696
		[Token(Token = "0x2000E70")]
		public class PlateData
		{
			// Token: 0x06006B3D RID: 27453 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006B3D")]
			[Address(RVA = "0x200BBC0", Offset = "0x200A7C0", VA = "0x18200BBC0")]
			public PlateData()
			{
			}

			// Token: 0x04004D62 RID: 19810
			[Token(Token = "0x4004D62")]
			[FieldOffset(Offset = "0x10")]
			public string plateId;

			// Token: 0x04004D63 RID: 19811
			[Token(Token = "0x4004D63")]
			[FieldOffset(Offset = "0x18")]
			public int sortId;

			// Token: 0x04004D64 RID: 19812
			[Token(Token = "0x4004D64")]
			[FieldOffset(Offset = "0x1C")]
			public FireworkData.FireworkDirectionType directionType;

			// Token: 0x04004D65 RID: 19813
			[Token(Token = "0x4004D65")]
			[FieldOffset(Offset = "0x20")]
			public string unlockLevel;

			// Token: 0x04004D66 RID: 19814
			[Token(Token = "0x4004D66")]
			[FieldOffset(Offset = "0x28")]
			public int plateRank;

			// Token: 0x04004D67 RID: 19815
			[Token(Token = "0x4004D67")]
			[FieldOffset(Offset = "0x30")]
			public List<FireworkData.PlateContent> plateContents;

			// Token: 0x04004D68 RID: 19816
			[Token(Token = "0x4004D68")]
			[FieldOffset(Offset = "0x38")]
			public bool isCraft;
		}

		// Token: 0x02000E71 RID: 3697
		[Token(Token = "0x2000E71")]
		public class AnimalData
		{
			// Token: 0x06006B3E RID: 27454 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006B3E")]
			[Address(RVA = "0x1FFDD90", Offset = "0x1FFC990", VA = "0x181FFDD90")]
			public AnimalData()
			{
			}

			// Token: 0x04004D69 RID: 19817
			[Token(Token = "0x4004D69")]
			[FieldOffset(Offset = "0x10")]
			public string animalId;

			// Token: 0x04004D6A RID: 19818
			[Token(Token = "0x4004D6A")]
			[FieldOffset(Offset = "0x18")]
			public int sortId;

			// Token: 0x04004D6B RID: 19819
			[Token(Token = "0x4004D6B")]
			[FieldOffset(Offset = "0x20")]
			public string animalName;

			// Token: 0x04004D6C RID: 19820
			[Token(Token = "0x4004D6C")]
			[FieldOffset(Offset = "0x28")]
			public string animalBuffDesc1;

			// Token: 0x04004D6D RID: 19821
			[Token(Token = "0x4004D6D")]
			[FieldOffset(Offset = "0x30")]
			public string animalBuffDesc2;

			// Token: 0x04004D6E RID: 19822
			[Token(Token = "0x4004D6E")]
			[FieldOffset(Offset = "0x38")]
			public string unlockLevel;

			// Token: 0x04004D6F RID: 19823
			[Token(Token = "0x4004D6F")]
			[FieldOffset(Offset = "0x40")]
			public FireworkData.FireworkType type;

			// Token: 0x04004D70 RID: 19824
			[Token(Token = "0x4004D70")]
			[FieldOffset(Offset = "0x48")]
			public List<string> noneOutlineUnselectIconId;

			// Token: 0x04004D71 RID: 19825
			[Token(Token = "0x4004D71")]
			[FieldOffset(Offset = "0x50")]
			public List<string> outlineIconId;

			// Token: 0x04004D72 RID: 19826
			[Token(Token = "0x4004D72")]
			[FieldOffset(Offset = "0x58")]
			public List<string> noneOutlineSelectIconId;

			// Token: 0x04004D73 RID: 19827
			[Token(Token = "0x4004D73")]
			[FieldOffset(Offset = "0x60")]
			public string unlockToast;

			// Token: 0x04004D74 RID: 19828
			[Token(Token = "0x4004D74")]
			[FieldOffset(Offset = "0x68")]
			public string unlockToastIconId;

			// Token: 0x04004D75 RID: 19829
			[Token(Token = "0x4004D75")]
			[FieldOffset(Offset = "0x70")]
			public string changedToast;

			// Token: 0x04004D76 RID: 19830
			[Token(Token = "0x4004D76")]
			[FieldOffset(Offset = "0x78")]
			public string fireworkAnimalNameIconId;
		}

		// Token: 0x02000E72 RID: 3698
		[Token(Token = "0x2000E72")]
		public class LevelData
		{
			// Token: 0x06006B3F RID: 27455 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006B3F")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public LevelData()
			{
			}

			// Token: 0x04004D77 RID: 19831
			[Token(Token = "0x4004D77")]
			[FieldOffset(Offset = "0x10")]
			public string levelId;

			// Token: 0x04004D78 RID: 19832
			[Token(Token = "0x4004D78")]
			[FieldOffset(Offset = "0x18")]
			public int sortId;

			// Token: 0x04004D79 RID: 19833
			[Token(Token = "0x4004D79")]
			[FieldOffset(Offset = "0x1C")]
			public int trapPosX;

			// Token: 0x04004D7A RID: 19834
			[Token(Token = "0x4004D7A")]
			[FieldOffset(Offset = "0x20")]
			public int trapPosY;

			// Token: 0x04004D7B RID: 19835
			[Token(Token = "0x4004D7B")]
			[FieldOffset(Offset = "0x24")]
			public bool isSPLevel;
		}

		// Token: 0x02000E73 RID: 3699
		[Token(Token = "0x2000E73")]
		public class ConstData
		{
			// Token: 0x06006B40 RID: 27456 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006B40")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ConstData()
			{
			}

			// Token: 0x04004D7C RID: 19836
			[Token(Token = "0x4004D7C")]
			[FieldOffset(Offset = "0x10")]
			public int maxFireworkNum;

			// Token: 0x04004D7D RID: 19837
			[Token(Token = "0x4004D7D")]
			[FieldOffset(Offset = "0x14")]
			public int maxFireworkPlateRowCount;

			// Token: 0x04004D7E RID: 19838
			[Token(Token = "0x4004D7E")]
			[FieldOffset(Offset = "0x18")]
			public string unlockStageCode;

			// Token: 0x04004D7F RID: 19839
			[Token(Token = "0x4004D7F")]
			[FieldOffset(Offset = "0x20")]
			public List<string> dontDisplayFireworkPluginStageList;
		}
	}
}
