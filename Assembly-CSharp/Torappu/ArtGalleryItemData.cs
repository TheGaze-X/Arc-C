using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu
{
	// Token: 0x02000FE5 RID: 4069
	[Token(Token = "0x2000FE5")]
	public class ArtGalleryItemData : IHotfixable, IComparable<ArtGalleryItemData>
	{
		// Token: 0x06006D3A RID: 27962 RVA: 0x00031BD8 File Offset: 0x0002FDD8
		[Token(Token = "0x6006D3A")]
		[Address(RVA = "0x20FEC70", Offset = "0x20FD870", VA = "0x1820FEC70", Slot = "4")]
		public int CompareTo(ArtGalleryItemData other)
		{
			return 0;
		}

		// Token: 0x06006D3B RID: 27963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D3B")]
		[Address(RVA = "0x20FECF0", Offset = "0x20FD8F0", VA = "0x1820FECF0")]
		public ArtGalleryItemData()
		{
		}

		// Token: 0x04005641 RID: 22081
		[Token(Token = "0x4005641")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x04005642 RID: 22082
		[Token(Token = "0x4005642")]
		[FieldOffset(Offset = "0x18")]
		public string groupType;

		// Token: 0x04005643 RID: 22083
		[Token(Token = "0x4005643")]
		[FieldOffset(Offset = "0x20")]
		public int sortId;

		// Token: 0x04005644 RID: 22084
		[Token(Token = "0x4005644")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CompareTo;

		// Token: 0x04005645 RID: 22085
		[Token(Token = "0x4005645")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
