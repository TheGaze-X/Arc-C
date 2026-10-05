using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000F4F RID: 3919
	[Token(Token = "0x2000F4F")]
	[Serializable]
	public class CGGalleryCGData
	{
		// Token: 0x06006C5B RID: 27739 RVA: 0x00031710 File Offset: 0x0002F910
		[Token(Token = "0x6006C5B")]
		[Address(RVA = "0x1FF9BE0", Offset = "0x1FF87E0", VA = "0x181FF9BE0")]
		public bool ShouldSerializecompositeType()
		{
			return default(bool);
		}

		// Token: 0x06006C5C RID: 27740 RVA: 0x00031728 File Offset: 0x0002F928
		[Token(Token = "0x6006C5C")]
		[Address(RVA = "0x1FF9BE0", Offset = "0x1FF87E0", VA = "0x181FF9BE0")]
		public bool ShouldSerializecompositeList()
		{
			return default(bool);
		}

		// Token: 0x06006C5D RID: 27741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C5D")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public CGGalleryCGData()
		{
		}

		// Token: 0x04005355 RID: 21333
		[Token(Token = "0x4005355")]
		[FieldOffset(Offset = "0x10")]
		public string cgId;

		// Token: 0x04005356 RID: 21334
		[Token(Token = "0x4005356")]
		[FieldOffset(Offset = "0x18")]
		public int sortId;

		// Token: 0x04005357 RID: 21335
		[Token(Token = "0x4005357")]
		[FieldOffset(Offset = "0x1C")]
		public CGGalleryCGCompositeType compositeType;

		// Token: 0x04005358 RID: 21336
		[Token(Token = "0x4005358")]
		[FieldOffset(Offset = "0x20")]
		public List<CGGalleryCGCompositeData> compositeList;

		// Token: 0x04005359 RID: 21337
		[Token(Token = "0x4005359")]
		[FieldOffset(Offset = "0x28")]
		public string storySetId;
	}
}
