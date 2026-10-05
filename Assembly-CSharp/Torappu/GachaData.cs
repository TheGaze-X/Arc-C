using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001069 RID: 4201
	[Token(Token = "0x2001069")]
	[Serializable]
	public class GachaData
	{
		// Token: 0x06006DF4 RID: 28148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DF4")]
		[Address(RVA = "0x2104DF0", Offset = "0x21039F0", VA = "0x182104DF0")]
		public GachaData()
		{
		}

		// Token: 0x04005950 RID: 22864
		[Token(Token = "0x4005950")]
		[FieldOffset(Offset = "0x10")]
		public GachaPoolClientData[] gachaPoolClient;

		// Token: 0x04005951 RID: 22865
		[Token(Token = "0x4005951")]
		[FieldOffset(Offset = "0x18")]
		public NewbeeGachaPoolClientData[] newbeeGachaPoolClient;

		// Token: 0x04005952 RID: 22866
		[Token(Token = "0x4005952")]
		[FieldOffset(Offset = "0x20")]
		public SpecialRecruitPool[] specialRecruitPool;

		// Token: 0x04005953 RID: 22867
		[Token(Token = "0x4005953")]
		[FieldOffset(Offset = "0x28")]
		public GachaTag[] gachaTags;

		// Token: 0x04005954 RID: 22868
		[Token(Token = "0x4005954")]
		[FieldOffset(Offset = "0x30")]
		public RecruitPool recruitPool;

		// Token: 0x04005955 RID: 22869
		[Token(Token = "0x4005955")]
		[FieldOffset(Offset = "0x38")]
		public PotentialMaterialConverterConfig potentialMaterialConverter;

		// Token: 0x04005956 RID: 22870
		[Token(Token = "0x4005956")]
		[FieldOffset(Offset = "0x40")]
		public PotentialMaterialConverterConfig classicPotentialMaterialConverter;

		// Token: 0x04005957 RID: 22871
		[Token(Token = "0x4005957")]
		[FieldOffset(Offset = "0x48")]
		public Dictionary<int, GachaData.RecruitRange> recruitRarityTable;

		// Token: 0x04005958 RID: 22872
		[Token(Token = "0x4005958")]
		[FieldOffset(Offset = "0x50")]
		public Dictionary<int, List<int>> specialTagRarityTable;

		// Token: 0x04005959 RID: 22873
		[Token(Token = "0x4005959")]
		[FieldOffset(Offset = "0x58")]
		public string recruitDetail;

		// Token: 0x0400595A RID: 22874
		[Token(Token = "0x400595A")]
		[FieldOffset(Offset = "0x60")]
		public bool showGachaLogEntry;

		// Token: 0x0400595B RID: 22875
		[Token(Token = "0x400595B")]
		[FieldOffset(Offset = "0x68")]
		public List<GachaData.CarouselData> carousel;

		// Token: 0x0400595C RID: 22876
		[Token(Token = "0x400595C")]
		[FieldOffset(Offset = "0x70")]
		public List<GachaData.FreeLimitGachaData> freeGacha;

		// Token: 0x0400595D RID: 22877
		[Token(Token = "0x400595D")]
		[FieldOffset(Offset = "0x78")]
		public List<GachaData.LimitTenGachaTkt> limitTenGachaItem;

		// Token: 0x0400595E RID: 22878
		[Token(Token = "0x400595E")]
		[FieldOffset(Offset = "0x80")]
		public List<GachaData.LinkageTenGachaTkt> linkageTenGachaItem;

		// Token: 0x0400595F RID: 22879
		[Token(Token = "0x400595F")]
		[FieldOffset(Offset = "0x88")]
		public List<GachaData.NormalGachaTkt> normalGachaItem;

		// Token: 0x04005960 RID: 22880
		[Token(Token = "0x4005960")]
		[FieldOffset(Offset = "0x90")]
		public Dictionary<string, GachaData.FesGachaPoolRelateItem> fesGachaPoolRelateItem;

		// Token: 0x04005961 RID: 22881
		[Token(Token = "0x4005961")]
		[FieldOffset(Offset = "0x98")]
		public Dictionary<string, string> dicRecruit6StarHint;

		// Token: 0x04005962 RID: 22882
		[Token(Token = "0x4005962")]
		[FieldOffset(Offset = "0xA0")]
		public Dictionary<int, float> specialGachaPercentDict;

		// Token: 0x0200106A RID: 4202
		[Token(Token = "0x200106A")]
		public class RecruitRange
		{
			// Token: 0x06006DF5 RID: 28149 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006DF5")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public RecruitRange()
			{
			}

			// Token: 0x04005963 RID: 22883
			[Token(Token = "0x4005963")]
			[FieldOffset(Offset = "0x10")]
			public int rarityStart;

			// Token: 0x04005964 RID: 22884
			[Token(Token = "0x4005964")]
			[FieldOffset(Offset = "0x14")]
			public int rarityEnd;
		}

		// Token: 0x0200106B RID: 4203
		[Token(Token = "0x200106B")]
		public class CarouselData
		{
			// Token: 0x06006DF6 RID: 28150 RVA: 0x00031E60 File Offset: 0x00030060
			[Token(Token = "0x6006DF6")]
			[Address(RVA = "0x20FF250", Offset = "0x20FDE50", VA = "0x1820FF250")]
			public bool IsValid(long curTs)
			{
				return default(bool);
			}

			// Token: 0x06006DF7 RID: 28151 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006DF7")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public CarouselData()
			{
			}

			// Token: 0x04005965 RID: 22885
			[Token(Token = "0x4005965")]
			[FieldOffset(Offset = "0x10")]
			public string poolId;

			// Token: 0x04005966 RID: 22886
			[Token(Token = "0x4005966")]
			[FieldOffset(Offset = "0x18")]
			public int index;

			// Token: 0x04005967 RID: 22887
			[Token(Token = "0x4005967")]
			[FieldOffset(Offset = "0x20")]
			public long startTime;

			// Token: 0x04005968 RID: 22888
			[Token(Token = "0x4005968")]
			[FieldOffset(Offset = "0x28")]
			public long endTime;

			// Token: 0x04005969 RID: 22889
			[Token(Token = "0x4005969")]
			[FieldOffset(Offset = "0x30")]
			public string spriteId;
		}

		// Token: 0x0200106C RID: 4204
		[Token(Token = "0x200106C")]
		public class FreeLimitGachaData
		{
			// Token: 0x06006DF8 RID: 28152 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006DF8")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public FreeLimitGachaData()
			{
			}

			// Token: 0x0400596A RID: 22890
			[Token(Token = "0x400596A")]
			[FieldOffset(Offset = "0x10")]
			public string poolId;

			// Token: 0x0400596B RID: 22891
			[Token(Token = "0x400596B")]
			[FieldOffset(Offset = "0x18")]
			public long openTime;

			// Token: 0x0400596C RID: 22892
			[Token(Token = "0x400596C")]
			[FieldOffset(Offset = "0x20")]
			public long endTime;

			// Token: 0x0400596D RID: 22893
			[Token(Token = "0x400596D")]
			[FieldOffset(Offset = "0x28")]
			public int freeCount;
		}

		// Token: 0x0200106D RID: 4205
		[Token(Token = "0x200106D")]
		public class LimitTenGachaTkt : IGachaTimeData
		{
			// Token: 0x06006DF9 RID: 28153 RVA: 0x00031E78 File Offset: 0x00030078
			[Token(Token = "0x6006DF9")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80", Slot = "4")]
			public long GetEndTime()
			{
				return 0L;
			}

			// Token: 0x06006DFA RID: 28154 RVA: 0x00031E90 File Offset: 0x00030090
			[Token(Token = "0x6006DFA")]
			[Address(RVA = "0x2106B80", Offset = "0x2105780", VA = "0x182106B80", Slot = "5")]
			public bool IsValid(long curTs)
			{
				return default(bool);
			}

			// Token: 0x06006DFB RID: 28155 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006DFB")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public LimitTenGachaTkt()
			{
			}

			// Token: 0x0400596E RID: 22894
			[Token(Token = "0x400596E")]
			[FieldOffset(Offset = "0x10")]
			public string itemId;

			// Token: 0x0400596F RID: 22895
			[Token(Token = "0x400596F")]
			[FieldOffset(Offset = "0x18")]
			public long endTime;
		}

		// Token: 0x0200106E RID: 4206
		[Token(Token = "0x200106E")]
		public class FesGachaPoolRelateItem
		{
			// Token: 0x06006DFC RID: 28156 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006DFC")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public FesGachaPoolRelateItem()
			{
			}

			// Token: 0x04005970 RID: 22896
			[Token(Token = "0x4005970")]
			[FieldOffset(Offset = "0x10")]
			public string rarityRank5ItemId;

			// Token: 0x04005971 RID: 22897
			[Token(Token = "0x4005971")]
			[FieldOffset(Offset = "0x18")]
			public string rarityRank6ItemId;
		}

		// Token: 0x0200106F RID: 4207
		[Token(Token = "0x200106F")]
		public class LinkageTenGachaTkt : IGachaTimeData
		{
			// Token: 0x06006DFD RID: 28157 RVA: 0x00031EA8 File Offset: 0x000300A8
			[Token(Token = "0x6006DFD")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80", Slot = "4")]
			public long GetEndTime()
			{
				return 0L;
			}

			// Token: 0x06006DFE RID: 28158 RVA: 0x00031EC0 File Offset: 0x000300C0
			[Token(Token = "0x6006DFE")]
			[Address(RVA = "0x2106B80", Offset = "0x2105780", VA = "0x182106B80", Slot = "5")]
			public bool IsValid(long curTs)
			{
				return default(bool);
			}

			// Token: 0x06006DFF RID: 28159 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006DFF")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public LinkageTenGachaTkt()
			{
			}

			// Token: 0x04005972 RID: 22898
			[Token(Token = "0x4005972")]
			[FieldOffset(Offset = "0x10")]
			public string itemId;

			// Token: 0x04005973 RID: 22899
			[Token(Token = "0x4005973")]
			[FieldOffset(Offset = "0x18")]
			public long endTime;

			// Token: 0x04005974 RID: 22900
			[Token(Token = "0x4005974")]
			[FieldOffset(Offset = "0x20")]
			public string gachaPoolId;
		}

		// Token: 0x02001070 RID: 4208
		[Token(Token = "0x2001070")]
		public class NormalGachaTkt : IGachaTimeData
		{
			// Token: 0x06006E00 RID: 28160 RVA: 0x00031ED8 File Offset: 0x000300D8
			[Token(Token = "0x6006E00")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80", Slot = "4")]
			public long GetEndTime()
			{
				return 0L;
			}

			// Token: 0x06006E01 RID: 28161 RVA: 0x00031EF0 File Offset: 0x000300F0
			[Token(Token = "0x6006E01")]
			[Address(RVA = "0x2106B80", Offset = "0x2105780", VA = "0x182106B80", Slot = "5")]
			public bool IsValid(long curTs)
			{
				return default(bool);
			}

			// Token: 0x06006E02 RID: 28162 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006E02")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public NormalGachaTkt()
			{
			}

			// Token: 0x04005975 RID: 22901
			[Token(Token = "0x4005975")]
			[FieldOffset(Offset = "0x10")]
			public string itemId;

			// Token: 0x04005976 RID: 22902
			[Token(Token = "0x4005976")]
			[FieldOffset(Offset = "0x18")]
			public long endTime;

			// Token: 0x04005977 RID: 22903
			[Token(Token = "0x4005977")]
			[FieldOffset(Offset = "0x20")]
			public string gachaPoolId;

			// Token: 0x04005978 RID: 22904
			[Token(Token = "0x4005978")]
			[FieldOffset(Offset = "0x28")]
			public bool isTen;
		}
	}
}
