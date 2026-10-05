using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x02007778 RID: 30584
	[Token(Token = "0x2007778")]
	public class Act1VHalfidlePlotViewModel : IComparable<Act1VHalfidlePlotViewModel>, IHotfixable
	{
		// Token: 0x170064B8 RID: 25784
		// (get) Token: 0x0602AF58 RID: 175960 RVA: 0x000DA838 File Offset: 0x000D8A38
		[Token(Token = "0x170064B8")]
		public bool isEmpty
		{
			[Token(Token = "0x602AF58")]
			[Address(RVA = "0x26D6BB0", Offset = "0x26D57B0", VA = "0x1826D6BB0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0602AF59 RID: 175961 RVA: 0x000DA850 File Offset: 0x000D8A50
		[Token(Token = "0x602AF59")]
		[Address(RVA = "0x26D67B0", Offset = "0x26D53B0", VA = "0x1826D67B0", Slot = "4")]
		public int CompareTo(Act1VHalfidlePlotViewModel other)
		{
			return 0;
		}

		// Token: 0x0602AF5A RID: 175962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AF5A")]
		[Address(RVA = "0x26D6940", Offset = "0x26D5540", VA = "0x1826D6940")]
		public Act1VHalfidlePlotViewModel(string actId, Act1VHalfIdlePlotData data, bool glow = false)
		{
		}

		// Token: 0x0403DFC3 RID: 253891
		[Token(Token = "0x403DFC3")]
		[FieldOffset(Offset = "0x10")]
		public string actId;

		// Token: 0x0403DFC4 RID: 253892
		[Token(Token = "0x403DFC4")]
		[FieldOffset(Offset = "0x18")]
		public Act1VHalfIdlePlotData data;

		// Token: 0x0403DFC5 RID: 253893
		[Token(Token = "0x403DFC5")]
		[FieldOffset(Offset = "0x20")]
		public List<Act1VHalfidlePlotViewModel> deriveList;

		// Token: 0x0403DFC6 RID: 253894
		[Token(Token = "0x403DFC6")]
		[FieldOffset(Offset = "0x28")]
		public bool isLocked;

		// Token: 0x0403DFC7 RID: 253895
		[Token(Token = "0x403DFC7")]
		[FieldOffset(Offset = "0x29")]
		public bool selected;

		// Token: 0x0403DFC8 RID: 253896
		[Token(Token = "0x403DFC8")]
		[FieldOffset(Offset = "0x2C")]
		public int selectedOrder;

		// Token: 0x0403DFC9 RID: 253897
		[Token(Token = "0x403DFC9")]
		[FieldOffset(Offset = "0x30")]
		public bool glowItem;

		// Token: 0x0403DFCA RID: 253898
		[Token(Token = "0x403DFCA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isEmpty;

		// Token: 0x0403DFCB RID: 253899
		[Token(Token = "0x403DFCB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CompareTo;

		// Token: 0x0403DFCC RID: 253900
		[Token(Token = "0x403DFCC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
