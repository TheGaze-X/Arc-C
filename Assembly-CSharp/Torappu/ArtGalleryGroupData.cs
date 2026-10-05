using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu
{
	// Token: 0x02000FE6 RID: 4070
	[Token(Token = "0x2000FE6")]
	public class ArtGalleryGroupData : IHotfixable, IComparable<ArtGalleryGroupData>
	{
		// Token: 0x06006D3C RID: 27964 RVA: 0x00031BF0 File Offset: 0x0002FDF0
		[Token(Token = "0x6006D3C")]
		[Address(RVA = "0x20FEB40", Offset = "0x20FD740", VA = "0x1820FEB40", Slot = "4")]
		public int CompareTo(ArtGalleryGroupData other)
		{
			return 0;
		}

		// Token: 0x06006D3D RID: 27965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D3D")]
		[Address(RVA = "0x20FEBC0", Offset = "0x20FD7C0", VA = "0x1820FEBC0")]
		public ArtGalleryGroupData()
		{
		}

		// Token: 0x04005646 RID: 22086
		[Token(Token = "0x4005646")]
		[FieldOffset(Offset = "0x10")]
		public string type;

		// Token: 0x04005647 RID: 22087
		[Token(Token = "0x4005647")]
		[FieldOffset(Offset = "0x18")]
		public string title;

		// Token: 0x04005648 RID: 22088
		[Token(Token = "0x4005648")]
		[FieldOffset(Offset = "0x20")]
		public int sortId;

		// Token: 0x04005649 RID: 22089
		[Token(Token = "0x4005649")]
		[FieldOffset(Offset = "0x28")]
		public List<ArtGalleryItemData> items;

		// Token: 0x0400564A RID: 22090
		[Token(Token = "0x400564A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CompareTo;

		// Token: 0x0400564B RID: 22091
		[Token(Token = "0x400564B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
