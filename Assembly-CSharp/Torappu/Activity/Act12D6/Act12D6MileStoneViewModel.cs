using System;
using Il2CppDummyDll;

namespace Torappu.Activity.Act12D6
{
	// Token: 0x02007B0A RID: 31498
	[Token(Token = "0x2007B0A")]
	public class Act12D6MileStoneViewModel : IComparable<Act12D6MileStoneViewModel>
	{
		// Token: 0x0602C1A0 RID: 180640 RVA: 0x000DE1C8 File Offset: 0x000DC3C8
		[Token(Token = "0x602C1A0")]
		[Address(RVA = "0x209C490", Offset = "0x209B090", VA = "0x18209C490", Slot = "4")]
		public int CompareTo(Act12D6MileStoneViewModel other)
		{
			return 0;
		}

		// Token: 0x0602C1A1 RID: 180641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C1A1")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Act12D6MileStoneViewModel()
		{
		}

		// Token: 0x0403FEFB RID: 261883
		[Token(Token = "0x403FEFB")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x0403FEFC RID: 261884
		[Token(Token = "0x403FEFC")]
		[FieldOffset(Offset = "0x18")]
		public Act12D6MileStoneViewModel.State state;

		// Token: 0x0403FEFD RID: 261885
		[Token(Token = "0x403FEFD")]
		[FieldOffset(Offset = "0x1C")]
		public int count;

		// Token: 0x0403FEFE RID: 261886
		[Token(Token = "0x403FEFE")]
		[FieldOffset(Offset = "0x20")]
		public ItemBundle rewardItem;

		// Token: 0x0403FEFF RID: 261887
		[Token(Token = "0x403FEFF")]
		[FieldOffset(Offset = "0x28")]
		public int orderId;

		// Token: 0x02007B0B RID: 31499
		[Token(Token = "0x2007B0B")]
		public enum State
		{
			// Token: 0x0403FF01 RID: 261889
			[Token(Token = "0x403FF01")]
			FINISH,
			// Token: 0x0403FF02 RID: 261890
			[Token(Token = "0x403FF02")]
			AVAIL,
			// Token: 0x0403FF03 RID: 261891
			[Token(Token = "0x403FF03")]
			NOTAVAIL
		}
	}
}
