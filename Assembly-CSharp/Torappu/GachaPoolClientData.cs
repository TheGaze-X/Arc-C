using System;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;

namespace Torappu
{
	// Token: 0x0200105F RID: 4191
	[Token(Token = "0x200105F")]
	[Serializable]
	public class GachaPoolClientData : IComparable<GachaPoolClientData>, IGachaTimeData
	{
		// Token: 0x06006DE6 RID: 28134 RVA: 0x00031E00 File Offset: 0x00030000
		[Token(Token = "0x6006DE6")]
		[Address(RVA = "0x20E5CF0", Offset = "0x20E48F0", VA = "0x1820E5CF0", Slot = "7")]
		public virtual int CompareTo(GachaPoolClientData otherModel)
		{
			return 0;
		}

		// Token: 0x06006DE7 RID: 28135 RVA: 0x00031E18 File Offset: 0x00030018
		[Token(Token = "0x6006DE7")]
		[Address(RVA = "0x21051A0", Offset = "0x2103DA0", VA = "0x1821051A0", Slot = "6")]
		public bool IsValid(long curTs)
		{
			return default(bool);
		}

		// Token: 0x06006DE8 RID: 28136 RVA: 0x00031E30 File Offset: 0x00030030
		[Token(Token = "0x6006DE8")]
		[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070", Slot = "5")]
		public long GetEndTime()
		{
			return 0L;
		}

		// Token: 0x06006DE9 RID: 28137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DE9")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public GachaPoolClientData()
		{
		}

		// Token: 0x04005923 RID: 22819
		[Token(Token = "0x4005923")]
		[FieldOffset(Offset = "0x10")]
		public string gachaPoolId;

		// Token: 0x04005924 RID: 22820
		[Token(Token = "0x4005924")]
		[FieldOffset(Offset = "0x18")]
		public int gachaIndex;

		// Token: 0x04005925 RID: 22821
		[Token(Token = "0x4005925")]
		[FieldOffset(Offset = "0x20")]
		public long openTime;

		// Token: 0x04005926 RID: 22822
		[Token(Token = "0x4005926")]
		[FieldOffset(Offset = "0x28")]
		public long endTime;

		// Token: 0x04005927 RID: 22823
		[Token(Token = "0x4005927")]
		[FieldOffset(Offset = "0x30")]
		public string gachaPoolName;

		// Token: 0x04005928 RID: 22824
		[Token(Token = "0x4005928")]
		[FieldOffset(Offset = "0x38")]
		public string gachaPoolSummary;

		// Token: 0x04005929 RID: 22825
		[Token(Token = "0x4005929")]
		[FieldOffset(Offset = "0x40")]
		public string gachaPoolDetail;

		// Token: 0x0400592A RID: 22826
		[Token(Token = "0x400592A")]
		[FieldOffset(Offset = "0x48")]
		public string guaranteeName;

		// Token: 0x0400592B RID: 22827
		[Token(Token = "0x400592B")]
		[FieldOffset(Offset = "0x50")]
		public int guarantee5Avail;

		// Token: 0x0400592C RID: 22828
		[Token(Token = "0x400592C")]
		[FieldOffset(Offset = "0x54")]
		public int guarantee5Count;

		// Token: 0x0400592D RID: 22829
		[Token(Token = "0x400592D")]
		[FieldOffset(Offset = "0x58")]
		public string LMTGSID;

		// Token: 0x0400592E RID: 22830
		[Token(Token = "0x400592E")]
		[FieldOffset(Offset = "0x60")]
		public string CDPrimColor;

		// Token: 0x0400592F RID: 22831
		[Token(Token = "0x400592F")]
		[FieldOffset(Offset = "0x68")]
		public string CDSecColor;

		// Token: 0x04005930 RID: 22832
		[Token(Token = "0x4005930")]
		[FieldOffset(Offset = "0x70")]
		public string freeBackColor;

		// Token: 0x04005931 RID: 22833
		[Token(Token = "0x4005931")]
		[FieldOffset(Offset = "0x78")]
		public GachaRuleType gachaRuleType;

		// Token: 0x04005932 RID: 22834
		[Token(Token = "0x4005932")]
		[FieldOffset(Offset = "0x80")]
		public JObject dynMeta;

		// Token: 0x04005933 RID: 22835
		[Token(Token = "0x4005933")]
		[FieldOffset(Offset = "0x88")]
		public string linkageRuleId;

		// Token: 0x04005934 RID: 22836
		[Token(Token = "0x4005934")]
		[FieldOffset(Offset = "0x90")]
		public JObject linkageParam;

		// Token: 0x04005935 RID: 22837
		[Token(Token = "0x4005935")]
		[FieldOffset(Offset = "0x98")]
		public JObject limitParam;
	}
}
