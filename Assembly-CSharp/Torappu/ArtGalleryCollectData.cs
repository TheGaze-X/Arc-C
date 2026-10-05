using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200101B RID: 4123
	[Token(Token = "0x200101B")]
	public class ArtGalleryCollectData
	{
		// Token: 0x06006D6E RID: 28014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D6E")]
		[Address(RVA = "0x20FE840", Offset = "0x20FD440", VA = "0x1820FE840")]
		public ArtGalleryCollectData()
		{
		}

		// Token: 0x04005790 RID: 22416
		[Token(Token = "0x4005790")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, ArtGalleryCollectSetData> collectionSets;

		// Token: 0x04005791 RID: 22417
		[Token(Token = "0x4005791")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, ArtGalleryCollectTypeData> collectionTypes;

		// Token: 0x04005792 RID: 22418
		[Token(Token = "0x4005792")]
		[FieldOffset(Offset = "0x20")]
		public ArtGalleryCollectConstData constData;
	}
}
