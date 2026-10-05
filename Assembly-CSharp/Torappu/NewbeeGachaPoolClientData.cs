using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001060 RID: 4192
	[Token(Token = "0x2001060")]
	[Serializable]
	public class NewbeeGachaPoolClientData : IComparable<NewbeeGachaPoolClientData>
	{
		// Token: 0x06006DEA RID: 28138 RVA: 0x00031E48 File Offset: 0x00030048
		[Token(Token = "0x6006DEA")]
		[Address(RVA = "0x20E5CF0", Offset = "0x20E48F0", VA = "0x1820E5CF0", Slot = "5")]
		public virtual int CompareTo(NewbeeGachaPoolClientData otherModel)
		{
			return 0;
		}

		// Token: 0x06006DEB RID: 28139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DEB")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public NewbeeGachaPoolClientData()
		{
		}

		// Token: 0x04005936 RID: 22838
		[Token(Token = "0x4005936")]
		[FieldOffset(Offset = "0x10")]
		public string gachaPoolId;

		// Token: 0x04005937 RID: 22839
		[Token(Token = "0x4005937")]
		[FieldOffset(Offset = "0x18")]
		public int gachaIndex;

		// Token: 0x04005938 RID: 22840
		[Token(Token = "0x4005938")]
		[FieldOffset(Offset = "0x20")]
		public string gachaPoolName;

		// Token: 0x04005939 RID: 22841
		[Token(Token = "0x4005939")]
		[FieldOffset(Offset = "0x28")]
		public string gachaPoolDetail;

		// Token: 0x0400593A RID: 22842
		[Token(Token = "0x400593A")]
		[FieldOffset(Offset = "0x30")]
		public int gachaPrice;

		// Token: 0x0400593B RID: 22843
		[Token(Token = "0x400593B")]
		[FieldOffset(Offset = "0x34")]
		public int gachaTimes;

		// Token: 0x0400593C RID: 22844
		[Token(Token = "0x400593C")]
		[FieldOffset(Offset = "0x38")]
		public string gachaOffset;
	}
}
