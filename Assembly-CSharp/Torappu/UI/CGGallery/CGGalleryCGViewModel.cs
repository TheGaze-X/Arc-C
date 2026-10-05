using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.CGGallery
{
	// Token: 0x02005FF1 RID: 24561
	[Token(Token = "0x2005FF1")]
	public class CGGalleryCGViewModel : IHotfixable, IComparable<CGGalleryCGViewModel>
	{
		// Token: 0x06023818 RID: 145432 RVA: 0x000C11E8 File Offset: 0x000BF3E8
		[Token(Token = "0x6023818")]
		[Address(RVA = "0x1E142A0", Offset = "0x1E12EA0", VA = "0x181E142A0", Slot = "4")]
		public int CompareTo(CGGalleryCGViewModel other)
		{
			return 0;
		}

		// Token: 0x06023819 RID: 145433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023819")]
		[Address(RVA = "0x1E14340", Offset = "0x1E12F40", VA = "0x181E14340")]
		public CGGalleryCGViewModel()
		{
		}

		// Token: 0x040311E0 RID: 201184
		[Token(Token = "0x40311E0")]
		[FieldOffset(Offset = "0x10")]
		public string cgId;

		// Token: 0x040311E1 RID: 201185
		[Token(Token = "0x40311E1")]
		[FieldOffset(Offset = "0x18")]
		public int sortId;

		// Token: 0x040311E2 RID: 201186
		[Token(Token = "0x40311E2")]
		[FieldOffset(Offset = "0x1C")]
		public CGGalleryCGSource source;

		// Token: 0x040311E3 RID: 201187
		[Token(Token = "0x40311E3")]
		[FieldOffset(Offset = "0x20")]
		public CGGalleryCGCompositeType compositeType;

		// Token: 0x040311E4 RID: 201188
		[Token(Token = "0x40311E4")]
		[FieldOffset(Offset = "0x28")]
		public List<CGGalleryCGCompositeViewModel> compositeList;

		// Token: 0x040311E5 RID: 201189
		[Token(Token = "0x40311E5")]
		[FieldOffset(Offset = "0x30")]
		public bool favourite;

		// Token: 0x040311E6 RID: 201190
		[Token(Token = "0x40311E6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CompareTo;

		// Token: 0x040311E7 RID: 201191
		[Token(Token = "0x40311E7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
