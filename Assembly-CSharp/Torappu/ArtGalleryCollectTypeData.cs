using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200101E RID: 4126
	[Token(Token = "0x200101E")]
	public class ArtGalleryCollectTypeData
	{
		// Token: 0x06006D70 RID: 28016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D70")]
		[Address(RVA = "0x20FEAB0", Offset = "0x20FD6B0", VA = "0x1820FEAB0")]
		public ArtGalleryCollectTypeData()
		{
		}

		// Token: 0x040057A0 RID: 22432
		[Token(Token = "0x40057A0")]
		[FieldOffset(Offset = "0x10")]
		public CollectType setType;

		// Token: 0x040057A1 RID: 22433
		[Token(Token = "0x40057A1")]
		[FieldOffset(Offset = "0x18")]
		public string typeName;

		// Token: 0x040057A2 RID: 22434
		[Token(Token = "0x40057A2")]
		[FieldOffset(Offset = "0x20")]
		public string typeEngNameFilterPic;

		// Token: 0x040057A3 RID: 22435
		[Token(Token = "0x40057A3")]
		[FieldOffset(Offset = "0x28")]
		public string typeEngNamePic;

		// Token: 0x040057A4 RID: 22436
		[Token(Token = "0x40057A4")]
		[FieldOffset(Offset = "0x30")]
		public string typeFilterSelectIcon;

		// Token: 0x040057A5 RID: 22437
		[Token(Token = "0x40057A5")]
		[FieldOffset(Offset = "0x38")]
		public string typeFilterUnselectIcon;

		// Token: 0x040057A6 RID: 22438
		[Token(Token = "0x40057A6")]
		[FieldOffset(Offset = "0x40")]
		public List<string> setIdList;

		// Token: 0x040057A7 RID: 22439
		[Token(Token = "0x40057A7")]
		[FieldOffset(Offset = "0x48")]
		public int sortId;
	}
}
