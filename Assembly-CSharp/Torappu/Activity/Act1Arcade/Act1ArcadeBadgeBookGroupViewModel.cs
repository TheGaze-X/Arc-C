using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act1Arcade
{
	// Token: 0x0200793D RID: 31037
	[Token(Token = "0x200793D")]
	public class Act1ArcadeBadgeBookGroupViewModel : IComparable<Act1ArcadeBadgeBookGroupViewModel>, IHotfixable
	{
		// Token: 0x0602B8B3 RID: 178355 RVA: 0x000DC680 File Offset: 0x000DA880
		[Token(Token = "0x602B8B3")]
		[Address(RVA = "0x2768C60", Offset = "0x2767860", VA = "0x182768C60", Slot = "4")]
		public int CompareTo(Act1ArcadeBadgeBookGroupViewModel other)
		{
			return 0;
		}

		// Token: 0x0602B8B4 RID: 178356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B8B4")]
		[Address(RVA = "0x2768D40", Offset = "0x2767940", VA = "0x182768D40")]
		public Act1ArcadeBadgeBookGroupViewModel()
		{
		}

		// Token: 0x0403EFB1 RID: 257969
		[Token(Token = "0x403EFB1")]
		[FieldOffset(Offset = "0x10")]
		public ActArcadeData.BadgeType badgeType;

		// Token: 0x0403EFB2 RID: 257970
		[Token(Token = "0x403EFB2")]
		[FieldOffset(Offset = "0x14")]
		public int sortId;

		// Token: 0x0403EFB3 RID: 257971
		[Token(Token = "0x403EFB3")]
		[FieldOffset(Offset = "0x18")]
		public string name;

		// Token: 0x0403EFB4 RID: 257972
		[Token(Token = "0x403EFB4")]
		[FieldOffset(Offset = "0x20")]
		public string desc;

		// Token: 0x0403EFB5 RID: 257973
		[Token(Token = "0x403EFB5")]
		[FieldOffset(Offset = "0x28")]
		public List<Act1ArcadeBadgeBookItemViewModel> items;

		// Token: 0x0403EFB6 RID: 257974
		[Token(Token = "0x403EFB6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CompareTo;

		// Token: 0x0403EFB7 RID: 257975
		[Token(Token = "0x403EFB7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
