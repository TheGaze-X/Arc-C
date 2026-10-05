using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200101D RID: 4125
	[Token(Token = "0x200101D")]
	public class ArtGalleryCollectSetData
	{
		// Token: 0x06006D6F RID: 28015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D6F")]
		[Address(RVA = "0x20FE950", Offset = "0x20FD550", VA = "0x1820FE950")]
		public ArtGalleryCollectSetData()
		{
		}

		// Token: 0x04005797 RID: 22423
		[Token(Token = "0x4005797")]
		[FieldOffset(Offset = "0x10")]
		public string setId;

		// Token: 0x04005798 RID: 22424
		[Token(Token = "0x4005798")]
		[FieldOffset(Offset = "0x18")]
		public string setName;

		// Token: 0x04005799 RID: 22425
		[Token(Token = "0x4005799")]
		[FieldOffset(Offset = "0x20")]
		public CollectType setType;

		// Token: 0x0400579A RID: 22426
		[Token(Token = "0x400579A")]
		[FieldOffset(Offset = "0x24")]
		public int sortId;

		// Token: 0x0400579B RID: 22427
		[Token(Token = "0x400579B")]
		[FieldOffset(Offset = "0x28")]
		public long startTime;

		// Token: 0x0400579C RID: 22428
		[Token(Token = "0x400579C")]
		[FieldOffset(Offset = "0x30")]
		public long completeTime;

		// Token: 0x0400579D RID: 22429
		[Token(Token = "0x400579D")]
		[FieldOffset(Offset = "0x38")]
		public List<ArtGalleryCollectItemData> items;

		// Token: 0x0400579E RID: 22430
		[Token(Token = "0x400579E")]
		[FieldOffset(Offset = "0x40")]
		public int displayMaxCount;

		// Token: 0x0400579F RID: 22431
		[Token(Token = "0x400579F")]
		[FieldOffset(Offset = "0x48")]
		public ListDict<string, ArtGalleryCollectSetMissionData> missionList;
	}
}
