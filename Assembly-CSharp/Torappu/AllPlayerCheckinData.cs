using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000DEE RID: 3566
	[Token(Token = "0x2000DEE")]
	public class AllPlayerCheckinData
	{
		// Token: 0x06006ABA RID: 27322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006ABA")]
		[Address(RVA = "0x1FFDBE0", Offset = "0x1FFC7E0", VA = "0x181FFDBE0")]
		public AllPlayerCheckinData()
		{
		}

		// Token: 0x040049ED RID: 18925
		[Token(Token = "0x40049ED")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<int, AllPlayerCheckinData.DailyInfo> checkInList;

		// Token: 0x040049EE RID: 18926
		[Token(Token = "0x40049EE")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, long> apSupplyOutOfDateDict;

		// Token: 0x040049EF RID: 18927
		[Token(Token = "0x40049EF")]
		[FieldOffset(Offset = "0x20")]
		public ListDict<string, AllPlayerCheckinData.PublicBehaviour> pubBhvs;

		// Token: 0x040049F0 RID: 18928
		[Token(Token = "0x40049F0")]
		[FieldOffset(Offset = "0x28")]
		public ListDict<string, AllPlayerCheckinData.PersonalBehaviour> personalBhvs;

		// Token: 0x040049F1 RID: 18929
		[Token(Token = "0x40049F1")]
		[FieldOffset(Offset = "0x30")]
		public AllPlayerCheckinData.ConstData constData;

		// Token: 0x02000DEF RID: 3567
		[Token(Token = "0x2000DEF")]
		public class DailyInfo
		{
			// Token: 0x06006ABB RID: 27323 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006ABB")]
			[Address(RVA = "0x2008AF0", Offset = "0x20076F0", VA = "0x182008AF0")]
			public DailyInfo()
			{
			}

			// Token: 0x040049F2 RID: 18930
			[Token(Token = "0x40049F2")]
			[FieldOffset(Offset = "0x10")]
			public List<ItemBundle> itemList;

			// Token: 0x040049F3 RID: 18931
			[Token(Token = "0x40049F3")]
			[FieldOffset(Offset = "0x18")]
			public int order;

			// Token: 0x040049F4 RID: 18932
			[Token(Token = "0x40049F4")]
			[FieldOffset(Offset = "0x1C")]
			public bool keyItem;

			// Token: 0x040049F5 RID: 18933
			[Token(Token = "0x40049F5")]
			[FieldOffset(Offset = "0x20")]
			public int showItemOrder;
		}

		// Token: 0x02000DF0 RID: 3568
		[Token(Token = "0x2000DF0")]
		public class PublicBehaviour
		{
			// Token: 0x06006ABC RID: 27324 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006ABC")]
			[Address(RVA = "0x200C980", Offset = "0x200B580", VA = "0x18200C980")]
			public PublicBehaviour()
			{
			}

			// Token: 0x040049F6 RID: 18934
			[Token(Token = "0x40049F6")]
			[FieldOffset(Offset = "0x10")]
			public int sortId;

			// Token: 0x040049F7 RID: 18935
			[Token(Token = "0x40049F7")]
			[FieldOffset(Offset = "0x18")]
			public string allBehaviorId;

			// Token: 0x040049F8 RID: 18936
			[Token(Token = "0x40049F8")]
			[FieldOffset(Offset = "0x20")]
			public int displayOrder;

			// Token: 0x040049F9 RID: 18937
			[Token(Token = "0x40049F9")]
			[FieldOffset(Offset = "0x28")]
			public string allBehaviorDesc;

			// Token: 0x040049FA RID: 18938
			[Token(Token = "0x40049FA")]
			[FieldOffset(Offset = "0x30")]
			public int requiringValue;

			// Token: 0x040049FB RID: 18939
			[Token(Token = "0x40049FB")]
			[FieldOffset(Offset = "0x34")]
			public bool requireRepeatCompletion;

			// Token: 0x040049FC RID: 18940
			[Token(Token = "0x40049FC")]
			[FieldOffset(Offset = "0x38")]
			public string rewardReceivedDesc;

			// Token: 0x040049FD RID: 18941
			[Token(Token = "0x40049FD")]
			[FieldOffset(Offset = "0x40")]
			public List<ItemBundle> rewards;
		}

		// Token: 0x02000DF1 RID: 3569
		[Token(Token = "0x2000DF1")]
		public class PersonalBehaviour
		{
			// Token: 0x06006ABD RID: 27325 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006ABD")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public PersonalBehaviour()
			{
			}

			// Token: 0x040049FE RID: 18942
			[Token(Token = "0x40049FE")]
			[FieldOffset(Offset = "0x10")]
			public int sortId;

			// Token: 0x040049FF RID: 18943
			[Token(Token = "0x40049FF")]
			[FieldOffset(Offset = "0x18")]
			public string personalBehaviorId;

			// Token: 0x04004A00 RID: 18944
			[Token(Token = "0x4004A00")]
			[FieldOffset(Offset = "0x20")]
			public int displayOrder;

			// Token: 0x04004A01 RID: 18945
			[Token(Token = "0x4004A01")]
			[FieldOffset(Offset = "0x24")]
			public bool requireRepeatCompletion;

			// Token: 0x04004A02 RID: 18946
			[Token(Token = "0x4004A02")]
			[FieldOffset(Offset = "0x28")]
			public string desc;
		}

		// Token: 0x02000DF2 RID: 3570
		[Token(Token = "0x2000DF2")]
		public class ConstData
		{
			// Token: 0x06006ABE RID: 27326 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006ABE")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ConstData()
			{
			}

			// Token: 0x04004A03 RID: 18947
			[Token(Token = "0x4004A03")]
			[FieldOffset(Offset = "0x10")]
			public string characterName;

			// Token: 0x04004A04 RID: 18948
			[Token(Token = "0x4004A04")]
			[FieldOffset(Offset = "0x18")]
			public string skinName;
		}
	}
}
