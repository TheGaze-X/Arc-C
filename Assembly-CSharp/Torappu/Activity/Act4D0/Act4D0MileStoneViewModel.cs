using System;
using Il2CppDummyDll;

namespace Torappu.Activity.Act4D0
{
	// Token: 0x0200728F RID: 29327
	[Token(Token = "0x200728F")]
	public class Act4D0MileStoneViewModel : IComparable<Act4D0MileStoneViewModel>
	{
		// Token: 0x06029884 RID: 170116 RVA: 0x000D5DC8 File Offset: 0x000D3FC8
		[Token(Token = "0x6029884")]
		[Address(RVA = "0x173B1B0", Offset = "0x1739DB0", VA = "0x18173B1B0", Slot = "4")]
		public int CompareTo(Act4D0MileStoneViewModel other)
		{
			return 0;
		}

		// Token: 0x06029885 RID: 170117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029885")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Act4D0MileStoneViewModel()
		{
		}

		// Token: 0x0403B598 RID: 243096
		[Token(Token = "0x403B598")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x0403B599 RID: 243097
		[Token(Token = "0x403B599")]
		[FieldOffset(Offset = "0x18")]
		public Act4D0MileStoneViewModel.State state;

		// Token: 0x0403B59A RID: 243098
		[Token(Token = "0x403B59A")]
		[FieldOffset(Offset = "0x1C")]
		public Act4D0MileStoneViewModel.Type type;

		// Token: 0x0403B59B RID: 243099
		[Token(Token = "0x403B59B")]
		[FieldOffset(Offset = "0x20")]
		public int count;

		// Token: 0x0403B59C RID: 243100
		[Token(Token = "0x403B59C")]
		[FieldOffset(Offset = "0x28")]
		public ItemBundle rewardItem;

		// Token: 0x0403B59D RID: 243101
		[Token(Token = "0x403B59D")]
		[FieldOffset(Offset = "0x30")]
		public int orderId;

		// Token: 0x0403B59E RID: 243102
		[Token(Token = "0x403B59E")]
		[FieldOffset(Offset = "0x38")]
		public string storyKey;

		// Token: 0x02007290 RID: 29328
		[Token(Token = "0x2007290")]
		public enum State
		{
			// Token: 0x0403B5A0 RID: 243104
			[Token(Token = "0x403B5A0")]
			FINISH,
			// Token: 0x0403B5A1 RID: 243105
			[Token(Token = "0x403B5A1")]
			AVAIL,
			// Token: 0x0403B5A2 RID: 243106
			[Token(Token = "0x403B5A2")]
			NOTAVAIL
		}

		// Token: 0x02007291 RID: 29329
		[Token(Token = "0x2007291")]
		public enum Type
		{
			// Token: 0x0403B5A4 RID: 243108
			[Token(Token = "0x403B5A4")]
			STORY,
			// Token: 0x0403B5A5 RID: 243109
			[Token(Token = "0x403B5A5")]
			ITEM
		}
	}
}
