using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000F4B RID: 3915
	[Token(Token = "0x2000F4B")]
	[Serializable]
	public class CGGalleryGroupData
	{
		// Token: 0x06006C57 RID: 27735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C57")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public CGGalleryGroupData()
		{
		}

		// Token: 0x0400533F RID: 21311
		[Token(Token = "0x400533F")]
		[FieldOffset(Offset = "0x10")]
		public string storySetId;

		// Token: 0x04005340 RID: 21312
		[Token(Token = "0x4005340")]
		[FieldOffset(Offset = "0x18")]
		public string storylineId;

		// Token: 0x04005341 RID: 21313
		[Token(Token = "0x4005341")]
		[FieldOffset(Offset = "0x20")]
		public string locationId;

		// Token: 0x04005342 RID: 21314
		[Token(Token = "0x4005342")]
		[FieldOffset(Offset = "0x28")]
		public List<string> displays;
	}
}
