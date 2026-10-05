using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02000DE8 RID: 3560
	[Token(Token = "0x2000DE8")]
	public class VersusCheckInData
	{
		// Token: 0x06006AB5 RID: 27317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006AB5")]
		[Address(RVA = "0x200E570", Offset = "0x200D170", VA = "0x18200E570")]
		public VersusCheckInData()
		{
		}

		// Token: 0x040049D8 RID: 18904
		[Token(Token = "0x40049D8")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<int, VersusCheckInData.DailyInfo> checkInDict;

		// Token: 0x040049D9 RID: 18905
		[Token(Token = "0x40049D9")]
		[FieldOffset(Offset = "0x18")]
		public List<VersusCheckInData.VoteData> voteTasteList;

		// Token: 0x040049DA RID: 18906
		[Token(Token = "0x40049DA")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<int, VersusCheckInData.TasteInfoData> tasteInfoDict;

		// Token: 0x040049DB RID: 18907
		[Token(Token = "0x40049DB")]
		[FieldOffset(Offset = "0x28")]
		public Dictionary<VersusCheckInData.TasteType, VersusCheckInData.TasteRewardData> tasteRewardDict;

		// Token: 0x040049DC RID: 18908
		[Token(Token = "0x40049DC")]
		[FieldOffset(Offset = "0x30")]
		public Dictionary<string, long> apSupplyOutOfDateDict;

		// Token: 0x040049DD RID: 18909
		[Token(Token = "0x40049DD")]
		[FieldOffset(Offset = "0x38")]
		public int versusTotalDays;

		// Token: 0x040049DE RID: 18910
		[Token(Token = "0x40049DE")]
		[FieldOffset(Offset = "0x40")]
		public string ruleText;

		// Token: 0x02000DE9 RID: 3561
		[Token(Token = "0x2000DE9")]
		[JsonConverter(typeof(StringEnumConverter))]
		public enum TasteType
		{
			// Token: 0x040049E0 RID: 18912
			[Token(Token = "0x40049E0")]
			DRAW,
			// Token: 0x040049E1 RID: 18913
			[Token(Token = "0x40049E1")]
			SWEET,
			// Token: 0x040049E2 RID: 18914
			[Token(Token = "0x40049E2")]
			SALT
		}

		// Token: 0x02000DEA RID: 3562
		[Token(Token = "0x2000DEA")]
		public class DailyInfo
		{
			// Token: 0x06006AB6 RID: 27318 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006AB6")]
			[Address(RVA = "0x2008B80", Offset = "0x2007780", VA = "0x182008B80")]
			public DailyInfo()
			{
			}

			// Token: 0x040049E3 RID: 18915
			[Token(Token = "0x40049E3")]
			[FieldOffset(Offset = "0x10")]
			public List<ItemBundle> rewardList;

			// Token: 0x040049E4 RID: 18916
			[Token(Token = "0x40049E4")]
			[FieldOffset(Offset = "0x18")]
			public int order;
		}

		// Token: 0x02000DEB RID: 3563
		[Token(Token = "0x2000DEB")]
		public class VoteData
		{
			// Token: 0x06006AB7 RID: 27319 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006AB7")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public VoteData()
			{
			}

			// Token: 0x040049E5 RID: 18917
			[Token(Token = "0x40049E5")]
			[FieldOffset(Offset = "0x10")]
			public int plSweetNum;

			// Token: 0x040049E6 RID: 18918
			[Token(Token = "0x40049E6")]
			[FieldOffset(Offset = "0x14")]
			public int plSaltyNum;

			// Token: 0x040049E7 RID: 18919
			[Token(Token = "0x40049E7")]
			[FieldOffset(Offset = "0x18")]
			public int plTaste;
		}

		// Token: 0x02000DEC RID: 3564
		[Token(Token = "0x2000DEC")]
		public class TasteInfoData
		{
			// Token: 0x06006AB8 RID: 27320 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006AB8")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public TasteInfoData()
			{
			}

			// Token: 0x040049E8 RID: 18920
			[Token(Token = "0x40049E8")]
			[FieldOffset(Offset = "0x10")]
			public int plTaste;

			// Token: 0x040049E9 RID: 18921
			[Token(Token = "0x40049E9")]
			[FieldOffset(Offset = "0x14")]
			public VersusCheckInData.TasteType tasteType;

			// Token: 0x040049EA RID: 18922
			[Token(Token = "0x40049EA")]
			[FieldOffset(Offset = "0x18")]
			public string tasteText;
		}

		// Token: 0x02000DED RID: 3565
		[Token(Token = "0x2000DED")]
		public class TasteRewardData
		{
			// Token: 0x06006AB9 RID: 27321 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006AB9")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public TasteRewardData()
			{
			}

			// Token: 0x040049EB RID: 18923
			[Token(Token = "0x40049EB")]
			[FieldOffset(Offset = "0x10")]
			public VersusCheckInData.TasteType tasteType;

			// Token: 0x040049EC RID: 18924
			[Token(Token = "0x40049EC")]
			[FieldOffset(Offset = "0x18")]
			public ItemBundle rewardItem;
		}
	}
}
