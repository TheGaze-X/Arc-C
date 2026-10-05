using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x0200101F RID: 4127
	[Token(Token = "0x200101F")]
	public class ArtGalleryCollectItemData
	{
		// Token: 0x06006D71 RID: 28017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D71")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ArtGalleryCollectItemData()
		{
		}

		// Token: 0x040057A8 RID: 22440
		[Token(Token = "0x40057A8")]
		[FieldOffset(Offset = "0x10")]
		public string itemId;

		// Token: 0x040057A9 RID: 22441
		[Token(Token = "0x40057A9")]
		[FieldOffset(Offset = "0x18")]
		[JsonConverter(typeof(StringEnumConverter))]
		public ItemType itemType;

		// Token: 0x040057AA RID: 22442
		[Token(Token = "0x40057AA")]
		[FieldOffset(Offset = "0x20")]
		public string collectionSetId;

		// Token: 0x040057AB RID: 22443
		[Token(Token = "0x40057AB")]
		[FieldOffset(Offset = "0x28")]
		public int sortId;
	}
}
