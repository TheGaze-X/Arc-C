using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000DE1 RID: 3553
	[Token(Token = "0x2000DE1")]
	public class DefaultCheckInData
	{
		// Token: 0x06006AAD RID: 27309 RVA: 0x000310E0 File Offset: 0x0002F2E0
		[Token(Token = "0x6006AAD")]
		[Address(RVA = "0x926F60", Offset = "0x925B60", VA = "0x180926F60")]
		public bool ShouldSerializedynCheckInData()
		{
			return default(bool);
		}

		// Token: 0x06006AAE RID: 27310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006AAE")]
		[Address(RVA = "0x2008E00", Offset = "0x2007A00", VA = "0x182008E00")]
		public DefaultCheckInData()
		{
		}

		// Token: 0x040049B3 RID: 18867
		[Token(Token = "0x40049B3")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<int, DefaultCheckInData.CheckInDailyInfo> checkInList;

		// Token: 0x040049B4 RID: 18868
		[Token(Token = "0x40049B4")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, long> apSupplyOutOfDateDict;

		// Token: 0x040049B5 RID: 18869
		[Token(Token = "0x40049B5")]
		[FieldOffset(Offset = "0x20")]
		public DefaultCheckInData.DynamicCheckInData dynCheckInData;

		// Token: 0x040049B6 RID: 18870
		[Token(Token = "0x40049B6")]
		[FieldOffset(Offset = "0x28")]
		public List<DefaultCheckInData.ExtraCheckinDailyInfo> extraCheckinList;

		// Token: 0x02000DE2 RID: 3554
		[Token(Token = "0x2000DE2")]
		public class CheckInDailyInfo
		{
			// Token: 0x06006AAF RID: 27311 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006AAF")]
			[Address(RVA = "0x2008590", Offset = "0x2007190", VA = "0x182008590")]
			public CheckInDailyInfo()
			{
			}

			// Token: 0x040049B7 RID: 18871
			[Token(Token = "0x40049B7")]
			[FieldOffset(Offset = "0x10")]
			public List<ItemBundle> itemList;

			// Token: 0x040049B8 RID: 18872
			[Token(Token = "0x40049B8")]
			[FieldOffset(Offset = "0x18")]
			public int order;

			// Token: 0x040049B9 RID: 18873
			[Token(Token = "0x40049B9")]
			[FieldOffset(Offset = "0x1C")]
			public int color;

			// Token: 0x040049BA RID: 18874
			[Token(Token = "0x40049BA")]
			[FieldOffset(Offset = "0x20")]
			public int keyItem;

			// Token: 0x040049BB RID: 18875
			[Token(Token = "0x40049BB")]
			[FieldOffset(Offset = "0x24")]
			public int showItemOrder;

			// Token: 0x040049BC RID: 18876
			[Token(Token = "0x40049BC")]
			[FieldOffset(Offset = "0x28")]
			public bool isDynItem;
		}

		// Token: 0x02000DE3 RID: 3555
		[Token(Token = "0x2000DE3")]
		public class DynCheckInDailyInfo
		{
			// Token: 0x06006AB0 RID: 27312 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006AB0")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public DynCheckInDailyInfo()
			{
			}

			// Token: 0x040049BD RID: 18877
			[Token(Token = "0x40049BD")]
			[FieldOffset(Offset = "0x10")]
			public string questionDesc;

			// Token: 0x040049BE RID: 18878
			[Token(Token = "0x40049BE")]
			[FieldOffset(Offset = "0x18")]
			public string preOption;

			// Token: 0x040049BF RID: 18879
			[Token(Token = "0x40049BF")]
			[FieldOffset(Offset = "0x20")]
			public List<string> optionList;

			// Token: 0x040049C0 RID: 18880
			[Token(Token = "0x40049C0")]
			[FieldOffset(Offset = "0x28")]
			public int showDay;

			// Token: 0x040049C1 RID: 18881
			[Token(Token = "0x40049C1")]
			[FieldOffset(Offset = "0x30")]
			public string spOrderIconId;

			// Token: 0x040049C2 RID: 18882
			[Token(Token = "0x40049C2")]
			[FieldOffset(Offset = "0x38")]
			public string spOrderDesc;

			// Token: 0x040049C3 RID: 18883
			[Token(Token = "0x40049C3")]
			[FieldOffset(Offset = "0x40")]
			public string spOrderCompleteDesc;
		}

		// Token: 0x02000DE4 RID: 3556
		[Token(Token = "0x2000DE4")]
		public class OptionInfo
		{
			// Token: 0x06006AB1 RID: 27313 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006AB1")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public OptionInfo()
			{
			}

			// Token: 0x040049C4 RID: 18884
			[Token(Token = "0x40049C4")]
			[FieldOffset(Offset = "0x10")]
			public string optionDesc;

			// Token: 0x040049C5 RID: 18885
			[Token(Token = "0x40049C5")]
			[FieldOffset(Offset = "0x18")]
			public string showImageId1;

			// Token: 0x040049C6 RID: 18886
			[Token(Token = "0x40049C6")]
			[FieldOffset(Offset = "0x20")]
			public string showImageId2;

			// Token: 0x040049C7 RID: 18887
			[Token(Token = "0x40049C7")]
			[FieldOffset(Offset = "0x28")]
			public string optionCompleteDesc;

			// Token: 0x040049C8 RID: 18888
			[Token(Token = "0x40049C8")]
			[FieldOffset(Offset = "0x30")]
			public bool isStart;
		}

		// Token: 0x02000DE5 RID: 3557
		[Token(Token = "0x2000DE5")]
		public class ExtraCheckinDailyInfo
		{
			// Token: 0x06006AB2 RID: 27314 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006AB2")]
			[Address(RVA = "0x2009AD0", Offset = "0x20086D0", VA = "0x182009AD0")]
			public ExtraCheckinDailyInfo()
			{
			}

			// Token: 0x040049C9 RID: 18889
			[Token(Token = "0x40049C9")]
			[FieldOffset(Offset = "0x10")]
			public int order;

			// Token: 0x040049CA RID: 18890
			[Token(Token = "0x40049CA")]
			[FieldOffset(Offset = "0x18")]
			public string blessing;

			// Token: 0x040049CB RID: 18891
			[Token(Token = "0x40049CB")]
			[FieldOffset(Offset = "0x20")]
			public long absolutData;

			// Token: 0x040049CC RID: 18892
			[Token(Token = "0x40049CC")]
			[FieldOffset(Offset = "0x28")]
			public string adTip;

			// Token: 0x040049CD RID: 18893
			[Token(Token = "0x40049CD")]
			[FieldOffset(Offset = "0x30")]
			public int relativeData;

			// Token: 0x040049CE RID: 18894
			[Token(Token = "0x40049CE")]
			[FieldOffset(Offset = "0x38")]
			public List<ItemBundle> itemList;
		}

		// Token: 0x02000DE6 RID: 3558
		[Token(Token = "0x2000DE6")]
		public class DynamicCheckInData
		{
			// Token: 0x06006AB3 RID: 27315 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006AB3")]
			[Address(RVA = "0x2009970", Offset = "0x2008570", VA = "0x182009970")]
			public DynamicCheckInData()
			{
			}

			// Token: 0x040049CF RID: 18895
			[Token(Token = "0x40049CF")]
			[FieldOffset(Offset = "0x10")]
			public Dictionary<string, DefaultCheckInData.DynCheckInDailyInfo> dynCheckInDict;

			// Token: 0x040049D0 RID: 18896
			[Token(Token = "0x40049D0")]
			[FieldOffset(Offset = "0x18")]
			public Dictionary<string, DefaultCheckInData.OptionInfo> dynOptionDict;

			// Token: 0x040049D1 RID: 18897
			[Token(Token = "0x40049D1")]
			[FieldOffset(Offset = "0x20")]
			public Dictionary<string, List<ItemBundle>> dynItemDict;

			// Token: 0x040049D2 RID: 18898
			[Token(Token = "0x40049D2")]
			[FieldOffset(Offset = "0x28")]
			public DefaultCheckInData.DynamicCheckInConsts constData;

			// Token: 0x040049D3 RID: 18899
			[Token(Token = "0x40049D3")]
			[FieldOffset(Offset = "0x30")]
			public string initOption;
		}

		// Token: 0x02000DE7 RID: 3559
		[Token(Token = "0x2000DE7")]
		public class DynamicCheckInConsts
		{
			// Token: 0x06006AB4 RID: 27316 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006AB4")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public DynamicCheckInConsts()
			{
			}

			// Token: 0x040049D4 RID: 18900
			[Token(Token = "0x40049D4")]
			[FieldOffset(Offset = "0x10")]
			public string firstQuestionDesc;

			// Token: 0x040049D5 RID: 18901
			[Token(Token = "0x40049D5")]
			[FieldOffset(Offset = "0x18")]
			public string firstQuestionTipsDesc;

			// Token: 0x040049D6 RID: 18902
			[Token(Token = "0x40049D6")]
			[FieldOffset(Offset = "0x20")]
			public string expirationDesc;

			// Token: 0x040049D7 RID: 18903
			[Token(Token = "0x40049D7")]
			[FieldOffset(Offset = "0x28")]
			public string firstQuestionConfirmDesc;
		}
	}
}
