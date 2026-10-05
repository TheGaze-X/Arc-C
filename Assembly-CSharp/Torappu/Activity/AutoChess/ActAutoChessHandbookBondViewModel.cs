using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.AutoChess
{
	// Token: 0x02007107 RID: 28935
	[Token(Token = "0x2007107")]
	public class ActAutoChessHandbookBondViewModel : ActAutoChessHandbookItemModelBase, IComparable
	{
		// Token: 0x060291E0 RID: 168416 RVA: 0x000D4850 File Offset: 0x000D2A50
		[Token(Token = "0x60291E0")]
		[Address(RVA = "0x2483570", Offset = "0x2482170", VA = "0x182483570", Slot = "4")]
		public int CompareTo(object obj)
		{
			return 0;
		}

		// Token: 0x060291E1 RID: 168417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60291E1")]
		[Address(RVA = "0x24836F0", Offset = "0x24822F0", VA = "0x1824836F0")]
		public ActAutoChessHandbookBondViewModel()
		{
		}

		// Token: 0x0403AB31 RID: 240433
		[Token(Token = "0x403AB31")]
		[FieldOffset(Offset = "0x20")]
		public AutoChessBondType bondType;

		// Token: 0x0403AB32 RID: 240434
		[Token(Token = "0x403AB32")]
		[FieldOffset(Offset = "0x28")]
		public string iconId;

		// Token: 0x0403AB33 RID: 240435
		[Token(Token = "0x403AB33")]
		[FieldOffset(Offset = "0x30")]
		public string name;

		// Token: 0x0403AB34 RID: 240436
		[Token(Token = "0x403AB34")]
		[FieldOffset(Offset = "0x38")]
		public int activeCount;

		// Token: 0x0403AB35 RID: 240437
		[Token(Token = "0x403AB35")]
		[FieldOffset(Offset = "0x40")]
		public string desc;

		// Token: 0x0403AB36 RID: 240438
		[Token(Token = "0x403AB36")]
		[FieldOffset(Offset = "0x48")]
		public int sortId;

		// Token: 0x0403AB37 RID: 240439
		[Token(Token = "0x403AB37")]
		[FieldOffset(Offset = "0x4C")]
		public bool shouldHideChar;

		// Token: 0x0403AB38 RID: 240440
		[Token(Token = "0x403AB38")]
		[FieldOffset(Offset = "0x50")]
		public List<ActAutoChessHandbookChessViewModel> chessList;

		// Token: 0x0403AB39 RID: 240441
		[Token(Token = "0x403AB39")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CompareTo;

		// Token: 0x0403AB3A RID: 240442
		[Token(Token = "0x403AB3A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
