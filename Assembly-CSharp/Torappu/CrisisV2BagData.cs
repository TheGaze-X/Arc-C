using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000FC5 RID: 4037
	[Token(Token = "0x2000FC5")]
	public class CrisisV2BagData
	{
		// Token: 0x06006D0F RID: 27919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D0F")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public CrisisV2BagData()
		{
		}

		// Token: 0x040055B4 RID: 21940
		[Token(Token = "0x40055B4")]
		[FieldOffset(Offset = "0x10")]
		public string slotPackId;

		// Token: 0x040055B5 RID: 21941
		[Token(Token = "0x40055B5")]
		[FieldOffset(Offset = "0x18")]
		public CrisisV2RunePackType slotPackType;

		// Token: 0x040055B6 RID: 21942
		[Token(Token = "0x40055B6")]
		[FieldOffset(Offset = "0x20")]
		public string mapId;

		// Token: 0x040055B7 RID: 21943
		[Token(Token = "0x40055B7")]
		[FieldOffset(Offset = "0x28")]
		public string mapSlotId;

		// Token: 0x040055B8 RID: 21944
		[Token(Token = "0x40055B8")]
		[FieldOffset(Offset = "0x30")]
		public string slotPackName;

		// Token: 0x040055B9 RID: 21945
		[Token(Token = "0x40055B9")]
		[FieldOffset(Offset = "0x38")]
		public string slotPackFullName;

		// Token: 0x040055BA RID: 21946
		[Token(Token = "0x40055BA")]
		[FieldOffset(Offset = "0x40")]
		public bool isDaily;

		// Token: 0x040055BB RID: 21947
		[Token(Token = "0x40055BB")]
		[FieldOffset(Offset = "0x44")]
		public int dimension;

		// Token: 0x040055BC RID: 21948
		[Token(Token = "0x40055BC")]
		[FieldOffset(Offset = "0x48")]
		public string previewTitle;

		// Token: 0x040055BD RID: 21949
		[Token(Token = "0x40055BD")]
		[FieldOffset(Offset = "0x50")]
		public string previewDesc;

		// Token: 0x040055BE RID: 21950
		[Token(Token = "0x40055BE")]
		[FieldOffset(Offset = "0x58")]
		public int rewardScore;

		// Token: 0x040055BF RID: 21951
		[Token(Token = "0x40055BF")]
		[FieldOffset(Offset = "0x5C")]
		public int sortId;

		// Token: 0x040055C0 RID: 21952
		[Token(Token = "0x40055C0")]
		[FieldOffset(Offset = "0x60")]
		public int missionSortId;

		// Token: 0x040055C1 RID: 21953
		[Token(Token = "0x40055C1")]
		[FieldOffset(Offset = "0x68")]
		public List<ItemBundle> slotPackRewards;
	}
}
