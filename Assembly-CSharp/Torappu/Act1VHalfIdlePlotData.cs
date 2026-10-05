using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000C8F RID: 3215
	[Token(Token = "0x2000C8F")]
	public class Act1VHalfIdlePlotData
	{
		// Token: 0x0600696A RID: 26986 RVA: 0x00030D50 File Offset: 0x0002EF50
		[Token(Token = "0x600696A")]
		[Address(RVA = "0x1FF3DD0", Offset = "0x1FF29D0", VA = "0x181FF3DD0")]
		public bool ShouldSerializederivedPlots()
		{
			return default(bool);
		}

		// Token: 0x0600696B RID: 26987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600696B")]
		[Address(RVA = "0x1FF3E20", Offset = "0x1FF2A20", VA = "0x181FF3E20")]
		public Act1VHalfIdlePlotData()
		{
		}

		// Token: 0x040041A4 RID: 16804
		[Token(Token = "0x40041A4")]
		[FieldOffset(Offset = "0x10")]
		public string plotId;

		// Token: 0x040041A5 RID: 16805
		[Token(Token = "0x40041A5")]
		[FieldOffset(Offset = "0x18")]
		public string plotName;

		// Token: 0x040041A6 RID: 16806
		[Token(Token = "0x40041A6")]
		[FieldOffset(Offset = "0x20")]
		public Act1VHalfIdlePlotType plotType;

		// Token: 0x040041A7 RID: 16807
		[Token(Token = "0x40041A7")]
		[FieldOffset(Offset = "0x28")]
		public string trapId;

		// Token: 0x040041A8 RID: 16808
		[Token(Token = "0x40041A8")]
		[FieldOffset(Offset = "0x30")]
		public bool initUnlock;

		// Token: 0x040041A9 RID: 16809
		[Token(Token = "0x40041A9")]
		[FieldOffset(Offset = "0x34")]
		public int rarity;

		// Token: 0x040041AA RID: 16810
		[Token(Token = "0x40041AA")]
		[FieldOffset(Offset = "0x38")]
		public int sortId;

		// Token: 0x040041AB RID: 16811
		[Token(Token = "0x40041AB")]
		[FieldOffset(Offset = "0x3C")]
		public bool isBasePlot;

		// Token: 0x040041AC RID: 16812
		[Token(Token = "0x40041AC")]
		[FieldOffset(Offset = "0x40")]
		public string iconId;

		// Token: 0x040041AD RID: 16813
		[Token(Token = "0x40041AD")]
		[FieldOffset(Offset = "0x48")]
		public string funcDesc;

		// Token: 0x040041AE RID: 16814
		[Token(Token = "0x40041AE")]
		[FieldOffset(Offset = "0x50")]
		public string flavorDesc;

		// Token: 0x040041AF RID: 16815
		[Token(Token = "0x40041AF")]
		[FieldOffset(Offset = "0x58")]
		public List<string> enemyIds;

		// Token: 0x040041B0 RID: 16816
		[Token(Token = "0x40041B0")]
		[FieldOffset(Offset = "0x60")]
		public string enemyDesc;

		// Token: 0x040041B1 RID: 16817
		[Token(Token = "0x40041B1")]
		[FieldOffset(Offset = "0x68")]
		public string itemIdShown;

		// Token: 0x040041B2 RID: 16818
		[Token(Token = "0x40041B2")]
		[FieldOffset(Offset = "0x70")]
		public List<Act1VHalfIdlePlotData.ItemDropData> itemDropData;

		// Token: 0x040041B3 RID: 16819
		[Token(Token = "0x40041B3")]
		[FieldOffset(Offset = "0x78")]
		public Act1VHalfIdlePlotData.PlotCombineData prevCombineData;

		// Token: 0x040041B4 RID: 16820
		[Token(Token = "0x40041B4")]
		[FieldOffset(Offset = "0x80")]
		public List<string> derivedPlots;

		// Token: 0x02000C90 RID: 3216
		[Token(Token = "0x2000C90")]
		public class ItemDropData
		{
			// Token: 0x0600696C RID: 26988 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600696C")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ItemDropData()
			{
			}

			// Token: 0x040041B5 RID: 16821
			[Token(Token = "0x40041B5")]
			[FieldOffset(Offset = "0x10")]
			public string itemId;

			// Token: 0x040041B6 RID: 16822
			[Token(Token = "0x40041B6")]
			[FieldOffset(Offset = "0x18")]
			public string itemDropDesc;
		}

		// Token: 0x02000C91 RID: 3217
		[Token(Token = "0x2000C91")]
		public class PlotCombineData
		{
			// Token: 0x0600696D RID: 26989 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600696D")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public PlotCombineData()
			{
			}

			// Token: 0x040041B7 RID: 16823
			[Token(Token = "0x40041B7")]
			[FieldOffset(Offset = "0x10")]
			public Act1VHalfIdlePlotCombineType combineType;

			// Token: 0x040041B8 RID: 16824
			[Token(Token = "0x40041B8")]
			[FieldOffset(Offset = "0x18")]
			public Act1VHalfIdlePlotData.PlotCombineData.CombineItemData[] plots;

			// Token: 0x02000C92 RID: 3218
			[Token(Token = "0x2000C92")]
			public class CombineItemData
			{
				// Token: 0x0600696E RID: 26990 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600696E")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public CombineItemData()
				{
				}

				// Token: 0x040041B9 RID: 16825
				[Token(Token = "0x40041B9")]
				[FieldOffset(Offset = "0x10")]
				public string plotId;

				// Token: 0x040041BA RID: 16826
				[Token(Token = "0x40041BA")]
				[FieldOffset(Offset = "0x18")]
				public int plotCount;
			}
		}
	}
}
