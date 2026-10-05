using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000F4C RID: 3916
	[Token(Token = "0x2000F4C")]
	[Serializable]
	public class CGGalleryDisplayData
	{
		// Token: 0x06006C58 RID: 27736 RVA: 0x000316E0 File Offset: 0x0002F8E0
		[Token(Token = "0x6006C58")]
		[Address(RVA = "0x20077F0", Offset = "0x20063F0", VA = "0x1820077F0")]
		public bool ShouldSerializerelatedStoryId()
		{
			return default(bool);
		}

		// Token: 0x06006C59 RID: 27737 RVA: 0x000316F8 File Offset: 0x0002F8F8
		[Token(Token = "0x6006C59")]
		[Address(RVA = "0x1FF9C20", Offset = "0x1FF8820", VA = "0x181FF9C20")]
		public bool ShouldSerializerelatedStageId()
		{
			return default(bool);
		}

		// Token: 0x06006C5A RID: 27738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C5A")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public CGGalleryDisplayData()
		{
		}

		// Token: 0x04005343 RID: 21315
		[Token(Token = "0x4005343")]
		[FieldOffset(Offset = "0x10")]
		public string displayId;

		// Token: 0x04005344 RID: 21316
		[Token(Token = "0x4005344")]
		[FieldOffset(Offset = "0x18")]
		public List<string> cgList;

		// Token: 0x04005345 RID: 21317
		[Token(Token = "0x4005345")]
		[FieldOffset(Offset = "0x20")]
		public CGGalleryCGSource cgSource;

		// Token: 0x04005346 RID: 21318
		[Token(Token = "0x4005346")]
		[FieldOffset(Offset = "0x28")]
		public string displayName;

		// Token: 0x04005347 RID: 21319
		[Token(Token = "0x4005347")]
		[FieldOffset(Offset = "0x30")]
		public string displayDesc;

		// Token: 0x04005348 RID: 21320
		[Token(Token = "0x4005348")]
		[FieldOffset(Offset = "0x38")]
		public string storySetId;

		// Token: 0x04005349 RID: 21321
		[Token(Token = "0x4005349")]
		[FieldOffset(Offset = "0x40")]
		public int sortId;

		// Token: 0x0400534A RID: 21322
		[Token(Token = "0x400534A")]
		[FieldOffset(Offset = "0x48")]
		public string relatedStoryId;

		// Token: 0x0400534B RID: 21323
		[Token(Token = "0x400534B")]
		[FieldOffset(Offset = "0x50")]
		public string relatedStageId;
	}
}
